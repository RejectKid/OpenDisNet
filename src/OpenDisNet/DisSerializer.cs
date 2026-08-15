using System.Buffers;
using OpenDisNet.Binary;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet;

/// <summary>Serializes and deserializes Distributed Interactive Simulation PDUs.</summary>
public static class DisSerializer
{
    /// <summary>Attempts to inspect a DIS header without decoding its PDU body.</summary>
    public static bool TryReadHeader(ReadOnlySpan<byte> source, out DisHeader header, out DisParseError error)
    {
        header = default;
        error = default;

        if (source.Length < 4)
            return Fail(DisParseErrorCode.TruncatedHeader, "A DIS header requires at least 4 bytes to identify its layout.", source.Length, out error);

        int requiredHeaderSize = RequiredHeaderSize(source[3]);
        if (source.Length < requiredHeaderSize)
            return Fail(DisParseErrorCode.TruncatedHeader, $"This DIS header requires {requiredHeaderSize} bytes.", source.Length, out error);

        try
        {
            var reader = new DisBinaryReader(source[..requiredHeaderSize]);
            header = DisHeaderCodec.Read(ref reader);
            if (header.Length < requiredHeaderSize)
                return Fail(DisParseErrorCode.InvalidLength, $"Invalid PDU length {header.Length}.", 8, out error);
            return true;
        }
        catch (DisParseException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, exception.Offset, out error);
        }
    }

    /// <summary>Attempts to inspect a possibly segmented DIS header without decoding its PDU body.</summary>
    public static bool TryReadHeader(ReadOnlySequence<byte> source, out DisHeader header, out DisParseError error)
    {
        int available = (int)Math.Min(source.Length, DisHeader.Size);
        if (source.IsSingleSegment)
            return TryReadHeader(source.FirstSpan[..available], out header, out error);

        Span<byte> headerBytes = stackalloc byte[DisHeader.Size];
        source.Slice(0, available).CopyTo(headerBytes);
        return TryReadHeader(headerBytes[..available], out header, out error);
    }

    /// <summary>Attempts to read the first complete DIS PDU from a buffer.</summary>
    public static DisReadStatus TryRead(
        ReadOnlySpan<byte> source,
        out IDisPdu? pdu,
        out int bytesConsumed,
        out DisParseError error) =>
        TryRead(source, out pdu, out bytesConsumed, out error, null);

    /// <summary>Attempts to read the first complete DIS PDU from a buffer with explicit parse options.</summary>
    public static DisReadStatus TryRead(
        ReadOnlySpan<byte> source,
        out IDisPdu? pdu,
        out int bytesConsumed,
        out DisParseError error,
        DisParseOptions? options)
    {
        pdu = null;
        bytesConsumed = 0;
        if (!TryReadHeader(source, out DisHeader header, out error))
            return error.Code == DisParseErrorCode.TruncatedHeader ? DisReadStatus.NeedMoreData : DisReadStatus.InvalidData;

        options ??= DisParseOptions.Default;
        if (header.Length > options.MaximumPduLength)
        {
            Fail(DisParseErrorCode.InvalidLength, $"Invalid PDU length {header.Length}.", 8, out error);
            return DisReadStatus.InvalidData;
        }

        if (source.Length < header.Length)
        {
            Fail(DisParseErrorCode.TruncatedPdu, $"The header declares {header.Length} bytes; only {source.Length} were received.", source.Length, out error);
            return DisReadStatus.NeedMoreData;
        }

        DisParseOptions framedOptions = options with { RequireExactDatagramLength = true };
        if (!TryDeserialize(source[..header.Length], out pdu, out error, framedOptions))
            return DisReadStatus.InvalidData;

        bytesConsumed = header.Length;
        return DisReadStatus.Done;
    }

    /// <summary>Attempts to read the first complete DIS PDU from a possibly segmented buffer.</summary>
    public static DisReadStatus TryRead(
        ReadOnlySequence<byte> source,
        out IDisPdu? pdu,
        out int bytesConsumed,
        out DisParseError error) =>
        TryRead(source, out pdu, out bytesConsumed, out error, null);

    /// <summary>Attempts to read the first complete DIS PDU from a possibly segmented buffer with explicit parse options.</summary>
    public static DisReadStatus TryRead(
        ReadOnlySequence<byte> source,
        out IDisPdu? pdu,
        out int bytesConsumed,
        out DisParseError error,
        DisParseOptions? options)
    {
        pdu = null;
        bytesConsumed = 0;
        if (!TryReadHeader(source, out DisHeader header, out error))
            return error.Code == DisParseErrorCode.TruncatedHeader ? DisReadStatus.NeedMoreData : DisReadStatus.InvalidData;

        options ??= DisParseOptions.Default;
        if (header.Length > options.MaximumPduLength)
        {
            Fail(DisParseErrorCode.InvalidLength, $"Invalid PDU length {header.Length}.", 8, out error);
            return DisReadStatus.InvalidData;
        }

        if (source.Length < header.Length)
        {
            Fail(DisParseErrorCode.TruncatedPdu, $"The header declares {header.Length} bytes; only {source.Length} were received.", (int)Math.Min(source.Length, int.MaxValue), out error);
            return DisReadStatus.NeedMoreData;
        }

        ReadOnlySequence<byte> frame = source.Slice(0, header.Length);
        if (frame.IsSingleSegment)
            return TryRead(frame.FirstSpan, out pdu, out bytesConsumed, out error, options);

        byte[] contiguousFrame = frame.ToArray();
        return TryRead(contiguousFrame, out pdu, out bytesConsumed, out error, options);
    }

    /// <summary>Deserializes one complete DIS datagram and requires the specified PDU type.</summary>
    public static TPdu Deserialize<TPdu>(ReadOnlySpan<byte> datagram, DisParseOptions? options = null)
        where TPdu : class, IDisPdu
    {
        if (TryDeserialize(datagram, out TPdu? pdu, out DisParseError error, options))
            return pdu!;
        throw new FormatException(error.Message);
    }

    /// <summary>Attempts to deserialize one complete DIS datagram as the specified PDU type.</summary>
    public static bool TryDeserialize<TPdu>(ReadOnlySpan<byte> datagram, out TPdu? pdu, out DisParseError error, DisParseOptions? options = null)
        where TPdu : class, IDisPdu
    {
        pdu = null;
        if (!TryDeserialize(datagram, out IDisPdu? parsed, out error, options))
            return false;
        if (parsed is TPdu typed)
        {
            pdu = typed;
            return true;
        }
        return Fail(DisParseErrorCode.UnexpectedPduType,
            $"Expected {typeof(TPdu).Name}; received {parsed!.GetType().Name} ({parsed.Header.PduType}).", 2, out error);
    }

    /// <summary>Deserializes one complete DIS datagram.</summary>
    public static IDisPdu Deserialize(ReadOnlySpan<byte> datagram, DisParseOptions? options = null)
    {
        if (TryDeserialize(datagram, out IDisPdu? pdu, out DisParseError error, options))
            return pdu!;
        throw new FormatException(error.Message);
    }

    /// <summary>Attempts to deserialize one complete DIS datagram without throwing for invalid input.</summary>
    public static bool TryDeserialize(
        ReadOnlySpan<byte> datagram,
        out IDisPdu? pdu,
        out DisParseError error,
        DisParseOptions? options = null)
    {
        options ??= DisParseOptions.Default;
        pdu = null;
        error = default;

        if (!TryReadHeader(datagram, out DisHeader header, out error))
            return false;

        try
        {
            int headerSize = header.EncodedSize;

            if (options.RequireVersion7 && header.ProtocolVersion != DisProtocolVersion.Ieee1278_1_2012)
                return Fail(DisParseErrorCode.UnsupportedProtocolVersion, $"Expected DIS protocol version 7; received {(byte)header.ProtocolVersion}.", 0, out error);
            if (header.Length < headerSize || header.Length > options.MaximumPduLength)
                return Fail(DisParseErrorCode.InvalidLength, $"Invalid PDU length {header.Length}.", 8, out error);
            if (header.Length > datagram.Length)
                return Fail(DisParseErrorCode.TruncatedPdu, $"The header declares {header.Length} bytes; only {datagram.Length} were received.", datagram.Length, out error);
            if (options.RequireExactDatagramLength && header.Length != datagram.Length)
                return Fail(DisParseErrorCode.TrailingData, $"The datagram contains {datagram.Length - header.Length} trailing bytes.", header.Length, out error);

            ReadOnlySpan<byte> body = datagram.Slice(headerSize, header.Length - headerSize);
            pdu = header.ProtocolVersion == DisProtocolVersion.Ieee1278_1_2012
                ? PduRegistry.Parse(header, body)
                : new UnknownPdu(header, body.ToArray());
            return true;
        }
        catch (DisParseException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, exception.Offset, out error);
        }
        catch (FormatException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, DisHeader.MinimumSize, out error);
        }
        catch (OverflowException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, DisHeader.MinimumSize, out error);
        }
    }

    /// <summary>Returns the number of octets required to serialize a PDU.</summary>
    public static int GetSerializedLength(IDisPdu pdu)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        return PduRegistry.GetLength(pdu);
    }

    /// <summary>Serializes a PDU into a newly allocated datagram.</summary>
    public static byte[] Serialize(IDisPdu pdu)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        byte[] bytes = new byte[GetSerializedLength(pdu)];
        Serialize(pdu, bytes);
        return bytes;
    }

    /// <summary>Serializes a PDU into caller-owned storage and returns the octets written.</summary>
    public static int Serialize(IDisPdu pdu, Span<byte> destination)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        if (pdu is Pdu typed)
            return PduCodec.Write(typed, destination);

        int length = GetSerializedLength(pdu);
        if (length > ushort.MaxValue) throw new ArgumentOutOfRangeException(nameof(pdu), "A DIS PDU cannot exceed 65,535 bytes.");
        if (destination.Length < length) throw new ArgumentException($"Destination requires {length} bytes.", nameof(destination));

        DisHeader header = pdu.Header with { Length = (ushort)length };
        var writer = new DisBinaryWriter(destination[..length]);
        DisHeaderCodec.Write(ref writer, header);
        PduRegistry.WriteBody(pdu, ref writer);
        return writer.Offset;
    }

    private static bool Fail(DisParseErrorCode code, string message, int offset, out DisParseError error)
    {
        error = new(code, message, offset);
        return false;
    }

    private static int RequiredHeaderSize(byte protocolFamily) =>
        protocolFamily == (byte)ProtocolFamily.LiveEntity ? DisHeader.MinimumSize : DisHeader.Size;
}

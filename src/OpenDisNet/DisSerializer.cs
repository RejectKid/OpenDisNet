using OpenDisNet.Binary;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet;

/// <summary>Serializes and deserializes Distributed Interactive Simulation PDUs.</summary>
public static class DisSerializer
{
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

        if (datagram.Length < DisHeader.Size)
            return Fail(DisParseErrorCode.TruncatedHeader, "A DIS header requires 12 bytes.", datagram.Length, out error);

        try
        {
            var reader = new DisBinaryReader(datagram);
            DisHeader header = DisHeaderCodec.Read(ref reader);

            if (options.RequireVersion7 && header.ProtocolVersion != DisProtocolVersion.Ieee1278_1_2012)
                return Fail(DisParseErrorCode.UnsupportedProtocolVersion, $"Expected DIS protocol version 7; received {(byte)header.ProtocolVersion}.", 0, out error);
            if (header.Length < DisHeader.Size || header.Length > options.MaximumPduLength)
                return Fail(DisParseErrorCode.InvalidLength, $"Invalid PDU length {header.Length}.", 8, out error);
            if (header.Length > datagram.Length)
                return Fail(DisParseErrorCode.TruncatedPdu, $"The header declares {header.Length} bytes; only {datagram.Length} were received.", datagram.Length, out error);
            if (options.RequireExactDatagramLength && header.Length != datagram.Length)
                return Fail(DisParseErrorCode.TrailingData, $"The datagram contains {datagram.Length - header.Length} trailing bytes.", header.Length, out error);

            pdu = PduRegistry.Parse(header, datagram.Slice(DisHeader.Size, header.Length - DisHeader.Size));
            return true;
        }
        catch (DisParseException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, exception.Offset, out error);
        }
        catch (FormatException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, DisHeader.Size, out error);
        }
        catch (OverflowException exception)
        {
            return Fail(DisParseErrorCode.InvalidField, exception.Message, DisHeader.Size, out error);
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
}

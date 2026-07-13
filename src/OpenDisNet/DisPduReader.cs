using OpenDisNet.Binary;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet;

public static class DisPduReader
{
    public static bool TryParse(ReadOnlySpan<byte> datagram, out IDisPdu? pdu, out DisParseError error, DisParseOptions? options = null)
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

    public static IDisPdu Parse(ReadOnlySpan<byte> datagram, DisParseOptions? options = null)
    {
        if (TryParse(datagram, out IDisPdu? pdu, out DisParseError error, options))
            return pdu!;
        throw new FormatException(error.Message);
    }

    private static bool Fail(DisParseErrorCode code, string message, int offset, out DisParseError error)
    {
        error = new(code, message, offset);
        return false;
    }
}

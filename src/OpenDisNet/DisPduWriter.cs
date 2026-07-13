using OpenDisNet.Binary;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet;

public static class DisPduWriter
{
    public static int GetEncodedLength(IDisPdu pdu) => PduRegistry.GetLength(pdu);

    public static int Write(IDisPdu pdu, Span<byte> destination)
    {
        if (pdu is Pdu typed)
            return PduCodec.Write(typed, destination);

        int length = GetEncodedLength(pdu);
        if (length > ushort.MaxValue) throw new ArgumentOutOfRangeException(nameof(pdu), "A DIS PDU cannot exceed 65,535 bytes.");
        if (destination.Length < length) throw new ArgumentException($"Destination requires {length} bytes.", nameof(destination));

        DisHeader header = pdu.Header with { Length = (ushort)length };
        var writer = new DisBinaryWriter(destination[..length]);
        DisHeaderCodec.Write(ref writer, header);
        PduRegistry.WriteBody(pdu, ref writer);
        return writer.Offset;
    }

    public static byte[] Write(IDisPdu pdu)
    {
        byte[] bytes = new byte[GetEncodedLength(pdu)];
        Write(pdu, bytes);
        return bytes;
    }
}

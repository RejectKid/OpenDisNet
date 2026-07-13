using OpenDisNet.Binary;
using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

internal static class PduRegistry
{
    public static IDisPdu Parse(DisHeader header, ReadOnlySpan<byte> body) =>
        (byte)header.PduType is >= 1 and <= 72
            ? PduCodec.Read(header, body)
            : new UnknownPdu(header, body.ToArray());

    public static int GetLength(IDisPdu pdu) => pdu switch
    {
        Pdu typed => PduCodec.GetEncodedLength(typed),
        UnknownPdu unknown => DisHeader.Size + unknown.Body.Length,
        _ => throw new NotSupportedException($"No DIS writer is registered for {pdu.GetType().FullName}."),
    };

    public static void WriteBody(IDisPdu pdu, ref DisBinaryWriter writer)
    {
        if (pdu is UnknownPdu unknown)
        {
            writer.WriteBytes(unknown.Body.Span);
            return;
        }

        throw new InvalidOperationException("Typed PDUs are written by the protocol codec.");
    }
}

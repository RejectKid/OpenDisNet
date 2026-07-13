using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

internal static class PduRegistry
{
    public static IDisPdu Parse(DisHeader header, ReadOnlySpan<byte> body) =>
        new UnknownPdu(header, body.ToArray());
}

using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

/// <summary>A validly framed but unsupported or vendor-defined PDU.</summary>
public sealed record UnknownPdu(DisHeader Header, ReadOnlyMemory<byte> Body) : IDisPdu;

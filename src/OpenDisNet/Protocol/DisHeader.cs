namespace OpenDisNet.Protocol;

/// <summary>The common 12-byte header present on every DIS PDU.</summary>
public readonly record struct DisHeader(
    DisProtocolVersion ProtocolVersion,
    byte ExerciseId,
    PduType PduType,
    ProtocolFamily ProtocolFamily,
    uint Timestamp,
    ushort Length,
    byte PduStatus,
    byte Padding)
{
    public const int Size = 12;
}

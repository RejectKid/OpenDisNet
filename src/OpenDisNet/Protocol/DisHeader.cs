namespace OpenDisNet.Protocol;

/// <summary>The DIS PDU header, including the status octets used outside the Live Entity family.</summary>
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
    public const int MinimumSize = 10;
    public const int Size = 12;

    /// <summary>Gets the encoded header size for this protocol family.</summary>
    public int EncodedSize => ProtocolFamily == ProtocolFamily.LiveEntity ? MinimumSize : Size;
}

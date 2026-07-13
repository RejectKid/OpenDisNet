using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

public abstract partial class Pdu : IDisPdu
{
    public DisHeader Header => new(
        (DisProtocolVersion)ProtocolVersion,
        ExerciseId,
        (PduType)PduType,
        (ProtocolFamily)ProtocolFamily,
        Timestamp,
        Length,
        this is PduBase body ? body.PduStatus?.Value ?? 0 : (byte)0,
        this is PduBase padded ? padded.Padding : (byte)0);
}

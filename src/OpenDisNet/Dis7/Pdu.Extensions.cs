using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Dis7;

public abstract partial class Pdu : IDisPdu
{
    public DisHeader Header => new(
        (DisProtocolVersion)ProtocolVersion,
        ExerciseID,
        (PduType)PduType,
        (ProtocolFamily)ProtocolFamily,
        Timestamp,
        Length,
        this is PduBase body ? body.PduStatus?.Value ?? 0 : (byte)0,
        this is PduBase padded ? padded.Padding : (byte)0);
}

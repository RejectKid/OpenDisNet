using OpenDisNet.Protocol;
using OpenDisNet.Records;

namespace OpenDisNet.Pdus;

public sealed record EntityStatePdu(
    DisHeader Header,
    EntityId EntityId,
    byte ForceId,
    EntityType EntityType,
    EntityType AlternativeEntityType,
    Vector3Float LinearVelocity,
    Vector3Double Location,
    EulerAngles Orientation,
    uint Appearance,
    DeadReckoningParameters DeadReckoning,
    EntityMarking Marking,
    uint Capabilities,
    IReadOnlyList<VariableParameter> VariableParameters) : IDisPdu;

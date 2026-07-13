using OpenDisNet.Protocol;
using OpenDisNet.Records;

namespace OpenDisNet.Pdus;

public sealed record DetonationPdu(
    DisHeader Header,
    EntityId SourceEntityId,
    EntityId TargetEntityId,
    EntityId ExplodingEntityId,
    EventId EventId,
    Vector3Float Velocity,
    Vector3Double Location,
    MunitionDescriptor Descriptor,
    Vector3Float EntityRelativeLocation,
    byte DetonationResult,
    IReadOnlyList<VariableParameter> VariableParameters) : IDisPdu;

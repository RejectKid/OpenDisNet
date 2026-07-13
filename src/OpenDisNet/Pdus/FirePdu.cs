using OpenDisNet.Protocol;
using OpenDisNet.Records;

namespace OpenDisNet.Pdus;

public sealed record FirePdu(
    DisHeader Header,
    EntityId FiringEntityId,
    EntityId TargetEntityId,
    EntityId MunitionEntityId,
    EventId EventId,
    uint FireMissionIndex,
    Vector3Double Location,
    MunitionDescriptor Descriptor,
    Vector3Float Velocity,
    float Range) : IDisPdu;

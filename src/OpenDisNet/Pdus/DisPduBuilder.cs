using OpenDisNet.Enumerations;

namespace OpenDisNet.Pdus;

/// <summary>Creates commonly used DIS v7 PDUs with valid discriminators and related fields.</summary>
public static class DisPduBuilder
{
    /// <summary>Creates an Entity State PDU with its primary identity, type, and position populated.</summary>
    public static EntityStatePdu CreateEntityState(
        EntityId entityId,
        EntityType entityType,
        Vector3Double location,
        ForceId forceId = ForceId.Other,
        byte exerciseId = 0)
    {
        ArgumentNullException.ThrowIfNull(entityId);
        ArgumentNullException.ThrowIfNull(entityType);
        ArgumentNullException.ThrowIfNull(location);

        return new EntityStatePdu
        {
            ExerciseId = exerciseId,
            EntityId = entityId,
            EntityType = entityType,
            ForceId = forceId,
            EntityLocation = location,
        };
    }

    /// <summary>Creates a Fire PDU and derives its event simulation address from the firing entity.</summary>
    public static FirePdu CreateFire(
        EntityId firingEntityId,
        EntityId targetEntityId,
        EntityId munitionEntityId,
        ushort eventNumber,
        MunitionDescriptor descriptor,
        Vector3Double location,
        Vector3Float velocity,
        float range = 0,
        byte exerciseId = 0)
    {
        ArgumentNullException.ThrowIfNull(firingEntityId);
        ArgumentNullException.ThrowIfNull(targetEntityId);
        ArgumentNullException.ThrowIfNull(munitionEntityId);
        ArgumentNullException.ThrowIfNull(descriptor);
        ArgumentNullException.ThrowIfNull(location);
        ArgumentNullException.ThrowIfNull(velocity);

        return new FirePdu
        {
            ExerciseId = exerciseId,
            FiringEntityId = firingEntityId,
            TargetEntityId = targetEntityId,
            MunitionExpendibleId = munitionEntityId,
            EventId = CreateEventIdentifier(firingEntityId, eventNumber),
            Descriptor = descriptor,
            LocationInWorldCoordinates = location,
            Velocity = velocity,
            Range = range,
        };
    }

    /// <summary>Creates a Detonation PDU and derives its event simulation address from the source entity.</summary>
    public static DetonationPdu CreateDetonation(
        EntityId sourceEntityId,
        EntityId targetEntityId,
        EntityId explodingEntityId,
        ushort eventNumber,
        MunitionDescriptor descriptor,
        Vector3Double location,
        Vector3Float velocity,
        DetonationResult result,
        byte exerciseId = 0)
    {
        ArgumentNullException.ThrowIfNull(sourceEntityId);
        ArgumentNullException.ThrowIfNull(targetEntityId);
        ArgumentNullException.ThrowIfNull(explodingEntityId);
        ArgumentNullException.ThrowIfNull(descriptor);
        ArgumentNullException.ThrowIfNull(location);
        ArgumentNullException.ThrowIfNull(velocity);

        return new DetonationPdu
        {
            ExerciseId = exerciseId,
            SourceEntityId = sourceEntityId,
            TargetEntityId = targetEntityId,
            ExplodingEntityId = explodingEntityId,
            EventId = CreateEventIdentifier(sourceEntityId, eventNumber),
            Descriptor = descriptor,
            LocationInWorldCoordinates = location,
            Velocity = velocity,
            DetonationResult = result,
        };
    }

    /// <summary>Creates a Transmitter PDU for an entity radio.</summary>
    public static TransmitterPdu CreateTransmitter(
        RadioId radio,
        RadioType radioType,
        ulong frequency,
        float power,
        TransmitterTransmitState transmitState = TransmitterTransmitState.OnAndTransmitting,
        TransmitterInputSource inputSource = TransmitterInputSource.Other,
        byte exerciseId = 0)
    {
        ArgumentNullException.ThrowIfNull(radio.Entity);
        ArgumentNullException.ThrowIfNull(radioType);

        return new TransmitterPdu
        {
            ExerciseId = exerciseId,
            RadioHeader = new RadioCommsHeader
            {
                RadioReferenceId = radio.Entity,
                RadioNumber = radio.Number,
            },
            RadioEntityType = radioType,
            Frequency = frequency,
            Power = power,
            TransmitState = transmitState,
            InputSource = inputSource,
        };
    }

    private static EventIdentifier CreateEventIdentifier(EntityId entityId, ushort eventNumber) => new()
    {
        SimulationAddress = new SimulationAddress
        {
            Site = entityId.SiteId,
            Application = entityId.ApplicationId,
        },
        EventNumber = eventNumber,
    };
}

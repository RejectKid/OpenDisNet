// DIS v7 protocol models reviewed from LiveEntityFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 9.4.3 Communicate information about the appearance of a live entity.
/// </summary>
public partial class AppearancePdu : LiveEntityFamilyPdu
{
    /// <summary>Creates a DIS v7 AppearancePdu with its wire discriminator fields initialized.</summary>
    public AppearancePdu() => Initialize(47, 11);

    public EntityId LiveEntityId { get; set; } = new EntityId();

    /// <summary>
    /// 16-bit bit field
    /// </summary>
    public ushort AppearanceFlags { get; set; }

    public byte ForceId { get; set; }

    public EntityType EntityType { get; set; } = new EntityType();

    public EntityType AlternateEntityType { get; set; } = new EntityType();

    public EntityMarking EntityMarking { get; set; } = new EntityMarking();

    public uint Capabilities { get; set; }

    public Appearance AppearanceFields { get; set; } = new Appearance();

}

/// <summary>
/// 9.4.4 Communicate information about an entity’s articulated and attached parts.
/// </summary>
public partial class ArticulatedPartsPdu : LiveEntityFamilyPdu
{
    /// <summary>Creates a DIS v7 ArticulatedPartsPdu with its wire discriminator fields initialized.</summary>
    public ArticulatedPartsPdu() => Initialize(48, 11);

    public EntityId LiveEntityId { get; set; } = new EntityId();

    internal byte NumberOfParameterRecords { get; set; }

    public List<VariableParameter> VariableParameters { get; set; } = [];

}

/// <summary>
/// 9.4.6 Communicate information associated with the impact or detonation of a munition.
/// </summary>
public partial class LEDetonationPdu : LiveEntityFamilyPdu
{
    /// <summary>Creates a DIS v7 LEDetonationPdu with its wire discriminator fields initialized.</summary>
    public LEDetonationPdu() => Initialize(50, 11);

    public EntityId FiringLiveEntityId { get; set; } = new EntityId();

    public byte DetonationFlag1 { get; set; }

    public byte DetonationFlag2 { get; set; }

    public EntityId TargetLiveEntityId { get; set; } = new EntityId();

    public EntityId MunitionLiveEntityId { get; set; } = new EntityId();

    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    public LiveEntityRelativeWorldCoordinates WorldLocation { get; set; } = new LiveEntityRelativeWorldCoordinates();

    public LiveEntityLinearVelocity Velocity { get; set; } = new LiveEntityLinearVelocity();

    /// <summary>
    /// spec error? 16-bit fields vs. 8-bit in TspiPdu?
    /// </summary>
    public LiveEntityOrientation16 MunitionOrientation { get; set; } = new LiveEntityOrientation16();

    public MunitionDescriptor MunitionDescriptor { get; set; } = new MunitionDescriptor();

    public LiveEntityLinearVelocity EntityLocation { get; set; } = new LiveEntityLinearVelocity();

    public byte DetonationResult { get; set; }

}

/// <summary>
/// 9.4.5 Representation of weapons fire in a DIS exercise involving LEs.
/// </summary>
public partial class LEFirePdu : LiveEntityFamilyPdu
{
    /// <summary>Creates a DIS v7 LEFirePdu with its wire discriminator fields initialized.</summary>
    public LEFirePdu() => Initialize(49, 11);

    public EntityId FiringLiveEntityId { get; set; } = new EntityId();

    /// <summary>
    /// Bits defined in IEEE Standard
    /// </summary>
    public byte Flags { get; set; }

    public EntityId TargetLiveEntityId { get; set; } = new EntityId();

    public EntityId MunitionLiveEntityId { get; set; } = new EntityId();

    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    public LiveEntityRelativeWorldCoordinates Location { get; set; } = new LiveEntityRelativeWorldCoordinates();

    public MunitionDescriptor MunitionDescriptor { get; set; } = new MunitionDescriptor();

    public LiveEntityLinearVelocity Velocity { get; set; } = new LiveEntityLinearVelocity();

    public ushort Range { get; set; }

}

/// <summary>
/// Alias, more descriptive name for LEDetonationPdu.
/// </summary>
public partial class LiveEntityDetonationPdu
{
}

/// <summary>
/// Does not inherit from PduBase.  See section 9.
/// </summary>
public abstract partial class LiveEntityFamilyPdu : Pdu
{
}

/// <summary>
/// Alias, more descriptive name for LEFirePdu.
/// </summary>
public partial class LiveEntityFirePdu
{
}

/// <summary>
/// 9.4.2 The Time Space Position Information (TSPI) PDU shall communicate information about the LE’s state vector.
/// </summary>
public partial class TSPIPdu : LiveEntityFamilyPdu
{
    /// <summary>Creates a DIS v7 TSPIPdu with its wire discriminator fields initialized.</summary>
    public TSPIPdu() => Initialize(46, 11);

    public EntityId LiveEntityId { get; set; } = new EntityId();

    /// <summary>
    /// bit field
    /// </summary>
    public byte TSPIFlag { get; set; }

    public LiveEntityRelativeWorldCoordinates EntityLocation { get; set; } = new LiveEntityRelativeWorldCoordinates();

    public LiveEntityLinearVelocity EntityLinearVelocity { get; set; } = new LiveEntityLinearVelocity();

    public LiveEntityOrientation EntityOrientation { get; set; } = new LiveEntityOrientation();

    public LiveEntityPositionError PositionError { get; set; } = new LiveEntityPositionError();

    public LiveEntityOrientationError OrientationError { get; set; } = new LiveEntityOrientationError();

    public LiveDeadReckoningParameters DeadReckoningParameters { get; set; } = new LiveDeadReckoningParameters();

    public ushort MeasuredSpeed { get; set; }

    internal byte SystemSpecificDataLength { get; set; }

    public byte[] SystemSpecificData { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for TSPIPdu.
/// </summary>
public partial class TimeSpacePositionInformationPdu
{
}


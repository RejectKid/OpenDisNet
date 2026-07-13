// DIS v7 protocol models reviewed from WarfareFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 7.3.3 Used to communicate the detonation or impact of munitions, as well as non-munition explosions, the burst or initial bloom of chaff, and the ignition of a flare.
/// </summary>
public partial class DetonationPdu : WarfareFamilyPdu
{
    /// <summary>Creates a DIS v7 DetonationPdu with its wire discriminator fields initialized.</summary>
    public DetonationPdu() => Initialize(3, 2);

    /// <summary>
    /// ID of the entity that shot
    /// </summary>
    public EntityId SourceEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of the entity that is being shot at
    /// </summary>
    public EntityId TargetEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of the expendable entity, Section 7.3.3
    /// </summary>
    public EntityId ExplodingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of event, Section 7.3.3
    /// </summary>
    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// velocity of the munition immediately before detonation/impact, Section 7.3.3
    /// </summary>
    public Vector3Float Velocity { get; set; } = new Vector3Float();

    /// <summary>
    /// location of the munition detonation, the expendable detonation, Section 7.3.3
    /// </summary>
    public Vector3Double LocationInWorldCoordinates { get; set; } = new Vector3Double();

    /// <summary>
    /// Describes the detonation represented, Section 7.3.3
    /// </summary>
    public MunitionDescriptor Descriptor { get; set; } = new MunitionDescriptor();

    /// <summary>
    /// Velocity of the ammunition, Section 7.3.3
    /// </summary>
    public Vector3Float LocationOfEntityCoordinates { get; set; } = new Vector3Float();

    /// <summary>
    /// result of the detonation, Section 7.3.3
    /// </summary>
    public byte DetonationResult { get; set; }

    /// <summary>
    /// How many articulation parameters we have, Section 7.3.3
    /// </summary>
    internal byte NumberOfVariableParameters { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Pad { get; set; }

    /// <summary>
    /// specify the parameter values for each Variable Parameter record, Section 7.3.3
    /// </summary>
    public List<VariableParameter> VariableParameters { get; set; } = [];

}

/// <summary>
/// 7.3.4 Used to communicate the firing of a directed energy weapon.
/// </summary>
public partial class DirectedEnergyFirePdu : WarfareFamilyPdu
{
    /// <summary>Creates a DIS v7 DirectedEnergyFirePdu with its wire discriminator fields initialized.</summary>
    public DirectedEnergyFirePdu() => Initialize(68, 2);

    /// <summary>
    /// ID of the entity that shot
    /// </summary>
    public EntityId FiringEntityId { get; set; } = new EntityId();

    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// Field shall identify the munition type enumeration for the DE weapon beam, Section 7.3.4
    /// </summary>
    public EntityType MunitionType { get; set; } = new EntityType();

    /// <summary>
    /// Field shall indicate the simulation time at start of the shot, Section 7.3.4
    /// </summary>
    public ClockTime ShotStartTime { get; set; } = new ClockTime();

    /// <summary>
    /// Field shall indicate the current cumulative duration of the shot, Section 7.3.4
    /// </summary>
    public float CommulativeShotTime { get; set; }

    /// <summary>
    /// Field shall identify the location of the DE weapon aperture/emitter, Section 7.3.4
    /// </summary>
    public Vector3Float ApertureEmitterLocation { get; set; } = new Vector3Float();

    /// <summary>
    /// Field shall identify the beam diameter at the aperture/emitter, Section 7.3.4
    /// </summary>
    public float ApertureDiameter { get; set; }

    /// <summary>
    /// Field shall identify the emissions wavelength in units of meters, Section 7.3.4
    /// </summary>
    public float Wavelength { get; set; }

    public uint Pad1 { get; set; }

    public float PulseRepititionFrequency { get; set; }

    /// <summary>
    /// field shall identify the pulse width emissions in units of seconds, Section 7.3.4
    /// </summary>
    public float PulseWidth { get; set; }

    /// <summary>
    /// 16bit Boolean field shall contain various flags to indicate status information needed to process a DE, Section 7.3.4
    /// </summary>
    public ushort Flags { get; set; }

    /// <summary>
    /// Field shall identify the pulse shape and shall be represented as an 8-bit enumeration, Section 7.3.4
    /// </summary>
    public byte PulseShape { get; set; }

    public byte Pad2 { get; set; }

    public uint Pad3 { get; set; }

    public ushort Pad4 { get; set; }

    /// <summary>
    /// Field shall specify the number of DE records, Section 7.3.4
    /// </summary>
    internal ushort NumberOfDERecords { get; set; }

    /// <summary>
    /// Fields shall contain one or more DE records, records shall conform to the variable record format (Section6.2.82), Section 7.3.4
    /// </summary>
    public List<StandardVariableSpecification> DERecords { get; set; } = [];

}

/// <summary>
/// 7.3.5 Used to communicate detailed damage information sustained by an entity regardless of the source of the damage.
/// </summary>
public partial class EntityDamageStatusPdu : WarfareFamilyPdu
{
    /// <summary>Creates a DIS v7 EntityDamageStatusPdu with its wire discriminator fields initialized.</summary>
    public EntityDamageStatusPdu() => Initialize(69, 2);

    /// <summary>
    /// Field shall identify the damaged entity (see 6.2.28), Section 7.3.4
    /// </summary>
    public EntityId DamagedEntityId { get; set; } = new EntityId();

    public ushort Padding1 { get; set; }

    public ushort Padding2 { get; set; }

    /// <summary>
    /// field shall specify the number of Damage Description records, Section 7.3.5
    /// </summary>
    internal ushort NumberOfDamageDescription { get; set; }

    /// <summary>
    /// Fields shall contain one or more Damage Description records (see 6.2.17) and may contain other Standard Variable records, Section 7.3.5
    /// </summary>
    public List<DirectedEnergyDamage> DamageDescriptionRecords { get; set; } = [];

}

/// <summary>
/// 7.3.2 Used to communicate the firing of a weapon or expendable.
/// </summary>
public partial class FirePdu : WarfareFamilyPdu
{
    /// <summary>Creates a DIS v7 FirePdu with its wire discriminator fields initialized.</summary>
    public FirePdu() => Initialize(2, 2);

    /// <summary>
    /// ID of the entity that shot
    /// </summary>
    public EntityId FiringEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of the entity that is being shot at
    /// </summary>
    public EntityId TargetEntityId { get; set; } = new EntityId();

    /// <summary>
    /// This field shall specify the entity identification of the fired munition or expendable. This field shall be represented by an Entity Identifier record (see 6.2.28).
    /// </summary>
    public EntityId MunitionExpendibleId { get; set; } = new EntityId();

    /// <summary>
    /// This field shall contain an identification generated by the firing entity to associate related firing and detonation events. This field shall be represented by an Event Identifier record (see 6.2.34).
    /// </summary>
    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// This field shall identify the fire mission (see 5.4.3.3). This field shall be represented by a 32-bit unsigned integer.
    /// </summary>
    public uint FireMissionIndex { get; set; }

    /// <summary>
    /// This field shall specify the location, in world coordinates, from which the munition was launched, and shall be represented by a World Coordinates record (see 6.2.97).
    /// </summary>
    public Vector3Double LocationInWorldCoordinates { get; set; } = new Vector3Double();

    /// <summary>
    /// This field shall describe the firing or launch of a munition or expendable represented by one of the following types of Descriptor records: Munition Descriptor (6.2.20.2) or Expendable Descriptor (6.2.20.4).
    /// </summary>
    public MunitionDescriptor Descriptor { get; set; } = new MunitionDescriptor();

    /// <summary>
    /// This field shall specify the velocity of the fired munition at the point when the issuing simulation application intends the externally visible effects of the launch (e.g. exhaust plume or muzzle blast) to first become apparent. The velocity shall be represented in world coordinates. This field shall be represented by a Linear Velocity Vector record [see 6.2.95 item c)].
    /// </summary>
    public Vector3Float Velocity { get; set; } = new Vector3Float();

    /// <summary>
    /// This field shall specify the range that an entity's fire control system has assumed in computing the fire control solution. This field shall be represented by a 32-bit floating point number in meters. For systems where range is unknown or unavailable, this field shall contain a value of zero.
    /// </summary>
    public float Range { get; set; }

}

/// <summary>
/// Abstract superclass for fire and detonation pdus that have shared information. Section 7.3
/// </summary>
public abstract partial class WarfareFamilyPdu : PduBase
{
}


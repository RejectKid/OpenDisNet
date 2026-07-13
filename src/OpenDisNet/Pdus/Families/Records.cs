// DIS v7 protocol models reviewed from DIS_7_2012.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// Additional Passive Activity for use by Underwater Acoustic (UA) PDU. Section 7.6.4
/// </summary>
public partial class APA
{
    public ushort ParameterIndex { get; set; }

    public ushort Value { get; set; }

}

/// <summary>
/// Information about a specific UA emitter. Section 6.2.2.
/// </summary>
public partial class AcousticEmitter
{
    /// <summary>
    /// The system for a particular UA emitter, and an enumeration
    /// </summary>
    public ushort AcousticSystemName { get; set; }

    /// <summary>
    /// The function of the acoustic system
    /// </summary>
    public byte AcousticFunction { get; set; }

    /// <summary>
    /// The UA emitter identification number relative to a specific system
    /// </summary>
    public byte AcousticIdNumber { get; set; }

}

/// <summary>
/// The unique designation of each aggregate in an exercise is specified by an aggregate identifier record. The aggregate ID is not an entity and shall not be treated as such. Section 6.2.3.
/// </summary>
public partial class AggregateIdentifier
{
    /// <summary>
    /// Simulation address, i.e. site and application, the first two fields of the entity ID provides a unique identifier
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    /// <summary>
    /// The aggregate ID provides a unique identifier
    /// </summary>
    public ushort AggregateId { get; set; }

}

/// <summary>
/// Specifies the character set used in the first byte, followed by up to 31 characters of text data. Section 6.2.4.
/// </summary>
public partial class AggregateMarking
{
    /// <summary>
    /// The character set
    /// </summary>
    public byte CharacterSet { get; set; }

    /// <summary>
    /// The characters
    /// </summary>
    public byte[] Characters { get; set; } = new byte[31];

}

/// <summary>
/// Identifies the type and organization of an aggregate. Section 6.2.5
/// </summary>
public partial class AggregateType
{
    /// <summary>
    /// Grouping criterion used to group the aggregate. Enumeration from EBV document
    /// </summary>
    public byte AggregateKind { get; set; }

    /// <summary>
    /// Domain of entity (air, surface, subsurface, space, etc.) where zero means domain does not apply.
    /// </summary>
    public byte Domain { get; set; }

    /// <summary>
    /// country to which the design of the entity is attributed
    /// </summary>
    public ushort Country { get; set; }

    /// <summary>
    /// category of entity
    /// </summary>
    public byte Category { get; set; }

    /// <summary>
    /// subcategory of entity
    /// </summary>
    public byte Subcategory { get; set; }

    /// <summary>
    /// specific info based on subcategory field. specific is a reserved word in sql.
    /// </summary>
    public byte SpecificInfo { get; set; }

    public byte Extra { get; set; }

}

/// <summary>
/// The Angle Deception attribute record may be used to communicate discrete values that are associated with angle deception jamming that cannot be referenced to an emitter mode. The values provided in the record records (provided in the associated Electromagnetic Emission PDU). (The victim radar beams are those that are targeted by the jammer.) Section 6.2.21.2.2
/// </summary>
public partial class AngleDeception
{
    /// <summary>
    /// record type
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// The length of the record in octets.
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// indicates the emitter system for which the angle deception values are applicable.
    /// </summary>
    public byte EmitterNumber { get; set; }

    /// <summary>
    /// indicates the jamming beam for which the angle deception values are applicable.
    /// </summary>
    public byte BeamNumber { get; set; }

    /// <summary>
    /// This field shall be used to indicate if angle deception data have changed since issuance of the last Angle Deception attribute record for this beam, if the Angle Deception attribute record is part of a heartbeat update to meet periodic update requirements or if the angle deception data for the beam has ceased.
    /// </summary>
    public byte StateIndicator { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding2 { get; set; }

    /// <summary>
    /// This field indicates the relative azimuth angle at which the deceptive radar returns are centered. This angle is measured in the X-Y plane of the victim radar's entity coordinate system (see 1.4.3). This angle is measured in radians from the victim radar entity's azimuth for the true jam- mer position to the center of the range of azimuths in which deceptive radar returns are perceived as shown in Figure 43. Positive and negative values indicate that the perceived positions of the jammer are right and left of the true position of the jammer, respectively. The range of permissible values is -PI to PI
    /// </summary>
    public float AzimuthOffset { get; set; }

    /// <summary>
    /// indicates the range of azimuths (in radians) through which the deceptive radar returns are perceived, centered on the azimuth offset as shown in Figure 43. The range of permissible values is 0 to 2PI radians
    /// </summary>
    public float AzimuthWidth { get; set; }

    /// <summary>
    /// This field indicates the rate (in radians per second) at which the Azimuth Offset value is changing. Positive and negative values indicate that the Azimuth Offset is moving to the right or left, respectively.
    /// </summary>
    public float AzimuthPullRate { get; set; }

    /// <summary>
    /// This field indicates the rate (in radians per second squared) at which the Azimuth Pull Rate value is changing. Azimuth Pull Acceleration is defined as positive to the right and negative to the left.
    /// </summary>
    public float AzimuthPullAcceleration { get; set; }

    /// <summary>
    /// This field indicates the relative elevation angle at which the deceptive radar returns begin. This angle is measured as an angle with respect to the X-Y plane of the victim radar's entity coordinate system (see 1.4.3). This angle is measured in radians from the victim radar entity's eleva- tion for the true jammer position to the center of the range of elevations in which deceptive radar returns are perceived as shown in Figure 44. Positive and negative values indicate that the perceived positions of the jammer are above and below the true position of the jammer, respectively. The range of permissible values is -PI/2 to PI/2
    /// </summary>
    public float ElevationOffset { get; set; }

    /// <summary>
    /// This field indicates the range of elevations (in radians) through which the decep- tive radar returns are perceived, centered on the elevation offset as shown in Figure 44. The range of permissible values is 0 to PI radians
    /// </summary>
    public float ElevationWidth { get; set; }

    /// <summary>
    /// This field indicates the rate (in radians per second) at which the Elevation Off- set value is changing. Positive and negative values indicate that the Elevation Offset is moving up or down, respectively.
    /// </summary>
    public float ElevationPullRate { get; set; }

    /// <summary>
    /// This field indicates the rate (in radians per second squared) at which the Elevation Pull Rate value is changing. Elevation Pull Acceleration is defined as positive to upward and negative downward.
    /// </summary>
    public float ElevationPullAcceleration { get; set; }

    public uint Padding3 { get; set; }

}

/// <summary>
/// Angular velocity measured in radians per second out each of the entity's own coordinate axes. Order of measurement is angular velocity around the x, y, and z axis of the entity. The positive direction is determined by the right hand rule. Section 6.2.7
/// </summary>
public partial class AngularVelocityVector
{
    /// <summary>
    /// velocity about the x axis
    /// </summary>
    public float X { get; set; }

    /// <summary>
    /// velocity about the y axis
    /// </summary>
    public float Y { get; set; }

    /// <summary>
    /// velocity about the zaxis
    /// </summary>
    public float Z { get; set; }

}

/// <summary>
/// Location of the radiating portion of the antenna, specified in world coordinates and entity coordinates. Section 6.2.8
/// </summary>
public partial class AntennaLocation
{
    /// <summary>
    /// Location of the radiating portion of the antenna in world coordinates
    /// </summary>
    public Vector3Double AntennaLocationValue { get; set; } = new Vector3Double();

    /// <summary>
    /// Location of the radiating portion of the antenna in entity coordinates
    /// </summary>
    public Vector3Float RelativeAntennaLocation { get; set; } = new Vector3Float();

}

/// <summary>
/// used in AppearancePdu
/// </summary>
public partial class Appearance
{
    public uint Visual { get; set; }

    public uint Ir { get; set; }

    public uint Em { get; set; }

    public uint Audio { get; set; }

}

/// <summary>
/// articulated parts for movable parts and a combination of moveable/attached parts of an entity. Section 6.2.94.2
/// </summary>
public partial class ArticulatedPartVP
{
    /// <summary>
    /// The identification of the Variable Parameter record. Enumeration from EBV
    /// </summary>
    public byte RecordType { get; set; }

    /// <summary>
    /// indicate the change of any parameter for any articulated part. Starts at zero, incremented for each change
    /// </summary>
    public byte ChangeIndicator { get; set; }

    /// <summary>
    /// The identification of the articulated part to which this articulation parameter is attached. This field shall be specified by a 16-bit unsigned integer. This field shall contain the value zero if the articulated part is attached directly to the entity.
    /// </summary>
    public ushort PartAttachedTo { get; set; }

    /// <summary>
    /// The type of parameter represented, 32-bit enumeration
    /// </summary>
    public uint ParameterType { get; set; }

    /// <summary>
    /// The definition of the 64-bits shall be determined based on the type of parameter specified in the Parameter Type field
    /// </summary>
    public float ParameterValue { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public uint Padding { get; set; }

}

/// <summary>
/// An entity's associations with other entities and/or locations. For each association, this record shall specify the type of the association, the associated entity's EntityID and/or the associated location's world coordinates. This record may be used (optionally) in a transfer transaction to send internal state data from the divesting simulation to the acquiring simulation (see 5.9.4). This record may also be used for other purposes. Section 6.2.9
/// </summary>
public partial class Association
{
    /// <summary>
    /// This field shall indicate the type of association. It shall be represented by an 8-bit enumeration. Values for this field are found in Section 14 of SISO-REF-010
    /// </summary>
    public byte AssociationType { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

    /// <summary>
    /// identity of associated entity. If none, NO_SPECIFIC_ENTITY
    /// </summary>
    public EntityIdentifier AssociatedEntityId { get; set; } = new EntityIdentifier();

    /// <summary>
    /// location, in world coordinates
    /// </summary>
    public Vector3Double AssociatedLocation { get; set; } = new Vector3Double();

}

/// <summary>
/// Removable parts that may be attached to an entity.  Section 6.2.93.3
/// </summary>
public partial class AttachedPartVP
{
    /// <summary>
    /// The identification of the Variable Parameter record. Enumeration from EBV
    /// </summary>
    public byte RecordType { get; set; }

    /// <summary>
    /// 0 = attached, 1 = detached. See I.2.3.1 for state transition diagram
    /// </summary>
    public byte DetachedIndicator { get; set; }

    /// <summary>
    /// The identification of the articulated part to which this articulation parameter is attached. This field shall be specified by a 16-bit unsigned integer. This field shall contain the value zero if the articulated part is attached directly to the entity.
    /// </summary>
    public ushort PartAttachedTo { get; set; }

    /// <summary>
    /// The location or station to which the part is attached
    /// </summary>
    public uint ParameterType { get; set; }

    /// <summary>
    /// The definition of the 64-bits shall be determined based on the type of parameter specified in the Parameter Type field
    /// </summary>
    public EntityType AttachedPartType { get; set; } = new EntityType();

}

/// <summary>
/// Used to convey information for one or more attributes. Attributes conform to the standard variable record format of 6.2.82. Section 6.2.10.
/// </summary>
public partial class Attribute
{
    /// <summary>
    /// The record type for this attribute. Enumeration
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// Total length of the record in octets, including padding. The record shall end on a 64-bit boundary after any padding. = 6 + K + P
    /// </summary>
    internal ushort RecordLength { get; set; }

    /// <summary>
    /// The attribute data format conforming to that specified by the record type. K bytes long
    /// </summary>
    public byte[] RecordSpecificFields { get; set; } = new byte[0];

}

/// <summary>
/// Used when the antenna pattern type field has a value of 1. Specifies the direction, pattern, and polarization of radiation from an antenna. Section 6.2.9.2
/// </summary>
public partial class BeamAntennaPattern
{
    /// <summary>
    /// The rotation that transforms the reference coordinate sytem into the beam coordinate system. Either world coordinates or entity coordinates may be used as the reference coordinate system, as specified by the reference system field of the antenna pattern record.
    /// </summary>
    public EulerAngles BeamDirection { get; set; } = new EulerAngles();

    /// <summary>
    /// Full width of the beam to the -3dB power density points in the x-y plane of the beam coordinnate system.  Elevation beamwidth is represented by a 32-bit floating point number in units of radians.
    /// </summary>
    public float AzimuthBeamwidth { get; set; }

    /// <summary>
    /// This field shall specify the full width of the beam to the –3 dB power density points in the x-z plane of the beam coordinate system. Elevation beamwidth shall be represented by a 32-bit floating point number in units of radians.
    /// </summary>
    public float ElevationBeamwidth { get; set; }

    /// <summary>
    /// The reference coordinate system wrt which beam direction  is specified. This field should not change over the duration of an exercise. World coordindate systemis prefered for exercises. The entity coordinate system should be used only when highly directional antennas must be precisely modeled.
    /// </summary>
    public byte ReferenceSystem { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding2 { get; set; }

    /// <summary>
    /// This field shall specify the magnitude of the Z-component (in beam coordinates) of the Electrical field at some arbitrary single point in the main beam and in the far field of the antenna.
    /// </summary>
    public float Ez { get; set; }

    /// <summary>
    /// This field shall specify the magnitude of the X-component (in beam coordinates) of the Electri- cal field at some arbitrary single point in the main beam and in the far field of the antenna.
    /// </summary>
    public float Ex { get; set; }

    /// <summary>
    /// This field shall specify the phase angle between EZ and EX in radians. If fully omni-direc- tional antenna is modeled using beam pattern type one, the omni-directional antenna shall be repre- sented by beam direction Euler angles psi, theta, and phi of zero, an azimuth beamwidth of 2PI, and an elevation beamwidth of PI
    /// </summary>
    public float Phase { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Padding3 { get; set; }

}

/// <summary>
/// Describes the scan volue of an emitter beam. Section 6.2.11.
/// </summary>
public partial class BeamData
{
    /// <summary>
    /// Specifies the beam azimuth an elevation centers and corresponding half-angles to describe the scan volume
    /// </summary>
    public float BeamAzimuthCenter { get; set; }

    /// <summary>
    /// Specifies the beam azimuth sweep to determine scan volume
    /// </summary>
    public float BeamAzimuthSweep { get; set; }

    /// <summary>
    /// Specifies the beam elevation center to determine scan volume
    /// </summary>
    public float BeamElevationCenter { get; set; }

    /// <summary>
    /// Specifies the beam elevation sweep to determine scan volume
    /// </summary>
    public float BeamElevationSweep { get; set; }

    /// <summary>
    /// allows receiver to synchronize its regenerated scan pattern to that of the emmitter. Specifies the percentage of time a scan is through its pattern from its origion.
    /// </summary>
    public float BeamSweepSync { get; set; }

}

/// <summary>
/// Information related to the status of a beam. This is contained in the beam status field of the electromagnitec emission PDU. The first bit determines whether the beam is active (0) or deactivated (1). Section 6.2.12.
/// </summary>
public partial class BeamStatus
{
    /// <summary>
    /// First bit zero means beam is active, first bit = 1 means deactivated. The rest is padding.
    /// </summary>
    public byte BeamState { get; set; }

}

/// <summary>
/// The Blanking Sector attribute record may be used to convey persistent areas within a scan volume where emitter power for a specific active emitter beam is reduced to an insignificant value. Section 6.2.21.2
/// </summary>
public partial class BlankingSector
{
    /// <summary>
    /// record type
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// The length of the Blanking Sector attribute record in octets.
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// indicates the emitter system for which the blanking sector values are applicable
    /// </summary>
    public byte EmitterNumber { get; set; }

    /// <summary>
    /// indicates the beam for which the blanking sector values are applicable.
    /// </summary>
    public byte BeamNumber { get; set; }

    /// <summary>
    /// indicate if blanking sector data have changed since issuance of the last Blanking Sector attribute record for this beam, if the Blanking Sector attribute record beam has ceased
    /// </summary>
    public byte StateIndicator { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public byte Padding2 { get; set; }

    /// <summary>
    /// This field is provided to indicate the left-most azimuth (clockwise in radians) for which emitted power is reduced. This angle is measured in the X-Y plane of the radar's entity coor- dinate system (see 1.4.3). The range of permissible values is 0 to 2PI, with zero pointing in the X- direction.
    /// </summary>
    public float LeftAzimuth { get; set; }

    /// <summary>
    /// Indicate the right-most azimuth (clockwise in radians) for which emitted power is reduced. This angle is measured in the X-Y plane of the radar's entity coordinate system (see 1.4.3). The range of permissible values is 0 to 2PI , with zero pointing in the X- direction.
    /// </summary>
    public float RightAzimuth { get; set; }

    /// <summary>
    /// This field is provided to indicate the lowest elevation (in radians) for which emit- ted power is reduced. This angle is measured positive upward with respect to the X-Y plane of the radar's entity coordinate system (see 1.4.3). The range of permissible values is -PI/2 to PI/2
    /// </summary>
    public float LowerElevation { get; set; }

    /// <summary>
    /// This field is provided to indicate the highest elevation (in radians) for which emitted power is reduced. This angle is measured positive upward with respect to the X-Y plane of the radar's entitycoordinatesystem(see1.4.3). The range of permissible values is -PI/2 to PI/2
    /// </summary>
    public float UpperElevation { get; set; }

    /// <summary>
    /// This field shall specify the residual effective radiated power in the blanking sector in dBm.
    /// </summary>
    public float ResidualPower { get; set; }

    /// <summary>
    /// Padding, 32-bits
    /// </summary>
    public ulong Padding3 { get; set; }

}

/// <summary>
/// This is a bitfield. See section 6.2.13 aka B.2.41
/// </summary>
public partial class ChangeOptions
{
    public byte Value { get; set; }

}

/// <summary>
/// Time measurements that exceed one hour are represented by this record. The first field is the hours since the unix epoch (Jan 1 1970, used by most Unix systems and java) and the second field the timestamp units since the top of the hour. Section 6.2.14
/// </summary>
public partial class ClockTime
{
    /// <summary>
    /// Hours in UTC
    /// </summary>
    public uint Hour { get; set; }

    /// <summary>
    /// Time past the hour
    /// </summary>
    public uint TimePastHour { get; set; }

}

/// <summary>
/// Identity of a communications node. Section 6.2.48.4
/// </summary>
public partial class CommunicationsNodeID
{
    public EntityID EntityId { get; set; } = new EntityID();

    public ushort ElementId { get; set; }

}

/// <summary>
/// identify which of the optional data fields are contained in the Minefield Data PDU or requested in the Minefield Query PDU. This is a 32-bit record. For each field, true denotes that the data is requested or present and false denotes that the data is neither requested nor present. Section 6.2.16
/// </summary>
public partial class DataFilterRecord
{
    /// <summary>
    /// Bitflags field
    /// </summary>
    public uint BitFlags { get; set; }

}

/// <summary>
/// List of fixed and variable datum records. Section 6.2.17
/// </summary>
public partial class DataQueryDatumSpecification
{
    /// <summary>
    /// Number of fixed datums
    /// </summary>
    internal uint NumberOfFixedDatums { get; set; }

    /// <summary>
    /// Number of variable datums
    /// </summary>
    internal uint NumberOfVariableDatums { get; set; }

    /// <summary>
    /// variable length list fixed datum IDs
    /// </summary>
    public List<UnsignedDISInteger> FixedDatumIdList { get; set; } = [];

    /// <summary>
    /// variable length list variable datum IDs
    /// </summary>
    public List<UnsignedDISInteger> VariableDatumIdList { get; set; } = [];

}

/// <summary>
/// List of fixed and variable datum records. Section 6.2.18
/// </summary>
public partial class DatumSpecification
{
    /// <summary>
    /// Number of fixed datums
    /// </summary>
    internal uint NumberOfFixedDatums { get; set; }

    /// <summary>
    /// Number of variable datums
    /// </summary>
    internal uint NumberOfVariableDatums { get; set; }

    /// <summary>
    /// variable length list fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatumIdList { get; set; } = [];

    /// <summary>
    /// variable length list of variable datums
    /// </summary>
    public List<VariableDatum> VariableDatumIdList { get; set; } = [];

}

/// <summary>
/// Not specified in the standard. This is used by the ESPDU
/// </summary>
public partial class DeadReckoningParameters
{
    /// <summary>
    /// Algorithm to use in computing dead reckoning. See EBV doc.
    /// </summary>
    public byte DeadReckoningAlgorithm { get; set; }

    /// <summary>
    /// Dead reckoning parameters. Contents depends on algorithm.
    /// </summary>
    public byte[] Parameters { get; set; } = new byte[15];

    /// <summary>
    /// Linear acceleration of the entity
    /// </summary>
    public Vector3Float EntityLinearAcceleration { get; set; } = new Vector3Float();

    /// <summary>
    /// Angular velocity of the entity
    /// </summary>
    public Vector3Float EntityAngularVelocity { get; set; } = new Vector3Float();

}

/// <summary>
/// DE Precision Aimpoint Record. Section 6.2.20.2
/// </summary>
public partial class DirectedEnergyAreaAimpoint
{
    /// <summary>
    /// Type of Record enumeration
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// Length of Record
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// Number of beam antenna pattern records
    /// </summary>
    internal ushort BeamAntennaPatternRecordCount { get; set; }

    /// <summary>
    /// Number of DE target energy depositon records
    /// </summary>
    internal ushort DirectedEnergyTargetEnergyDepositionRecordCount { get; set; }

    /// <summary>
    /// list of beam antenna records. See 6.2.9.2
    /// </summary>
    public List<BeamAntennaPattern> BeamAntennaParameterList { get; set; } = [];

    /// <summary>
    /// list of DE target deposition records. See 6.2.21.4
    /// </summary>
    public List<DirectedEnergyTargetEnergyDeposition> DirectedEnergyTargetEnergyDepositionRecordList { get; set; } = [];

}

/// <summary>
/// Damage sustained by an entity due to directed energy. Location of the damage based on a relative x,y,z location from the center of the entity. Section 6.2.15.2
/// </summary>
public partial class DirectedEnergyDamage
{
    /// <summary>
    /// DE Record Type.
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// DE Record Length (bytes)
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// location of damage, relative to center of entity
    /// </summary>
    public Vector3Float DamageLocation { get; set; } = new Vector3Float();

    /// <summary>
    /// Size of damaged area, in meters
    /// </summary>
    public float DamageDiameter { get; set; }

    /// <summary>
    /// average temp of the damaged area, in degrees celsius. If firing entitty does not model this, use a value of -273.15
    /// </summary>
    public float Temperature { get; set; }

    /// <summary>
    /// enumeration
    /// </summary>
    public byte ComponentIdentification { get; set; }

    /// <summary>
    /// enumeration
    /// </summary>
    public byte ComponentDamageStatus { get; set; }

    /// <summary>
    /// enumeration
    /// </summary>
    public byte ComponentVisualDamageStatus { get; set; }

    /// <summary>
    /// enumeration
    /// </summary>
    public byte ComponentVisualSmokeColor { get; set; }

    /// <summary>
    /// For any component damage resulting this field shall be set to the fire event ID from that PDU.
    /// </summary>
    public EventIdentifier FireEventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

}

/// <summary>
/// DE Precision Aimpoint Record. Section 6.2.20.3
/// </summary>
public partial class DirectedEnergyPrecisionAimpoint
{
    /// <summary>
    /// Type of Record
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// Length of Record
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// Position of Target Spot in World Coordinates.
    /// </summary>
    public Vector3Double TargetSpotLocation { get; set; } = new Vector3Double();

    /// <summary>
    /// Position (meters) of Target Spot relative to Entity Position.
    /// </summary>
    public Vector3Float TargetSpotEntityLocation { get; set; } = new Vector3Float();

    /// <summary>
    /// Velocity (meters/sec) of Target Spot.
    /// </summary>
    public Vector3Float TargetSpotVelocity { get; set; } = new Vector3Float();

    /// <summary>
    /// Acceleration (meters/sec/sec) of Target Spot.
    /// </summary>
    public Vector3Float TargetSpotAcceleration { get; set; } = new Vector3Float();

    /// <summary>
    /// Unique ID of the target entity.
    /// </summary>
    public EntityID TargetEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Target Component ID ENUM, same as in DamageDescriptionRecord.
    /// </summary>
    public byte TargetComponentId { get; set; }

    /// <summary>
    /// Spot Shape ENUM.
    /// </summary>
    public byte BeamSpotType { get; set; }

    /// <summary>
    /// Beam Spot Cross Section Semi-Major Axis.
    /// </summary>
    public float BeamSpotCrossSectionSemiMajorAxis { get; set; }

    /// <summary>
    /// Beam Spot Cross Section Semi-Major Axis.
    /// </summary>
    public float BeamSpotCrossSectionSemiMinorAxis { get; set; }

    /// <summary>
    /// Beam Spot Cross Section Orientation Angle.
    /// </summary>
    public float BeamSpotCrossSectionOrientationAngle { get; set; }

    /// <summary>
    /// Peak irradiance
    /// </summary>
    public float PeakIrradiance { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Padding2 { get; set; }

}

/// <summary>
/// DE energy depostion properties for a target entity. Section 6.2.20.4
/// </summary>
public partial class DirectedEnergyTargetEnergyDeposition
{
    /// <summary>
    /// Unique ID of the target entity.
    /// </summary>
    public EntityID TargetEntityId { get; set; } = new EntityID();

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// Peak irradiance
    /// </summary>
    public float PeakIrradiance { get; set; }

}

/// <summary>
/// A special class to contain and act as a super class for Domain enumerations.
/// </summary>
public partial class Domain
{
    /// <summary>
    /// domain field containing enumeration value.                    See SISO enumerations for PlatformDomain uid 8, MunitionDomain uid 14 and SupplyDomain uid 600.
    /// </summary>
    public byte Value { get; set; }

}

/// <summary>
/// Contains electromagnetic emission regeneration parameters that are variable throught a scenario. Section 6.2.22.
/// </summary>
public partial class EEFundamentalParameterData
{
    /// <summary>
    /// center frequency of the emission in hertz.
    /// </summary>
    public float Frequency { get; set; }

    /// <summary>
    /// Bandwidth of the frequencies corresponding to the fequency field.
    /// </summary>
    public float FrequencyRange { get; set; }

    /// <summary>
    /// Effective radiated power for the emission in DdBm. For a radar noise jammer, indicates the peak of the transmitted power.
    /// </summary>
    public float EffectiveRadiatedPower { get; set; }

    /// <summary>
    /// Average repetition frequency of the emission in hertz.
    /// </summary>
    public float PulseRepetitionFrequency { get; set; }

    /// <summary>
    /// Average pulse width  of the emission in microseconds.
    /// </summary>
    public float PulseWidth { get; set; }

}

/// <summary>
/// This field shall specify information about a particular emitter system. Section 6.2.23.
/// </summary>
public partial class EmitterSystem
{
    /// <summary>
    /// Name of the emitter, 16-bit enumeration
    /// </summary>
    public ushort EmitterName { get; set; }

    /// <summary>
    /// function of the emitter, 8-bit enumeration
    /// </summary>
    public byte EmitterFunction { get; set; }

    /// <summary>
    /// emitter ID, 8-bit enumeration
    /// </summary>
    public byte EmitterIdNumber { get; set; }

}

/// <summary>
/// Information about an entity's engine fuel. Section 6.2.24.
/// </summary>
public partial class EngineFuel
{
    /// <summary>
    /// Fuel quantity, units specified by next field
    /// </summary>
    public uint FuelQuantity { get; set; }

    /// <summary>
    /// Units in which the fuel is measured
    /// </summary>
    public byte FuelMeasurementUnits { get; set; }

    /// <summary>
    /// Type of fuel
    /// </summary>
    public byte FuelType { get; set; }

    /// <summary>
    /// Location of fuel as related to entity. See section 14 of EBV document
    /// </summary>
    public byte FuelLocation { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// For each type or location of engine fuell, this record specifies the type, location, fuel measurement units, and reload quantity and maximum quantity. Section 6.2.25.
/// </summary>
public partial class EngineFuelReload
{
    /// <summary>
    /// standard quantity of fuel loaded
    /// </summary>
    public uint StandardQuantity { get; set; }

    /// <summary>
    /// maximum quantity of fuel loaded
    /// </summary>
    public uint MaximumQuantity { get; set; }

    /// <summary>
    /// seconds normally required to to reload standard qty
    /// </summary>
    public uint StandardQuantityReloadTime { get; set; }

    /// <summary>
    /// seconds normally required to to reload maximum qty
    /// </summary>
    public uint MaximumQuantityReloadTime { get; set; }

    /// <summary>
    /// Units of measure
    /// </summary>
    public byte FuelMeasurmentUnits { get; set; }

    public byte FuelType { get; set; }

    /// <summary>
    /// fuel  location as related to the entity
    /// </summary>
    public byte FuelLocation { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// Association or disassociation of two entities.  Section 6.2.94.4.3
/// </summary>
public partial class EntityAssociationVP
{
    /// <summary>
    /// The identification of the Variable Parameter record. Enumeration from EBV
    /// </summary>
    public byte RecordType { get; set; }

    /// <summary>
    /// Indicates if this VP has changed since last issuance
    /// </summary>
    public byte ChangeIndicator { get; set; }

    /// <summary>
    /// Indicates association status between two entities
    /// </summary>
    public byte AssociationStatus { get; set; }

    /// <summary>
    /// Type of association; 8-bit enum
    /// </summary>
    public byte AssociationType { get; set; }

    /// <summary>
    /// Object ID of entity associated with this entity
    /// </summary>
    public EntityID EntityId { get; set; } = new EntityID();

    /// <summary>
    /// Station location on one's own entity
    /// </summary>
    public ushort OwnStationLocation { get; set; }

    /// <summary>
    /// Type of physical connection
    /// </summary>
    public byte PhysicalConnectionType { get; set; }

    /// <summary>
    /// Type of member the entity is within the group
    /// </summary>
    public byte GroupMemberType { get; set; }

    /// <summary>
    /// Group if any to which the entity belongs
    /// </summary>
    public ushort GroupNumber { get; set; }

}

/// <summary>
/// Unique identifier triplet for this entity.  Also referred to as EntityIdentifier
/// </summary>
public partial class EntityID
{
    /// <summary>
    /// Site ID values are unique identification number for originating site, often corresponding to an internet address.  Site ID values are agreed upon by individual simulations.
    /// </summary>
    public ushort SiteId { get; set; }

    /// <summary>
    /// Application ID values are unique identification number for originating application at a given site.  Application ID values are sssigned by individual sites.
    /// </summary>
    public ushort ApplicationId { get; set; }

    /// <summary>
    /// Entity ID values are unique identification number for s givent entity in the originating application at a given site.  Entity ID values are sssigned by individual simulation programs.
    /// </summary>
    public ushort EntityId { get; set; }

}

/// <summary>
/// Entity Identifier. Unique ID for entities in the world. Consists of an simulation address and a entity number. Section 6.2.28.
/// </summary>
public partial class EntityIdentifier
{
    /// <summary>
    /// Site and application IDs
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    /// <summary>
    /// Entity number
    /// </summary>
    public ushort EntityNumber { get; set; }

}

/// <summary>
/// Specifies the character set used in the first byte, followed by 11 characters of text data. Section 6.29
/// </summary>
public partial class EntityMarking
{
    /// <summary>
    /// The character set
    /// </summary>
    public byte CharacterSet { get; set; }

    /// <summary>
    /// The characters
    /// </summary>
    public byte[] Characters { get; set; } = new byte[11];

}

/// <summary>
/// Identifies the type of Entity
/// </summary>
public partial class EntityType
{
    /// <summary>
    /// Kind of entity
    /// </summary>
    public byte EntityKind { get; set; }

    /// <summary>
    /// Domain of entity (air, surface, subsurface, space, etc.)
    /// </summary>
    public Domain Domain { get; set; } = new Domain();

    /// <summary>
    /// country to which the design of the entity is attributed
    /// </summary>
    public ushort Country { get; set; }

    /// <summary>
    /// category of entity
    /// </summary>
    public byte Category { get; set; }

    /// <summary>
    /// subcategory based on category
    /// </summary>
    public byte SubCategory { get; set; }

    /// <summary>
    /// specific info based on subcategory
    /// </summary>
    public byte Specific { get; set; }

    public byte Extra { get; set; }

}

/// <summary>
/// Identifies the type of Entity
/// </summary>
public partial class EntityTypeRaw
{
    /// <summary>
    /// Kind of entity
    /// </summary>
    public byte EntityKind { get; set; }

    /// <summary>
    /// Domain of entity (air, surface, subsurface, space, etc.)
    /// </summary>
    public byte Domain { get; set; }

    /// <summary>
    /// country to which the design of the entity is attributed
    /// </summary>
    public ushort Country { get; set; }

    /// <summary>
    /// category of entity
    /// </summary>
    public byte Category { get; set; }

    /// <summary>
    /// subcategory of entity
    /// </summary>
    public byte SubCategory { get; set; }

    /// <summary>
    /// specific info based on subcategory field. Renamed from specific because that is a reserved word in SQL.
    /// </summary>
    public byte Specific { get; set; }

    public byte Extra { get; set; }

}

/// <summary>
/// Association or disassociation of two entities.  Section 6.2.94.5
/// </summary>
public partial class EntityTypeVP
{
    /// <summary>
    /// The identification of the Variable Parameter record.
    /// </summary>
    public byte RecordType { get; set; }

    /// <summary>
    /// Indicates if this VP has changed since last issuance
    /// </summary>
    public byte ChangeIndicator { get; set; }

    public EntityType EntityType { get; set; } = new EntityType();

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Padding1 { get; set; }

}

/// <summary>
/// Information about a geometry, a state associated with a geometry, a bounding volume, or an associated entity ID.  6.2.31, not fully defined. 'The current definitions can be found in DIS PCR 240'
/// </summary>
public partial class Environment
{
    /// <summary>
    /// Record type
    /// </summary>
    public uint EnvironmentType { get; set; }

    /// <summary>
    /// length, in bits
    /// </summary>
    public ushort Length { get; set; }

    /// <summary>
    /// Identify the sequentially numbered record index
    /// </summary>
    public byte Index { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// Geometry or state record
    /// </summary>
    public byte[] Geometry { get; set; } = new byte[0];

}

/// <summary>
/// Three floating point values representing an orientation, psi, theta, and phi, aka the euler angles, in radians. Section 6.2.33
/// </summary>
public partial class EulerAngles
{
    public float Psi { get; set; }

    public float Theta { get; set; }

    public float Phi { get; set; }

}

/// <summary>
/// Identifies an event in the world. Use this format for every PDU EXCEPT the LiveEntityPdu. Section 6.2.34.
/// </summary>
public partial class EventIdentifier
{
    /// <summary>
    /// Site and application IDs
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    public ushort EventNumber { get; set; }

}

/// <summary>
/// Identifies an event in the world. Use this format for ONLY the LiveEntityPdu. Section 6.2.34.
/// </summary>
public partial class EventIdentifierLiveEntity
{
    public byte SiteNumber { get; set; }

    public byte ApplicationNumber { get; set; }

    public ushort EventNumber { get; set; }

}

/// <summary>
/// An entity's expendable (chaff, flares, etc.) information. Section 6.2.36
/// </summary>
public partial class Expendable
{
    /// <summary>
    /// Type of expendable
    /// </summary>
    public EntityType ExpendableValue { get; set; } = new EntityType();

    public uint Station { get; set; }

    public ushort Quantity { get; set; }

    public byte ExpendableStatus { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// Burst of chaff or expendible device. Section 6.2.19.4
/// </summary>
public partial class ExpendableDescriptor
{
    /// <summary>
    /// Type of the object that exploded
    /// </summary>
    public EntityType ExpendableType { get; set; } = new EntityType();

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public long Padding { get; set; }

}

/// <summary>
/// An entity's expendable (chaff, flares, etc.) information. Section 6.2.37
/// </summary>
public partial class ExpendableReload
{
    /// <summary>
    /// Type of expendable
    /// </summary>
    public EntityType Expendable { get; set; } = new EntityType();

    public uint Station { get; set; }

    public ushort StandardQuantity { get; set; }

    public ushort MaximumQuantity { get; set; }

    public uint StandardQuantityReloadTime { get; set; }

    public uint MaximumQuantityReloadTime { get; set; }

}

/// <summary>
/// Explosion of a non-munition. Section 6.2.19.3
/// </summary>
public partial class ExplosionDescriptor
{
    /// <summary>
    /// Type of the object that exploded. See 6.2.30
    /// </summary>
    public EntityType ExplodingObject { get; set; } = new EntityType();

    /// <summary>
    /// Material that exploded. Can be grain dust, tnt, gasoline, etc. Enumeration
    /// </summary>
    public ushort ExplosiveMaterial { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// Force of explosion, in equivalent KG of TNT
    /// </summary>
    public float ExplosiveForce { get; set; }

}

/// <summary>
/// The False Targets attribute record shall be used to communicate discrete values that are associated with false targets jamming that cannot be referenced to an emitter mode. The values provided in the False Targets attri- bute record shall be considered valid only for the victim radar beams listed in the jamming beam's Track/Jam Data records (provided in the associated Electromagnetic Emission PDU). Section 6.2.21.3
/// </summary>
public partial class FalseTargetsAttribute
{
    /// <summary>
    /// record type
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// The length of the record in octets.
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// This field indicates the emitter system generating the false targets.
    /// </summary>
    public byte EmitterNumber { get; set; }

    /// <summary>
    /// This field indicates the jamming beam generating the false targets.
    /// </summary>
    public byte BeamNumber { get; set; }

    /// <summary>
    /// This field shall be used to indicate if false target data have changed since issuance of the last False Targets attribute record for this beam, if the False Targets attribute record is part of a heartbeat update to meet periodic update requirements or if false target data for the beam has ceased.
    /// </summary>
    public byte StateIndicator { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding2 { get; set; }

    public ushort Padding3 { get; set; }

    /// <summary>
    /// This field indicates the jamming beam generating the false targets.
    /// </summary>
    public ushort FalseTargetCount { get; set; }

    /// <summary>
    /// This field shall specify the speed (in meters per second) at which false targets move toward the victim radar. Negative values shall indicate a velocity away from the victim radar.
    /// </summary>
    public float WalkSpeed { get; set; }

    /// <summary>
    /// This field shall specify the rate (in meters per second squared) at which false tar- gets accelerate toward the victim radar. Negative values shall indicate an acceleration direction away from the victim radar.
    /// </summary>
    public float WalkAcceleration { get; set; }

    /// <summary>
    /// This field shall specify the distance (in meters) that a false target is to walk before it pauses in range.
    /// </summary>
    public float MaximumWalkDistance { get; set; }

    /// <summary>
    /// This field shall specify the time (in seconds) that a false target is to be held at the Maxi- mum Walk Distance before it resets to its initial position.
    /// </summary>
    public float KeepTime { get; set; }

    /// <summary>
    /// This field shall specify the distance between false targets in meters. Positive values for this field shall indicate that second and subsequent false targets are initially placed at increasing ranges from the victim radar.
    /// </summary>
    public float EchoSpacing { get; set; }

    /// <summary>
    /// Sets the position of the first false target relative to the jamming entity in meters.
    /// </summary>
    public float FirstTargetOffset { get; set; }

}

/// <summary>
/// Fixed Datum Record. Section 6.2.37
/// </summary>
public partial class FixedDatum
{
    /// <summary>
    /// ID of the fixed datum, an enumeration
    /// </summary>
    public uint FixedDatumId { get; set; }

    /// <summary>
    /// Value for the fixed datum
    /// </summary>
    public uint FixedDatumValue { get; set; }

}

/// <summary>
/// Basic operational data for IFF. Section 6.2.39
/// </summary>
public partial class FundamentalOperationalData
{
    /// <summary>
    /// system status, IEEE DIS 7 defined
    /// </summary>
    public byte SystemStatus { get; set; }

    /// <summary>
    /// data field 1
    /// </summary>
    public byte DataField1 { get; set; }

    /// <summary>
    /// eight boolean fields
    /// </summary>
    public byte InformationLayers { get; set; }

    /// <summary>
    /// enumeration
    /// </summary>
    public byte DataField2 { get; set; }

    /// <summary>
    /// parameter, enumeration
    /// </summary>
    public ushort Parameter1 { get; set; }

    /// <summary>
    /// parameter, enumeration
    /// </summary>
    public ushort Parameter2 { get; set; }

    /// <summary>
    /// parameter, enumeration
    /// </summary>
    public ushort Parameter3 { get; set; }

    /// <summary>
    /// parameter, enumeration
    /// </summary>
    public ushort Parameter4 { get; set; }

    /// <summary>
    /// parameter, enumeration
    /// </summary>
    public ushort Parameter5 { get; set; }

    /// <summary>
    /// parameter, enumeration
    /// </summary>
    public ushort Parameter6 { get; set; }

}

/// <summary>
/// Detailed information about the grid dimensions (axes) and coordinates for environmental state variables
/// </summary>
public partial class GridAxisDescriptor
{
    /// <summary>
    /// coordinate of the grid origin or initial value
    /// </summary>
    public double DomainInitialXi { get; set; }

    /// <summary>
    /// coordinate of the endpoint or final value
    /// </summary>
    public double DomainFinalXi { get; set; }

    /// <summary>
    /// The number of grid points along the Xi domain axis for the enviornmental state data
    /// </summary>
    public ushort DomainPointsXi { get; set; }

    /// <summary>
    /// interleaf factor along the domain axis.
    /// </summary>
    public byte InterleafFactor { get; set; }

    /// <summary>
    /// type of grid axis
    /// </summary>
    public byte AxisType { get; set; }

}

/// <summary>
/// Grid axis record for fixed data. Section 6.2.41
/// </summary>
public partial class GridAxisDescriptorFixed : GridAxisDescriptor
{
    /// <summary>
    /// Number of grid locations along Xi axis
    /// </summary>
    public ushort NumberOfPointsOnXiAxis { get; set; }

    /// <summary>
    /// initial grid point for the current pdu
    /// </summary>
    public ushort InitialIndex { get; set; }

}

/// <summary>
/// Grid axis descriptor fo variable spacing axis data.
/// </summary>
public partial class GridAxisDescriptorVariable : GridAxisDescriptor
{
    /// <summary>
    /// Number of grid locations along Xi axis
    /// </summary>
    public ushort NumberOfPointsOnXiAxis { get; set; }

    /// <summary>
    /// initial grid point for the current pdu
    /// </summary>
    public ushort InitialIndex { get; set; }

    /// <summary>
    /// value that linearly scales the coordinates of the grid locations for the xi axis
    /// </summary>
    public double CoordinateScaleXi { get; set; }

    /// <summary>
    /// The constant offset value that shall be applied to the grid locations for the xi axis
    /// </summary>
    public double CoordinateOffsetXi { get; set; }

    /// <summary>
    /// list of coordinates
    /// </summary>
    public ushort[] XiValues { get; set; } = new ushort[0];

}

/// <summary>
/// 6.2.41, table 68
/// </summary>
public partial class GridData
{
    public ushort SampleType { get; set; }

    public ushort DataRepresentation { get; set; }

}

/// <summary>
/// 6.2.41, table 68
/// </summary>
public partial class GridDataType0 : GridData
{
    internal ushort NumberOfBytes { get; set; }

    public byte[] DataValues { get; set; } = [];

}

/// <summary>
/// 6.2.41, table 69
/// </summary>
public partial class GridDataType1 : GridData
{
    public float FieldScale { get; set; }

    public float FieldOffset { get; set; }

    internal ushort NumberOfValues { get; set; }

    public ushort[] DataValues { get; set; } = [];

}

/// <summary>
/// 6.2.41, table 70
/// </summary>
public partial class GridDataType2 : GridData
{
    internal ushort NumberOfValues { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    public float[] DataValues { get; set; } = [];

}

/// <summary>
/// Unique designation of a group of entities contained in the isGroupOfPdu. Represents a group of entities rather than a single entity. Section 6.2.43
/// </summary>
public partial class GroupID
{
    /// <summary>
    /// Simulation address (site and application number)
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    /// <summary>
    /// group number
    /// </summary>
    public ushort GroupNumber { get; set; }

}

/// <summary>
/// repeating element in IFF Data specification record
/// </summary>
public partial class IFFData
{
    /// <summary>
    /// enumeration for type of record
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// length of record, including padding
    /// </summary>
    public ushort RecordLength { get; set; }

    public byte[] RecordSpecificFields { get; set; } = [];

}

/// <summary>
/// Requires hand coding to be useful. Section 6.2.43
/// </summary>
public partial class IFFDataSpecification
{
    /// <summary>
    /// Number of IFF records
    /// </summary>
    internal ushort NumberOfIFFDataRecords { get; set; }

    /// <summary>
    /// IFF data records
    /// </summary>
    public List<IFFData> IffDataRecords { get; set; } = [];

}

/// <summary>
/// Fundamental IFF atc data. Section 6.2.44
/// </summary>
public partial class IFFFundamentalParameterData
{
    /// <summary>
    /// ERP
    /// </summary>
    public float Erp { get; set; }

    /// <summary>
    /// frequency
    /// </summary>
    public float Frequency { get; set; }

    /// <summary>
    /// pgrf
    /// </summary>
    public float Pgrf { get; set; }

    /// <summary>
    /// Pulse width
    /// </summary>
    public float PulseWidth { get; set; }

    /// <summary>
    /// Burst length
    /// </summary>
    public uint BurstLength { get; set; }

    /// <summary>
    /// Applicable modes enumeration
    /// </summary>
    public byte ApplicableModes { get; set; }

    /// <summary>
    /// System-specific data
    /// </summary>
    public byte[] SystemSpecificData { get; set; } = new byte[3];

}

/// <summary>
/// 6.2.48.2
/// </summary>
public partial class IOCommsNodeRecord : IORecord
{
    public uint RecordType { get; set; }

    public ushort RecordLength { get; set; }

    public byte CommsNodeType { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

    public CommunicationsNodeID CommsNodeId { get; set; } = new CommunicationsNodeID();

}

/// <summary>
/// 6.2.48.3
/// </summary>
public partial class IOEffectRecord : IORecord
{
    public uint RecordType { get; set; }

    public ushort RecordLength { get; set; }

    public byte IoStatus { get; set; }

    public byte IoLinkType { get; set; }

    public byte IoEffect { get; set; }

    public byte IoEffectDutyCycle { get; set; }

    public ushort IoEffectDuration { get; set; }

    public ushort IoProcess { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

}

/// <summary>
/// 6.2.48
/// </summary>
public partial class IORecord
{
}

/// <summary>
/// Intercom communications parameters. Section 6.2.46
/// </summary>
public partial class IntercomCommunicationsParameters
{
    /// <summary>
    /// Type of intercom parameters record
    /// </summary>
    public ushort RecordType { get; set; }

    /// <summary>
    /// length of record
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// This is a placeholder.
    /// </summary>
    public byte[] RecordSpecificField { get; set; } = new byte[0];

}

/// <summary>
/// Unique designation of an attached or unattached intercom in an event or exercirse. Section 6.2.48
/// </summary>
public partial class IntercomIdentifier
{
    public ushort SiteNumber { get; set; }

    public ushort ApplicationNumber { get; set; }

    public ushort ReferenceNumber { get; set; }

    public ushort IntercomNumber { get; set; }

}

/// <summary>
/// Jamming technique. Section 6.2.49, uid 284
/// </summary>
public partial class JammingTechnique
{
    public byte Kind { get; set; }

    public byte Category { get; set; }

    public byte SubCategory { get; set; }

    public byte Specific { get; set; }

}

/// <summary>
/// 3 x 8-bit fixed binary
/// </summary>
public partial class LEVector3FixedByte
{
    /// <summary>
    /// X value
    /// </summary>
    public byte X { get; set; }

    /// <summary>
    /// y Value
    /// </summary>
    public byte Y { get; set; }

    /// <summary>
    /// Z value
    /// </summary>
    public byte Z { get; set; }

}

/// <summary>
/// Identity of a communications node. Section 6.2.50
/// </summary>
public partial class LaunchedMunitionRecord
{
    public EventIdentifier FireEventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    public EntityID FiringEntityId { get; set; } = new EntityID();

    public ushort Padding2 { get; set; }

    public EntityID TargetEntityId { get; set; } = new EntityID();

    public ushort Padding3 { get; set; }

    public Vector3Double TargetLocation { get; set; } = new Vector3Double();

}

/// <summary>
/// The identification of the additional information layer number, layer-specific information, and the length of the layer. Section 6.2.51
/// </summary>
public partial class LayerHeader
{
    public byte LayerNumber { get; set; }

    /// <summary>
    /// field shall specify layer-specific information that varies by System Type (see 6.2.86) and Layer Number.
    /// </summary>
    public byte LayerSpecificInformation { get; set; }

    /// <summary>
    /// This field shall specify the length in octets of the layer, including the Layer Header record
    /// </summary>
    public ushort Length { get; set; }

}

/// <summary>
/// The specification of an individual segment of a linear segment synthetic environment object in a Linear Object State PDU Section 6.2.52
/// </summary>
public partial class LinearSegmentParameter
{
    /// <summary>
    /// The individual segment of the linear segment
    /// </summary>
    public byte SegmentNumber { get; set; }

    /// <summary>
    /// whether a modification has been made to the point object's location or orientation
    /// </summary>
    public ushort SegmentModification { get; set; }

    /// <summary>
    /// general dynamic appearance attributes of the segment. This record shall be defined as a 16-bit record of enumerations. The values defined for this record are included in Section 12 of SISO-REF-010.
    /// </summary>
    public ushort GeneralSegmentAppearance { get; set; }

    /// <summary>
    /// This field shall specify specific dynamic appearance attributes of the segment. This record shall be defined as a 32-bit record of enumerations.
    /// </summary>
    public uint SpecificSegmentAppearance { get; set; }

    /// <summary>
    /// This field shall specify the location of the linear segment in the simulated world and shall be represented by a World Coordinates record
    /// </summary>
    public Vector3Double SegmentLocation { get; set; } = new Vector3Double();

    /// <summary>
    /// orientation of the linear segment about the segment location and shall be represented by a Euler Angles record
    /// </summary>
    public EulerAngles SegmentOrientation { get; set; } = new EulerAngles();

    /// <summary>
    /// length of the linear segment, in meters, extending in the positive X direction
    /// </summary>
    public float SegmentLength { get; set; }

    /// <summary>
    /// The total width of the linear segment, in meters, shall be specified by a 16-bit unsigned integer. One-half of the width shall extend in the positive Y direction, and one-half of the width shall extend in the negative Y direction.
    /// </summary>
    public float SegmentWidth { get; set; }

    /// <summary>
    /// The height of the linear segment, in meters, above ground shall be specified by a 16-bit unsigned integer.
    /// </summary>
    public float SegmentHeight { get; set; }

    /// <summary>
    /// The depth of the linear segment, in meters, below ground level
    /// </summary>
    public float SegmentDepth { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public uint Padding { get; set; }

}

/// <summary>
/// 16-bit fixed binaries
/// </summary>
public partial class LiveDeadReckoningParameters
{
    public byte DeadReckoningAlgorithm { get; set; }

    public LEVector3FixedByte EntityLinearAcceleration { get; set; } = new LEVector3FixedByte();

    public LEVector3FixedByte EntityAngularVelocity { get; set; } = new LEVector3FixedByte();

}

/// <summary>
/// The unique designation of each entity in an event or exercise that is contained in a Live Entity PDU. Section 6.2.54
/// </summary>
public partial class LiveEntityIdentifier
{
    /// <summary>
    /// Live Simulation Address record (see 6.2.54)
    /// </summary>
    public LiveSimulationAddress LiveSimulationAddress { get; set; } = new LiveSimulationAddress();

    /// <summary>
    /// Live entity number
    /// </summary>
    public ushort EntityNumber { get; set; }

}

/// <summary>
/// 16-bit fixed binaries
/// </summary>
public partial class LiveEntityLinearVelocity
{
    public ushort XComponent { get; set; }

    public ushort YComponent { get; set; }

    public ushort ZComponent { get; set; }

}

/// <summary>
/// 8-bit fixed binaries
/// </summary>
public partial class LiveEntityOrientation
{
    public byte Psi { get; set; }

    public byte Theta { get; set; }

    public byte Phi { get; set; }

}

/// <summary>
/// 16-bit fixed binaries
/// </summary>
public partial class LiveEntityOrientation16
{
    public ushort Psi { get; set; }

    public ushort Theta { get; set; }

    public ushort Phi { get; set; }

}

/// <summary>
/// 16-bit fixed binaries
/// </summary>
public partial class LiveEntityOrientationError
{
    public ushort AzimuthError { get; set; }

    public ushort ElevationError { get; set; }

    public ushort RotationError { get; set; }

}

/// <summary>
/// 16-bit fixed binaries
/// </summary>
public partial class LiveEntityPositionError
{
    public ushort HorizontalError { get; set; }

    public ushort VerticalError { get; set; }

}

/// <summary>
/// 16-bit fixed binaries
/// </summary>
public partial class LiveEntityRelativeWorldCoordinates
{
    public ushort ReferencePoint { get; set; }

    public ushort DeltaX { get; set; }

    public ushort DeltaY { get; set; }

    public ushort DeltaZ { get; set; }

}

/// <summary>
/// A simulation's designation associated with all Live Entity IDs contained in Live Entity PDUs. Section 6.2.55
/// </summary>
public partial class LiveSimulationAddress
{
    /// <summary>
    /// facility, installation, organizational unit or geographic location may have multiple sites associated with it. The Site Number is the first component of the Live Simulation Address, which defines a live simulation.
    /// </summary>
    public byte LiveSiteNumber { get; set; }

    /// <summary>
    /// An application associated with a live site is termed a live application. Each live application participating in an event
    /// </summary>
    public byte LiveApplicationNumber { get; set; }

}

/// <summary>
/// The unique designation of a mine contained in the Minefield Data PDU. No espdus are issued for mine entities.  Section 6.2.55
/// </summary>
public partial class MineEntityIdentifier
{
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    public ushort MineEntityNumber { get; set; }

}

/// <summary>
/// The unique designation of a minefield Section 6.2.56
/// </summary>
public partial class MinefieldIdentifier
{
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    public ushort MinefieldNumber { get; set; }

}

/// <summary>
/// Information about a minefield sensor. Section 6.2.57
/// </summary>
public partial class MinefieldSensorType
{
    /// <summary>
    /// sensor type. bit fields 0-3 are the type category, 4-15 are teh subcategory
    /// </summary>
    public ushort SensorType { get; set; }

}

/// <summary>
/// Modulation parameters associated with a specific radio system.  6.2.58
/// </summary>
public partial class ModulationParameters
{
    public byte[] RecordSpecificFields { get; set; } = new byte[0];

}

/// <summary>
/// Information about the type of modulation used for radio transmission. 6.2.59
/// </summary>
public partial class ModulationType
{
    /// <summary>
    /// This field shall indicate the spread spectrum technique or combination of spread spectrum techniques in use. Bit field. 0=freq hopping, 1=psuedo noise, time hopping=2, reamining bits unused
    /// </summary>
    public ushort SpreadSpectrum { get; set; }

    /// <summary>
    /// The major classification of the modulation type.
    /// </summary>
    public ushort MajorModulation { get; set; }

    /// <summary>
    /// provide certain detailed information depending upon the major modulation type, uid 156-162
    /// </summary>
    public ushort Detail { get; set; }

    /// <summary>
    /// The radio system associated with this Transmitter PDU and shall be used as the basis to interpret other fields whose values depend on a specific radio system.
    /// </summary>
    public ushort RadioSystem { get; set; }

}

/// <summary>
/// An entity's munition (e.g., bomb, missile) information shall be represented by one or more Munition records. For each type or location of munition, this record shall specify the type, location, quantity and status of munitions that an entity contains. Section 6.2.60
/// </summary>
public partial class Munition
{
    /// <summary>
    /// This field shall identify the entity type of the munition. See section 6.2.30.
    /// </summary>
    public EntityType MunitionType { get; set; } = new EntityType();

    /// <summary>
    /// The station or launcher to which the munition is assigned. See Annex I
    /// </summary>
    public uint Station { get; set; }

    /// <summary>
    /// The quantity remaining of this munition.
    /// </summary>
    public ushort Quantity { get; set; }

    /// <summary>
    /// the status of the munition. It shall be represented by an 8-bit enumeration.
    /// </summary>
    public byte MunitionStatus { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// Represents the firing or detonation of a munition. Section 6.2.19.2
/// </summary>
public partial class MunitionDescriptor
{
    /// <summary>
    /// What munition was used in the burst
    /// </summary>
    public EntityType MunitionType { get; set; } = new EntityType();

    /// <summary>
    /// type of warhead enumeration
    /// </summary>
    public ushort Warhead { get; set; }

    /// <summary>
    /// type of fuse used enumeration
    /// </summary>
    public ushort Fuse { get; set; }

    /// <summary>
    /// how many of the munition were fired
    /// </summary>
    public ushort Quantity { get; set; }

    /// <summary>
    /// rate at which the munition was fired
    /// </summary>
    public ushort Rate { get; set; }

}

/// <summary>
/// indicate weapons (munitions) previously communicated via the Munition record. Section 6.2.61
/// </summary>
public partial class MunitionReload
{
    /// <summary>
    /// This field shall identify the entity type of the munition. See section 6.2.30.
    /// </summary>
    public EntityType MunitionType { get; set; } = new EntityType();

    /// <summary>
    /// The station or launcher to which the munition is assigned. See Annex I
    /// </summary>
    public uint Station { get; set; }

    /// <summary>
    /// The standard quantity of this munition type normally loaded at this station/launcher if a station/launcher is specified.
    /// </summary>
    public ushort StandardQuantity { get; set; }

    /// <summary>
    /// The maximum quantity of this munition type that this station/launcher is capable of holding when a station/launcher is specified
    /// </summary>
    public ushort MaximumQuantity { get; set; }

    /// <summary>
    /// numer of seconds of sim time required to reload the std qty
    /// </summary>
    public uint StandardQuantityReloadTime { get; set; }

    /// <summary>
    /// The number of seconds of sim time required to reload the max possible quantity
    /// </summary>
    public uint MaximumQuantityReloadTime { get; set; }

}

/// <summary>
/// Information about the discrete positional relationship of the part entity with respect to the its host entity Section 6.2.62
/// </summary>
public partial class NamedLocationIdentification
{
    /// <summary>
    /// The station name within the host at which the part entity is located. If the part entity is On Station, this field shall specify the representation of the part's location data fields. This field shall be specified by a 16-bit enumeration
    /// </summary>
    public ushort StationName { get; set; }

    /// <summary>
    /// The number of the particular wing station, cargo hold etc., at which the part is attached.
    /// </summary>
    public ushort StationNumber { get; set; }

}

/// <summary>
/// The unique designation of an environmental object. Section 6.2.63
/// </summary>
public partial class ObjectIdentifier
{
    /// <summary>
    /// Simulation Address
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    /// <summary>
    /// object number
    /// </summary>
    public ushort ObjectNumber { get; set; }

}

/// <summary>
/// The unique designation of an environmental object. Section 6.2.64
/// </summary>
public partial class ObjectType
{
    /// <summary>
    /// Domain of entity (air, surface, subsurface, space, etc.)
    /// </summary>
    public byte Domain { get; set; }

    /// <summary>
    /// country to which the design of the entity is attributed
    /// </summary>
    public byte ObjectKind { get; set; }

    /// <summary>
    /// category of entity
    /// </summary>
    public byte Category { get; set; }

    /// <summary>
    /// subcategory of entity
    /// </summary>
    public byte SubCategory { get; set; }

}

/// <summary>
/// used to convey entity and conflict status information associated with transferring ownership of an entity. Section 6.2.65
/// </summary>
public partial class OwnershipStatusRecord
{
    /// <summary>
    /// EntityID
    /// </summary>
    public EntityID EntityId { get; set; } = new EntityID();

    /// <summary>
    /// The ownership and/or ownership conflict status of the entity represented by the Entity ID field.
    /// </summary>
    public byte OwnershipStatus { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// Base class of PduBase and LiveEntityPdu
/// </summary>
public abstract partial class Pdu
{
    /// <summary>
    /// The version of the protocol. 5=DIS-1995, 6=DIS-1998, 7=DIS-2012
    /// </summary>
    public byte ProtocolVersion { get; set; }

    /// <summary>
    /// Exercise ID provides a unique identifier
    /// </summary>
    public byte ExerciseId { get; set; }

    /// <summary>
    /// Type of pdu, unique for each PDU class
    /// </summary>
    public byte PduType { get; set; }

    /// <summary>
    /// value that refers to the protocol family, eg SimulationManagement, et
    /// </summary>
    public byte ProtocolFamily { get; set; }

    /// <summary>
    /// Timestamp value, int representing number of 1.675 microseconds as interval past hour
    /// </summary>
    public uint Timestamp { get; set; }

    /// <summary>
    /// Length, in bytes, of the PDU
    /// </summary>
    public ushort Length { get; set; }

}

/// <summary>
/// The superclass for all PDUs except LiveEntity. This incorporates the PduHeader record, section 7.2.2
/// </summary>
public abstract partial class PduBase : Pdu
{
    /// <summary>
    /// PDU Status Record. Described in 6.2.67. This field is not present in earlier DIS versions
    /// </summary>
    public PduStatus PduStatus { get; set; } = new PduStatus();

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// PduStatus provides a set of bit-masked indicator values, section 6.2.67.                       Bit fields include Transferred Entity Indicator (TEI), LVC Indicator (LVC), Coupled Extension Indicator (CEI),                     Fire Type Indicator (FTI), Detonation Type Indicator (DTI), Radio Attached Indicator (RAI),                     Intercom Attached Indicator (IAI), IFF Simulation Mode (ISM) and Active Interrogation Indicator (AII).
/// </summary>
public partial class PduStatus
{
    /// <summary>
    /// PDU Status Record value containing bitmasked field
    /// </summary>
    public byte Value { get; set; }

}

/// <summary>
/// contains information describing the propulsion systems of the entity. This information shall be provided for each active propulsion system defined. Section 6.2.68
/// </summary>
public partial class PropulsionSystemData
{
    /// <summary>
    /// powerSetting
    /// </summary>
    public float PowerSetting { get; set; }

    /// <summary>
    /// engine RPMs
    /// </summary>
    public float EngineRpm { get; set; }

}

/// <summary>
/// Bit field used to identify minefield data. bits 14-15 are a 2-bit enum, other bits unused. Section 6.2.69
/// </summary>
public partial class ProtocolMode
{
    /// <summary>
    /// Bitfields, 14-15 contain an enum, uid 336
    /// </summary>
    public ushort ProtocolModeValue { get; set; }

}

/// <summary>
/// The unique designation of an attached or unattached radio in an event or exercise Section 6.2.70
/// </summary>
public partial class RadioIdentifier
{
    /// <summary>
    /// site
    /// </summary>
    public ushort SiteNumber { get; set; }

    /// <summary>
    /// application number
    /// </summary>
    public ushort ApplicationNumber { get; set; }

    /// <summary>
    /// reference number
    /// </summary>
    public ushort ReferenceNumber { get; set; }

    /// <summary>
    /// Radio number
    /// </summary>
    public ushort RadioNumber { get; set; }

}

/// <summary>
/// Identifies the type of radio. Section 6.2.71
/// </summary>
public partial class RadioType
{
    /// <summary>
    /// Kind of entity
    /// </summary>
    public byte EntityKind { get; set; }

    /// <summary>
    /// Domain of entity (air, surface, subsurface, space, etc.)
    /// </summary>
    public byte Domain { get; set; }

    /// <summary>
    /// country to which the design of the entity is attributed
    /// </summary>
    public ushort Country { get; set; }

    /// <summary>
    /// category of entity
    /// </summary>
    public byte Category { get; set; }

    /// <summary>
    /// specific info based on subcategory field
    /// </summary>
    public byte Subcategory { get; set; }

    public byte Specific { get; set; }

    public byte Extra { get; set; }

}

/// <summary>
/// The identification of the records being queried 6.2.72
/// </summary>
public partial class RecordQuerySpecification
{
    internal uint NumberOfRecords { get; set; }

    /// <summary>
    /// variable length list of 32-bit record types
    /// </summary>
    public List<uint> RecordIds { get; set; } = [];

}

/// <summary>
/// This record shall specify the number of record sets contained in the Record Specification record and the record details. Section 6.2.73.
/// </summary>
public partial class RecordSpecification
{
    /// <summary>
    /// The number of record sets
    /// </summary>
    internal uint NumberOfRecordSets { get; set; }

    /// <summary>
    /// variable length list record specifications.
    /// </summary>
    public List<RecordSpecificationElement> RecordSets { get; set; } = [];

}

/// <summary>
/// Synthetic record, made up from section 6.2.73. This is used to achieve a repeating variable list element.&lt;p&gt;recordLength, recordCount and recordValues must be set by hand so the.
/// </summary>
public partial class RecordSpecificationElement
{
    /// <summary>
    /// The data structure used to convey the parameter values of the record for each record. 32-bit enumeration.
    /// </summary>
    public uint RecordId { get; set; }

    /// <summary>
    /// The serial number of the first record in the block of records
    /// </summary>
    public uint RecordSetSerialNumber { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public uint Padding { get; set; }

    /// <summary>
    /// the length, in bits, of the record. Note, bits, not bytes.
    /// </summary>
    public ushort RecordLength { get; set; }

    /// <summary>
    /// the number of records included in the record set
    /// </summary>
    public ushort RecordCount { get; set; }

    /// <summary>
    /// The concatenated records of the format specified by the Record ID field. The length of this field is the Record Length multiplied by the Record Count, in units of bits.
    /// </summary>
    public byte[] RecordValues { get; set; } = new byte[0];

    /// <summary>
    /// used if required to make entire record size an even multiple of 8 bytes
    /// </summary>
    public byte[] PadTo64 { get; set; } = new byte[0];

}

/// <summary>
/// The relationship of the part entity to its host entity. Section 6.2.74.
/// </summary>
public partial class Relationship
{
    /// <summary>
    /// The nature or purpose for joining of the part entity to the host entity and shall be represented by a 16-bit enumeration
    /// </summary>
    public ushort Nature { get; set; }

    /// <summary>
    /// The position of the part entity with respect to the host entity and shall be represented by a 16-bit enumeration
    /// </summary>
    public ushort Position { get; set; }

}

/// <summary>
/// A monotonically increasing number inserted into all simulation managment PDUs. This should be a hand-coded thingie, maybe a singleton. Section 6.2.75
/// </summary>
public partial class RequestID
{
    /// <summary>
    /// monotonically increasing number
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Additional operational data for an IFF emitting system and the number of IFF Fundamental Parameter Data records Section 6.2.76.
/// </summary>
public partial class SecondaryOperationalData
{
    /// <summary>
    /// additional operational characteristics of the IFF emitting system. Each 8-bit field will vary depending on the system type.
    /// </summary>
    public byte OperationalData1 { get; set; }

    /// <summary>
    /// additional operational characteristics of the IFF emitting system. Each 8-bit field will vary depending on the system type.
    /// </summary>
    public byte OperationalData2 { get; set; }

    /// <summary>
    /// The number of IFF Fundamental Parameter Data records that follow
    /// </summary>
    public ushort NumberOfIFFFundamentalParameterRecords { get; set; }

}

/// <summary>
/// An entity's sensor information.  Section 6.2.77.
/// </summary>
public partial class Sensor
{
    /// <summary>
    /// the source of the Sensor Type field
    /// </summary>
    public byte SensorTypeSource { get; set; }

    /// <summary>
    /// The on/off status of the sensor
    /// </summary>
    public byte SensorOnOffStatus { get; set; }

    /// <summary>
    /// for Source 'other':SensorRecordOtherActiveSensors/325,'em':EmitterName/75,'passive':SensorRecordSensorTypePassiveSensors/326,'mine':6.2.57,'ua':UAAcousticSystemName/144,'lasers':DesignatorSystemName/80
    /// </summary>
    public ushort SensorType { get; set; }

    /// <summary>
    /// the station to which the sensor is assigned. A zero value shall indi- cate that this Sensor record is not associated with any particular station and represents the total quan- tity of this sensor for this entity. If this field is non-zero, it shall either reference an attached part or an articulated part
    /// </summary>
    public uint Station { get; set; }

    /// <summary>
    /// quantity of the sensor
    /// </summary>
    public ushort Quantity { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

}

/// <summary>
/// Physical separation of an entity from another entity.  Section 6.2.94.6
/// </summary>
public partial class SeparationVP
{
    /// <summary>
    /// The identification of the Variable Parameter record. Enumeration from EBV
    /// </summary>
    public byte RecordType { get; set; }

    /// <summary>
    /// Reason for separation. EBV
    /// </summary>
    public byte ReasonForSeparation { get; set; }

    /// <summary>
    /// Whether the entity existed prior to separation EBV
    /// </summary>
    public byte PreEntityIndicator { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// ID of parent
    /// </summary>
    public EntityID ParentEntityId { get; set; } = new EntityID();

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

    /// <summary>
    /// Station separated from
    /// </summary>
    public NamedLocationIdentification StationLocation { get; set; } = new NamedLocationIdentification();

}

/// <summary>
/// Current Shaft RPM, Ordered Shaft RPM for use by Underwater Acoustic (UA) PDU. Section 7.6.4
/// </summary>
public partial class ShaftRPM
{
    public ushort CurrentRPM { get; set; }

    public ushort OrderedRPM { get; set; }

    public int RPMrateOfChange { get; set; }

}

/// <summary>
/// information abou an enitity not producing espdus. Section 6.2.79
/// </summary>
public partial class SilentEntitySystem
{
    /// <summary>
    /// number of the type specified by the entity type field
    /// </summary>
    public ushort NumberOfEntities { get; set; }

    /// <summary>
    /// number of entity appearance records that follow
    /// </summary>
    internal ushort NumberOfAppearanceRecords { get; set; }

    /// <summary>
    /// Entity type
    /// </summary>
    public EntityType EntityType { get; set; } = new EntityType();

    /// <summary>
    /// Variable length list of appearance records
    /// </summary>
    public uint[] AppearanceRecordList { get; set; } = new uint[0];

}

/// <summary>
/// A Simulation Address record shall consist of the Site Identification number and the Application Identification number. Section 6.2.79
/// </summary>
public partial class SimulationAddress
{
    /// <summary>
    /// A site is defined as a facility, installation, organizational unit or a geographic location that has one or more simulation applications capable of participating in a distributed event.
    /// </summary>
    public ushort Site { get; set; }

    /// <summary>
    /// An application is defined as a software program that is used to generate and process distributed simulation data including live, virtual and constructive data.
    /// </summary>
    public ushort Application { get; set; }

}

/// <summary>
/// The unique designation of a simulation when using the 48-bit identifier format shall be specified by the Sim- ulation Identifier record. The reason that the 48-bit format is required in addition to the 32-bit simulation address format that actually identifies a specific simulation is because some 48-bit identifier fields in PDUs may contain either an Object Identifier, such as an Entity ID, or a Simulation Identifier. Section 6.2.80
/// </summary>
public partial class SimulationIdentifier
{
    /// <summary>
    /// Simulation address
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    /// <summary>
    /// This field shall be set to zero as there is no reference number associated with a Simulation Identifier.
    /// </summary>
    public ushort ReferenceNumber { get; set; }

}

/// <summary>
/// Section 6.2.83
/// </summary>
public partial class StandardVariableRecord
{
    public uint RecordType { get; set; }

    internal ushort RecordLength { get; set; }

    public byte[] RecordSpecificFields { get; set; } = new byte[0];

}

/// <summary>
/// Does not work, and causes failure in anything it is embedded in. Section 6.2.83
/// </summary>
public partial class StandardVariableSpecification
{
    /// <summary>
    /// Number of static variable records
    /// </summary>
    public ushort NumberOfStandardVariableRecords { get; set; }

    /// <summary>
    /// variable length list of standard variables, The class type and length here are WRONG and will cause the incorrect serialization of any class in whihc it is embedded.
    /// </summary>
    public List<StandardVariableRecord> StandardVariables { get; set; } = [];

}

/// <summary>
/// Information about an entity's engine fuel. Section 6.2.84.
/// </summary>
public partial class StorageFuel
{
    /// <summary>
    /// Fuel quantity, units specified by next field
    /// </summary>
    public uint FuelQuantity { get; set; }

    /// <summary>
    /// Units in which the fuel is measured
    /// </summary>
    public byte FuelMeasurementUnits { get; set; }

    /// <summary>
    /// Type of fuel
    /// </summary>
    public byte FuelType { get; set; }

    /// <summary>
    /// Location of fuel as related to entity. See section 14 of EBV document
    /// </summary>
    public byte FuelLocation { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// For each type or location of Storage Fuel, this record shall specify the type, location, fuel measure- ment units, reload quantity and maximum quantity for storage fuel either for the whole entity or a specific storage fuel location (tank). Section 6.2.85.
/// </summary>
public partial class StorageFuelReload
{
    /// <summary>
    /// the standard quantity of this fuel type normally loaded at this station/launcher if a station/launcher is specified. If the Station/Launcher field is set to zero, then this is the total quantity of this fuel type that would be present in a standard reload of all appli- cable stations/launchers associated with this entity.
    /// </summary>
    public uint StandardQuantity { get; set; }

    /// <summary>
    /// The maximum quantity of this fuel type that this sta- tion/launcher is capable of holding when a station/launcher is specified. This would be the value used when a maximum reload was desired to be set for this station/launcher. If the Station/launcher field is set to zero, then this is the maximum quantity of this fuel type that would be present on this entity at all stations/launchers that can accept this fuel type.
    /// </summary>
    public uint MaximumQuantity { get; set; }

    /// <summary>
    /// The seconds normally required to reload the standard quantity of this fuel type at this specific station/launcher. When the Station/Launcher field is set to zero, this shall be the time it takes to perform a standard quantity reload of this fuel type at all applicable stations/launchers for this entity.
    /// </summary>
    public uint StandardQuantityReloadTime { get; set; }

    /// <summary>
    /// The seconds normally required to reload the maximum possible quantity of this fuel type at this station/launcher. When the Station/Launcher field is set to zero, this shall be the time it takes to perform a maximum quantity load/reload of this fuel type at all applicable stations/launchers for this entity.
    /// </summary>
    public uint MaximumQuantityReloadTime { get; set; }

    /// <summary>
    /// The fuel measurement units. Enumeration
    /// </summary>
    public byte FuelMeasurementUnits { get; set; }

    /// <summary>
    /// Fuel type
    /// </summary>
    public byte FuelType { get; set; }

    /// <summary>
    /// Location of fuel as related to entity. See section 14 of EBV document
    /// </summary>
    public byte FuelLocation { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// A supply, and the amount of that supply. Section 6.2.86
/// </summary>
public partial class SupplyQuantity
{
    /// <summary>
    /// Type of supply
    /// </summary>
    public EntityType SupplyType { get; set; } = new EntityType();

    /// <summary>
    /// The number of units of a supply type.
    /// </summary>
    public float Quantity { get; set; }

}

/// <summary>
/// The ID of the IFF emitting system. Section 6.2.87
/// </summary>
public partial class SystemIdentifier
{
    /// <summary>
    /// general type of emitting system, an enumeration
    /// </summary>
    public ushort SystemType { get; set; }

    /// <summary>
    /// named type of system, an enumeration
    /// </summary>
    public ushort SystemName { get; set; }

    /// <summary>
    /// mode of operation for the system, an enumeration
    /// </summary>
    public byte SystemMode { get; set; }

    /// <summary>
    /// status of this PDU, see section 6.2.15
    /// </summary>
    public ChangeOptions ChangeOptions { get; set; } = new ChangeOptions();

}

/// <summary>
/// Total number of record sets contained in a logical set of one or more PDUs. Used to transfer ownership, etc Section 6.2.88
/// </summary>
public partial class TotalRecordSets
{
    /// <summary>
    /// Total number of record sets
    /// </summary>
    public ushort TotalRecordSetsValue { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

}

/// <summary>
/// Track-Jam data Section 6.2.89
/// </summary>
public partial class TrackJamData
{
    /// <summary>
    /// The entity tracked or illumated, or an emitter beam targeted with jamming
    /// </summary>
    public EntityID EntityId { get; set; } = new EntityID();

    /// <summary>
    /// Emitter system associated with the entity
    /// </summary>
    public byte EmitterNumber { get; set; }

    /// <summary>
    /// Beam associated with the entity
    /// </summary>
    public byte BeamNumber { get; set; }

}

/// <summary>
/// Regeneration parameters for active emission systems that are variable throughout a scenario. Section 6.2.91
/// </summary>
public partial class UAFundamentalParameter
{
    /// <summary>
    /// Which database record shall be used
    /// </summary>
    public ushort ActiveEmissionParameterIndex { get; set; }

    /// <summary>
    /// The type of scan pattern, If not used, zero
    /// </summary>
    public ushort ScanPattern { get; set; }

    /// <summary>
    /// center azimuth bearing of th emain beam. In radians.
    /// </summary>
    public float BeamCenterAzimuthHorizontal { get; set; }

    /// <summary>
    /// Horizontal beamwidth of th emain beam Meastued at the 3dB down point of peak radiated power. In radians.
    /// </summary>
    public float AzimuthalBeamwidthHorizontal { get; set; }

    /// <summary>
    /// center of the d/e angle of th emain beam relative to the stablised de angle of the target. In radians.
    /// </summary>
    public float BeamCenterDepressionElevation { get; set; }

    /// <summary>
    /// vertical beamwidth of the main beam. Meastured at the 3dB down point of peak radiated power. In radians.
    /// </summary>
    public float DepressionElevationBeamWidth { get; set; }

}

/// <summary>
/// The unique designation of one or more unattached radios in an event or exercise Section 6.2.91
/// </summary>
public partial class UnattachedIdentifier
{
    /// <summary>
    /// See 6.2.79
    /// </summary>
    public SimulationAddress SimulationAddress { get; set; } = new SimulationAddress();

    /// <summary>
    /// Reference number
    /// </summary>
    public ushort ReferenceNumber { get; set; }

}

/// <summary>
/// container class not in specification
/// </summary>
public partial class UnsignedDISInteger
{
    /// <summary>
    /// unsigned integer
    /// </summary>
    public uint Val { get; set; }

}

/// <summary>
/// The variable datum type, the datum length, and the value for that variable datum type. Section 6.2.93
/// </summary>
public partial class VariableDatum
{
    /// <summary>
    /// Type of variable datum to be transmitted. 32-bit enumeration defined in EBV
    /// </summary>
    public uint VariableDatumId { get; set; }

    /// <summary>
    /// Length, IN BITS, of the variable datum.
    /// </summary>
    public uint VariableDatumLength { get; set; }

    /// <summary>
    /// This can be any number of bits long, depending on the datum.
    /// </summary>
    public byte[] VariableDatumValue { get; set; } = new byte[0];

}

/// <summary>
/// used in DetonationPdu, ArticulatedPartsPdu among others
/// </summary>
public partial class VariableParameter
{
    /// <summary>
    /// The identification of the Variable Parameter record. Enumeration from EBV
    /// </summary>
    public byte RecordType { get; set; }

    /// <summary>
    /// 120 bits
    /// </summary>
    public byte[] RecordSpecificFields { get; set; } = new byte[15];

}

/// <summary>
/// Relates to radios. Section 6.2.95
/// </summary>
public partial class VariableTransmitterParameters
{
    /// <summary>
    /// Type of VTP
    /// </summary>
    public uint RecordType { get; set; }

    /// <summary>
    /// Length, in bytes
    /// </summary>
    public ushort RecordLength { get; set; }

    public byte[] RecordSpecificFields { get; set; } = new byte[0];

}

/// <summary>
/// Two floating point values, x, y
/// </summary>
public partial class Vector2Float
{
    /// <summary>
    /// X value
    /// </summary>
    public float X { get; set; }

    /// <summary>
    /// y Value
    /// </summary>
    public float Y { get; set; }

}

/// <summary>
/// Three double precision floating point values, x, y, and z. Used for world coordinates Section 6.2.97.
/// </summary>
public partial class Vector3Double
{
    /// <summary>
    /// X value
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// y Value
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Z value
    /// </summary>
    public double Z { get; set; }

}

/// <summary>
/// Three floating point values, x, y, and z. Section 6.2.95
/// </summary>
public partial class Vector3Float
{
    /// <summary>
    /// X value
    /// </summary>
    public float X { get; set; }

    /// <summary>
    /// y Value
    /// </summary>
    public float Y { get; set; }

    /// <summary>
    /// Z value
    /// </summary>
    public float Z { get; set; }

}

/// <summary>
/// Operational data for describing the vectoring nozzle systems Section 6.2.96
/// </summary>
public partial class VectoringNozzleSystem
{
    /// <summary>
    /// In degrees
    /// </summary>
    public float HorizontalDeflectionAngle { get; set; }

    /// <summary>
    /// In degrees
    /// </summary>
    public float VerticalDeflectionAngle { get; set; }

}


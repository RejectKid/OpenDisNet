// DIS v7 protocol models reviewed from SyntheticEnvironmentFamilyPdus.xml.
#pragma warning disable CS0108
using OpenDisNet.Enumerations;
using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

/// <summary>
/// 7.10.6 Used to communicate detailed information about the addition/modification of a synthetic environment object that is geometrically anchored to the terrain with a set of three or more points that come to a closure.
/// </summary>
public partial class ArealObjectStatePdu : SyntheticEnvironmentFamilyPdu
{
    /// <summary>Creates a DIS v7 ArealObjectStatePdu with its wire discriminator fields initialized.</summary>
    public ArealObjectStatePdu() => Initialize(45, 9);

    /// <summary>
    /// Object in synthetic environment
    /// </summary>
    public ObjectIdentifier ObjectId { get; set; } = new ObjectIdentifier();

    /// <summary>
    /// Object with which this point object is associated
    /// </summary>
    public ObjectIdentifier ReferencedObjectId { get; set; } = new ObjectIdentifier();

    /// <summary>
    /// unique update number of each state transition of an object
    /// </summary>
    public ushort UpdateNumber { get; set; }

    /// <summary>
    /// force ID provides a unique identifier
    /// </summary>
    public ForceId ForceId { get; set; }

    /// <summary>
    /// modifications enumeration
    /// </summary>
    public ObjectStateModificationArealObject Modifications { get; set; }

    /// <summary>
    /// Object type
    /// </summary>
    public ObjectType ObjectType { get; set; } = new ObjectType();

    /// <summary>
    /// Object appearance
    /// </summary>
    public uint SpecificObjectAppearance { get; set; }

    /// <summary>
    /// Object appearance
    /// </summary>
    public ushort GeneralObjectAppearance { get; set; }

    /// <summary>
    /// Number of points
    /// </summary>
    internal ushort NumberOfPoints { get; set; }

    /// <summary>
    /// requesterID
    /// </summary>
    public SimulationAddress RequesterId { get; set; } = new SimulationAddress();

    /// <summary>
    /// receiver ID provides a unique identifier
    /// </summary>
    public SimulationAddress ReceivingId { get; set; } = new SimulationAddress();

    /// <summary>
    /// location of object
    /// </summary>
    public List<Vector3Double> ObjectLocation { get; set; } = [];

}

/// <summary>
/// 7.10.2 Used to communicate information about environmental effects and processes.
/// </summary>
public partial class EnvironmentalProcessPdu : SyntheticEnvironmentFamilyPdu
{
    /// <summary>Creates a DIS v7 EnvironmentalProcessPdu with its wire discriminator fields initialized.</summary>
    public EnvironmentalProcessPdu() => Initialize(41, 9);

    /// <summary>
    /// Environmental process ID provides a unique identifier
    /// </summary>
    public ObjectIdentifier EnvironementalProcessId { get; set; } = new ObjectIdentifier();

    /// <summary>
    /// Environment type
    /// </summary>
    public EntityType EnvironmentType { get; set; } = new EntityType();

    /// <summary>
    /// model type
    /// </summary>
    public EnvironmentalProcessModelType ModelType { get; set; }

    /// <summary>
    /// Environment status
    /// </summary>
    public EnvironmentalProcessEnvironmentStatus EnvironmentStatus { get; set; }

    /// <summary>
    /// number of environment records
    /// </summary>
    internal ushort NumberOfEnvironmentRecords { get; set; }

    /// <summary>
    /// PDU sequence number for the environmental process if pdu sequencing required
    /// </summary>
    public ushort SequenceNumber { get; set; }

    /// <summary>
    /// environmemt records
    /// </summary>
    public List<Environment> EnvironmentRecords { get; set; } = [];

}

/// <summary>
/// 7.10.3 Used to communicate information about global, spatially varying environmental effects.
/// </summary>
public partial class GriddedDataPdu : SyntheticEnvironmentFamilyPdu
{
    /// <summary>Creates a DIS v7 GriddedDataPdu with its wire discriminator fields initialized.</summary>
    public GriddedDataPdu() => Initialize(42, 9);

    /// <summary>
    /// environmental simulation application ID provides a unique identifier
    /// </summary>
    public SimulationIdentifier EnvironmentalSimulationApplicationId { get; set; } = new SimulationIdentifier();

    /// <summary>
    /// unique identifier for each piece of environmental data
    /// </summary>
    public ushort FieldNumber { get; set; }

    /// <summary>
    /// sequence number for the total set of PDUS used to transmit the data
    /// </summary>
    public ushort PduNumber { get; set; }

    /// <summary>
    /// Total number of PDUS used to transmit the data
    /// </summary>
    public ushort PduTotal { get; set; }

    /// <summary>
    /// coordinate system of the grid
    /// </summary>
    public GriddedDataCoordinateSystem CoordinateSystem { get; set; }

    /// <summary>
    /// number of grid axes for the environmental data
    /// </summary>
    internal byte NumberOfGridAxes { get; set; }

    /// <summary>
    /// are domain grid axes identidal to those of the priveious domain update?
    /// </summary>
    public GriddedDataConstantGrid ConstantGrid { get; set; }

    /// <summary>
    /// type of environment
    /// </summary>
    public EntityType EnvironmentType { get; set; } = new EntityType();

    /// <summary>
    /// orientation of the data grid
    /// </summary>
    public EulerAngles Orientation { get; set; } = new EulerAngles();

    /// <summary>
    /// valid time of the enviormental data sample, 64-bit unsigned int
    /// </summary>
    public ClockTime SampleTime { get; set; } = new ClockTime();

    /// <summary>
    /// total number of all data values for all pdus for an environmental sample
    /// </summary>
    public uint TotalValues { get; set; }

    /// <summary>
    /// total number of data values at each grid point.
    /// </summary>
    public byte VectorDimension { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

    public List<GridAxisDescriptor> GridAxisDescriptors { get; set; } = [];

    public List<GridData> GridDataRecords { get; set; } = [];

}

/// <summary>
/// 7.10.5 Used to communicate detailed information about the addition/modification of a synthetic environment object that is geometrically anchored to the terrain with one point and has size and orientation.
/// </summary>
public partial class LinearObjectStatePdu : SyntheticEnvironmentFamilyPdu
{
    /// <summary>Creates a DIS v7 LinearObjectStatePdu with its wire discriminator fields initialized.</summary>
    public LinearObjectStatePdu() => Initialize(44, 9);

    /// <summary>
    /// Object in synthetic environment
    /// </summary>
    public ObjectIdentifier ObjectId { get; set; } = new ObjectIdentifier();

    /// <summary>
    /// Object with which this point object is associated
    /// </summary>
    public ObjectIdentifier ReferencedObjectId { get; set; } = new ObjectIdentifier();

    /// <summary>
    /// unique update number of each state transition of an object
    /// </summary>
    public ushort UpdateNumber { get; set; }

    /// <summary>
    /// force ID provides a unique identifier
    /// </summary>
    public ForceId ForceId { get; set; }

    /// <summary>
    /// number of linear segment parameters
    /// </summary>
    internal byte NumberOfLinearSegments { get; set; }

    /// <summary>
    /// requesterID
    /// </summary>
    public SimulationAddress RequesterId { get; set; } = new SimulationAddress();

    /// <summary>
    /// receiver ID provides a unique identifier
    /// </summary>
    public SimulationAddress ReceivingId { get; set; } = new SimulationAddress();

    /// <summary>
    /// Object type
    /// </summary>
    public ObjectType ObjectType { get; set; } = new ObjectType();

    /// <summary>
    /// Linear segment parameters
    /// </summary>
    public List<LinearSegmentParameter> LinearSegmentParameters { get; set; } = [];

}

/// <summary>
/// 7.10.4 Used to communicate detailed information about the addition/modification of a synthetic environment object that is geometrically anchored to the terrain with a single point.
/// </summary>
public partial class PointObjectStatePdu : SyntheticEnvironmentFamilyPdu
{
    /// <summary>Creates a DIS v7 PointObjectStatePdu with its wire discriminator fields initialized.</summary>
    public PointObjectStatePdu() => Initialize(43, 9);

    /// <summary>
    /// Object in synthetic environment
    /// </summary>
    public EntityId ObjectId { get; set; } = new EntityId();

    /// <summary>
    /// Object with which this point object is associated
    /// </summary>
    public ObjectIdentifier ReferencedObjectId { get; set; } = new ObjectIdentifier();

    /// <summary>
    /// unique update number of each state transition of an object
    /// </summary>
    public uint UpdateNumber { get; set; }

    /// <summary>
    /// force ID provides a unique identifier
    /// </summary>
    public ForceId ForceId { get; set; }

    /// <summary>
    /// modifications
    /// </summary>
    public ObjectStateModificationPointObject Modifications { get; set; }

    /// <summary>
    /// Object type
    /// </summary>
    public ObjectType ObjectType { get; set; } = new ObjectType();

    /// <summary>
    /// Object location
    /// </summary>
    public Vector3Double ObjectLocation { get; set; } = new Vector3Double();

    /// <summary>
    /// Object orientation
    /// </summary>
    public EulerAngles ObjectOrientation { get; set; } = new EulerAngles();

    /// <summary>
    /// Specific object apperance
    /// </summary>
    public uint SpecificObjectAppearance { get; set; }

    /// <summary>
    /// General object apperance
    /// </summary>
    public ObjectStateAppearanceGeneral GenerObjectAppearance { get; set; }

    public ushort Padding1 { get; set; }

    /// <summary>
    /// requesterID
    /// </summary>
    public SimulationAddress RequesterId { get; set; } = new SimulationAddress();

    /// <summary>
    /// receiver ID provides a unique identifier
    /// </summary>
    public SimulationAddress ReceivingId { get; set; } = new SimulationAddress();

    /// <summary>
    /// padding
    /// </summary>
    public uint Pad2 { get; set; }

}

/// <summary>
/// Section 5.3.11: Abstract superclass for synthetic environment PDUs
/// </summary>
public abstract partial class SyntheticEnvironmentFamilyPdu : PduBase
{
}


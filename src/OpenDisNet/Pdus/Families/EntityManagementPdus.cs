// DIS v7 protocol models reviewed from EntityManagementFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 5.9.2.2 The Aggregate State PDU shall be used to communicate the state and other pertinent information about an aggregated unit.
/// </summary>
public partial class AggregateStatePdu : EntityManagementFamilyPdu
{
    /// <summary>Creates a DIS v7 AggregateStatePdu with its wire discriminator fields initialized.</summary>
    public AggregateStatePdu() => Initialize(33, 7);

    /// <summary>
    /// ID of aggregated entities
    /// </summary>
    public AggregateIdentifier AggregateId { get; set; } = new AggregateIdentifier();

    /// <summary>
    /// force ID provides a unique identifier
    /// </summary>
    public byte ForceId { get; set; }

    /// <summary>
    /// state of aggregate
    /// </summary>
    public byte AggregateState { get; set; }

    /// <summary>
    /// entity type of the aggregated entities
    /// </summary>
    public AggregateType AggregateType { get; set; } = new AggregateType();

    /// <summary>
    /// formation of aggregated entities
    /// </summary>
    public uint Formation { get; set; }

    /// <summary>
    /// marking for aggregate; first char is charset type, rest is char data
    /// </summary>
    public AggregateMarking AggregateMarking { get; set; } = new AggregateMarking();

    /// <summary>
    /// dimensions of bounding box for the aggregated entities, origin at the center of mass
    /// </summary>
    public Vector3Float Dimensions { get; set; } = new Vector3Float();

    /// <summary>
    /// orientation of the bounding box
    /// </summary>
    public Vector3Float Orientation { get; set; } = new Vector3Float();

    /// <summary>
    /// center of mass of the aggregation
    /// </summary>
    public Vector3Double CenterOfMass { get; set; } = new Vector3Double();

    /// <summary>
    /// velocity of aggregation
    /// </summary>
    public Vector3Float Velocity { get; set; } = new Vector3Float();

    /// <summary>
    /// number of aggregates
    /// </summary>
    internal ushort NumberOfDisAggregates { get; set; }

    /// <summary>
    /// number of entities
    /// </summary>
    internal ushort NumberOfDisEntities { get; set; }

    /// <summary>
    /// number of silent aggregate types
    /// </summary>
    internal ushort NumberOfSilentAggregateTypes { get; set; }

    /// <summary>
    /// Number of silent entity types, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal ushort NumberOfSilentEntityTypes { get; set; }

    /// <summary>
    /// aggregates  list
    /// </summary>
    public List<AggregateIdentifier> AggregateIdList { get; set; } = [];

    /// <summary>
    /// entity ID list
    /// </summary>
    public List<EntityId> EntityIdList { get; set; } = [];

    /// <summary>
    /// silent entity types
    /// </summary>
    public List<EntityType> SilentAggregateSystemList { get; set; } = [];

    /// <summary>
    /// silent entity types
    /// </summary>
    public List<EntityType> SilentEntitySystemList { get; set; } = [];

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variableDatums
    /// </summary>
    public List<VariableDatum> VariableDatumList { get; set; } = [];

}

/// <summary>
/// Managment of grouping of PDUs, and more. Section 7.8
/// </summary>
public abstract partial class EntityManagementFamilyPdu : PduBase
{
}

/// <summary>
/// 5.9.3.1 The IsGroupOf PDU shall communicate information about the individual states of a group of entities, including state information that is necessary for the receiving simulation applications to represent the issuing group of entities in the simulation applications’ own simulation.
/// </summary>
public partial class IsGroupOfPdu : EntityManagementFamilyPdu
{
    /// <summary>Creates a DIS v7 IsGroupOfPdu with its wire discriminator fields initialized.</summary>
    public IsGroupOfPdu() => Initialize(34, 7);

    /// <summary>
    /// ID of aggregated entities
    /// </summary>
    public EntityId GroupEntityId { get; set; } = new EntityId();

    /// <summary>
    /// type of entities constituting the group
    /// </summary>
    public byte GroupedEntityCategory { get; set; }

    /// <summary>
    /// Number of individual entities constituting the group
    /// </summary>
    internal byte NumberOfGroupedEntities { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Pad { get; set; }

    /// <summary>
    /// latitude
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// longitude
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// GED records about each individual entity in the group. Bad specing--the Group Entity Descriptions are not described.
    /// </summary>
    public List<VariableDatum> GroupedEntityDescriptions { get; set; } = [];

}

/// <summary>
/// 5.9.5 Used to request hierarchical linkage of separately hosted simulation entities
/// </summary>
public partial class IsPartOfPdu : EntityManagementFamilyPdu
{
    /// <summary>Creates a DIS v7 IsPartOfPdu with its wire discriminator fields initialized.</summary>
    public IsPartOfPdu() => Initialize(36, 7);

    /// <summary>
    /// ID of entity originating PDU
    /// </summary>
    public EntityId OrginatingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of entity receiving PDU
    /// </summary>
    public EntityId ReceivingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// relationship of joined parts
    /// </summary>
    public Relationship Relationship { get; set; } = new Relationship();

    /// <summary>
    /// location of part; centroid of part in host's coordinate system. x=range, y=bearing, z=0
    /// </summary>
    public Vector3Float PartLocation { get; set; } = new Vector3Float();

    /// <summary>
    /// named location
    /// </summary>
    public NamedLocationIdentification NamedLocationId { get; set; } = new NamedLocationIdentification();

    /// <summary>
    /// entity type
    /// </summary>
    public EntityType PartEntityType { get; set; } = new EntityType();

}

/// <summary>
/// Information initiating the dyanic allocation and control of simulation entities between two simulation applications.
/// </summary>
public partial class TransferOwnershipPdu : EntityManagementFamilyPdu
{
    /// <summary>Creates a DIS v7 TransferOwnershipPdu with its wire discriminator fields initialized.</summary>
    public TransferOwnershipPdu() => Initialize(35, 7);

    /// <summary>
    /// ID of entity originating request
    /// </summary>
    public EntityId OriginatingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of entity receiving request
    /// </summary>
    public EntityId ReceivingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of request
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// required level of reliability service.
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// type of transfer desired
    /// </summary>
    public byte TransferType { get; set; }

    /// <summary>
    /// The entity for which control is being requested to transfer
    /// </summary>
    public EntityId TransferEntityId { get; set; } = new EntityId();

    public RecordSpecification RecordSets { get; set; } = new RecordSpecification();

}


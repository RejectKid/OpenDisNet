// DIS v7 protocol models reviewed from LogisticsFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// Abstract superclass for logistics PDUs. Section 7.4
/// </summary>
public abstract partial class LogisticsFamilyPdu : PduBase
{
}

/// <summary>
/// 5.5.10 Used by the repairing entity to communicate the repair that has been performed for the entity that requested repair service.
/// </summary>
public partial class RepairCompletePdu : LogisticsFamilyPdu
{
    /// <summary>
    /// Entity that is receiving service.  See 6.2.28
    /// </summary>
    public EntityID ReceivingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Entity that is supplying.  See 6.2.28
    /// </summary>
    public EntityID RepairingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Enumeration for type of repair.  See 6.2.74
    /// </summary>
    public ushort Repair { get; set; }

    /// <summary>
    /// padding, number prevents conflict with superclass ivar name
    /// </summary>
    public ushort Padding4 { get; set; }

}

/// <summary>
/// 5.5.11 used by the receiving entity to acknowledge the receipt of a Repair Complete PDU
/// </summary>
public partial class RepairResponsePdu : LogisticsFamilyPdu
{
    /// <summary>
    /// Entity that requested repairs.  See 6.2.28
    /// </summary>
    public EntityID ReceivingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Entity that is repairing.  See 6.2.28
    /// </summary>
    public EntityID RepairingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Result of repair operation
    /// </summary>
    public ushort RepairResult { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

}

/// <summary>
/// 5.5.8 Used to communicate the canceling of a resupply service provided through logistics support.
/// </summary>
public partial class ResupplyCancelPdu : LogisticsFamilyPdu
{
    /// <summary>
    /// Requesting entity, Section 7.4.5
    /// </summary>
    public EntityID ReceivingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Supplying entity, Section 7.4.5
    /// </summary>
    public EntityID SupplyingEntityId { get; set; } = new EntityID();

}

/// <summary>
/// 5.5.6 Communicate the offer of supplies by a supplying entity to a receiving entity.
/// </summary>
public partial class ResupplyOfferPdu : LogisticsFamilyPdu
{
    /// <summary>
    /// Field identifies the Entity and respective Entity Record ID that is receiving service (see 6.2.28), Section 7.4.3
    /// </summary>
    public EntityID ReceivingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Identifies the Entity and respective Entity ID Record that is supplying  (see 6.2.28), Section 7.4.3
    /// </summary>
    public EntityID SupplyingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// How many supplies types are being offered, Section 7.4.3
    /// </summary>
    internal byte NumberOfSupplyTypes { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

    /// <summary>
    /// A Reord that Specifies the type of supply and the amount of that supply for each of the supply types in numberOfSupplyTypes (see 6.2.85), Section 7.4.3
    /// </summary>
    public List<SupplyQuantity> Supplies { get; set; } = [];

}

/// <summary>
/// 5.5.7 Used to acknowledge the receipt of supplies by the receiving entity.
/// </summary>
public partial class ResupplyReceivedPdu : LogisticsFamilyPdu
{
    /// <summary>
    /// Entity that is receiving service.  Shall be represented by Entity Identifier record (see 6.2.28)
    /// </summary>
    public EntityID ReceivingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Entity that is supplying.  Shall be represented by Entity Identifier record (see 6.2.28)
    /// </summary>
    public EntityID SupplyingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// How many supplies are taken by receiving entity
    /// </summary>
    internal byte NumberOfSupplyTypes { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

    /// <summary>
    /// A Reord that Specifies the type of supply and the amount of that supply for each of the supply types in numberOfSupplyTypes (see 6.2.85), Section 7.4.3
    /// </summary>
    public List<SupplyQuantity> Supplies { get; set; } = [];

}

/// <summary>
/// 5.5.5 Communicate information associated with one entity requesting a service from another.
/// </summary>
public partial class ServiceRequestPdu : LogisticsFamilyPdu
{
    /// <summary>
    /// Entity that is requesting service (see 6.2.28), Section 7.4.2
    /// </summary>
    public EntityID RequestingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Entity that is providing the service (see 6.2.28), Section 7.4.2
    /// </summary>
    public EntityID ServicingEntityId { get; set; } = new EntityID();

    /// <summary>
    /// Type of service requested, Section 7.4.2
    /// </summary>
    public byte ServiceTypeRequested { get; set; }

    /// <summary>
    /// How many requested, Section 7.4.2
    /// </summary>
    internal byte NumberOfSupplyTypes { get; set; }

    public ushort Padding1 { get; set; }

    public List<SupplyQuantity> Supplies { get; set; } = [];

}


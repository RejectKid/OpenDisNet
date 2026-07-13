// DIS v7 protocol models reviewed from InformationOperationsFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 5.13.3.1 Used to communicate an IO attack or the effects of an IO attack on one or more target entities.
/// </summary>
public partial class InformationOperationsActionPdu : InformationOperationsFamilyPdu
{
    /// <summary>Creates a DIS v7 InformationOperationsActionPdu with its wire discriminator fields initialized.</summary>
    public InformationOperationsActionPdu() => Initialize(70, 13);

    /// <summary>
    /// the simulation to which this PDU is addressed
    /// </summary>
    public EntityId ReceivingSimId { get; set; } = new EntityId();

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    public ushort IOWarfareType { get; set; }

    public ushort IOSimulationSource { get; set; }

    public ushort IOActionType { get; set; }

    public ushort IOActionPhase { get; set; }

    public uint Padding1 { get; set; }

    public EntityId IoAttackerId { get; set; } = new EntityId();

    public EntityId IoPrimaryTargetId { get; set; } = new EntityId();

    public ushort Padding2 { get; set; }

    internal ushort NumberOfIORecords { get; set; }

    public List<IORecord> IoRecords { get; set; } = [];

}

/// <summary>
/// Information operations (IO) are the integrated employment of electronic warfare (EW), computer network operations (CNO), psychological operations (PSYOP), military deception (MILDEC), and operations security (OPSEC), along with specific supporting capabilities, to influence, disrupt, corrupt, or otherwise affect enemy information and decision making while protecting friendly information operations.
/// </summary>
public abstract partial class InformationOperationsFamilyPdu : PduBase
{
    /// <summary>
    /// Object originating the request
    /// </summary>
    public EntityId OriginatingSimId { get; set; } = new EntityId();

}

/// <summary>
/// 5.13.4.1 Used to communicate the effects of an IO attack on one or more target entities.
/// </summary>
public partial class InformationOperationsReportPdu : InformationOperationsFamilyPdu
{
    /// <summary>Creates a DIS v7 InformationOperationsReportPdu with its wire discriminator fields initialized.</summary>
    public InformationOperationsReportPdu() => Initialize(71, 13);

    public ushort IoSimSource { get; set; }

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public byte IoReportType { get; set; }

    public byte Padding1 { get; set; }

    public EntityId IoAttackerId { get; set; } = new EntityId();

    public EntityId IoPrimaryTargetId { get; set; } = new EntityId();

    public ushort Padding2 { get; set; }

    public ushort Padding3 { get; set; }

    internal ushort NumberOfIORecords { get; set; }

    public List<IORecord> IoRecords { get; set; } = [];

}


// DIS v7 protocol models reviewed from SimulationManagementWithReliabilityFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 5.12.4.6 Serves the same function as the Acknowledge PDU but is used to acknowledge the receipt of a Create Entity-R PDU, a Remove Entity-R PDU, a Start/Resume-R PDU, or a Stop/Freeze-R PDU.
/// </summary>
public partial class AcknowledgeRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 AcknowledgeRPdu with its wire discriminator fields initialized.</summary>
    public AcknowledgeRPdu() => Initialize(55, 10);

    /// <summary>
    /// ack flags
    /// </summary>
    public ushort AcknowledgeFlag { get; set; }

    /// <summary>
    /// response flags
    /// </summary>
    public ushort ResponseFlag { get; set; }

    /// <summary>
    /// Request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Alias, more descriptive name for AcknowledgeRPdu.
/// </summary>
public partial class AcknowledgeReliablePdu
{
}

/// <summary>
/// 5.12.4.7 Serves the same function as the Action Request PDU but with the addition of reliability service levels.
/// </summary>
public partial class ActionRequestRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 ActionRequestRPdu with its wire discriminator fields initialized.</summary>
    public ActionRequestRPdu() => Initialize(56, 10);

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Pad2 { get; set; }

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint ActionId { get; set; }

    /// <summary>
    /// Fixed datum record count
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Fixed datum records
    /// </summary>
    public List<FixedDatum> FixedDatumRecords { get; set; } = [];

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for ActionRequestRPdu.
/// </summary>
public partial class ActionRequestReliablePdu
{
}

/// <summary>
/// 5.12.4.8 Serves the same function as the Action Response PDU (see 5.6.5.8.1) but is used to acknowledge the receipt of an Action Request-R PDU.
/// </summary>
public partial class ActionResponseRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 ActionResponseRPdu with its wire discriminator fields initialized.</summary>
    public ActionResponseRPdu() => Initialize(57, 10);

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// status of response
    /// </summary>
    public uint ResponseStatus { get; set; }

    /// <summary>
    /// Fixed datum record count
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Fixed datum records
    /// </summary>
    public List<FixedDatum> FixedDatumRecords { get; set; } = [];

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for ActionResponseRPdu.
/// </summary>
public partial class ActionResponseReliablePdu
{
}

/// <summary>
/// 5.12.4.13 Serves the same function as the Comment PDU.
/// </summary>
public partial class CommentRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 CommentRPdu with its wire discriminator fields initialized.</summary>
    public CommentRPdu() => Initialize(62, 10);

    /// <summary>
    /// Fixed datum record count, not used in this Pdu
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for CommentRPdu.
/// </summary>
public partial class CommentReliablePdu
{
}

/// <summary>
/// 5.12.4.2 Serves the same function as the Create Entity PDU but with the addition of reliability service levels.
/// </summary>
public partial class CreateEntityRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 CreateEntityRPdu with its wire discriminator fields initialized.</summary>
    public CreateEntityRPdu() => Initialize(51, 10);

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    public byte Pad1 { get; set; }

    public ushort Pad2 { get; set; }

    /// <summary>
    /// Request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Alias, more descriptive name for CreateEntityRPdu.
/// </summary>
public partial class CreateEntityReliablePdu
{
}

/// <summary>
/// 5.12.4.9 Serves the same function as the Data Query PDU but with the addition of reliability service levels
/// </summary>
public partial class DataQueryRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 DataQueryRPdu with its wire discriminator fields initialized.</summary>
    public DataQueryRPdu() => Initialize(58, 10);

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Pad2 { get; set; }

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// time interval between issuing data query PDUs
    /// </summary>
    public uint TimeInterval { get; set; }

    /// <summary>
    /// Fixed datum record count
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Fixed datum records
    /// </summary>
    public List<FixedDatum> FixedDatumRecords { get; set; } = [];

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for DataQueryRPdu.
/// </summary>
public partial class DataQueryReliablePdu
{
}

/// <summary>
/// 5.12.4.11 Serves the same function as the Data PDU but with the addition of reliability service levels and is used in response to a Data Query-R PDU, a Data-R PDU, or a Set Data-R PDU.
/// </summary>
public partial class DataRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 DataRPdu with its wire discriminator fields initialized.</summary>
    public DataRPdu() => Initialize(60, 10);

    /// <summary>
    /// Request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Pad2 { get; set; }

    /// <summary>
    /// Fixed datum record count
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Fixed datum records
    /// </summary>
    public List<FixedDatum> FixedDatumRecords { get; set; } = [];

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for DataRPdu.
/// </summary>
public partial class DataReliablePdu
{
}

/// <summary>
/// 5.12.4.12 Contains the same information as found in the Event Report PDU.
/// </summary>
public partial class EventReportRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 EventReportRPdu with its wire discriminator fields initialized.</summary>
    public EventReportRPdu() => Initialize(61, 10);

    /// <summary>
    /// Event type
    /// </summary>
    public uint EventType { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Pad1 { get; set; }

    /// <summary>
    /// Fixed datum record count
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Fixed datum records
    /// </summary>
    public List<FixedDatum> FixedDatumRecords { get; set; } = [];

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for EventReportRPdu.
/// </summary>
public partial class EventReportReliablePdu
{
}

/// <summary>
/// 5.12.4.14 Used to communicate a request for data in record format.
/// </summary>
public partial class RecordQueryRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 RecordQueryRPdu with its wire discriminator fields initialized.</summary>
    public RecordQueryRPdu() => Initialize(65, 10);

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad1 { get; set; }

    /// <summary>
    /// event type
    /// </summary>
    public ushort EventType { get; set; }

    /// <summary>
    /// time
    /// </summary>
    public uint Time { get; set; }

    /// <summary>
    /// numberOfRecords
    /// </summary>
    internal uint NumberOfRecords { get; set; }

    /// <summary>
    /// record IDs
    /// </summary>
    public List<RecordQuerySpecification> RecordIds { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for RecordQueryRPdu.
/// </summary>
public partial class RecordQueryReliablePdu
{
}

/// <summary>
/// 5.12.4.16 Used to respond to a Record Query-R PDU or a Set Record-R PDU. It is used to provide information requested in a Record Query-R PDU, to confirm the information received in a Set Record-R PDU, and to confirm the receipt of a periodic or unsolicited Record-R PDU when the acknowledged service level is used.
/// </summary>
public partial class RecordRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 RecordRPdu with its wire discriminator fields initialized.</summary>
    public RecordRPdu() => Initialize(63, 10);

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    public byte Pad1 { get; set; }

    public ushort EventType { get; set; }

    /// <summary>
    /// Number of record sets in list
    /// </summary>
    internal uint NumberOfRecordSets { get; set; }

    /// <summary>
    /// record sets
    /// </summary>
    public List<RecordSpecification> RecordSets { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for RecordRPdu.
/// </summary>
public partial class RecordReliablePdu
{
}

/// <summary>
/// 5.12.4.3 Contains the same information as found in the Remove Entity PDU with the addition of the level of reliability service to be used for the removal action being requested.
/// </summary>
public partial class RemoveEntityRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 RemoveEntityRPdu with its wire discriminator fields initialized.</summary>
    public RemoveEntityRPdu() => Initialize(52, 10);

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    public byte Pad1 { get; set; }

    public ushort Pad2 { get; set; }

    /// <summary>
    /// Request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Alias, more descriptive name for RemoveEntityRPdu.
/// </summary>
public partial class RemoveEntityReliablePdu
{
}

/// <summary>
/// 5.12.4.10 Serves the same function as the Set Data PDU but with the addition of reliability service levels.
/// </summary>
public partial class SetDataRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 SetDataRPdu with its wire discriminator fields initialized.</summary>
    public SetDataRPdu() => Initialize(59, 10);

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Pad2 { get; set; }

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// Fixed datum record count
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// variable datum record count
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// Fixed datum records
    /// </summary>
    public List<FixedDatum> FixedDatumRecords { get; set; } = [];

    /// <summary>
    /// Variable datum records
    /// </summary>
    public List<VariableDatum> VariableDatumRecords { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for SetDataRPdu.
/// </summary>
public partial class SetDataReliablePdu
{
}

/// <summary>
/// 5.12.4.15 Used to set or change certain parameter values. These parameter values are contained within a record format as compared to the datum format used in the Set Data-R PDU.
/// </summary>
public partial class SetRecordRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 SetRecordRPdu with its wire discriminator fields initialized.</summary>
    public SetRecordRPdu() => Initialize(64, 10);

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    public byte Pad1 { get; set; }

    public ushort Pad2 { get; set; }

    public uint Pad3 { get; set; }

    /// <summary>
    /// Number of record sets in list
    /// </summary>
    internal uint NumberOfRecordSets { get; set; }

    /// <summary>
    /// record sets
    /// </summary>
    public List<RecordSpecification> RecordSets { get; set; } = [];

}

/// <summary>
/// Alias, more descriptive name for SetRecordRPdu.
/// </summary>
public partial class SetRecordReliablePdu
{
}

/// <summary>
/// Simulation Management with Reliability PDUs with reliability service levels in a DIS exercise are an alternative to the Simulation Management PDUs, and may or may not be required for participation in an DIS exercise,
/// </summary>
public abstract partial class SimulationManagementWithReliabilityFamilyPdu : PduBase
{
    /// <summary>
    /// IDs the simulation or entity, either a simulation or an entity. Either 6.2.80 or 6.2.28
    /// </summary>
    public SimulationIdentifier OriginatingId { get; set; } = new SimulationIdentifier();

    /// <summary>
    /// simulation, all simulations, a special ID, or an entity. See 5.6.5 and 5.12.4
    /// </summary>
    public SimulationIdentifier ReceivingId { get; set; } = new SimulationIdentifier();

}

/// <summary>
/// 5.12.4.4 Serves the same function as the Start/Resume PDU but with the addition of reliability service levels
/// </summary>
public partial class StartResumeRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 StartResumeRPdu with its wire discriminator fields initialized.</summary>
    public StartResumeRPdu() => Initialize(53, 10);

    /// <summary>
    /// time in real world for this operation to happen
    /// </summary>
    public ClockTime RealWorldTime { get; set; } = new ClockTime();

    /// <summary>
    /// time in simulation for the simulation to resume
    /// </summary>
    public ClockTime SimulationTime { get; set; } = new ClockTime();

    /// <summary>
    /// level of reliability service used for this transaction
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    public byte Pad1 { get; set; }

    public ushort Pad2 { get; set; }

    /// <summary>
    /// Request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Alias, more descriptive name for StartResumeRPdu.
/// </summary>
public partial class StartResumeReliablePdu
{
}

/// <summary>
/// 5.12.4.5 Serves the same function as the Stop/Freeze PDU (see 5.6.5.5.1) but with the addition of reliability service levels.
/// </summary>
public partial class StopFreezeRPdu : SimulationManagementWithReliabilityFamilyPdu
{
    /// <summary>Creates a DIS v7 StopFreezeRPdu with its wire discriminator fields initialized.</summary>
    public StopFreezeRPdu() => Initialize(54, 10);

    /// <summary>
    /// time in real world for this operation to happen
    /// </summary>
    public ClockTime RealWorldTime { get; set; } = new ClockTime();

    /// <summary>
    /// Reason for stopping/freezing simulation
    /// </summary>
    public byte Reason { get; set; }

    /// <summary>
    /// internal behvior of the simulation while frozen
    /// </summary>
    public byte FrozenBehavior { get; set; }

    /// <summary>
    /// reliability level
    /// </summary>
    public byte RequiredReliabilityService { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad1 { get; set; }

    /// <summary>
    /// Request ID provides a unique identifier
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Alias, more descriptive name for StopFreezeRPdu.
/// </summary>
public partial class StopFreezeReliablePdu
{
}


// DIS v7 protocol models reviewed from SimulationManagementFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 7.5.6 Acknowledges the receipt of a Start/Resume PDU, Stop/Freeze PDU, Create Entity PDU, or Remove Entity PDU. See 5.6.5.6.
/// </summary>
public partial class AcknowledgePdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// type of message being acknowledged
    /// </summary>
    public ushort AcknowledgeFlag { get; set; }

    /// <summary>
    /// Whether or not the receiving entity was able to comply with the request
    /// </summary>
    public ushort ResponseFlag { get; set; }

    /// <summary>
    /// Request ID that is unique
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// 7.5.7 A request from a Simulation Manager (SM) to a managed entity to perform a specified action. See 5.6.5.7
/// </summary>
public partial class ActionRequestPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// identifies the request being made by the simulation manager
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// identifies the particular action being requested(see Section 7 of SISO-REF-010).
    /// </summary>
    public uint ActionId { get; set; }

    /// <summary>
    /// Number of fixed datum records
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variable length list of fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatums { get; set; } = [];

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// Section 7.5.8. When an entity receives an Action Request PDU, that entity shall acknowledge the receipt of the Action Request PDU with an Action Response PDU. See 5.6.5.8.
/// </summary>
public partial class ActionResponsePdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// Request ID that is unique
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// Status of response
    /// </summary>
    public uint RequestStatus { get; set; }

    /// <summary>
    /// Number of fixed datum records
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// fixed length list of fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatums { get; set; } = [];

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// 7.5.13 Used to enter arbitrary messages (character strings, for example). See 5.6.5.13
/// </summary>
public partial class CommentPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// Number of fixed datum records, not used in this Pdu
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// Section 7.5.2. The creation of a new entity shall be communicated using a Create Entity PDU. See 5.6.5.2.
/// </summary>
public partial class CreateEntityPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// Identifier for the request.  See 6.2.75
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// 7.5.11 Information issued in response to a Data Query PDU or Set Data PDU. Section 5.6.5.11
/// </summary>
public partial class DataPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// ID of request
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Padding1 { get; set; }

    /// <summary>
    /// Number of fixed datum records
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variable length list of fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatums { get; set; } = [];

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// Section 7.5.9. A request for data from an entity shall be communicated by issuing a Data Query PDU. See 5.6.5.9
/// </summary>
public partial class DataQueryPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// ID of request
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// time issues between issues of Data PDUs. Zero means send once only.
    /// </summary>
    public uint TimeInterval { get; set; }

    /// <summary>
    /// Number of fixed datum records
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variable length list of fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatums { get; set; } = [];

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// 7.5.12 A managed entity shall report the occurrence of a significant event to the simulation manager (SM) using an Event Report PDU. See 5.6.5.12.
/// </summary>
public partial class EventReportPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// Type of event
    /// </summary>
    public uint EventType { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Padding1 { get; set; }

    /// <summary>
    /// Number of fixed datum records
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variable length list of fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatums { get; set; } = [];

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// Section 7.5.3 The removal of an entity from an exercise shall be communicated with a Remove Entity PDU. See 5.6.5.3.
/// </summary>
public partial class RemoveEntityPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// This field shall identify the specific and unique start/resume request being made by the SM
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Section 7.5.10. Initializing or changing internal state information shall be communicated using a Set Data PDU. See 5.6.5.10
/// </summary>
public partial class SetDataPdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// ID of request
    /// </summary>
    public uint RequestId { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public uint Padding1 { get; set; }

    /// <summary>
    /// Number of fixed datum records
    /// </summary>
    internal uint NumberOfFixedDatumRecords { get; set; }

    /// <summary>
    /// Number of variable datum records, handled automatically by marshaller at run time (and not modifiable by end-user programmers)
    /// </summary>
    internal uint NumberOfVariableDatumRecords { get; set; }

    /// <summary>
    /// variable length list of fixed datums
    /// </summary>
    public List<FixedDatum> FixedDatums { get; set; } = [];

    /// <summary>
    /// variable length list of variable length datums
    /// </summary>
    public List<VariableDatum> VariableDatums { get; set; } = [];

}

/// <summary>
/// First part of a simulation management (SIMAN) PDU and SIMAN-Reliability (SIMAN-R) PDU. Sectionn 6.2.81
/// </summary>
public abstract partial class SimulationManagementFamilyPdu : PduBase
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
/// Section 7.5.4. The Start/Resume of an entity/exercise shall be communicated using a Start/Resume PDU. See 5.6.5.4.
/// </summary>
public partial class StartResumePdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// This field shall specify the real-world time (UTC) at which the entity is to start/resume in the exercise. This information shall be used by the participating simulation applications to start/resume an exercise synchronously. This field shall be represented by a Clock Time record (see 6.2.16).
    /// </summary>
    public ClockTime RealWorldTime { get; set; } = new ClockTime();

    /// <summary>
    /// The reference time within a simulation exercise. This time is established in advance by simulation management and is common to all participants in a particular exercise. Simulation time may be either Absolute Time or Relative Time. This field shall be represented by a Clock Time record (see 6.2.16)
    /// </summary>
    public ClockTime SimulationTime { get; set; } = new ClockTime();

    /// <summary>
    /// Identifier for the specific and unique start/resume request
    /// </summary>
    public uint RequestId { get; set; }

}

/// <summary>
/// Section 7.5.5. The stopping or freezing of an entity/exercise shall be communicated using a Stop/Freeze PDU. See 5.6.5.5
/// </summary>
public partial class StopFreezePdu : SimulationManagementFamilyPdu
{
    /// <summary>
    /// real-world(UTC) time at which the entity shall stop or freeze in the exercise
    /// </summary>
    public ClockTime RealWorldTime { get; set; } = new ClockTime();

    /// <summary>
    /// Reason the simulation was stopped or frozen (see section 7 of SISO-REF-010) represented by an 8-bit enumeration
    /// </summary>
    public byte Reason { get; set; }

    /// <summary>
    /// Internal behavior of the entity (or simulation) and its appearance while frozen to the other participants
    /// </summary>
    public byte FrozenBehavior { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding1 { get; set; }

    /// <summary>
    /// Request ID that is unique
    /// </summary>
    public uint RequestId { get; set; }

}


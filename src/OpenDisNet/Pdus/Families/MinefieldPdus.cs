// DIS v7 protocol models reviewed from MinefieldFamilyPdus.xml.
#pragma warning disable CS0108
using OpenDisNet.Enumerations;
using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

/// <summary>
/// simulation time of emplacement of the mine
/// </summary>
public partial class MineEmplacementTime
{
    public uint Hour { get; set; }

    public uint TimePastTheHour { get; set; }

}

/// <summary>
/// 5.10.4 Information about the location and status of a collection of mines in a minefield is conveyed through the Minefield Data PDU on an individual mine basis.
/// </summary>
public partial class MinefieldDataPdu : MinefieldFamilyPdu
{
    /// <summary>Creates a DIS v7 MinefieldDataPdu with its wire discriminator fields initialized.</summary>
    public MinefieldDataPdu() => Initialize(39, 8);

    /// <summary>
    /// Minefield ID provides a unique identifier
    /// </summary>
    public MinefieldIdentifier MinefieldId { get; set; } = new MinefieldIdentifier();

    /// <summary>
    /// ID of entity making request
    /// </summary>
    public SimulationIdentifier RequestingEntityId { get; set; } = new SimulationIdentifier();

    /// <summary>
    /// Minefield sequence number
    /// </summary>
    public ushort MinefieldSequenceNumber { get; set; }

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public byte RequestId { get; set; }

    /// <summary>
    /// pdu sequence number
    /// </summary>
    public byte PduSequenceNumber { get; set; }

    /// <summary>
    /// number of pdus in response
    /// </summary>
    public byte NumberOfPdus { get; set; }

    /// <summary>
    /// how many mines are in this PDU
    /// </summary>
    internal byte NumberOfMinesInThisPdu { get; set; }

    /// <summary>
    /// how many sensor type are in this PDU
    /// </summary>
    internal byte NumberOfSensorTypes { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

    /// <summary>
    /// 32 boolean field
    /// </summary>
    public DataFilterRecord DataFilter { get; set; } = new DataFilterRecord();

    /// <summary>
    /// Mine type
    /// </summary>
    public EntityType MineType { get; set; } = new EntityType();

    /// <summary>
    /// Sensor types, each 16-bits long
    /// </summary>
    public List<MinefieldSensorType> SensorTypes { get; set; } = [];

    /// <summary>
    /// Mine locations
    /// </summary>
    public List<Vector3Float> MineLocation { get; set; } = [];

    public float[] GroundBurialDepthOffset { get; set; } = [];

    public float[] WaterBurialDepthOffset { get; set; } = [];

    public float[] SnowBurialDepthOffset { get; set; } = [];

    public List<EulerAngles> MineOrientation { get; set; } = [];

    public float[] ThermalContrast { get; set; } = [];

    public float[] Reflectance { get; set; } = [];

    public List<MineEmplacementTime> MineEmplacementTime { get; set; } = [];

    public ushort[] MineEntityNumber { get; set; } = [];

    public List<MinefieldDataFusing> Fusing { get; set; } = [];

    public byte[] ScalarDetectionCoefficient { get; set; } = [];

    public List<MinefieldDataPaintScheme> PaintScheme { get; set; } = [];

    public byte[] NumberOfTripDetonationWires { get; set; } = [];

    public byte[] NumberOfVertices { get; set; } = [];

}

/// <summary>
/// Abstract superclass for PDUs relating to minefields. Section 7.9
/// </summary>
public abstract partial class MinefieldFamilyPdu : PduBase
{
}

/// <summary>
/// 5.10.3 Contains information about the requesting entity and the region and mine types of interest to the requesting entity.
/// </summary>
public partial class MinefieldQueryPdu : MinefieldFamilyPdu
{
    /// <summary>Creates a DIS v7 MinefieldQueryPdu with its wire discriminator fields initialized.</summary>
    public MinefieldQueryPdu() => Initialize(38, 8);

    /// <summary>
    /// Minefield ID provides a unique identifier
    /// </summary>
    public MinefieldIdentifier MinefieldId { get; set; } = new MinefieldIdentifier();

    /// <summary>
    /// EID of entity making the request
    /// </summary>
    public EntityId RequestingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public byte RequestId { get; set; }

    /// <summary>
    /// Number of perimeter points for the minefield
    /// </summary>
    internal byte NumberOfPerimeterPoints { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public byte Padding { get; set; }

    /// <summary>
    /// Number of sensor types
    /// </summary>
    internal byte NumberOfSensorTypes { get; set; }

    /// <summary>
    /// data filter, 32 boolean fields
    /// </summary>
    public DataFilterRecord DataFilter { get; set; } = new DataFilterRecord();

    /// <summary>
    /// Entity type of mine being requested
    /// </summary>
    public EntityType RequestedMineType { get; set; } = new EntityType();

    /// <summary>
    /// perimeter points of request
    /// </summary>
    public List<Vector2Float> RequestedPerimeterPoints { get; set; } = [];

    /// <summary>
    /// Sensor types, each 16-bits long
    /// </summary>
    public List<MinefieldSensorType> SensorTypes { get; set; } = [];

}

/// <summary>
/// 5.10.5 Contains information about the requesting entity and the PDU(s) that were not received in response to a query. NACK = Negative Acknowledgment.
/// </summary>
public partial class MinefieldResponseNACKPdu : MinefieldFamilyPdu
{
    /// <summary>Creates a DIS v7 MinefieldResponseNACKPdu with its wire discriminator fields initialized.</summary>
    public MinefieldResponseNACKPdu() => Initialize(40, 8);

    /// <summary>
    /// Minefield ID provides a unique identifier
    /// </summary>
    public MinefieldIdentifier MinefieldId { get; set; } = new MinefieldIdentifier();

    /// <summary>
    /// entity ID making the request
    /// </summary>
    public SimulationIdentifier RequestingEntityId { get; set; } = new SimulationIdentifier();

    /// <summary>
    /// request ID provides a unique identifier
    /// </summary>
    public byte RequestId { get; set; }

    /// <summary>
    /// how many pdus were missing
    /// </summary>
    internal byte NumberOfMissingPdus { get; set; }

    /// <summary>
    /// PDU sequence numbers that were missing
    /// </summary>
    public byte[] MissingPduSequenceNumbers { get; set; } = [];

}

/// <summary>
/// 5.10.2 Communicate information about the minefield, including the location, perimeter, and types of mines contained within it.
/// </summary>
public partial class MinefieldStatePdu : MinefieldFamilyPdu
{
    /// <summary>Creates a DIS v7 MinefieldStatePdu with its wire discriminator fields initialized.</summary>
    public MinefieldStatePdu() => Initialize(37, 8);

    /// <summary>
    /// Minefield ID provides a unique identifier
    /// </summary>
    public MinefieldIdentifier MinefieldId { get; set; } = new MinefieldIdentifier();

    /// <summary>
    /// Minefield sequence number shall specify a change in state of a minefield as a result of a change in minefield information or a change in the state, in accordance with the rules specified in 5.10.2.3, of any of the mines contained therein
    /// </summary>
    public ushort MinefieldSequence { get; set; }

    /// <summary>
    /// force ID provides a unique identifier
    /// </summary>
    public ForceId ForceId { get; set; }

    /// <summary>
    /// Number of permieter points
    /// </summary>
    internal byte NumberOfPerimeterPoints { get; set; }

    /// <summary>
    /// type of minefield
    /// </summary>
    public EntityType MinefieldType { get; set; } = new EntityType();

    /// <summary>
    /// the number of different mine types employed in the minefield
    /// </summary>
    internal ushort NumberOfMineTypes { get; set; }

    /// <summary>
    /// location of center of minefield in world coordinates
    /// </summary>
    public Vector3Double MinefieldLocation { get; set; } = new Vector3Double();

    /// <summary>
    /// orientation of minefield
    /// </summary>
    public EulerAngles MinefieldOrientation { get; set; } = new EulerAngles();

    /// <summary>
    /// appearance bitflags information needed for displaying the symbology of the minefield as a doctrinal minefield graphic
    /// </summary>
    public MinefieldStateAppearanceBitMap Appearance { get; set; }

    /// <summary>
    /// protocolMode. First two bits are the protocol mode, 14 bits reserved.
    /// </summary>
    public ProtocolMode ProtocolMode { get; set; } = new ProtocolMode();

    /// <summary>
    /// location of each perimeter point, relative to the Minefield Location field. Only the x and y coordinates of each perimeter point shall be specified.
    /// </summary>
    public List<Vector2Float> PerimeterPoints { get; set; } = [];

    /// <summary>
    /// type of each mine contained within the minefield
    /// </summary>
    public List<EntityType> MineType { get; set; } = [];

}


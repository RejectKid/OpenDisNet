// DIS v7 protocol models reviewed from DistributedEmissionsFamilyPdus.xml.
#pragma warning disable CS0108
using OpenDisNet.Enumerations;
using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

/// <summary>
/// 7.6.5.1 Abstract base class for IFFPduLayerData classes
/// </summary>
public partial class AbstractIFFPduLayerData
{
}

/// <summary>
/// 7.6.3 Handles designating operations. See 5.3.7.2.
/// </summary>
public partial class DesignatorPdu : DistributedEmissionsRegenerationFamilyPdu
{
    /// <summary>Creates a DIS v7 DesignatorPdu with its wire discriminator fields initialized.</summary>
    public DesignatorPdu() => Initialize(24, 6);

    /// <summary>
    /// ID of the entity designating
    /// </summary>
    public EntityId DesignatingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// This field shall specify a unique emitter database number assigned to  differentiate between otherwise similar or identical emitter beams within an emitter system.
    /// </summary>
    public DesignatorSystemName CodeName { get; set; }

    /// <summary>
    /// ID of the entity being designated
    /// </summary>
    public EntityId DesignatedEntityId { get; set; } = new EntityId();

    /// <summary>
    /// This field shall identify the designator code being used by the designating entity
    /// </summary>
    public DesignatorDesignatorCode DesignatorCode { get; set; }

    /// <summary>
    /// This field shall identify the designator output power in watts
    /// </summary>
    public float DesignatorPower { get; set; }

    /// <summary>
    /// This field shall identify the designator wavelength in units of microns
    /// </summary>
    public float DesignatorWavelength { get; set; }

    /// <summary>
    /// designtor spot wrt the designated entity
    /// </summary>
    public Vector3Float DesignatorSpotWrtDesignated { get; set; } = new Vector3Float();

    /// <summary>
    /// designtor spot wrt the designated entity
    /// </summary>
    public Vector3Double DesignatorSpotLocation { get; set; } = new Vector3Double();

    /// <summary>
    /// Dead reckoning algorithm
    /// </summary>
    public DeadReckoningAlgorithm DeadReckoningAlgorithm { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Padding1 { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding2 { get; set; }

    /// <summary>
    /// linear accelleration of entity
    /// </summary>
    public Vector3Float EntityLinearAcceleration { get; set; } = new Vector3Float();

}

/// <summary>
/// Section 5.3.7. Electronic Emissions. Abstract superclass for distributed emissions PDU
/// </summary>
public abstract partial class DistributedEmissionsRegenerationFamilyPdu : PduBase
{
}

/// <summary>
/// 7.6.2 Communicate active electromagnetic emissions, including radar and radar-related electronic warfare (e.g., jamming). Exceptions include IFF interrogations and replies, navigation aids, voice, beacon and data radio communications, directed energy weapons, and laser ranging and designation systems, which are handled by other PDUs. Section 5.3.7.1.
/// </summary>
public partial class ElectromagneticEmissionPdu : DistributedEmissionsRegenerationFamilyPdu
{
    /// <summary>Creates a DIS v7 ElectromagneticEmissionPdu with its wire discriminator fields initialized.</summary>
    public ElectromagneticEmissionPdu() => Initialize(23, 6);

    /// <summary>
    /// ID of the entity emitting
    /// </summary>
    public EntityId EmittingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of event
    /// </summary>
    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// This field shall be used to indicate if the data in the PDU represents a state update or just data that has changed since issuance of the last Electromagnetic Emission PDU [relative to the identified entity and emission system(s)].
    /// </summary>
    public ElectromagneticEmissionStateUpdateIndicator StateUpdateIndicator { get; set; }

    /// <summary>
    /// This field shall specify the number of emission systems being described in the current PDU.
    /// </summary>
    internal byte NumberOfSystems { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort PaddingForEmissionsPdu { get; set; }

    /// <summary>
    /// Electronic emmissions systems
    /// </summary>
    public List<ElectronicEmitter> Systems { get; set; } = [];

}

/// <summary>
/// A device that is able to discharge detectable electromagnetic energy.
/// </summary>
public partial class ElectronicEmitter
{
    /// <summary>
    /// this field shall specify the length of this emitter system's data in 32-bit words.
    /// </summary>
    public byte SystemDataLength { get; set; }

    /// <summary>
    /// the number of beams being described in the current PDU for the emitter system being described.
    /// </summary>
    internal byte NumberOfBeams { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// information about a particular emitter system and shall be represented by an Emitter System record (see 6.2.23).
    /// </summary>
    public EmitterSystem EmitterSystem { get; set; } = new EmitterSystem();

    /// <summary>
    /// the location of the antenna beam source with respect to the emitting entity's coordinate system. This location shall be the origin of the emitter coordinate system that shall have the same orientation as the entity coordinate system. This field shall be represented by an Entity Coordinate Vector record see 6.2.95
    /// </summary>
    public Vector3Float Location { get; set; } = new Vector3Float();

    /// <summary>
    /// Electronic emission beams
    /// </summary>
    public List<EmitterBeam> Beams { get; set; } = [];

}

/// <summary>
/// Emitter beams focused emissions from an electromagnetic or active acoustic transmitter. The beam is defined by the main lobe of the antenna pattern.
/// </summary>
public partial class EmitterBeam
{
    public byte BeamDataLength { get; set; }

    public byte BeamNumber { get; set; }

    public ushort BeamParameterIndex { get; set; }

    public EEFundamentalParameterData FundamentalParameterData { get; set; } = new EEFundamentalParameterData();

    public BeamData BeamData { get; set; } = new BeamData();

    public ElectromagneticEmissionBeamFunction BeamFunction { get; set; }

    internal byte NumberOfTargets { get; set; }

    public HighDensityTrackJam HighDensityTrackJam { get; set; }

    public BeamStatus BeamStatus { get; set; } = new BeamStatus();

    public JammingTechnique JammingTechnique { get; set; } = new JammingTechnique();

    public List<TrackJamData> TrackJamData { get; set; } = [];

}

/// <summary>
/// 7.6.5.3 Layer 2 emissions data
/// </summary>
public partial class IFFPduLayer2Data : AbstractIFFPduLayerData
{
    /// <summary>
    /// Layer header
    /// </summary>
    public LayerHeader LayerHeader { get; set; } = new LayerHeader();

    /// <summary>
    /// Beam data
    /// </summary>
    public BeamData BeamData { get; set; } = new BeamData();

    public byte SecondaryOpParameter1 { get; set; }

    public byte SecondaryOpParameter2 { get; set; }

    public ushort NumberOfIFFFundamentalParameterDataRecordsParameters { get; set; }

    /// <summary>
    /// Variable length list of fundamental parameters.
    /// </summary>
    public List<IFFFundamentalParameterData> IFFFundamentalParameterDataRecord { get; set; } = [];

}

/// <summary>
/// 7.6.5.4.2 Layer 3 Mode 5 interrogator format
/// </summary>
public partial class IFFPduLayer3InterrogatorFormatData : AbstractIFFPduLayerData
{
    /// <summary>
    /// Layer header
    /// </summary>
    public LayerHeader LayerHeader { get; set; } = new LayerHeader();

    /// <summary>
    /// 6.2.80 Site number, part of reporting simulation field
    /// </summary>
    public ushort SiteNumber { get; set; }

    /// <summary>
    /// 6.2.80 Application number, part of reporting simulation field
    /// </summary>
    public ushort ApplicationNumber { get; set; }

    /// <summary>
    /// Mode 5 interrogator basic data
    /// </summary>
    public Mode5InterrogatorBasicData Mode5InterrogatorBasicData { get; set; } = new Mode5InterrogatorBasicData();

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding { get; set; }

    public ushort NumberOfIFFFundamentalParameterDataRecordsParameters { get; set; }

    /// <summary>
    /// Variable length list of fundamental parameters.
    /// </summary>
    public List<IFFDataSpecification> IFFFundamentalParameterDataRecord { get; set; } = [];

}

/// <summary>
/// 7.6.5.4.3 Layer 3 Mode 5 transponder format
/// </summary>
public partial class IFFPduLayer3TransponderFormatData : AbstractIFFPduLayerData
{
    /// <summary>
    /// Layer header
    /// </summary>
    public LayerHeader LayerHeader { get; set; } = new LayerHeader();

    /// <summary>
    /// 6.2.80 Site number, part of reporting simulation field
    /// </summary>
    public ushort SiteNumber { get; set; }

    /// <summary>
    /// 6.2.80 Application number, part of reporting simulation field
    /// </summary>
    public ushort ApplicationNumber { get; set; }

    /// <summary>
    /// Mode 5 transponder basic data
    /// </summary>
    public Mode5TransponderBasicData Mode5TransponderBasicData { get; set; } = new Mode5TransponderBasicData();

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding { get; set; }

    public ushort NumberOfIFFFundamentalParameterDataRecordsParameters { get; set; }

    /// <summary>
    /// Variable length list of fundamental parameters.
    /// </summary>
    public List<IFFDataSpecification> IFFFundamentalParameterDataRecord { get; set; } = [];

}

/// <summary>
/// 7.6.5.5.2 Layer 4 Mode S interrogator format
/// </summary>
public partial class IFFPduLayer4InterrogatorFormatData : AbstractIFFPduLayerData
{
    /// <summary>
    /// Layer header
    /// </summary>
    public LayerHeader LayerHeader { get; set; } = new LayerHeader();

    /// <summary>
    /// 6.2.80 Site number, part of reporting simulation field
    /// </summary>
    public ushort SiteNumber { get; set; }

    /// <summary>
    /// 6.2.80 Application number, part of reporting simulation field
    /// </summary>
    public ushort ApplicationNumber { get; set; }

    /// <summary>
    /// Mode S interrogator basic data
    /// </summary>
    public ModeSInterrogatorBasicData ModeSInterrogatorBasicData { get; set; } = new ModeSInterrogatorBasicData();

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding { get; set; }

    public ushort NumberOfIFFFundamentalParameterDataRecordsParameters { get; set; }

    /// <summary>
    /// Variable length list of fundamental parameters.
    /// </summary>
    public List<IFFDataSpecification> IFFFundamentalParameterDataRecord { get; set; } = [];

}

/// <summary>
/// 7.6.5.5.3 Layer 4 Mode S transponder format
/// </summary>
public partial class IFFPduLayer4TransponderFormatData : AbstractIFFPduLayerData
{
    /// <summary>
    /// Layer header
    /// </summary>
    public LayerHeader LayerHeader { get; set; } = new LayerHeader();

    /// <summary>
    /// 6.2.80 Site number, part of reporting simulation field
    /// </summary>
    public ushort SiteNumber { get; set; }

    /// <summary>
    /// 6.2.80 Application number, part of reporting simulation field
    /// </summary>
    public ushort ApplicationNumber { get; set; }

    /// <summary>
    /// Mode S transponder basic data
    /// </summary>
    public ModeSTransponderBasicData ModeSTransponderBasicData { get; set; } = new ModeSTransponderBasicData();

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding { get; set; }

    public ushort NumberOfIFFFundamentalParameterDataRecordsParameters { get; set; }

    /// <summary>
    /// Variable length list of fundamental parameters.
    /// </summary>
    public List<IFFDataSpecification> IFFFundamentalParameterDataRecord { get; set; } = [];

}

/// <summary>
/// 7.6.5.6. Layer 5 data communications
/// </summary>
public partial class IFFPduLayer5Data : AbstractIFFPduLayerData
{
    /// <summary>
    /// Layer header
    /// </summary>
    public LayerHeader LayerHeader { get; set; } = new LayerHeader();

    /// <summary>
    /// 6.2.80 Site number, part of reporting simulation field
    /// </summary>
    public ushort SiteNumber { get; set; }

    /// <summary>
    /// 6.2.80 Application number, part of reporting simulation field
    /// </summary>
    public ushort ApplicationNumber { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// Eight boolean fields. See 6.2.45.
    /// </summary>
    public byte ApplicableLayers { get; set; }

    /// <summary>
    /// Data category
    /// </summary>
    public DataCategory DataCategory { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding2 { get; set; }

    public ushort NumberOfIFFFundamentalParameterDataRecordsParameters { get; set; }

    /// <summary>
    /// Variable length list of fundamental parameters.
    /// </summary>
    public List<IFFDataSpecification> IFFFundamentalParameterDataRecord { get; set; } = [];

}

/// <summary>
/// 7.6.5.1 Information about military and civilian interrogators, transponders, and specific other electronic systems. See 5.7.6
/// </summary>
public partial class IdentificationFriendOrFoePdu : DistributedEmissionsRegenerationFamilyPdu
{
    /// <summary>Creates a DIS v7 IdentificationFriendOrFoePdu with its wire discriminator fields initialized.</summary>
    public IdentificationFriendOrFoePdu() => Initialize(28, 6);

    /// <summary>
    /// ID of the entity that is the source of the emissions. Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public EntityId EmittingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// Number generated by the issuing simulation to associate realted events. Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// Location wrt entity. There is some ambiguity in the standard here, but this is the order it is listed in the table. Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public Vector3Float Location { get; set; } = new Vector3Float();

    /// <summary>
    /// System ID information. Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public SystemIdentifier SystemId { get; set; } = new SystemIdentifier();

    /// <summary>
    /// Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public byte SystemDesignator { get; set; }

    /// <summary>
    /// Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public byte SystemSpecificData { get; set; }

    /// <summary>
    /// Fundamental parameters. Part of Layer 1 basic system data 7.6.5.2.
    /// </summary>
    public FundamentalOperationalData FundamentalParameters { get; set; } = new FundamentalOperationalData();

    /// <summary>
    /// IFF pdu layer 2 data
    /// </summary>
    public IFFPduLayer2Data IFFPduLayer2Data { get; set; } = new IFFPduLayer2Data();

    /// <summary>
    /// IFF pdu layer 3 transponder format data
    /// </summary>
    public IFFPduLayer3TransponderFormatData IFFPduLayer3TransponderFormatData { get; set; } = new IFFPduLayer3TransponderFormatData();

    /// <summary>
    /// IFF pdu layer 3 interrogator format data
    /// </summary>
    public IFFPduLayer3InterrogatorFormatData IFFPduLayer3InterrogatorFormatData { get; set; } = new IFFPduLayer3InterrogatorFormatData();

    /// <summary>
    /// IFF pdu layer 4 interrogator format data
    /// </summary>
    public IFFPduLayer4InterrogatorFormatData IFFPduLayer4InterrogatorFormatData { get; set; } = new IFFPduLayer4InterrogatorFormatData();

    /// <summary>
    /// IFF pdu layer 4 transponder format data
    /// </summary>
    public IFFPduLayer4TransponderFormatData IFFPduLayer4TransponderFormatData { get; set; } = new IFFPduLayer4TransponderFormatData();

    /// <summary>
    /// IFF pdu layer 5 data communications
    /// </summary>
    public IFFPduLayer5Data IFFPduLayer5Data { get; set; } = new IFFPduLayer5Data();

}

/// <summary>
/// B.2.26. Mode 5 interrogator basic data
/// </summary>
public partial class Mode5InterrogatorBasicData
{
    /// <summary>
    /// Mode 5 interrogator status, part of Mode 5 interrogator basic data fields
    /// </summary>
    public byte Mode5InterrogatorStatus { get; set; }

    /// <summary>
    /// Padding, part of Mode 5 interrogator basic data fields
    /// </summary>
    public byte Padding { get; set; }

    /// <summary>
    /// Padding, part of Mode 5 interrogator basic data fields
    /// </summary>
    public ushort Padding2 { get; set; }

    /// <summary>
    /// Mode 5 Message Formats Present, part of Mode 5 interrogator basic data fields
    /// </summary>
    public uint Mode5MessageFormatsPresent { get; set; }

    /// <summary>
    /// Interrogated entity ID, part of Mode 5 interrogator basic data fields
    /// </summary>
    public EntityId EntityId { get; set; } = new EntityId();

    /// <summary>
    /// Padding, part of Mode 5 interrogator basic data fields
    /// </summary>
    public ushort Padding3 { get; set; }

}

/// <summary>
/// B.2.29. Mode 5 transponder basic data
/// </summary>
public partial class Mode5TransponderBasicData
{
    /// <summary>
    /// Mode 5 status, part of Mode 5 transponder basic data fields
    /// </summary>
    public ushort Mode5Status { get; set; }

    /// <summary>
    /// Personal Identification Number (PIN), part of Mode 5 transponder basic data fields
    /// </summary>
    public ushort PersonalIdentificationNumber { get; set; }

    /// <summary>
    /// Mode 5 Message Formats Present, part of Mode 5 transponder basic data fields
    /// </summary>
    public uint Mode5MessageFormatsPresent { get; set; }

    /// <summary>
    /// Enhanced Mode 1, part of Mode 5 transponder basic data fields
    /// </summary>
    public ushort EnhancedMode1 { get; set; }

    /// <summary>
    /// National Origin, part of Mode 5 transponder basic data fields
    /// </summary>
    public ushort NationalOrigin { get; set; }

    /// <summary>
    /// Supplemental Data, part of Mode 5 transponder basic data fields
    /// </summary>
    public byte SupplementalData { get; set; }

    /// <summary>
    /// Navigation Source, part of Mode 5 transponder basic data fields
    /// </summary>
    public NavigationSource NavigationSource { get; set; }

    /// <summary>
    /// Figure of merit, part of Mode 5 transponder basic data fields
    /// </summary>
    public byte FigureOfMerit { get; set; }

    /// <summary>
    /// Padding, part of Mode 5 transponder basic data fields
    /// </summary>
    public byte Padding { get; set; }

}

/// <summary>
/// B.2.37. Mode S interrogator basic data
/// </summary>
public partial class ModeSInterrogatorBasicData
{
    /// <summary>
    /// Mode S interrogator status, part of Mode S interrogator basic data fields. See B.2.39.
    /// </summary>
    public byte ModeSInterrogatorStatus { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public byte Padding { get; set; }

    /// <summary>
    /// Mode S levels present, part of Mode S interrogator basic data fields. See B.2.40
    /// </summary>
    public byte ModeSLevelsPresent { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public byte Padding2 { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public uint Padding3 { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public uint Padding4 { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public uint Padding5 { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public uint Padding6 { get; set; }

    /// <summary>
    /// Padding, part of Mode S interrogator basic data fields
    /// </summary>
    public uint Padding7 { get; set; }

}

/// <summary>
/// B.2.41. Mode S transponder basic data
/// </summary>
public partial class ModeSTransponderBasicData
{
    /// <summary>
    /// Mode S transponder status, part of Mode S transponder basic data fields. See B.2.42.
    /// </summary>
    public ushort ModeSTransponderStatus { get; set; }

    /// <summary>
    /// Mode S levels present, part of Mode S transponder basic data fields. See B.2.40.
    /// </summary>
    public byte ModeSLevelsPresent { get; set; }

    /// <summary>
    /// aircraft present domain
    /// </summary>
    public AircraftPresentDomain AircraftPresentDomain { get; set; }

    /// <summary>
    /// Aircraft identification, part of Mode S transponder basic data fields. See B.2.35.
    /// </summary>
    public ulong AircraftIdentification { get; set; }

    /// <summary>
    /// Unique ICAO Mode S aircraft address, part of Mode S transponder basic data fields.
    /// </summary>
    public uint AircraftAddress { get; set; }

    /// <summary>
    /// Aircraft identification type, part of Mode S transponder basic data fields.
    /// </summary>
    public AircraftIdentificationType AircraftIdentificationType { get; set; }

    /// <summary>
    /// DAP source, part of Mode S transponder basic data fields. See B.2.6.
    /// </summary>
    public byte DapSource { get; set; }

    /// <summary>
    /// Mode S altitude, part of Mode S transponder basic data fields. See B.2.36.
    /// </summary>
    public ushort ModeSAltitude { get; set; }

    /// <summary>
    /// Capability report, part of Mode S transponder basic data fields.
    /// </summary>
    public CapabilityReport CapabilityReport { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public byte Padding { get; set; }

    /// <summary>
    /// Padding
    /// </summary>
    public ushort Padding2 { get; set; }

}

/// <summary>
/// 7.6.6 Certain supplemental information on an entity’s physical state and emissions. See 5.7.7
/// </summary>
public partial class SupplementalEmissionEntityStatePdu : DistributedEmissionsRegenerationFamilyPdu
{
    /// <summary>Creates a DIS v7 SupplementalEmissionEntityStatePdu with its wire discriminator fields initialized.</summary>
    public SupplementalEmissionEntityStatePdu() => Initialize(30, 6);

    /// <summary>
    /// Originating entity ID provides a unique identifier
    /// </summary>
    public EntityId OrginatingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// IR Signature representation index
    /// </summary>
    public ushort InfraredSignatureRepresentationIndex { get; set; }

    /// <summary>
    /// acoustic Signature representation index
    /// </summary>
    public ushort AcousticSignatureRepresentationIndex { get; set; }

    /// <summary>
    /// radar cross section representation index
    /// </summary>
    public ushort RadarCrossSectionSignatureRepresentationIndex { get; set; }

    /// <summary>
    /// how many propulsion systems
    /// </summary>
    internal ushort NumberOfPropulsionSystems { get; set; }

    /// <summary>
    /// how many vectoring nozzle systems
    /// </summary>
    internal ushort NumberOfVectoringNozzleSystems { get; set; }

    /// <summary>
    /// variable length list of propulsion system data
    /// </summary>
    public List<PropulsionSystemData> PropulsionSystemData { get; set; } = [];

    /// <summary>
    /// variable length list of vectoring system data
    /// </summary>
    public List<VectoringNozzleSystem> VectoringSystemData { get; set; } = [];

}

/// <summary>
/// Information for one or more acoustic beams that the system has, including: length of the beam data,  beam identification number for each beam, and fundamental parametric data used to define the entity’s active emissions.  This field defines the active  emission  parameter  index,  beam  scan  pattern,  orientation,  and beamwidth, which can vary dynamically during system operation.
/// </summary>
public partial class UABeam
{
    public byte BeamDataLength { get; set; }

    public byte BeamNumber { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    public UAFundamentalParameter FundamentalParameterData { get; set; } = new UAFundamentalParameter();

}

/// <summary>
/// Underwater Acoustic (UA) active emissions (intentional emissions) and passive signature (unintentional emissions) information.
/// </summary>
public partial class UAEmitter
{
    /// <summary>
    /// this field shall specify the length of this emitter system's data in 32-bit words.
    /// </summary>
    public byte SystemDataLength { get; set; }

    /// <summary>
    /// the number of beams being described in the current PDU for the emitter system being described.
    /// </summary>
    internal byte NumberOfBeams { get; set; }

    /// <summary>
    /// zero-filled array of padding bits for byte alignment and consistent sizing of PDU data
    /// </summary>
    public ushort Padding { get; set; }

    /// <summary>
    /// TODO
    /// </summary>
    public AcousticEmitter AcousticEmitter { get; set; } = new AcousticEmitter();

    /// <summary>
    /// the location of the antenna beam source with respect to the emitting entity's coordinate system. This location shall be the origin of the emitter coordinate system that shall have the same orientation as the entity coordinate system. This field shall be represented by an Entity Coordinate Vector record see 6.2.95
    /// </summary>
    public Vector3Float Location { get; set; } = new Vector3Float();

    /// <summary>
    /// Electronic emission beams
    /// </summary>
    public List<UABeam> Beams { get; set; } = [];

}

/// <summary>
/// 7.6.4 Information about underwater acoustic emmissions. See 5.7.5.
/// </summary>
public partial class UnderwaterAcousticPdu : DistributedEmissionsRegenerationFamilyPdu
{
    /// <summary>Creates a DIS v7 UnderwaterAcousticPdu with its wire discriminator fields initialized.</summary>
    public UnderwaterAcousticPdu() => Initialize(29, 6);

    /// <summary>
    /// ID of the entity that is the source of the emission
    /// </summary>
    public EntityId EmittingEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of event
    /// </summary>
    public EventIdentifier EventId { get; set; } = new EventIdentifier();

    /// <summary>
    /// This field shall be used to indicate whether the data in the UA PDU represent a state update or data that have changed since issuance of the last UA PDU
    /// </summary>
    public UaStateChangeUpdateIndicator StateChangeIndicator { get; set; }

    /// <summary>
    /// padding
    /// </summary>
    public byte Pad { get; set; }

    /// <summary>
    /// This field indicates which database record (or file) shall be used in the definition of passive signature (unintentional) emissions of the entity. The indicated database record (or  file) shall define all noise generated as a function of propulsion plant configurations and associated  auxiliaries.
    /// </summary>
    public UaPassiveParameterIndex PassiveParameterIndex { get; set; }

    /// <summary>
    /// This field shall specify the entity propulsion plant configuration. This field is used to determine the passive signature characteristics of an entity.
    /// </summary>
    public byte PropulsionPlantConfiguration { get; set; }

    /// <summary>
    /// This field shall represent the number of shafts on a platform
    /// </summary>
    internal byte NumberOfShafts { get; set; }

    /// <summary>
    /// This field shall indicate the number of APAs described in the current UA PDU
    /// </summary>
    internal byte NumberOfAPAs { get; set; }

    /// <summary>
    /// This field shall specify the number of UA emitter systems being described in the current UA PDU
    /// </summary>
    internal byte NumberOfUAEmitterSystems { get; set; }

    /// <summary>
    /// shaft RPM values.
    /// </summary>
    public List<ShaftRPM> ShaftRPMs { get; set; } = [];

    /// <summary>
    /// additional passive activities
    /// </summary>
    public List<APA> ApaData { get; set; } = [];

    public List<UAEmitter> EmitterSystems { get; set; } = [];

}


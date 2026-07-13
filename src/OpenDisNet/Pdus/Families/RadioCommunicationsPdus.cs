// DIS v7 protocol models reviewed from RadioCommunicationsFamilyPdus.xml.
#pragma warning disable CS0108
namespace OpenDisNet.Pdus;

/// <summary>
/// 5.8.7 Communicates the state of a particular intercom device, request an action of another intercom device, or respond to an action request.
/// </summary>
public partial class IntercomControlPdu : RadioCommunicationsFamilyPdu
{
    /// <summary>Creates a DIS v7 IntercomControlPdu with its wire discriminator fields initialized.</summary>
    public IntercomControlPdu() => Initialize(32, 4);

    /// <summary>
    /// control type
    /// </summary>
    public byte ControlType { get; set; }

    /// <summary>
    /// control type
    /// </summary>
    public byte CommunicationsChannelType { get; set; }

    /// <summary>
    /// Source entity ID, this can also be ObjectIdentifier or UnattachedIdentifier
    /// </summary>
    public EntityId SourceEntityId { get; set; } = new EntityId();

    /// <summary>
    /// The specific intercom device being simulated within an entity.
    /// </summary>
    public ushort SourceIntercomNumber { get; set; }

    /// <summary>
    /// Line number to which the intercom control refers
    /// </summary>
    public byte SourceLineId { get; set; }

    /// <summary>
    /// priority of this message relative to transmissons from other intercom devices
    /// </summary>
    public byte TransmitPriority { get; set; }

    /// <summary>
    /// current transmit state of the line
    /// </summary>
    public byte TransmitLineState { get; set; }

    /// <summary>
    /// detailed type requested.
    /// </summary>
    public byte Command { get; set; }

    /// <summary>
    /// eid of the entity that has created this intercom channel, same comments as sourceEntityId
    /// </summary>
    public EntityId MasterIntercomReferenceId { get; set; } = new EntityId();

    /// <summary>
    /// specific intercom device that has created this intercom channel
    /// </summary>
    public ushort MasterIntercomNumber { get; set; }

    public ushort MasterChannelId { get; set; }

    /// <summary>
    /// number of intercom parameters
    /// </summary>
    internal uint IntercomParametersLength { get; set; }

    public List<IntercomCommunicationsParameters> IntercomParameters { get; set; } = [];

}

/// <summary>
/// unique reference ID for this intercom
/// </summary>
public partial class IntercomReferenceID
{
    public ushort SiteNumber { get; set; }

    public ushort ApplicationNumber { get; set; }

    public ushort ReferenceNumber { get; set; }

}

/// <summary>
/// 5.8.6 Conveys the audio or digital data that is used to communicate between simulated intercom devices
/// </summary>
public partial class IntercomSignalPdu : RadioCommunicationsFamilyPdu
{
    /// <summary>Creates a DIS v7 IntercomSignalPdu with its wire discriminator fields initialized.</summary>
    public IntercomSignalPdu() => Initialize(31, 4);

    /// <summary>
    /// The unique designation of an attached or unattached intercom in an event or exercise
    /// </summary>
    public IntercomReferenceID IntercomReferenceId { get; set; } = new IntercomReferenceID();

    /// <summary>
    /// ID of communications device
    /// </summary>
    public ushort IntercomNumber { get; set; }

    /// <summary>
    /// encoding scheme
    /// </summary>
    public ushort EncodingScheme { get; set; }

    /// <summary>
    /// tactical data link type
    /// </summary>
    public ushort TdlType { get; set; }

    /// <summary>
    /// sample rate
    /// </summary>
    public uint SampleRate { get; set; }

    /// <summary>
    /// meaningful length of data in bits; the final octet may contain padding bits
    /// </summary>
    public ushort DataBitLength { get; set; }

    /// <summary>
    /// samples
    /// </summary>
    public ushort Samples { get; set; }

    /// <summary>
    /// data bytes
    /// </summary>
    public byte[] Data { get; set; } = new byte[0];

}

/// <summary>
/// Common PDU fields for Radio Communications family
/// </summary>
public partial class RadioCommsHeader
{
    /// <summary>
    /// ID of the entitythat is the source of the communication
    /// </summary>
    public EntityId RadioReferenceId { get; set; } = new EntityId();

    /// <summary>
    /// particular radio within an entity
    /// </summary>
    public ushort RadioNumber { get; set; }

}

/// <summary>
/// Abstract superclass for radio communications PDUs. Section 7.7
/// </summary>
public abstract partial class RadioCommunicationsFamilyPdu : PduBase
{
}

/// <summary>
/// 5.8.5 Communicates the state of a particular radio receiver. Its primary application is in communicating state information to radio network monitors, data loggers, and similar applications for use in debugging, supervision, and after-action review.
/// </summary>
public partial class ReceiverPdu : RadioCommunicationsFamilyPdu
{
    /// <summary>Creates a DIS v7 ReceiverPdu with its wire discriminator fields initialized.</summary>
    public ReceiverPdu() => Initialize(27, 4);

    public RadioCommsHeader RadioHeader { get; set; } = new RadioCommsHeader();

    /// <summary>
    /// encoding scheme used, and enumeration
    /// </summary>
    public ushort ReceiverState { get; set; }

    public ushort Padding1 { get; set; }

    /// <summary>
    /// received power
    /// </summary>
    public float ReceivedPower { get; set; }

    /// <summary>
    /// ID of transmitter
    /// </summary>
    public EntityId TransmitterEntityId { get; set; } = new EntityId();

    /// <summary>
    /// ID of transmitting radio
    /// </summary>
    public ushort TransmitterRadioId { get; set; }

}

/// <summary>
/// 5.8.4 Conveys the audio or digital data carried by the simulated radio or intercom transmission.
/// </summary>
public partial class SignalPdu : RadioCommunicationsFamilyPdu
{
    /// <summary>Creates a DIS v7 SignalPdu with its wire discriminator fields initialized.</summary>
    public SignalPdu() => Initialize(26, 4);

    public RadioCommsHeader RadioHeader { get; set; } = new RadioCommsHeader();

    /// <summary>
    /// encoding scheme used, and enumeration
    /// </summary>
    public ushort EncodingScheme { get; set; }

    /// <summary>
    /// tdl type
    /// </summary>
    public ushort TdlType { get; set; }

    /// <summary>
    /// sample rate
    /// </summary>
    public uint SampleRate { get; set; }

    /// <summary>
    /// meaningful length of data in bits; the final octet may contain padding bits
    /// </summary>
    public ushort DataBitLength { get; set; }

    /// <summary>
    /// number of samples
    /// </summary>
    public ushort Samples { get; set; }

    /// <summary>
    /// list of eight bit values
    /// </summary>
    public byte[] Data { get; set; } = new byte[0];

}

/// <summary>
/// 5.8.3 Communicates the state of a particular radio transmitter or simple intercom.
/// </summary>
public partial class TransmitterPdu : RadioCommunicationsFamilyPdu
{
    /// <summary>Creates a DIS v7 TransmitterPdu with its wire discriminator fields initialized.</summary>
    public TransmitterPdu() => Initialize(25, 4);

    public RadioCommsHeader RadioHeader { get; set; } = new RadioCommsHeader();

    /// <summary>
    /// Type of radio
    /// </summary>
    public RadioType RadioEntityType { get; set; } = new RadioType();

    /// <summary>
    /// transmit state
    /// </summary>
    public byte TransmitState { get; set; }

    /// <summary>
    /// input source
    /// </summary>
    public byte InputSource { get; set; }

    /// <summary>
    /// number of Variable Transmitter Parameter records
    /// </summary>
    internal ushort VariableTransmitterParameterCount { get; set; }

    /// <summary>
    /// Location of antenna
    /// </summary>
    public Vector3Double AntennaLocation { get; set; } = new Vector3Double();

    /// <summary>
    /// relative location of antenna
    /// </summary>
    public Vector3Float RelativeAntennaLocation { get; set; } = new Vector3Float();

    /// <summary>
    /// antenna pattern type
    /// </summary>
    public ushort AntennaPatternType { get; set; }

    /// <summary>
    /// antenna pattern length in octets
    /// </summary>
    internal ushort AntennaPatternCount { get; set; }

    /// <summary>
    /// frequency
    /// </summary>
    public ulong Frequency { get; set; }

    /// <summary>
    /// transmit frequency Bandwidth
    /// </summary>
    public float TransmitFrequencyBandwidth { get; set; }

    /// <summary>
    /// transmission power
    /// </summary>
    public float Power { get; set; }

    /// <summary>
    /// modulation
    /// </summary>
    public ModulationType ModulationType { get; set; } = new ModulationType();

    /// <summary>
    /// crypto system enumeration
    /// </summary>
    public ushort CryptoSystem { get; set; }

    /// <summary>
    /// crypto system key identifer
    /// </summary>
    public ushort CryptoKeyId { get; set; }

    /// <summary>
    /// length in octets of the modulation parameters field, including end padding
    /// </summary>
    internal byte ModulationParameterCount { get; set; }

    public byte Padding1 { get; set; }

    public ushort Padding2 { get; set; }

    /// <summary>
    /// radio-system-specific modulation parameters and end padding
    /// </summary>
    public byte[] ModulationParameters { get; set; } = [];

    /// <summary>
    /// antenna-pattern-specific parameters, including end padding
    /// </summary>
    public byte[] AntennaPatternParameters { get; set; } = [];

    /// <summary>
    /// DIS v7 variable transmitter parameter records
    /// </summary>
    public List<VariableTransmitterParameters> VariableTransmitterParameters { get; set; } = [];

}


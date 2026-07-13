// Derived from SISO-REF-010-2025 v36. Reprinted with permission from SISO Inc.
namespace OpenDisNet.Enumerations;

/// <summary>SISO-REF-010 v36 enumeration UID 69.</summary>
public enum AcknowledgeAcknowledgeFlag : ushort
{
    /// <summary>Create Entity</summary>
    CreateEntity = 1,
    /// <summary>Remove Entity</summary>
    RemoveEntity = 2,
    /// <summary>Start/Resume</summary>
    StartResume = 3,
    /// <summary>Stop/Freeze</summary>
    StopFreeze = 4,
    /// <summary>Transfer Ownership</summary>
    TransferOwnership = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 70.</summary>
public enum AcknowledgeResponseFlag : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Able to comply</summary>
    AbleToComply = 1,
    /// <summary>Unable to comply</summary>
    UnableToComply = 2,
    /// <summary>Pending Operator Action</summary>
    PendingOperatorAction = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 71.</summary>
public enum ActionRequestActionId : uint
{
    /// <summary>Other</summary>
    Other = 0u,
    /// <summary>Local storage of the requested information</summary>
    LocalStorageOfTheRequestedInformation = 1u,
    /// <summary>Inform SM of event "ran out of ammunition"</summary>
    InformSmOfEventRanOutOfAmmunition = 2u,
    /// <summary>Inform SM of event "killed in action"</summary>
    InformSmOfEventKilledInAction = 3u,
    /// <summary>Inform SM of event "damage"</summary>
    InformSmOfEventDamage = 4u,
    /// <summary>Inform SM of event "mobility disabled"</summary>
    InformSmOfEventMobilityDisabled = 5u,
    /// <summary>Inform SM of event "fire disabled"</summary>
    InformSmOfEventFireDisabled = 6u,
    /// <summary>Inform SM of event "ran out of fuel"</summary>
    InformSmOfEventRanOutOfFuel = 7u,
    /// <summary>Recall checkpoint data</summary>
    RecallCheckpointData = 8u,
    /// <summary>Recall initial parameters</summary>
    RecallInitialParameters = 9u,
    /// <summary>Initiate tether-lead</summary>
    InitiateTetherLead = 10u,
    /// <summary>Initiate tether-follow</summary>
    InitiateTetherFollow = 11u,
    /// <summary>Untether</summary>
    Untether = 12u,
    /// <summary>Initiate service station resupply</summary>
    InitiateServiceStationResupply = 13u,
    /// <summary>Initiate tailgate resupply</summary>
    InitiateTailgateResupply = 14u,
    /// <summary>Initiate hitch lead</summary>
    InitiateHitchLead = 15u,
    /// <summary>Initiate hitch follow</summary>
    InitiateHitchFollow = 16u,
    /// <summary>Unhitch</summary>
    Unhitch = 17u,
    /// <summary>Mount</summary>
    Mount = 18u,
    /// <summary>Dismount</summary>
    Dismount = 19u,
    /// <summary>Start DRC (Daily Readiness Check)</summary>
    StartDrcDailyReadinessCheck = 20u,
    /// <summary>Stop DRC</summary>
    StopDrc = 21u,
    /// <summary>Data Query</summary>
    DataQuery = 22u,
    /// <summary>Status Request</summary>
    StatusRequest = 23u,
    /// <summary>Send Object State Data</summary>
    SendObjectStateData = 24u,
    /// <summary>Reconstitute</summary>
    Reconstitute = 25u,
    /// <summary>Lock Site Configuration</summary>
    LockSiteConfiguration = 26u,
    /// <summary>Unlock Site Configuration</summary>
    UnlockSiteConfiguration = 27u,
    /// <summary>Update Site Configuration</summary>
    UpdateSiteConfiguration = 28u,
    /// <summary>Query Site Configuration</summary>
    QuerySiteConfiguration = 29u,
    /// <summary>Tethering Information</summary>
    TetheringInformation = 30u,
    /// <summary>Mount Intent</summary>
    MountIntent = 31u,
    /// <summary>Accept Subscription</summary>
    AcceptSubscription = 33u,
    /// <summary>Unsubscribe</summary>
    Unsubscribe = 34u,
    /// <summary>Teleport entity</summary>
    TeleportEntity = 35u,
    /// <summary>Change aggregate state</summary>
    ChangeAggregateState = 36u,
    /// <summary>Request Start PDU</summary>
    RequestStartPdu = 37u,
    /// <summary>Wakeup get ready for initialization</summary>
    WakeupGetReadyForInitialization = 38u,
    /// <summary>Initialize internal parameters</summary>
    InitializeInternalParameters = 39u,
    /// <summary>Send plan data</summary>
    SendPlanData = 40u,
    /// <summary>Synchronize internal clocks</summary>
    SynchronizeInternalClocks = 41u,
    /// <summary>Run</summary>
    Run = 42u,
    /// <summary>Save internal parameters</summary>
    SaveInternalParameters = 43u,
    /// <summary>Simulate malfunction</summary>
    SimulateMalfunction = 44u,
    /// <summary>Join exercise</summary>
    JoinExercise = 45u,
    /// <summary>Resign exercise</summary>
    ResignExercise = 46u,
    /// <summary>Time advance</summary>
    TimeAdvance = 47u,
    /// <summary>TACCSF LOS Request-Type 1</summary>
    TaccsfLosRequestType1 = 100u,
    /// <summary>TACCSF LOS Request-Type 2</summary>
    TaccsfLosRequestType2 = 101u,
    /// <summary>Airmount Mount Request</summary>
    AirmountMountRequest = 4303u,
    /// <summary>Airmount Dismount Request</summary>
    AirmountDismountRequest = 4304u,
    /// <summary>Airmount Information Request</summary>
    AirmountInformationRequest = 4305u,
}

/// <summary>SISO-REF-010 v36 enumeration UID 72.</summary>
public enum ActionResponseRequestStatus : uint
{
    /// <summary>Other</summary>
    Other = 0u,
    /// <summary>Pending</summary>
    Pending = 1u,
    /// <summary>Executing</summary>
    Executing = 2u,
    /// <summary>Partially Complete</summary>
    PartiallyComplete = 3u,
    /// <summary>Complete</summary>
    Complete = 4u,
    /// <summary>Request rejected</summary>
    RequestRejected = 5u,
    /// <summary>Retransmit request now</summary>
    RetransmitRequestNow = 6u,
    /// <summary>Retransmit request later</summary>
    RetransmitRequestLater = 7u,
    /// <summary>Invalid time parameters</summary>
    InvalidTimeParameters = 8u,
    /// <summary>Simulation time exceeded</summary>
    SimulationTimeExceeded = 9u,
    /// <summary>Request done</summary>
    RequestDone = 10u,
    /// <summary>TACCSF LOS Reply-Type 1</summary>
    TaccsfLosReplyType1 = 100u,
    /// <summary>TACCSF LOS Reply-Type 2</summary>
    TaccsfLosReplyType2 = 101u,
    /// <summary>Join Exercise Request Rejected</summary>
    JoinExerciseRequestRejected = 201u,
}

/// <summary>SISO-REF-010 v36 enumeration UID 206.</summary>
public enum AggregateStateAggregateKind : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Military Hierarchy</summary>
    MilitaryHierarchy = 1,
    /// <summary>Common Type</summary>
    CommonType = 2,
    /// <summary>Common Mission</summary>
    CommonMission = 3,
    /// <summary>Similar Capabilities</summary>
    SimilarCapabilities = 4,
    /// <summary>Common Location</summary>
    CommonLocation = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 204.</summary>
public enum AggregateStateAggregateState : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Aggregated</summary>
    Aggregated = 1,
    /// <summary>Disaggregated</summary>
    Disaggregated = 2,
    /// <summary>Fully disaggregated</summary>
    FullyDisaggregated = 3,
    /// <summary>Pseudo-disaggregated</summary>
    PseudoDisaggregated = 4,
    /// <summary>Partially-disaggregated</summary>
    PartiallyDisaggregated = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 205.</summary>
public enum AggregateStateFormation : uint
{
    /// <summary>Other</summary>
    Other = 0u,
    /// <summary>Assembly</summary>
    Assembly = 1u,
    /// <summary>Vee</summary>
    Vee = 2u,
    /// <summary>Wedge</summary>
    Wedge = 3u,
    /// <summary>Line</summary>
    Line = 4u,
    /// <summary>Column</summary>
    Column = 5u,
}

/// <summary>SISO-REF-010 v36 enumeration UID 209.</summary>
public enum AggregateStateSpecific : byte
{
    /// <summary>No headquarters</summary>
    NoHeadquarters = 0,
    /// <summary>Yes aggregate unit contains a headquarters</summary>
    YesAggregateUnitContainsAHeadquarters = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 208.</summary>
public enum AggregateStateSubcategory : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Cavalry Troop</summary>
    CavalryTroop = 1,
    /// <summary>Armor</summary>
    Armor = 2,
    /// <summary>Infantry</summary>
    Infantry = 3,
    /// <summary>Mechanized Infantry</summary>
    MechanizedInfantry = 4,
    /// <summary>Cavalry</summary>
    Cavalry = 5,
    /// <summary>Armored Cavalry</summary>
    ArmoredCavalry = 6,
    /// <summary>Artillery</summary>
    Artillery = 7,
    /// <summary>Self-Propelled Artillery</summary>
    SelfPropelledArtillery = 8,
    /// <summary>Close Air Support</summary>
    CloseAirSupport = 9,
    /// <summary>Engineer</summary>
    Engineer = 10,
    /// <summary>Air Defense Artillery</summary>
    AirDefenseArtillery = 11,
    /// <summary>Anti-Tank</summary>
    AntiTank = 12,
    /// <summary>Army Aviation Fixed-wing</summary>
    ArmyAviationFixedWing = 13,
    /// <summary>Army Aviation Rotary-wing</summary>
    ArmyAviationRotaryWing = 14,
    /// <summary>Army Attack Helicopter</summary>
    ArmyAttackHelicopter = 15,
    /// <summary>Air Cavalry</summary>
    AirCavalry = 16,
    /// <summary>Armor Heavy Task Force</summary>
    ArmorHeavyTaskForce = 17,
    /// <summary>Motorized Rifle</summary>
    MotorizedRifle = 18,
    /// <summary>Mechanized Heavy Task Force</summary>
    MechanizedHeavyTaskForce = 19,
    /// <summary>Command Post</summary>
    CommandPost = 20,
    /// <summary>CEWI</summary>
    Cewi = 21,
    /// <summary>Tank only</summary>
    TankOnly = 22,
}

/// <summary>SISO-REF-010 v36 enumeration UID 357.</summary>
public enum AircraftIdentificationType : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Flight Number</summary>
    FlightNumber = 1,
    /// <summary>Tail Number</summary>
    TailNumber = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 356.</summary>
public enum AircraftPresentDomain : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Airborne</summary>
    Airborne = 1,
    /// <summary>On Ground/Surface</summary>
    OnGroundSurface = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 415.</summary>
public enum AttachedPartDetachedIndicator : byte
{
    /// <summary>Attached</summary>
    Attached = 0,
    /// <summary>Detached</summary>
    Detached = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 57.</summary>
public enum AttachedParts : uint
{
    /// <summary>Nothing, Empty</summary>
    NothingEmpty = 0u,
    /// <summary>M16A42 rifle</summary>
    M16a42Rifle = 896u,
    /// <summary>M249 SAW</summary>
    M249Saw = 897u,
    /// <summary>M60 Machine gun</summary>
    M60MachineGun = 898u,
    /// <summary>M203 Grenade Launcher</summary>
    M203GrenadeLauncher = 899u,
    /// <summary>M136 AT4</summary>
    M136At4 = 900u,
    /// <summary>M47 Dragon</summary>
    M47Dragon = 901u,
    /// <summary>AAWS-M Javelin</summary>
    AawsMJavelin = 902u,
    /// <summary>M18A1 Claymore Mine</summary>
    M18a1ClaymoreMine = 903u,
    /// <summary>MK19 Grenade Launcher</summary>
    Mk19GrenadeLauncher = 904u,
    /// <summary>M2 Machine Gun</summary>
    M2MachineGun = 905u,
}

/// <summary>SISO-REF-010 v36 enumeration UID 318.</summary>
public enum BeamStatusBeamState : byte
{
    /// <summary>Active</summary>
    Active = 0,
    /// <summary>Deactivated</summary>
    Deactivated = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 358.</summary>
public enum CapabilityReport : byte
{
    /// <summary>No Communications Capability (CA)</summary>
    NoCommunicationsCapabilityCa = 0,
    /// <summary>Reserved</summary>
    Reserved = 1,
    /// <summary>Reserved</summary>
    Reserved2 = 2,
    /// <summary>Reserved</summary>
    Reserved3 = 3,
    /// <summary>Signifies at Least Comm-A and Comm-B Capability and Ability to Set CA Code 7 and on the Ground</summary>
    SignifiesAtLeastCommAAndCommBCapabilityAndAbilityToSetCaCode7AndOnTheGround = 4,
    /// <summary>Signifies at Least Comm-A and Comm-B capability and Ability to Set CA Code 7 and Airborne</summary>
    SignifiesAtLeastCommAAndCommBCapabilityAndAbilityToSetCaCode7AndAirborne = 5,
    /// <summary>Signifies at Least Comm-A and Comm-B capability and Ability to Set CA Code 7 and Either Airborne or on the Ground</summary>
    SignifiesAtLeastCommAAndCommBCapabilityAndAbilityToSetCaCode7AndEitherAirborneOrOnTheGround = 6,
    /// <summary>Signifies the Downlink Request (DR) Field Is Not Equal To 0 and The Flight Status (FS) Field Equals 2, 3, 4 or 5, and Either Airborne or on the Ground</summary>
    SignifiesTheDownlinkRequestDrFieldIsNotEqualTo0AndTheFlightStatusFsFieldEquals234Or5AndEitherAirborneOrOnTheGround = 7,
    /// <summary>No Statement</summary>
    NoStatement = 255,
}

/// <summary>SISO-REF-010 v36 enumeration UID 189.</summary>
public enum CollisionType : byte
{
    /// <summary>Inelastic</summary>
    Inelastic = 0,
    /// <summary>Elastic</summary>
    Elastic = 1,
    /// <summary>The boom nozzle is in physical contact with the receptacle and the booms signal system is operative.</summary>
    TheBoomNozzleIsInPhysicalContactWithTheReceptacleAndTheBoomsSignalSystemIsOperative = 2,
    /// <summary>The boom trainers signal system has sent a disconnect signal that should cause the receivers refueling receptacle to unlatch (unless there is a malfunction).</summary>
    TheBoomTrainersSignalSystemHasSentADisconnectSignalThatShouldCauseTheReceiversRefuelingReceptacleToUnlatchUnlessThereIsAMalfunction = 3,
    /// <summary>Disconnect without a signal being sent - disconnected by physical means (brute force disconnect, controlled tension disconnect).</summary>
    DisconnectWithoutASignalBeingSentDisconnectedByPhysicalMeansBruteForceDisconnectControlledTensionDisconnect = 4,
    /// <summary>The boom nozzle is in physical contact with the receptacle and the booms signal system is inoperative.</summary>
    TheBoomNozzleIsInPhysicalContactWithTheReceptacleAndTheBoomsSignalSystemIsInoperative = 5,
    /// <summary>Boom simulator has calculated that the receivers latches have been damaged.</summary>
    BoomSimulatorHasCalculatedThatTheReceiversLatchesHaveBeenDamaged = 6,
    /// <summary>AR receptacle door #1 damaged.</summary>
    ArReceptacleDoor1Damaged = 7,
    /// <summary>AR receptacle door #2 damaged.</summary>
    ArReceptacleDoor2Damaged = 8,
    /// <summary>Pilots Cockpit Windshield damaged</summary>
    PilotsCockpitWindshieldDamaged = 9,
    /// <summary>Copilots Cockpit Windshield damaged</summary>
    CopilotsCockpitWindshieldDamaged = 10,
    /// <summary>Pilots Left Side Window damaged</summary>
    PilotsLeftSideWindowDamaged = 11,
    /// <summary>Copilots Right Side Window damaged</summary>
    CopilotsRightSideWindowDamaged = 12,
    /// <summary>Pilots Eyebrow Window damaged</summary>
    PilotsEyebrowWindowDamaged = 13,
    /// <summary>Copilots Eyebrow Window damaged</summary>
    CopilotsEyebrowWindowDamaged = 14,
    /// <summary>MLS Glide Slope #1 Antenna damaged</summary>
    MlsGlideSlope1AntennaDamaged = 15,
    /// <summary>MLS Glide Slope #2 Antenna damaged</summary>
    MlsGlideSlope2AntennaDamaged = 16,
    /// <summary>ILS Glide #1 Slope Antenna damaged</summary>
    IlsGlide1SlopeAntennaDamaged = 17,
    /// <summary>ILS Glide #2 Slope Antenna damaged</summary>
    IlsGlide2SlopeAntennaDamaged = 18,
    /// <summary>SKE OMNI Antenna damaged</summary>
    SkeOmniAntennaDamaged = 19,
    /// <summary>SKE Directional Antenna damaged</summary>
    SkeDirectionalAntennaDamaged = 20,
    /// <summary>Weather Radar Antenna damaged</summary>
    WeatherRadarAntennaDamaged = 21,
    /// <summary>Com #1 ARC 210 Antenna damaged</summary>
    Com1Arc210AntennaDamaged = 22,
    /// <summary>TACAN Antenna damaged</summary>
    TacanAntennaDamaged = 23,
    /// <summary>MLS Antenna damaged</summary>
    MlsAntennaDamaged = 24,
    /// <summary>AF SATCOM Antenna damaged</summary>
    AfSatcomAntennaDamaged = 25,
    /// <summary>AERO-I SATCOM Antenna damaged</summary>
    AeroISatcomAntennaDamaged = 26,
    /// <summary>AERO-H SATCOM Antenna damaged</summary>
    AeroHSatcomAntennaDamaged = 28,
    /// <summary>UHF SATCOM Antenna damaged</summary>
    UhfSatcomAntennaDamaged = 29,
    /// <summary>HMSA Antenna damaged</summary>
    HmsaAntennaDamaged = 30,
    /// <summary>IFF Antenna damaged</summary>
    IffAntennaDamaged = 31,
    /// <summary>Left Side Landing/Taxi Light damaged</summary>
    LeftSideLandingTaxiLightDamaged = 32,
    /// <summary>Right Side Landing/Taxi Light damaged</summary>
    RightSideLandingTaxiLightDamaged = 33,
    /// <summary>Left Side Runway Turnoff Light damaged</summary>
    LeftSideRunwayTurnoffLightDamaged = 34,
    /// <summary>Right Side Runway Turnoff Light damaged</summary>
    RightSideRunwayTurnoffLightDamaged = 35,
    /// <summary>Left Side Formation Light damaged</summary>
    LeftSideFormationLightDamaged = 36,
    /// <summary>Right Side Formation Light damaged</summary>
    RightSideFormationLightDamaged = 37,
    /// <summary>Left Side Nacelle Scanning Light damaged</summary>
    LeftSideNacelleScanningLightDamaged = 38,
    /// <summary>Right Side Nacelle Scanning Light damaged</summary>
    RightSideNacelleScanningLightDamaged = 39,
    /// <summary>Copilot Pitot Static Probe #1 damaged</summary>
    CopilotPitotStaticProbe1Damaged = 40,
    /// <summary>Copilot Pitot Static Probe #2 damaged</summary>
    CopilotPitotStaticProbe2Damaged = 41,
    /// <summary>Pilot Pitot Static Probe #1 damaged</summary>
    PilotPitotStaticProbe1Damaged = 42,
    /// <summary>Pilot Pitot Static Probe #2 damaged</summary>
    PilotPitotStaticProbe2Damaged = 43,
    /// <summary>Total Air Temperature Probe #1 damaged</summary>
    TotalAirTemperatureProbe1Damaged = 44,
    /// <summary>Total Air Temperature Probe #2 damaged</summary>
    TotalAirTemperatureProbe2Damaged = 45,
    /// <summary>Angle of Attack Sensor #1 damaged</summary>
    AngleOfAttackSensor1Damaged = 46,
    /// <summary>Angle of Attack Sensor #2 damaged</summary>
    AngleOfAttackSensor2Damaged = 47,
    /// <summary>Angle of Attack Sensor #3 damaged</summary>
    AngleOfAttackSensor3Damaged = 48,
    /// <summary>Angle of Attack Sensor #4 damaged</summary>
    AngleOfAttackSensor4Damaged = 49,
    /// <summary>Angle of Attack Sensor #5 damaged</summary>
    AngleOfAttackSensor5Damaged = 50,
    /// <summary>Angle of Attack Sensor #6 damaged</summary>
    AngleOfAttackSensor6Damaged = 51,
    /// <summary>Left Side Spoiler damaged</summary>
    LeftSideSpoilerDamaged = 52,
    /// <summary>Right Side Spoiler damaged</summary>
    RightSideSpoilerDamaged = 53,
    /// <summary>Upper TCAS antenna (KC-135 R/T) damaged</summary>
    UpperTcasAntennaKc135RTDamaged = 54,
    /// <summary>Boom nozzle has cleared the receiver's refueling receptacle</summary>
    BoomNozzleHasClearedTheReceiverSRefuelingReceptacle = 55,
}

/// <summary>SISO-REF-010 v36 enumeration UID 29.</summary>
public enum Country : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Afghanistan (AFG)</summary>
    AfghanistanAfg = 1,
    /// <summary>Albania (ALB)</summary>
    AlbaniaAlb = 2,
    /// <summary>Algeria (DZA)</summary>
    AlgeriaDza = 3,
    /// <summary>American Samoa (ASM)</summary>
    AmericanSamoaAsm = 4,
    /// <summary>Andorra (AND)</summary>
    AndorraAnd = 5,
    /// <summary>Angola (AGO)</summary>
    AngolaAgo = 6,
    /// <summary>Anguilla (AIA)</summary>
    AnguillaAia = 7,
    /// <summary>Antarctica (ATA)</summary>
    AntarcticaAta = 8,
    /// <summary>Antigua and Barbuda (ATG)</summary>
    AntiguaAndBarbudaAtg = 9,
    /// <summary>Argentina (ARG)</summary>
    ArgentinaArg = 10,
    /// <summary>Aruba (ABW)</summary>
    ArubaAbw = 11,
    /// <summary>Ashmore and Cartier Islands (Australia)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    AshmoreAndCartierIslandsAustralia = 12,
    /// <summary>Australia (AUS)</summary>
    AustraliaAus = 13,
    /// <summary>Austria (AUT)</summary>
    AustriaAut = 14,
    /// <summary>Bahamas (BHS)</summary>
    BahamasBhs = 15,
    /// <summary>Bahrain (BHR)</summary>
    BahrainBhr = 16,
    /// <summary>Baker Island (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    BakerIslandUnitedStates = 17,
    /// <summary>Bangladesh (BGD)</summary>
    BangladeshBgd = 18,
    /// <summary>Barbados (BRB)</summary>
    BarbadosBrb = 19,
    /// <summary>Bassas da India (France)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    BassasDaIndiaFrance = 20,
    /// <summary>Belgium (BEL)</summary>
    BelgiumBel = 21,
    /// <summary>Belize (BLZ)</summary>
    BelizeBlz = 22,
    /// <summary>Benin (BEN)</summary>
    BeninBen = 23,
    /// <summary>Bermuda (BMU)</summary>
    BermudaBmu = 24,
    /// <summary>Bhutan (BTN)</summary>
    BhutanBtn = 25,
    /// <summary>Bolivia (Plurinational State of) (BOL)</summary>
    BoliviaPlurinationalStateOfBol = 26,
    /// <summary>Botswana (BWA)</summary>
    BotswanaBwa = 27,
    /// <summary>Bouvet Island (BVT)</summary>
    BouvetIslandBvt = 28,
    /// <summary>Brazil (BRA)</summary>
    BrazilBra = 29,
    /// <summary>British Indian Ocean Territory (IOT)</summary>
    BritishIndianOceanTerritoryIot = 30,
    /// <summary>Virgin Islands (British) (VGB)</summary>
    VirginIslandsBritishVgb = 31,
    /// <summary>Brunei Darussalam (BRN)</summary>
    BruneiDarussalamBrn = 32,
    /// <summary>Bulgaria (BGR)</summary>
    BulgariaBgr = 33,
    /// <summary>Burkina Faso (BFA)</summary>
    BurkinaFasoBfa = 34,
    /// <summary>Myanmar (MMR)</summary>
    MyanmarMmr = 35,
    /// <summary>Burundi (BDI)</summary>
    BurundiBdi = 36,
    /// <summary>Cambodia (KHM)</summary>
    CambodiaKhm = 37,
    /// <summary>Cameroon (CMR)</summary>
    CameroonCmr = 38,
    /// <summary>Canada (CAN)</summary>
    CanadaCan = 39,
    /// <summary>Cabo Verde (CPV)</summary>
    CaboVerdeCpv = 40,
    /// <summary>Cayman Islands (CYM)</summary>
    CaymanIslandsCym = 41,
    /// <summary>Central African Republic (CAF)</summary>
    CentralAfricanRepublicCaf = 42,
    /// <summary>Chad (TCD)</summary>
    ChadTcd = 43,
    /// <summary>Chile (CHL)</summary>
    ChileChl = 44,
    /// <summary>China, People's Republic of (CHN)</summary>
    ChinaPeopleSRepublicOfChn = 45,
    /// <summary>Christmas Island (CXR)</summary>
    ChristmasIslandCxr = 46,
    /// <summary>Cocos (Keeling) Islands (CCK)</summary>
    CocosKeelingIslandsCck = 47,
    /// <summary>Colombia (COL)</summary>
    ColombiaCol = 48,
    /// <summary>Comoros (COM)</summary>
    ComorosCom = 49,
    /// <summary>Congo (COG)</summary>
    CongoCog = 50,
    /// <summary>Cook Islands (COK)</summary>
    CookIslandsCok = 51,
    /// <summary>Coral Sea Islands (Australia)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    CoralSeaIslandsAustralia = 52,
    /// <summary>Costa Rica (CRI)</summary>
    CostaRicaCri = 53,
    /// <summary>Cuba (CUB)</summary>
    CubaCub = 54,
    /// <summary>Cyprus (CYP)</summary>
    CyprusCyp = 55,
    /// <summary>Czechoslovakia (CSK)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    CzechoslovakiaCsk = 56,
    /// <summary>Denmark (DNK)</summary>
    DenmarkDnk = 57,
    /// <summary>Djibouti (DJI)</summary>
    DjiboutiDji = 58,
    /// <summary>Dominica (DMA)</summary>
    DominicaDma = 59,
    /// <summary>Dominican Republic (DOM)</summary>
    DominicanRepublicDom = 60,
    /// <summary>Ecuador (ECU)</summary>
    EcuadorEcu = 61,
    /// <summary>Egypt (EGY)</summary>
    EgyptEgy = 62,
    /// <summary>El Salvador (SLV)</summary>
    ElSalvadorSlv = 63,
    /// <summary>Equatorial Guinea (GNQ)</summary>
    EquatorialGuineaGnq = 64,
    /// <summary>Ethiopia (ETH)</summary>
    EthiopiaEth = 65,
    /// <summary>Europa Island (France)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    EuropaIslandFrance = 66,
    /// <summary>Falkland Islands (Malvinas) (FLK)</summary>
    FalklandIslandsMalvinasFlk = 67,
    /// <summary>Faroe Islands (FRO)</summary>
    FaroeIslandsFro = 68,
    /// <summary>Fiji (FJI)</summary>
    FijiFji = 69,
    /// <summary>Finland (FIN)</summary>
    FinlandFin = 70,
    /// <summary>France (FRA)</summary>
    FranceFra = 71,
    /// <summary>French Guiana (GUF)</summary>
    FrenchGuianaGuf = 72,
    /// <summary>French Polynesia (PYF)</summary>
    FrenchPolynesiaPyf = 73,
    /// <summary>French Southern Territories (ATF)</summary>
    FrenchSouthernTerritoriesAtf = 74,
    /// <summary>Gabon (GAB)</summary>
    GabonGab = 75,
    /// <summary>Gambia, The (GMB)</summary>
    GambiaTheGmb = 76,
    /// <summary>Gaza Strip (Israel)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    GazaStripIsrael = 77,
    /// <summary>Germany (DEU)</summary>
    GermanyDeu = 78,
    /// <summary>Ghana (GHA)</summary>
    GhanaGha = 79,
    /// <summary>Gibraltar (GIB)</summary>
    GibraltarGib = 80,
    /// <summary>Glorioso Islands (France)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    GloriosoIslandsFrance = 81,
    /// <summary>Greece (GRC)</summary>
    GreeceGrc = 82,
    /// <summary>Greenland (GRL)</summary>
    GreenlandGrl = 83,
    /// <summary>Grenada (GRD)</summary>
    GrenadaGrd = 84,
    /// <summary>Guadeloupe (GLP)</summary>
    GuadeloupeGlp = 85,
    /// <summary>Guam (GUM)</summary>
    GuamGum = 86,
    /// <summary>Guatemala (GTM)</summary>
    GuatemalaGtm = 87,
    /// <summary>Guernsey (GGY)</summary>
    GuernseyGgy = 88,
    /// <summary>Guinea (GIN)</summary>
    GuineaGin = 89,
    /// <summary>Guinea-Bissau (GNB)</summary>
    GuineaBissauGnb = 90,
    /// <summary>Guyana (GUY)</summary>
    GuyanaGuy = 91,
    /// <summary>Haiti (HTI)</summary>
    HaitiHti = 92,
    /// <summary>Heard Island and McDonald Islands (HMD)</summary>
    HeardIslandAndMcDonaldIslandsHmd = 93,
    /// <summary>Honduras (HND)</summary>
    HondurasHnd = 94,
    /// <summary>Hong Kong (HKG)</summary>
    HongKongHkg = 95,
    /// <summary>Howland Island (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    HowlandIslandUnitedStates = 96,
    /// <summary>Hungary (HUN)</summary>
    HungaryHun = 97,
    /// <summary>Iceland (ISL)</summary>
    IcelandIsl = 98,
    /// <summary>India (IND)</summary>
    IndiaInd = 99,
    /// <summary>Indonesia (IDN)</summary>
    IndonesiaIdn = 100,
    /// <summary>Iran (Islamic Republic of) (IRN)</summary>
    IranIslamicRepublicOfIrn = 101,
    /// <summary>Iraq (IRQ)</summary>
    IraqIrq = 102,
    /// <summary>Ireland (IRL)</summary>
    IrelandIrl = 104,
    /// <summary>Israel (ISR)</summary>
    IsraelIsr = 105,
    /// <summary>Italy (ITA)</summary>
    ItalyIta = 106,
    /// <summary>Cote d'Ivoire (CIV)</summary>
    CoteDIvoireCiv = 107,
    /// <summary>Jamaica (JAM)</summary>
    JamaicaJam = 108,
    /// <summary>Jan Mayen (Norway)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    JanMayenNorway = 109,
    /// <summary>Japan (JPN)</summary>
    JapanJpn = 110,
    /// <summary>Jarvis Island (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    JarvisIslandUnitedStates = 111,
    /// <summary>Jersey (JEY)</summary>
    JerseyJey = 112,
    /// <summary>Johnston Atoll (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    JohnstonAtollUnitedStates = 113,
    /// <summary>Jordan (JOR)</summary>
    JordanJor = 114,
    /// <summary>Juan de Nova Island</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    JuanDeNovaIsland = 115,
    /// <summary>Kenya (KEN)</summary>
    KenyaKen = 116,
    /// <summary>Kingman Reef (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    KingmanReefUnitedStates = 117,
    /// <summary>Kiribati (KIR)</summary>
    KiribatiKir = 118,
    /// <summary>Korea (Democratic People's Republic of) (PRK)</summary>
    KoreaDemocraticPeopleSRepublicOfPrk = 119,
    /// <summary>Korea (Republic of) (KOR)</summary>
    KoreaRepublicOfKor = 120,
    /// <summary>Kuwait (KWT)</summary>
    KuwaitKwt = 121,
    /// <summary>Lao People's Democratic Republic (LAO)</summary>
    LaoPeopleSDemocraticRepublicLao = 122,
    /// <summary>Lebanon (LBN)</summary>
    LebanonLbn = 123,
    /// <summary>Lesotho (LSO)</summary>
    LesothoLso = 124,
    /// <summary>Liberia (LBR)</summary>
    LiberiaLbr = 125,
    /// <summary>Libya (LBY)</summary>
    LibyaLby = 126,
    /// <summary>Liechtenstein (LIE)</summary>
    LiechtensteinLie = 127,
    /// <summary>Luxembourg (LUX)</summary>
    LuxembourgLux = 128,
    /// <summary>Madagascar (MDG)</summary>
    MadagascarMdg = 129,
    /// <summary>Macao (MAC)</summary>
    MacaoMac = 130,
    /// <summary>Malawi (MWI)</summary>
    MalawiMwi = 131,
    /// <summary>Malaysia (MYS)</summary>
    MalaysiaMys = 132,
    /// <summary>Maldives (MDV)</summary>
    MaldivesMdv = 133,
    /// <summary>Mali (MLI)</summary>
    MaliMli = 134,
    /// <summary>Malta (MLT)</summary>
    MaltaMlt = 135,
    /// <summary>Isle of Man (IMN)</summary>
    IsleOfManImn = 136,
    /// <summary>Marshall Islands (MHL)</summary>
    MarshallIslandsMhl = 137,
    /// <summary>Martinique (MTQ)</summary>
    MartiniqueMtq = 138,
    /// <summary>Mauritania (MRT)</summary>
    MauritaniaMrt = 139,
    /// <summary>Mauritius (MUS)</summary>
    MauritiusMus = 140,
    /// <summary>Mayotte (MYT)</summary>
    MayotteMyt = 141,
    /// <summary>Mexico (MEX)</summary>
    MexicoMex = 142,
    /// <summary>Micronesia (Federated States of) (FSM)</summary>
    MicronesiaFederatedStatesOfFsm = 143,
    /// <summary>Monaco (MCO)</summary>
    MonacoMco = 144,
    /// <summary>Mongolia (MNG)</summary>
    MongoliaMng = 145,
    /// <summary>Montserrat (MSR)</summary>
    MontserratMsr = 146,
    /// <summary>Morocco (MAR)</summary>
    MoroccoMar = 147,
    /// <summary>Mozambique (MOZ)</summary>
    MozambiqueMoz = 148,
    /// <summary>Namibia (NAM)</summary>
    NamibiaNam = 149,
    /// <summary>Nauru (NRU)</summary>
    NauruNru = 150,
    /// <summary>Navassa Island (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    NavassaIslandUnitedStates = 151,
    /// <summary>Nepal (NPL)</summary>
    NepalNpl = 152,
    /// <summary>Netherlands (NLD)</summary>
    NetherlandsNld = 153,
    /// <summary>Netherlands Antilles (Curacao, Bonaire, Saba, Sint Maarten Sint Eustatius)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    NetherlandsAntillesCuracaoBonaireSabaSintMaartenSintEustatius = 154,
    /// <summary>New Caledonia (NCL)</summary>
    NewCaledoniaNcl = 155,
    /// <summary>New Zealand (NZL)</summary>
    NewZealandNzl = 156,
    /// <summary>Nicaragua (NIC)</summary>
    NicaraguaNic = 157,
    /// <summary>Niger (NER)</summary>
    NigerNer = 158,
    /// <summary>Nigeria (NGA)</summary>
    NigeriaNga = 159,
    /// <summary>Niue (NIU)</summary>
    NiueNiu = 160,
    /// <summary>Norfolk Island (NFK)</summary>
    NorfolkIslandNfk = 161,
    /// <summary>Northern Mariana Islands (MNP)</summary>
    NorthernMarianaIslandsMnp = 162,
    /// <summary>Norway (NOR)</summary>
    NorwayNor = 163,
    /// <summary>Oman (OMN)</summary>
    OmanOmn = 164,
    /// <summary>Pakistan (PAK)</summary>
    PakistanPak = 165,
    /// <summary>Palmyra Atoll (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    PalmyraAtollUnitedStates = 166,
    /// <summary>Panama (PAN)</summary>
    PanamaPan = 168,
    /// <summary>Papua New Guinea (PNG)</summary>
    PapuaNewGuineaPng = 169,
    /// <summary>Paracel Islands (International - Occupied by China, also claimed by Taiwan and Vietnam)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    ParacelIslandsInternationalOccupiedByChinaAlsoClaimedByTaiwanAndVietnam = 170,
    /// <summary>Paraguay (PRY)</summary>
    ParaguayPry = 171,
    /// <summary>Peru (PER)</summary>
    PeruPer = 172,
    /// <summary>Philippines (PHL)</summary>
    PhilippinesPhl = 173,
    /// <summary>Pitcairn (PCN)</summary>
    PitcairnPcn = 174,
    /// <summary>Poland (POL)</summary>
    PolandPol = 175,
    /// <summary>Portugal (PRT)</summary>
    PortugalPrt = 176,
    /// <summary>Puerto Rico (PRI)</summary>
    PuertoRicoPri = 177,
    /// <summary>Qatar (QAT)</summary>
    QatarQat = 178,
    /// <summary>Reunion (REU)</summary>
    ReunionReu = 179,
    /// <summary>Romania (ROU)</summary>
    RomaniaRou = 180,
    /// <summary>Rwanda (RWA)</summary>
    RwandaRwa = 181,
    /// <summary>Saint Kitts and Nevis (KNA)</summary>
    SaintKittsAndNevisKna = 182,
    /// <summary>Saint Helena, Ascension and Tristan da Cunha (SHN)</summary>
    SaintHelenaAscensionAndTristanDaCunhaShn = 183,
    /// <summary>Saint Lucia (LCA)</summary>
    SaintLuciaLca = 184,
    /// <summary>Saint Pierre and Miquelon (SPM)</summary>
    SaintPierreAndMiquelonSpm = 185,
    /// <summary>Saint Vincent and the Grenadines (VCT)</summary>
    SaintVincentAndTheGrenadinesVct = 186,
    /// <summary>San Marino (SMR)</summary>
    SanMarinoSmr = 187,
    /// <summary>Sao Tome and Principe (STP)</summary>
    SaoTomeAndPrincipeStp = 188,
    /// <summary>Saudi Arabia (SAU)</summary>
    SaudiArabiaSau = 189,
    /// <summary>Senegal (SEN)</summary>
    SenegalSen = 190,
    /// <summary>Seychelles (SYC)</summary>
    SeychellesSyc = 191,
    /// <summary>Sierra Leone (SLE)</summary>
    SierraLeoneSle = 192,
    /// <summary>Singapore (SGP)</summary>
    SingaporeSgp = 193,
    /// <summary>Solomon Islands (SLB)</summary>
    SolomonIslandsSlb = 194,
    /// <summary>Somalia (SOM)</summary>
    SomaliaSom = 195,
    /// <summary>South Georgia and the South Sandwich Islands (SGS)</summary>
    SouthGeorgiaAndTheSouthSandwichIslandsSgs = 196,
    /// <summary>South Africa (ZAF)</summary>
    SouthAfricaZaf = 197,
    /// <summary>Spain (ESP)</summary>
    SpainEsp = 198,
    /// <summary>Spratly Islands (International - parts occupied and claimed by China,Malaysia, Philippines, Taiwan, Vietnam)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SpratlyIslandsInternationalPartsOccupiedAndClaimedByChinaMalaysiaPhilippinesTaiwanVietnam = 199,
    /// <summary>Sri Lanka (LKA)</summary>
    SriLankaLka = 200,
    /// <summary>Sudan (SDN)</summary>
    SudanSdn = 201,
    /// <summary>Suriname (SUR)</summary>
    SurinameSur = 202,
    /// <summary>Svalbard (Norway)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SvalbardNorway = 203,
    /// <summary>Eswatini (SWZ)</summary>
    EswatiniSwz = 204,
    /// <summary>Sweden (SWE)</summary>
    SwedenSwe = 205,
    /// <summary>Switzerland (CHE)</summary>
    SwitzerlandChe = 206,
    /// <summary>Syrian Arab Republic (SYR)</summary>
    SyrianArabRepublicSyr = 207,
    /// <summary>Taiwan, Province of China (TWN)</summary>
    TaiwanProvinceOfChinaTwn = 208,
    /// <summary>Tanzania, United Republic of (TZA)</summary>
    TanzaniaUnitedRepublicOfTza = 209,
    /// <summary>Thailand (THA)</summary>
    ThailandTha = 210,
    /// <summary>Togo (TGO)</summary>
    TogoTgo = 211,
    /// <summary>Tokelau (TKL)</summary>
    TokelauTkl = 212,
    /// <summary>Tonga (TON)</summary>
    TongaTon = 213,
    /// <summary>Trinidad and Tobago (TTO)</summary>
    TrinidadAndTobagoTto = 214,
    /// <summary>Tromelin Island (France)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    TromelinIslandFrance = 215,
    /// <summary>Palau (PLW)</summary>
    PalauPlw = 216,
    /// <summary>Tunisia (TUN)</summary>
    TunisiaTun = 217,
    /// <summary>Turkiye (Republic of) (TUR)</summary>
    TurkiyeRepublicOfTur = 218,
    /// <summary>Turks and Caicos Islands (TCA)</summary>
    TurksAndCaicosIslandsTca = 219,
    /// <summary>Tuvalu (TUV)</summary>
    TuvaluTuv = 220,
    /// <summary>Uganda (UGA)</summary>
    UgandaUga = 221,
    /// <summary>Russia (RUS)</summary>
    RussiaRus = 222,
    /// <summary>United Arab Emirates (ARE)</summary>
    UnitedArabEmiratesAre = 223,
    /// <summary>United Kingdom of Great Britain and Northern Ireland (GBR)</summary>
    UnitedKingdomOfGreatBritainAndNorthernIrelandGbr = 224,
    /// <summary>United States of America (USA)</summary>
    UnitedStatesOfAmericaUsa = 225,
    /// <summary>Uruguay (URY)</summary>
    UruguayUry = 226,
    /// <summary>Vanuatu (VUT)</summary>
    VanuatuVut = 227,
    /// <summary>Holy See (VAT)</summary>
    HolySeeVat = 228,
    /// <summary>Venezuela (Bolivarian Republic of) (VEN)</summary>
    VenezuelaBolivarianRepublicOfVen = 229,
    /// <summary>Viet Nam (VNM)</summary>
    VietNamVnm = 230,
    /// <summary>Virgin Islands (U.S.) (VIR)</summary>
    VirginIslandsUSVir = 231,
    /// <summary>Wake Island (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    WakeIslandUnitedStates = 232,
    /// <summary>Wallis and Futuna (WLF)</summary>
    WallisAndFutunaWlf = 233,
    /// <summary>Western Sahara (ESH)</summary>
    WesternSaharaEsh = 234,
    /// <summary>West Bank (Israel)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    WestBankIsrael = 235,
    /// <summary>Samoa (WSM)</summary>
    SamoaWsm = 236,
    /// <summary>Yemen (YEM)</summary>
    YemenYem = 237,
    /// <summary>Serbia and Montenegro</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SerbiaAndMontenegro = 240,
    /// <summary>Zaire</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Zaire = 241,
    /// <summary>Zambia (ZMB)</summary>
    ZambiaZmb = 242,
    /// <summary>Zimbabwe (ZWE)</summary>
    ZimbabweZwe = 243,
    /// <summary>Armenia (ARM)</summary>
    ArmeniaArm = 244,
    /// <summary>Azerbaijan (AZE)</summary>
    AzerbaijanAze = 245,
    /// <summary>Belarus (BLR)</summary>
    BelarusBlr = 246,
    /// <summary>Bosnia and Herzegovina (BIH)</summary>
    BosniaAndHerzegovinaBih = 247,
    /// <summary>Clipperton Island (France)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    ClippertonIslandFrance = 248,
    /// <summary>Croatia (HRV)</summary>
    CroatiaHrv = 249,
    /// <summary>Estonia (EST)</summary>
    EstoniaEst = 250,
    /// <summary>Georgia (GEO)</summary>
    GeorgiaGeo = 251,
    /// <summary>Kazakhstan (KAZ)</summary>
    KazakhstanKaz = 252,
    /// <summary>Kyrgyzstan (KGZ)</summary>
    KyrgyzstanKgz = 253,
    /// <summary>Latvia (LVA)</summary>
    LatviaLva = 254,
    /// <summary>Lithuania (LTU)</summary>
    LithuaniaLtu = 255,
    /// <summary>North Macedonia (MKD)</summary>
    NorthMacedoniaMkd = 256,
    /// <summary>Midway Islands (United States)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    MidwayIslandsUnitedStates = 257,
    /// <summary>Moldova (Republic of) (MDA)</summary>
    MoldovaRepublicOfMda = 258,
    /// <summary>Montenegro (MNE)</summary>
    MontenegroMne = 259,
    /// <summary>Russia</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Russia = 260,
    /// <summary>Serbia and Montenegro (Montenegro to separate)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SerbiaAndMontenegroMontenegroToSeparate = 261,
    /// <summary>Slovenia (SVN)</summary>
    SloveniaSvn = 262,
    /// <summary>Tajikistan (TJK)</summary>
    TajikistanTjk = 263,
    /// <summary>Turkmenistan (TKM)</summary>
    TurkmenistanTkm = 264,
    /// <summary>Ukraine (UKR)</summary>
    UkraineUkr = 265,
    /// <summary>Uzbekistan (UZB)</summary>
    UzbekistanUzb = 266,
    /// <summary>Czech Republic (CZE)</summary>
    CzechRepublicCze = 267,
    /// <summary>Slovakia (SVK)</summary>
    SlovakiaSvk = 268,
    /// <summary>Aaland Islands (ALA)</summary>
    AalandIslandsAla = 269,
    /// <summary>Bonaire, Sint Eustatius and Saba (BES)</summary>
    BonaireSintEustatiusAndSabaBes = 270,
    /// <summary>Congo (Democratic Republic of the) (COD)</summary>
    CongoDemocraticRepublicOfTheCod = 271,
    /// <summary>Curacao (CUW)</summary>
    CuracaoCuw = 272,
    /// <summary>Eritrea (ERI)</summary>
    EritreaEri = 273,
    /// <summary>Saint Barthelemy (BLM)</summary>
    SaintBarthelemyBlm = 274,
    /// <summary>Saint Martin (French Part) (MAF)</summary>
    SaintMartinFrenchPartMaf = 275,
    /// <summary>Serbia (SRB)</summary>
    SerbiaSrb = 276,
    /// <summary>Sint Maarten (Dutch part) (SXM)</summary>
    SintMaartenDutchPartSxm = 277,
    /// <summary>South Sudan (SSD)</summary>
    SouthSudanSsd = 278,
    /// <summary>Svalbard and Jan Mayen (SJM)</summary>
    SvalbardAndJanMayenSjm = 279,
    /// <summary>Timor-Leste (TLS)</summary>
    TimorLesteTls = 280,
    /// <summary>United States Minor Outlying Islands (UMI)</summary>
    UnitedStatesMinorOutlyingIslandsUmi = 281,
    /// <summary>Palestine, State of (PSE)</summary>
    PalestineStateOfPse = 282,
}

/// <summary>SISO-REF-010 v36 enumeration UID 315.</summary>
public enum DeDamageDescriptionComponentDamageStatus : byte
{
    /// <summary>No Damage</summary>
    NoDamage = 0,
    /// <summary>Minor Damage</summary>
    MinorDamage = 1,
    /// <summary>Medium Damage</summary>
    MediumDamage = 2,
    /// <summary>Major Damage</summary>
    MajorDamage = 3,
    /// <summary>Destroyed</summary>
    Destroyed = 4,
}

/// <summary>SISO-REF-010 v36 bitfield UID 317. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct DeDamageDescriptionComponentVisualDamageStatus(byte Value)
{
    public static DeDamageDescriptionComponentVisualDamageStatus None => new(0);

    /// <summary>Describes presence of fire at the damage site</summary>
    public bool IsFirePresent => (Value & 1) != 0;
    public DeDamageDescriptionComponentVisualDamageStatus WithIsFirePresent(bool value) => new((byte)(value ? Value | 1 : Value & ~1));

    /// <summary>Describes presence of smoke emanating from the damage site</summary>
    public byte Smoke => (byte)((Value >> 1) & 3);
    public DeDamageDescriptionComponentVisualDamageStatus WithSmoke(byte value)
    {
        if (value > 3) throw new ArgumentOutOfRangeException(nameof(value));
        return new((byte)((Value & ~6) | ((byte)(value << 1) & 6)));
    }

    /// <summary>Describes general surface appearance at the damage site</summary>
    public byte SurfaceDamage => (byte)((Value >> 3) & 3);
    public DeDamageDescriptionComponentVisualDamageStatus WithSurfaceDamage(byte value)
    {
        if (value > 3) throw new ArgumentOutOfRangeException(nameof(value));
        return new((byte)((Value & ~24) | ((byte)(value << 3) & 24)));
    }

    public static implicit operator DeDamageDescriptionComponentVisualDamageStatus(byte value) => new(value);
    public static implicit operator byte(DeDamageDescriptionComponentVisualDamageStatus value) => value.Value;
    public override string ToString() => $"0x{Value:X2}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 316.</summary>
public enum DeDamageDescriptionComponentVisualSmokeColor : byte
{
    /// <summary>No Smoke</summary>
    NoSmoke = 0,
    /// <summary>White</summary>
    White = 1,
    /// <summary>Gray</summary>
    Gray = 2,
    /// <summary>Black</summary>
    Black = 3,
}

/// <summary>SISO-REF-010 v36 bitfield UID 313. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct DeFireFlags(ushort Value)
{
    public static DeFireFlags None => new(0);

    /// <summary>Identifies the State of the DE Weapon</summary>
    public bool WeaponOn => (Value & 1) != 0;
    public DeFireFlags WithWeaponOn(bool value) => new((ushort)(value ? Value | 1 : Value & ~1));

    /// <summary>Identifies a DE Weapon State Change</summary>
    public bool StateUpdateFlag => (Value & 2) != 0;
    public DeFireFlags WithStateUpdateFlag(bool value) => new((ushort)(value ? Value | 2 : Value & ~2));

    public static implicit operator DeFireFlags(ushort value) => new(value);
    public static implicit operator ushort(DeFireFlags value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 312.</summary>
public enum DeFirePulseShape : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Square Wave</summary>
    SquareWave = 1,
    /// <summary>Continuous Wave</summary>
    ContinuousWave = 2,
    /// <summary>Gaussian</summary>
    Gaussian = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 311.</summary>
public enum DePrecisionAimpointBeamSpotType : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Gaussian</summary>
    Gaussian = 1,
    /// <summary>Top Hat</summary>
    TopHat = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 295.</summary>
public enum DisAttributeActionCode : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 369.</summary>
public enum DataCategory : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Functional Data</summary>
    FunctionalData = 1,
    /// <summary>Transponder/Interrogator Data Link Messages</summary>
    TransponderInterrogatorDataLinkMessages = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 44.</summary>
public enum DeadReckoningAlgorithm : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Static - Non-moving Entity</summary>
    StaticNonMovingEntity = 1,
    /// <summary>DRM (FPW) - Constant Velocity / Low Acceleration Linear Motion Entity</summary>
    DrmFpwConstantVelocityLowAccelerationLinearMotionEntity = 2,
    /// <summary>DRM (RPW) - Constant Velocity / Low Acceleration Linear Motion Entity with Extrapolation of Orientation</summary>
    DrmRpwConstantVelocityLowAccelerationLinearMotionEntityWithExtrapolationOfOrientation = 3,
    /// <summary>DRM (RVW) - High Speed or Maneuvering Entity with Extrapolation of Orientation</summary>
    DrmRvwHighSpeedOrManeuveringEntityWithExtrapolationOfOrientation = 4,
    /// <summary>DRM (FVW) - High Speed or Maneuvering Entity</summary>
    DrmFvwHighSpeedOrManeuveringEntity = 5,
    /// <summary>DRM (FPB) - Similar to FPW except in Body Coordinates</summary>
    DrmFpbSimilarToFpwExceptInBodyCoordinates = 6,
    /// <summary>DRM (RPB) - Similar to RPW except in Body Coordinates</summary>
    DrmRpbSimilarToRpwExceptInBodyCoordinates = 7,
    /// <summary>DRM (RVB) - Similar to RVW except in Body Coordinates</summary>
    DrmRvbSimilarToRvwExceptInBodyCoordinates = 8,
    /// <summary>DRM (FVB) - Similar to FVW except in Body Coordinates</summary>
    DrmFvbSimilarToFvwExceptInBodyCoordinates = 9,
    /// <summary>Combined Parabolic/Circular (CPC)</summary>
    CombinedParabolicCircularCpc = 10,
}

/// <summary>SISO-REF-010 v36 enumeration UID 81.</summary>
public enum DesignatorDesignatorCode : ushort
{
    /// <summary>Other</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Other = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 80.</summary>
public enum DesignatorSystemName : ushort
{
    /// <summary>Not Specified</summary>
    NotSpecified = 0,
    /// <summary>AN/AAQ-4</summary>
    AnAaq4 = 1000,
    /// <summary>AN/AAQ-7</summary>
    AnAaq7 = 1100,
    /// <summary>AN/AAQ-8</summary>
    AnAaq8 = 1200,
    /// <summary>AN/AAQ-14 LANTIRN</summary>
    AnAaq14Lantirn = 1300,
    /// <summary>AN/AAQ-19</summary>
    AnAaq19 = 1400,
    /// <summary>AN/AAQ-22A; SAFIRE</summary>
    AnAaq22aSafire = 1500,
    /// <summary>AN/AAQ-22B; SAFIRE LP</summary>
    AnAaq22bSafireLp = 1600,
    /// <summary>AN/AAQ-22C; Star SAFIRE I</summary>
    AnAaq22cStarSafireI = 1700,
    /// <summary>AN/AAQ-22D; BRITE Star</summary>
    AnAaq22dBriteStar = 1800,
    /// <summary>AN/AAQ-24(V) DIRCM; Nemesis</summary>
    AnAaq24VDircmNemesis = 1900,
    /// <summary>AN/AAQ-25 LTS</summary>
    AnAaq25Lts = 2000,
    /// <summary>AN/AAQ-28(V) LITENING II</summary>
    AnAaq28VLiteningIi = 2100,
    /// <summary>AN/AAQ-30</summary>
    AnAaq30 = 2200,
    /// <summary>AN/AAQ-32</summary>
    AnAaq32 = 2300,
    /// <summary>AN/AAQ-33; Sniper</summary>
    AnAaq33Sniper = 2400,
    /// <summary>AN/AAQ-37</summary>
    AnAaq37 = 2500,
    /// <summary>AN/AAQ-38</summary>
    AnAaq38 = 2600,
    /// <summary>AN/AAQ-40</summary>
    AnAaq40 = 2650,
    /// <summary>AN/AAS-32</summary>
    AnAas32 = 2700,
    /// <summary>AN/AAS-35V</summary>
    AnAas35v = 2800,
    /// <summary>AN/AAS-37</summary>
    AnAas37 = 2900,
    /// <summary>AN/AAS-38</summary>
    AnAas38 = 3000,
    /// <summary>AN/AAS-44(V)</summary>
    AnAas44V = 3100,
    /// <summary>AN/AAS-46</summary>
    AnAas46 = 3200,
    /// <summary>AN/AAS-49</summary>
    AnAas49 = 3300,
    /// <summary>AN/AAS-51</summary>
    AnAas51 = 3400,
    /// <summary>AN/AAS-52; MTS-A</summary>
    AnAas52MtsA = 3500,
    /// <summary>AN/ALQ-10</summary>
    AnAlq10 = 3600,
    /// <summary>AN/ASQ-228</summary>
    AnAsq228 = 3700,
    /// <summary>AN/AVQ-25</summary>
    AnAvq25 = 4400,
    /// <summary>AN/AVQ-26</summary>
    AnAvq26 = 4500,
    /// <summary>AN/GVS-5</summary>
    AnGvs5 = 4600,
    /// <summary>AN/PED-1 LLDR</summary>
    AnPed1Lldr = 4700,
    /// <summary>TADS LRF/D</summary>
    TadsLrfD = 4800,
    /// <summary>MMS LRF/D</summary>
    MmsLrfD = 4900,
    /// <summary>AH-1 C-NITE</summary>
    Ah1CNite = 5000,
    /// <summary>MATES</summary>
    Mates = 5100,
    /// <summary>TCV 115</summary>
    Tcv115 = 5200,
    /// <summary>TIM</summary>
    Tim = 5300,
    /// <summary>TMS 303</summary>
    Tms303 = 5400,
    /// <summary>TMY 303</summary>
    Tmy303 = 5500,
    /// <summary>ALRAD</summary>
    Alrad = 5600,
    /// <summary>RFTDL</summary>
    Rftdl = 5700,
    /// <summary>VVLR</summary>
    Vvlr = 5800,
    /// <summary>P0705 HELL</summary>
    P0705Hell = 6000,
    /// <summary>P0708 PULSE</summary>
    P0708Pulse = 6100,
    /// <summary>HELD</summary>
    Held = 6200,
    /// <summary>TYPE 105</summary>
    Type105 = 6300,
    /// <summary>TYPE 118</summary>
    Type118 = 6400,
    /// <summary>TYPE 121</summary>
    Type121 = 6500,
    /// <summary>TYPE 126</summary>
    Type126 = 6600,
    /// <summary>TYPE 629</summary>
    Type629 = 6700,
    /// <summary>CLDS</summary>
    Clds = 6800,
    /// <summary>TAV-38</summary>
    Tav38 = 6900,
    /// <summary>TMV 630</summary>
    Tmv630 = 7000,
    /// <summary>ALTM 1020</summary>
    Altm1020 = 7100,
    /// <summary>ALATS</summary>
    Alats = 7200,
    /// <summary>Dark Star/LAMPS</summary>
    DarkStarLamps = 7300,
    /// <summary>GLTD II</summary>
    GltdIi = 7400,
    /// <summary>MBT-ELRF</summary>
    MbtElrf = 7500,
    /// <summary>Mark VII</summary>
    MarkVii = 7600,
    /// <summary>SIRE V</summary>
    SireV = 7700,
    /// <summary>AN/AAQ-16B</summary>
    AnAaq16b = 7800,
    /// <summary>AN/AAQ-16D; AESOP</summary>
    AnAaq16dAesop = 7900,
    /// <summary>AN/AAQ-21; Star SAFIRE III</summary>
    AnAaq21StarSafireIii = 8000,
    /// <summary>AN/AAQ-22E; BRITE Star</summary>
    AnAaq22eBriteStar = 8100,
    /// <summary>AN/AAQ-36; Star SAFIRE II</summary>
    AnAaq36StarSafireIi = 8200,
    /// <summary>AN/AAS-38A; Nite Hawk</summary>
    AnAas38aNiteHawk = 8300,
    /// <summary>AN/AAS-38B; Nite Hawk</summary>
    AnAas38bNiteHawk = 8400,
    /// <summary>AN/AAS-44C(V)</summary>
    AnAas44cV = 8500,
    /// <summary>AN/AAS-53; CSP</summary>
    AnAas53Csp = 8600,
    /// <summary>AN/ASQ-28 ATFLIR</summary>
    AnAsq28Atflir = 8700,
    /// <summary>AN/DAS-1; MTS-B</summary>
    AnDas1MtsB = 8800,
    /// <summary>AN/PAQ-1 LTD</summary>
    AnPaq1Ltd = 8900,
    /// <summary>AN/PAQ-3 MULE</summary>
    AnPaq3Mule = 9000,
    /// <summary>AN/PEQ-1; SOFLAM</summary>
    AnPeq1Soflam = 9090,
    /// <summary>AN/PEQ-3</summary>
    AnPeq3 = 9100,
    /// <summary>AN/PEQ-15; ATPIAL</summary>
    AnPeq15Atpial = 9140,
    /// <summary>AN/PEQ-18; IZLID 1000P</summary>
    AnPeq18Izlid1000p = 9150,
    /// <summary>AN/TVQ-2 G/VLLD</summary>
    AnTvq2GVlld = 9200,
    /// <summary>AN/ZSQ-2(V)1 EOS</summary>
    AnZsq2V1Eos = 9300,
    /// <summary>AN/ZSQ-2(V)2 EOS</summary>
    AnZsq2V2Eos = 9400,
    /// <summary>CIRCM</summary>
    Circm = 9500,
    /// <summary>Guardian</summary>
    Guardian = 9600,
    /// <summary>IZLID 200P</summary>
    Izlid200p = 9700,
    /// <summary>IZLID 1000P-W</summary>
    Izlid1000pW = 9800,
    /// <summary>MMS</summary>
    Mms = 9900,
    /// <summary>M-TADS/PNVS; Arrowhead</summary>
    MTadsPnvsArrowhead = 10000,
    /// <summary>RBS-70</summary>
    Rbs70 = 10100,
    /// <summary>RBS-90</summary>
    Rbs90 = 10200,
    /// <summary>TADS/PNVS</summary>
    TadsPnvs = 10300,
    /// <summary>COLIBRI</summary>
    Colibri = 10400,
    /// <summary>Damocles</summary>
    Damocles = 10500,
    /// <summary>I-251 Shkval</summary>
    I251Shkval = 10600,
    /// <summary>KPS-53AV EOTS</summary>
    Kps53avEots = 10700,
    /// <summary>Star SAFIRE 380</summary>
    StarSafire380 = 10800,
    /// <summary>JANUS-T EOS</summary>
    JanusTEos = 10900,
    /// <summary>LOTHAR EOS</summary>
    LotharEos = 11000,
    /// <summary>MK46 MOD 1 EOS</summary>
    Mk46Mod1Eos = 11100,
    /// <summary>MTK-201ME EOS</summary>
    Mtk201meEos = 11200,
    /// <summary>Thales Mirador Mk2 EOS</summary>
    ThalesMiradorMk2Eos = 11300,
    /// <summary>TPN-1M-49-23 EOS</summary>
    Tpn1m4923Eos = 11400,
    /// <summary>MX-10</summary>
    Mx10 = 11500,
    /// <summary>MX-15</summary>
    Mx15 = 11600,
    /// <summary>MX-20</summary>
    Mx20 = 11700,
    /// <summary>AN/DAS-4; MTS-B</summary>
    AnDas4MtsB = 11800,
    /// <summary>AN/AAS-53; CSPv3 TLA</summary>
    AnAas53CSPv3Tla = 11900,
}

/// <summary>SISO-REF-010 v36 enumeration UID 62.</summary>
public enum DetonationResult : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Entity Impact</summary>
    EntityImpact = 1,
    /// <summary>Entity Proximate Detonation</summary>
    EntityProximateDetonation = 2,
    /// <summary>Ground Impact</summary>
    GroundImpact = 3,
    /// <summary>Ground Proximate Detonation</summary>
    GroundProximateDetonation = 4,
    /// <summary>Detonation</summary>
    Detonation = 5,
    /// <summary>None or No Detonation (Dud)</summary>
    NoneOrNoDetonationDud = 6,
    /// <summary>HE hit, small</summary>
    HeHitSmall = 7,
    /// <summary>HE hit, medium</summary>
    HeHitMedium = 8,
    /// <summary>HE hit, large</summary>
    HeHitLarge = 9,
    /// <summary>Armor-piercing hit</summary>
    ArmorPiercingHit = 10,
    /// <summary>Dirt blast, small</summary>
    DirtBlastSmall = 11,
    /// <summary>Dirt blast, medium</summary>
    DirtBlastMedium = 12,
    /// <summary>Dirt blast, large</summary>
    DirtBlastLarge = 13,
    /// <summary>Water blast, small</summary>
    WaterBlastSmall = 14,
    /// <summary>Water blast, medium</summary>
    WaterBlastMedium = 15,
    /// <summary>Water blast, large</summary>
    WaterBlastLarge = 16,
    /// <summary>Air hit</summary>
    AirHit = 17,
    /// <summary>Building hit, small</summary>
    BuildingHitSmall = 18,
    /// <summary>Building hit, medium</summary>
    BuildingHitMedium = 19,
    /// <summary>Building hit, large</summary>
    BuildingHitLarge = 20,
    /// <summary>Mine-clearing line charge</summary>
    MineClearingLineCharge = 21,
    /// <summary>Environment object impact</summary>
    EnvironmentObjectImpact = 22,
    /// <summary>Environment object proximate detonation</summary>
    EnvironmentObjectProximateDetonation = 23,
    /// <summary>Water Impact</summary>
    WaterImpact = 24,
    /// <summary>Air Burst</summary>
    AirBurst = 25,
    /// <summary>Kill with fragment type 1</summary>
    KillWithFragmentType1 = 26,
    /// <summary>Kill with fragment type 2</summary>
    KillWithFragmentType2 = 27,
    /// <summary>Kill with fragment type 3</summary>
    KillWithFragmentType3 = 28,
    /// <summary>Kill with fragment type 1 after fly-out failure</summary>
    KillWithFragmentType1AfterFlyOutFailure = 29,
    /// <summary>Kill with fragment type 2 after fly-out failure</summary>
    KillWithFragmentType2AfterFlyOutFailure = 30,
    /// <summary>Miss due to fly-out failure</summary>
    MissDueToFlyOutFailure = 31,
    /// <summary>Miss due to end-game failure</summary>
    MissDueToEndGameFailure = 32,
    /// <summary>Miss due to fly-out and end-game failure</summary>
    MissDueToFlyOutAndEndGameFailure = 33,
}

/// <summary>SISO-REF-010 v36 enumeration UID 300.</summary>
public enum EeAttributeStateIndicator : byte
{
    /// <summary>Heartbeat Update</summary>
    HeartbeatUpdate = 0,
    /// <summary>Changed Data</summary>
    ChangedData = 1,
    /// <summary>Has Ceased</summary>
    HasCeased = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 78.</summary>
public enum ElectromagneticEmissionBeamFunction : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Search</summary>
    Search = 1,
    /// <summary>Height Finding</summary>
    HeightFinding = 2,
    /// <summary>Acquisition</summary>
    Acquisition = 3,
    /// <summary>Tracking</summary>
    Tracking = 4,
    /// <summary>Acquisition and tracking</summary>
    AcquisitionAndTracking = 5,
    /// <summary>Command guidance</summary>
    CommandGuidance = 6,
    /// <summary>Illumination</summary>
    Illumination = 7,
    /// <summary>Ranging</summary>
    Ranging = 8,
    /// <summary>Missile beacon</summary>
    MissileBeacon = 9,
    /// <summary>Missile Fusing</summary>
    MissileFusing = 10,
    /// <summary>Active radar missile seeker</summary>
    ActiveRadarMissileSeeker = 11,
    /// <summary>Jamming</summary>
    Jamming = 12,
    /// <summary>IFF</summary>
    Iff = 13,
    /// <summary>Navigation / Weather</summary>
    NavigationWeather = 14,
    /// <summary>Meteorological</summary>
    Meteorological = 15,
    /// <summary>Data transmission</summary>
    DataTransmission = 16,
    /// <summary>Navigational directional beacon</summary>
    NavigationalDirectionalBeacon = 17,
    /// <summary>Ground Mapping</summary>
    GroundMapping = 19,
    /// <summary>Time-Shared Search</summary>
    TimeSharedSearch = 20,
    /// <summary>Time-Shared Acquisition</summary>
    TimeSharedAcquisition = 21,
    /// <summary>Time-Shared Track</summary>
    TimeSharedTrack = 22,
    /// <summary>Time-Shared Command Guidance</summary>
    TimeSharedCommandGuidance = 23,
    /// <summary>Time-Shared Illumination</summary>
    TimeSharedIllumination = 24,
    /// <summary>Time-Shared Jamming</summary>
    TimeSharedJamming = 25,
}

/// <summary>SISO-REF-010 v36 enumeration UID 77.</summary>
public enum ElectromagneticEmissionStateUpdateIndicator : byte
{
    /// <summary>Heartbeat Update</summary>
    HeartbeatUpdate = 0,
    /// <summary>Changed Data Update</summary>
    ChangedDataUpdate = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 75.</summary>
public enum EmitterName : ushort
{
    /// <summary>1245/6X</summary>
    Value12456x = 2,
    /// <summary>1L117</summary>
    Value1l117 = 3,
    /// <summary>1L121E</summary>
    Value1l121e = 4,
    /// <summary>1L250</summary>
    Value1l250 = 5,
    /// <summary>1L220-U</summary>
    Value1l220U = 6,
    /// <summary>1L122-1E</summary>
    Value1l1221e = 7,
    /// <summary>1RL257</summary>
    Value1rl257 = 9,
    /// <summary>1RL138</summary>
    Value1rl138 = 10,
    /// <summary>1RL257 (Krasukha-4) Jammer</summary>
    Value1rl257Krasukha4Jammer = 11,
    /// <summary>5N20</summary>
    Value5n20 = 12,
    /// <summary>5H62B</summary>
    Value5h62b = 13,
    /// <summary>5P-10</summary>
    Value5p10 = 14,
    /// <summary>5P-10E</summary>
    Value5p10e = 15,
    /// <summary>5P-10-01</summary>
    Value5p1001 = 16,
    /// <summary>5P-10-01E</summary>
    Value5p1001e = 17,
    /// <summary>5P-10-02</summary>
    Value5p1002 = 18,
    /// <summary>5P-10-02E</summary>
    Value5p1002e = 19,
    /// <summary>5P-10-03</summary>
    Value5p1003 = 20,
    /// <summary>5P-10-03E</summary>
    Value5p1003e = 21,
    /// <summary>5P-10E MOD</summary>
    Value5p10eMod = 22,
    /// <summary>621A-3</summary>
    Value621a3 = 25,
    Value = 40,
    /// <summary>9B-1103M2</summary>
    Value9b1103m2 = 42,
    /// <summary>1226 DECCA MIL</summary>
    Value1226DeccaMil = 45,
    /// <summary>9B-1348</summary>
    Value9b1348 = 46,
    /// <summary>3KM6</summary>
    Value3km6 = 47,
    /// <summary>9KR400</summary>
    Value9kr400 = 48,
    /// <summary>50N6A</summary>
    Value50n6a = 49,
    /// <summary>55G6-1</summary>
    Value55g61 = 50,
    /// <summary>59N6</summary>
    Value59n6 = 55,
    /// <summary>5N69</summary>
    Value5n69 = 57,
    /// <summary>67N6</summary>
    Value67n6 = 60,
    /// <summary>79K6 Pelican</summary>
    Value79k6Pelican = 62,
    /// <summary>76T6</summary>
    Value76t6 = 63,
    /// <summary>77T6 ABM</summary>
    Value77t6Abm = 64,
    /// <summary>80K6</summary>
    Value80k6 = 65,
    /// <summary>91N6A(M)</summary>
    Value91n6aM = 66,
    /// <summary>80K6M</summary>
    Value80k6m = 67,
    /// <summary>96L6E</summary>
    Value96l6e = 70,
    /// <summary>96L6-TsP</summary>
    Value96l6TsP = 75,
    /// <summary>9C18M3</summary>
    Value9c18m3 = 76,
    /// <summary>9C36M</summary>
    Value9c36m = 77,
    /// <summary>9GR400</summary>
    Value9gr400 = 80,
    /// <summary>9 GR 400A</summary>
    Value9Gr400a = 81,
    /// <summary>9GR600</summary>
    Value9gr600 = 90,
    /// <summary>9GR606</summary>
    Value9gr606 = 91,
    /// <summary>9 LV 100</summary>
    Value9Lv100 = 125,
    /// <summary>9LV 200 TA</summary>
    Value9lv200Ta = 135,
    /// <summary>9LV 200 TV</summary>
    Value9lv200Tv = 180,
    /// <summary>9LV 200 TT</summary>
    Value9lv200Tt = 181,
    /// <summary>9LV200 MK III</summary>
    Value9lv200MkIii = 183,
    /// <summary>9LV326</summary>
    Value9lv326 = 185,
    /// <summary>9M96E2 Seeker</summary>
    Value9m96e2Seeker = 190,
    /// <summary>9M96M MH</summary>
    Value9m96mMh = 191,
    /// <summary>9S15M2</summary>
    Value9s15m2 = 195,
    /// <summary>9S19M2</summary>
    Value9s19m2 = 196,
    /// <summary>9S19ME</summary>
    Value9s19me = 197,
    /// <summary>9S32M</summary>
    Value9s32m = 198,
    /// <summary>9S32ME</summary>
    Value9s32me = 199,
    /// <summary>9S36E</summary>
    Value9s36e = 200,
    /// <summary>9S112</summary>
    Value9s112 = 215,
    Value225 = 225,
    Value270 = 270,
    Value315 = 315,
    Value360 = 360,
    Value405 = 405,
    Value450 = 450,
    Value495 = 495,
    Value540 = 540,
    Value585 = 585,
    Value630 = 630,
    Value675 = 675,
    Value720 = 720,
    Value765 = 765,
    Value810 = 810,
    Value855 = 855,
    Value900 = 900,
    Value945 = 945,
    Value990 = 990,
    Value1035 = 1035,
    /// <summary>AA-6C Acrid (R-40)</summary>
    Aa6cAcridR40 = 1070,
    /// <summary>AA-7C Apex (R-24R)</summary>
    Aa7cApexR24r = 1073,
    Value1080 = 1080,
    /// <summary>AA-10A (R-27R)</summary>
    Aa10aR27r = 1081,
    Value1082 = 1082,
    /// <summary>R-37 Seeker</summary>
    R37Seeker = 1085,
    /// <summary>AAM-4B MH</summary>
    Aam4bMh = 1090,
    /// <summary>AA-300</summary>
    Aa300 = 1094,
    /// <summary>R-77 Seeker</summary>
    R77Seeker = 1095,
    Value1096 = 1096,
    /// <summary>ADES</summary>
    Ades = 1097,
    /// <summary>ADS-4 LRSR</summary>
    Ads4Lrsr = 1098,
    /// <summary>ACR-430</summary>
    Acr430 = 1099,
    /// <summary>Agave</summary>
    Agave = 1100,
    /// <summary>ACSOPRI-E</summary>
    AcsopriE = 1101,
    /// <summary>ABD 2000</summary>
    Abd2000 = 1102,
    /// <summary>ADAC MK 1</summary>
    AdacMk1 = 1110,
    /// <summary>ADAC MK 2</summary>
    AdacMk2 = 1111,
    /// <summary>ADAR</summary>
    Adar = 1113,
    /// <summary>ADOUR</summary>
    Adour = 1115,
    /// <summary>AGAT 9B-1348</summary>
    Agat9b1348 = 1117,
    /// <summary>Adros KT-01AV</summary>
    AdrosKt01av = 1118,
    /// <summary>Agat 9E420</summary>
    Agat9e420 = 1120,
    /// <summary>AGM-158 JASSM SAR</summary>
    Agm158JassmSar = 1122,
    /// <summary>AGM-88 HARM MMW</summary>
    Agm88HarmMmw = 1123,
    /// <summary>AGRION 15</summary>
    Agrion15 = 1125,
    Value1130 = 1130,
    /// <summary>AHV-17</summary>
    Ahv17 = 1150,
    /// <summary>AI MK 23</summary>
    AiMk23 = 1170,
    /// <summary>AIDA II</summary>
    AidaIi = 1215,
    /// <summary>AIM-120A</summary>
    Aim120a = 1216,
    /// <summary>AIM-7M Sparrow</summary>
    Aim7mSparrow = 1218,
    /// <summary>1L271</summary>
    Value1l271 = 1230,
    /// <summary>ALA-51</summary>
    Ala51 = 1240,
    /// <summary>Albatros MK2</summary>
    AlbatrosMk2 = 1260,
    /// <summary>ALT-50</summary>
    Alt50 = 1263,
    /// <summary>ALTAIR</summary>
    Altair = 1264,
    /// <summary>AM/APS-717</summary>
    AmAps717 = 1265,
    /// <summary>AMES 13 MK 1</summary>
    Ames13Mk1 = 1268,
    /// <summary>WGU-16/B</summary>
    Wgu16B = 1270,
    /// <summary>1L13-3 (55G6)</summary>
    Value1l13355g6 = 1280,
    /// <summary>1L13-3 (55G6)</summary>
    Value1l13355g61282 = 1282,
    /// <summary>Amber Wedge Jammer</summary>
    AmberWedgeJammer = 1285,
    /// <summary>AMDR 3D</summary>
    Amdr3d = 1288,
    /// <summary>ANA SPS 502</summary>
    AnaSps502 = 1305,
    Value1306 = 1306,
    /// <summary>ANRITSU Electric AR-30A</summary>
    AnritsuElectricAr30a = 1350,
    /// <summary>Antilope V</summary>
    AntilopeV = 1395,
    /// <summary>AN/AAQ-24</summary>
    AnAaq24 = 1397,
    /// <summary>AN/ADM-160</summary>
    AnAdm160 = 1398,
    /// <summary>AN/ALE-50</summary>
    AnAle50 = 1400,
    /// <summary>AN/ALQ-76</summary>
    AnAlq76 = 1410,
    /// <summary>AN/ALQ-99</summary>
    AnAlq99 = 1440,
    /// <summary>AN/ALQ-99 Band 4</summary>
    AnAlq99Band4 = 1441,
    /// <summary>AN/ALQ-99 LBT</summary>
    AnAlq99Lbt = 1442,
    /// <summary>AN/ALQ-100</summary>
    AnAlq100 = 1485,
    /// <summary>AN/ALQ-101</summary>
    AnAlq101 = 1530,
    /// <summary>AN/ALQ-119</summary>
    AnAlq119 = 1575,
    /// <summary>AN/ALQ-122</summary>
    AnAlq122 = 1585,
    /// <summary>AN/ALQ-126A</summary>
    AnAlq126a = 1620,
    /// <summary>AN/ALQ-128</summary>
    AnAlq128 = 1621,
    /// <summary>AN/ALQ-126B</summary>
    AnAlq126b = 1622,
    /// <summary>AN/ALQ-131</summary>
    AnAlq131 = 1626,
    /// <summary>AN/ALQ-131 Blk II</summary>
    AnAlq131BlkIi = 1627,
    /// <summary>AN/ALQ-135C/D</summary>
    AnAlq135cD = 1628,
    /// <summary>AN/ALQ-144A(V)3</summary>
    AnAlq144aV3 = 1630,
    /// <summary>AN/ALQ-153</summary>
    AnAlq153 = 1632,
    /// <summary>AN/ALQ-157Jammer</summary>
    AnAlq157Jammer = 1633,
    /// <summary>AN/ALQ-155</summary>
    AnAlq155 = 1634,
    /// <summary>AN/ALQ-156</summary>
    AnAlq156 = 1635,
    /// <summary>AN/ALQ-161/A</summary>
    AnAlq161A = 1636,
    /// <summary>AN/ALQ-161</summary>
    AnAlq161 = 1637,
    /// <summary>AN/ALQ-162</summary>
    AnAlq162 = 1638,
    /// <summary>AN/ALQ-164</summary>
    AnAlq164 = 1639,
    /// <summary>AN/ALQ-165</summary>
    AnAlq165 = 1640,
    /// <summary>AN/ALQ-187 Jammer</summary>
    AnAlq187Jammer = 1641,
    /// <summary>AN/ALQ-167</summary>
    AnAlq167 = 1642,
    /// <summary>AN/ALQ-172(V)1</summary>
    AnAlq172V1 = 1643,
    /// <summary>AN/ALQ-172(V)2</summary>
    AnAlq172V2 = 1644,
    /// <summary>AN/ALQ-172(V)3</summary>
    AnAlq172V3 = 1645,
    /// <summary>AN/ALQ-176</summary>
    AnAlq176 = 1646,
    /// <summary>AN/ALQ-178</summary>
    AnAlq178 = 1647,
    /// <summary>AN/ALQ-184</summary>
    AnAlq184 = 1648,
    /// <summary>AN/ALQ-184(V)9</summary>
    AnAlq184V9 = 1649,
    /// <summary>AN/ALQ-188</summary>
    AnAlq188 = 1650,
    /// <summary>AN/ALQ-214</summary>
    AnAlq214 = 1651,
    /// <summary>AN/ALR-56</summary>
    AnAlr56 = 1652,
    /// <summary>AN/ALQ-221</summary>
    AnAlq221 = 1653,
    /// <summary>AN/ALR-69</summary>
    AnAlr69 = 1654,
    /// <summary>AN/ALQ-211(V)</summary>
    AnAlq211V = 1655,
    /// <summary>AN/ALT-16A</summary>
    AnAlt16a = 1656,
    /// <summary>AN/ALQ-173</summary>
    AnAlq173 = 1657,
    /// <summary>AN/ALT-28</summary>
    AnAlt28 = 1658,
    /// <summary>AN/ALR-66B Jammer</summary>
    AnAlr66bJammer = 1659,
    /// <summary>AN/ALT-32A</summary>
    AnAlt32a = 1660,
    /// <summary>AN/ALQ-196</summary>
    AnAlq196 = 1661,
    /// <summary>AN/ALQ-249(V)1</summary>
    AnAlq249V1 = 1662,
    /// <summary>AN/ALQ-240(V)1 Jammer</summary>
    AnAlq240V1Jammer = 1663,
    /// <summary>AN/ALR-66B Jammer</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    AnAlr66bJammer1664 = 1664,
    /// <summary>AN/APD 10</summary>
    AnApd10 = 1665,
    /// <summary>AN/ALQ-249(V)2</summary>
    AnAlq249V2 = 1666,
    /// <summary>AN/ALQ-213</summary>
    AnAlq213 = 1670,
    /// <summary>ALQ-214A(V)4/5 Jammer</summary>
    Alq214aV45Jammer = 1672,
    /// <summary>AN/ALQ-218</summary>
    AnAlq218 = 1680,
    /// <summary>AN/ALQ-250 EPAWSS</summary>
    AnAlq250Epawss = 1685,
    /// <summary>AN/APG-50</summary>
    AnApg50 = 1700,
    /// <summary>AN/APG-53</summary>
    AnApg53 = 1710,
    /// <summary>AN/APG-59</summary>
    AnApg59 = 1755,
    /// <summary>AN/APG-63</summary>
    AnApg63 = 1800,
    /// <summary>AN/APG-63(V)1</summary>
    AnApg63V1 = 1805,
    /// <summary>AN/APG-63(V)2</summary>
    AnApg63V2 = 1807,
    /// <summary>AN/APG-63(V)3</summary>
    AnApg63V3 = 1809,
    /// <summary>AN/APG-65</summary>
    AnApg65 = 1845,
    /// <summary>AN/APG-66</summary>
    AnApg66 = 1870,
    /// <summary>AN/APG-66(V)</summary>
    AnApg66V = 1871,
    /// <summary>AN/APG-66(V)2</summary>
    AnApg66V2 = 1872,
    /// <summary>AN/APG-67</summary>
    AnApg67 = 1880,
    /// <summary>AN/APG-68</summary>
    AnApg68 = 1890,
    /// <summary>AN/APG-68(v)9</summary>
    AnApg68V9 = 1895,
    /// <summary>AN/APG-70</summary>
    AnApg70 = 1935,
    /// <summary>AN/APG-71</summary>
    AnApg71 = 1940,
    /// <summary>AN/APG-73</summary>
    AnApg73 = 1945,
    /// <summary>AN/APG-77</summary>
    AnApg77 = 1960,
    /// <summary>AN/APG-78</summary>
    AnApg78 = 1970,
    /// <summary>AN/APG-79</summary>
    AnApg79 = 1971,
    /// <summary>AN/APG-80</summary>
    AnApg80 = 1972,
    /// <summary>AN/APG-81</summary>
    AnApg81 = 1974,
    /// <summary>AN/APG-82(V)1</summary>
    AnApg82V1 = 1975,
    /// <summary>AN/APG-83</summary>
    AnApg83 = 1976,
    /// <summary>AN/APG-502</summary>
    AnApg502 = 1980,
    /// <summary>AN/APN-1</summary>
    AnApn1 = 2025,
    /// <summary>AN/APN-22</summary>
    AnApn22 = 2070,
    /// <summary>AN/APN-59</summary>
    AnApn59 = 2115,
    /// <summary>AN/APN-69</summary>
    AnApn69 = 2160,
    /// <summary>AN/APN-81</summary>
    AnApn81 = 2205,
    /// <summary>AN/APN-102</summary>
    AnApn102 = 2220,
    /// <summary>AN/APN-117</summary>
    AnApn117 = 2250,
    /// <summary>AN/APN-118</summary>
    AnApn118 = 2295,
    /// <summary>AN/APN-122</summary>
    AnApn122 = 2320,
    /// <summary>AN/APN-130</summary>
    AnApn130 = 2340,
    /// <summary>AN/APN-131</summary>
    AnApn131 = 2385,
    /// <summary>AN/APN-133</summary>
    AnApn133 = 2430,
    /// <summary>AN/APN-134</summary>
    AnApn134 = 2475,
    /// <summary>AN/APN-141(V)</summary>
    AnApn141V = 2476,
    /// <summary>AN/APN-147</summary>
    AnApn147 = 2520,
    /// <summary>AN/APN-150</summary>
    AnApn150 = 2565,
    /// <summary>AN/APN-153</summary>
    AnApn153 = 2610,
    /// <summary>AN/APN-154</summary>
    AnApn154 = 2655,
    /// <summary>AN/APN-155</summary>
    AnApn155 = 2700,
    /// <summary>AN/APN-159</summary>
    AnApn159 = 2745,
    /// <summary>AN/APN-177</summary>
    AnApn177 = 2746,
    /// <summary>AN/APN-179</summary>
    AnApn179 = 2747,
    /// <summary>AN/APN-169</summary>
    AnApn169 = 2748,
    /// <summary>AN/APN-182</summary>
    AnApn182 = 2790,
    /// <summary>AN/APN-187</summary>
    AnApn187 = 2835,
    /// <summary>AN/APN-190</summary>
    AnApn190 = 2880,
    /// <summary>AN/APN-194</summary>
    AnApn194 = 2925,
    /// <summary>AN/APN-195</summary>
    AnApn195 = 2970,
    /// <summary>AN/APN-198</summary>
    AnApn198 = 3015,
    /// <summary>AN/APN-200</summary>
    AnApn200 = 3060,
    /// <summary>AN/APN-202</summary>
    AnApn202 = 3105,
    /// <summary>AN/APN-205</summary>
    AnApn205 = 3106,
    /// <summary>AN/APN-209</summary>
    AnApn209 = 3120,
    /// <summary>AN/APN-209D</summary>
    AnApn209d = 3121,
    /// <summary>AN/APN-209A</summary>
    AnApn209a = 3122,
    /// <summary>AN/APN-215</summary>
    AnApn215 = 3148,
    /// <summary>AN/APN-217</summary>
    AnApn217 = 3150,
    /// <summary>AN/APN-218</summary>
    AnApn218 = 3152,
    /// <summary>AN/APN-224</summary>
    AnApn224 = 3153,
    /// <summary>AN/APN-227</summary>
    AnApn227 = 3154,
    /// <summary>AN/APN-230</summary>
    AnApn230 = 3155,
    /// <summary>AN/APN-232</summary>
    AnApn232 = 3156,
    /// <summary>AN/APN-237A</summary>
    AnApn237a = 3157,
    /// <summary>AN/APN-234</summary>
    AnApn234 = 3158,
    /// <summary>AN/APN-235</summary>
    AnApn235 = 3159,
    /// <summary>AN/APN-238</summary>
    AnApn238 = 3160,
    /// <summary>AN/APN-222</summary>
    AnApn222 = 3161,
    /// <summary>AN/APN-239</summary>
    AnApn239 = 3162,
    /// <summary>AN/APN-241</summary>
    AnApn241 = 3164,
    /// <summary>AN/APN-242</summary>
    AnApn242 = 3166,
    /// <summary>AN/APN-243</summary>
    AnApn243 = 3170,
    /// <summary>AN/APN-506</summary>
    AnApn506 = 3195,
    /// <summary>AN/APQ-72</summary>
    AnApq72 = 3240,
    /// <summary>AN/APQ-99</summary>
    AnApq99 = 3285,
    /// <summary>AN/APQ-100</summary>
    AnApq100 = 3330,
    /// <summary>AN/APQ-102</summary>
    AnApq102 = 3375,
    /// <summary>AN/APQ-107</summary>
    AnApq107 = 3376,
    /// <summary>AN/APQ-109</summary>
    AnApq109 = 3420,
    /// <summary>AN/APQ-113</summary>
    AnApq113 = 3465,
    /// <summary>AN/APQ-120</summary>
    AnApq120 = 3510,
    /// <summary>AN/APQ-122</summary>
    AnApq122 = 3512,
    /// <summary>AN/APQ-126</summary>
    AnApq126 = 3555,
    /// <summary>AN/APQ-128</summary>
    AnApq128 = 3600,
    /// <summary>AN/APQ-129</summary>
    AnApq129 = 3645,
    /// <summary>AN/APQ-148</summary>
    AnApq148 = 3690,
    /// <summary>AN/APQ-150A</summary>
    AnApq150a = 3700,
    /// <summary>AN/APQ-153</summary>
    AnApq153 = 3735,
    /// <summary>AN/APQ-155</summary>
    AnApq155 = 3770,
    /// <summary>AN/APQ-159</summary>
    AnApq159 = 3780,
    /// <summary>AN/APQ-164</summary>
    AnApq164 = 3785,
    /// <summary>AN/APQ-166</summary>
    AnApq166 = 3788,
    /// <summary>AN/APQ-170</summary>
    AnApq170 = 3790,
    /// <summary>AN/APQ-174</summary>
    AnApq174 = 3791,
    /// <summary>AN/APQ-180</summary>
    AnApq180 = 3794,
    /// <summary>AN/APQ-181</summary>
    AnApq181 = 3795,
    /// <summary>AN/APQ-186</summary>
    AnApq186 = 3800,
    /// <summary>AN/APS-15J</summary>
    AnAps15j = 3810,
    /// <summary>AN/APS-16(V)2</summary>
    AnAps16V2 = 3813,
    /// <summary>AN/APS-31</summary>
    AnAps31 = 3820,
    /// <summary>AN/APS-42</summary>
    AnAps42 = 3825,
    /// <summary>AN/APS-80</summary>
    AnAps80 = 3870,
    /// <summary>AN/APS-88</summary>
    AnAps88 = 3915,
    /// <summary>AN/APS-88A</summary>
    AnAps88a = 3916,
    /// <summary>AN/APS-94</summary>
    AnAps94 = 3920,
    /// <summary>AN/APS-96</summary>
    AnAps96 = 3922,
    /// <summary>AN/APS-113</summary>
    AnAps113 = 3958,
    /// <summary>AN/APS-115</summary>
    AnAps115 = 3960,
    /// <summary>AN/APS-116</summary>
    AnAps116 = 4005,
    /// <summary>AN/APS-120</summary>
    AnAps120 = 4050,
    /// <summary>AN/APS-121</summary>
    AnAps121 = 4095,
    /// <summary>AN/APS-124</summary>
    AnAps124 = 4140,
    /// <summary>AN/APS-125</summary>
    AnAps125 = 4185,
    /// <summary>AN/APS-127</summary>
    AnAps127 = 4190,
    /// <summary>AN/APS-128</summary>
    AnAps128 = 4230,
    /// <summary>AN/APS-130</summary>
    AnAps130 = 4275,
    /// <summary>AN/APS-133</summary>
    AnAps133 = 4320,
    /// <summary>AN/APS-134</summary>
    AnAps134 = 4365,
    /// <summary>AN/APS-137</summary>
    AnAps137 = 4410,
    /// <summary>AN/APS-137(V)5</summary>
    AnAps137V5 = 4413,
    /// <summary>AN/APS-137B</summary>
    AnAps137b = 4415,
    /// <summary>AN/APS-137B(V)5</summary>
    AnAps137bV5 = 4420,
    /// <summary>AN/APS-137D(V)5 Elta</summary>
    AnAps137dV5Elta = 4425,
    /// <summary>AN/APS-138</summary>
    AnAps138 = 4455,
    /// <summary>AN/APS-139</summary>
    AnAps139 = 4460,
    /// <summary>AN/APS-143</summary>
    AnAps143 = 4464,
    /// <summary>AN/APS-143 (V) 1</summary>
    AnAps143V1 = 4465,
    /// <summary>AN/APS-143B</summary>
    AnAps143b = 4466,
    /// <summary>AN/APS-143(V)3</summary>
    AnAps143V3 = 4467,
    /// <summary>AN/APS-143B(V)3</summary>
    AnAps143bV3 = 4468,
    /// <summary>AN/APS-153</summary>
    AnAps153 = 4475,
    /// <summary>AN/APS-154</summary>
    AnAps154 = 4476,
    /// <summary>AN/APS-150</summary>
    AnAps150 = 4480,
    /// <summary>AN/APS-145</summary>
    AnAps145 = 4482,
    /// <summary>AN/APS-147</summary>
    AnAps147 = 4485,
    /// <summary>AN/APS-149</summary>
    AnAps149 = 4486,
    /// <summary>AN/APS-503</summary>
    AnAps503 = 4489,
    /// <summary>AN/APS-504</summary>
    AnAps504 = 4490,
    /// <summary>AN/APS-705</summary>
    AnAps705 = 4491,
    /// <summary>AN/APW-22</summary>
    AnApw22 = 4500,
    /// <summary>AN/APW-23</summary>
    AnApw23 = 4545,
    /// <summary>AN/APX-6</summary>
    AnApx6 = 4590,
    /// <summary>AN/APX-7</summary>
    AnApx7 = 4635,
    /// <summary>AN/APX-39</summary>
    AnApx39 = 4680,
    /// <summary>AN/APX-64(V)</summary>
    AnApx64V = 4681,
    /// <summary>AN/APX-72</summary>
    AnApx72 = 4725,
    /// <summary>AN/APX-76</summary>
    AnApx76 = 4770,
    /// <summary>AN/APX-78</summary>
    AnApx78 = 4815,
    /// <summary>AN/APX-100</summary>
    AnApx100 = 4816,
    /// <summary>AN/APX-101</summary>
    AnApx101 = 4860,
    /// <summary>AN/APX-113 AIFF</summary>
    AnApx113Aiff = 4870,
    /// <summary>AN/APY-1</summary>
    AnApy1 = 4900,
    /// <summary>AN/APY-2</summary>
    AnApy2 = 4905,
    /// <summary>AN/APY-3</summary>
    AnApy3 = 4950,
    /// <summary>AN/APY-7</summary>
    AnApy7 = 4952,
    /// <summary>AN/APY-8</summary>
    AnApy8 = 4953,
    /// <summary>AN/APY-9</summary>
    AnApy9 = 4954,
    /// <summary>AN/APY-10</summary>
    AnApy10 = 4955,
    /// <summary>AN/ARN-21</summary>
    AnArn21 = 4995,
    /// <summary>AN/ARN-52</summary>
    AnArn52 = 5040,
    /// <summary>AN/ARN-84</summary>
    AnArn84 = 5085,
    /// <summary>AN/ARN-118</summary>
    AnArn118 = 5130,
    /// <summary>AN/ARN-153(V)</summary>
    AnArn153V = 5131,
    /// <summary>AN/ARN-153</summary>
    AnArn153 = 5165,
    /// <summary>AN/ARW 73</summary>
    AnArw73 = 5175,
    /// <summary>AN/ASB 1</summary>
    AnAsb1 = 5220,
    /// <summary>AN/ASG 21</summary>
    AnAsg21 = 5265,
    /// <summary>AN/ASN-137</summary>
    AnAsn137 = 5266,
    /// <summary>AN/ASN-128</summary>
    AnAsn128 = 5270,
    /// <summary>AN/ASQ-108</summary>
    AnAsq108 = 5280,
    /// <summary>AN/ASQ-239</summary>
    AnAsq239 = 5285,
    /// <summary>AN/AST-502</summary>
    AnAst502 = 5290,
    /// <summary>AN/AVQ-55</summary>
    AnAvq55 = 5300,
    /// <summary>AN/AWG 9</summary>
    AnAwg9 = 5310,
    /// <summary>AN/BRN-1</summary>
    AnBrn1 = 5320,
    /// <summary>AN/BPS-5</summary>
    AnBps5 = 5325,
    /// <summary>AN/BPS-9</summary>
    AnBps9 = 5355,
    /// <summary>AN/BPS 15</summary>
    AnBps15 = 5400,
    /// <summary>AN/BPS-15 H</summary>
    AnBps15H = 5401,
    /// <summary>AN/BPS-15J</summary>
    AnBps15j = 5402,
    /// <summary>AN/BPS-16</summary>
    AnBps16 = 5405,
    /// <summary>AN/BPS-16(V)2</summary>
    AnBps16V2 = 5406,
    /// <summary>AN/CPN-4</summary>
    AnCpn4 = 5410,
    /// <summary>AN/CPN-18</summary>
    AnCpn18 = 5415,
    /// <summary>AN/CRM-30</summary>
    AnCrm30 = 5420,
    /// <summary>AN/DPW-23</summary>
    AnDpw23 = 5430,
    /// <summary>AN/DSQ 26 Phoenix MH</summary>
    AnDsq26PhoenixMh = 5445,
    /// <summary>AN/DSQ 28 Harpoon MH</summary>
    AnDsq28HarpoonMh = 5490,
    /// <summary>AN/FPN-1</summary>
    AnFpn1 = 5491,
    /// <summary>AN/FPN-28</summary>
    AnFpn28 = 5493,
    /// <summary>AN/FPN-33</summary>
    AnFpn33 = 5494,
    /// <summary>AN/FPN-40</summary>
    AnFpn40 = 5495,
    /// <summary>AN/FPN-62</summary>
    AnFpn62 = 5500,
    /// <summary>AN/FPN-66</summary>
    AnFpn66 = 5502,
    /// <summary>AN/FPS-8</summary>
    AnFps8 = 5503,
    /// <summary>AN/FPN-67</summary>
    AnFpn67 = 5504,
    /// <summary>AN/FPS-16</summary>
    AnFps16 = 5505,
    /// <summary>AN/FPS-5</summary>
    AnFps5 = 5506,
    /// <summary>AN/FPS-18</summary>
    AnFps18 = 5507,
    /// <summary>AN/FPS-89</summary>
    AnFps89 = 5508,
    /// <summary>AN/FPS-49</summary>
    AnFps49 = 5509,
    /// <summary>AN/FPS-117</summary>
    AnFps117 = 5510,
    /// <summary>AN/FPS-85</summary>
    AnFps85 = 5511,
    /// <summary>AN/FPS-88</summary>
    AnFps88 = 5512,
    /// <summary>AN/FPS-113</summary>
    AnFps113 = 5513,
    /// <summary>AN/FPS-115</summary>
    AnFps115 = 5514,
    /// <summary>AN/FPS-20R</summary>
    AnFps20r = 5515,
    /// <summary>AN/FPS-132</summary>
    AnFps132 = 5516,
    /// <summary>AN/FPS-77</summary>
    AnFps77 = 5520,
    /// <summary>AN/FPS-41</summary>
    AnFps41 = 5521,
    /// <summary>AN/FPS-100A</summary>
    AnFps100a = 5522,
    /// <summary>AN/FPS-103</summary>
    AnFps103 = 5525,
    /// <summary>AN/FPS-108</summary>
    AnFps108 = 5526,
    /// <summary>AN/GPN-12</summary>
    AnGpn12 = 5527,
    /// <summary>AN/FPS-124(V)</summary>
    AnFps124V = 5528,
    /// <summary>AN/FPS-129</summary>
    AnFps129 = 5529,
    /// <summary>AN/GPX-6</summary>
    AnGpx6 = 5530,
    /// <summary>AN/GPX 8</summary>
    AnGpx8 = 5535,
    /// <summary>AN/GRN-12</summary>
    AnGrn12 = 5537,
    /// <summary>AN/MPN-14K</summary>
    AnMpn14k = 5538,
    /// <summary>AN/MPN-14</summary>
    AnMpn14 = 5539,
    /// <summary>AN/MPQ-10</summary>
    AnMpq10 = 5540,
    /// <summary>AN/MPN-17</summary>
    AnMpn17 = 5541,
    /// <summary>AN/MPQ-33/39/46/57/61 (HPIR) ILL</summary>
    AnMpq3339465761HpirIll = 5545,
    /// <summary>AN/MPQ-34/48/55/62 (CWAR) TA</summary>
    AnMpq34485562CwarTa = 5550,
    /// <summary>AN/MPQ-49</summary>
    AnMpq49 = 5551,
    /// <summary>AN/MPQ-35/50 (PAR) TA</summary>
    AnMpq3550ParTa = 5555,
    /// <summary>AN/MPQ-50C</summary>
    AnMpq50c = 5556,
    /// <summary>AN/MPQ-37/51 (ROR) TT</summary>
    AnMpq3751RorTt = 5560,
    /// <summary>AN/MPQ-43</summary>
    AnMpq43 = 5565,
    /// <summary>AN/MPQ-50</summary>
    AnMpq50 = 5567,
    /// <summary>AN/MPQ-53</summary>
    AnMpq53 = 5570,
    /// <summary>AN/MPQ-63</summary>
    AnMpq63 = 5571,
    /// <summary>AN/MPQ-64</summary>
    AnMpq64 = 5575,
    /// <summary>AN/SLQ-32</summary>
    AnSlq32 = 5576,
    /// <summary>AN/MPQ-65</summary>
    AnMpq65 = 5577,
    /// <summary>AN/SLQ-32(V)4</summary>
    AnSlq32V4 = 5578,
    /// <summary>AN/SLQ-32A</summary>
    AnSlq32a = 5579,
    /// <summary>AN/SPG-34</summary>
    AnSpg34 = 5580,
    /// <summary>AN/MSQ-104</summary>
    AnMsq104 = 5582,
    /// <summary>AN/MPS-36</summary>
    AnMps36 = 5583,
    /// <summary>AN/SLQ-503</summary>
    AnSlq503 = 5584,
    /// <summary>AN/SPG-48/MK 25 MOD 3</summary>
    AnSpg48Mk25Mod3 = 5620,
    /// <summary>AN/SPG-50</summary>
    AnSpg50 = 5625,
    /// <summary>AN/SPG-51</summary>
    AnSpg51 = 5670,
    /// <summary>AN/PPQ-2</summary>
    AnPpq2 = 5690,
    /// <summary>AN/PPS-15</summary>
    AnPps15 = 5700,
    /// <summary>AN/PPS-5</summary>
    AnPps5 = 5705,
    /// <summary>AN/PPS-5D</summary>
    AnPps5d = 5710,
    /// <summary>AN/SPG-51 CWI TI</summary>
    AnSpg51CwiTi = 5715,
    /// <summary>AN/SPG-51 FC</summary>
    AnSpg51Fc = 5760,
    /// <summary>AN/SPG-51C/D</summary>
    AnSpg51cD = 5761,
    /// <summary>AN/SPG-52</summary>
    AnSpg52 = 5805,
    /// <summary>AN/SPG-53</summary>
    AnSpg53 = 5850,
    /// <summary>AN/SPG-55B</summary>
    AnSpg55b = 5895,
    /// <summary>AN/SPG-60</summary>
    AnSpg60 = 5940,
    /// <summary>AN/SPG-62</summary>
    AnSpg62 = 5985,
    /// <summary>AN/SPG-503</summary>
    AnSpg503 = 5995,
    /// <summary>AN/SPN-4</summary>
    AnSpn4 = 6015,
    /// <summary>AN/SPN-11</summary>
    AnSpn11 = 6025,
    /// <summary>AN/SPN-35</summary>
    AnSpn35 = 6030,
    /// <summary>AN/SPN-41</summary>
    AnSpn41 = 6050,
    /// <summary>AN/SPN-43</summary>
    AnSpn43 = 6075,
    /// <summary>AN/SPN-43A</summary>
    AnSpn43a = 6076,
    /// <summary>AN/SPN-43C</summary>
    AnSpn43c = 6078,
    /// <summary>AN/SPN-46</summary>
    AnSpn46 = 6085,
    /// <summary>AN/SPQ-2</summary>
    AnSpq2 = 6120,
    /// <summary>AN/SPQ-5A</summary>
    AnSpq5a = 6155,
    /// <summary>AN/SPQ-9A</summary>
    AnSpq9a = 6165,
    /// <summary>AN/SPQ-9B</summary>
    AnSpq9b = 6166,
    /// <summary>AN/SPQ-34</summary>
    AnSpq34 = 6190,
    /// <summary>AN/SPS-4</summary>
    AnSps4 = 6210,
    /// <summary>AN/SPS-5</summary>
    AnSps5 = 6255,
    /// <summary>AN/SPS-5C</summary>
    AnSps5c = 6300,
    /// <summary>AN/SPS-6</summary>
    AnSps6 = 6345,
    /// <summary>AN/SPS-10</summary>
    AnSps10 = 6390,
    /// <summary>AN/SPS-21</summary>
    AnSps21 = 6435,
    /// <summary>AN/SPS-28</summary>
    AnSps28 = 6480,
    /// <summary>AN/SPS-37</summary>
    AnSps37 = 6525,
    /// <summary>AN/SPS-39A</summary>
    AnSps39a = 6570,
    /// <summary>AN/SPS-40</summary>
    AnSps40 = 6615,
    /// <summary>AN/SPS-41</summary>
    AnSps41 = 6660,
    /// <summary>AN/SPS-48</summary>
    AnSps48 = 6705,
    /// <summary>AN/SPS-48C</summary>
    AnSps48c = 6750,
    /// <summary>AN/SPS-48E</summary>
    AnSps48e = 6752,
    /// <summary>AN/SPS-49</summary>
    AnSps49 = 6795,
    /// <summary>AN/SPS-49(V)1</summary>
    AnSps49V1 = 6796,
    /// <summary>AN/SPS-49(V)2</summary>
    AnSps49V2 = 6797,
    /// <summary>AN/SPS-49(V)3</summary>
    AnSps49V3 = 6798,
    /// <summary>AN/SPS-49(V)4</summary>
    AnSps49V4 = 6799,
    /// <summary>AN/SPS-49(V)5</summary>
    AnSps49V5 = 6800,
    /// <summary>AN/SPS-49(V)6</summary>
    AnSps49V6 = 6801,
    /// <summary>AN/SPS-49(V)7</summary>
    AnSps49V7 = 6802,
    /// <summary>AN/SPS-49(V)8</summary>
    AnSps49V8 = 6803,
    /// <summary>AN/SPS-49A(V)1</summary>
    AnSps49aV1 = 6804,
    /// <summary>AN/SPS-52</summary>
    AnSps52 = 6840,
    /// <summary>AN/SPS-53</summary>
    AnSps53 = 6885,
    /// <summary>AN/SPS-55</summary>
    AnSps55 = 6930,
    /// <summary>AN/SPS-52C</summary>
    AnSps52c = 6945,
    /// <summary>AN/SPS-55 CS</summary>
    AnSps55Cs = 6970,
    /// <summary>AN/SPS-55 SS</summary>
    AnSps55Ss = 6975,
    /// <summary>AN/SPS-58</summary>
    AnSps58 = 7020,
    /// <summary>AN/SPS-58C</summary>
    AnSps58c = 7025,
    /// <summary>AN/SPS-59</summary>
    AnSps59 = 7065,
    /// <summary>AN/SPS-64</summary>
    AnSps64 = 7110,
    /// <summary>AN/SPS-64(V)9</summary>
    AnSps64V9 = 7119,
    /// <summary>SPS64(V)12</summary>
    Sps64V12 = 7120,
    /// <summary>AN/SPS-65</summary>
    AnSps65 = 7155,
    /// <summary>AN/SPS-66</summary>
    AnSps66 = 7175,
    /// <summary>AN/SPS-67</summary>
    AnSps67 = 7200,
    /// <summary>AN/SPS-73(I)</summary>
    AnSps73I = 7201,
    /// <summary>AN/SPS-69</summary>
    AnSps69 = 7210,
    /// <summary>AN/SPS-73</summary>
    AnSps73 = 7215,
    /// <summary>AN/SPS-74</summary>
    AnSps74 = 7216,
    /// <summary>AN/SPS-88</summary>
    AnSps88 = 7225,
    /// <summary>AN/SPS-501</summary>
    AnSps501 = 7226,
    /// <summary>AN/SPS-505</summary>
    AnSps505 = 7230,
    /// <summary>AN/SPY-1</summary>
    AnSpy1 = 7245,
    /// <summary>AN/SPY-1A</summary>
    AnSpy1a = 7250,
    /// <summary>AN/SPY-1B</summary>
    AnSpy1b = 7252,
    /// <summary>AN/SPY-1B(V)</summary>
    AnSpy1bV = 7253,
    /// <summary>AN/SPY-1D</summary>
    AnSpy1d = 7260,
    /// <summary>AN/SPY-1D(V)</summary>
    AnSpy1dV = 7261,
    /// <summary>AN/SPY-1F</summary>
    AnSpy1f = 7265,
    /// <summary>AN/SPY-3</summary>
    AnSpy3 = 7266,
    /// <summary>AN/TPN-12</summary>
    AnTpn12 = 7267,
    /// <summary>AN/SPY-4</summary>
    AnSpy4 = 7268,
    /// <summary>AN/TLQ-32 ARM Decoy</summary>
    AnTlq32ArmDecoy = 7269,
    /// <summary>AN/TPN-17</summary>
    AnTpn17 = 7270,
    /// <summary>AN/TPN-8</summary>
    AnTpn8 = 7271,
    /// <summary>AN/TPN-22</summary>
    AnTpn22 = 7272,
    /// <summary>AN/TLQ-17A</summary>
    AnTlq17a = 7273,
    /// <summary>AN/TMS-1</summary>
    AnTms1 = 7274,
    /// <summary>AN/TPN-24</summary>
    AnTpn24 = 7275,
    /// <summary>AN/TPN-25</summary>
    AnTpn25 = 7276,
    /// <summary>AN/TMS-2</summary>
    AnTms2 = 7277,
    /// <summary>AN/TPN-19</summary>
    AnTpn19 = 7278,
    /// <summary>AN/TPN-31</summary>
    AnTpn31 = 7279,
    /// <summary>AN/TPQ-18</summary>
    AnTpq18 = 7280,
    /// <summary>AN/SPY-6(V)</summary>
    AnSpy6V = 7281,
    /// <summary>AN/SPY-7(V1)</summary>
    AnSpy7V1 = 7282,
    /// <summary>AN/TPQ-36</summary>
    AnTpq36 = 7295,
    /// <summary>AN/TPQ-37</summary>
    AnTpq37 = 7300,
    /// <summary>AN/TPQ-38 (V8)</summary>
    AnTpq38V8 = 7301,
    /// <summary>AN/TPQ-39(V)</summary>
    AnTpq39V = 7302,
    /// <summary>AN/TPQ-47</summary>
    AnTpq47 = 7303,
    /// <summary>AN/TPS-43</summary>
    AnTps43 = 7305,
    /// <summary>AN/TPS-43E</summary>
    AnTps43e = 7310,
    /// <summary>AN/TPQ-48</summary>
    AnTpq48 = 7311,
    /// <summary>AN/TPQ-49</summary>
    AnTpq49 = 7312,
    /// <summary>AN/TPQ-46A</summary>
    AnTpq46a = 7313,
    /// <summary>AN/TPS-34</summary>
    AnTps34 = 7314,
    /// <summary>AN/TPS-59</summary>
    AnTps59 = 7315,
    /// <summary>AN/TPS-44</summary>
    AnTps44 = 7316,
    /// <summary>AN/TPQ-50</summary>
    AnTpq50 = 7317,
    /// <summary>AN/TPS-63</summary>
    AnTps63 = 7320,
    /// <summary>AN/TPS-65</summary>
    AnTps65 = 7321,
    /// <summary>AN/TPS-70 (V) 1</summary>
    AnTps70V1 = 7322,
    /// <summary>AN/TPS-63SS</summary>
    AnTps63ss = 7323,
    /// <summary>AN/TPS-73</summary>
    AnTps73 = 7324,
    /// <summary>AN/TPS-75</summary>
    AnTps75 = 7325,
    /// <summary>AN/TPS-77</summary>
    AnTps77 = 7326,
    /// <summary>AN/TPS-78</summary>
    AnTps78 = 7327,
    /// <summary>AN/TPS-79</summary>
    AnTps79 = 7328,
    /// <summary>AN/TPS-703</summary>
    AnTps703 = 7329,
    /// <summary>AN/TPX-46(V)7</summary>
    AnTpx46V7 = 7330,
    /// <summary>AN/TPS-80</summary>
    AnTps80 = 7331,
    /// <summary>AN/TPY-2</summary>
    AnTpy2 = 7333,
    /// <summary>AN/TSQ-288</summary>
    AnTsq288 = 7334,
    /// <summary>AN/ULQ-6A</summary>
    AnUlq6a = 7335,
    /// <summary>AN/ULQ-19</summary>
    AnUlq19 = 7340,
    /// <summary>AN/ULQ-21</summary>
    AnUlq21 = 7345,
    /// <summary>AN/UPN 25</summary>
    AnUpn25 = 7380,
    /// <summary>AN/UPS 1</summary>
    AnUps1 = 7425,
    /// <summary>AN/UPS-2</summary>
    AnUps2 = 7426,
    /// <summary>AN/UPS-3</summary>
    AnUps3 = 7427,
    /// <summary>AN/UPX 1</summary>
    AnUpx1 = 7470,
    /// <summary>AN/UPX 5</summary>
    AnUpx5 = 7515,
    /// <summary>AN/UPX 11</summary>
    AnUpx11 = 7560,
    /// <summary>AN/UPX 12</summary>
    AnUpx12 = 7605,
    /// <summary>AN/UPX 17</summary>
    AnUpx17 = 7650,
    /// <summary>AN/UPX 23</summary>
    AnUpx23 = 7695,
    /// <summary>AN/USQ-113(V)3</summary>
    AnUsq113V3 = 7700,
    /// <summary>AN/VPS 2</summary>
    AnVps2 = 7740,
    /// <summary>AN/PLM-3</summary>
    AnPlm3 = 7750,
    /// <summary>AN/PLM-3A</summary>
    AnPlm3a = 7751,
    /// <summary>AN/PLM-4</summary>
    AnPlm4 = 7752,
    /// <summary>AN/ZPY1</summary>
    AnZpy1 = 7753,
    /// <summary>AN/ZPY-2 MP-RTIP</summary>
    AnZpy2MpRtip = 7754,
    /// <summary>AN/ZPY-3</summary>
    AnZpy3 = 7755,
    /// <summary>AN/ZPY-8</summary>
    AnZpy8 = 7760,
    /// <summary>AORL-1AS</summary>
    Aorl1as = 7761,
    /// <summary>AORL-85K/TK/MTA</summary>
    Aorl85kTkMta = 7762,
    /// <summary>APAR</summary>
    Apar = 7765,
    /// <summary>Aparna</summary>
    Aparna = 7770,
    /// <summary>APECS II</summary>
    ApecsIi = 7780,
    Value7785 = 7785,
    /// <summary>APG 71</summary>
    Apg71 = 7830,
    /// <summary>APN 148</summary>
    Apn148 = 7875,
    /// <summary>APN 227</summary>
    Apn227 = 7920,
    /// <summary>APQ 113</summary>
    Apq113 = 7965,
    /// <summary>APQ 120</summary>
    Apq120 = 8010,
    /// <summary>APQ 148</summary>
    Apq148 = 8055,
    /// <summary>APS 504 V3</summary>
    Aps504V3 = 8100,
    /// <summary>AQUITAINE II</summary>
    AquitaineIi = 8102,
    /// <summary>AR-1</summary>
    Ar1 = 8103,
    /// <summary>AR 3D</summary>
    Ar3d = 8105,
    Value8112 = 8112,
    Value8113 = 8113,
    /// <summary>AR-15/2</summary>
    Ar152 = 8114,
    /// <summary>AR 320</summary>
    Ar320 = 8115,
    /// <summary>AR-325</summary>
    Ar325 = 8118,
    /// <summary>AR 327</summary>
    Ar327 = 8120,
    /// <summary>Arbalet-52</summary>
    Arbalet52 = 8121,
    /// <summary>ARBB-31</summary>
    Arbb31 = 8122,
    Value8123 = 8123,
    Value8126 = 8126,
    /// <summary>Aries-Nav</summary>
    AriesNav = 8127,
    /// <summary>Aries-CS</summary>
    AriesCs = 8128,
    /// <summary>ARGS-14E</summary>
    Args14e = 8134,
    /// <summary>ARGS 31</summary>
    Args31 = 8135,
    /// <summary>ARGUS</summary>
    Argus = 8140,
    /// <summary>AR M31</summary>
    ArM31 = 8145,
    /// <summary>ARECIBO</summary>
    Arecibo = 8150,
    /// <summary>ARED</summary>
    Ared = 8160,
    /// <summary>ARI 5954</summary>
    Ari5954 = 8190,
    /// <summary>ARI 5955</summary>
    Ari5955 = 8235,
    /// <summary>ARI 5979</summary>
    Ari5979 = 8280,
    /// <summary>ARGSN-31</summary>
    Argsn31 = 8281,
    /// <summary>ARGOS-10</summary>
    Argos10 = 8282,
    /// <summary>ARGOS-800</summary>
    Argos800 = 8283,
    /// <summary>ARI 5983</summary>
    Ari5983 = 8284,
    /// <summary>ARI 5991</summary>
    Ari5991 = 8285,
    /// <summary>ARI 5995</summary>
    Ari5995 = 8290,
    Value8325 = 8325,
    Value8370 = 8370,
    /// <summary>ARK-1</summary>
    Ark1 = 8375,
    Value8378 = 8378,
    /// <summary>ARMOR</summary>
    Armor = 8379,
    /// <summary>ARSR-3</summary>
    Arsr3 = 8380,
    /// <summary>ARS-400</summary>
    Ars400 = 8381,
    /// <summary>ARSR-1</summary>
    Arsr1 = 8382,
    /// <summary>ARSR-4</summary>
    Arsr4 = 8384,
    /// <summary>ARSR-18</summary>
    Arsr18 = 8390,
    Value8395 = 8395,
    /// <summary>ARTHUR MOD B</summary>
    ArthurModB = 8400,
    /// <summary>ARTHUR MOD C</summary>
    ArthurModC = 8405,
    /// <summary>ARTISAN 3D</summary>
    Artisan3d = 8410,
    Value8415 = 8415,
    Value8460 = 8460,
    /// <summary>AS 3 YJ-83K mmW MH</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    As3Yj83kMmWMh = 8470,
    /// <summary>AS.34 Kormoran Seeker</summary>
    As34KormoranSeeker = 8480,
    Value8505 = 8505,
    Value8550 = 8550,
    Value8595 = 8595,
    Value8640 = 8640,
    Value8685 = 8685,
    Value8730 = 8730,
    Value8735 = 8735,
    Value8736 = 8736,
    Value8737 = 8737,
    Value8750 = 8750,
    /// <summary>AS901A</summary>
    As901a = 8751,
    /// <summary>ASARS2</summary>
    Asars2 = 8755,
    /// <summary>ASDE-KDD</summary>
    AsdeKdd = 8756,
    /// <summary>ASLESHA</summary>
    Aslesha = 8757,
    /// <summary>A-SMGCS</summary>
    ASmgcs = 8758,
    /// <summary>ASMI-18X</summary>
    Asmi18x = 8759,
    /// <summary>Aspide AAM/SAM ILL</summary>
    AspideAamSamIll = 8760,
    /// <summary>ASMI-3</summary>
    Asmi3 = 8761,
    /// <summary>Aselsan MAR</summary>
    AselsanMar = 8762,
    /// <summary>ASR-2000</summary>
    Asr2000 = 8771,
    /// <summary>ASR-4</summary>
    Asr4 = 8772,
    /// <summary>ASR-4D</summary>
    Asr4d = 8773,
    /// <summary>ASR O</summary>
    AsrO = 8775,
    /// <summary>ASR-12</summary>
    Asr12 = 8776,
    /// <summary>ASR-22AL</summary>
    Asr22al = 8778,
    /// <summary>ASR-3</summary>
    Asr3 = 8779,
    /// <summary>ASR-5</summary>
    Asr5 = 8780,
    /// <summary>ASR-7</summary>
    Asr7 = 8782,
    /// <summary>ASR-8</summary>
    Asr8 = 8785,
    /// <summary>ASR-9</summary>
    Asr9 = 8790,
    /// <summary>ASR-9000</summary>
    Asr9000 = 8791,
    /// <summary>ASTI</summary>
    Asti = 8792,
    /// <summary>ASR-11/DASR</summary>
    Asr11Dasr = 8793,
    /// <summary>ASR-12</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Asr128795 = 8795,
    Value8812 = 8812,
    /// <summary>ASR-23SS</summary>
    Asr23ss = 8816,
    /// <summary>Arabel</summary>
    Arabel = 8818,
    Value8819 = 8819,
    Value8820 = 8820,
    /// <summary>9K114 Shturm MG</summary>
    Value9k114ShturmMg = 8824,
    /// <summary>ASTOR</summary>
    Astor = 8825,
    /// <summary>ASTRA RCI</summary>
    AstraRci = 8826,
    /// <summary>ATCR-22</summary>
    Atcr22 = 8830,
    /// <summary>ATCR-22 M</summary>
    Atcr22M = 8831,
    /// <summary>ATCR-2T</summary>
    Atcr2t = 8832,
    /// <summary>ATCR-33</summary>
    Atcr33 = 8840,
    /// <summary>ATCR 33 K/M</summary>
    Atcr33KM = 8845,
    /// <summary>ATCR-33S</summary>
    Atcr33s = 8846,
    /// <summary>ATCR-3T</summary>
    Atcr3t = 8847,
    /// <summary>ATCR-44</summary>
    Atcr44 = 8848,
    /// <summary>ATCR-44 K</summary>
    Atcr44K = 8849,
    Value8850 = 8850,
    /// <summary>ATCR-44 M/S</summary>
    Atcr44MS = 8851,
    /// <summary>ATCR-4T</summary>
    Atcr4t = 8852,
    Value8865 = 8865,
    /// <summary>ATLAS-8600X</summary>
    Atlas8600x = 8866,
    /// <summary>Atlas-9600M</summary>
    Atlas9600m = 8867,
    /// <summary>ATLAS-9600X</summary>
    Atlas9600x = 8868,
    /// <summary>ATLAS-9600S</summary>
    Atlas9600s = 8869,
    /// <summary>ATLAS-9740 VTS</summary>
    Atlas9740Vts = 8870,
    /// <summary>ATLASS</summary>
    Atlass = 8871,
    /// <summary>ATR-500C</summary>
    Atr500c = 8880,
    /// <summary>AVG 65</summary>
    Avg65 = 8910,
    /// <summary>AVH 7</summary>
    Avh7 = 8955,
    /// <summary>AVIA CM</summary>
    AviaCm = 8980,
    /// <summary>AVIA D</summary>
    AviaD = 8985,
    Value8990 = 8990,
    Value8993 = 8993,
    Value8995 = 8995,
    /// <summary>AVQ 20</summary>
    Avq20 = 9000,
    /// <summary>AVQ-21</summary>
    Avq21 = 9005,
    /// <summary>AVQ30X</summary>
    Avq30x = 9045,
    /// <summary>AVQ-50 (RCA)</summary>
    Avq50Rca = 9075,
    /// <summary>AVQ 70</summary>
    Avq70 = 9090,
    /// <summary>AWS 5</summary>
    Aws5 = 9135,
    /// <summary>AWS 6</summary>
    Aws6 = 9180,
    /// <summary>AWS-6B/300</summary>
    Aws6b300 = 9185,
    /// <summary>B597Z</summary>
    B597z = 9200,
    /// <summary>B636Z</summary>
    B636z = 9205,
    Value9215 = 9215,
    Value9225 = 9225,
    Value9270 = 9270,
    Value9280 = 9280,
    /// <summary>BAES DASS-2000 Jammer</summary>
    BaesDass2000Jammer = 9281,
    /// <summary>Balance Beam</summary>
    BalanceBeam = 9285,
    /// <summary>BALTIKA-B</summary>
    BaltikaB = 9300,
    /// <summary>BALTYK</summary>
    Baltyk = 9310,
    Value9315 = 9315,
    Value9360 = 9360,
    Value9370 = 9370,
    Value9405 = 9405,
    Value9406 = 9406,
    /// <summary>P-35/37 ("A"); P-50 ("B")</summary>
    P3537AP50B = 9450,
    /// <summary>BARAX</summary>
    Barax = 9475,
    /// <summary>BASIR-110D</summary>
    Basir110d = 9485,
    Value9495 = 9495,
    /// <summary>Badger</summary>
    Badger = 9505,
    /// <summary>Barracuda Jammer</summary>
    BarracudaJammer = 9510,
    /// <summary>Bavar-373 TTR</summary>
    Bavar373Ttr = 9511,
    /// <summary>Bavar-373 TAR</summary>
    Bavar373Tar = 9512,
    /// <summary>Bavar-373 TELAR TER</summary>
    Bavar373TelarTer = 9520,
    /// <summary>Baykal Countermeasures Suite</summary>
    BaykalCountermeasuresSuite = 9530,
    Value9540 = 9540,
    Value9585 = 9585,
    Value9630 = 9630,
    /// <summary>Bell Nip Jammer</summary>
    BellNipJammer = 9638,
    /// <summary>Bell Push Jammer</summary>
    BellPushJammer = 9639,
    Value9640 = 9640,
    Value9642 = 9642,
    Value9643 = 9643,
    Value9645 = 9645,
    Value9659 = 9659,
    Value9660 = 9660,
    Value9661 = 9661,
    Value9662 = 9662,
    Value9675 = 9675,
    Value9720 = 9720,
    Value9765 = 9765,
    Value9775 = 9775,
    /// <summary>SNAR-10</summary>
    Snar10 = 9780,
    Value9781 = 9781,
    Value9810 = 9810,
    Value9855 = 9855,
    Value9875 = 9875,
    /// <summary>9S15MT</summary>
    Value9s15mt = 9885,
    Value9900 = 9900,
    /// <summary>BLIGHTER 400</summary>
    Blighter400 = 9903,
    /// <summary>Blowpipe MG</summary>
    BlowpipeMg = 9905,
    /// <summary>BLR</summary>
    Blr = 9920,
    /// <summary>Blue Fox</summary>
    BlueFox = 9930,
    /// <summary>Blue Kestrel</summary>
    BlueKestrel = 9933,
    /// <summary>Blue Vixen</summary>
    BlueVixen = 9935,
    /// <summary>Blue Silk</summary>
    BlueSilk = 9945,
    /// <summary>Blue Parrot</summary>
    BlueParrot = 9990,
    /// <summary>Blue Orchid</summary>
    BlueOrchid = 10035,
    /// <summary>BM/DJG-8715</summary>
    BmDjg8715 = 10057,
    Value10080 = 10080,
    /// <summary>BOR-A 550</summary>
    BorA550 = 10090,
    Value10125 = 10125,
    Value10170 = 10170,
    Value10215 = 10215,
    Value10260 = 10260,
    Value10305 = 10305,
    /// <summary>BM/KG300G Jamming Pod</summary>
    BmKg300gJammingPod = 10308,
    /// <summary>BM KG600 Jamming Pod</summary>
    BmKg600JammingPod = 10310,
    /// <summary>BM KG800 Jamming Pod</summary>
    BmKg800JammingPod = 10312,
    /// <summary>BM/KG 8601/8605/8606</summary>
    BmKg860186058606 = 10315,
    /// <summary>BPS 11A</summary>
    Bps11a = 10350,
    /// <summary>BPS 14</summary>
    Bps14 = 10395,
    /// <summary>BPS 15A</summary>
    Bps15a = 10440,
    /// <summary>BR-3440CA-X57</summary>
    Br3440caX57 = 10450,
    /// <summary>BR-15 Tokyo KEIKI</summary>
    Br15TokyoKeiki = 10485,
    /// <summary>BrahMos</summary>
    BrahMos = 10500,
    Value10510 = 10510,
    Value10511 = 10511,
    Value10512 = 10512,
    Value10513 = 10513,
    /// <summary>Brimstone mmW MH</summary>
    BrimstoneMmWMh = 10520,
    Value10530 = 10530,
    /// <summary>Asr</summary>
    Asr = 10540,
    /// <summary>BT 271</summary>
    Bt271 = 10575,
    /// <summary>BU-304</summary>
    Bu304 = 10595,
    /// <summary>BX 732</summary>
    Bx732 = 10620,
    /// <summary>BUK-MB</summary>
    BukMb = 10630,
    /// <summary>Buran-D</summary>
    BuranD = 10642,
    /// <summary>BUREVISNYK-1</summary>
    Burevisnyk1 = 10650,
    Value10665 = 10665,
    /// <summary>C 5A Multi Mode Radar</summary>
    C5aMultiModeRadar = 10710,
    /// <summary>C-802 AL</summary>
    C802Al = 10711,
    Value10740 = 10740,
    /// <summary>Caiman</summary>
    Caiman = 10755,
    Value10800 = 10800,
    /// <summary>Calypso C61</summary>
    CalypsoC61 = 10845,
    /// <summary>Calypso C63</summary>
    CalypsoC63 = 10846,
    /// <summary>Calypso Ii</summary>
    CalypsoIi = 10890,
    /// <summary>Calypso III</summary>
    CalypsoIii = 10891,
    /// <summary>Calypso IV</summary>
    CalypsoIv = 10892,
    Value10895 = 10895,
    /// <summary>Castor Ii</summary>
    CastorIi = 10935,
    /// <summary>Castor 2J TT (Crotale NG)</summary>
    Castor2jTtCrotaleNg = 10940,
    Value10980 = 10980,
    /// <summary>CDR-431</summary>
    Cdr431 = 10985,
    /// <summary>CEAFAR</summary>
    Ceafar = 10987,
    /// <summary>CEAMOUNT</summary>
    Ceamount = 10988,
    /// <summary>CEAFAR2-L</summary>
    Ceafar2L = 10989,
    /// <summary>CEROS 200</summary>
    Ceros200 = 10990,
    /// <summary>CEROS 200 CWI</summary>
    Ceros200Cwi = 10991,
    /// <summary>CEATAC</summary>
    Ceatac = 10992,
    /// <summary>CEAOPS</summary>
    Ceaops = 10993,
    /// <summary>Cerberus III</summary>
    CerberusIii = 10994,
    /// <summary>CH/SS-N-6</summary>
    ChSsN6 = 10995,
    /// <summary>Cerberus IV</summary>
    CerberusIv = 10996,
    Value11000 = 11000,
    Value11010 = 11010,
    /// <summary>LEMZ 96L6</summary>
    Lemz96l6 = 11020,
    Value11025 = 11025,
    Value11030 = 11030,
    Value11060 = 11060,
    /// <summary>Leninetz Obzor MS</summary>
    LeninetzObzorMs = 11070,
    Value11115 = 11115,
    /// <summary>CLC-1 TER</summary>
    Clc1Ter = 11117,
    /// <summary>CLC-2 TAR</summary>
    Clc2Tar = 11118,
    /// <summary>CLC-3 TAR</summary>
    Clc3Tar = 11119,
    /// <summary>CLR-155</summary>
    Clr155 = 11120,
    /// <summary>COAST WATCHER 100</summary>
    CoastWatcher100 = 11123,
    /// <summary>Coastal Giraffe</summary>
    CoastalGiraffe = 11125,
    /// <summary>COBRA</summary>
    Cobra = 11130,
    /// <summary>Cobra Shoe</summary>
    CobraShoe = 11133,
    /// <summary>Colibri</summary>
    Colibri = 11137,
    Value11155 = 11155,
    Value11160 = 11160,
    /// <summary>Collins TWR-850</summary>
    CollinsTwr850 = 11165,
    Value11205 = 11205,
    Value11230 = 11230,
    /// <summary>CONDOR MK 2</summary>
    CondorMk2 = 11235,
    Value11240 = 11240,
    Value11250 = 11250,
    Value11260 = 11260,
    /// <summary>COSMO SKYMED-1</summary>
    CosmoSkymed1 = 11265,
    /// <summary>CR-105 RMCA</summary>
    Cr105Rmca = 11270,
    /// <summary>CREW Duke 2</summary>
    CrewDuke2 = 11280,
    /// <summary>CREW Duke 3</summary>
    CrewDuke3 = 11290,
    Value11295 = 11295,
    Value11340 = 11340,
    Value11385 = 11385,
    Value11430 = 11430,
    Value11475 = 11475,
    Value11520 = 11520,
    Value11565 = 11565,
    Value11610 = 11610,
    /// <summary>Crotale Acquisition TA</summary>
    CrotaleAcquisitionTa = 11655,
    /// <summary>Crotale NG TA</summary>
    CrotaleNgTa = 11660,
    /// <summary>Crotale TT</summary>
    CrotaleTt = 11665,
    /// <summary>Crotale MGMissile System</summary>
    CrotaleMGMissileSystem = 11700,
    Value11705 = 11705,
    Value11706 = 11706,
    Value11707 = 11707,
    Value11708 = 11708,
    Value11709 = 11709,
    Value11710 = 11710,
    Value11711 = 11711,
    Value11712 = 11712,
    /// <summary>CS-10-TA</summary>
    Cs10Ta = 11715,
    Value11717 = 11717,
    Value11718 = 11718,
    Value11719 = 11719,
    Value11720 = 11720,
    Value11724 = 11724,
    /// <summary>CSF-Varan</summary>
    CsfVaran = 11725,
    Value11735 = 11735,
    /// <summary>CSS C 3C CAS 1M1 M2 MH</summary>
    CssC3cCas1m1M2Mh = 11745,
    /// <summary>HY-2B MH</summary>
    Hy2bMh = 11748,
    /// <summary>CSS C 2B HY 1A MH</summary>
    CssC2bHy1aMh = 11790,
    /// <summary>CSS-N-4 Sardine</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    CssN4Sardine = 11800,
    Value11810 = 11810,
    Value11825 = 11825,
    /// <summary>CWS-1</summary>
    Cws1 = 11830,
    /// <summary>CWS 2</summary>
    Cws2 = 11835,
    /// <summary>CWS-3</summary>
    Cws3 = 11840,
    Value11860 = 11860,
    Value11880 = 11880,
    /// <summary>Cymbeline</summary>
    Cymbeline = 11902,
    /// <summary>Cyrano II</summary>
    CyranoIi = 11925,
    /// <summary>Cyrano IV</summary>
    CyranoIv = 11970,
    /// <summary>Cyrano IV-M</summary>
    CyranoIvM = 11975,
    /// <summary>DA-01/00</summary>
    Da0100 = 12010,
    /// <summary>DA 05 00</summary>
    Da0500 = 12015,
    /// <summary>DA-05/2</summary>
    Da052 = 12016,
    /// <summary>DA.08</summary>
    Da08 = 12018,
    Value12060 = 12060,
    /// <summary>DCR</summary>
    Dcr = 12090,
    Value12105 = 12105,
    Value12110 = 12110,
    Value12111 = 12111,
    Value12150 = 12150,
    Value12195 = 12195,
    Value12196 = 12196,
    /// <summary>Decca 72</summary>
    Decca72 = 12197,
    Value12240 = 12240,
    Value12285 = 12285,
    Value12292 = 12292,
    Value12330 = 12330,
    Value12375 = 12375,
    Value12420 = 12420,
    Value12430 = 12430,
    Value12465 = 12465,
    Value12510 = 12510,
    Value12555 = 12555,
    Value12600 = 12600,
    Value12610 = 12610,
    Value12615 = 12615,
    Value12616 = 12616,
    Value12645 = 12645,
    Value12655 = 12655,
    Value12690 = 12690,
    Value12691 = 12691,
    Value12694 = 12694,
    Value12735 = 12735,
    Value12780 = 12780,
    Value12782 = 12782,
    Value12785 = 12785,
    Value12787 = 12787,
    Value12800 = 12800,
    Value12805 = 12805,
    Value12825 = 12825,
    /// <summary>DECCA RM 970BT</summary>
    DeccaRm970bt = 12850,
    Value12870 = 12870,
    /// <summary>DF-21D Seeker</summary>
    Df21dSeeker = 12875,
    Value12915 = 12915,
    Value12916 = 12916,
    Value12960 = 12960,
    /// <summary>DISS 1</summary>
    Diss1 = 13005,
    /// <summary>DISS-7</summary>
    Diss7 = 13006,
    /// <summary>DISS-013</summary>
    Diss013 = 13007,
    /// <summary>DISS-15D</summary>
    Diss15d = 13015,
    /// <summary>DLD-100A</summary>
    Dld100a = 13020,
    /// <summary>Rapier TTDN 181</summary>
    RapierTtdn181 = 13050,
    /// <summary>Rapier 2000 TT</summary>
    Rapier2000Tt = 13055,
    Value13095 = 13095,
    Value13140 = 13140,
    /// <summary>DM3</summary>
    Dm3 = 13141,
    /// <summary>DM-3B</summary>
    Dm3b = 13142,
    /// <summary>DM-5</summary>
    Dm5 = 13143,
    /// <summary>Don 2</summary>
    Don2 = 13185,
    Value13230 = 13230,
    Value13275 = 13275,
    Value13280 = 13280,
    Value13320 = 13320,
    /// <summary>DR-582</summary>
    Dr582 = 13360,
    /// <summary>DRAA 2A</summary>
    Draa2a = 13365,
    /// <summary>DRAA 2B</summary>
    Draa2b = 13410,
    /// <summary>DRAA 9A</summary>
    Draa9a = 13415,
    /// <summary>DRAA 11A</summary>
    Draa11a = 13420,
    /// <summary>DRAC 37B</summary>
    Drac37b = 13450,
    /// <summary>DRAC 38</summary>
    Drac38 = 13452,
    /// <summary>DRAC 39</summary>
    Drac39 = 13455,
    /// <summary>DRAC 39A</summary>
    Drac39a = 13456,
    /// <summary>DRAC 43A</summary>
    Drac43a = 13460,
    /// <summary>DRAC 44A</summary>
    Drac44a = 13465,
    Value13477 = 13477,
    Value13480 = 13480,
    Value13481 = 13481,
    Value13485 = 13485,
    /// <summary>DRBC 30B</summary>
    Drbc30b = 13500,
    /// <summary>DRBC 31A</summary>
    Drbc31a = 13545,
    /// <summary>DRBC-31D</summary>
    Drbc31d = 13546,
    /// <summary>DRBC-32</summary>
    Drbc32 = 13585,
    /// <summary>DRBC 32A</summary>
    Drbc32a = 13590,
    /// <summary>DRBC 32D</summary>
    Drbc32d = 13635,
    /// <summary>DRBC 33A</summary>
    Drbc33a = 13680,
    /// <summary>DRBI 10</summary>
    Drbi10 = 13725,
    /// <summary>DRBI 23</summary>
    Drbi23 = 13770,
    /// <summary>DRBJ 11B</summary>
    Drbj11b = 13815,
    /// <summary>DRBN 30</summary>
    Drbn30 = 13860,
    /// <summary>DRBN 32</summary>
    Drbn32 = 13905,
    /// <summary>DRBN 34</summary>
    Drbn34 = 13915,
    /// <summary>DRBR 51</summary>
    Drbr51 = 13950,
    /// <summary>DRBV-20A</summary>
    Drbv20a = 13994,
    /// <summary>DRBV 20B</summary>
    Drbv20b = 13995,
    /// <summary>DRBV-21 Mars 05</summary>
    Drbv21Mars05 = 14020,
    /// <summary>DRBV 22</summary>
    Drbv22 = 14040,
    /// <summary>DRBV-23</summary>
    Drbv23 = 14041,
    /// <summary>DRBV 26C</summary>
    Drbv26c = 14085,
    /// <summary>DRBV 26D</summary>
    Drbv26d = 14086,
    /// <summary>DRBV 30</summary>
    Drbv30 = 14130,
    /// <summary>DRBV-31</summary>
    Drbv31 = 14131,
    /// <summary>DRBV 50</summary>
    Drbv50 = 14175,
    /// <summary>DRBV 51</summary>
    Drbv51 = 14220,
    /// <summary>DRBV 51A</summary>
    Drbv51a = 14265,
    /// <summary>DRBV 51B</summary>
    Drbv51b = 14310,
    /// <summary>DRBV 51C</summary>
    Drbv51c = 14355,
    /// <summary>Drop Kick</summary>
    DropKick = 14400,
    /// <summary>DRUA 31</summary>
    Drua31 = 14445,
    Value14490 = 14490,
    Value14535 = 14535,
    Value14545 = 14545,
    /// <summary>DRUN 30A</summary>
    Drun30a = 14560,
    Value14580 = 14580,
    /// <summary>DWSR-92</summary>
    Dwsr92 = 14583,
    /// <summary>DWSR-93S</summary>
    Dwsr93s = 14585,
    /// <summary>EAGLE</summary>
    Eagle = 14586,
    /// <summary>EAGLE Mk 1</summary>
    EagleMk1 = 14587,
    /// <summary>EAJP Jamming Pod</summary>
    EajpJammingPod = 14588,
    /// <summary>EKCO E390</summary>
    EkcoE390 = 14590,
    /// <summary>ECR-90</summary>
    Ecr90 = 14600,
    /// <summary>ECR-90 Jammer</summary>
    Ecr90Jammer = 14601,
    Value14625 = 14625,
    /// <summary>EISCAT</summary>
    Eiscat = 14640,
    /// <summary>EKCO E120</summary>
    EkcoE120 = 14660,
    /// <summary>EKCO 190</summary>
    Ekco190 = 14670,
    /// <summary>Ekran-1</summary>
    Ekran1 = 14677,
    /// <summary>EL/L-8222</summary>
    ElL8222 = 14710,
    Value14713 = 14713,
    /// <summary>EL M 2001B</summary>
    ElM2001b = 14715,
    /// <summary>EL/M-2022</summary>
    ElM2022 = 14725,
    /// <summary>EL/M-2032</summary>
    ElM2032 = 14726,
    /// <summary>EL/M-2052</summary>
    ElM2052 = 14727,
    /// <summary>EL/M-2055</summary>
    ElM2055 = 14728,
    /// <summary>EL/M-2060</summary>
    ElM2060 = 14730,
    /// <summary>EL/M-2075</summary>
    ElM2075 = 14735,
    /// <summary>EL/M-2022U(V)3</summary>
    ElM2022uV3 = 14736,
    /// <summary>EL/M-2080</summary>
    ElM2080 = 14737,
    /// <summary>EL/M-2080S</summary>
    ElM2080s = 14738,
    /// <summary>EL/M-2085</summary>
    ElM2085 = 14739,
    /// <summary>EL/M-2106</summary>
    ElM2106 = 14740,
    /// <summary>EL/M-2106NG</summary>
    ElM2106ng = 14741,
    /// <summary>EL/M-2125</summary>
    ElM2125 = 14742,
    /// <summary>EL/M-2129</summary>
    ElM2129 = 14743,
    /// <summary>EL/M-2150</summary>
    ElM2150 = 14744,
    /// <summary>EL/M-2083</summary>
    ElM2083 = 14745,
    /// <summary>EL/M-2084</summary>
    ElM2084 = 14746,
    /// <summary>EL/M-2160-V1</summary>
    ElM2160V1 = 14747,
    /// <summary>EL/M-2084 MMR</summary>
    ElM2084Mmr = 14748,
    /// <summary>EL/M-2112</summary>
    ElM2112 = 14749,
    /// <summary>EL/M-2200</summary>
    ElM2200 = 14750,
    /// <summary>EL/M-2133</summary>
    ElM2133 = 14751,
    /// <summary>EL/M-2205</summary>
    ElM2205 = 14755,
    /// <summary>EL M 2207</summary>
    ElM2207 = 14760,
    /// <summary>EL/M-2215</summary>
    ElM2215 = 14765,
    Value14770 = 14770,
    /// <summary>EL/M-2216XH</summary>
    ElM2216xh = 14772,
    /// <summary>EL/M-2218S</summary>
    ElM2218s = 14775,
    /// <summary>ELT-361</summary>
    Elt361 = 14776,
    /// <summary>EL/M-2258</summary>
    ElM2258 = 14777,
    /// <summary>ELT-553</summary>
    Elt553 = 14779,
    /// <summary>ELT-558</summary>
    Elt558 = 14780,
    /// <summary>ELT-572</summary>
    Elt572 = 14785,
    /// <summary>ELT 715</summary>
    Elt715 = 14790,
    /// <summary>Elta ELM 2022A</summary>
    EltaElm2022a = 14800,
    /// <summary>ELTA EL/M 2221 GM STGR</summary>
    EltaElM2221GmStgr = 14805,
    /// <summary>EL/M-2228S/3D</summary>
    ElM2228s3d = 14806,
    /// <summary>EL/M-2705</summary>
    ElM2705 = 14807,
    /// <summary>EL/M-2226</summary>
    ElM2226 = 14808,
    /// <summary>EL/M-2228X</summary>
    ElM2228x = 14809,
    /// <summary>ELTA SIS</summary>
    EltaSis = 14810,
    /// <summary>EL/M-2238</summary>
    ElM2238 = 14811,
    /// <summary>EL/M-2248</summary>
    ElM2248 = 14815,
    /// <summary>EL/M-2288</summary>
    ElM2288 = 14820,
    /// <summary>EL/M-2311</summary>
    ElM2311 = 14821,
    /// <summary>ELM-2026</summary>
    Elm2026 = 14822,
    Value14830 = 14830,
    /// <summary>ELT/318</summary>
    Elt318 = 14831,
    /// <summary>ELW-2085</summary>
    Elw2085 = 14832,
    /// <summary>ELT/521</summary>
    Elt521 = 14833,
    /// <summary>ELW-2090</summary>
    Elw2090 = 14835,
    Value14845 = 14845,
    /// <summary>EMD 2900</summary>
    Emd2900 = 14850,
    /// <summary>EMPAR</summary>
    Empar = 14851,
    Value14895 = 14895,
    /// <summary>EQ-36</summary>
    Eq36 = 14896,
    /// <summary>Ericsson SLAR</summary>
    EricssonSlar = 14897,
    /// <summary>Erieye</summary>
    Erieye = 14898,
    Value14899 = 14899,
    /// <summary>ESR 1</summary>
    Esr1 = 14900,
    /// <summary>ESR 220</summary>
    Esr220 = 14901,
    /// <summary>ESR380</summary>
    Esr380 = 14902,
    /// <summary>ESTEREL</summary>
    Esterel = 14903,
    /// <summary>ET-316</summary>
    Et316 = 14905,
    /// <summary>Exocet Type</summary>
    ExocetType = 14935,
    /// <summary>Exocet AL</summary>
    ExocetAl = 14936,
    /// <summary>Exocet 1</summary>
    Exocet1 = 14940,
    /// <summary>Exocet 1 MH</summary>
    Exocet1Mh = 14985,
    /// <summary>Exocet 2</summary>
    Exocet2 = 15030,
    Value15075 = 15075,
    Value15120 = 15120,
    Value15140 = 15140,
    Value15155 = 15155,
    Value15156 = 15156,
    /// <summary>FALCON</summary>
    Falcon = 15160,
    /// <summary>FALCON-G</summary>
    FalconG = 15161,
    Value15163 = 15163,
    Value15165 = 15165,
    Value15200 = 15200,
    Value15210 = 15210,
    Value15220 = 15220,
    Value15230 = 15230,
    Value15240 = 15240,
    Value15255 = 15255,
    Value15300 = 15300,
    /// <summary>FAR-2117</summary>
    Far2117 = 15301,
    /// <summary>FAR-2827</summary>
    Far2827 = 15302,
    /// <summary>FAR-2837S</summary>
    Far2837s = 15303,
    Value15304 = 15304,
    /// <summary>FB-7 Radar</summary>
    Fb7Radar = 15305,
    /// <summary>FCR-1401</summary>
    Fcr1401 = 15310,
    /// <summary>FCS-2-12E</summary>
    Fcs212e = 15312,
    /// <summary>FCS-2-12G</summary>
    Fcs212g = 15313,
    /// <summary>FCS-2-21A</summary>
    Fcs221a = 15315,
    /// <summary>FCS-2-21C</summary>
    Fcs221c = 15317,
    /// <summary>FCS-2-22</summary>
    Fcs222 = 15318,
    /// <summary>FCS-2-31</summary>
    Fcs231 = 15319,
    /// <summary>FCS-3</summary>
    Fcs3 = 15320,
    Value15345 = 15345,
    Value15390 = 15390,
    Value15435 = 15435,
    Value15470 = 15470,
    Value15475 = 15475,
    Value15480 = 15480,
    Value15525 = 15525,
    Value15565 = 15565,
    Value15570 = 15570,
    Value15615 = 15615,
    /// <summary>FK-3</summary>
    Fk3 = 15620,
    /// <summary>FLAIR</summary>
    Flair = 15650,
    /// <summary>30N6E</summary>
    Value30n6e = 15660,
    /// <summary>30N6E</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Value30n6e15661 = 15661,
    Value15705 = 15705,
    Value15750 = 15750,
    Value15795 = 15795,
    Value15800 = 15800,
    /// <summary>P-15</summary>
    P15 = 15840,
    /// <summary>35N6</summary>
    Value35n6 = 15842,
    Value15885 = 15885,
    Value15930 = 15930,
    /// <summary>Flat Track Jammer</summary>
    FlatTrackJammer = 15970,
    Value15975 = 15975,
    /// <summary>FL-400</summary>
    Fl400 = 15980,
    /// <summary>FL 1800</summary>
    Fl1800 = 15985,
    /// <summary>FL 1800U</summary>
    Fl1800u = 15990,
    /// <summary>FL 1800S</summary>
    Fl1800s = 16000,
    /// <summary>Fledermaus</summary>
    Fledermaus = 16020,
    Value16030 = 16030,
    /// <summary>FLYCATCHER MK 2</summary>
    FlycatcherMk2 = 16035,
    Value16065 = 16065,
    Value16110 = 16110,
    Value16155 = 16155,
    /// <summary>FM-90</summary>
    Fm90 = 16160,
    Value16200 = 16200,
    Value16245 = 16245,
    Value16290 = 16290,
    /// <summary>FootBall</summary>
    FootBall = 16300,
    /// <summary>Fox Hunter</summary>
    FoxHunter = 16335,
    Value16380 = 16380,
    Value16390 = 16390,
    Value16395 = 16395,
    /// <summary>FR-151A</summary>
    Fr151a = 16400,
    Value16405 = 16405,
    /// <summary>FR-1505 DA</summary>
    Fr1505Da = 16410,
    /// <summary>FR-1510DS</summary>
    Fr1510ds = 16412,
    /// <summary>FR-2000</summary>
    Fr2000 = 16420,
    /// <summary>Furuno-2855W</summary>
    Furuno2855w = 16421,
    Value16422 = 16422,
    Value16423 = 16423,
    Value16424 = 16424,
    Value16425 = 16425,
    /// <summary>Fregat MAE-5</summary>
    FregatMae5 = 16426,
    Value16470 = 16470,
    Value16515 = 16515,
    /// <summary>Furby mmW MH</summary>
    FurbyMmWMh = 16520,
    Value16550 = 16550,
    /// <summary>Furke 2 (Furke-E, Positiv-ME1)</summary>
    Furke2FurkeEPositivMe1 = 16552,
    /// <summary>Furke-4</summary>
    Furke4 = 16554,
    /// <summary>Furuno</summary>
    Furuno = 16560,
    /// <summary>Furuno 1721</summary>
    Furuno1721 = 16561,
    Value16564 = 16564,
    Value16565 = 16565,
    /// <summary>Furuno 1730</summary>
    Furuno1730 = 16580,
    /// <summary>Furuno 1731 Mark 3</summary>
    Furuno1731Mark3 = 16581,
    /// <summary>Furuno 1832</summary>
    Furuno1832 = 16585,
    Value16587 = 16587,
    /// <summary>Furuno 1932</summary>
    Furuno1932 = 16590,
    Value16596 = 16596,
    /// <summary>Furuno 701</summary>
    Furuno701 = 16605,
    /// <summary>Furuno 1940</summary>
    Furuno1940 = 16606,
    /// <summary>Furuno 711 2</summary>
    Furuno7112 = 16650,
    Value16652 = 16652,
    /// <summary>Furuno FAR-2137S</summary>
    FurunoFar2137s = 16654,
    /// <summary>Furuno FAR-28X7</summary>
    FurunoFar28x7 = 16655,
    Value16658 = 16658,
    /// <summary>FR-2110</summary>
    Fr2110 = 16660,
    /// <summary>FR-2115</summary>
    Fr2115 = 16662,
    /// <summary>FR-8062</summary>
    Fr8062 = 16663,
    /// <summary>Furuno 2125</summary>
    Furuno2125 = 16670,
    /// <summary>Furuno 240</summary>
    Furuno240 = 16690,
    /// <summary>Furuno 2400</summary>
    Furuno2400 = 16695,
    /// <summary>FR-801D</summary>
    Fr801d = 16725,
    /// <summary>Furuno 8051</summary>
    Furuno8051 = 16730,
    Value16732 = 16732,
    Value16733 = 16733,
    Value16734 = 16734,
    /// <summary>G030A(APD-31)</summary>
    G030aApd31 = 16735,
    Value16736 = 16736,
    Value16737 = 16737,
    /// <summary>GA 01 00</summary>
    Ga0100 = 16740,
    /// <summary>Gabbiano</summary>
    Gabbiano = 16750,
    Value16785 = 16785,
    /// <summary>Gaofen-3</summary>
    Gaofen3 = 16787,
    /// <summary>GAOFEN-12</summary>
    Gaofen12 = 16789,
    /// <summary>GAP GATE</summary>
    GapGate = 16790,
    Value16800 = 16800,
    Value16815 = 16815,
    Value16820 = 16820,
    /// <summary>Garmin GWX 68 Weather Radar</summary>
    GarminGwx68WeatherRadar = 16825,
    Value16830 = 16830,
    /// <summary>JY-14M</summary>
    Jy14m = 16833,
    /// <summary>Garpun-Bal-E</summary>
    GarpunBalE = 16835,
    /// <summary>Gazetchik</summary>
    Gazetchik = 16837,
    /// <summary>GBS1</summary>
    Gbs1 = 16840,
    /// <summary>GCA-2000</summary>
    Gca2000 = 16850,
    Value16858 = 16858,
    Value16870 = 16870,
    Value16871 = 16871,
    Value16872 = 16872,
    /// <summary>GEM BX 132</summary>
    GemBx132 = 16875,
    /// <summary>GEM SC-2050X</summary>
    GemSc2050x = 16876,
    Value16877 = 16877,
    Value16879 = 16879,
    /// <summary>MPDR-12</summary>
    Mpdr12 = 16880,
    /// <summary>GEN-X</summary>
    GenX = 16881,
    Value16884 = 16884,
    /// <summary>GERAN-F</summary>
    GeranF = 16888,
    /// <summary>GERFAUT</summary>
    Gerfaut = 16890,
    /// <summary>GFE(L)1</summary>
    GfeL1 = 16895,
    /// <summary>GIRAFFE</summary>
    Giraffe = 16900,
    /// <summary>GIRAFFE 1X</summary>
    Giraffe1x = 16903,
    /// <summary>Giraffe-40</summary>
    Giraffe40 = 16905,
    /// <summary>Giraffe-50 AT</summary>
    Giraffe50At = 16908,
    /// <summary>Giraffe 75</summary>
    Giraffe75 = 16912,
    Value16915 = 16915,
    /// <summary>Gin Sling</summary>
    GinSling = 16920,
    Value16925 = 16925,
    /// <summary>Goal Keeper</summary>
    GoalKeeper = 16930,
    Value16935 = 16935,
    Value16940 = 16940,
    Value16942 = 16942,
    Value16943 = 16943,
    /// <summary>GPN-22</summary>
    Gpn22 = 16945,
    /// <summary>GPSJ-10</summary>
    Gpsj10 = 16946,
    /// <summary>GPSJ-25</summary>
    Gpsj25 = 16947,
    /// <summary>GPSJ-40</summary>
    Gpsj40 = 16948,
    /// <summary>GPSJ-50</summary>
    Gpsj50 = 16949,
    /// <summary>GRN-9</summary>
    Grn9 = 16950,
    /// <summary>GRAN-K</summary>
    GranK = 16951,
    Value16953 = 16953,
    Value16958 = 16958,
    Value16960 = 16960,
    /// <summary>GRAVES</summary>
    Graves = 16963,
    /// <summary>Green Stain</summary>
    GreenStain = 16965,
    /// <summary>40N6 Seeker</summary>
    Value40n6Seeker = 16970,
    Value17010 = 17010,
    /// <summary>Grifo-F</summary>
    GrifoF = 17016,
    Value17018 = 17018,
    /// <summary>9S32</summary>
    Value9s32 = 17025,
    Value17027 = 17027,
    /// <summary>Grom-2</summary>
    Grom2 = 17029,
    /// <summary>GROUND MASTER 400</summary>
    GroundMaster400 = 17030,
    /// <summary>GT-4</summary>
    Gt4 = 17031,
    /// <summary>GRS 440</summary>
    Grs440 = 17032,
    Value17034 = 17034,
    /// <summary>GUARDIAN</summary>
    Guardian = 17050,
    /// <summary>Guardsman</summary>
    Guardsman = 17055,
    /// <summary>RPK-2</summary>
    Rpk2 = 17070,
    Value17072 = 17072,
    /// <summary>H/RJZ-726-4A Jammer</summary>
    HRjz7264aJammer = 17075,
    /// <summary>H025 (NO25E)</summary>
    H025No25e = 17079,
    /// <summary>HADR</summary>
    Hadr = 17080,
    Value17100 = 17100,
    Value17145 = 17145,
    Value17190 = 17190,
    /// <summary>HARD</summary>
    Hard = 17220,
    /// <summary>Harpoon</summary>
    Harpoon = 17225,
    Value17230 = 17230,
    Value17235 = 17235,
    Value17250 = 17250,
    Value17255 = 17255,
    Value17280 = 17280,
    Value17325 = 17325,
    Value17370 = 17370,
    Value17415 = 17415,
    Value17460 = 17460,
    Value17505 = 17505,
    Value17550 = 17550,
    Value17572 = 17572,
    /// <summary>Hellfire mmW MH</summary>
    HellfireMmWMh = 17590,
    Value17595 = 17595,
    Value17640 = 17640,
    Value17685 = 17685,
    Value17730 = 17730,
    Value17732 = 17732,
    /// <summary>HF-2 MG</summary>
    Hf2Mg = 17735,
    /// <summary>HGR-105</summary>
    Hgr105 = 17745,
    /// <summary>Herz-9 TAR</summary>
    Herz9Tar = 17750,
    /// <summary>Herz-9 TTR</summary>
    Herz9Ttr = 17751,
    /// <summary>Herz-9 MG</summary>
    Herz9Mg = 17752,
    Value17775 = 17775,
    Value17820 = 17820,
    /// <summary>YLC-2V</summary>
    Ylc2v = 17842,
    Value17865 = 17865,
    Value17910 = 17910,
    Value17955 = 17955,
    Value18000 = 18000,
    Value18045 = 18045,
    Value18090 = 18090,
    Value18135 = 18135,
    /// <summary>9S19MT</summary>
    Value9s19mt = 18150,
    Value18180 = 18180,
    Value18185 = 18185,
    /// <summary>Himalayas Countermeasures Suite</summary>
    HimalayasCountermeasuresSuite = 18189,
    Value18190 = 18190,
    /// <summary>HJ-6374</summary>
    Hj6374 = 18193,
    Value18194 = 18194,
    /// <summary>HLJQ-520</summary>
    Hljq520 = 18195,
    /// <summary>HN-503</summary>
    Hn503 = 18200,
    /// <summary>HN-C03-M</summary>
    HnC03M = 18201,
    Value18223 = 18223,
    Value18225 = 18225,
    Value18270 = 18270,
    Value18280 = 18280,
    Value18315 = 18315,
    Value18316 = 18316,
    /// <summary>IHS-6</summary>
    Ihs6 = 18318,
    /// <summary>IRL144M</summary>
    Irl144m = 18320,
    /// <summary>IRL144M</summary>
    Irl144m18325 = 18325,
    /// <summary>IRL144M</summary>
    Irl144m18330 = 18330,
    /// <summary>HPS-106</summary>
    Hps106 = 18331,
    /// <summary>HPS-104</summary>
    Hps104 = 18332,
    /// <summary>HQ-9 MH</summary>
    Hq9Mh = 18339,
    Value18340 = 18340,
    /// <summary>HQ-9A TER</summary>
    Hq9aTer = 18342,
    /// <summary>HQ-9B/C TER</summary>
    Hq9bCTer = 18344,
    /// <summary>HQ-9B MH</summary>
    Hq9bMh = 18345,
    /// <summary>HQ-9C MH</summary>
    Hq9cMh = 18346,
    /// <summary>HT-233</summary>
    Ht233 = 18348,
    /// <summary>HQ-61</summary>
    Hq61 = 18350,
    /// <summary>HRJS</summary>
    Hrjs = 18351,
    /// <summary>I-Derby ER</summary>
    IDerbyEr = 18352,
    /// <summary>IBIS-80</summary>
    Ibis80 = 18353,
    /// <summary>IBIS-150</summary>
    Ibis150 = 18355,
    /// <summary>IBIS-200</summary>
    Ibis200 = 18357,
    /// <summary>HQ-16 TER</summary>
    Hq16Ter = 18359,
    /// <summary>IFF MK XII AIMS UPX 29</summary>
    IffMkXiiAimsUpx29 = 18360,
    Value18400 = 18400,
    /// <summary>IFF MK XV</summary>
    IffMkXv = 18405,
    /// <summary>IFF INT</summary>
    IffInt = 18406,
    Value18407 = 18407,
    /// <summary>IFF TRSP</summary>
    IffTrsp = 18408,
    /// <summary>J-MUSIC Elbit Systems Jammer</summary>
    JMusicElbitSystemsJammer = 18409,
    /// <summary>Javelin MG</summary>
    JavelinMg = 18410,
    /// <summary>Igla-1 SLAR</summary>
    Igla1Slar = 18411,
    /// <summary>1L267 (Moskva-1) Jammer</summary>
    Value1l267Moskva1Jammer = 18412,
    Value18415 = 18415,
    Value18417 = 18417,
    Value18419 = 18419,
    /// <summary>J-10B PESA</summary>
    J10bPesa = 18420,
    /// <summary>J-10C AESA</summary>
    J10cAesa = 18421,
    /// <summary>J-11D AESA</summary>
    J11dAesa = 18422,
    /// <summary>J-15D Jammer</summary>
    J15dJammer = 18430,
    /// <summary>J-16D Jammer</summary>
    J16dJammer = 18431,
    /// <summary>JL-10MP</summary>
    Jl10mp = 18443,
    /// <summary>J/ALQ-8</summary>
    JAlq8 = 18445,
    /// <summary>J/FPS-7</summary>
    JFps7 = 18449,
    Value18450 = 18450,
    /// <summary>J/FPS-3</summary>
    JFps3 = 18451,
    /// <summary>JH-10</summary>
    Jh10 = 18452,
    /// <summary>J/MPQ-P7</summary>
    JMpqP7 = 18453,
    /// <summary>JL-7</summary>
    Jl7 = 18454,
    /// <summary>JL-10B</summary>
    Jl10b = 18455,
    /// <summary>JMA 1576</summary>
    Jma1576 = 18456,
    /// <summary>JRC JMA-9252-6CA</summary>
    JrcJma92526ca = 18457,
    /// <summary>JLP-40</summary>
    Jlp40 = 18458,
    /// <summary>JRC JMR-9200 Series X</summary>
    JrcJmr9200SeriesX = 18459,
    /// <summary>JRC-NMD-401</summary>
    JrcNmd401 = 18460,
    /// <summary>JRC JRM 310 MK2</summary>
    JrcJrm310Mk2 = 18461,
    /// <summary>JMA 1596</summary>
    Jma1596 = 18462,
    /// <summary>JN-1104</summary>
    Jn1104 = 18463,
    /// <summary>JMA 7000</summary>
    Jma7000 = 18464,
    /// <summary>JRC JMA 7700</summary>
    JrcJma7700 = 18465,
    /// <summary>JMA 5320</summary>
    Jma5320 = 18466,
    /// <summary>JRC JMR-9210-6XC</summary>
    JrcJmr92106xc = 18467,
    /// <summary>JERS-1</summary>
    Jers1 = 18468,
    /// <summary>JINDALEE</summary>
    Jindalee = 18469,
    /// <summary>JRC JMA-9900 series</summary>
    JrcJma9900Series = 18470,
    /// <summary>JLP-40D</summary>
    Jlp40d = 18471,
    /// <summary>JRC JMA-5300 series</summary>
    JrcJma5300Series = 18475,
    /// <summary>Jupiter</summary>
    Jupiter = 18495,
    /// <summary>Jupiter II</summary>
    JupiterIi = 18540,
    /// <summary>JY-8</summary>
    Jy8 = 18550,
    /// <summary>JY-8A</summary>
    Jy8a = 18551,
    /// <summary>JY-9</summary>
    Jy9 = 18555,
    /// <summary>JY-9 Modified</summary>
    Jy9Modified = 18556,
    /// <summary>JY-11 EW</summary>
    Jy11Ew = 18557,
    /// <summary>JY-14</summary>
    Jy14 = 18560,
    /// <summary>JY-14A</summary>
    Jy14a = 18561,
    /// <summary>JY-16</summary>
    Jy16 = 18565,
    /// <summary>JY-24</summary>
    Jy24 = 18570,
    /// <summary>J/APG-1</summary>
    JApg1 = 18571,
    /// <summary>J/APG-2</summary>
    JApg2 = 18572,
    /// <summary>JY-29</summary>
    Jy29 = 18575,
    /// <summary>JYL-1</summary>
    Jyl1 = 18578,
    /// <summary>JYL-6</summary>
    Jyl6 = 18580,
    /// <summary>JYL-6A</summary>
    Jyl6a = 18582,
    /// <summary>JZ/QF-612</summary>
    JzQf612 = 18583,
    Value18585 = 18585,
    /// <summary>K77M</summary>
    K77m = 18586,
    /// <summary>Kaige</summary>
    Kaige = 18600,
    /// <summary>KALKAN</summary>
    Kalkan = 18610,
    /// <summary>KBP Afganit</summary>
    KbpAfganit = 18611,
    /// <summary>KALKAN II</summary>
    KalkanIi = 18615,
    Value18630 = 18630,
    Value18675 = 18675,
    Value18700 = 18700,
    /// <summary>Kashtan-3 Jamming System</summary>
    Kashtan3JammingSystem = 18710,
    Value18720 = 18720,
    Value18765 = 18765,
    Value18766 = 18766,
    Value18767 = 18767,
    Value18768 = 18768,
    Value18770 = 18770,
    Value18774 = 18774,
    Value18775 = 18775,
    Value18776 = 18776,
    Value18777 = 18777,
    /// <summary>KH Family</summary>
    KhFamily = 18780,
    Value18781 = 18781,
    /// <summary>Kh-38MAE MH</summary>
    Kh38maeMh = 18782,
    /// <summary>KG8605A</summary>
    Kg8605a = 18784,
    /// <summary>KH-902M</summary>
    Kh902m = 18785,
    /// <summary>KHOROM-K</summary>
    KhoromK = 18786,
    /// <summary>KHIBINY</summary>
    Khibiny = 18787,
    /// <summary>KG300E</summary>
    Kg300e = 18789,
    Value18790 = 18790,
    Value18791 = 18791,
    Value18792 = 18792,
    /// <summary>KH 1700</summary>
    Kh1700 = 18795,
    Value18797 = 18797,
    /// <summary>3rd Khordad TELAR TIR</summary>
    Value3rdKhordadTelarTir = 18800,
    /// <summary>3rd Khordad TAR</summary>
    Value3rdKhordadTar = 18801,
    /// <summary>15th Khordad TER</summary>
    Value15thKhordadTer = 18803,
    /// <summary>KG-300</summary>
    Kg300 = 18805,
    Value18810 = 18810,
    Value18855 = 18855,
    Value18900 = 18900,
    /// <summary>KLC-3B</summary>
    Klc3b = 18930,
    /// <summary>KJ-500 Nanjing Radar</summary>
    Kj500NanjingRadar = 18944,
    Value18945 = 18945,
    /// <summary>KJ-500 Jammer</summary>
    Kj500Jammer = 18946,
    /// <summary>KLC-1</summary>
    Klc1 = 18947,
    /// <summary>KLJ-1</summary>
    Klj1 = 18948,
    /// <summary>KLJ-3 (Type 1473)</summary>
    Klj3Type1473 = 18950,
    /// <summary>KLJ-4</summary>
    Klj4 = 18951,
    /// <summary>KLJ-4B</summary>
    Klj4b = 18952,
    /// <summary>KLJ-5</summary>
    Klj5 = 18955,
    /// <summary>KLJ-7</summary>
    Klj7 = 18960,
    /// <summary>KLJ-7B</summary>
    Klj7b = 18961,
    /// <summary>KLJ-7A</summary>
    Klj7a = 18962,
    Value18990 = 18990,
    /// <summary>P-10</summary>
    P10 = 19035,
    Value19037 = 19037,
    Value19039 = 19039,
    /// <summary>KJ-2000</summary>
    Kj2000 = 19040,
    Value19041 = 19041,
    /// <summary>Koopol</summary>
    Koopol = 19042,
    /// <summary>KOPYO-I</summary>
    KopyoI = 19045,
    /// <summary>KR-75</summary>
    Kr75 = 19050,
    /// <summary>KRONOS</summary>
    Kronos = 19051,
    /// <summary>KREDO-1E</summary>
    Kredo1e = 19052,
    /// <summary>Krasukha-2</summary>
    Krasukha2 = 19053,
    /// <summary>KRONOS GRAND NAVAL</summary>
    KronosGrandNaval = 19054,
    /// <summary>KRM-66E</summary>
    Krm66e = 19060,
    /// <summary>KRTZ-125-2M</summary>
    Krtz1252m = 19065,
    /// <summary>KSA SRN</summary>
    KsaSrn = 19080,
    /// <summary>KSA TSR</summary>
    KsaTsr = 19125,
    /// <summary>KS-1A PHASED ARRAY</summary>
    Ks1aPhasedArray = 19127,
    /// <summary>KS418</summary>
    Ks418 = 19129,
    /// <summary>KS418E</summary>
    Ks418e = 19130,
    /// <summary>KZ100</summary>
    Kz100 = 19131,
    /// <summary>KZ900</summary>
    Kz900 = 19132,
    /// <summary>KZ800 Airborne ELINT System</summary>
    Kz800AirborneElintSystem = 19133,
    /// <summary>L175V</summary>
    L175v = 19140,
    /// <summary>L370-5 President-S Jammer</summary>
    L3705PresidentSJammer = 19142,
    /// <summary>L-415</summary>
    L415 = 19143,
    /// <summary>L-88</summary>
    L88 = 19145,
    /// <summary>LAADS</summary>
    Laads = 19150,
    Value19170 = 19170,
    Value19215 = 19215,
    Value19260 = 19260,
    Value19305 = 19305,
    /// <summary>LAZUR</summary>
    Lazur = 19306,
    /// <summary>Model 791-A</summary>
    Model791A = 19307,
    /// <summary>LAP-3000</summary>
    Lap3000 = 19309,
    /// <summary>LC-150</summary>
    Lc150 = 19310,
    /// <summary>LEER-3</summary>
    Leer3 = 19320,
    Value19330 = 19330,
    /// <summary>Leninetz V-004</summary>
    LeninetzV004 = 19340,
    Value19350 = 19350,
    /// <summary>LIANA</summary>
    Liana = 19370,
    Value19395 = 19395,
    /// <summary>LIRA-A10</summary>
    LiraA10 = 19396,
    /// <summary>LIROD 8</summary>
    Lirod8 = 19397,
    /// <summary>LIROD MK II</summary>
    LirodMkIi = 19398,
    /// <summary>LLX05K</summary>
    Llx05k = 19399,
    /// <summary>LMT NRAI-6A</summary>
    LmtNrai6a = 19400,
    /// <summary>LN 55</summary>
    Ln55 = 19440,
    Value19485 = 19485,
    Value19500 = 19500,
    Value19505 = 19505,
    /// <summary>Lockheed Vigilance</summary>
    LockheedVigilance = 19520,
    Value19530 = 19530,
    Value19575 = 19575,
    Value19620 = 19620,
    Value19665 = 19665,
    Value19710 = 19710,
    Value19755 = 19755,
    Value19800 = 19800,
    Value19845 = 19845,
    Value19890 = 19890,
    /// <summary>LOPAR</summary>
    Lopar = 19920,
    /// <summary>LORAN</summary>
    Loran = 19935,
    Value19950 = 19950,
    Value19955 = 19955,
    Value19960 = 19960,
    Value19970 = 19970,
    Value19971 = 19971,
    Value19980 = 19980,
    Value20025 = 20025,
    /// <summary>LR-66 TER (LD-2000)</summary>
    Lr66TerLd2000 = 20029,
    /// <summary>LRA-900</summary>
    Lra900 = 20030,
    /// <summary>TRS-2050</summary>
    Trs2050 = 20040,
    /// <summary>LW 01</summary>
    Lw01 = 20060,
    /// <summary>LW 08</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Lw08 = 20070,
    Value20090 = 20090,
    /// <summary>M22-40</summary>
    M2240 = 20115,
    /// <summary>M44</summary>
    M44 = 20160,
    Value20205 = 20205,
    Value20250 = 20250,
    Value20295 = 20295,
    /// <summary>MA 1 IFF Portion</summary>
    Ma1IffPortion = 20340,
    /// <summary>MAD HACK</summary>
    MadHack = 20350,
    Value20360 = 20360,
    Value20385 = 20385,
    /// <summary>MARC S-152</summary>
    MarcS152 = 20420,
    Value20430 = 20430,
    Value20475 = 20475,
    Value20495 = 20495,
    Value20520 = 20520,
    Value20530 = 20530,
    Value20565 = 20565,
    Value20585 = 20585,
    /// <summary>MARCONI ST801</summary>
    MarconiSt801 = 20589,
    Value20590 = 20590,
    Value20610 = 20610,
    Value20655 = 20655,
    Value20700 = 20700,
    Value20745 = 20745,
    Value20790 = 20790,
    Value20835 = 20835,
    Value20880 = 20880,
    /// <summary>MARTELLO 743D</summary>
    Martello743d = 20890,
    /// <summary>MARTELLO S-723A</summary>
    MartelloS723a = 20895,
    /// <summary>MASTER-A</summary>
    MasterA = 20897,
    /// <summary>MBDA FLAADS-M (Sea Ceptor) Jammer</summary>
    MbdaFlaadsMSeaCeptorJammer = 20898,
    Value20900 = 20900,
    /// <summary>MELCO-3</summary>
    Melco3 = 20915,
    /// <summary>MELODI</summary>
    Melodi = 20917,
    /// <summary>MERLIN</summary>
    Merlin = 20918,
    /// <summary>Meraj-4 (Ascension)</summary>
    Meraj4Ascension = 20919,
    Value20920 = 20920,
    Value20925 = 20925,
    /// <summary>METEOR 1500S</summary>
    Meteor1500s = 20927,
    /// <summary>METEOR 200</summary>
    Meteor200 = 20929,
    /// <summary>METEOR 50DX</summary>
    Meteor50dx = 20930,
    /// <summary>METEOR 300</summary>
    Meteor300 = 20931,
    /// <summary>Meteor BVRAAM</summary>
    MeteorBvraam = 20933,
    /// <summary>MFR</summary>
    Mfr = 20935,
    /// <summary>MFSR 2100/45</summary>
    Mfsr210045 = 20940,
    /// <summary>MICA MH</summary>
    MicaMh = 20942,
    /// <summary>MICA-RF</summary>
    MicaRf = 20943,
    /// <summary>Mineral-ME</summary>
    MineralMe = 20945,
    /// <summary>Mirage ILL</summary>
    MirageIll = 20950,
    /// <summary>Miysis Jammer</summary>
    MiysisJammer = 20955,
    /// <summary>MK 15 (Phalanx BLK 0)</summary>
    Mk15PhalanxBlk0 = 20969,
    Value20970 = 20970,
    /// <summary>MK-23</summary>
    Mk23 = 21015,
    /// <summary>MK 23 TAS</summary>
    Mk23Tas = 21060,
    /// <summary>MK 25</summary>
    Mk25 = 21105,
    /// <summary>Mk-25 Mod-3</summary>
    Mk25Mod3 = 21110,
    /// <summary>Mk 25 Mod 7</summary>
    Mk25Mod7 = 21130,
    /// <summary>MK-35 M2</summary>
    Mk35M2 = 21150,
    /// <summary>MK 92</summary>
    Mk92 = 21195,
    /// <summary>MK-92 CAS</summary>
    Mk92Cas = 21240,
    /// <summary>MK-92 STIR</summary>
    Mk92Stir = 21285,
    /// <summary>MK 95</summary>
    Mk95 = 21330,
    /// <summary>MKS-818</summary>
    Mks818 = 21332,
    /// <summary>MLA-1</summary>
    Mla1 = 21340,
    /// <summary>MM/APQ-706</summary>
    MmApq706 = 21359,
    /// <summary>MM 950</summary>
    Mm950 = 21360,
    /// <summary>MM APS 705</summary>
    MmAps705 = 21375,
    /// <summary>MM/APS-784</summary>
    MmAps784 = 21390,
    /// <summary>MM/SPG-73 (RTN-12X)</summary>
    MmSpg73Rtn12x = 21419,
    /// <summary>MM SPG 74</summary>
    MmSpg74 = 21420,
    /// <summary>MM SPG 75</summary>
    MmSpg75 = 21465,
    /// <summary>MM SPN 703</summary>
    MmSpn703 = 21490,
    /// <summary>MM SPN 730</summary>
    MmSpn730 = 21492,
    /// <summary>MM SPN-753B</summary>
    MmSpn753b = 21495,
    /// <summary>MM/SPQ-3</summary>
    MmSpq3 = 21500,
    /// <summary>MM SPS 702</summary>
    MmSps702 = 21510,
    /// <summary>MM SPS 768</summary>
    MmSps768 = 21555,
    /// <summary>MM SPS 774</summary>
    MmSps774 = 21600,
    /// <summary>MM/SPS-791 (RAN-30X)</summary>
    MmSps791Ran30x = 21610,
    /// <summary>MM SPS-794 (RAN-21S)</summary>
    MmSps794Ran21s = 21615,
    /// <summary>MM/SPS-798 (RAN-40L)</summary>
    MmSps798Ran40l = 21620,
    /// <summary>MMSR</summary>
    Mmsr = 21623,
    /// <summary>Model-17C</summary>
    Model17c = 21625,
    /// <summary>Moon 4</summary>
    Moon4 = 21645,
    Value21646 = 21646,
    /// <summary>MOON CONE</summary>
    MoonCone = 21647,
    Value21648 = 21648,
    /// <summary>MOON FACE</summary>
    MoonFace = 21649,
    Value21650 = 21650,
    Value21651 = 21651,
    /// <summary>Model 360</summary>
    Model360 = 21655,
    /// <summary>Model 378</summary>
    Model378 = 21660,
    /// <summary>Model-970</summary>
    Model970 = 21661,
    /// <summary>Model 974</summary>
    Model974 = 21665,
    /// <summary>MONOLIT-B</summary>
    MonolitB = 21672,
    Value21675 = 21675,
    Value21680 = 21680,
    /// <summary>MP-411 ESM</summary>
    Mp411Esm = 21682,
    /// <summary>MPDR 18/S</summary>
    Mpdr18S = 21685,
    /// <summary>MPDR 18 X</summary>
    Mpdr18X = 21690,
    /// <summary>MPDR 45/E</summary>
    Mpdr45E = 21692,
    /// <summary>MR-231-1</summary>
    Mr2311 = 21693,
    /// <summary>MR-231-3</summary>
    Mr2313 = 21694,
    /// <summary>MPR</summary>
    Mpr = 21695,
    Value21696 = 21696,
    /// <summary>MPS-1</summary>
    Mps1 = 21697,
    Value21698 = 21698,
    Value21699 = 21699,
    /// <summary>MR-1600</summary>
    Mr1600 = 21700,
    /// <summary>MRR</summary>
    Mrr = 21701,
    /// <summary>MR35</summary>
    Mr35 = 21702,
    /// <summary>MR36</summary>
    Mr36 = 21703,
    /// <summary>MRL-1</summary>
    Mrl1 = 21704,
    /// <summary>MRL-4</summary>
    Mrl4 = 21705,
    /// <summary>MRL-5</summary>
    Mrl5 = 21706,
    /// <summary>MSAM</summary>
    Msam = 21707,
    /// <summary>MR-36A</summary>
    Mr36a = 21708,
    /// <summary>MSTAR</summary>
    Mstar = 21709,
    /// <summary>MT-305X</summary>
    Mt305x = 21710,
    /// <summary>MR-10M1E</summary>
    Mr10m1e = 21711,
    /// <summary>MR-90</summary>
    Mr90 = 21712,
    /// <summary>MRK-411</summary>
    Mrk411 = 21715,
    /// <summary>MR-320M Topaz-V</summary>
    Mr320mTopazV = 21716,
    /// <summary>MSP-418K</summary>
    Msp418k = 21720,
    Value21735 = 21735,
    /// <summary>Mushroom</summary>
    Mushroom = 21780,
    /// <summary>Mushroom 1</summary>
    Mushroom1 = 21825,
    /// <summary>Mushroom 2</summary>
    Mushroom2 = 21870,
    Value21871 = 21871,
    /// <summary>N-23</summary>
    N23 = 21872,
    /// <summary>N-011M Bars</summary>
    N011mBars = 21873,
    /// <summary>N-011M Bars-B</summary>
    N011mBarsB = 21874,
    /// <summary>N-011M Bars-C</summary>
    N011mBarsC = 21875,
    /// <summary>N-011M Bars-R</summary>
    N011mBarsR = 21876,
    /// <summary>N035 Irbis-E</summary>
    N035IrbisE = 21877,
    /// <summary>N036 Byelka</summary>
    N036Byelka = 21878,
    /// <summary>N-25</summary>
    N25 = 21879,
    /// <summary>N920Z</summary>
    N920z = 21880,
    /// <summary>N001V</summary>
    N001v = 21881,
    /// <summary>N001VE</summary>
    N001ve = 21882,
    /// <summary>N001VEP</summary>
    N001vep = 21883,
    /// <summary>NACOS RADARPILOT Platinum</summary>
    NacosRadarpilotPlatinum = 21884,
    Value21885 = 21885,
    /// <summary>NAGIRA</summary>
    Nagira = 21886,
    Value21890 = 21890,
    Value21895 = 21895,
    /// <summary>Nayada</summary>
    Nayada = 21915,
    /// <summary>NAYADA-5M</summary>
    Nayada5m = 21917,
    /// <summary>NAYADA-5PV</summary>
    Nayada5pv = 21918,
    /// <summary>NEBO-M</summary>
    NeboM = 21919,
    /// <summary>Nebo-SVU</summary>
    NeboSvu = 21920,
    /// <summary>Neptun</summary>
    Neptun = 21960,
    /// <summary>Nettuno 4100</summary>
    Nettuno4100 = 21965,
    /// <summary>NIKE HERCULES MTR</summary>
    NikeHerculesMtr = 21970,
    Value21980 = 21980,
    /// <summary>Northrop Grumman MFEW Jammer</summary>
    NorthropGrummanMfewJammer = 21981,
    /// <summary>NORINCO 3D</summary>
    Norinco3d = 21982,
    /// <summary>NJ-81E</summary>
    Nj81e = 21983,
    /// <summary>Normandie</summary>
    Normandie = 21984,
    /// <summary>NRJ-6A</summary>
    Nrj6a = 21985,
    /// <summary>NOSTRADAMUS</summary>
    Nostradamus = 21986,
    /// <summary>NPG-1240</summary>
    Npg1240 = 21987,
    /// <summary>NPG-1460</summary>
    Npg1460 = 21988,
    /// <summary>NPG-434</summary>
    Npg434 = 21989,
    /// <summary>NPG-630</summary>
    Npg630 = 21990,
    /// <summary>NPM-510</summary>
    Npm510 = 21991,
    Value21992 = 21992,
    /// <summary>NP Vega Liana</summary>
    NpVegaLiana = 21995,
    /// <summary>Novella NV1.70</summary>
    NovellaNv170 = 22000,
    /// <summary>Novella-P-38</summary>
    NovellaP38 = 22001,
    /// <summary>NRBA 50</summary>
    Nrba50 = 22005,
    /// <summary>NRBA 51</summary>
    Nrba51 = 22050,
    /// <summary>NRBF 20A</summary>
    Nrbf20a = 22095,
    /// <summary>NRJ-5</summary>
    Nrj5 = 22110,
    Value22115 = 22115,
    /// <summary>NS-100 Series</summary>
    Ns100Series = 22125,
    /// <summary>NUR-31</summary>
    Nur31 = 22127,
    /// <summary>NWS-3</summary>
    Nws3 = 22130,
    Value22140 = 22140,
    Value22185 = 22185,
    Value22230 = 22230,
    Value22275 = 22275,
    Value22320 = 22320,
    /// <summary>Ocean Master</summary>
    OceanMaster = 22335,
    Value22340 = 22340,
    Value22345 = 22345,
    Value22365 = 22365,
    Value22410 = 22410,
    Value22411 = 22411,
    Value22455 = 22455,
    /// <summary>OFOGH</summary>
    Ofogh = 22460,
    /// <summary>OFOGH-3</summary>
    Ofogh3 = 22463,
    /// <summary>OKEAN</summary>
    Okean = 22500,
    /// <summary>OKEAN A</summary>
    OkeanA = 22505,
    /// <summary>OKINXE 12C</summary>
    Okinxe12c = 22545,
    /// <summary>OKO</summary>
    Oko = 22560,
    /// <summary>OMEGA</summary>
    Omega = 22590,
    /// <summary>Omera ORB32</summary>
    OmeraOrb32 = 22635,
    /// <summary>OMUL</summary>
    Omul = 22640,
    Value22680 = 22680,
    /// <summary>OP-28</summary>
    Op28 = 22690,
    /// <summary>OPRL-4</summary>
    Oprl4 = 22695,
    /// <summary>OPRM-71</summary>
    Oprm71 = 22696,
    /// <summary>OPS-9</summary>
    Ops9 = 22697,
    /// <summary>OPS-11 B/C</summary>
    Ops11BC = 22700,
    /// <summary>OPS-12</summary>
    Ops12 = 22701,
    /// <summary>OPS-14B</summary>
    Ops14b = 22705,
    /// <summary>OPS-14C</summary>
    Ops14c = 22706,
    /// <summary>OPS-16B</summary>
    Ops16b = 22725,
    /// <summary>OPS-18</summary>
    Ops18 = 22730,
    /// <summary>OPS-19</summary>
    Ops19 = 22732,
    /// <summary>OPS-20</summary>
    Ops20 = 22735,
    /// <summary>OPS-22</summary>
    Ops22 = 22736,
    /// <summary>OPS-24</summary>
    Ops24 = 22737,
    /// <summary>OPS-28</summary>
    Ops28 = 22740,
    /// <summary>OPS-28C</summary>
    Ops28c = 22745,
    /// <summary>OPS-39</summary>
    Ops39 = 22750,
    /// <summary>OPTIMA 3.2</summary>
    Optima32 = 22760,
    Value22770 = 22770,
    /// <summary>ORB-31D</summary>
    Orb31d = 22800,
    /// <summary>ORB-31S</summary>
    Orb31s = 22810,
    /// <summary>ORB 32</summary>
    Orb32 = 22815,
    /// <summary>ORB-42</summary>
    Orb42 = 22830,
    /// <summary>Orion Rtn 10X</summary>
    OrionRtn10x = 22860,
    /// <summary>Surface Wave (Over The Horizon)</summary>
    SurfaceWaveOverTheHorizon = 22890,
    /// <summary>Otomat MK 1</summary>
    OtomatMk1 = 22900,
    /// <summary>Otomat MK II Teseo</summary>
    OtomatMkIiTeseo = 22905,
    /// <summary>Otomat Series AL</summary>
    OtomatSeriesAl = 22906,
    Value22950 = 22950,
    /// <summary>P360Z</summary>
    P360z = 22955,
    /// <summary>P-14</summary>
    P14 = 22956,
    /// <summary>P-180U</summary>
    P180u = 22957,
    /// <summary>P-18-2</summary>
    P182 = 22959,
    /// <summary>PA-1660</summary>
    Pa1660 = 22960,
    /// <summary>P-18M</summary>
    P18m = 22961,
    /// <summary>P-190U</summary>
    P190u = 22962,
    /// <summary>P-30</summary>
    P30 = 22963,
    /// <summary>P-18 MOD</summary>
    P18Mod = 22964,
    /// <summary>P-35M</summary>
    P35m = 22965,
    /// <summary>PAGE</summary>
    Page = 22970,
    Value22977 = 22977,
    Value22995 = 22995,
    Value22998 = 22998,
    Value23040 = 23040,
    /// <summary>Pandora</summary>
    Pandora = 23041,
    /// <summary>PALSAR-2</summary>
    Palsar2 = 23042,
    /// <summary>Pantsir-SM TAR</summary>
    PantsirSmTar = 23043,
    /// <summary>PAR-2</summary>
    Par2 = 23045,
    /// <summary>Pantsir-S1 2RL80 TAR</summary>
    PantsirS12rl80Tar = 23046,
    /// <summary>Pantsir-S1 1RS2-1 TT</summary>
    PantsirS11rs21Tt = 23047,
    /// <summary>PAR-2000</summary>
    Par2000 = 23050,
    /// <summary>PAR-2090C</summary>
    Par2090c = 23053,
    /// <summary>PAR-80</summary>
    Par80 = 23055,
    Value23085 = 23085,
    Value23095 = 23095,
    /// <summary>PATRIOT</summary>
    Patriot = 23100,
    Value23130 = 23130,
    Value23175 = 23175,
    /// <summary>PBR 4 Rubin</summary>
    Pbr4Rubin = 23220,
    /// <summary>PCS 514</summary>
    Pcs514 = 23240,
    Value23265 = 23265,
    /// <summary>Pechora SC</summary>
    PechoraSc = 23295,
    Value23310 = 23310,
    Value23355 = 23355,
    Value23400 = 23400,
    Value23445 = 23445,
    Value23450 = 23450,
    Value23490 = 23490,
    Value23500 = 23500,
    /// <summary>PGZ-07 TER</summary>
    Pgz07Ter = 23515,
    /// <summary>Phalanx</summary>
    Phalanx = 23525,
    /// <summary>Phazotron Gukol-4</summary>
    PhazotronGukol4 = 23529,
    /// <summary>Phazotron Zhuk-A/AE</summary>
    PhazotronZhukAAe = 23530,
    Value23535 = 23535,
    Value23580 = 23580,
    Value23625 = 23625,
    Value23670 = 23670,
    /// <summary>Phimat Jammer</summary>
    PhimatJammer = 23675,
    /// <summary>PICOSAR</summary>
    Picosar = 23680,
    Value23685 = 23685,
    Value23690 = 23690,
    Value23695 = 23695,
    /// <summary>PL02 Surveillance</summary>
    Pl02Surveillance = 23698,
    /// <summary>PL-11</summary>
    Pl11 = 23700,
    /// <summary>PL-12</summary>
    Pl12 = 23701,
    /// <summary>PL-12A</summary>
    Pl12a = 23703,
    /// <summary>PL-15</summary>
    Pl15 = 23704,
    /// <summary>PL-17</summary>
    Pl17 = 23705,
    Value23710 = 23710,
    Value23715 = 23715,
    Value23760 = 23760,
    Value23805 = 23805,
    Value23850 = 23850,
    Value23895 = 23895,
    Value23925 = 23925,
    Value23940 = 23940,
    Value23985 = 23985,
    Value23990 = 23990,
    Value24020 = 24020,
    Value24030 = 24030,
    /// <summary>Plessey AWS 9</summary>
    PlesseyAws9 = 24035,
    Value24075 = 24075,
    Value24095 = 24095,
    /// <summary>PNA-B Rubin / Down Beat</summary>
    PnaBRubinDownBeat = 24098,
    /// <summary>POHJANPALO</summary>
    Pohjanpalo = 24100,
    /// <summary>Pole-21E Jammer L1</summary>
    Pole21eJammerL1 = 24108,
    /// <summary>Pole-21E Jammer L2</summary>
    Pole21eJammerL2 = 24109,
    /// <summary>Poliment-K</summary>
    PolimentK = 24110,
    /// <summary>POLLUX</summary>
    Pollux = 24120,
    /// <summary>Polozhennya-2</summary>
    Polozhennya2 = 24130,
    Value24165 = 24165,
    Value24210 = 24210,
    Value24255 = 24255,
    Value24300 = 24300,
    Value24320 = 24320,
    Value24345 = 24345,
    /// <summary>Pozitiv-ME1 5P-26</summary>
    PozitivMe15p26 = 24385,
    /// <summary>Pozitiv-ME1.2</summary>
    PozitivMe12 = 24386,
    /// <summary>Pozitiv-MK</summary>
    PozitivMk = 24387,
    Value24390 = 24390,
    Value24435 = 24435,
    Value24480 = 24480,
    Value24525 = 24525,
    Value24535 = 24535,
    /// <summary>Praetorian Countermeasures Suite</summary>
    PraetorianCountermeasuresSuite = 24540,
    /// <summary>PRIMUS 30A</summary>
    Primus30a = 24569,
    /// <summary>PRIMUS 40 WXD</summary>
    Primus40Wxd = 24570,
    /// <summary>Primus 400</summary>
    Primus400 = 24614,
    /// <summary>PRIMUS 300SL</summary>
    Primus300sl = 24615,
    /// <summary>Primus 500</summary>
    Primus500 = 24616,
    /// <summary>Primus 650</summary>
    Primus650 = 24617,
    /// <summary>Primus 700</summary>
    Primus700 = 24618,
    /// <summary>PRIMUS 800</summary>
    Primus800 = 24619,
    Value24620 = 24620,
    /// <summary>Primus 870</summary>
    Primus870 = 24622,
    /// <summary>PRORA</summary>
    Prora = 24630,
    /// <summary>PRS-2</summary>
    Prs2 = 24631,
    /// <summary>PRS-3 Argon-2</summary>
    Prs3Argon2 = 24633,
    /// <summary>PRORA PA-1660</summary>
    ProraPa1660 = 24635,
    /// <summary>PS-15</summary>
    Ps15 = 24640,
    /// <summary>PS-05A</summary>
    Ps05a = 24650,
    /// <summary>PS 46 A</summary>
    Ps46A = 24660,
    /// <summary>PS 70 R</summary>
    Ps70R = 24705,
    /// <summary>PS-171/R</summary>
    Ps171R = 24706,
    /// <summary>PS-860</summary>
    Ps860 = 24707,
    /// <summary>PS-870</summary>
    Ps870 = 24709,
    /// <summary>PS-890</summary>
    Ps890 = 24710,
    /// <summary>PSM-33</summary>
    Psm33 = 24720,
    Value24750 = 24750,
    /// <summary>Quadradar VI</summary>
    QuadradarVi = 24755,
    /// <summary>QW-1A</summary>
    Qw1a = 24757,
    /// <summary>Phazotron 1RS2-1E</summary>
    Phazotron1rs21e = 24758,
    /// <summary>PVS-200</summary>
    Pvs200 = 24760,
    /// <summary>PVS 2000</summary>
    Pvs2000 = 24761,
    /// <summary>R-325UMV Jammer</summary>
    R325umvJammer = 24767,
    /// <summary>R-330ZH</summary>
    R330zh = 24768,
    /// <summary>R 045</summary>
    R045 = 24769,
    /// <summary>R-76</summary>
    R76 = 24770,
    /// <summary>R-934B</summary>
    R934b = 24771,
    /// <summary>RA-20</summary>
    Ra20 = 24772,
    /// <summary>RA723</summary>
    Ra723 = 24774,
    /// <summary>R41XXX</summary>
    R41xxx = 24775,
    /// <summary>RAC-3D</summary>
    Rac3d = 24776,
    Value24780 = 24780,
    /// <summary>R-423AM</summary>
    R423am = 24781,
    /// <summary>Raad-1 TER</summary>
    Raad1Ter = 24785,
    /// <summary>Raad-2 TER</summary>
    Raad2Ter = 24787,
    Value24795 = 24795,
    /// <summary>DECCA 1230</summary>
    Decca1230 = 24800,
    Value24840 = 24840,
    Value24885 = 24885,
    /// <summary>Racal-DECCA 20V90/9</summary>
    RacalDecca20v909 = 24890,
    Value24930 = 24930,
    Value24975 = 24975,
    Value25020 = 25020,
    Value25065 = 25065,
    Value25110 = 25110,
    /// <summary>RADA MHR</summary>
    RadaMhr = 25150,
    Value25155 = 25155,
    Value25170 = 25170,
    Value25171 = 25171,
    /// <summary>RAJENDRA</summary>
    Rajendra = 25180,
    /// <summary>RAN 7S</summary>
    Ran7s = 25200,
    /// <summary>RAN 10S</summary>
    Ran10s = 25205,
    /// <summary>RAN 11 LX</summary>
    Ran11Lx = 25245,
    /// <summary>Rani</summary>
    Rani = 25250,
    /// <summary>RAPHAEL-TH</summary>
    RaphaelTh = 25259,
    /// <summary>Rapier TA</summary>
    RapierTa = 25260,
    /// <summary>Rapier 2000 TA</summary>
    Rapier2000Ta = 25265,
    /// <summary>Rapier MG</summary>
    RapierMg = 25270,
    /// <summary>RASCAR 3400C</summary>
    Rascar3400c = 25273,
    /// <summary>Rashmi</summary>
    Rashmi = 25275,
    /// <summary>Rasit</summary>
    Rasit = 25276,
    /// <summary>Rasit 3190B</summary>
    Rasit3190b = 25277,
    /// <summary>RAT-31 DL/M</summary>
    Rat31DlM = 25278,
    /// <summary>RAT-31 DL</summary>
    Rat31Dl = 25279,
    /// <summary>RAT-31S</summary>
    Rat31s = 25280,
    /// <summary>RAT-8 S</summary>
    Rat8S = 25281,
    /// <summary>RAT-31 SL</summary>
    Rat31Sl = 25282,
    /// <summary>Raven ES-05</summary>
    RavenEs05 = 25283,
    /// <summary>RATAC (LCT)</summary>
    RatacLct = 25285,
    /// <summary>RAWL</summary>
    Rawl = 25286,
    Value25287 = 25287,
    /// <summary>RAWS</summary>
    Raws = 25288,
    /// <summary>RAWL-02</summary>
    Rawl02 = 25289,
    Value25290 = 25290,
    /// <summary>RAWS-03</summary>
    Raws03 = 25291,
    Value25292 = 25292,
    Value25300 = 25300,
    Value25335 = 25335,
    Value25380 = 25380,
    Value25425 = 25425,
    Value25470 = 25470,
    Value25515 = 25515,
    /// <summary>Raytheon Anschutz NautoScan NX</summary>
    RaytheonAnschutzNautoScanNx = 25530,
    Value25540 = 25540,
    Value25545 = 25545,
    Value25550 = 25550,
    Value25560 = 25560,
    Value25605 = 25605,
    /// <summary>RAY-1220XR</summary>
    Ray1220xr = 25630,
    Value25635 = 25635,
    Value25650 = 25650,
    Value25694 = 25694,
    Value25695 = 25695,
    Value25698 = 25698,
    /// <summary>RB-109A Bylina Jammer</summary>
    Rb109aBylinaJammer = 25710,
    /// <summary>RB-313A Jammer</summary>
    Rb313aJammer = 25715,
    /// <summary>RB-337A Jammer</summary>
    Rb337aJammer = 25719,
    /// <summary>RB-341A Leer-3 Jammer</summary>
    Rb341aLeer3Jammer = 25721,
    /// <summary>RB-343A Jammer</summary>
    Rb343aJammer = 25723,
    /// <summary>RB-334A Jammer</summary>
    Rb334aJammer = 25724,
    /// <summary>RB-336A Jammer</summary>
    Rb336aJammer = 25725,
    /// <summary>RB-636AM2 SVET-KU Jammer</summary>
    Rb636am2SvetKuJammer = 25730,
    /// <summary>RBE2</summary>
    Rbe2 = 25735,
    /// <summary>RBE2-AA</summary>
    Rbe2Aa = 25736,
    /// <summary>RCT-180</summary>
    Rct180 = 25739,
    /// <summary>RDM</summary>
    Rdm = 25740,
    /// <summary>RDM-3</summary>
    Rdm3 = 25745,
    /// <summary>RDI</summary>
    Rdi = 25750,
    /// <summary>RDY</summary>
    Rdy = 25760,
    /// <summary>RDY-3</summary>
    Rdy3 = 25762,
    /// <summary>RDS-86</summary>
    Rds86 = 25770,
    /// <summary>RDN 72</summary>
    Rdn72 = 25785,
    /// <summary>RDR 1A</summary>
    Rdr1a = 25830,
    /// <summary>RDR 1E</summary>
    Rdr1e = 25835,
    /// <summary>RDR 4A</summary>
    Rdr4a = 25840,
    /// <summary>RDR-150</summary>
    Rdr150 = 25845,
    /// <summary>RDR-160XD</summary>
    Rdr160xd = 25850,
    /// <summary>RDR-230 HP</summary>
    Rdr230Hp = 25853,
    /// <summary>RDR 1100</summary>
    Rdr1100 = 25855,
    /// <summary>RDR-1150</summary>
    Rdr1150 = 25860,
    /// <summary>RDR 1200</summary>
    Rdr1200 = 25875,
    /// <summary>RDR 1400</summary>
    Rdr1400 = 25885,
    /// <summary>RDR 1400 C</summary>
    Rdr1400C = 25890,
    /// <summary>RDR-4000</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Rdr4000 = 25891,
    /// <summary>RDR 4000</summary>
    Rdr400025892 = 25892,
    /// <summary>RDR 1500</summary>
    Rdr1500 = 25895,
    Value25896 = 25896,
    /// <summary>RDR 1600</summary>
    Rdr1600 = 25897,
    /// <summary>RDR 2000</summary>
    Rdr2000 = 25898,
    /// <summary>RDR 1700B</summary>
    Rdr1700b = 25899,
    /// <summary>Remora</summary>
    Remora = 25900,
    /// <summary>Rice Field</summary>
    RiceField = 25901,
    /// <summary>REC-1A</summary>
    Rec1a = 25902,
    /// <summary>REC-1B</summary>
    Rec1b = 25903,
    /// <summary>REC-1C</summary>
    Rec1c = 25904,
    /// <summary>Resolve EAS</summary>
    ResolveEas = 25906,
    Value25907 = 25907,
    /// <summary>REL-6E</summary>
    Rel6e = 25908,
    /// <summary>REC-1</summary>
    Rec1 = 25909,
    Value25910 = 25910,
    /// <summary>Improved Reporter</summary>
    ImprovedReporter = 25911,
    Value25912 = 25912,
    Value25915 = 25915,
    Value25920 = 25920,
    Value25921 = 25921,
    Value25923 = 25923,
    /// <summary>Retia ReVisor</summary>
    RetiaReVisor = 25930,
    /// <summary>REVATHI</summary>
    Revathi = 25940,
    /// <summary>REZONANS</summary>
    Rezonans = 25950,
    /// <summary>RGM/UGM-109B</summary>
    RgmUgm109b = 25955,
    /// <summary>RGM/UGM-109E Homing Radar</summary>
    RgmUgm109eHomingRadar = 25958,
    Value25965 = 25965,
    /// <summary>RKL-526</summary>
    Rkl526 = 25966,
    /// <summary>RKZ-764</summary>
    Rkz764 = 25967,
    /// <summary>RKZ-766</summary>
    Rkz766 = 25968,
    /// <summary>RKL-165</summary>
    Rkl165 = 25969,
    /// <summary>RKL-609</summary>
    Rkl609 = 25970,
    /// <summary>RKL-800</summary>
    Rkl800 = 25971,
    /// <summary>RKZ-761</summary>
    Rkz761 = 25972,
    /// <summary>RKZ-2000</summary>
    Rkz2000 = 25973,
    /// <summary>RIS-4C/A</summary>
    Ris4cA = 25974,
    /// <summary>RL-2000</summary>
    Rl2000 = 25975,
    /// <summary>RL-41</summary>
    Rl41 = 25976,
    /// <summary>RIR 778</summary>
    Rir778 = 25977,
    /// <summary>RISAT</summary>
    Risat = 25978,
    /// <summary>RLM-S</summary>
    RlmS = 25979,
    /// <summary>Rim Hat ESM/ECM Suite</summary>
    RimHatEsmEcmSuite = 25980,
    Value26008 = 26008,
    Value26010 = 26010,
    Value26011 = 26011,
    /// <summary>RM370BT</summary>
    Rm370bt = 26015,
    Value26020 = 26020,
    Value26040 = 26040,
    Value26041 = 26041,
    /// <summary>RMT 0100A</summary>
    Rmt0100a = 26043,
    /// <summary>RN-222</summary>
    Rn222 = 26045,
    /// <summary>ROLAND 2</summary>
    Roland2 = 26053,
    /// <summary>ROLAND BN</summary>
    RolandBn = 26055,
    /// <summary>ROLAND MG</summary>
    RolandMg = 26100,
    /// <summary>ROLAND TA</summary>
    RolandTa = 26145,
    /// <summary>ROLAND TT</summary>
    RolandTt = 26190,
    /// <summary>ROTODOME</summary>
    Rotodome = 26210,
    Value26235 = 26235,
    /// <summary>RP-379D Tirada D</summary>
    Rp379dTiradaD = 26236,
    /// <summary>RP-3</summary>
    Rp3 = 26237,
    /// <summary>RP-4G</summary>
    Rp4g = 26238,
    /// <summary>RP-377L Lorandit DF Jammer</summary>
    Rp377lLoranditDfJammer = 26240,
    /// <summary>RP-377UVM3 Jammer</summary>
    Rp377uvm3Jammer = 26241,
    Value26280 = 26280,
    Value26325 = 26325,
    /// <summary>RPR-117</summary>
    Rpr117 = 26326,
    /// <summary>RS-02/50</summary>
    Rs0250 = 26327,
    Value26328 = 26328,
    /// <summary>RT-02/50</summary>
    Rt0250 = 26330,
    /// <summary>RTA-4100</summary>
    Rta4100 = 26340,
    /// <summary>RTN-1A</summary>
    Rtn1a = 26350,
    /// <summary>RTN-25X</summary>
    Rtn25x = 26353,
    /// <summary>RTS-6400</summary>
    Rts6400 = 26354,
    Value26355 = 26355,
    Value26360 = 26360,
    Value26361 = 26361,
    Value26362 = 26362,
    /// <summary>RV2</summary>
    Rv2 = 26370,
    /// <summary>RV3</summary>
    Rv3 = 26415,
    /// <summary>RV5</summary>
    Rv5 = 26460,
    /// <summary>RV10</summary>
    Rv10 = 26505,
    /// <summary>RV-15M</summary>
    Rv15m = 26506,
    /// <summary>RV17</summary>
    Rv17 = 26550,
    /// <summary>RV18</summary>
    Rv18 = 26595,
    /// <summary>RV-21</summary>
    Rv21 = 26596,
    /// <summary>RV-21B</summary>
    Rv21b = 26597,
    /// <summary>RV-25</summary>
    Rv25 = 26600,
    /// <summary>RV-377</summary>
    Rv377 = 26610,
    /// <summary>RV UM</summary>
    RvUm = 26640,
    /// <summary>RWD-8</summary>
    Rwd8 = 26650,
    Value26660 = 26660,
    Value26665 = 26665,
    /// <summary>S-1810CD</summary>
    S1810cd = 26670,
    /// <summary>Sahab</summary>
    Sahab = 26672,
    /// <summary>Salamandre</summary>
    Salamandre = 26673,
    Value26674 = 26674,
    /// <summary>S1850M</summary>
    S1850m = 26675,
    /// <summary>S-511</summary>
    S511 = 26676,
    /// <summary>S-512</summary>
    S512 = 26677,
    /// <summary>S-600</summary>
    S600 = 26678,
    /// <summary>S-604</summary>
    S604 = 26679,
    /// <summary>S-763 LANZA 3D</summary>
    S763Lanza3d = 26680,
    /// <summary>S-613</summary>
    S613 = 26681,
    /// <summary>S-631</summary>
    S631 = 26682,
    /// <summary>S-654</summary>
    S654 = 26683,
    /// <summary>S-669</summary>
    S669 = 26684,
    Value26685 = 26685,
    /// <summary>S-244</summary>
    S244 = 26686,
    /// <summary>S-711</summary>
    S711 = 26687,
    Value26730 = 26730,
    Value26775 = 26775,
    Value26795 = 26795,
    Value26797 = 26797,
    /// <summary>SABER-M60</summary>
    SaberM60 = 26799,
    /// <summary>Samovar</summary>
    Samovar = 26805,
    /// <summary>Sampson</summary>
    Sampson = 26810,
    Value26820 = 26820,
    Value26865 = 26865,
    /// <summary>Saccade MH</summary>
    SaccadeMh = 26900,
    Value26910 = 26910,
    /// <summary>SAP-14</summary>
    Sap14 = 26920,
    /// <summary>SAP-518</summary>
    Sap518 = 26925,
    /// <summary>SAP-518M</summary>
    Sap518m = 26926,
    /// <summary>Sand Bar</summary>
    SandBar = 26930,
    Value26935 = 26935,
    /// <summary>SAR (on UAVs)</summary>
    SarOnUAVs = 26945,
    /// <summary>SATRAPE</summary>
    Satrape = 26950,
    /// <summary>SATURNE II</summary>
    SaturneIi = 26955,
    /// <summary>Sayyad-2 TER</summary>
    Sayyad2Ter = 26957,
    Value27000 = 27000,
    Value27045 = 27045,
    Value27090 = 27090,
    /// <summary>SCANTER 1002</summary>
    Scanter1002 = 27095,
    Value27100 = 27100,
    Value27101 = 27101,
    Value27102 = 27102,
    /// <summary>SCANTER 4002</summary>
    Scanter4002 = 27109,
    Value27110 = 27110,
    /// <summary>SCANTER 5102</summary>
    Scanter5102 = 27111,
    /// <summary>SCANTER 5502</summary>
    Scanter5502 = 27113,
    Value27115 = 27115,
    Value27116 = 27116,
    Value27125 = 27125,
    Value27135 = 27135,
    /// <summary>SCANTER MIL S</summary>
    ScanterMilS = 27137,
    /// <summary>Scanter SMR</summary>
    ScanterSmr = 27139,
    /// <summary>SCANTER (CSR)</summary>
    ScanterCsr = 27140,
    /// <summary>SCORADS</summary>
    Scorads = 27141,
    /// <summary>Scimitar</summary>
    Scimitar = 27142,
    /// <summary>STAR 2000</summary>
    Star2000 = 27143,
    Value27150 = 27150,
    /// <summary>Scoop Pair</summary>
    ScoopPair = 27175,
    Value27180 = 27180,
    Value27183 = 27183,
    /// <summary>SCR-584</summary>
    Scr584 = 27190,
    /// <summary>Sea Archer 2</summary>
    SeaArcher2 = 27225,
    /// <summary>Sea Based X-Band</summary>
    SeaBasedXBand = 27230,
    /// <summary>Sea Dragon</summary>
    SeaDragon = 27235,
    /// <summary>Sea Eagle (Type 381)</summary>
    SeaEagleType381 = 27239,
    /// <summary>Sea Eagle S/C (Type 382)</summary>
    SeaEagleSCType382 = 27240,
    /// <summary>SEA FALCON</summary>
    SeaFalcon = 27245,
    Value27248 = 27248,
    Value27251 = 27251,
    /// <summary>Sea-Hawk SHN X12</summary>
    SeaHawkShnX12 = 27260,
    /// <summary>Sea Hunter 4 MG</summary>
    SeaHunter4Mg = 27270,
    /// <summary>Sea Hunter 4 TA</summary>
    SeaHunter4Ta = 27315,
    /// <summary>Sea Hunter 4 TT</summary>
    SeaHunter4Tt = 27360,
    Value27405 = 27405,
    Value27430 = 27430,
    Value27450 = 27450,
    /// <summary>Sea Sparrow</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SeaSparrow = 27451,
    /// <summary>Sea Spray</summary>
    SeaSpray = 27495,
    /// <summary>Sea Tiger</summary>
    SeaTiger = 27540,
    /// <summary>Sea Tiger M</summary>
    SeaTigerM = 27550,
    /// <summary>Seastar</summary>
    Seastar = 27560,
    /// <summary>Searchwater</summary>
    Searchwater = 27570,
    /// <summary>Searchwater 2000</summary>
    Searchwater2000 = 27575,
    /// <summary>SEASONDE</summary>
    Seasonde = 27580,
    /// <summary>SEASPRAY 7000E</summary>
    Seaspray7000e = 27582,
    /// <summary>SeaVue</summary>
    SeaVue = 27583,
    Value27584 = 27584,
    Value27585 = 27585,
    Value27630 = 27630,
    Value27675 = 27675,
    /// <summary>Selenia RAN 20S</summary>
    SeleniaRan20s = 27680,
    Value27720 = 27720,
    Value27765 = 27765,
    /// <summary>SENTIR-M20</summary>
    SentirM20 = 27770,
    /// <summary>SERDAR</summary>
    Serdar = 27771,
    /// <summary>SERHAT</summary>
    Serhat = 27773,
    Value27775 = 27775,
    /// <summary>SERIES 52</summary>
    Series52 = 27780,
    /// <summary>SERIES 320</summary>
    Series320 = 27790,
    /// <summary>SG</summary>
    Sg = 27800,
    Value27802 = 27802,
    Value27803 = 27803,
    /// <summary>SGR 102 00</summary>
    Sgr10200 = 27810,
    /// <summary>SGR 103/02</summary>
    Sgr10302 = 27855,
    /// <summary>SGR-104</summary>
    Sgr104 = 27870,
    /// <summary>Shahed-129 SAR</summary>
    Shahed129Sar = 27873,
    /// <summary>SHAHINE</summary>
    Shahine = 27875,
    Value27900 = 27900,
    Value27945 = 27945,
    /// <summary>SHIKRA</summary>
    Shikra = 27980,
    Value27990 = 27990,
    Value28035 = 28035,
    /// <summary>SGR 114</summary>
    Sgr114 = 28080,
    Value28125 = 28125,
    Value28170 = 28170,
    Value28215 = 28215,
    Value28260 = 28260,
    /// <summary>PRV-11</summary>
    Prv11 = 28280,
    Value28305 = 28305,
    /// <summary>Signaal - Bharat</summary>
    SignaalBharat = 28340,
    Value28350 = 28350,
    Value28395 = 28395,
    Value28440 = 28440,
    Value28445 = 28445,
    Value28480 = 28480,
    Value28485 = 28485,
    Value28530 = 28530,
    Value28575 = 28575,
    Value28620 = 28620,
    Value28665 = 28665,
    Value28710 = 28710,
    Value28755 = 28755,
    Value28760 = 28760,
    Value28770 = 28770,
    Value28800 = 28800,
    Value28845 = 28845,
    Value28890 = 28890,
    Value28935 = 28935,
    Value28980 = 28980,
    Value29025 = 29025,
    Value29030 = 29030,
    Value29035 = 29035,
    /// <summary>SIMRAD 3G</summary>
    Simrad3g = 29043,
    /// <summary>SIMRAD 4G</summary>
    Simrad4g = 29045,
    Value29050 = 29050,
    Value29060 = 29060,
    Value29070 = 29070,
    Value29115 = 29115,
    Value29160 = 29160,
    /// <summary>SKYFENDER</summary>
    Skyfender = 29172,
    /// <summary>Sky Wave (Over The Horizon)</summary>
    SkyWaveOverTheHorizon = 29175,
    /// <summary>Skyguard B</summary>
    SkyguardB = 29180,
    /// <summary>SKYGUARD TA</summary>
    SkyguardTa = 29185,
    /// <summary>SKYGUARD TT</summary>
    SkyguardTt = 29190,
    /// <summary>Skyguard LR</summary>
    SkyguardLr = 29191,
    /// <summary>Skymaster</summary>
    Skymaster = 29200,
    Value29205 = 29205,
    /// <summary>Sky Ranger</summary>
    SkyRanger = 29210,
    Value29215 = 29215,
    /// <summary>SKYSHIELD TA</summary>
    SkyshieldTa = 29220,
    /// <summary>SL</summary>
    Sl = 29250,
    /// <summary>SL/ALQ-234</summary>
    SlAlq234 = 29270,
    Value29295 = 29295,
    Value29297 = 29297,
    /// <summary>SLC-2</summary>
    Slc2 = 29300,
    /// <summary>SLC-2E</summary>
    Slc2e = 29301,
    /// <summary>SLC-4</summary>
    Slc4 = 29305,
    Value29340 = 29340,
    Value29385 = 29385,
    Value29400 = 29400,
    Value29430 = 29430,
    Value29431 = 29431,
    Value29432 = 29432,
    Value29433 = 29433,
    Value29434 = 29434,
    Value29435 = 29435,
    Value29440 = 29440,
    /// <summary>SM-674A/UPM</summary>
    Sm674aUpm = 29450,
    Value29475 = 29475,
    Value29520 = 29520,
    Value29565 = 29565,
    Value29610 = 29610,
    Value29655 = 29655,
    Value29700 = 29700,
    Value29745 = 29745,
    Value29790 = 29790,
    Value29835 = 29835,
    Value29880 = 29880,
    Value29925 = 29925,
    Value29970 = 29970,
    Value30015 = 30015,
    /// <summary>SR-47A</summary>
    Sr47a = 30016,
    Value30060 = 30060,
    Value30065 = 30065,
    /// <summary>SMART-S</summary>
    SmartS = 30068,
    /// <summary>SMART-S Mk2</summary>
    SmartSMk2 = 30069,
    /// <summary>SMART-L</summary>
    SmartL = 30070,
    /// <summary>SM-932</summary>
    Sm932 = 30072,
    Value30075 = 30075,
    Value30080 = 30080,
    Value30105 = 30105,
    Value30140 = 30140,
    Value30150 = 30150,
    Value30195 = 30195,
    [Obsolete("Deprecated by SISO-REF-010.")]
    Value30200 = 30200,
    Value30240 = 30240,
    Value30255 = 30255,
    Value30285 = 30285,
    Value30330 = 30330,
    Value30375 = 30375,
    Value30420 = 30420,
    Value30421 = 30421,
    Value30465 = 30465,
    /// <summary>9S18M1</summary>
    Value9s18m1 = 30470,
    /// <summary>9S18M1E</summary>
    Value9s18m1e = 30471,
    /// <summary>SPB-7</summary>
    Spb7 = 30475,
    Value30480 = 30480,
    /// <summary>SNW-10</summary>
    Snw10 = 30490,
    /// <summary>SO-1</summary>
    So1 = 30510,
    /// <summary>SO-12</summary>
    So12 = 30520,
    /// <summary>SO A Communist</summary>
    SoACommunist = 30555,
    /// <summary>SO-69</summary>
    So69 = 30580,
    Value30600 = 30600,
    /// <summary>SOM 64</summary>
    Som64 = 30645,
    /// <summary>Sopka (Hill)</summary>
    SopkaHill = 30650,
    Value30660 = 30660,
    /// <summary>Sorbtsiya L005</summary>
    SorbtsiyaL005 = 30661,
    /// <summary>Sorbtsiya L005S</summary>
    SorbtsiyaL005s = 30662,
    /// <summary>SPADA SIR</summary>
    SpadaSir = 30665,
    Value30670 = 30670,
    Value30680 = 30680,
    Value30682 = 30682,
    /// <summary>Sparrow (AIM/RIM-7) ILL</summary>
    SparrowAimRim7Ill = 30690,
    /// <summary>SPERRY RASCAR</summary>
    SperryRascar = 30691,
    /// <summary>SPECTRA</summary>
    Spectra = 30692,
    /// <summary>SPEAR3 MMW</summary>
    Spear3Mmw = 30696,
    Value30700 = 30700,
    Value30701 = 30701,
    /// <summary>SPEXER 2000</summary>
    Spexer2000 = 30710,
    /// <summary>SPG 53F</summary>
    Spg53f = 30735,
    /// <summary>SPG 70 (RTN 10X)</summary>
    Spg70Rtn10x = 30780,
    /// <summary>SPG 74 (RTN 20X)</summary>
    Spg74Rtn20x = 30825,
    /// <summary>SPG 75 (RTN 30X)</summary>
    Spg75Rtn30x = 30870,
    /// <summary>SPG 76 (RTN 30X)</summary>
    Spg76Rtn30x = 30915,
    Value30960 = 30960,
    Value31005 = 31005,
    Value31050 = 31050,
    /// <summary>SPINO D'ADDA WTR</summary>
    SpinoDAddaWtr = 31070,
    /// <summary>SPJ-40</summary>
    Spj40 = 31080,
    Value31095 = 31095,
    /// <summary>SPN-2</summary>
    Spn2 = 31096,
    /// <summary>SPN-4</summary>
    Spn4 = 31097,
    /// <summary>SPN-30</summary>
    Spn30 = 31100,
    /// <summary>SPN 35A</summary>
    Spn35a = 31140,
    /// <summary>SPN 41</summary>
    Spn41 = 31185,
    /// <summary>SPN 42</summary>
    Spn42 = 31230,
    /// <summary>SPN 43A</summary>
    Spn43a = 31275,
    /// <summary>SPN 43B</summary>
    Spn43b = 31320,
    /// <summary>SPN 44</summary>
    Spn44 = 31365,
    /// <summary>SPN 46</summary>
    Spn46 = 31410,
    /// <summary>SPN 703</summary>
    Spn703 = 31455,
    /// <summary>SPN 720</summary>
    Spn720 = 31475,
    /// <summary>SPN 728 (V) 1</summary>
    Spn728V1 = 31500,
    /// <summary>SPN 748</summary>
    Spn748 = 31545,
    /// <summary>SPN 750</summary>
    Spn750 = 31590,
    /// <summary>SPO-8</summary>
    Spo8 = 31592,
    /// <summary>SPN 753G</summary>
    Spn753g = 31593,
    Value31635 = 31635,
    /// <summary>P-12</summary>
    P12 = 31680,
    /// <summary>P-18</summary>
    P18 = 31681,
    /// <summary>P-18</summary>
    P1831682 = 31682,
    /// <summary>P-18</summary>
    P1831684 = 31684,
    /// <summary>P-18MH2</summary>
    P18mh2 = 31685,
    /// <summary>P-18MA</summary>
    P18ma = 31686,
    /// <summary>P-18MU</summary>
    P18mu = 31687,
    /// <summary>P-18 Malachite</summary>
    P18Malachite = 31688,
    /// <summary>P-18OU</summary>
    P18ou = 31689,
    Value31700 = 31700,
    /// <summary>SPQ 712 (RAN 12 L/X)</summary>
    Spq712Ran12LX = 31725,
    /// <summary>SPR-2</summary>
    Spr2 = 31730,
    /// <summary>SPR-51</summary>
    Spr51 = 31740,
    /// <summary>SPS-5 FASOL</summary>
    Sps5Fasol = 31765,
    /// <summary>SPS-6</summary>
    Sps6 = 31766,
    /// <summary>SPS 6C</summary>
    Sps6c = 31770,
    /// <summary>SPS 10F</summary>
    Sps10f = 31815,
    /// <summary>SPS 12</summary>
    Sps12 = 31860,
    /// <summary>SPS-22N BUKET</summary>
    Sps22nBuket = 31870,
    /// <summary>SPS-33N BUKET</summary>
    Sps33nBuket = 31875,
    /// <summary>SPS-44N BUKET</summary>
    Sps44nBuket = 31880,
    /// <summary>SPS-55N BUKET</summary>
    Sps55nBuket = 31890,
    /// <summary>SPS 58</summary>
    Sps58 = 31905,
    /// <summary>SPS-62</summary>
    Sps62 = 31925,
    /// <summary>SPS-100K</summary>
    Sps100k = 31935,
    /// <summary>SPS 64</summary>
    Sps64 = 31950,
    /// <summary>SPS-141</summary>
    Sps141 = 31951,
    /// <summary>SPS-142</summary>
    Sps142 = 31952,
    /// <summary>SPS-143</summary>
    Sps143 = 31953,
    /// <summary>SPS-151</summary>
    Sps151 = 31955,
    /// <summary>SPS-152</summary>
    Sps152 = 31956,
    /// <summary>SPS-153</summary>
    Sps153 = 31957,
    /// <summary>SPS-160 Geran</summary>
    Sps160Geran = 31959,
    /// <summary>SPS-161</summary>
    Sps161 = 31960,
    /// <summary>SPS-95K</summary>
    Sps95k = 31970,
    /// <summary>SPS-171 Jammer</summary>
    Sps171Jammer = 31971,
    /// <summary>SPS-172 Jammer</summary>
    Sps172Jammer = 31972,
    /// <summary>SPS 768 (RAN EL)</summary>
    Sps768RanEl = 31995,
    /// <summary>SPS-540K</summary>
    Sps540k = 32010,
    /// <summary>SPS-550K MF</summary>
    Sps550kMf = 32020,
    /// <summary>SPS 774 (RAN 10S)</summary>
    Sps774Ran10s = 32040,
    /// <summary>SPY 790</summary>
    Spy790 = 32085,
    Value32130 = 32130,
    Value32175 = 32175,
    Value32220 = 32220,
    Value32265 = 32265,
    /// <summary>Shmel</summary>
    Shmel = 32310,
    /// <summary>P-15M</summary>
    P15m = 32330,
    Value32355 = 32355,
    /// <summary>SQUIRE</summary>
    Squire = 32365,
    /// <summary>SR2410C</summary>
    Sr2410c = 32373,
    /// <summary>SR47B-G</summary>
    Sr47bG = 32375,
    /// <summary>SR-64 TAR (LD-2000)</summary>
    Sr64TarLd2000 = 32376,
    /// <summary>SRE-M5</summary>
    SreM5 = 32385,
    /// <summary>SRN 6</summary>
    Srn6 = 32400,
    /// <summary>SRN 15</summary>
    Srn15 = 32445,
    /// <summary>SRN 206</summary>
    Srn206 = 32455,
    /// <summary>SRN 745</summary>
    Srn745 = 32490,
    /// <summary>SRO 1</summary>
    Sro1 = 32535,
    /// <summary>SRO 2</summary>
    Sro2 = 32580,
    Value32625 = 32625,
    Value32670 = 32670,
    Value32715 = 32715,
    Value32760 = 32760,
    Value32805 = 32805,
    Value32850 = 32850,
    Value32851 = 32851,
    Value32852 = 32852,
    Value32895 = 32895,
    Value32940 = 32940,
    Value32985 = 32985,
    Value33025 = 33025,
    Value33030 = 33030,
    Value33075 = 33075,
    Value33120 = 33120,
    /// <summary>SS-N-10A FL-10 mmW MH</summary>
    SsN10aFl10MmWMh = 33125,
    /// <summary>SS-N-11 Nasr-1 mmW MH</summary>
    SsN11Nasr1MmWMh = 33140,
    Value33165 = 33165,
    /// <summary>SS-N-12 YJ-83J mmW MH</summary>
    SsN12Yj83jMmWMh = 33166,
    Value33210 = 33210,
    Value33230 = 33230,
    Value33231 = 33231,
    Value33255 = 33255,
    Value33300 = 33300,
    Value33345 = 33345,
    Value33390 = 33390,
    Value33435 = 33435,
    Value33480 = 33480,
    Value33481 = 33481,
    Value33483 = 33483,
    /// <summary>SS-N-26 Strobile MMW MH</summary>
    SsN26StrobileMmwMh = 33484,
    Value33485 = 33485,
    Value33486 = 33486,
    Value33505 = 33505,
    Value33510 = 33510,
    Value33511 = 33511,
    Value33525 = 33525,
    /// <summary>STR 41</summary>
    Str41 = 33570,
    /// <summary>ST-858</summary>
    St858 = 33580,
    /// <summary>START-1M</summary>
    Start1m = 33582,
    /// <summary>STENTOR</summary>
    Stentor = 33584,
    /// <summary>Storm Shadow AHR</summary>
    StormShadowAhr = 33585,
    /// <summary>STRAIGHT FLUSH</summary>
    StraightFlush = 33586,
    Value33590 = 33590,
    Value33595 = 33595,
    Value33600 = 33600,
    Value33615 = 33615,
    Value33660 = 33660,
    Value33705 = 33705,
    Value33750 = 33750,
    Value33795 = 33795,
    Value33840 = 33840,
    /// <summary>SUPERDARN</summary>
    Superdarn = 33850,
    /// <summary>Superfledermaus</summary>
    Superfledermaus = 33860,
    /// <summary>Supersearcher</summary>
    Supersearcher = 33870,
    Value33885 = 33885,
    Value33930 = 33930,
    /// <summary>SYMPHONY</summary>
    Symphony = 33933,
    /// <summary>SYNAPSIS Mk2</summary>
    SynapsisMk2 = 33935,
    /// <summary>SY80</summary>
    Sy80 = 33950,
    Value33975 = 33975,
    Value34020 = 34020,
    Value34040 = 34040,
    Value34065 = 34065,
    Value34110 = 34110,
    Value34155 = 34155,
    Value34200 = 34200,
    Value34245 = 34245,
    Value34290 = 34290,
    Value34335 = 34335,
    Value34380 = 34380,
    Value34425 = 34425,
    Value34470 = 34470,
    /// <summary>TA-10K</summary>
    Ta10k = 34480,
    /// <summary>JY-11B</summary>
    Jy11b = 34500,
    /// <summary>TACAN/SURF</summary>
    TacanSurf = 34505,
    /// <summary>P-14</summary>
    P1434515 = 34515,
    Value34516 = 34516,
    Value34517 = 34517,
    Value34560 = 34560,
    Value34605 = 34605,
    Value34606 = 34606,
    /// <summary>TDR-94 (MODE S)</summary>
    Tdr94ModeS = 34607,
    Value34610 = 34610,
    Value34620 = 34620,
    /// <summary>TALISMAN</summary>
    Talisman = 34624,
    Value34625 = 34625,
    /// <summary>T1135</summary>
    T1135 = 34626,
    /// <summary>TANCAN/SURF</summary>
    TancanSurf = 34627,
    /// <summary>TECSAR</summary>
    Tecsar = 34628,
    /// <summary>TERRASAR-X</summary>
    TerrasarX = 34629,
    /// <summary>TESAR</summary>
    Tesar = 34630,
    /// <summary>THAAD GBR</summary>
    ThaadGbr = 34640,
    /// <summary>Thales APAR Block2</summary>
    ThalesAparBlock2 = 34643,
    /// <summary>Thales RDY-2</summary>
    ThalesRdy2 = 34644,
    /// <summary>Thales Nederland Signaal APAR</summary>
    ThalesNederlandSignaalApar = 34645,
    /// <summary>Thales Scorpion Jammer</summary>
    ThalesScorpionJammer = 34646,
    /// <summary>Thales Variant</summary>
    ThalesVariant = 34647,
    /// <summary>Thales ICMS Jammer</summary>
    ThalesIcmsJammer = 34648,
    /// <summary>Thales IMEWS Jammer</summary>
    ThalesImewsJammer = 34649,
    /// <summary>THD 225</summary>
    Thd225 = 34650,
    /// <summary>THD 1012</summary>
    Thd1012 = 34655,
    /// <summary>THD 1098</summary>
    Thd1098 = 34660,
    /// <summary>THD 1213</summary>
    Thd1213 = 34665,
    /// <summary>THD 1940</summary>
    Thd1940 = 34670,
    /// <summary>THD-1955 Palmier</summary>
    Thd1955Palmier = 34680,
    /// <summary>THD 5500</summary>
    Thd5500 = 34695,
    /// <summary>Third of Khordad</summary>
    ThirdOfKhordad = 34700,
    Value34740 = 34740,
    /// <summary>PRV-9</summary>
    Prv9 = 34785,
    /// <summary>PRV-16</summary>
    Prv16 = 34786,
    Value34795 = 34795,
    Value34830 = 34830,
    Value34875 = 34875,
    Value34920 = 34920,
    Value34965 = 34965,
    /// <summary>Thomson-CSF Domino 30</summary>
    ThomsonCsfDomino30 = 34966,
    Value35010 = 35010,
    Value35055 = 35055,
    Value35100 = 35100,
    Value35145 = 35145,
    Value35190 = 35190,
    Value35235 = 35235,
    Value35280 = 35280,
    Value35325 = 35325,
    Value35370 = 35370,
    Value35415 = 35415,
    Value35460 = 35460,
    /// <summary>Thomson ENR (European Navy Radar)</summary>
    ThomsonEnrEuropeanNavyRadar = 35470,
    /// <summary>Thomson RDI</summary>
    ThomsonRdi = 35475,
    /// <summary>Tier II Plus</summary>
    TierIiPlus = 35477,
    /// <summary>TPS-755</summary>
    Tps755 = 35478,
    /// <summary>TPS-830K</summary>
    Tps830k = 35479,
    /// <summary>TRS-2105</summary>
    Trs2105 = 35480,
    /// <summary>TR-23K</summary>
    Tr23k = 35481,
    /// <summary>TR-23MR</summary>
    Tr23mr = 35482,
    /// <summary>TRAC-2100</summary>
    Trac2100 = 35483,
    /// <summary>TRAC-2300</summary>
    Trac2300 = 35484,
    /// <summary>HT-223</summary>
    Ht223 = 35485,
    /// <summary>TRADEX</summary>
    Tradex = 35486,
    /// <summary>TRAIL XI</summary>
    TrailXi = 35487,
    /// <summary>TRD-1211</summary>
    Trd1211 = 35488,
    /// <summary>TRD-1235</summary>
    Trd1235 = 35489,
    /// <summary>TRS-2100</summary>
    Trs2100 = 35490,
    /// <summary>TRAC NG</summary>
    TracNg = 35491,
    Value35505 = 35505,
    /// <summary>36D6</summary>
    Value36d6 = 35550,
    Value35570 = 35570,
    /// <summary>TIRSPONDER</summary>
    Tirsponder = 35580,
    /// <summary>TK-25E-5</summary>
    Tk25e5 = 35583,
    /// <summary>TMK Mk2</summary>
    TmkMk2 = 35585,
    /// <summary>TMX Mk2</summary>
    TmxMk2 = 35586,
    Value35595 = 35595,
    Value35640 = 35640,
    Value35685 = 35685,
    Value35730 = 35730,
    Value35775 = 35775,
    /// <summary>Token B</summary>
    TokenB = 35785,
    Value35800 = 35800,
    /// <summary>Tonson</summary>
    Tonson = 35810,
    Value35820 = 35820,
    Value35865 = 35865,
    Value35910 = 35910,
    Value35955 = 35955,
    Value36000 = 36000,
    Value36045 = 36045,
    Value36046 = 36046,
    Value36090 = 36090,
    /// <summary>TYPE-208</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Type208 = 36120,
    Value36135 = 36135,
    Value36180 = 36180,
    /// <summary>Tornado GMR</summary>
    TornadoGmr = 36200,
    /// <summary>Tornado TFR</summary>
    TornadoTfr = 36201,
    Value36220 = 36220,
    Value36225 = 36225,
    /// <summary>TOR-M2 TER</summary>
    TorM2Ter = 36226,
    Value36230 = 36230,
    Value36270 = 36270,
    /// <summary>TR-47C</summary>
    Tr47c = 36300,
    /// <summary>TORSO M</summary>
    TorsoM = 36315,
    /// <summary>TQN-2</summary>
    Tqn2 = 36320,
    Value36360 = 36360,
    /// <summary>TRD-1500</summary>
    Trd1500 = 36365,
    Value36370 = 36370,
    Value36371 = 36371,
    /// <summary>TRISPONDE</summary>
    Trisponde = 36380,
    /// <summary>TRML</summary>
    Trml = 36381,
    /// <summary>TRS-2215</summary>
    Trs2215 = 36382,
    /// <summary>TRML-3D</summary>
    Trml3d = 36383,
    /// <summary>TRM-S</summary>
    TrmS = 36384,
    /// <summary>TRS-2056</summary>
    Trs2056 = 36385,
    /// <summary>TRS 3010</summary>
    Trs3010 = 36386,
    /// <summary>TRS-2060</summary>
    Trs2060 = 36387,
    /// <summary>TRS-2245</summary>
    Trs2245 = 36388,
    /// <summary>TRS-2310</summary>
    Trs2310 = 36389,
    /// <summary>Triton G</summary>
    TritonG = 36390,
    /// <summary>TRS-22XX</summary>
    Trs22xx = 36391,
    /// <summary>TRS 3030</summary>
    Trs3030 = 36400,
    /// <summary>TRS 3033</summary>
    Trs3033 = 36405,
    /// <summary>TRS 3203</summary>
    Trs3203 = 36417,
    /// <summary>TRS 3405</summary>
    Trs3405 = 36420,
    /// <summary>TRS 3410</summary>
    Trs3410 = 36425,
    /// <summary>TRS 3415</summary>
    Trs3415 = 36430,
    /// <summary>TRS-3D</summary>
    Trs3d = 36440,
    /// <summary>TRS-3D/16</summary>
    Trs3d16 = 36441,
    /// <summary>TRS-3D/16-ES</summary>
    Trs3d16Es = 36442,
    /// <summary>TRS-3D/32</summary>
    Trs3d32 = 36443,
    /// <summary>TRS-4D</summary>
    Trs4d = 36446,
    /// <summary>TRS-C</summary>
    TrsC = 36447,
    /// <summary>TRS-N</summary>
    TrsN = 36450,
    /// <summary>TRML-4D</summary>
    Trml4d = 36455,
    /// <summary>TS-4478A</summary>
    Ts4478a = 36460,
    /// <summary>TSE 5000</summary>
    Tse5000 = 36495,
    /// <summary>TSR 333</summary>
    Tsr333 = 36540,
    /// <summary>TSR 793</summary>
    Tsr793 = 36550,
    Value36563 = 36563,
    Value36585 = 36585,
    /// <summary>TW 1374</summary>
    Tw1374 = 36590,
    /// <summary>TW 1378</summary>
    Tw1378 = 36595,
    /// <summary>TW 1446</summary>
    Tw1446 = 36600,
    Value36630 = 36630,
    Value36675 = 36675,
    Value36720 = 36720,
    Value36765 = 36765,
    Value36810 = 36810,
    /// <summary>Type 071 LPD</summary>
    Type071Lpd = 36821,
    /// <summary>Type 2-12 J/A</summary>
    Type212JA = 36827,
    /// <summary>Type 2-21 J/A</summary>
    Type221JA = 36830,
    /// <summary>Type 2-23</summary>
    Type223 = 36835,
    /// <summary>Type 80/ASM-1</summary>
    Type80Asm1 = 36836,
    /// <summary>Type 120</summary>
    Type120 = 36838,
    /// <summary>Type 208</summary>
    Type20836840 = 36840,
    /// <summary>Type 222</summary>
    Type222 = 36843,
    /// <summary>Type 226</summary>
    Type226 = 36846,
    /// <summary>Type 232H</summary>
    Type232h = 36850,
    /// <summary>TYPE 245</summary>
    Type245 = 36853,
    /// <summary>TYPE 262</summary>
    Type262 = 36855,
    /// <summary>TYPE 275</summary>
    Type275 = 36900,
    /// <summary>TYPE 278</summary>
    Type278 = 36905,
    /// <summary>TYPE 293</summary>
    Type293 = 36945,
    /// <summary>Type 341</summary>
    Type341 = 36946,
    /// <summary>TYPE 313</summary>
    Type313 = 36947,
    /// <summary>Type 305A</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Type305a = 36948,
    /// <summary>Type 334</summary>
    Type334 = 36960,
    /// <summary>Type 342</summary>
    Type342 = 36985,
    /// <summary>TYPE 343 SUN VISOR B</summary>
    Type343SunVisorB = 36990,
    /// <summary>Type 344</summary>
    Type344 = 36992,
    /// <summary>Type 345</summary>
    Type345 = 37010,
    /// <summary>Type 346</summary>
    Type346 = 37011,
    /// <summary>Type 349A</summary>
    Type349a = 37033,
    /// <summary>TYPE 347B</summary>
    Type347b = 37035,
    /// <summary>Type 347G</summary>
    Type347g = 37038,
    /// <summary>Type 359</summary>
    Type359 = 37039,
    /// <summary>Type 352</summary>
    Type352 = 37040,
    /// <summary>Type 360</summary>
    Type360 = 37041,
    /// <summary>Type 362 ESR-1 SR-47B</summary>
    Type362Esr1Sr47b = 37043,
    /// <summary>Type 354</summary>
    Type354 = 37045,
    /// <summary>Type 366</summary>
    Type366 = 37047,
    /// <summary>Type 363</summary>
    Type363 = 37048,
    /// <summary>Type 364</summary>
    Type364 = 37049,
    /// <summary>Type-404A(CH)</summary>
    Type404aCh = 37050,
    /// <summary>Type 405</summary>
    Type405 = 37052,
    /// <summary>TYPE 405J</summary>
    Type405j = 37053,
    /// <summary>Type 408D</summary>
    Type408d = 37058,
    /// <summary>Type 517B</summary>
    Type517b = 37059,
    /// <summary>Type 518 (Hai Ying, God Eye, REL-2)</summary>
    Type518HaiYingGodEyeRel2 = 37060,
    /// <summary>Type 589</summary>
    Type589 = 37070,
    /// <summary>TYPE 651</summary>
    Type651 = 37073,
    /// <summary>Type 753</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Type753 = 37075,
    /// <summary>Type 702</summary>
    Type702 = 37077,
    /// <summary>Type 704M (BL-904)</summary>
    Type704mBl904 = 37078,
    /// <summary>Type 753</summary>
    Type75337079 = 37079,
    /// <summary>Type 756</summary>
    Type756 = 37080,
    /// <summary>TYPE 713</summary>
    Type713 = 37081,
    /// <summary>TYPE 714</summary>
    Type714 = 37082,
    /// <summary>TYPE 702-D</summary>
    Type702D = 37083,
    /// <summary>TYPE 760</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Type760 = 37084,
    /// <summary>Type 760</summary>
    Type76037086 = 37086,
    /// <summary>Type 815</summary>
    Type815 = 37090,
    /// <summary>Type 793</summary>
    Type793 = 37095,
    /// <summary>Type 8A-813</summary>
    Type8a813 = 37100,
    /// <summary>TYPE 901M</summary>
    Type901m = 37105,
    /// <summary>Type 902 FCR</summary>
    Type902Fcr = 37110,
    /// <summary>Type 902B</summary>
    Type902b = 37124,
    /// <summary>TYPE 903</summary>
    Type903 = 37125,
    /// <summary>TYPE 909 TI</summary>
    Type909Ti = 37170,
    /// <summary>TYPE 909 TT</summary>
    Type909Tt = 37215,
    /// <summary>TYPE 910</summary>
    Type910 = 37260,
    /// <summary>TYPE-931(CH)</summary>
    Type931Ch = 37265,
    /// <summary>TYPE 965</summary>
    Type965 = 37305,
    /// <summary>TYPE 967</summary>
    Type967 = 37350,
    /// <summary>TYPE 968</summary>
    Type968 = 37395,
    /// <summary>TYPE 974</summary>
    Type974 = 37440,
    /// <summary>TYPE 975</summary>
    Type975 = 37485,
    /// <summary>TYPE 978</summary>
    Type978 = 37530,
    /// <summary>Type 981</summary>
    Type981 = 37534,
    /// <summary>Type 981-3</summary>
    Type9813 = 37535,
    /// <summary>TYPE 982</summary>
    Type982 = 37540,
    /// <summary>Type 984</summary>
    Type984 = 37543,
    /// <summary>Type 985</summary>
    Type985 = 37544,
    /// <summary>TYPE 992</summary>
    Type992 = 37575,
    /// <summary>TYPE 993</summary>
    Type993 = 37620,
    /// <summary>TYPE 994</summary>
    Type994 = 37665,
    /// <summary>Type 996</summary>
    Type996 = 37670,
    /// <summary>Type 997 Artisan</summary>
    Type997Artisan = 37675,
    /// <summary>TYPE 1006(1)</summary>
    Type10061 = 37710,
    /// <summary>TYPE 1006(2)</summary>
    Type10062 = 37755,
    /// <summary>TYPE 1022</summary>
    Type1022 = 37800,
    /// <summary>Type 1047</summary>
    Type1047 = 37810,
    /// <summary>Type 1048</summary>
    Type1048 = 37815,
    /// <summary>Type 1474</summary>
    Type1474 = 37825,
    /// <summary>Type 1493</summary>
    Type1493 = 37828,
    /// <summary>ULTRA</summary>
    Ultra = 37840,
    /// <summary>UK MK 10</summary>
    UkMk10 = 37845,
    /// <summary>UPS-220C</summary>
    Ups220c = 37850,
    /// <summary>UPX 1 10</summary>
    Upx110 = 37890,
    /// <summary>UPX 27</summary>
    Upx27 = 37935,
    /// <summary>URN 20</summary>
    Urn20 = 37980,
    /// <summary>UTES-A</summary>
    UtesA = 37985,
    /// <summary>UTES-T</summary>
    UtesT = 37990,
    /// <summary>URN 25</summary>
    Urn25 = 38025,
    /// <summary>VIGILANT</summary>
    Vigilant = 38035,
    /// <summary>Vitebsk L370 Jammer</summary>
    VitebskL370Jammer = 38038,
    /// <summary>VOLEX III/IV</summary>
    VolexIiiIv = 38045,
    /// <summary>VOLGA</summary>
    Volga = 38046,
    /// <summary>VORONEZH-DM</summary>
    VoronezhDm = 38047,
    /// <summary>VOSTOK</summary>
    Vostok = 38048,
    /// <summary>VOSTOK-E</summary>
    VostokE = 38049,
    /// <summary>VSR</summary>
    Vsr = 38050,
    /// <summary>VOSTOK-3D</summary>
    Vostok3d = 38051,
    /// <summary>VSTAR-PT</summary>
    VstarPt = 38055,
    /// <summary>W-160</summary>
    W160 = 38058,
    /// <summary>W1028</summary>
    W1028 = 38060,
    /// <summary>W8818</summary>
    W8818 = 38070,
    /// <summary>W8838</summary>
    W8838 = 38115,
    /// <summary>W8852</summary>
    W8852 = 38120,
    Value38140 = 38140,
    Value38150 = 38150,
    /// <summary>WAS-74S</summary>
    Was74s = 38160,
    Value38205 = 38205,
    /// <summary>WATCHDOG</summary>
    Watchdog = 38210,
    Value38250 = 38250,
    /// <summary>Watchman</summary>
    Watchman = 38260,
    /// <summary>WAVESTORM</summary>
    Wavestorm = 38270,
    /// <summary>WATCHMAN-S</summary>
    WatchmanS = 38275,
    /// <summary>WATCHMAN-T</summary>
    WatchmanT = 38276,
    /// <summary>WEATHER SCOUT 2</summary>
    WeatherScout2 = 38280,
    Value38295 = 38295,
    Value38320 = 38320,
    Value38340 = 38340,
    Value38385 = 38385,
    Value38430 = 38430,
    Value38475 = 38475,
    /// <summary>Wet Eye</summary>
    WetEye = 38520,
    /// <summary>Wet Eye 2</summary>
    WetEye2 = 38525,
    /// <summary>Wet Eye Mod</summary>
    WetEyeMod = 38565,
    /// <summary>WF44S</summary>
    Wf44s = 38568,
    /// <summary>WGU-41/B</summary>
    Wgu41B = 38570,
    /// <summary>WGU-44/B</summary>
    Wgu44B = 38572,
    Value38610 = 38610,
    Value38655 = 38655,
    Value38700 = 38700,
    Value38715 = 38715,
    Value38730 = 38730,
    /// <summary>Wine Glass Jammer</summary>
    WineGlassJammer = 38735,
    /// <summary>Wild Card</summary>
    WildCard = 38745,
    /// <summary>WILDCAT</summary>
    Wildcat = 38748,
    Value38790 = 38790,
    Value38835 = 38835,
    /// <summary>WLR</summary>
    Wlr = 38840,
    /// <summary>WM2X Series</summary>
    Wm2xSeries = 38880,
    /// <summary>WM2X Series CAS</summary>
    Wm2xSeriesCas = 38925,
    /// <summary>WR-10X</summary>
    Wr10x = 38930,
    /// <summary>WR-2100</summary>
    Wr2100 = 38935,
    /// <summary>WSR-74C</summary>
    Wsr74c = 38950,
    /// <summary>WSR-74S</summary>
    Wsr74s = 38955,
    /// <summary>WSR-81</summary>
    Wsr81 = 38957,
    /// <summary>WXR-700C</summary>
    Wxr700c = 38960,
    /// <summary>WXR-2100 MSTT</summary>
    Wxr2100Mstt = 38965,
    /// <summary>WXR-2100MSTT</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Wxr2100mstt = 38966,
    Value38970 = 38970,
    /// <summary>X-TAR25</summary>
    XTar25 = 38990,
    /// <summary>X-TAR3D</summary>
    XTar3d = 38995,
    /// <summary>YAOGAN 3</summary>
    Yaogan3 = 39000,
    /// <summary>Yaogan-29</summary>
    Yaogan29 = 39014,
    Value39015 = 39015,
    /// <summary>YH-96</summary>
    Yh96 = 39050,
    Value39060 = 39060,
    /// <summary>YITIAN ADS</summary>
    YitianAds = 39061,
    /// <summary>YD-3</summary>
    Yd3 = 39062,
    /// <summary>YJ-12 MH</summary>
    Yj12Mh = 39063,
    /// <summary>YJ-62 MH</summary>
    Yj62Mh = 39065,
    /// <summary>YJ-82 MH</summary>
    Yj82Mh = 39066,
    /// <summary>YJ-83 MH</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    Yj83Mh = 39067,
    /// <summary>YJ-63</summary>
    Yj63 = 39068,
    /// <summary>YLC-2</summary>
    Ylc2 = 39070,
    /// <summary>YLC-2A</summary>
    Ylc2a = 39071,
    /// <summary>YLC-4</summary>
    Ylc4 = 39073,
    /// <summary>YLC-6</summary>
    Ylc6 = 39074,
    /// <summary>YLC-6M</summary>
    Ylc6m = 39075,
    /// <summary>YLC-8</summary>
    Ylc8 = 39080,
    /// <summary>YLC-8B</summary>
    Ylc8b = 39081,
    /// <summary>YLC-18</summary>
    Ylc18 = 39085,
    Value39105 = 39105,
    /// <summary>Zaslon-A</summary>
    ZaslonA = 39110,
    /// <summary>Zaslon Multi-purpose (X- and S-band)</summary>
    ZaslonMultiPurposeXAndSBand = 39112,
    /// <summary>ZBD-08 Recon Surveillance</summary>
    Zbd08ReconSurveillance = 39115,
    /// <summary>Zoo Park 1</summary>
    ZooPark1 = 39125,
    /// <summary>ZPS-6</summary>
    Zps6 = 39126,
    /// <summary>ZOOPARK-3</summary>
    Zoopark3 = 39127,
    /// <summary>ZOOPARK-1M</summary>
    Zoopark1m = 39128,
    /// <summary>ZD-12</summary>
    Zd12 = 39131,
    /// <summary>ZW-06</summary>
    Zw06 = 39150,
    /// <summary>AN/ALQ-136(V)1</summary>
    AnAlq136V1 = 39200,
    /// <summary>AN/ALQ-136(V)2</summary>
    AnAlq136V2 = 39201,
    /// <summary>AN/ALQ-136(V)3</summary>
    AnAlq136V3 = 39202,
    /// <summary>AN/ALQ-136(V)4</summary>
    AnAlq136V4 = 39203,
    /// <summary>AN/ALQ-136(V)5</summary>
    AnAlq136V5 = 39204,
    /// <summary>AN/ALQ-162(V)2</summary>
    AnAlq162V2 = 39210,
    /// <summary>AN/ALQ-162(V)3</summary>
    AnAlq162V3 = 39211,
    /// <summary>AN/ALQ-162(V)4</summary>
    AnAlq162V4 = 39212,
    /// <summary>Zhuk-M</summary>
    ZhukM = 45300,
    /// <summary>ZHUK-MAE</summary>
    ZhukMae = 45303,
    /// <summary>ZHUK-ME</summary>
    ZhukMe = 45304,
    /// <summary>ZHUK-MME</summary>
    ZhukMme = 45305,
    /// <summary>Zhuk-MSE</summary>
    ZhukMse = 45307,
}

/// <summary>SISO-REF-010 v36 enumeration UID 76.</summary>
public enum EmitterSystemFunction : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Multi-function</summary>
    MultiFunction = 1,
    /// <summary>Early Warning/Surveillance</summary>
    EarlyWarningSurveillance = 2,
    /// <summary>Height Finder</summary>
    HeightFinder = 3,
    /// <summary>Fire Control</summary>
    FireControl = 4,
    /// <summary>Acquisition/Detection</summary>
    AcquisitionDetection = 5,
    /// <summary>Tracker</summary>
    Tracker = 6,
    /// <summary>Guidance/Illumination</summary>
    GuidanceIllumination = 7,
    /// <summary>Firing point/launch point location</summary>
    FiringPointLaunchPointLocation = 8,
    /// <summary>Range-Only</summary>
    RangeOnly = 9,
    /// <summary>Radar Altimeter</summary>
    RadarAltimeter = 10,
    /// <summary>Imaging</summary>
    Imaging = 11,
    /// <summary>Motion Detection</summary>
    MotionDetection = 12,
    /// <summary>Navigation</summary>
    Navigation = 13,
    /// <summary>Weather / Meteorological</summary>
    WeatherMeteorological = 14,
    /// <summary>Instrumentation</summary>
    Instrumentation = 15,
    /// <summary>Identification/Classification (including IFF)</summary>
    IdentificationClassificationIncludingIff = 16,
    /// <summary>AAA (Anti-Aircraft Artillery) Fire Control</summary>
    AaaAntiAircraftArtilleryFireControl = 17,
    /// <summary>Air Search/Bomb</summary>
    AirSearchBomb = 18,
    /// <summary>Air Intercept</summary>
    AirIntercept = 19,
    /// <summary>Altimeter</summary>
    Altimeter = 20,
    /// <summary>Air Mapping</summary>
    AirMapping = 21,
    /// <summary>Air Traffic Control</summary>
    AirTrafficControl = 22,
    /// <summary>Beacon</summary>
    Beacon = 23,
    /// <summary>Battlefield Surveillance</summary>
    BattlefieldSurveillance = 24,
    /// <summary>Ground Control Approach</summary>
    GroundControlApproach = 25,
    /// <summary>Ground Control Intercept</summary>
    GroundControlIntercept = 26,
    /// <summary>Coastal Surveillance</summary>
    CoastalSurveillance = 27,
    /// <summary>Decoy/Mimic</summary>
    DecoyMimic = 28,
    /// <summary>Data Transmission</summary>
    DataTransmission = 29,
    /// <summary>Earth Surveillance</summary>
    EarthSurveillance = 30,
    /// <summary>Gun Lay Beacon</summary>
    GunLayBeacon = 31,
    /// <summary>Ground Mapping</summary>
    GroundMapping = 32,
    /// <summary>Harbor Surveillance</summary>
    HarborSurveillance = 33,
    /// <summary>IFF (Identify Friend or Foe)</summary>
    IffIdentifyFriendOrFoe = 34,
    /// <summary>ILS (Instrument Landing System)</summary>
    IlsInstrumentLandingSystem = 35,
    /// <summary>Ionospheric Sound</summary>
    IonosphericSound = 36,
    /// <summary>Interrogator</summary>
    Interrogator = 37,
    /// <summary>Barrage Jamming</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    BarrageJamming = 38,
    /// <summary>Click Jamming</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    ClickJamming = 39,
    /// <summary>Deceptive Jamming</summary>
    DeceptiveJamming = 40,
    /// <summary>Frequency Swept Jamming</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    FrequencySweptJamming = 41,
    /// <summary>Jammer</summary>
    Jammer = 42,
    /// <summary>Noise Jamming</summary>
    NoiseJamming = 43,
    /// <summary>Pulsed Jamming</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    PulsedJamming = 44,
    /// <summary>Repeater Jamming</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    RepeaterJamming = 45,
    /// <summary>Spot Noise Jamming</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SpotNoiseJamming = 46,
    /// <summary>Missile Acquisition</summary>
    MissileAcquisition = 47,
    /// <summary>Missile Downlink</summary>
    MissileDownlink = 48,
    /// <summary>Meteorological</summary>
    Meteorological = 49,
    /// <summary>Space</summary>
    Space = 50,
    /// <summary>Surface Search</summary>
    SurfaceSearch = 51,
    /// <summary>Shell Tracking</summary>
    ShellTracking = 52,
    /// <summary>Television</summary>
    Television = 56,
    /// <summary>Unknown</summary>
    Unknown = 57,
    /// <summary>Video Remoting</summary>
    VideoRemoting = 58,
    /// <summary>Experimental or Training</summary>
    ExperimentalOrTraining = 59,
    /// <summary>Missile Guidance</summary>
    MissileGuidance = 60,
    /// <summary>Missile Homing</summary>
    MissileHoming = 61,
    /// <summary>Missile Tracking</summary>
    MissileTracking = 62,
    /// <summary>Jamming, noise</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    JammingNoise = 64,
    /// <summary>Jamming, deception</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    JammingDeception = 65,
    /// <summary>Decoy</summary>
    Decoy = 66,
    /// <summary>Navigation/Distance Measuring Equipment</summary>
    NavigationDistanceMeasuringEquipment = 71,
    /// <summary>Terrain Following</summary>
    TerrainFollowing = 72,
    /// <summary>Weather Avoidance</summary>
    WeatherAvoidance = 73,
    /// <summary>Proximity Fuse</summary>
    ProximityFuse = 74,
    /// <summary>Instrumentation</summary>
    Instrumentation75 = 75,
    /// <summary>Radiosonde</summary>
    Radiosonde = 76,
    /// <summary>Sonobuoy</summary>
    Sonobuoy = 77,
    /// <summary>Bathythermal Sensor</summary>
    BathythermalSensor = 78,
    /// <summary>Towed Counter Measure</summary>
    TowedCounterMeasure = 79,
    /// <summary>Dipping Sonar</summary>
    DippingSonar = 80,
    /// <summary>Towed Acoustic Sensor</summary>
    TowedAcousticSensor = 81,
    /// <summary>Weapon, non-lethal</summary>
    WeaponNonLethal = 96,
    /// <summary>Weapon, lethal</summary>
    WeaponLethal = 97,
    /// <summary>Test Equipment</summary>
    TestEquipment = 98,
    /// <summary>Acquisition Track</summary>
    AcquisitionTrack = 99,
    /// <summary>Track Guidance</summary>
    TrackGuidance = 100,
    /// <summary>Guidance Illumination Track Acquisition</summary>
    GuidanceIlluminationTrackAcquisition = 101,
    /// <summary>Search Acquisition</summary>
    SearchAcquisition = 102,
    /// <summary>Dropsonde</summary>
    Dropsonde = 103,
}

/// <summary>SISO-REF-010 v36 enumeration UID 319.</summary>
public enum EntityAssociationAssociationType : byte
{
    /// <summary>Not Specified</summary>
    NotSpecified = 0,
    /// <summary>Physical Association (General/Object 1)</summary>
    PhysicalAssociationGeneralObject1 = 1,
    /// <summary>Functional Association (General)</summary>
    FunctionalAssociationGeneral = 2,
    /// <summary>Association Broken</summary>
    AssociationBroken = 3,
    /// <summary>Physical Association (Object 2)</summary>
    PhysicalAssociationObject2 = 4,
    /// <summary>Functional Association (Object 1)</summary>
    FunctionalAssociationObject1 = 5,
    /// <summary>Functional Association (Object 2)</summary>
    FunctionalAssociationObject2 = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 321.</summary>
public enum EntityAssociationGroupMemberType : byte
{
    /// <summary>Not Part of a Group</summary>
    NotPartOfAGroup = 0,
    /// <summary>Group Leader</summary>
    GroupLeader = 1,
    /// <summary>Group Member</summary>
    GroupMember = 2,
    /// <summary>Formation Leader</summary>
    FormationLeader = 3,
    /// <summary>Formation Member</summary>
    FormationMember = 4,
    /// <summary>Convoy Leader</summary>
    ConvoyLeader = 5,
    /// <summary>Convoy Member</summary>
    ConvoyMember = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 323.</summary>
public enum EntityAssociationPhysicalAssociationType : byte
{
    /// <summary>Not Specified</summary>
    NotSpecified = 0,
    /// <summary>Towed in Air (Single Hook, Not Specified)</summary>
    TowedInAirSingleHookNotSpecified = 1,
    /// <summary>Towed on Land</summary>
    TowedOnLand = 2,
    /// <summary>Towed on Water Surface</summary>
    TowedOnWaterSurface = 3,
    /// <summary>Towed Underwater</summary>
    TowedUnderwater = 4,
    /// <summary>Mounted Attached</summary>
    MountedAttached = 5,
    /// <summary>Mounted Unattached and Unsupported</summary>
    MountedUnattachedAndUnsupported = 6,
    /// <summary>Mounted Unattached and Supported</summary>
    MountedUnattachedAndSupported = 7,
    /// <summary>Towed in Air (Center Hook)</summary>
    TowedInAirCenterHook = 8,
    /// <summary>Towed in Air (Forward Hook)</summary>
    TowedInAirForwardHook = 9,
    /// <summary>Towed in Air (Aft Hook)</summary>
    TowedInAirAftHook = 10,
    /// <summary>Towed in Air (Tandem Hook - Fore and Aft)</summary>
    TowedInAirTandemHookForeAndAft = 11,
    /// <summary>Towed in Air (Mismanaged Tandem - Fore and Center)</summary>
    TowedInAirMismanagedTandemForeAndCenter = 12,
    /// <summary>Towed in Air (Mismanaged Tandem - Center and Aft)</summary>
    TowedInAirMismanagedTandemCenterAndAft = 13,
    /// <summary>Towed in Air (All Hooks)</summary>
    TowedInAirAllHooks = 14,
    /// <summary>Hoisted</summary>
    Hoisted = 15,
    /// <summary>Restrained to a Life Form</summary>
    RestrainedToALifeForm = 30,
    /// <summary>Restrained to a Platform</summary>
    RestrainedToAPlatform = 31,
    /// <summary>Restrained to an Object</summary>
    RestrainedToAnObject = 32,
    /// <summary>Refueling Operation</summary>
    RefuelingOperation = 61,
    /// <summary>Search and Rescue Basket</summary>
    SearchAndRescueBasket = 62,
    /// <summary>Search and Rescue Rescue Collar</summary>
    SearchAndRescueRescueCollar = 63,
    /// <summary>Engagement/Object 2 is Being Engaged</summary>
    EngagementObject2IsBeingEngaged = 64,
    /// <summary>Return To Base/Object 2 is the Destination Object</summary>
    ReturnToBaseObject2IsTheDestinationObject = 65,
    /// <summary>Line between Communication Towers</summary>
    LineBetweenCommunicationTowers = 90,
    /// <summary>Line Between Power Towers</summary>
    LineBetweenPowerTowers = 91,
    /// <summary>Indoors</summary>
    Indoors = 92,
    /// <summary>Top Surface</summary>
    TopSurface = 93,
}

/// <summary>SISO-REF-010 v36 enumeration UID 324.</summary>
public enum EntityAssociationPhysicalConnectionType : byte
{
    /// <summary>Not Specified</summary>
    NotSpecified = 0,
    /// <summary>Attached Directly to Surface</summary>
    AttachedDirectlyToSurface = 1,
    /// <summary>Cable Wire</summary>
    CableWire = 2,
    /// <summary>Rope</summary>
    Rope = 3,
    /// <summary>Chain</summary>
    Chain = 4,
    /// <summary>Power Line</summary>
    PowerLine = 5,
    /// <summary>Telephone Line</summary>
    TelephoneLine = 6,
    /// <summary>Cable Line</summary>
    CableLine = 7,
    /// <summary>Refueling Drogue</summary>
    RefuelingDrogue = 8,
    /// <summary>Refueling Boom</summary>
    RefuelingBoom = 9,
    /// <summary>Handcuffs</summary>
    Handcuffs = 10,
    /// <summary>In Contact With</summary>
    InContactWith = 11,
    /// <summary>Fast Rope</summary>
    FastRope = 12,
}

/// <summary>SISO-REF-010 v36 bitfield UID 55. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct EntityCapabilities(uint Value)
{
    public static EntityCapabilities None => new(0);

    public static implicit operator EntityCapabilities(uint value) => new(value);
    public static implicit operator uint(EntityCapabilities value) => value.Value;
    public override string ToString() => $"0x{Value:X8}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 314.</summary>
public enum EntityDamageStatusComponentIdentification : byte
{
    /// <summary>Entity Center (No Specific Component)</summary>
    EntityCenterNoSpecificComponent = 0,
    /// <summary>Entity Structure</summary>
    EntityStructure = 1,
    /// <summary>Control System</summary>
    ControlSystem = 2,
    /// <summary>Control Surface</summary>
    ControlSurface = 3,
    /// <summary>Engine / Propulsion System</summary>
    EnginePropulsionSystem = 4,
    /// <summary>Crew Member</summary>
    CrewMember = 5,
    /// <summary>Fuse</summary>
    Fuse = 6,
    /// <summary>Acquisition Sensor</summary>
    AcquisitionSensor = 7,
    /// <summary>Tracking Sensor</summary>
    TrackingSensor = 8,
    /// <summary>Fuel Tank / Solid Rocket Motor</summary>
    FuelTankSolidRocketMotor = 9,
}

/// <summary>SISO-REF-010 v36 enumeration UID 7.</summary>
public enum EntityKind : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Platform</summary>
    Platform = 1,
    /// <summary>Munition</summary>
    Munition = 2,
    /// <summary>Life form</summary>
    LifeForm = 3,
    /// <summary>Environmental</summary>
    Environmental = 4,
    /// <summary>Cultural feature</summary>
    CulturalFeature = 5,
    /// <summary>Supply</summary>
    Supply = 6,
    /// <summary>Radio</summary>
    Radio = 7,
    /// <summary>Expendable</summary>
    Expendable = 8,
    /// <summary>Sensor/Emitter</summary>
    SensorEmitter = 9,
    /// <summary>Command and Control (C2) Logical Object</summary>
    CommandAndControlC2LogicalObject = 10,
}

/// <summary>SISO-REF-010 v36 enumeration UID 45.</summary>
public enum EntityMarkingCharacterSet : byte
{
    /// <summary>Unused</summary>
    Unused = 0,
    /// <summary>ASCII</summary>
    Ascii = 1,
    /// <summary>U.S. Army Marking</summary>
    USArmyMarking = 2,
    /// <summary>Digit Chevron</summary>
    DigitChevron = 3,
    /// <summary>UTF-8</summary>
    Utf8 = 4,
}

/// <summary>SISO-REF-010 v36 enumeration UID 320.</summary>
public enum EntityVpRecordChangeIndicator : byte
{
    /// <summary>Initial Report or No Change Since Last Issuance</summary>
    InitialReportOrNoChangeSinceLastIssuance = 0,
    /// <summary>Change Since Last Issuance</summary>
    ChangeSinceLastIssuance = 1,
}

/// <summary>SISO-REF-010 v36 bitfield UID 249. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct EnvironmentalProcessEnvironmentStatus(byte Value)
{
    public static EnvironmentalProcessEnvironmentStatus None => new(0);

    /// <summary>Indicates that the current update shall be the last update for the specified process</summary>
    public bool IsLast => (Value & 1) != 0;
    public EnvironmentalProcessEnvironmentStatus WithIsLast(bool value) => new((byte)(value ? Value | 1 : Value & ~1));

    /// <summary>Describes whether the environmental process is active or not</summary>
    public bool IsActive => (Value & 2) != 0;
    public EnvironmentalProcessEnvironmentStatus WithIsActive(bool value) => new((byte)(value ? Value | 2 : Value & ~2));

    public static implicit operator EnvironmentalProcessEnvironmentStatus(byte value) => new(value);
    public static implicit operator byte(EnvironmentalProcessEnvironmentStatus value) => value.Value;
    public override string ToString() => $"0x{Value:X2}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 248.</summary>
public enum EnvironmentalProcessModelType : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 250.</summary>
public enum EnvironmentalProcessRecordType : uint
{
    /// <summary>COMBIC State</summary>
    CombicState = 256u,
    /// <summary>Flare State</summary>
    FlareState = 259u,
    /// <summary>Bounding Sphere Record</summary>
    BoundingSphereRecord = 65536u,
    /// <summary>Uniform Geometry Record</summary>
    UniformGeometryRecord = 327680u,
    /// <summary>Point Record 1</summary>
    PointRecord1 = 655360u,
    /// <summary>Line Record 1</summary>
    LineRecord1 = 786432u,
    /// <summary>Sphere Record 1</summary>
    SphereRecord1 = 851968u,
    /// <summary>Ellipsoid Record 1</summary>
    EllipsoidRecord1 = 1048576u,
    /// <summary>Cone Record 1</summary>
    ConeRecord1 = 3145728u,
    /// <summary>Rectangular Volume Record 1</summary>
    RectangularVolumeRecord1 = 5242880u,
    /// <summary>Rectangular Volume Record 3</summary>
    RectangularVolumeRecord3 = 83886080u,
    /// <summary>Point Record 2</summary>
    PointRecord2 = 167772160u,
    /// <summary>Line Record 2</summary>
    LineRecord2 = 201326592u,
    /// <summary>Sphere Record 2</summary>
    SphereRecord2 = 218103808u,
    /// <summary>Ellipsoid Record 2</summary>
    EllipsoidRecord2 = 268435456u,
    /// <summary>Cone Record 2</summary>
    ConeRecord2 = 805306368u,
    /// <summary>Rectangular Volume Record 2</summary>
    RectangularVolumeRecord2 = 1342177280u,
    /// <summary>Gaussian Plume Record</summary>
    GaussianPlumeRecord = 1610612736u,
    /// <summary>Gaussian Puff Record</summary>
    GaussianPuffRecord = 1879048192u,
}

/// <summary>SISO-REF-010 v36 enumeration UID 73.</summary>
public enum EventReportEventType : uint
{
    /// <summary>Other</summary>
    Other = 0u,
    /// <summary>Ran Out of Ammunition</summary>
    RanOutOfAmmunition = 2u,
    /// <summary>Killed in Action (KIA)</summary>
    KilledInActionKia = 3u,
    /// <summary>Damage</summary>
    Damage = 4u,
    /// <summary>Mobility Disabled</summary>
    MobilityDisabled = 5u,
    /// <summary>Fire Disabled</summary>
    FireDisabled = 6u,
    /// <summary>Ran Out of Fuel</summary>
    RanOutOfFuel = 7u,
    /// <summary>Entity Initialization</summary>
    EntityInitialization = 8u,
    /// <summary>Request for Indirect Fire or CAS Mission</summary>
    RequestForIndirectFireOrCasMission = 9u,
    /// <summary>Indirect Fire or CAS Fire</summary>
    IndirectFireOrCasFire = 10u,
    /// <summary>Minefield Entry</summary>
    MinefieldEntry = 11u,
    /// <summary>Minefield Detonation</summary>
    MinefieldDetonation = 12u,
    /// <summary>Vehicle Master Power On</summary>
    VehicleMasterPowerOn = 13u,
    /// <summary>Vehicle Master Power Off</summary>
    VehicleMasterPowerOff = 14u,
    /// <summary>Aggregate State Change Requested</summary>
    AggregateStateChangeRequested = 15u,
    /// <summary>Prevent Collision / Detonation</summary>
    PreventCollisionDetonation = 16u,
    /// <summary>Ownership Report</summary>
    OwnershipReport = 17u,
    /// <summary>Radar Perception</summary>
    RadarPerception = 18u,
    /// <summary>Detect</summary>
    Detect = 19u,
}

/// <summary>SISO-REF-010 v36 enumeration UID 310.</summary>
public enum ExplosiveMaterialCategories : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>AVGAS (Aviation Gas)</summary>
    AvgasAviationGas = 10,
    /// <summary>Jet Fuel (Unspecified)</summary>
    JetFuelUnspecified = 11,
    /// <summary>JP-4 (F-40/JET B)</summary>
    Jp4F40JetB = 12,
    /// <summary>JP-5 (F-44/JET A)</summary>
    Jp5F44JetA = 13,
    /// <summary>JP-7</summary>
    Jp7 = 14,
    /// <summary>JP-8 (F-34/JET A-1)</summary>
    Jp8F34JetA1 = 15,
    /// <summary>JP-10 Missile Fuel</summary>
    Jp10MissileFuel = 16,
    /// <summary>JPTS</summary>
    Jpts = 17,
    /// <summary>Jet A</summary>
    JetA = 18,
    /// <summary>Jet A-1</summary>
    JetA1 = 19,
    /// <summary>Jet B</summary>
    JetB = 20,
    /// <summary>Jet Biofuel</summary>
    JetBiofuel = 21,
    /// <summary>Gasoline/Petrol (Unspecified Octane)</summary>
    GasolinePetrolUnspecifiedOctane = 151,
    /// <summary>Diesel Fuel (Unspecified Grade)</summary>
    DieselFuelUnspecifiedGrade = 152,
    /// <summary>Ethanol</summary>
    Ethanol = 153,
    /// <summary>E85 Ethanol</summary>
    E85Ethanol = 154,
    /// <summary>Fuel Oil</summary>
    FuelOil = 155,
    /// <summary>Kerosene</summary>
    Kerosene = 156,
    /// <summary>Crude Oil (Unspecified)</summary>
    CrudeOilUnspecified = 157,
    /// <summary>Light Crude Oil</summary>
    LightCrudeOil = 158,
    /// <summary>Liquid Petroleum Gas (LPG)</summary>
    LiquidPetroleumGasLpg = 159,
    /// <summary>RP-1 Rocket Fuel</summary>
    Rp1RocketFuel = 160,
    /// <summary>LH-2 Rocket Fuel</summary>
    Lh2RocketFuel = 161,
    /// <summary>LOX Rocket Fuel</summary>
    LoxRocketFuel = 162,
    /// <summary>Alcohol</summary>
    Alcohol = 164,
    /// <summary>Hydrogen (Liquid)</summary>
    HydrogenLiquid = 166,
    /// <summary>Nitroglycerin (NG)</summary>
    NitroglycerinNg = 301,
    /// <summary>ANFO</summary>
    Anfo = 302,
    /// <summary>Dynamite</summary>
    Dynamite = 451,
    /// <summary>TNT</summary>
    Tnt = 452,
    /// <summary>RDX</summary>
    Rdx = 453,
    /// <summary>PETN</summary>
    Petn = 454,
    /// <summary>HMX</summary>
    Hmx = 455,
    /// <summary>C-4</summary>
    C4 = 456,
    /// <summary>Composition C-4</summary>
    CompositionC4 = 457,
    /// <summary>Natural Gas (NG)</summary>
    NaturalGasNg = 601,
    /// <summary>Butane</summary>
    Butane = 602,
    /// <summary>Propane</summary>
    Propane = 603,
    /// <summary>Helium</summary>
    Helium = 604,
    /// <summary>Hydrogen (Gaseous)</summary>
    HydrogenGaseous = 605,
    /// <summary>Dust (Unspecified Type)</summary>
    DustUnspecifiedType = 801,
    /// <summary>Grain Dust</summary>
    GrainDust = 802,
    /// <summary>Flour Dust</summary>
    FlourDust = 803,
    /// <summary>Sugar Dust</summary>
    SugarDust = 804,
}

/// <summary>SISO-REF-010 v36 enumeration UID 6.</summary>
public enum ForceId : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Friendly</summary>
    Friendly = 1,
    /// <summary>Opposing</summary>
    Opposing = 2,
    /// <summary>Neutral</summary>
    Neutral = 3,
    /// <summary>Friendly 2</summary>
    Friendly2 = 4,
    /// <summary>Opposing 2</summary>
    Opposing2 = 5,
    /// <summary>Neutral 2</summary>
    Neutral2 = 6,
    /// <summary>Friendly 3</summary>
    Friendly3 = 7,
    /// <summary>Opposing 3</summary>
    Opposing3 = 8,
    /// <summary>Neutral 3</summary>
    Neutral3 = 9,
    /// <summary>Friendly 4</summary>
    Friendly4 = 10,
    /// <summary>Opposing 4</summary>
    Opposing4 = 11,
    /// <summary>Neutral 4</summary>
    Neutral4 = 12,
    /// <summary>Friendly 5</summary>
    Friendly5 = 13,
    /// <summary>Opposing 5</summary>
    Opposing5 = 14,
    /// <summary>Neutral 5</summary>
    Neutral5 = 15,
    /// <summary>Friendly 6</summary>
    Friendly6 = 16,
    /// <summary>Opposing 6</summary>
    Opposing6 = 17,
    /// <summary>Neutral 6</summary>
    Neutral6 = 18,
    /// <summary>Friendly 7</summary>
    Friendly7 = 19,
    /// <summary>Opposing 7</summary>
    Opposing7 = 20,
    /// <summary>Neutral 7</summary>
    Neutral7 = 21,
    /// <summary>Friendly 8</summary>
    Friendly8 = 22,
    /// <summary>Opposing 8</summary>
    Opposing8 = 23,
    /// <summary>Neutral 8</summary>
    Neutral8 = 24,
    /// <summary>Friendly 9</summary>
    Friendly9 = 25,
    /// <summary>Opposing 9</summary>
    Opposing9 = 26,
    /// <summary>Neutral 9</summary>
    Neutral9 = 27,
    /// <summary>Friendly 10</summary>
    Friendly10 = 28,
    /// <summary>Opposing 10</summary>
    Opposing10 = 29,
    /// <summary>Neutral 10</summary>
    Neutral10 = 30,
}

/// <summary>SISO-REF-010 v36 enumeration UID 329.</summary>
public enum FuelLocation : byte
{
    /// <summary>Other</summary>
    Other = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 328.</summary>
public enum FuelMeasurementUnits : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Liter</summary>
    Liter = 1,
    /// <summary>Kilogram</summary>
    Kilogram = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 377.</summary>
public enum GridAxisDescriptorAxisType : byte
{
    /// <summary>Regular Axis</summary>
    RegularAxis = 0,
    /// <summary>Irregular Axis</summary>
    IrregularAxis = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 245.</summary>
public enum GriddedDataConstantGrid : byte
{
    /// <summary>Constant grid</summary>
    ConstantGrid = 0,
    /// <summary>Updated grid</summary>
    UpdatedGrid = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 244.</summary>
public enum GriddedDataCoordinateSystem : ushort
{
    /// <summary>Right handed Cartesian (local topographic projection: east, north, up)</summary>
    RightHandedCartesianLocalTopographicProjectionEastNorthUp = 0,
    /// <summary>Left handed Cartesian (local topographic projection: east, north, down)</summary>
    LeftHandedCartesianLocalTopographicProjectionEastNorthDown = 1,
    /// <summary>Latitude, Longitude, Height</summary>
    LatitudeLongitudeHeight = 2,
    /// <summary>Latitude, Longitude, Depth</summary>
    LatitudeLongitudeDepth = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 247.</summary>
public enum GriddedDataDataRepresentation : ushort
{
    /// <summary>Type 0</summary>
    Type0 = 0,
    /// <summary>Type 1</summary>
    Type1 = 1,
    /// <summary>Type 2</summary>
    Type2 = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 246.</summary>
public enum GriddedDataSampleType : ushort
{
    /// <summary>Not Specified</summary>
    NotSpecified = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 79.</summary>
public enum HighDensityTrackJam : byte
{
    /// <summary>Not Selected</summary>
    NotSelected = 0,
    /// <summary>Selected</summary>
    Selected = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 339.</summary>
public enum IffApplicableModes : byte
{
    /// <summary>No Applicable Modes Data</summary>
    NoApplicableModesData = 0,
    /// <summary>All Modes</summary>
    AllModes = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 84.</summary>
public enum IffSystemMode : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Off</summary>
    Off = 1,
    /// <summary>Standby</summary>
    Standby = 2,
    /// <summary>Normal</summary>
    Normal = 3,
    /// <summary>Emergency</summary>
    Emergency = 4,
    /// <summary>Low or Low Sensitivity</summary>
    LowOrLowSensitivity = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 83.</summary>
public enum IffSystemName : ushort
{
    /// <summary>Not Used (Invalid Value)</summary>
    NotUsedInvalidValue = 0,
    /// <summary>Generic Mark X</summary>
    GenericMarkX = 1,
    /// <summary>Generic Mark XII</summary>
    GenericMarkXii = 2,
    /// <summary>Generic ATCRBS</summary>
    GenericAtcrbs = 3,
    /// <summary>Generic Soviet</summary>
    GenericSoviet = 4,
    /// <summary>Generic Mode S</summary>
    GenericModeS = 5,
    /// <summary>Generic Mark X/XII/ATCRBS</summary>
    GenericMarkXXiiAtcrbs = 6,
    /// <summary>Generic Mark X/XII/ATCRBS/Mode S</summary>
    GenericMarkXXiiAtcrbsModeS = 7,
    /// <summary>ARI 5954 (RRB)</summary>
    Ari5954Rrb = 8,
    /// <summary>ARI 5983 (RRB)</summary>
    Ari5983Rrb = 9,
    /// <summary>Generic RRB</summary>
    GenericRrb = 10,
    /// <summary>Generic Mark XIIA</summary>
    GenericMarkXiia = 11,
    /// <summary>Generic Mode 5</summary>
    GenericMode5 = 12,
    /// <summary>Generic Mark XIIA Combined Interrogator/Transponder (CIT)</summary>
    GenericMarkXiiaCombinedInterrogatorTransponderCit = 13,
    /// <summary>Generic Mark XII Combined Interrogator/Transponder (CIT)</summary>
    GenericMarkXiiCombinedInterrogatorTransponderCit = 14,
    /// <summary>Generic TCAS I/ACAS I Transceiver</summary>
    GenericTcasIAcasITransceiver = 15,
    /// <summary>Generic TCAS II/ACAS II Transceiver</summary>
    GenericTcasIiAcasIiTransceiver = 16,
    /// <summary>Generic Mark X (A)</summary>
    GenericMarkXA = 17,
    /// <summary>Generic Mark X (SIF)</summary>
    GenericMarkXSif = 18,
}

/// <summary>SISO-REF-010 v36 enumeration UID 82.</summary>
public enum IffSystemType : ushort
{
    /// <summary>Not Used (Invalid Value)</summary>
    NotUsedInvalidValue = 0,
    /// <summary>Mark X/XII/ATCRBS Transponder</summary>
    MarkXXiiAtcrbsTransponder = 1,
    /// <summary>Mark X/XII/ATCRBS Interrogator</summary>
    MarkXXiiAtcrbsInterrogator = 2,
    /// <summary>Soviet Transponder</summary>
    SovietTransponder = 3,
    /// <summary>Soviet Interrogator</summary>
    SovietInterrogator = 4,
    /// <summary>RRB Transponder</summary>
    RrbTransponder = 5,
    /// <summary>Mark XIIA Interrogator</summary>
    MarkXiiaInterrogator = 6,
    /// <summary>Mode 5 Interrogator</summary>
    Mode5Interrogator = 7,
    /// <summary>Mode S Interrogator</summary>
    ModeSInterrogator = 8,
    /// <summary>Mark XIIA Transponder</summary>
    MarkXiiaTransponder = 9,
    /// <summary>Mode 5 Transponder</summary>
    Mode5Transponder = 10,
    /// <summary>Mode S Transponder</summary>
    ModeSTransponder = 11,
    /// <summary>Mark XIIA Combined Interrogator/Transponder (CIT)</summary>
    MarkXiiaCombinedInterrogatorTransponderCit = 12,
    /// <summary>Mark XII Combined Interrogator/Transponder (CIT)</summary>
    MarkXiiCombinedInterrogatorTransponderCit = 13,
    /// <summary>TCAS/ACAS Transceiver</summary>
    TcasAcasTransceiver = 14,
}

/// <summary>SISO-REF-010 v36 enumeration UID 288.</summary>
public enum IoActionIoActionPhase : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Start Attack Profile</summary>
    StartAttackProfile = 1,
    /// <summary>End Attack Profile</summary>
    EndAttackProfile = 2,
    /// <summary>Continue Attack Profile with Changes</summary>
    ContinueAttackProfileWithChanges = 3,
    /// <summary>Start Attack Effects</summary>
    StartAttackEffects = 4,
    /// <summary>End Attacked Effects</summary>
    EndAttackedEffects = 5,
    /// <summary>Continue Attack Effects with Changes</summary>
    ContinueAttackEffectsWithChanges = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 287.</summary>
public enum IoActionIoActionType : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>IO Attack - Profile Data (Parametrics)</summary>
    IoAttackProfileDataParametrics = 1,
    /// <summary>IO Attack - Computed Effects</summary>
    IoAttackComputedEffects = 2,
    /// <summary>Intent-Based-EW</summary>
    IntentBasedEw = 3,
    /// <summary>Intent-Based-EW - Computed Effects</summary>
    IntentBasedEwComputedEffects = 4,
}

/// <summary>SISO-REF-010 v36 enumeration UID 286.</summary>
public enum IoActionIoSimulationSource : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 285.</summary>
public enum IoActionIoWarfareType : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Electronic Warfare (EW)</summary>
    ElectronicWarfareEw = 1,
    /// <summary>Computer Network Operations (CNO)</summary>
    ComputerNetworkOperationsCno = 2,
    /// <summary>Psychological Operations (PSYOPS)</summary>
    PsychologicalOperationsPsyops = 3,
    /// <summary>Military Deception (MILDEC)</summary>
    MilitaryDeceptionMildec = 4,
    /// <summary>Operations Security (OPSEC)</summary>
    OperationsSecurityOpsec = 5,
    /// <summary>Physical Attack</summary>
    PhysicalAttack = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 294.</summary>
public enum IoCommsNodeRecordCommsNodeType : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Sender Node ID</summary>
    SenderNodeId = 1,
    /// <summary>Receiver Node ID</summary>
    ReceiverNodeId = 2,
    /// <summary>Sender/Receiver Node ID</summary>
    SenderReceiverNodeId = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 292.</summary>
public enum IoEffectsRecordIoEffect : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Denial</summary>
    Denial = 1,
    /// <summary>Degradation</summary>
    Degradation = 2,
    /// <summary>Disruption</summary>
    Disruption = 3,
    /// <summary>Terminate Effect</summary>
    TerminateEffect = 255,
}

/// <summary>SISO-REF-010 v36 enumeration UID 291.</summary>
public enum IoEffectsRecordIoLinkType : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Logical Link</summary>
    LogicalLink = 1,
    /// <summary>Physical Node</summary>
    PhysicalNode = 2,
    /// <summary>Physical Link</summary>
    PhysicalLink = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 293.</summary>
public enum IoEffectsRecordIoProcess : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 290.</summary>
public enum IoEffectsRecordIoStatus : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Effect on Sender</summary>
    EffectOnSender = 1,
    /// <summary>Effect on Receiver</summary>
    EffectOnReceiver = 2,
    /// <summary>Effect on Sender and Receiver</summary>
    EffectOnSenderAndReceiver = 3,
    /// <summary>Effect on Message</summary>
    EffectOnMessage = 4,
    /// <summary>Effect on Sender and Message</summary>
    EffectOnSenderAndMessage = 5,
    /// <summary>Effect on Receiver and Message</summary>
    EffectOnReceiverAndMessage = 6,
    /// <summary>Effect on Sender, Receiver, and Message</summary>
    EffectOnSenderReceiverAndMessage = 7,
}

/// <summary>SISO-REF-010 v36 enumeration UID 289.</summary>
public enum IoReportIoReportType : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Initial Report</summary>
    InitialReport = 1,
    /// <summary>Update Report</summary>
    UpdateReport = 2,
    /// <summary>Final Report</summary>
    FinalReport = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 182.</summary>
public enum IntercomControlCommand : byte
{
    /// <summary>No Command</summary>
    NoCommand = 0,
    /// <summary>Status</summary>
    Status = 1,
    /// <summary>Connect</summary>
    Connect = 2,
    /// <summary>Disconnect</summary>
    Disconnect = 3,
    /// <summary>Reset</summary>
    Reset = 4,
    /// <summary>On</summary>
    On = 5,
    /// <summary>Off</summary>
    Off = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 180.</summary>
public enum IntercomControlControlType : byte
{
    /// <summary>Reserved</summary>
    Reserved = 0,
    /// <summary>Status</summary>
    Status = 1,
    /// <summary>Request - Acknowledge Required</summary>
    RequestAcknowledgeRequired = 2,
    /// <summary>Request - No Acknowledge</summary>
    RequestNoAcknowledge = 3,
    /// <summary>Ack - Request Granted</summary>
    AckRequestGranted = 4,
    /// <summary>Nack - Request Denied</summary>
    NackRequestDenied = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 185.</summary>
public enum IntercomControlRecordType : ushort
{
    /// <summary>Specific Destination record</summary>
    SpecificDestinationRecord = 1,
    /// <summary>Group Destination record</summary>
    GroupDestinationRecord = 2,
    /// <summary>Group Assignment record</summary>
    GroupAssignmentRecord = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 183.</summary>
public enum IntercomControlTransmitLineState : byte
{
    /// <summary>Transmit Line State not applicable</summary>
    TransmitLineStateNotApplicable = 0,
    /// <summary>Not Transmitting</summary>
    NotTransmitting = 1,
    /// <summary>Transmitting</summary>
    Transmitting = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 213.</summary>
public enum IsGroupOfGroupedEntityCategory : byte
{
    /// <summary>Undefined</summary>
    Undefined = 0,
    /// <summary>Basic Ground Combat Vehicle</summary>
    BasicGroundCombatVehicle = 1,
    /// <summary>Enhanced Ground Combat Vehicle</summary>
    EnhancedGroundCombatVehicle = 2,
    /// <summary>Basic Ground Combat Soldier</summary>
    BasicGroundCombatSoldier = 3,
    /// <summary>Enhanced Ground Combat Soldier</summary>
    EnhancedGroundCombatSoldier = 4,
    /// <summary>Basic Rotor Wing Aircraft</summary>
    BasicRotorWingAircraft = 5,
    /// <summary>Enhanced Rotor Wing Aircraft</summary>
    EnhancedRotorWingAircraft = 6,
    /// <summary>Basic Fixed Wing Aircraft</summary>
    BasicFixedWingAircraft = 7,
    /// <summary>Enhanced Fixed Wing Aircraft</summary>
    EnhancedFixedWingAircraft = 8,
    /// <summary>Ground Logistics Vehicle</summary>
    GroundLogisticsVehicle = 9,
}

/// <summary>SISO-REF-010 v36 enumeration UID 210.</summary>
public enum IsPartOfNature : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Host-fireable munition</summary>
    HostFireableMunition = 1,
    /// <summary>Munition carried as cargo</summary>
    MunitionCarriedAsCargo = 2,
    /// <summary>Fuel carried as cargo</summary>
    FuelCarriedAsCargo = 3,
    /// <summary>Gunmount attached to host</summary>
    GunmountAttachedToHost = 4,
    /// <summary>Computer generated forces carried as cargo</summary>
    ComputerGeneratedForcesCarriedAsCargo = 5,
    /// <summary>Vehicle carried as cargo</summary>
    VehicleCarriedAsCargo = 6,
    /// <summary>Emitter mounted on host</summary>
    EmitterMountedOnHost = 7,
    /// <summary>Mobile command and control entity carried aboard host</summary>
    MobileCommandAndControlEntityCarriedAboardHost = 8,
    /// <summary>Entity stationed at position with respect to host</summary>
    EntityStationedAtPositionWithRespectToHost = 9,
    /// <summary>Team member in formation with</summary>
    TeamMemberInFormationWith = 10,
}

/// <summary>SISO-REF-010 v36 enumeration UID 211.</summary>
public enum IsPartOfPosition : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>On top of</summary>
    OnTopOf = 1,
    /// <summary>Inside of</summary>
    InsideOf = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 212.</summary>
public enum IsPartOfStationName : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Aircraft Wingstation</summary>
    AircraftWingstation = 1,
    /// <summary>Ship's Forward Gunmount (Starboard)</summary>
    ShipSForwardGunmountStarboard = 2,
    /// <summary>Ship's Forward Gunmount (Port)</summary>
    ShipSForwardGunmountPort = 3,
    /// <summary>Ship's Forward Gunmount (Centerline)</summary>
    ShipSForwardGunmountCenterline = 4,
    /// <summary>Ship's Aft Gunmount (Starboard)</summary>
    ShipSAftGunmountStarboard = 5,
    /// <summary>Ship's Aft Gunmount (Port)</summary>
    ShipSAftGunmountPort = 6,
    /// <summary>Ship's Aft Gunmount (Centerline)</summary>
    ShipSAftGunmountCenterline = 7,
    /// <summary>Forward Torpedo Tube</summary>
    ForwardTorpedoTube = 8,
    /// <summary>Aft Torpedo Tube</summary>
    AftTorpedoTube = 9,
    /// <summary>Bomb Bay</summary>
    BombBay = 10,
    /// <summary>Cargo Bay</summary>
    CargoBay = 11,
    /// <summary>Truck Bed</summary>
    TruckBed = 12,
    /// <summary>Trailer Bed</summary>
    TrailerBed = 13,
    /// <summary>Well Deck</summary>
    WellDeck = 14,
    /// <summary>On Station Range and Bearing</summary>
    OnStationRangeAndBearing = 15,
    /// <summary>On Station xyz</summary>
    OnStationXyz = 16,
    /// <summary>Air-to-Air Refueling Boom</summary>
    AirToAirRefuelingBoom = 17,
    /// <summary>Aerial Refueling Receptacle</summary>
    AerialRefuelingReceptacle = 18,
    /// <summary>Port Side Refueling Drogue</summary>
    PortSideRefuelingDrogue = 19,
    /// <summary>Starboard Side Refueling Drogue</summary>
    StarboardSideRefuelingDrogue = 20,
    /// <summary>Center Refueling Drogue</summary>
    CenterRefuelingDrogue = 21,
    /// <summary>Air Refueling Probe</summary>
    AirRefuelingProbe = 22,
}

/// <summary>SISO-REF-010 v36 bitfield UID 192. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct MinefieldDataFusing(ushort Value)
{
    public static MinefieldDataFusing None => new(0);

    /// <summary>Identifies the type of the primary fuse</summary>
    public ushort Primary => (ushort)((Value >> 0) & 127);
    public MinefieldDataFusing WithPrimary(ushort value)
    {
        if (value > 127) throw new ArgumentOutOfRangeException(nameof(value));
        return new((ushort)((Value & ~127) | ((ushort)(value << 0) & 127)));
    }

    /// <summary>Identifies the type of the secondary fuse</summary>
    public ushort Secondary => (ushort)((Value >> 7) & 127);
    public MinefieldDataFusing WithSecondary(ushort value)
    {
        if (value > 127) throw new ArgumentOutOfRangeException(nameof(value));
        return new((ushort)((Value & ~16256) | ((ushort)(value << 7) & 16256)));
    }

    /// <summary>Describes whether the mine has an Anti-Handling device</summary>
    public bool HasAntiHandlingDevice => (Value & 16384) != 0;
    public MinefieldDataFusing WithHasAntiHandlingDevice(bool value) => new((ushort)(value ? Value | 16384 : Value & ~16384));

    public static implicit operator MinefieldDataFusing(ushort value) => new(value);
    public static implicit operator ushort(MinefieldDataFusing value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 bitfield UID 202. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct MinefieldDataPaintScheme(byte Value)
{
    public static MinefieldDataPaintScheme None => new(0);

    /// <summary>Identifies the algae build-up on the mine</summary>
    public byte Algae => (byte)((Value >> 0) & 3);
    public MinefieldDataPaintScheme WithAlgae(byte value)
    {
        if (value > 3) throw new ArgumentOutOfRangeException(nameof(value));
        return new((byte)((Value & ~3) | ((byte)(value << 0) & 3)));
    }

    /// <summary>Identifies the paint scheme of the mine</summary>
    public byte PaintScheme => (byte)((Value >> 2) & 63);
    public MinefieldDataPaintScheme WithPaintScheme(byte value)
    {
        if (value > 63) throw new ArgumentOutOfRangeException(nameof(value));
        return new((byte)((Value & ~252) | ((byte)(value << 2) & 252)));
    }

    public static implicit operator MinefieldDataPaintScheme(byte value) => new(value);
    public static implicit operator byte(MinefieldDataPaintScheme value) => value.Value;
    public override string ToString() => $"0x{Value:X2}";
}

/// <summary>SISO-REF-010 v36 bitfield UID 190. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct MinefieldStateAppearanceBitMap(ushort Value)
{
    public static MinefieldStateAppearanceBitMap None => new(0);

    /// <summary>Identifies the type of minefield</summary>
    public ushort MinefieldType => (ushort)((Value >> 0) & 3);
    public MinefieldStateAppearanceBitMap WithMinefieldType(ushort value)
    {
        if (value > 3) throw new ArgumentOutOfRangeException(nameof(value));
        return new((ushort)((Value & ~3) | ((ushort)(value << 0) & 3)));
    }

    /// <summary>Describes whether the minefield is active or inactive</summary>
    public bool ActiveStatus => (Value & 4) != 0;
    public MinefieldStateAppearanceBitMap WithActiveStatus(bool value) => new((ushort)(value ? Value | 4 : Value & ~4));

    /// <summary>Identifies whether the minefield has an active or inactive lane</summary>
    public bool Lane => (Value & 8) != 0;
    public MinefieldStateAppearanceBitMap WithLane(bool value) => new((ushort)(value ? Value | 8 : Value & ~8));

    /// <summary>Describes the state of the minefield</summary>
    public bool State => (Value & 8192) != 0;
    public MinefieldStateAppearanceBitMap WithState(bool value) => new((ushort)(value ? Value | 8192 : Value & ~8192));

    public static implicit operator MinefieldStateAppearanceBitMap(ushort value) => new(value);
    public static implicit operator ushort(MinefieldStateAppearanceBitMap value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 61.</summary>
public enum MunitionDescriptorFuse : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Intelligent Influence</summary>
    IntelligentInfluence = 10,
    /// <summary>Sensor</summary>
    Sensor = 20,
    /// <summary>Self-destruct</summary>
    SelfDestruct = 30,
    /// <summary>Ultra Quick</summary>
    UltraQuick = 40,
    /// <summary>Body</summary>
    Body = 50,
    /// <summary>Deep Intrusion</summary>
    DeepIntrusion = 60,
    /// <summary>Multifunction</summary>
    Multifunction = 100,
    /// <summary>Point Detonation (PD)</summary>
    PointDetonationPd = 200,
    /// <summary>Base Detonation (BD)</summary>
    BaseDetonationBd = 300,
    /// <summary>Contact</summary>
    Contact = 1000,
    /// <summary>Contact, Instant (Impact)</summary>
    ContactInstantImpact = 1100,
    /// <summary>Contact, Delayed</summary>
    ContactDelayed = 1200,
    /// <summary>Contact, Delayed, 10 ms Delay</summary>
    ContactDelayed10MsDelay = 1201,
    /// <summary>Contact, Delayed, 20 ms Delay</summary>
    ContactDelayed20MsDelay = 1202,
    /// <summary>Contact, Delayed, 50 ms Delay</summary>
    ContactDelayed50MsDelay = 1205,
    /// <summary>Contact, Delayed, 60 ms Delay</summary>
    ContactDelayed60MsDelay = 1206,
    /// <summary>Contact, Delayed, 100 ms Delay</summary>
    ContactDelayed100MsDelay = 1210,
    /// <summary>Contact, Delayed, 125 ms Delay</summary>
    ContactDelayed125MsDelay = 1212,
    /// <summary>Contact, Delayed, 250 ms Delay</summary>
    ContactDelayed250MsDelay = 1225,
    /// <summary>Contact, Delayed, 5 ms Delay</summary>
    ContactDelayed5MsDelay = 1250,
    /// <summary>Contact, Delayed, 15 ms Delay</summary>
    ContactDelayed15MsDelay = 1251,
    /// <summary>Contact, Delayed, 25 ms Delay</summary>
    ContactDelayed25MsDelay = 1252,
    /// <summary>Contact, Delayed, 30 ms Delay</summary>
    ContactDelayed30MsDelay = 1253,
    /// <summary>Contact, Delayed, 35 ms Delay</summary>
    ContactDelayed35MsDelay = 1254,
    /// <summary>Contact, Delayed, 40 ms Delay</summary>
    ContactDelayed40MsDelay = 1255,
    /// <summary>Contact, Delayed, 45 ms Delay</summary>
    ContactDelayed45MsDelay = 1256,
    /// <summary>Contact, Delayed, 90 ms Delay</summary>
    ContactDelayed90MsDelay = 1257,
    /// <summary>Contact, Delayed, 120 ms Delay</summary>
    ContactDelayed120MsDelay = 1258,
    /// <summary>Contact, Delayed, 180 ms Delay</summary>
    ContactDelayed180MsDelay = 1259,
    /// <summary>Contact, Delayed, 240 ms Delay</summary>
    ContactDelayed240MsDelay = 1260,
    /// <summary>Contact, Electronic (Oblique Contact)</summary>
    ContactElectronicObliqueContact = 1300,
    /// <summary>Contact, Graze</summary>
    ContactGraze = 1400,
    /// <summary>Contact, Crush</summary>
    ContactCrush = 1500,
    /// <summary>Contact, Hydrostatic</summary>
    ContactHydrostatic = 1600,
    /// <summary>Contact, Mechanical</summary>
    ContactMechanical = 1700,
    /// <summary>Contact, Chemical</summary>
    ContactChemical = 1800,
    /// <summary>Contact, Piezoelectric</summary>
    ContactPiezoelectric = 1900,
    /// <summary>Contact, Point Initiating</summary>
    ContactPointInitiating = 1910,
    /// <summary>Contact, Point Initiating, Base Detonating</summary>
    ContactPointInitiatingBaseDetonating = 1920,
    /// <summary>Contact, Base Detonating</summary>
    ContactBaseDetonating = 1930,
    /// <summary>Contact, Ballistic Cap and Base</summary>
    ContactBallisticCapAndBase = 1940,
    /// <summary>Contact, Base</summary>
    ContactBase = 1950,
    /// <summary>Contact, Nose</summary>
    ContactNose = 1960,
    /// <summary>Contact, Fitted in Standoff Probe</summary>
    ContactFittedInStandoffProbe = 1970,
    /// <summary>Contact, Non-aligned</summary>
    ContactNonAligned = 1980,
    /// <summary>Timed</summary>
    Timed = 2000,
    /// <summary>Timed, Programmable</summary>
    TimedProgrammable = 2100,
    /// <summary>Timed, Burnout</summary>
    TimedBurnout = 2200,
    /// <summary>Timed, Pyrotechnic</summary>
    TimedPyrotechnic = 2300,
    /// <summary>Timed, Electronic</summary>
    TimedElectronic = 2400,
    /// <summary>Timed, Base Delay</summary>
    TimedBaseDelay = 2500,
    /// <summary>Timed, Reinforced Nose Impact Delay</summary>
    TimedReinforcedNoseImpactDelay = 2600,
    /// <summary>Timed, Short Delay Impact</summary>
    TimedShortDelayImpact = 2700,
    /// <summary>Timed, Short Delay Impact, 10 ms Delay</summary>
    TimedShortDelayImpact10MsDelay = 2701,
    /// <summary>Timed, Short Delay Impact, 20 ms Delay</summary>
    TimedShortDelayImpact20MsDelay = 2702,
    /// <summary>Timed, Short Delay Impact, 50 ms Delay</summary>
    TimedShortDelayImpact50MsDelay = 2705,
    /// <summary>Timed, Short Delay Impact, 60 ms Delay</summary>
    TimedShortDelayImpact60MsDelay = 2706,
    /// <summary>Timed, Short Delay Impact, 100 ms Delay</summary>
    TimedShortDelayImpact100MsDelay = 2710,
    /// <summary>Timed, Short Delay Impact, 125 ms Delay</summary>
    TimedShortDelayImpact125MsDelay = 2712,
    /// <summary>Timed, Short Delay Impact, 250 ms Delay</summary>
    TimedShortDelayImpact250MsDelay = 2725,
    /// <summary>Timed, Nose Mounted Variable Delay</summary>
    TimedNoseMountedVariableDelay = 2800,
    /// <summary>Timed, Long Delay Side</summary>
    TimedLongDelaySide = 2900,
    /// <summary>Timed, Selectable Delay</summary>
    TimedSelectableDelay = 2910,
    /// <summary>Timed, Impact</summary>
    TimedImpact = 2920,
    /// <summary>Timed, Sequence</summary>
    TimedSequence = 2930,
    /// <summary>Proximity</summary>
    Proximity = 3000,
    /// <summary>Proximity, Active Laser</summary>
    ProximityActiveLaser = 3100,
    /// <summary>Proximity, Magnetic (Magpolarity)</summary>
    ProximityMagneticMagpolarity = 3200,
    /// <summary>Proximity, Active Radar (Doppler Radar)</summary>
    ProximityActiveRadarDopplerRadar = 3300,
    /// <summary>Proximity, Radio Frequency (RF)</summary>
    ProximityRadioFrequencyRf = 3400,
    /// <summary>Proximity, Programmable</summary>
    ProximityProgrammable = 3500,
    /// <summary>Proximity, Programmable, Prefragmented</summary>
    ProximityProgrammablePrefragmented = 3600,
    /// <summary>Proximity, Infrared</summary>
    ProximityInfrared = 3700,
    /// <summary>Command</summary>
    Command = 4000,
    /// <summary>Command, Electronic, Remotely Set</summary>
    CommandElectronicRemotelySet = 4100,
    /// <summary>Altitude</summary>
    Altitude = 5000,
    /// <summary>Altitude, Radio Altimeter</summary>
    AltitudeRadioAltimeter = 5100,
    /// <summary>Altitude, Air Burst</summary>
    AltitudeAirBurst = 5200,
    /// <summary>Depth</summary>
    Depth = 6000,
    /// <summary>Acoustic</summary>
    Acoustic = 7000,
    /// <summary>Pressure</summary>
    Pressure = 8000,
    /// <summary>Pressure, Delay</summary>
    PressureDelay = 8010,
    /// <summary>Inert</summary>
    Inert = 8100,
    /// <summary>Dummy</summary>
    Dummy = 8110,
    /// <summary>Practice</summary>
    Practice = 8120,
    /// <summary>Plug Representing</summary>
    PlugRepresenting = 8130,
    /// <summary>Training</summary>
    Training = 8150,
    /// <summary>Pyrotechnic</summary>
    Pyrotechnic = 9000,
    /// <summary>Pyrotechnic, Delay</summary>
    PyrotechnicDelay = 9010,
    /// <summary>Electro-optical</summary>
    ElectroOptical = 9100,
    /// <summary>Electromechanical</summary>
    Electromechanical = 9110,
    /// <summary>Electromechanical, Nose</summary>
    ElectromechanicalNose = 9120,
    /// <summary>Strikerless</summary>
    Strikerless = 9200,
    /// <summary>Strikerless, Nose Impact</summary>
    StrikerlessNoseImpact = 9210,
    /// <summary>Strikerless, Compression-Ignition</summary>
    StrikerlessCompressionIgnition = 9220,
    /// <summary>Compression-Ignition</summary>
    CompressionIgnition = 9300,
    /// <summary>Compression-Ignition, Strikerless, Nose Impact</summary>
    CompressionIgnitionStrikerlessNoseImpact = 9310,
    /// <summary>Percussion</summary>
    Percussion = 9400,
    /// <summary>Percussion, Instantaneous</summary>
    PercussionInstantaneous = 9410,
    /// <summary>Electronic</summary>
    Electronic = 9500,
    /// <summary>Electronic, Internally Mounted</summary>
    ElectronicInternallyMounted = 9510,
    /// <summary>Electronic, Range Setting</summary>
    ElectronicRangeSetting = 9520,
    /// <summary>Electronic, Programmed</summary>
    ElectronicProgrammed = 9530,
    /// <summary>Mechanical</summary>
    Mechanical = 9600,
    /// <summary>Mechanical, Nose</summary>
    MechanicalNose = 9610,
    /// <summary>Mechanical, Tail</summary>
    MechanicalTail = 9620,
}

/// <summary>SISO-REF-010 v36 enumeration UID 60.</summary>
public enum MunitionDescriptorWarhead : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Cargo (Variable Submunitions)</summary>
    CargoVariableSubmunitions = 10,
    /// <summary>Fuel/Air Explosive</summary>
    FuelAirExplosive = 20,
    /// <summary>Glass Beads</summary>
    GlassBeads = 30,
    /// <summary>1 um</summary>
    Value1Um = 31,
    /// <summary>5 um</summary>
    Value5Um = 32,
    /// <summary>10 um</summary>
    Value10Um = 33,
    /// <summary>High Explosive (HE)</summary>
    HighExplosiveHe = 1000,
    /// <summary>HE, Plastic</summary>
    HePlastic = 1100,
    /// <summary>HE, Incendiary</summary>
    HeIncendiary = 1200,
    /// <summary>HE, Fragmentation</summary>
    HeFragmentation = 1300,
    /// <summary>HE, Anti-Tank</summary>
    HeAntiTank = 1400,
    /// <summary>HE, Bomblets</summary>
    HeBomblets = 1500,
    /// <summary>HE, Shaped Charge</summary>
    HeShapedCharge = 1600,
    /// <summary>HE, Continuous Rod</summary>
    HeContinuousRod = 1610,
    /// <summary>HE, Tungsten Ball</summary>
    HeTungstenBall = 1615,
    /// <summary>HE, Blast Fragmentation</summary>
    HeBlastFragmentation = 1620,
    /// <summary>HE, Steerable Darts with HE</summary>
    HeSteerableDartsWithHe = 1625,
    /// <summary>HE, Darts</summary>
    HeDarts = 1630,
    /// <summary>HE, Flechettes</summary>
    HeFlechettes = 1635,
    /// <summary>HE, Directed Fragmentation</summary>
    HeDirectedFragmentation = 1640,
    /// <summary>HE, Semi-Armor Piercing (SAP)</summary>
    HeSemiArmorPiercingSap = 1645,
    /// <summary>HE, Shaped Charge Fragmentation</summary>
    HeShapedChargeFragmentation = 1650,
    /// <summary>HE, Semi-Armor Piercing, Fragmentation</summary>
    HeSemiArmorPiercingFragmentation = 1655,
    /// <summary>HE, Hollow Charge</summary>
    HeHollowCharge = 1660,
    /// <summary>HE, Double Hollow Charge</summary>
    HeDoubleHollowCharge = 1665,
    /// <summary>HE, General Purpose</summary>
    HeGeneralPurpose = 1670,
    /// <summary>HE, Blast Penetrator</summary>
    HeBlastPenetrator = 1675,
    /// <summary>HE, Rod Penetrator</summary>
    HeRodPenetrator = 1680,
    /// <summary>HE, Anti-Personnel</summary>
    HeAntiPersonnel = 1685,
    /// <summary>HE, Shaped Charge, Fragmentation, Incendiary</summary>
    HeShapedChargeFragmentationIncendiary = 1690,
    /// <summary>HE, Penetrator, Blast, Fragmentation</summary>
    HePenetratorBlastFragmentation = 1695,
    /// <summary>Smoke</summary>
    Smoke = 2000,
    /// <summary>WP (White Phosphorus)</summary>
    WpWhitePhosphorus = 2005,
    /// <summary>FOGO (Fog Oil)</summary>
    FogoFogOil = 2010,
    /// <summary>HC (HexaChloroEthane)</summary>
    HcHexaChloroEthane = 2015,
    /// <summary>Illumination</summary>
    Illumination = 3000,
    /// <summary>Practice</summary>
    Practice = 4000,
    /// <summary>Blank</summary>
    Blank = 4001,
    /// <summary>Dummy</summary>
    Dummy = 4002,
    /// <summary>Kinetic</summary>
    Kinetic = 5000,
    /// <summary>Mines</summary>
    Mines = 6000,
    /// <summary>Nuclear</summary>
    Nuclear = 7000,
    /// <summary>Nuclear, IMT</summary>
    NuclearImt = 7010,
    /// <summary>Chemical, General</summary>
    ChemicalGeneral = 8000,
    /// <summary>Chemical, Blister Agent</summary>
    ChemicalBlisterAgent = 8100,
    /// <summary>HD (Mustard)</summary>
    HdMustard = 8110,
    /// <summary>Thickened HD (Mustard)</summary>
    ThickenedHdMustard = 8115,
    /// <summary>Dusty HD (Mustard)</summary>
    DustyHdMustard = 8120,
    /// <summary>L (Lewisite)</summary>
    LLewisite = 8125,
    /// <summary>HN3 (Nitrogen Mustard)</summary>
    Hn3NitrogenMustard = 8130,
    /// <summary>HL (Mustard/Lewisite)</summary>
    HlMustardLewisite = 8135,
    /// <summary>CX (Phosgene Oxime)</summary>
    CxPhosgeneOxime = 8140,
    /// <summary>DMMP (Phosphate Dimethyl Hydrogen)</summary>
    DmmpPhosphateDimethylHydrogen = 8145,
    /// <summary>DMHP (Phosphite)</summary>
    DmhpPhosphite = 8150,
    /// <summary>DMA (Dimethyl Acrylate)</summary>
    DmaDimethylAcrylate = 8155,
    /// <summary>DEM</summary>
    Dem = 8160,
    /// <summary>PX (P-xlene)</summary>
    PxPXlene = 8165,
    /// <summary>Chemical, Blood Agent</summary>
    ChemicalBloodAgent = 8200,
    /// <summary>AC (HCN)</summary>
    AcHcn = 8210,
    /// <summary>CK (CNCI)</summary>
    CkCnci = 8215,
    /// <summary>CG (Phosgene)</summary>
    CgPhosgene = 8220,
    /// <summary>Chemical, Nerve Agent</summary>
    ChemicalNerveAgent = 8300,
    /// <summary>VX</summary>
    Vx = 8310,
    /// <summary>Thickened VX</summary>
    ThickenedVx = 8315,
    /// <summary>Dusty VX</summary>
    DustyVx = 8320,
    /// <summary>GA (Tabun)</summary>
    GaTabun = 8325,
    /// <summary>Thickened GA (Tabun)</summary>
    ThickenedGaTabun = 8330,
    /// <summary>Dusty GA (Tabun)</summary>
    DustyGaTabun = 8335,
    /// <summary>GB (Sarin)</summary>
    GbSarin = 8340,
    /// <summary>Thickened GB (Sarin)</summary>
    ThickenedGbSarin = 8345,
    /// <summary>Dusty GB (Sarin)</summary>
    DustyGbSarin = 8350,
    /// <summary>GD (Soman)</summary>
    GdSoman = 8355,
    /// <summary>Thickened GD (Soman)</summary>
    ThickenedGdSoman = 8360,
    /// <summary>Dusty GD (Soman)</summary>
    DustyGdSoman = 8365,
    /// <summary>GF</summary>
    Gf = 8370,
    /// <summary>Thickened GF</summary>
    ThickenedGf = 8375,
    /// <summary>Dusty GF</summary>
    DustyGf = 8380,
    /// <summary>SVX (Soviet VX)</summary>
    SvxSovietVx = 8385,
    /// <summary>BIS</summary>
    Bis = 8410,
    /// <summary>TCP</summary>
    Tcp = 8415,
    /// <summary>MS (Methyl Salicylate)</summary>
    MsMethylSalicylate = 8425,
    /// <summary>TEP</summary>
    Tep = 8430,
    /// <summary>H2O (Water)</summary>
    H2oWater = 8445,
    /// <summary>TO1 (Toxic Organic 1)</summary>
    To1ToxicOrganic1 = 8450,
    /// <summary>TO2 (Toxic Organic 2)</summary>
    To2ToxicOrganic2 = 8455,
    /// <summary>TO3 (Toxic Organic 3)</summary>
    To3ToxicOrganic3 = 8460,
    /// <summary>Sulfur Hexafluoride</summary>
    SulfurHexafluoride = 8465,
    /// <summary>AA (Acetic Acid)</summary>
    AaAceticAcid = 8470,
    /// <summary>HF (Hydrofluoric Acid)</summary>
    HfHydrofluoricAcid = 8475,
    /// <summary>Biological</summary>
    Biological = 9000,
    /// <summary>Biological, Virus</summary>
    BiologicalVirus = 9100,
    /// <summary>Biological, Bacteria</summary>
    BiologicalBacteria = 9200,
    /// <summary>Biological, Rickettsia</summary>
    BiologicalRickettsia = 9300,
    /// <summary>Biological, Genetically Modified Micro-organisms</summary>
    BiologicalGeneticallyModifiedMicroOrganisms = 9400,
    /// <summary>Biological, Toxin</summary>
    BiologicalToxin = 9500,
}

/// <summary>SISO-REF-010 v36 enumeration UID 327.</summary>
public enum MunitionExpendableStatus : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Ready</summary>
    Ready = 1,
    /// <summary>Inventory</summary>
    Inventory = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 359.</summary>
public enum NavigationSource : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>GPS</summary>
    Gps = 1,
    /// <summary>INS</summary>
    Ins = 2,
    /// <summary>INS/GPS</summary>
    InsGps = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 225.</summary>
public enum ObjectKind : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Obstacle</summary>
    Obstacle = 1,
    /// <summary>Prepared Position</summary>
    PreparedPosition = 2,
    /// <summary>Cultural Feature</summary>
    CulturalFeature = 3,
    /// <summary>Passageway</summary>
    Passageway = 4,
    /// <summary>Tactical Smoke</summary>
    TacticalSmoke = 5,
    /// <summary>Obstacle Marker</summary>
    ObstacleMarker = 6,
    /// <summary>Obstacle Breach</summary>
    ObstacleBreach = 7,
    /// <summary>Environmental Object</summary>
    EnvironmentalObject = 8,
}

/// <summary>SISO-REF-010 v36 bitfield UID 229. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct ObjectStateAppearanceGeneral(ushort Value)
{
    public static ObjectStateAppearanceGeneral None => new(0);

    /// <summary>8-bit unsigned integer indicating the percent completion of the object (0..100)</summary>
    public ushort PercentComplete => (ushort)((Value >> 0) & 255);
    public ObjectStateAppearanceGeneral WithPercentComplete(ushort value)
    {
        if (value > 255) throw new ArgumentOutOfRangeException(nameof(value));
        return new((ushort)((Value & ~255) | ((ushort)(value << 0) & 255)));
    }

    /// <summary>Describes the damaged appearance</summary>
    public ushort Damage => (ushort)((Value >> 8) & 3);
    public ObjectStateAppearanceGeneral WithDamage(ushort value)
    {
        if (value > 3) throw new ArgumentOutOfRangeException(nameof(value));
        return new((ushort)((Value & ~768) | ((ushort)(value << 8) & 768)));
    }

    /// <summary>Describes whether the object was predistributed</summary>
    public bool Predistributed => (Value & 1024) != 0;
    public ObjectStateAppearanceGeneral WithPredistributed(bool value) => new((ushort)(value ? Value | 1024 : Value & ~1024));

    /// <summary>Describes the state of the object</summary>
    public bool State => (Value & 2048) != 0;
    public ObjectStateAppearanceGeneral WithState(bool value) => new((ushort)(value ? Value | 2048 : Value & ~2048));

    /// <summary>Describes whether or not there is a smoke plume</summary>
    public bool IsSmoking => (Value & 4096) != 0;
    public ObjectStateAppearanceGeneral WithIsSmoking(bool value) => new((ushort)(value ? Value | 4096 : Value & ~4096));

    /// <summary>Describes whether the object is burning and flames are visible</summary>
    public bool IsFlaming => (Value & 8192) != 0;
    public ObjectStateAppearanceGeneral WithIsFlaming(bool value) => new((ushort)(value ? Value | 8192 : Value & ~8192));

    /// <summary>Describes whether the object has or contains an IED</summary>
    public ushort IedPresent => (ushort)((Value >> 14) & 3);
    public ObjectStateAppearanceGeneral WithIedPresent(ushort value)
    {
        if (value > 3) throw new ArgumentOutOfRangeException(nameof(value));
        return new((ushort)((Value & ~49152) | ((ushort)(value << 14) & 49152)));
    }

    public static implicit operator ObjectStateAppearanceGeneral(ushort value) => new(value);
    public static implicit operator ushort(ObjectStateAppearanceGeneral value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 bitfield UID 242. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct ObjectStateModificationArealObject(ushort Value)
{
    public static ObjectStateModificationArealObject None => new(0);

    /// <summary>Describes whether any locations of the areal object have been modified since the last update number</summary>
    public bool IsLocationModified => (Value & 1) != 0;
    public ObjectStateModificationArealObject WithIsLocationModified(bool value) => new((ushort)(value ? Value | 1 : Value & ~1));

    public static implicit operator ObjectStateModificationArealObject(ushort value) => new(value);
    public static implicit operator ushort(ObjectStateModificationArealObject value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 bitfield UID 241. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct ObjectStateModificationLinearObject(ushort Value)
{
    public static ObjectStateModificationLinearObject None => new(0);

    /// <summary>Describes whether the location of the linear segment has been modified since the last update number</summary>
    public bool IsLocationModified => (Value & 1) != 0;
    public ObjectStateModificationLinearObject WithIsLocationModified(bool value) => new((ushort)(value ? Value | 1 : Value & ~1));

    /// <summary>Describes whether the orientation of the linear segment has been modified since the last update number</summary>
    public bool IsOrientationModified => (Value & 2) != 0;
    public ObjectStateModificationLinearObject WithIsOrientationModified(bool value) => new((ushort)(value ? Value | 2 : Value & ~2));

    public static implicit operator ObjectStateModificationLinearObject(ushort value) => new(value);
    public static implicit operator ushort(ObjectStateModificationLinearObject value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 bitfield UID 240. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct ObjectStateModificationPointObject(ushort Value)
{
    public static ObjectStateModificationPointObject None => new(0);

    /// <summary>Describes whether the point object location has been modified since the last update number</summary>
    public bool IsLocationModified => (Value & 1) != 0;
    public ObjectStateModificationPointObject WithIsLocationModified(bool value) => new((ushort)(value ? Value | 1 : Value & ~1));

    /// <summary>Describes whether the point object orientation has been modified since the last update number</summary>
    public bool IsOrientationModified => (Value & 2) != 0;
    public ObjectStateModificationPointObject WithIsOrientationModified(bool value) => new((ushort)(value ? Value | 2 : Value & ~2));

    public static implicit operator ObjectStateModificationPointObject(ushort value) => new(value);
    public static implicit operator ushort(ObjectStateModificationPointObject value) => value.Value;
    public override string ToString() => $"0x{Value:X4}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 332.</summary>
public enum OwnershipStatus : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>New Owner</summary>
    NewOwner = 1,
    /// <summary>Ownership Query Response</summary>
    OwnershipQueryResponse = 2,
    /// <summary>Ownership Conflict</summary>
    OwnershipConflict = 3,
    /// <summary>Local Entity Cancelled - Auto Resolve Conflict</summary>
    LocalEntityCancelledAutoResolveConflict = 4,
    /// <summary>Local Entity Cancelled - Manual Resolve Conflict</summary>
    LocalEntityCancelledManualResolveConflict = 5,
    /// <summary>Local Entity Cancelled - Remove Entity TO Received</summary>
    LocalEntityCancelledRemoveEntityToReceived = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 8.</summary>
public enum PlatformDomain : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Land</summary>
    Land = 1,
    /// <summary>Air</summary>
    Air = 2,
    /// <summary>Surface</summary>
    Surface = 3,
    /// <summary>Subsurface</summary>
    Subsurface = 4,
    /// <summary>Space</summary>
    Space = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 22.</summary>
public enum RadioCategory : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Voice Transmission/Reception</summary>
    VoiceTransmissionReception = 1,
    /// <summary>Data Link Transmission/Reception</summary>
    DataLinkTransmissionReception = 2,
    /// <summary>Voice and Data Link Transmission/Reception</summary>
    VoiceAndDataLinkTransmissionReception = 3,
    /// <summary>Instrumented Landing System (ILS) Glideslope Transmitter</summary>
    InstrumentedLandingSystemIlsGlideslopeTransmitter = 4,
    /// <summary>Instrumented Landing System (ILS) Localizer Transmitter</summary>
    InstrumentedLandingSystemIlsLocalizerTransmitter = 5,
    /// <summary>Instrumented Landing System (ILS) Outer Marker Beacon</summary>
    InstrumentedLandingSystemIlsOuterMarkerBeacon = 6,
    /// <summary>Instrumented Landing System (ILS) Middle Marker Beacon</summary>
    InstrumentedLandingSystemIlsMiddleMarkerBeacon = 7,
    /// <summary>Instrumented Landing System (ILS) Inner Marker Beacon</summary>
    InstrumentedLandingSystemIlsInnerMarkerBeacon = 8,
    /// <summary>Instrumented Landing System (ILS) Receiver (Platform Radio)</summary>
    InstrumentedLandingSystemIlsReceiverPlatformRadio = 9,
    /// <summary>Tactical Air Navigation (TACAN) Transmitter (Ground Fixed Equipment)</summary>
    TacticalAirNavigationTacanTransmitterGroundFixedEquipment = 10,
    /// <summary>Tactical Air Navigation (TACAN) Receiver (Moving Platform Equipment)</summary>
    TacticalAirNavigationTacanReceiverMovingPlatformEquipment = 11,
    /// <summary>Tactical Air Navigation (TACAN) Transmitter/Receiver (Moving Platform Equipment)</summary>
    TacticalAirNavigationTacanTransmitterReceiverMovingPlatformEquipment = 12,
    /// <summary>Variable Omni-Ranging (VOR) Transmitter (Ground Fixed Equipment)</summary>
    VariableOmniRangingVorTransmitterGroundFixedEquipment = 13,
    /// <summary>Variable Omni-Ranging (VOR) with Distance Measuring Equipment (DME) Transmitter (Ground Fixed Equipment)</summary>
    VariableOmniRangingVorWithDistanceMeasuringEquipmentDmeTransmitterGroundFixedEquipment = 14,
    /// <summary>Combined VOR/ILS Receiver (Moving Platform Equipment)</summary>
    CombinedVorIlsReceiverMovingPlatformEquipment = 15,
    /// <summary>Combined VOR &amp; TACAN (VORTAC) Transmitter</summary>
    CombinedVorTacanVortacTransmitter = 16,
    /// <summary>Non-Directional Beacon (NDB) Transmitter</summary>
    NonDirectionalBeaconNdbTransmitter = 17,
    /// <summary>Non-Directional Beacon (NDB) Receiver</summary>
    NonDirectionalBeaconNdbReceiver = 18,
    /// <summary>Non-Directional Beacon (NDB) with Distance Measuring Equipment (DME) Transmitter</summary>
    NonDirectionalBeaconNdbWithDistanceMeasuringEquipmentDmeTransmitter = 19,
    /// <summary>Distance Measuring Equipment (DME)</summary>
    DistanceMeasuringEquipmentDme = 20,
    /// <summary>Link 16 Terminal</summary>
    Link16Terminal = 21,
    /// <summary>Link 11 Terminal</summary>
    Link11Terminal = 22,
    /// <summary>Link 11B Terminal</summary>
    Link11bTerminal = 23,
    /// <summary>EPLRS/SADL Terminal</summary>
    EplrsSadlTerminal = 24,
    /// <summary>F-22 Intra-Flight Data Link (IFDL)</summary>
    F22IntraFlightDataLinkIfdl = 25,
    /// <summary>F-35 Multifunction Advanced Data Link (MADL)</summary>
    F35MultifunctionAdvancedDataLinkMadl = 26,
    /// <summary>SINCGARS Terminal</summary>
    SincgarsTerminal = 27,
    /// <summary>L-Band SATCOM Terminal</summary>
    LBandSatcomTerminal = 28,
    /// <summary>IBS Terminal</summary>
    IbsTerminal = 29,
    /// <summary>GPS</summary>
    Gps = 30,
    /// <summary>Tactical Video</summary>
    TacticalVideo = 31,
    /// <summary>Air-to-Air Missile Datalink</summary>
    AirToAirMissileDatalink = 32,
    /// <summary>Link 16 Surrogate for Non-NATO TDL Terminal</summary>
    Link16SurrogateForNonNatoTdlTerminal = 33,
    /// <summary>MQ-1/9 C-Band LOS Datalink</summary>
    Mq19CBandLosDatalink = 34,
    /// <summary>MQ-1/9 Ku-Band SATCOM Datalink</summary>
    Mq19KuBandSatcomDatalink = 35,
    /// <summary>Air-to-Ground Weapon Datalink</summary>
    AirToGroundWeaponDatalink = 36,
    /// <summary>Automatic Identification System (AIS)</summary>
    AutomaticIdentificationSystemAis = 37,
    /// <summary>JPALS Data Link</summary>
    JpalsDataLink = 38,
    /// <summary>Combat Search and Rescue (CSAR) Radio</summary>
    CombatSearchAndRescueCsarRadio = 40,
    /// <summary>Counter Unmanned Aircraft System (C-UAS) Radio</summary>
    CounterUnmannedAircraftSystemCUasRadio = 41,
    /// <summary>Emergency Position-Indicating Radio Beacons (EPIRB)</summary>
    EmergencyPositionIndicatingRadioBeaconsEpirb = 42,
    /// <summary>Electronic Attack Systems</summary>
    ElectronicAttackSystems = 50,
    /// <summary>Tactical Targeting Network Technology (TTNT)</summary>
    TacticalTargetingNetworkTechnologyTtnt = 51,
}

/// <summary>SISO-REF-010 v36 enumeration UID 23.</summary>
public enum RadioSubcategory : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Joint Electronics Type Designation System (JETDS) Non-specific Series</summary>
    JointElectronicsTypeDesignationSystemJetdsNonSpecificSeries = 1,
    /// <summary>Manufacturer Designation</summary>
    ManufacturerDesignation = 2,
    /// <summary>National Designation</summary>
    NationalDesignation = 3,
    /// <summary>JETDS ARC Set 1</summary>
    JetdsArcSet1 = 11,
    /// <summary>JETDS ARC Set 2</summary>
    JetdsArcSet2 = 12,
    /// <summary>JETDS ARC Set 3</summary>
    JetdsArcSet3 = 13,
    /// <summary>JETDS ARC Set 4</summary>
    JetdsArcSet4 = 14,
    /// <summary>JETDS BRC Set 1</summary>
    JetdsBrcSet1 = 15,
    /// <summary>JETDS BRC Set 2</summary>
    JetdsBrcSet2 = 16,
    /// <summary>JETDS BRC Set 3</summary>
    JetdsBrcSet3 = 17,
    /// <summary>JETDS BRC Set 4</summary>
    JetdsBrcSet4 = 18,
    /// <summary>JETDS CRC Set 1</summary>
    JetdsCrcSet1 = 19,
    /// <summary>JETDS CRC Set 2</summary>
    JetdsCrcSet2 = 20,
    /// <summary>JETDS CRC Set 3</summary>
    JetdsCrcSet3 = 21,
    /// <summary>JETDS CRC Set 4</summary>
    JetdsCrcSet4 = 22,
    /// <summary>JETDS DRC Set 1</summary>
    JetdsDrcSet1 = 23,
    /// <summary>JETDS DRC Set 2</summary>
    JetdsDrcSet2 = 24,
    /// <summary>JETDS DRC Set 3</summary>
    JetdsDrcSet3 = 25,
    /// <summary>JETDS DRC Set 4</summary>
    JetdsDrcSet4 = 26,
    /// <summary>JETDS FRC Set 1</summary>
    JetdsFrcSet1 = 27,
    /// <summary>JETDS FRC Set 2</summary>
    JetdsFrcSet2 = 28,
    /// <summary>JETDS FRC Set 3</summary>
    JetdsFrcSet3 = 29,
    /// <summary>JETDS FRC Set 4</summary>
    JetdsFrcSet4 = 30,
    /// <summary>JETDS GRC Set 1</summary>
    JetdsGrcSet1 = 31,
    /// <summary>JETDS GRC Set 2</summary>
    JetdsGrcSet2 = 32,
    /// <summary>JETDS GRC Set 3</summary>
    JetdsGrcSet3 = 33,
    /// <summary>JETDS GRC Set 4</summary>
    JetdsGrcSet4 = 34,
    /// <summary>JETDS KRC Set 1</summary>
    JetdsKrcSet1 = 35,
    /// <summary>JETDS KRC Set 2</summary>
    JetdsKrcSet2 = 36,
    /// <summary>JETDS KRC Set 3</summary>
    JetdsKrcSet3 = 37,
    /// <summary>JETDS KRC Set 4</summary>
    JetdsKrcSet4 = 38,
    /// <summary>JETDS MRC Set 1</summary>
    JetdsMrcSet1 = 39,
    /// <summary>JETDS MRC Set 2</summary>
    JetdsMrcSet2 = 40,
    /// <summary>JETDS MRC Set 3</summary>
    JetdsMrcSet3 = 41,
    /// <summary>JETDS MRC Set 4</summary>
    JetdsMrcSet4 = 42,
    /// <summary>JETDS PRC Set 1</summary>
    JetdsPrcSet1 = 43,
    /// <summary>JETDS PRC Set 2</summary>
    JetdsPrcSet2 = 44,
    /// <summary>JETDS PRC Set 3</summary>
    JetdsPrcSet3 = 45,
    /// <summary>JETDS PRC Set 4</summary>
    JetdsPrcSet4 = 46,
    /// <summary>JETDS SRC Set 1</summary>
    JetdsSrcSet1 = 47,
    /// <summary>JETDS SRC Set 2</summary>
    JetdsSrcSet2 = 48,
    /// <summary>JETDS SRC Set 3</summary>
    JetdsSrcSet3 = 49,
    /// <summary>JETDS SRC Set 4</summary>
    JetdsSrcSet4 = 50,
    /// <summary>JETDS TRC Set 1</summary>
    JetdsTrcSet1 = 51,
    /// <summary>JETDS TRC Set 2</summary>
    JetdsTrcSet2 = 52,
    /// <summary>JETDS TRC Set 3</summary>
    JetdsTrcSet3 = 53,
    /// <summary>JETDS TRC Set 4</summary>
    JetdsTrcSet4 = 54,
    /// <summary>JETDS VRC Set 1</summary>
    JetdsVrcSet1 = 55,
    /// <summary>JETDS VRC Set 2</summary>
    JetdsVrcSet2 = 56,
    /// <summary>JETDS VRC Set 3</summary>
    JetdsVrcSet3 = 57,
    /// <summary>JETDS VRC Set 4</summary>
    JetdsVrcSet4 = 58,
    /// <summary>JETDS WRC Set 1</summary>
    JetdsWrcSet1 = 59,
    /// <summary>JETDS WRC Set 2</summary>
    JetdsWrcSet2 = 60,
    /// <summary>JETDS WRC Set 3</summary>
    JetdsWrcSet3 = 61,
    /// <summary>JETDS WRC Set 4</summary>
    JetdsWrcSet4 = 62,
    /// <summary>JETDS ZRC Set 1</summary>
    JetdsZrcSet1 = 63,
    /// <summary>JETDS ZRC Set 2</summary>
    JetdsZrcSet2 = 64,
    /// <summary>JETDS ZRC Set 3</summary>
    JetdsZrcSet3 = 65,
    /// <summary>JETDS ZRC Set 4</summary>
    JetdsZrcSet4 = 66,
}

/// <summary>SISO-REF-010 v36 enumeration UID 179.</summary>
public enum ReceiverReceiverState : ushort
{
    /// <summary>Off</summary>
    Off = 0,
    /// <summary>On but not receiving</summary>
    OnButNotReceiving = 1,
    /// <summary>On and receiving</summary>
    OnAndReceiving = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 334.</summary>
public enum RecordQueryREventType : ushort
{
    /// <summary>Periodic</summary>
    Periodic = 0,
    /// <summary>Internal Entity State Data</summary>
    InternalEntityStateData = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 333.</summary>
public enum RecordREventType : ushort
{
    /// <summary>Other</summary>
    Other = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 64.</summary>
public enum RepairCompleteRepair : ushort
{
    /// <summary>no repairs performed</summary>
    NoRepairsPerformed = 0,
    /// <summary>all requested repairs performed</summary>
    AllRequestedRepairsPerformed = 1,
    /// <summary>motor / engine</summary>
    MotorEngine = 10,
    /// <summary>starter</summary>
    Starter = 20,
    /// <summary>alternator</summary>
    Alternator = 30,
    /// <summary>generator</summary>
    Generator = 40,
    /// <summary>battery</summary>
    Battery = 50,
    /// <summary>engine-coolant leak</summary>
    EngineCoolantLeak = 60,
    /// <summary>fuel filter</summary>
    FuelFilter = 70,
    /// <summary>transmission-oil leak</summary>
    TransmissionOilLeak = 80,
    /// <summary>engine-oil leak</summary>
    EngineOilLeak = 90,
    /// <summary>pumps</summary>
    Pumps = 100,
    /// <summary>filters</summary>
    Filters = 110,
    /// <summary>transmission</summary>
    Transmission = 120,
    /// <summary>brakes</summary>
    Brakes = 130,
    /// <summary>suspension system</summary>
    SuspensionSystem = 140,
    /// <summary>oil filter</summary>
    OilFilter = 150,
    /// <summary>hull</summary>
    Hull = 1000,
    /// <summary>airframe</summary>
    Airframe = 1010,
    /// <summary>truck body</summary>
    TruckBody = 1020,
    /// <summary>tank body</summary>
    TankBody = 1030,
    /// <summary>trailer body</summary>
    TrailerBody = 1040,
    /// <summary>turret</summary>
    Turret = 1050,
    /// <summary>propeller</summary>
    Propeller = 1500,
    /// <summary>filters</summary>
    Filters1520 = 1520,
    /// <summary>wheels</summary>
    Wheels = 1540,
    /// <summary>tire</summary>
    Tire = 1550,
    /// <summary>track</summary>
    Track = 1560,
    /// <summary>gun elevation drive</summary>
    GunElevationDrive = 2000,
    /// <summary>gun stabilization system</summary>
    GunStabilizationSystem = 2010,
    /// <summary>gunner's primary sight (GPS)</summary>
    GunnerSPrimarySightGps = 2020,
    /// <summary>commander's extension to the GPS</summary>
    CommanderSExtensionToTheGps = 2030,
    /// <summary>loading mechanism</summary>
    LoadingMechanism = 2040,
    /// <summary>gunner's auxiliary sight</summary>
    GunnerSAuxiliarySight = 2050,
    /// <summary>gunner's control panel</summary>
    GunnerSControlPanel = 2060,
    /// <summary>gunner's control assembly handle(s)</summary>
    GunnerSControlAssemblyHandleS = 2070,
    /// <summary>commander's control handles/assembly</summary>
    CommanderSControlHandlesAssembly = 2090,
    /// <summary>commander's weapon station</summary>
    CommanderSWeaponStation = 2100,
    /// <summary>commander's independent thermal viewer (CITV)</summary>
    CommanderSIndependentThermalViewerCitv = 2110,
    /// <summary>general weapons</summary>
    GeneralWeapons = 2120,
    /// <summary>fuel transfer pump</summary>
    FuelTransferPump = 4000,
    /// <summary>fuel lines</summary>
    FuelLines = 4010,
    /// <summary>gauges</summary>
    Gauges = 4020,
    /// <summary>general fuel system</summary>
    GeneralFuelSystem = 4030,
    /// <summary>electronic warfare systems</summary>
    ElectronicWarfareSystems = 4500,
    /// <summary>detection systems</summary>
    DetectionSystems = 4600,
    /// <summary>detection systems, radio frequency</summary>
    DetectionSystemsRadioFrequency = 4610,
    /// <summary>detection systems, microwave</summary>
    DetectionSystemsMicrowave = 4620,
    /// <summary>detection systems, infrared</summary>
    DetectionSystemsInfrared = 4630,
    /// <summary>detection systems, laser</summary>
    DetectionSystemsLaser = 4640,
    /// <summary>range finders</summary>
    RangeFinders = 4700,
    /// <summary>range-only radar</summary>
    RangeOnlyRadar = 4710,
    /// <summary>laser range finder</summary>
    LaserRangeFinder = 4720,
    /// <summary>electronic systems</summary>
    ElectronicSystems = 4800,
    /// <summary>electronics systems, radio frequency</summary>
    ElectronicsSystemsRadioFrequency = 4810,
    /// <summary>electronics systems, microwave</summary>
    ElectronicsSystemsMicrowave = 4820,
    /// <summary>electronics systems, infrared</summary>
    ElectronicsSystemsInfrared = 4830,
    /// <summary>electronics systems, laser</summary>
    ElectronicsSystemsLaser = 4840,
    /// <summary>radios</summary>
    Radios = 5000,
    /// <summary>communication systems</summary>
    CommunicationSystems = 5010,
    /// <summary>intercoms</summary>
    Intercoms = 5100,
    /// <summary>encoders</summary>
    Encoders = 5200,
    /// <summary>encryption devices</summary>
    EncryptionDevices = 5250,
    /// <summary>decoders</summary>
    Decoders = 5300,
    /// <summary>decryption devices</summary>
    DecryptionDevices = 5350,
    /// <summary>computers</summary>
    Computers = 5500,
    /// <summary>navigation and control systems</summary>
    NavigationAndControlSystems = 6000,
    /// <summary>fire control systems</summary>
    FireControlSystems = 6500,
    /// <summary>air supply</summary>
    AirSupply = 8000,
    /// <summary>filters</summary>
    Filters8010 = 8010,
    /// <summary>water supply</summary>
    WaterSupply = 8020,
    /// <summary>refrigeration system</summary>
    RefrigerationSystem = 8030,
    /// <summary>chemical, biological, and radiological protection</summary>
    ChemicalBiologicalAndRadiologicalProtection = 8040,
    /// <summary>water wash down systems</summary>
    WaterWashDownSystems = 8050,
    /// <summary>decontamination systems</summary>
    DecontaminationSystems = 8060,
    /// <summary>water supply</summary>
    WaterSupply9000 = 9000,
    /// <summary>cooling system</summary>
    CoolingSystem = 9010,
    /// <summary>winches</summary>
    Winches = 9020,
    /// <summary>catapults</summary>
    Catapults = 9030,
    /// <summary>cranes</summary>
    Cranes = 9040,
    /// <summary>launchers</summary>
    Launchers = 9050,
    /// <summary>life boats</summary>
    LifeBoats = 10000,
    /// <summary>landing craft</summary>
    LandingCraft = 10010,
    /// <summary>ejection seats</summary>
    EjectionSeats = 10020,
}

/// <summary>SISO-REF-010 v36 enumeration UID 64.</summary>
public enum RepairResponseRepairResult : ushort
{
    /// <summary>no repairs performed</summary>
    NoRepairsPerformed = 0,
    /// <summary>all requested repairs performed</summary>
    AllRequestedRepairsPerformed = 1,
    /// <summary>motor / engine</summary>
    MotorEngine = 10,
    /// <summary>starter</summary>
    Starter = 20,
    /// <summary>alternator</summary>
    Alternator = 30,
    /// <summary>generator</summary>
    Generator = 40,
    /// <summary>battery</summary>
    Battery = 50,
    /// <summary>engine-coolant leak</summary>
    EngineCoolantLeak = 60,
    /// <summary>fuel filter</summary>
    FuelFilter = 70,
    /// <summary>transmission-oil leak</summary>
    TransmissionOilLeak = 80,
    /// <summary>engine-oil leak</summary>
    EngineOilLeak = 90,
    /// <summary>pumps</summary>
    Pumps = 100,
    /// <summary>filters</summary>
    Filters = 110,
    /// <summary>transmission</summary>
    Transmission = 120,
    /// <summary>brakes</summary>
    Brakes = 130,
    /// <summary>suspension system</summary>
    SuspensionSystem = 140,
    /// <summary>oil filter</summary>
    OilFilter = 150,
    /// <summary>hull</summary>
    Hull = 1000,
    /// <summary>airframe</summary>
    Airframe = 1010,
    /// <summary>truck body</summary>
    TruckBody = 1020,
    /// <summary>tank body</summary>
    TankBody = 1030,
    /// <summary>trailer body</summary>
    TrailerBody = 1040,
    /// <summary>turret</summary>
    Turret = 1050,
    /// <summary>propeller</summary>
    Propeller = 1500,
    /// <summary>filters</summary>
    Filters1520 = 1520,
    /// <summary>wheels</summary>
    Wheels = 1540,
    /// <summary>tire</summary>
    Tire = 1550,
    /// <summary>track</summary>
    Track = 1560,
    /// <summary>gun elevation drive</summary>
    GunElevationDrive = 2000,
    /// <summary>gun stabilization system</summary>
    GunStabilizationSystem = 2010,
    /// <summary>gunner's primary sight (GPS)</summary>
    GunnerSPrimarySightGps = 2020,
    /// <summary>commander's extension to the GPS</summary>
    CommanderSExtensionToTheGps = 2030,
    /// <summary>loading mechanism</summary>
    LoadingMechanism = 2040,
    /// <summary>gunner's auxiliary sight</summary>
    GunnerSAuxiliarySight = 2050,
    /// <summary>gunner's control panel</summary>
    GunnerSControlPanel = 2060,
    /// <summary>gunner's control assembly handle(s)</summary>
    GunnerSControlAssemblyHandleS = 2070,
    /// <summary>commander's control handles/assembly</summary>
    CommanderSControlHandlesAssembly = 2090,
    /// <summary>commander's weapon station</summary>
    CommanderSWeaponStation = 2100,
    /// <summary>commander's independent thermal viewer (CITV)</summary>
    CommanderSIndependentThermalViewerCitv = 2110,
    /// <summary>general weapons</summary>
    GeneralWeapons = 2120,
    /// <summary>fuel transfer pump</summary>
    FuelTransferPump = 4000,
    /// <summary>fuel lines</summary>
    FuelLines = 4010,
    /// <summary>gauges</summary>
    Gauges = 4020,
    /// <summary>general fuel system</summary>
    GeneralFuelSystem = 4030,
    /// <summary>electronic warfare systems</summary>
    ElectronicWarfareSystems = 4500,
    /// <summary>detection systems</summary>
    DetectionSystems = 4600,
    /// <summary>detection systems, radio frequency</summary>
    DetectionSystemsRadioFrequency = 4610,
    /// <summary>detection systems, microwave</summary>
    DetectionSystemsMicrowave = 4620,
    /// <summary>detection systems, infrared</summary>
    DetectionSystemsInfrared = 4630,
    /// <summary>detection systems, laser</summary>
    DetectionSystemsLaser = 4640,
    /// <summary>range finders</summary>
    RangeFinders = 4700,
    /// <summary>range-only radar</summary>
    RangeOnlyRadar = 4710,
    /// <summary>laser range finder</summary>
    LaserRangeFinder = 4720,
    /// <summary>electronic systems</summary>
    ElectronicSystems = 4800,
    /// <summary>electronics systems, radio frequency</summary>
    ElectronicsSystemsRadioFrequency = 4810,
    /// <summary>electronics systems, microwave</summary>
    ElectronicsSystemsMicrowave = 4820,
    /// <summary>electronics systems, infrared</summary>
    ElectronicsSystemsInfrared = 4830,
    /// <summary>electronics systems, laser</summary>
    ElectronicsSystemsLaser = 4840,
    /// <summary>radios</summary>
    Radios = 5000,
    /// <summary>communication systems</summary>
    CommunicationSystems = 5010,
    /// <summary>intercoms</summary>
    Intercoms = 5100,
    /// <summary>encoders</summary>
    Encoders = 5200,
    /// <summary>encryption devices</summary>
    EncryptionDevices = 5250,
    /// <summary>decoders</summary>
    Decoders = 5300,
    /// <summary>decryption devices</summary>
    DecryptionDevices = 5350,
    /// <summary>computers</summary>
    Computers = 5500,
    /// <summary>navigation and control systems</summary>
    NavigationAndControlSystems = 6000,
    /// <summary>fire control systems</summary>
    FireControlSystems = 6500,
    /// <summary>air supply</summary>
    AirSupply = 8000,
    /// <summary>filters</summary>
    Filters8010 = 8010,
    /// <summary>water supply</summary>
    WaterSupply = 8020,
    /// <summary>refrigeration system</summary>
    RefrigerationSystem = 8030,
    /// <summary>chemical, biological, and radiological protection</summary>
    ChemicalBiologicalAndRadiologicalProtection = 8040,
    /// <summary>water wash down systems</summary>
    WaterWashDownSystems = 8050,
    /// <summary>decontamination systems</summary>
    DecontaminationSystems = 8060,
    /// <summary>water supply</summary>
    WaterSupply9000 = 9000,
    /// <summary>cooling system</summary>
    CoolingSystem = 9010,
    /// <summary>winches</summary>
    Winches = 9020,
    /// <summary>catapults</summary>
    Catapults = 9030,
    /// <summary>cranes</summary>
    Cranes = 9040,
    /// <summary>launchers</summary>
    Launchers = 9050,
    /// <summary>life boats</summary>
    LifeBoats = 10000,
    /// <summary>landing craft</summary>
    LandingCraft = 10010,
    /// <summary>ejection seats</summary>
    EjectionSeats = 10020,
}

/// <summary>SISO-REF-010 v36 enumeration UID 74.</summary>
public enum RequiredReliabilityService : byte
{
    /// <summary>Acknowledged</summary>
    Acknowledged = 0,
    /// <summary>Unacknowledged</summary>
    Unacknowledged = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 331.</summary>
public enum SensorOnOffStatus : byte
{
    /// <summary>Off</summary>
    Off = 0,
    /// <summary>On</summary>
    On = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 414.</summary>
public enum SensorTypeSource : byte
{
    /// <summary>Other Active Sensors</summary>
    OtherActiveSensors = 0,
    /// <summary>Electromagnetic</summary>
    Electromagnetic = 1,
    /// <summary>Passive Sensors</summary>
    PassiveSensors = 2,
    /// <summary>Minefield Sensors</summary>
    MinefieldSensors = 3,
    /// <summary>Underwater Acoustics</summary>
    UnderwaterAcoustics = 4,
    /// <summary>Lasers</summary>
    Lasers = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 283.</summary>
public enum SeparationVpPreEntityIndicator : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Entity ID Existed Prior to Separation without Entity State PDU</summary>
    EntityIdExistedPriorToSeparationWithoutEntityStatePdu = 1,
    /// <summary>Entity ID Existed Prior to Separation with Entity State PDU Issued</summary>
    EntityIdExistedPriorToSeparationWithEntityStatePduIssued = 2,
    /// <summary>Entity Initially Created at Separation Event</summary>
    EntityInitiallyCreatedAtSeparationEvent = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 282.</summary>
public enum SeparationVpReasonforSeparation : byte
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Attached Part Separation</summary>
    AttachedPartSeparation = 1,
    /// <summary>Submunition Separation</summary>
    SubmunitionSeparation = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 63.</summary>
public enum ServiceRequestServiceTypeRequested : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Resupply</summary>
    Resupply = 1,
    /// <summary>Repair</summary>
    Repair = 2,
    /// <summary>Aerial Refueling High Fidelity</summary>
    AerialRefuelingHighFidelity = 3,
    /// <summary>Aerial Refueling Low Fidelity</summary>
    AerialRefuelingLowFidelity = 4,
}

/// <summary>SISO-REF-010 v36 enumeration UID 270.</summary>
public enum SignalEncodingClass : byte
{
    /// <summary>Encoded audio</summary>
    EncodedAudio = 0,
    /// <summary>Raw Binary Data</summary>
    RawBinaryData = 1,
    /// <summary>Application-Specific Data</summary>
    ApplicationSpecificData = 2,
    /// <summary>Database index</summary>
    DatabaseIndex = 3,
}

/// <summary>SISO-REF-010 v36 enumeration UID 271.</summary>
public enum SignalEncodingType : ushort
{
    /// <summary>8-bit mu-law (ITU-T G.711)</summary>
    Value8BitMuLawItuTG711 = 1,
    /// <summary>CVSD (MIL-STD-188-113)</summary>
    CvsdMilStd188113 = 2,
    /// <summary>ADPCM (ITU-T G.726)</summary>
    AdpcmItuTG726 = 3,
    /// <summary>16-bit Linear PCM 2s Complement, Big Endian</summary>
    Value16BitLinearPcm2sComplementBigEndian = 4,
    /// <summary>8-bit Linear PCM, Unsigned</summary>
    Value8BitLinearPcmUnsigned = 5,
    /// <summary>VQ (Vector Quantization)</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    VqVectorQuantization = 6,
    /// <summary>(unavailable for use)</summary>
    UnavailableForUse = 7,
    /// <summary>GSM Full-Rate (ETSI 06.10)</summary>
    GsmFullRateEtsi0610 = 8,
    /// <summary>GSM Half-Rate (ETSI 06.20)</summary>
    GsmHalfRateEtsi0620 = 9,
    /// <summary>Speex Narrow Band</summary>
    SpeexNarrowBand = 10,
    /// <summary>Opus</summary>
    Opus = 11,
    /// <summary>LPC-10 (FIPS PUB 137)</summary>
    Lpc10FipsPub137 = 12,
    /// <summary>16-bit Linear PCM 2s Complement, Little Endian</summary>
    Value16BitLinearPcm2sComplementLittleEndian = 100,
    /// <summary>(unavailable for use)</summary>
    UnavailableForUse255 = 255,
}

/// <summary>SISO-REF-010 v36 enumeration UID 178.</summary>
public enum SignalTdlType : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>PADIL</summary>
    Padil = 1,
    /// <summary>NATO Link-1</summary>
    NatoLink1 = 2,
    /// <summary>ATDL-1</summary>
    Atdl1 = 3,
    /// <summary>Link 11B (TADIL B)</summary>
    Link11bTadilB = 4,
    /// <summary>Situational Awareness Data Link (SADL)</summary>
    SituationalAwarenessDataLinkSadl = 5,
    /// <summary>Link 16 Legacy Format (JTIDS/TADIL-J)</summary>
    Link16LegacyFormatJtidsTadilJ = 6,
    /// <summary>Link 16 Legacy Format (JTIDS/FDL/TADIL-J)</summary>
    Link16LegacyFormatJtidsFdlTadilJ = 7,
    /// <summary>Link 11 (TADIL A)</summary>
    Link11TadilA = 8,
    /// <summary>IJMS</summary>
    Ijms = 9,
    /// <summary>Link 4A (TADIL C)</summary>
    Link4aTadilC = 10,
    /// <summary>Link 4C</summary>
    Link4c = 11,
    /// <summary>TIBS</summary>
    Tibs = 12,
    /// <summary>ATL</summary>
    Atl = 13,
    /// <summary>Constant Source</summary>
    ConstantSource = 14,
    /// <summary>Abbreviated Command and Control</summary>
    AbbreviatedCommandAndControl = 15,
    /// <summary>MILSTAR</summary>
    Milstar = 16,
    /// <summary>ATHS</summary>
    Aths = 17,
    /// <summary>OTHGOLD</summary>
    Othgold = 18,
    /// <summary>TACELINT</summary>
    Tacelint = 19,
    /// <summary>Weapons Data Link (AWW-13)</summary>
    WeaponsDataLinkAww13 = 20,
    /// <summary>Abbreviated Command and Control</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    AbbreviatedCommandAndControl21 = 21,
    /// <summary>Enhanced Position Location Reporting System (EPLRS)</summary>
    EnhancedPositionLocationReportingSystemEplrs = 22,
    /// <summary>Position Location Reporting System (PLRS)</summary>
    PositionLocationReportingSystemPlrs = 23,
    /// <summary>SINCGARS</summary>
    Sincgars = 24,
    /// <summary>HAVE QUICK I</summary>
    HaveQuickI = 25,
    /// <summary>HAVE QUICK II</summary>
    HaveQuickIi = 26,
    /// <summary>SATURN</summary>
    Saturn = 27,
    /// <summary>Intra-Flight Data Link 1</summary>
    IntraFlightDataLink1 = 28,
    /// <summary>Intra-Flight Data Link 2</summary>
    IntraFlightDataLink2 = 29,
    /// <summary>Improved Data Modem (IDM)</summary>
    ImprovedDataModemIdm = 30,
    /// <summary>Air Force Application Program Development (AFAPD)</summary>
    AirForceApplicationProgramDevelopmentAfapd = 31,
    /// <summary>Cooperative Engagement Capability (CEC)</summary>
    CooperativeEngagementCapabilityCec = 32,
    /// <summary>Forward Area Air Defense (FAAD) Data Link (FDL)</summary>
    ForwardAreaAirDefenseFaadDataLinkFdl = 33,
    /// <summary>Ground Based Data Link (GBDL)</summary>
    GroundBasedDataLinkGbdl = 34,
    /// <summary>Intra Vehicular Info System (IVIS)</summary>
    IntraVehicularInfoSystemIvis = 35,
    /// <summary>Marine Tactical System (MTS)</summary>
    MarineTacticalSystemMts = 36,
    /// <summary>Tactical Fire Direction System (TACFIRE)</summary>
    TacticalFireDirectionSystemTacfire = 37,
    /// <summary>Integrated Broadcast Service (IBS)</summary>
    IntegratedBroadcastServiceIbs = 38,
    /// <summary>Airborne Information Transfer (ABIT)</summary>
    AirborneInformationTransferAbit = 39,
    /// <summary>Advanced Tactical Airborne Reconnaissance System (ATARS) Data Link</summary>
    AdvancedTacticalAirborneReconnaissanceSystemAtarsDataLink = 40,
    /// <summary>Battle Group Passive Horizon Extension System (BGPHES) Data Link</summary>
    BattleGroupPassiveHorizonExtensionSystemBgphesDataLink = 41,
    /// <summary>Common High Bandwidth Data Link (CHBDL)</summary>
    CommonHighBandwidthDataLinkChbdl = 42,
    /// <summary>Guardrail Interoperable Data Link (IDL)</summary>
    GuardrailInteroperableDataLinkIdl = 43,
    /// <summary>Guardrail Common Sensor System One (CSS1) Data Link</summary>
    GuardrailCommonSensorSystemOneCss1DataLink = 44,
    /// <summary>Guardrail Common Sensor System Two (CSS2) Data Link</summary>
    GuardrailCommonSensorSystemTwoCss2DataLink = 45,
    /// <summary>Guardrail CSS2 Multi-Role Data Link (MRDL)</summary>
    GuardrailCss2MultiRoleDataLinkMrdl = 46,
    /// <summary>Guardrail CSS2 Direct Air to Satellite Relay (DASR) Data Link</summary>
    GuardrailCss2DirectAirToSatelliteRelayDasrDataLink = 47,
    /// <summary>Line of Sight (LOS) Data Link Implementation (LOS tether)</summary>
    LineOfSightLosDataLinkImplementationLosTether = 48,
    /// <summary>Lightweight CDL (LWCDL)</summary>
    LightweightCdlLwcdl = 49,
    /// <summary>L-52M (SR-71)</summary>
    L52mSr71 = 50,
    /// <summary>Rivet Reach/Rivet Owl Data Link</summary>
    RivetReachRivetOwlDataLink = 51,
    /// <summary>Senior Span</summary>
    SeniorSpan = 52,
    /// <summary>Senior Spur</summary>
    SeniorSpur = 53,
    /// <summary>Senior Stretch.</summary>
    SeniorStretch = 54,
    /// <summary>Senior Year Interoperable Data Link (IDL)</summary>
    SeniorYearInteroperableDataLinkIdl = 55,
    /// <summary>Space CDL</summary>
    SpaceCdl = 56,
    /// <summary>TR-1 mode MIST Airborne Data Link</summary>
    Tr1ModeMistAirborneDataLink = 57,
    /// <summary>Ku-band SATCOM Data Link Implementation (UAV)</summary>
    KuBandSatcomDataLinkImplementationUav = 58,
    /// <summary>Mission Equipment Control Data link (MECDL)</summary>
    MissionEquipmentControlDataLinkMecdl = 59,
    /// <summary>Radar Data Transmitting Set Data Link</summary>
    RadarDataTransmittingSetDataLink = 60,
    /// <summary>Surveillance and Control Data Link (SCDL)</summary>
    SurveillanceAndControlDataLinkScdl = 61,
    /// <summary>Tactical UAV Video</summary>
    TacticalUavVideo = 62,
    /// <summary>UHF SATCOM Data Link Implementation (UAV)</summary>
    UhfSatcomDataLinkImplementationUav = 63,
    /// <summary>Tactical Common Data Link (TCDL)</summary>
    TacticalCommonDataLinkTcdl = 64,
    /// <summary>Low Level Air Picture Interface (LLAPI)</summary>
    LowLevelAirPictureInterfaceLlapi = 65,
    /// <summary>Weapons Data Link (AGM-130)</summary>
    WeaponsDataLinkAgm130 = 66,
    /// <summary>Automatic Identification System (AIS)</summary>
    AutomaticIdentificationSystemAis = 67,
    /// <summary>Weapons Data Link (AIM-120)</summary>
    WeaponsDataLinkAim120 = 68,
    /// <summary>Weapons Data Link (AIM-9)</summary>
    WeaponsDataLinkAim9 = 69,
    /// <summary>Weapons Data Link (CAMM)</summary>
    WeaponsDataLinkCamm = 70,
    /// <summary>GC3</summary>
    Gc3 = 99,
    /// <summary>Link 16 Standardized Format (JTIDS/MIDS/TADIL J)</summary>
    Link16StandardizedFormatJtidsMidsTadilJ = 100,
    /// <summary>Link 16 Enhanced Data Rate (EDR JTIDS/MIDS/TADIL-J)</summary>
    Link16EnhancedDataRateEdrJtidsMidsTadilJ = 101,
    /// <summary>JTIDS/MIDS Net Data Load (TIMS/TOMS)</summary>
    JtidsMidsNetDataLoadTimsToms = 102,
    /// <summary>Link 22</summary>
    Link22 = 103,
    /// <summary>AFIWC IADS Communications Links</summary>
    AfiwcIadsCommunicationsLinks = 104,
    /// <summary>F-22 Intra-Flight Data Link (IFDL)</summary>
    F22IntraFlightDataLinkIfdl = 105,
    /// <summary>L-Band SATCOM</summary>
    LBandSatcom = 106,
    /// <summary>TSAF Communications Link</summary>
    TsafCommunicationsLink = 107,
    /// <summary>Enhanced SINCGARS 7.3</summary>
    EnhancedSincgars73 = 108,
    /// <summary>F-35 Multifunction Advanced Data Link (MADL)</summary>
    F35MultifunctionAdvancedDataLinkMadl = 109,
    /// <summary>Cursor on Target</summary>
    CursorOnTarget = 110,
    /// <summary>All Purpose Structured Eurocontrol Surveillance Information Exchange (ASTERIX)</summary>
    AllPurposeStructuredEurocontrolSurveillanceInformationExchangeAsterix = 111,
    /// <summary>Variable Message Format (VMF) over Combat Net Radio (VMF over CNR)</summary>
    VariableMessageFormatVmfOverCombatNetRadioVmfOverCnr = 112,
    /// <summary>Link 16 Surrogate for Non-NATO TDL</summary>
    Link16SurrogateForNonNatoTdl = 113,
    /// <summary>MQ-1/9 C-Band LOS Uplink</summary>
    Mq19CBandLosUplink = 114,
    /// <summary>MQ-1/9 C-Band LOS Downlink</summary>
    Mq19CBandLosDownlink = 115,
    /// <summary>MQ-1/9 Ku-Band SATCOM Uplink</summary>
    Mq19KuBandSatcomUplink = 116,
    /// <summary>MQ-1/9 Ku-Band SATCOM Downlink</summary>
    Mq19KuBandSatcomDownlink = 117,
    /// <summary>Weapons Datalink (SDB II)</summary>
    WeaponsDatalinkSdbIi = 118,
    /// <summary>JTAC SA Uplink</summary>
    JtacSaUplink = 119,
    /// <summary>Common Interactive Broadcast (CIB)</summary>
    CommonInteractiveBroadcastCib = 120,
    /// <summary>Joint Range Extension Application Protocol A (JREAP A)</summary>
    JointRangeExtensionApplicationProtocolAJreapA = 121,
    /// <summary>JPALS Data Link</summary>
    JpalsDataLink = 125,
    /// <summary>OneSAF IADS Communications Link</summary>
    OneSAFIadsCommunicationsLink = 126,
    /// <summary>Tactical Targeting Network Technology (TTNT) Application</summary>
    TacticalTargetingNetworkTechnologyTtntApplication = 127,
}

/// <summary>SISO-REF-010 v36 bitfield UID 68. Unknown and reserved bits are preserved in <see cref="Value"/>.</summary>
public readonly partial record struct StopFreezeFrozenBehavior(byte Value)
{
    public static StopFreezeFrozenBehavior None => new(0);

    /// <summary>Describes whether a simulation application should run the internal simulation clock or not</summary>
    public bool RunSimulationClock => (Value & 1) != 0;
    public StopFreezeFrozenBehavior WithRunSimulationClock(bool value) => new((byte)(value ? Value | 1 : Value & ~1));

    /// <summary>Describes whether a simulation application should transmit updates and interactions or not</summary>
    public bool TransmitUpdates => (Value & 2) != 0;
    public StopFreezeFrozenBehavior WithTransmitUpdates(bool value) => new((byte)(value ? Value | 2 : Value & ~2));

    /// <summary>Describes whether a simulation application should update simulation models of other entities via received updates or interactions</summary>
    public bool ProcessUpdates => (Value & 4) != 0;
    public StopFreezeFrozenBehavior WithProcessUpdates(bool value) => new((byte)(value ? Value | 4 : Value & ~4));

    public static implicit operator StopFreezeFrozenBehavior(byte value) => new(value);
    public static implicit operator byte(StopFreezeFrozenBehavior value) => value.Value;
    public override string ToString() => $"0x{Value:X2}";
}

/// <summary>SISO-REF-010 v36 enumeration UID 67.</summary>
public enum StopFreezeReason : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Recess</summary>
    Recess = 1,
    /// <summary>Termination</summary>
    Termination = 2,
    /// <summary>System Failure</summary>
    SystemFailure = 3,
    /// <summary>Security Violation</summary>
    SecurityViolation = 4,
    /// <summary>Entity Reconstitution</summary>
    EntityReconstitution = 5,
    /// <summary>Stop for reset</summary>
    StopForReset = 6,
    /// <summary>Stop for restart</summary>
    StopForRestart = 7,
    /// <summary>Abort Training Return to Tactical Operations</summary>
    AbortTrainingReturnToTacticalOperations = 8,
}

/// <summary>SISO-REF-010 v36 enumeration UID 413.</summary>
public enum SupplyFuelType : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Gasoline</summary>
    Gasoline = 1,
    /// <summary>Diesel Fuel (F-54/DF-2)</summary>
    DieselFuelF54Df2 = 2,
    /// <summary>JP-4 (F-40/JET B)</summary>
    Jp4F40JetB = 3,
    /// <summary>Fuel Oil</summary>
    FuelOil = 4,
    /// <summary>JP-8 (F-34/JET A-1)</summary>
    Jp8F34JetA1 = 5,
    /// <summary>Fog Oil</summary>
    FogOil = 6,
    /// <summary>Multi-Spectral Fog Oil</summary>
    MultiSpectralFogOil = 7,
    /// <summary>JP-5 (F-44/JET A)</summary>
    Jp5F44JetA = 8,
    /// <summary>JPTS</summary>
    Jpts = 9,
    /// <summary>TS-1 (Russia (RUS))</summary>
    Ts1RussiaRus = 10,
}

/// <summary>SISO-REF-010 v36 enumeration UID 224.</summary>
public enum TransferControlTransferType : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Push Transfer - Entity</summary>
    PushTransferEntity = 1,
    /// <summary>Automatic Pull Transfer - Entity</summary>
    AutomaticPullTransferEntity = 2,
    /// <summary>Not Used</summary>
    NotUsed = 3,
    /// <summary>Push Transfer - Environmental Process</summary>
    PushTransferEnvironmentalProcess = 4,
    /// <summary>Automatic Pull Transfer - Environmental Process</summary>
    AutomaticPullTransferEnvironmentalProcess = 5,
    /// <summary>Not Used</summary>
    NotUsed6 = 6,
    /// <summary>Cancel Transfer</summary>
    CancelTransfer = 7,
    /// <summary>Manual Pull Transfer - Entity</summary>
    ManualPullTransferEntity = 8,
    /// <summary>Manual Pull Transfer - Environmental Process</summary>
    ManualPullTransferEnvironmentalProcess = 9,
    /// <summary>Remove Entity</summary>
    RemoveEntity = 10,
}

/// <summary>SISO-REF-010 v36 enumeration UID 168.</summary>
public enum TransmitterAntennaPatternReferenceSystem : byte
{
    /// <summary>World Coordinates</summary>
    WorldCoordinates = 1,
    /// <summary>Entity Coordinates</summary>
    EntityCoordinates = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 167.</summary>
public enum TransmitterAntennaPatternType : ushort
{
    /// <summary>Isotropic (Spherical Radiation Pattern)</summary>
    IsotropicSphericalRadiationPattern = 0,
    /// <summary>Beam</summary>
    Beam = 1,
    /// <summary>Spherical harmonic</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    SphericalHarmonic = 2,
    /// <summary>Transmitter Radiation Volume</summary>
    TransmitterRadiationVolume = 4,
    /// <summary>Beam and Transmitter Radiation Volume</summary>
    BeamAndTransmitterRadiationVolume = 5,
    /// <summary>Omnidirectional (Toroidal Radiation Pattern)</summary>
    OmnidirectionalToroidalRadiationPattern = 6,
}

/// <summary>SISO-REF-010 v36 enumeration UID 166.</summary>
public enum TransmitterCryptoSystem : ushort
{
    /// <summary>No Encryption Device</summary>
    NoEncryptionDevice = 0,
    /// <summary>KY-28</summary>
    Ky28 = 1,
    /// <summary>KY-58</summary>
    Ky58 = 2,
    /// <summary>Narrow Spectrum Secure Voice (NSVE)</summary>
    NarrowSpectrumSecureVoiceNsve = 3,
    /// <summary>Wide Spectrum Secure Voice (WSVE)</summary>
    WideSpectrumSecureVoiceWsve = 4,
    /// <summary>SINCGARS ICOM</summary>
    SincgarsIcom = 5,
    /// <summary>KY-75</summary>
    Ky75 = 6,
    /// <summary>KY-100</summary>
    Ky100 = 7,
    /// <summary>KY-57</summary>
    Ky57 = 8,
    /// <summary>KYV-5</summary>
    Kyv5 = 9,
    /// <summary>Link 11 KG-40A-P (NTDS)</summary>
    Link11Kg40aPNtds = 10,
    /// <summary>Link 11B KG-40A-S</summary>
    Link11bKg40aS = 11,
    /// <summary>Link 11 KG-40AR</summary>
    Link11Kg40ar = 12,
    /// <summary>KGV-135A</summary>
    Kgv135a = 13,
    /// <summary>Tactical Secure Voice (TSV)</summary>
    TacticalSecureVoiceTsv = 14,
}

/// <summary>SISO-REF-010 v36 enumeration UID 165.</summary>
public enum TransmitterInputSource : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Pilot</summary>
    Pilot = 1,
    /// <summary>Copilot</summary>
    Copilot = 2,
    /// <summary>First Officer</summary>
    FirstOfficer = 3,
    /// <summary>Driver</summary>
    Driver = 4,
    /// <summary>Loader</summary>
    Loader = 5,
    /// <summary>Gunner</summary>
    Gunner = 6,
    /// <summary>Commander</summary>
    Commander = 7,
    /// <summary>Digital Data Device</summary>
    DigitalDataDevice = 8,
    /// <summary>Intercom</summary>
    Intercom = 9,
    /// <summary>Audio Jammer</summary>
    AudioJammer = 10,
    /// <summary>Data Jammer</summary>
    DataJammer = 11,
    /// <summary>GPS Jammer</summary>
    GpsJammer = 12,
    /// <summary>GPS Meaconer</summary>
    GpsMeaconer = 13,
    /// <summary>SATCOM Uplink Jammer</summary>
    SatcomUplinkJammer = 14,
    /// <summary>Crew Observer 1</summary>
    CrewObserver1 = 15,
    /// <summary>Crew Observer 2</summary>
    CrewObserver2 = 16,
    /// <summary>Aerial Refueling Officer (ARO)</summary>
    AerialRefuelingOfficerAro = 17,
    /// <summary>Aerial Refueling Officer Instructor (AROI)</summary>
    AerialRefuelingOfficerInstructorAroi = 18,
}

/// <summary>SISO-REF-010 v36 enumeration UID 155.</summary>
public enum TransmitterMajorModulation : ushort
{
    /// <summary>No Statement</summary>
    NoStatement = 0,
    /// <summary>Amplitude</summary>
    Amplitude = 1,
    /// <summary>Amplitude and Angle</summary>
    AmplitudeAndAngle = 2,
    /// <summary>Angle</summary>
    Angle = 3,
    /// <summary>Combination</summary>
    Combination = 4,
    /// <summary>Pulse</summary>
    Pulse = 5,
    /// <summary>Unmodulated</summary>
    Unmodulated = 6,
    /// <summary>Carrier Phase Shift Modulation (CPSM)</summary>
    CarrierPhaseShiftModulationCpsm = 7,
    /// <summary>SATCOM</summary>
    Satcom = 8,
}

/// <summary>SISO-REF-010 v36 enumeration UID 163.</summary>
public enum TransmitterModulationTypeSystem : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Generic Radio or Simple Intercom</summary>
    GenericRadioOrSimpleIntercom = 1,
    /// <summary>HAVE QUICK I</summary>
    HaveQuickI = 2,
    /// <summary>HAVE QUICK II</summary>
    HaveQuickIi = 3,
    /// <summary>SATURN</summary>
    Saturn = 4,
    /// <summary>SINCGARS</summary>
    Sincgars = 5,
    /// <summary>CCTT SINCGARS</summary>
    CcttSincgars = 6,
    /// <summary>EPLRS (Enhanced Position Location Reporting System)</summary>
    EplrsEnhancedPositionLocationReportingSystem = 7,
    /// <summary>JTIDS/MIDS</summary>
    JtidsMids = 8,
    /// <summary>Link 11</summary>
    Link11 = 9,
    /// <summary>Link 11B</summary>
    Link11b = 10,
    /// <summary>L-Band SATCOM</summary>
    LBandSatcom = 11,
    /// <summary>Enhanced SINCGARS 7.3</summary>
    EnhancedSincgars73 = 12,
    /// <summary>Navigation Aid</summary>
    NavigationAid = 13,
    /// <summary>MUOS</summary>
    Muos = 14,
}

/// <summary>SISO-REF-010 v36 enumeration UID 164.</summary>
public enum TransmitterTransmitState : byte
{
    /// <summary>Off</summary>
    Off = 0,
    /// <summary>On but not transmitting</summary>
    OnButNotTransmitting = 1,
    /// <summary>On and transmitting</summary>
    OnAndTransmitting = 2,
}

/// <summary>SISO-REF-010 v36 enumeration UID 145.</summary>
public enum UaAcousticEmitterSystemFunction : byte
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>Platform search/detect/track</summary>
    PlatformSearchDetectTrack = 1,
    /// <summary>Navigation</summary>
    Navigation = 2,
    /// <summary>Mine hunting</summary>
    MineHunting = 3,
    /// <summary>Weapon search/detect/track/detect</summary>
    WeaponSearchDetectTrackDetect = 4,
}

/// <summary>SISO-REF-010 v36 enumeration UID 144.</summary>
public enum UaAcousticSystemName : ushort
{
    /// <summary>Other</summary>
    Other = 0,
    /// <summary>AN/BQQ-5</summary>
    AnBqq5 = 1,
    /// <summary>AN/SSQ-62</summary>
    AnSsq62 = 2,
    /// <summary>AN/SQS-23</summary>
    AnSqs23 = 3,
    /// <summary>AN/SQS-26</summary>
    AnSqs26 = 4,
    /// <summary>AN/SQS-53</summary>
    AnSqs53 = 5,
    /// <summary>ALFS</summary>
    Alfs = 6,
    /// <summary>LFA</summary>
    Lfa = 7,
    /// <summary>AN/AQS-901</summary>
    AnAqs901 = 8,
    /// <summary>AN/AQS-902</summary>
    AnAqs902 = 9,
}

/// <summary>SISO-REF-010 v36 enumeration UID 146.</summary>
public enum UaActiveEmissionParameterIndex : ushort
{
    /// <summary>Other</summary>
    Other = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 148.</summary>
public enum UaPassiveParameterIndex : ushort
{
    /// <summary>Other</summary>
    Other = 0,
}

/// <summary>SISO-REF-010 v36 enumeration UID 147.</summary>
public enum UaScanPattern : ushort
{
    /// <summary>Scan pattern not used</summary>
    ScanPatternNotUsed = 0,
    /// <summary>Conical</summary>
    Conical = 1,
    /// <summary>Helical</summary>
    Helical = 2,
    /// <summary>Raster</summary>
    Raster = 3,
    /// <summary>Sector search</summary>
    SectorSearch = 4,
    /// <summary>Continuous search</summary>
    ContinuousSearch = 5,
}

/// <summary>SISO-REF-010 v36 enumeration UID 143.</summary>
public enum UaStateChangeUpdateIndicator : byte
{
    /// <summary>State Update</summary>
    StateUpdate = 0,
    /// <summary>Changed Data Update</summary>
    ChangedDataUpdate = 1,
}

/// <summary>SISO-REF-010 v36 enumeration UID 56.</summary>
public enum VariableParameterRecordType : byte
{
    /// <summary>Articulated Part</summary>
    ArticulatedPart = 0,
    /// <summary>Attached Part</summary>
    AttachedPart = 1,
    /// <summary>Separation</summary>
    Separation = 2,
    /// <summary>Entity Type</summary>
    EntityType = 3,
    /// <summary>Entity Association</summary>
    EntityAssociation = 4,
}

/// <summary>SISO-REF-010 v36 enumeration UID 66.</summary>
public enum VariableRecordType : uint
{
    /// <summary>Not Used (Invalid Value)</summary>
    NotUsedInvalidValue = 0u,
    /// <summary>Entity ID List</summary>
    EntityIdList = 1u,
    /// <summary>DDCP Join Transaction Join Request Message</summary>
    DdcpJoinTransactionJoinRequestMessage = 1001u,
    /// <summary>DDCP Set Playback Window Transaction Set Playback Window Request Message</summary>
    DdcpSetPlaybackWindowTransactionSetPlaybackWindowRequestMessage = 1002u,
    /// <summary>DDCP Load Mission Recording Transaction Load Mission Recording Request Message</summary>
    DdcpLoadMissionRecordingTransactionLoadMissionRecordingRequestMessage = 1003u,
    /// <summary>DDCP Cue Transaction Cue Request Message</summary>
    DdcpCueTransactionCueRequestMessage = 1004u,
    /// <summary>DDCP Play Transaction Play Request Message</summary>
    DdcpPlayTransactionPlayRequestMessage = 1005u,
    /// <summary>DDCP Stop Transaction Stop Request Message</summary>
    DdcpStopTransactionStopRequestMessage = 1006u,
    /// <summary>DDCP Pause Transaction Pause Request Message</summary>
    DdcpPauseTransactionPauseRequestMessage = 1007u,
    /// <summary>DDCP End Transaction End Request Message</summary>
    DdcpEndTransactionEndRequestMessage = 1009u,
    /// <summary>DDCP Join Response Message</summary>
    DdcpJoinResponseMessage = 1051u,
    /// <summary>DDCP Request Receipt Message</summary>
    DdcpRequestReceiptMessage = 1052u,
    /// <summary>DDCP Playback Window Confirmed Message</summary>
    DdcpPlaybackWindowConfirmedMessage = 1053u,
    /// <summary>DDCP Mission Recording Loaded Message</summary>
    DdcpMissionRecordingLoadedMessage = 1054u,
    /// <summary>DDCP Cue Confirmed Message</summary>
    DdcpCueConfirmedMessage = 1055u,
    /// <summary>DDCP Time to Complete Message</summary>
    DdcpTimeToCompleteMessage = 1056u,
    /// <summary>DDCP Play Commenced Message</summary>
    DdcpPlayCommencedMessage = 1057u,
    /// <summary>DDCP Stop Confirmed Message</summary>
    DdcpStopConfirmedMessage = 1058u,
    /// <summary>DDCP Pause Confirmed Message</summary>
    DdcpPauseConfirmedMessage = 1059u,
    /// <summary>DDCP End Response Message</summary>
    DdcpEndResponseMessage = 1061u,
    /// <summary>DDCP Master Announce Message</summary>
    DdcpMasterAnnounceMessage = 1111u,
    /// <summary>DDCP Device Announce Message</summary>
    DdcpDeviceAnnounceMessage = 1112u,
    /// <summary>DDCP Device Exit Message</summary>
    DdcpDeviceExitMessage = 1114u,
    /// <summary>DDCP Device Heartbeat Message</summary>
    DdcpDeviceHeartbeatMessage = 1115u,
    /// <summary>DDCP Master Time Sync Message</summary>
    DdcpMasterTimeSyncMessage = 1116u,
    /// <summary>DDCP Error Message</summary>
    DdcpErrorMessage = 1118u,
    /// <summary>DDCP Master Stop Sync Message</summary>
    DdcpMasterStopSyncMessage = 1119u,
    /// <summary>DDCP Master Transition Message</summary>
    DdcpMasterTransitionMessage = 1120u,
    /// <summary>Mission Time</summary>
    MissionTime = 1200u,
    /// <summary>High Fidelity HAVE QUICK/SATURN Radio</summary>
    HighFidelityHaveQuickSaturnRadio = 3000u,
    /// <summary>Blanking Sector attribute record</summary>
    BlankingSectorAttributeRecord = 3500u,
    /// <summary>Angle Deception attribute record</summary>
    AngleDeceptionAttributeRecord = 3501u,
    /// <summary>False Targets attribute record</summary>
    FalseTargetsAttributeRecord = 3502u,
    /// <summary>DE Precision Aimpoint record</summary>
    DePrecisionAimpointRecord = 4000u,
    /// <summary>DE Area Aimpoint record</summary>
    DeAreaAimpointRecord = 4001u,
    /// <summary>Directed Energy Damage Description record</summary>
    DirectedEnergyDamageDescriptionRecord = 4500u,
    /// <summary>Crypto Control</summary>
    CryptoControl = 5000u,
    /// <summary>Mode 5/S Transponder Location</summary>
    Mode5STransponderLocation = 5001u,
    /// <summary>Mode 5/S Transponder Location Error</summary>
    Mode5STransponderLocationError = 5002u,
    /// <summary>Squitter Airborne Position Report</summary>
    SquitterAirbornePositionReport = 5003u,
    /// <summary>Squitter Airborne Velocity Report</summary>
    SquitterAirborneVelocityReport = 5004u,
    /// <summary>Squitter Surface Position Report</summary>
    SquitterSurfacePositionReport = 5005u,
    /// <summary>Squitter Identification Report</summary>
    SquitterIdentificationReport = 5006u,
    /// <summary>GICB</summary>
    Gicb = 5007u,
    /// <summary>Squitter Event-Driven Report</summary>
    SquitterEventDrivenReport = 5008u,
    /// <summary>Antenna Location</summary>
    AntennaLocation = 5009u,
    /// <summary>Basic Interactive</summary>
    BasicInteractive = 5010u,
    /// <summary>Interactive Mode 4 Reply</summary>
    InteractiveMode4Reply = 5011u,
    /// <summary>Interactive Mode 5 Reply</summary>
    InteractiveMode5Reply = 5012u,
    /// <summary>Interactive Basic Mode 5</summary>
    InteractiveBasicMode5 = 5013u,
    /// <summary>Interactive Basic Mode S</summary>
    InteractiveBasicModeS = 5014u,
    /// <summary>IO Effect</summary>
    IoEffect = 5500u,
    /// <summary>IO Communications Node</summary>
    IoCommunicationsNode = 5501u,
    /// <summary>Identification</summary>
    Identification = 10000u,
    /// <summary>Trainer Initial Conditions Filename</summary>
    TrainerInitialConditionsFilename = 10010u,
    /// <summary>Increment 3.1 Mission Data Load Name</summary>
    Increment31MissionDataLoadName = 10020u,
    /// <summary>Increment 2 Mission Data Load Name</summary>
    Increment2MissionDataLoadName = 10030u,
    /// <summary>Set Markpoint Command</summary>
    SetMarkpointCommand = 10110u,
    /// <summary>Markpoint ID</summary>
    MarkpointId = 10115u,
    /// <summary>Reaction Level</summary>
    ReactionLevel = 10140u,
    /// <summary>Weapon Reload</summary>
    WeaponReload = 10150u,
    /// <summary>CES Entity Set / Clear Status</summary>
    CesEntitySetClearStatus = 10157u,
    /// <summary>Activate Entity</summary>
    ActivateEntity = 10160u,
    /// <summary>Disengage / Reengage</summary>
    DisengageReengage = 10170u,
    /// <summary>Fuel Freeze</summary>
    FuelFreeze = 10190u,
    /// <summary>Fire Launch Dispense</summary>
    FireLaunchDispense = 10250u,
    /// <summary>Target Assignment</summary>
    TargetAssignment = 10254u,
    /// <summary>CIC Enable</summary>
    CicEnable = 10256u,
    /// <summary>Shoot Inhibit</summary>
    ShootInhibit = 10258u,
    /// <summary>Posture</summary>
    Posture = 10259u,
    /// <summary>Jammer State</summary>
    JammerState = 10262u,
    /// <summary>Jammer Type</summary>
    JammerType = 10263u,
    /// <summary>Dynamic Targeting</summary>
    DynamicTargeting = 10264u,
    /// <summary>Manual Jamming On Override</summary>
    ManualJammingOnOverride = 10267u,
    /// <summary>SOJ Axis</summary>
    SojAxis = 10268u,
    /// <summary>Emitter Override</summary>
    EmitterOverride = 10280u,
    /// <summary>Shields</summary>
    Shields = 10290u,
    /// <summary>Crash Override</summary>
    CrashOverride = 10300u,
    /// <summary>Stop Buzzer</summary>
    StopBuzzer = 10306u,
    /// <summary>Target Lasing - On / Off</summary>
    TargetLasingOnOff = 10307u,
    /// <summary>Target Lasing - Laser Code</summary>
    TargetLasingLaserCode = 10308u,
    /// <summary>Power Plant</summary>
    PowerPlant = 10310u,
    /// <summary>Tactical Lighting On / Off Control - Light Control</summary>
    TacticalLightingOnOffControlLightControl = 10311u,
    /// <summary>Tactical Lighting Blinker Control - Blinker Value</summary>
    TacticalLightingBlinkerControlBlinkerValue = 10312u,
    /// <summary>Tactical Lighting On / Off Control - Light Control Type</summary>
    TacticalLightingOnOffControlLightControlType = 10313u,
    /// <summary>Park Vehicle</summary>
    ParkVehicle = 10314u,
    /// <summary>Signaling On / Off</summary>
    SignalingOnOff = 10315u,
    /// <summary>Signaling Device</summary>
    SignalingDevice = 10316u,
    /// <summary>Ownship ID</summary>
    OwnshipId = 10400u,
    /// <summary>State Change</summary>
    StateChange = 10600u,
    /// <summary>Entity Type</summary>
    EntityType = 11000u,
    /// <summary>Concatenated</summary>
    Concatenated = 11100u,
    /// <summary>Kind</summary>
    Kind = 11110u,
    /// <summary>Domain</summary>
    Domain = 11120u,
    /// <summary>Country</summary>
    Country = 11130u,
    /// <summary>Category</summary>
    Category = 11140u,
    /// <summary>Subcategory</summary>
    Subcategory = 11150u,
    /// <summary>Specific</summary>
    Specific = 11160u,
    /// <summary>Extra</summary>
    Extra = 11170u,
    /// <summary>Force ID</summary>
    ForceId = 11180u,
    /// <summary>Force ID</summary>
    ForceId11200 = 11200u,
    /// <summary>Description</summary>
    Description = 11300u,
    /// <summary>Tanker Boom Control</summary>
    TankerBoomControl = 11500u,
    /// <summary>Airport Lights</summary>
    AirportLights = 11501u,
    /// <summary>Weather Post</summary>
    WeatherPost = 11502u,
    /// <summary>Localizer and GlideSlope</summary>
    LocalizerAndGlideSlope = 11503u,
    /// <summary>TACAN NavAids</summary>
    TacanNavAids = 11504u,
    /// <summary>Alternative Entity Type</summary>
    AlternativeEntityType = 12000u,
    /// <summary>Kind</summary>
    Kind12110 = 12110u,
    /// <summary>Domain</summary>
    Domain12120 = 12120u,
    /// <summary>Country</summary>
    Country12130 = 12130u,
    /// <summary>Category</summary>
    Category12140 = 12140u,
    /// <summary>Subcategory</summary>
    Subcategory12150 = 12150u,
    /// <summary>Specific</summary>
    Specific12160 = 12160u,
    /// <summary>Extra</summary>
    Extra12170 = 12170u,
    /// <summary>Description</summary>
    Description12300 = 12300u,
    /// <summary>Entity Marking</summary>
    EntityMarking = 13000u,
    /// <summary>Entity Marking Characters</summary>
    EntityMarkingCharacters = 13100u,
    /// <summary>Crew ID</summary>
    CrewId = 13200u,
    /// <summary>Task Organization</summary>
    TaskOrganization = 14000u,
    /// <summary>Regiment Name</summary>
    RegimentName = 14200u,
    /// <summary>Battalion Name</summary>
    BattalionName = 14300u,
    /// <summary>Company Name</summary>
    CompanyName = 14400u,
    /// <summary>Platoon Name</summary>
    PlatoonName = 14500u,
    /// <summary>Squad Name</summary>
    SquadName = 14520u,
    /// <summary>Team Name</summary>
    TeamName = 14540u,
    /// <summary>Bumper Number</summary>
    BumperNumber = 14600u,
    /// <summary>Vehicle Number</summary>
    VehicleNumber = 14700u,
    /// <summary>Unit Number</summary>
    UnitNumber = 14800u,
    /// <summary>DIS Identity</summary>
    DisIdentity = 15000u,
    /// <summary>DIS Site ID</summary>
    DisSiteId = 15100u,
    /// <summary>DIS Host ID</summary>
    DisHostId = 15200u,
    /// <summary>DIS Entity ID</summary>
    DisEntityId = 15300u,
    /// <summary>Mount Intent</summary>
    MountIntent = 15400u,
    /// <summary>Tether-Untether Command ID</summary>
    TetherUntetherCommandId = 15500u,
    /// <summary>Teleport Entity Data Record</summary>
    TeleportEntityDataRecord = 15510u,
    /// <summary>DIS Aggregate ID (Set if communication to aggregate)</summary>
    DisAggregateIdSetIfCommunicationToAggregate = 15600u,
    /// <summary>Ownership Status</summary>
    OwnershipStatus = 15800u,
    /// <summary>Reconstitute</summary>
    Reconstitute = 19177u,
    /// <summary>Loads</summary>
    Loads = 20000u,
    /// <summary>Crew Members</summary>
    CrewMembers = 21000u,
    /// <summary>Crew Member ID</summary>
    CrewMemberId = 21100u,
    /// <summary>Health</summary>
    Health = 21200u,
    /// <summary>Job Assignment</summary>
    JobAssignment = 21300u,
    /// <summary>Fuel</summary>
    Fuel = 23000u,
    /// <summary>Quantity</summary>
    Quantity = 23100u,
    /// <summary>Quantity</summary>
    Quantity23105 = 23105u,
    /// <summary>Ammunition</summary>
    Ammunition = 24000u,
    /// <summary>120-mm HEAT, quantity</summary>
    Value120MmHeatQuantity = 24001u,
    /// <summary>120-mm SABOT, quantity</summary>
    Value120MmSabotQuantity = 24002u,
    /// <summary>12.7-mm M8, quantity</summary>
    Value127MmM8Quantity = 24003u,
    /// <summary>12.7-mm M20, quantity</summary>
    Value127MmM20Quantity = 24004u,
    /// <summary>7.62-mm M62, quantity</summary>
    Value762MmM62Quantity = 24005u,
    /// <summary>M250 UKL8A1, quantity</summary>
    M250Ukl8a1Quantity = 24006u,
    /// <summary>M250 UKL8A3, quantity</summary>
    M250Ukl8a3Quantity = 24007u,
    /// <summary>7.62-mm M80, quantity</summary>
    Value762MmM80Quantity = 24008u,
    /// <summary>12.7-mm, quantity</summary>
    Value127MmQuantity = 24009u,
    /// <summary>7.62-mm, quantity</summary>
    Value762MmQuantity = 24010u,
    /// <summary>Mines, quantity</summary>
    MinesQuantity = 24060u,
    /// <summary>Type</summary>
    Type = 24100u,
    /// <summary>Kind</summary>
    Kind24110 = 24110u,
    /// <summary>Domain</summary>
    Domain24120 = 24120u,
    /// <summary>Country</summary>
    Country24130 = 24130u,
    /// <summary>Category</summary>
    Category24140 = 24140u,
    /// <summary>Subcategory</summary>
    Subcategory24150 = 24150u,
    /// <summary>Extra</summary>
    Extra24160 = 24160u,
    /// <summary>Description</summary>
    Description24300 = 24300u,
    /// <summary>Cargo</summary>
    Cargo = 25000u,
    /// <summary>Vehicle Mass</summary>
    VehicleMass = 26000u,
    /// <summary>Supply Quantity</summary>
    SupplyQuantity = 27000u,
    /// <summary>Armament</summary>
    Armament = 28000u,
    /// <summary>Status</summary>
    Status = 30000u,
    /// <summary>Activate entity</summary>
    ActivateEntity30010 = 30010u,
    /// <summary>Subscription State</summary>
    SubscriptionState = 30100u,
    /// <summary>Round trip time delay</summary>
    RoundTripTimeDelay = 30300u,
    /// <summary>TADIL J message count (label 0)</summary>
    TadilJMessageCountLabel0 = 30400u,
    /// <summary>TADIL J message count (label 1)</summary>
    TadilJMessageCountLabel1 = 30401u,
    /// <summary>TADIL J message count (label 2)</summary>
    TadilJMessageCountLabel2 = 30402u,
    /// <summary>TADIL J message count (label 3)</summary>
    TadilJMessageCountLabel3 = 30403u,
    /// <summary>TADIL J message count (label 4)</summary>
    TadilJMessageCountLabel4 = 30404u,
    /// <summary>TADIL J message count (label 5)</summary>
    TadilJMessageCountLabel5 = 30405u,
    /// <summary>TADIL J message count (label 6)</summary>
    TadilJMessageCountLabel6 = 30406u,
    /// <summary>TADIL J message count (label 7)</summary>
    TadilJMessageCountLabel7 = 30407u,
    /// <summary>TADIL J message count (label 8)</summary>
    TadilJMessageCountLabel8 = 30408u,
    /// <summary>TADIL J message count (label 9)</summary>
    TadilJMessageCountLabel9 = 30409u,
    /// <summary>TADIL J message count (label 10)</summary>
    TadilJMessageCountLabel10 = 30410u,
    /// <summary>TADIL J message count (label 11)</summary>
    TadilJMessageCountLabel11 = 30411u,
    /// <summary>TADIL J message count (label 12)</summary>
    TadilJMessageCountLabel12 = 30412u,
    /// <summary>TADIL J message count (label 13)</summary>
    TadilJMessageCountLabel13 = 30413u,
    /// <summary>TADIL J message count (label 14)</summary>
    TadilJMessageCountLabel14 = 30414u,
    /// <summary>TADIL J message count (label 15)</summary>
    TadilJMessageCountLabel15 = 30415u,
    /// <summary>TADIL J message count (label 16)</summary>
    TadilJMessageCountLabel16 = 30416u,
    /// <summary>TADIL J message count (label 17)</summary>
    TadilJMessageCountLabel17 = 30417u,
    /// <summary>TADIL J message count (label 18)</summary>
    TadilJMessageCountLabel18 = 30418u,
    /// <summary>TADIL J message count (label 19)</summary>
    TadilJMessageCountLabel19 = 30419u,
    /// <summary>TADIL J message count (label 20)</summary>
    TadilJMessageCountLabel20 = 30420u,
    /// <summary>TADIL J message count (label 21)</summary>
    TadilJMessageCountLabel21 = 30421u,
    /// <summary>TADIL J message count (label 22)</summary>
    TadilJMessageCountLabel22 = 30422u,
    /// <summary>TADIL J message count (label 23)</summary>
    TadilJMessageCountLabel23 = 30423u,
    /// <summary>TADIL J message count (label 24)</summary>
    TadilJMessageCountLabel24 = 30424u,
    /// <summary>TADIL J message count (label 25)</summary>
    TadilJMessageCountLabel25 = 30425u,
    /// <summary>TADIL J message count (label 26)</summary>
    TadilJMessageCountLabel26 = 30426u,
    /// <summary>TADIL J message count (label 27)</summary>
    TadilJMessageCountLabel27 = 30427u,
    /// <summary>TADIL J message count (label 28)</summary>
    TadilJMessageCountLabel28 = 30428u,
    /// <summary>TADIL J message count (label 29)</summary>
    TadilJMessageCountLabel29 = 30429u,
    /// <summary>TADIL J message count (label 30)</summary>
    TadilJMessageCountLabel30 = 30430u,
    /// <summary>TADIL J message count (label 31)</summary>
    TadilJMessageCountLabel31 = 30431u,
    /// <summary>Position</summary>
    Position = 31000u,
    /// <summary>Route (Waypoint) type</summary>
    RouteWaypointType = 31010u,
    /// <summary>MilGrid10</summary>
    MilGrid10 = 31100u,
    /// <summary>Geocentric Coordinates</summary>
    GeocentricCoordinates = 31200u,
    /// <summary>X</summary>
    X = 31210u,
    /// <summary>Y</summary>
    Y = 31220u,
    /// <summary>Z</summary>
    Z = 31230u,
    /// <summary>Latitude</summary>
    Latitude = 31300u,
    /// <summary>Longitude</summary>
    Longitude = 31400u,
    /// <summary>Line of Sight</summary>
    LineOfSight = 31500u,
    /// <summary>X</summary>
    X31510 = 31510u,
    /// <summary>Y</summary>
    Y31520 = 31520u,
    /// <summary>Z</summary>
    Z31530 = 31530u,
    /// <summary>Altitude</summary>
    Altitude = 31600u,
    /// <summary>Destination Latitude</summary>
    DestinationLatitude = 31700u,
    /// <summary>Destination Longitude</summary>
    DestinationLongitude = 31800u,
    /// <summary>Destination Altitude</summary>
    DestinationAltitude = 31900u,
    /// <summary>Orientation</summary>
    Orientation = 32000u,
    /// <summary>Hull Heading Angle</summary>
    HullHeadingAngle = 32100u,
    /// <summary>Hull Pitch Angle</summary>
    HullPitchAngle = 32200u,
    /// <summary>Roll Angle</summary>
    RollAngle = 32300u,
    /// <summary>X</summary>
    X32500 = 32500u,
    /// <summary>Y</summary>
    Y32600 = 32600u,
    /// <summary>Z</summary>
    Z32700 = 32700u,
    /// <summary>Appearance</summary>
    Appearance = 33000u,
    /// <summary>Ambient Lighting</summary>
    AmbientLighting = 33100u,
    /// <summary>Lights</summary>
    Lights = 33101u,
    /// <summary>Paint Scheme</summary>
    PaintScheme = 33200u,
    /// <summary>Smoke</summary>
    Smoke = 33300u,
    /// <summary>Trailing Effects</summary>
    TrailingEffects = 33400u,
    /// <summary>Flaming</summary>
    Flaming = 33500u,
    /// <summary>Marking</summary>
    Marking = 33600u,
    /// <summary>Mine Plows Attached</summary>
    MinePlowsAttached = 33710u,
    /// <summary>Mine Rollers Attached</summary>
    MineRollersAttached = 33720u,
    /// <summary>Tank Turret Azimuth</summary>
    TankTurretAzimuth = 33730u,
    /// <summary>Failures and Malfunctions</summary>
    FailuresAndMalfunctions = 34000u,
    /// <summary>Age</summary>
    Age = 34100u,
    /// <summary>Kilometers</summary>
    Kilometers = 34110u,
    /// <summary>Damage</summary>
    Damage = 35000u,
    /// <summary>Cause</summary>
    Cause = 35050u,
    /// <summary>Mobility Kill</summary>
    MobilityKill = 35100u,
    /// <summary>Fire-Power Kill</summary>
    FirePowerKill = 35200u,
    /// <summary>Personnel Casualties</summary>
    PersonnelCasualties = 35300u,
    /// <summary>Velocity</summary>
    Velocity = 36000u,
    /// <summary>X-velocity</summary>
    XVelocity = 36100u,
    /// <summary>Y-velocity</summary>
    YVelocity = 36200u,
    /// <summary>Z-velocity</summary>
    ZVelocity = 36300u,
    /// <summary>Speed</summary>
    Speed = 36400u,
    /// <summary>Acceleration</summary>
    Acceleration = 37000u,
    /// <summary>X-acceleration</summary>
    XAcceleration = 37100u,
    /// <summary>Y-acceleration</summary>
    YAcceleration = 37200u,
    /// <summary>Z-acceleration</summary>
    ZAcceleration = 37300u,
    /// <summary>Engine Status</summary>
    EngineStatus = 38100u,
    /// <summary>Primary Target Line (PTL)</summary>
    PrimaryTargetLinePtl = 39000u,
    /// <summary>Exercise</summary>
    Exercise = 40000u,
    /// <summary>Exercise State</summary>
    ExerciseState = 40010u,
    /// <summary>Restart/Refresh</summary>
    RestartRefresh = 40015u,
    /// <summary>AFATDS File Name</summary>
    AfatdsFileName = 40020u,
    /// <summary>Terrain Database</summary>
    TerrainDatabase = 41000u,
    /// <summary>Missions</summary>
    Missions = 42000u,
    /// <summary>Mission ID</summary>
    MissionId = 42100u,
    /// <summary>Mission Type</summary>
    MissionType = 42200u,
    /// <summary>Mission Request Time Stamp</summary>
    MissionRequestTimeStamp = 42300u,
    /// <summary>Exercise Description</summary>
    ExerciseDescription = 43000u,
    /// <summary>Name</summary>
    Name = 43100u,
    /// <summary>Entities</summary>
    Entities = 43200u,
    /// <summary>Version</summary>
    Version = 43300u,
    /// <summary>Guise Mode</summary>
    GuiseMode = 43410u,
    /// <summary>Simulation Application Active Status</summary>
    SimulationApplicationActiveStatus = 43420u,
    /// <summary>Simulation Application Role Record</summary>
    SimulationApplicationRoleRecord = 43430u,
    /// <summary>Simulation Application State</summary>
    SimulationApplicationState = 43440u,
    /// <summary>Visual Output Mode</summary>
    VisualOutputMode = 44000u,
    /// <summary>Simulation Manager Role</summary>
    SimulationManagerRole = 44100u,
    /// <summary>Simulation Manager Site ID</summary>
    SimulationManagerSiteId = 44110u,
    /// <summary>Simulation Manager Applic. ID</summary>
    SimulationManagerApplicId = 44120u,
    /// <summary>Simulation Manager Entity ID</summary>
    SimulationManagerEntityId = 44130u,
    /// <summary>Simulation Manager Active Status</summary>
    SimulationManagerActiveStatus = 44140u,
    /// <summary>After Active Review Role</summary>
    AfterActiveReviewRole = 44200u,
    /// <summary>After Active Review Site ID</summary>
    AfterActiveReviewSiteId = 44210u,
    /// <summary>After Active Applic. ID</summary>
    AfterActiveApplicId = 44220u,
    /// <summary>After Active Review Entity ID</summary>
    AfterActiveReviewEntityId = 44230u,
    /// <summary>After Active Review Active Status</summary>
    AfterActiveReviewActiveStatus = 44240u,
    /// <summary>Exercise Logger Role</summary>
    ExerciseLoggerRole = 44300u,
    /// <summary>Exercise Logger Site ID</summary>
    ExerciseLoggerSiteId = 44310u,
    /// <summary>Exercise Logger Applic. ID</summary>
    ExerciseLoggerApplicId = 44320u,
    /// <summary>Exercise Entity ID</summary>
    ExerciseEntityId = 44330u,
    /// <summary>Exercise Logger Active Status</summary>
    ExerciseLoggerActiveStatus = 44340u,
    /// <summary>Synthetic Environment Manager Role</summary>
    SyntheticEnvironmentManagerRole = 44400u,
    /// <summary>Synthetic Environment Manager Site ID</summary>
    SyntheticEnvironmentManagerSiteId = 44410u,
    /// <summary>Synthetic Environment Manager Applic. ID</summary>
    SyntheticEnvironmentManagerApplicId = 44420u,
    /// <summary>Synthetic Environment Manager Entity ID</summary>
    SyntheticEnvironmentManagerEntityId = 44430u,
    /// <summary>Synthetic Environment Manager Active Status</summary>
    SyntheticEnvironmentManagerActiveStatus = 44440u,
    /// <summary>SIMNET-DIS Translator Role</summary>
    SimnetDisTranslatorRole = 44500u,
    /// <summary>SIMNET-DIS Translator Site ID</summary>
    SimnetDisTranslatorSiteId = 44510u,
    /// <summary>SIMNET-DIS Translator Applic. ID</summary>
    SimnetDisTranslatorApplicId = 44520u,
    /// <summary>SIMNET-DIS Translator Entity ID</summary>
    SimnetDisTranslatorEntityId = 44530u,
    /// <summary>SIMNET-DIS Translator Active Status</summary>
    SimnetDisTranslatorActiveStatus = 44540u,
    /// <summary>Application Rate</summary>
    ApplicationRate = 45000u,
    /// <summary>Application Time</summary>
    ApplicationTime = 45005u,
    /// <summary>Application Timestep</summary>
    ApplicationTimestep = 45010u,
    /// <summary>Feedback Time</summary>
    FeedbackTime = 45020u,
    /// <summary>Simulation Rate</summary>
    SimulationRate = 45030u,
    /// <summary>Simulation Time</summary>
    SimulationTime = 45040u,
    /// <summary>Simulation Timestep</summary>
    SimulationTimestep = 45050u,
    /// <summary>Time Interval</summary>
    TimeInterval = 45060u,
    /// <summary>Time Latency</summary>
    TimeLatency = 45070u,
    /// <summary>Time Scheme</summary>
    TimeScheme = 45080u,
    /// <summary>Exercise Elapsed Time</summary>
    ExerciseElapsedTime = 46000u,
    /// <summary>Elapsed Time</summary>
    ElapsedTime = 46010u,
    /// <summary>Environment</summary>
    Environment = 50000u,
    /// <summary>Scenario Date</summary>
    ScenarioDate = 50103u,
    /// <summary>Time &amp; Date Valid</summary>
    TimeDateValid = 50106u,
    /// <summary>Scenario Time</summary>
    ScenarioTime = 50118u,
    /// <summary>Snow Enable/Disable</summary>
    SnowEnableDisable = 50120u,
    /// <summary>Weather Attributes Request</summary>
    WeatherAttributesRequest = 50124u,
    /// <summary>MET Heartbeat Message</summary>
    MetHeartbeatMessage = 50126u,
    /// <summary>Contrails Enable</summary>
    ContrailsEnable = 50600u,
    /// <summary>Contrail Altitudes</summary>
    ContrailAltitudes = 50700u,
    /// <summary>Weather</summary>
    Weather = 51000u,
    /// <summary>Weather Condition</summary>
    WeatherCondition = 51010u,
    /// <summary>Thermal Condition</summary>
    ThermalCondition = 51100u,
    /// <summary>Thermal Visibility</summary>
    ThermalVisibility = 51110u,
    /// <summary>Thermal Visibility</summary>
    ThermalVisibility51111 = 51111u,
    /// <summary>Time</summary>
    Time = 52000u,
    /// <summary>Time</summary>
    Time52001 = 52001u,
    /// <summary>Time of Day, Discrete</summary>
    TimeOfDayDiscrete = 52100u,
    /// <summary>Time of Day, Continuous</summary>
    TimeOfDayContinuous = 52200u,
    /// <summary>Time Mode</summary>
    TimeMode = 52300u,
    /// <summary>Time Scene</summary>
    TimeScene = 52305u,
    /// <summary>Current Hour</summary>
    CurrentHour = 52310u,
    /// <summary>Current Minute</summary>
    CurrentMinute = 52320u,
    /// <summary>Current Second</summary>
    CurrentSecond = 52330u,
    /// <summary>Azimuth</summary>
    Azimuth = 52340u,
    /// <summary>Maximum Elevation</summary>
    MaximumElevation = 52350u,
    /// <summary>Time Zone</summary>
    TimeZone = 52360u,
    /// <summary>Time Rate</summary>
    TimeRate = 52370u,
    /// <summary>The number of simulation seconds since the start of the exercise (simulation time)</summary>
    TheNumberOfSimulationSecondsSinceTheStartOfTheExerciseSimulationTime = 52380u,
    /// <summary>Time Sunrise Enabled</summary>
    TimeSunriseEnabled = 52400u,
    /// <summary>Sunrise Hour</summary>
    SunriseHour = 52410u,
    /// <summary>Sunrise Minute</summary>
    SunriseMinute = 52420u,
    /// <summary>Sunrise Second</summary>
    SunriseSecond = 52430u,
    /// <summary>Sunrise Azimuth</summary>
    SunriseAzimuth = 52440u,
    /// <summary>Time Sunset Enabled</summary>
    TimeSunsetEnabled = 52500u,
    /// <summary>Sunset Hour</summary>
    SunsetHour = 52510u,
    /// <summary>Sunset Hour</summary>
    SunsetHour52511 = 52511u,
    /// <summary>Sunset Minute</summary>
    SunsetMinute = 52520u,
    /// <summary>Sunset Second</summary>
    SunsetSecond = 52530u,
    /// <summary>Date</summary>
    Date = 52600u,
    /// <summary>Date (European)</summary>
    DateEuropean = 52601u,
    /// <summary>Date (US)</summary>
    DateUs = 52602u,
    /// <summary>Month</summary>
    Month = 52610u,
    /// <summary>Day</summary>
    Day = 52620u,
    /// <summary>Year</summary>
    Year = 52630u,
    /// <summary>Clouds</summary>
    Clouds = 53000u,
    /// <summary>Cloud Layer Enable</summary>
    CloudLayerEnable = 53050u,
    /// <summary>Cloud Layer Selection</summary>
    CloudLayerSelection = 53060u,
    /// <summary>Visibility</summary>
    Visibility = 53100u,
    /// <summary>Base Altitude</summary>
    BaseAltitude = 53200u,
    /// <summary>Base Altitude</summary>
    BaseAltitude53250 = 53250u,
    /// <summary>Ceiling</summary>
    Ceiling = 53300u,
    /// <summary>Ceiling</summary>
    Ceiling53350 = 53350u,
    /// <summary>Characteristics</summary>
    Characteristics = 53400u,
    /// <summary>Concentration Length</summary>
    ConcentrationLength = 53410u,
    /// <summary>Transmittance</summary>
    Transmittance = 53420u,
    /// <summary>Radiance</summary>
    Radiance = 53430u,
    /// <summary>Precipitation</summary>
    Precipitation = 54000u,
    /// <summary>Rain</summary>
    Rain = 54100u,
    /// <summary>Fog</summary>
    Fog = 55000u,
    /// <summary>Visibility</summary>
    Visibility55100 = 55100u,
    /// <summary>Visibility</summary>
    Visibility55101 = 55101u,
    /// <summary>Visibility</summary>
    Visibility55105 = 55105u,
    /// <summary>Density</summary>
    Density = 55200u,
    /// <summary>Base</summary>
    Base = 55300u,
    /// <summary>View Layer from above.</summary>
    ViewLayerFromAbove = 55401u,
    /// <summary>Transition Range</summary>
    TransitionRange = 55410u,
    /// <summary>Bottom</summary>
    Bottom = 55420u,
    /// <summary>Bottom</summary>
    Bottom55425 = 55425u,
    /// <summary>Ceiling</summary>
    Ceiling55430 = 55430u,
    /// <summary>Ceiling</summary>
    Ceiling55435 = 55435u,
    /// <summary>Heavenly Bodies</summary>
    HeavenlyBodies = 56000u,
    /// <summary>Sun</summary>
    Sun = 56100u,
    /// <summary>Sun Visible</summary>
    SunVisible = 56105u,
    /// <summary>Position</summary>
    Position56110 = 56110u,
    /// <summary>Sun Position Elevation, Degrees</summary>
    SunPositionElevationDegrees = 56111u,
    /// <summary>Position Azimuth</summary>
    PositionAzimuth = 56120u,
    /// <summary>Sun Position Azimuth, Degrees</summary>
    SunPositionAzimuthDegrees = 56121u,
    /// <summary>Position Elevation</summary>
    PositionElevation = 56130u,
    /// <summary>Position Intensity</summary>
    PositionIntensity = 56140u,
    /// <summary>Moon</summary>
    Moon = 56200u,
    /// <summary>Moon Visible</summary>
    MoonVisible = 56205u,
    /// <summary>Position</summary>
    Position56210 = 56210u,
    /// <summary>Position Azimuth</summary>
    PositionAzimuth56220 = 56220u,
    /// <summary>Moon Position Azimuth, Degrees</summary>
    MoonPositionAzimuthDegrees = 56221u,
    /// <summary>Position Elevation</summary>
    PositionElevation56230 = 56230u,
    /// <summary>Moon Position Elevation, Degrees</summary>
    MoonPositionElevationDegrees = 56231u,
    /// <summary>Position Intensity</summary>
    PositionIntensity56240 = 56240u,
    /// <summary>Horizon</summary>
    Horizon = 56310u,
    /// <summary>Horizon Azimuth</summary>
    HorizonAzimuth = 56320u,
    /// <summary>Horizon Elevation</summary>
    HorizonElevation = 56330u,
    /// <summary>Horizon Heading</summary>
    HorizonHeading = 56340u,
    /// <summary>Horizon Intensity</summary>
    HorizonIntensity = 56350u,
    /// <summary>Humidity</summary>
    Humidity = 57200u,
    /// <summary>Visibility</summary>
    Visibility57300 = 57300u,
    /// <summary>Winds</summary>
    Winds = 57400u,
    /// <summary>Speed</summary>
    Speed57410 = 57410u,
    /// <summary>Wind Speed, Knots</summary>
    WindSpeedKnots = 57411u,
    /// <summary>Wind Direction</summary>
    WindDirection = 57420u,
    /// <summary>Wind Direction, Degrees</summary>
    WindDirectionDegrees = 57421u,
    /// <summary>Rainsoak</summary>
    Rainsoak = 57500u,
    /// <summary>Tide Speed</summary>
    TideSpeed = 57610u,
    /// <summary>Tide Speed, Knots</summary>
    TideSpeedKnots = 57611u,
    /// <summary>Tide Direction</summary>
    TideDirection = 57620u,
    /// <summary>Tide Direction, Degrees</summary>
    TideDirectionDegrees = 57621u,
    /// <summary>Haze</summary>
    Haze = 58000u,
    /// <summary>Visibility</summary>
    Visibility58100 = 58100u,
    /// <summary>Visibility</summary>
    Visibility58105 = 58105u,
    /// <summary>Density</summary>
    Density58200 = 58200u,
    /// <summary>Ceiling</summary>
    Ceiling58430 = 58430u,
    /// <summary>Ceiling</summary>
    Ceiling58435 = 58435u,
    /// <summary>Contaminants and Obscurants</summary>
    ContaminantsAndObscurants = 59000u,
    /// <summary>Contaminant/Obscurant Type</summary>
    ContaminantObscurantType = 59100u,
    /// <summary>Persistence</summary>
    Persistence = 59110u,
    /// <summary>Chemical Dosage</summary>
    ChemicalDosage = 59115u,
    /// <summary>Chemical Air Concentration</summary>
    ChemicalAirConcentration = 59120u,
    /// <summary>Chemical Ground Deposition</summary>
    ChemicalGroundDeposition = 59125u,
    /// <summary>Chemical Maximum Ground Deposition</summary>
    ChemicalMaximumGroundDeposition = 59130u,
    /// <summary>Chemical Dosage Threshold</summary>
    ChemicalDosageThreshold = 59135u,
    /// <summary>Biological Dosage</summary>
    BiologicalDosage = 59140u,
    /// <summary>Biological Air Concentration</summary>
    BiologicalAirConcentration = 59145u,
    /// <summary>Biological Dosage Threshold</summary>
    BiologicalDosageThreshold = 59150u,
    /// <summary>Biological Binned Particle Count</summary>
    BiologicalBinnedParticleCount = 59155u,
    /// <summary>Radiological Dosage</summary>
    RadiologicalDosage = 59160u,
    /// <summary>Communications</summary>
    Communications = 60000u,
    /// <summary>Fire Bottle Reload</summary>
    FireBottleReload = 61005u,
    /// <summary>Channel Type</summary>
    ChannelType = 61100u,
    /// <summary>Channel Type</summary>
    ChannelType61101 = 61101u,
    /// <summary>Channel Identification</summary>
    ChannelIdentification = 61200u,
    /// <summary>Alpha Identification</summary>
    AlphaIdentification = 61300u,
    /// <summary>Radio Identification</summary>
    RadioIdentification = 61400u,
    /// <summary>Land Line Identification</summary>
    LandLineIdentification = 61500u,
    /// <summary>Intercom Identification</summary>
    IntercomIdentification = 61600u,
    /// <summary>Group Network Channel Number</summary>
    GroupNetworkChannelNumber = 61700u,
    /// <summary>Radio Communications Status</summary>
    RadioCommunicationsStatus = 62100u,
    /// <summary>Boom Interphone</summary>
    BoomInterphone = 62101u,
    /// <summary>Stationary Radio Transmitters Default Time</summary>
    StationaryRadioTransmittersDefaultTime = 62200u,
    /// <summary>Moving Radio Transmitters Default Time</summary>
    MovingRadioTransmittersDefaultTime = 62300u,
    /// <summary>Stationary Radio Signals Default Time</summary>
    StationaryRadioSignalsDefaultTime = 62400u,
    /// <summary>Moving Radio Signal Default Time</summary>
    MovingRadioSignalDefaultTime = 62500u,
    /// <summary>Radio Initialization Transec Security Key</summary>
    RadioInitializationTransecSecurityKey = 63101u,
    /// <summary>Radio Initialization Internal Noise Level</summary>
    RadioInitializationInternalNoiseLevel = 63102u,
    /// <summary>Radio Initialization Squelch Threshold</summary>
    RadioInitializationSquelchThreshold = 63103u,
    /// <summary>Radio Initialization Antenna Location</summary>
    RadioInitializationAntennaLocation = 63104u,
    /// <summary>Radio Initialization Antenna Pattern Type</summary>
    RadioInitializationAntennaPatternType = 63105u,
    /// <summary>Radio Initialization Antenna Pattern Length</summary>
    RadioInitializationAntennaPatternLength = 63106u,
    /// <summary>Radio Initialization Beam Definition</summary>
    RadioInitializationBeamDefinition = 63107u,
    /// <summary>Radio Initialization Transmit Heartbeat Time</summary>
    RadioInitializationTransmitHeartbeatTime = 63108u,
    /// <summary>Radio Initialization Transmit Distance Threshold Variable Record</summary>
    RadioInitializationTransmitDistanceThresholdVariableRecord = 63109u,
    /// <summary>Radio Channel Initialization Lockout ID</summary>
    RadioChannelInitializationLockoutId = 63110u,
    /// <summary>Radio Channel Initialization Hopset ID</summary>
    RadioChannelInitializationHopsetId = 63111u,
    /// <summary>Radio Channel Initialization Preset Frequency</summary>
    RadioChannelInitializationPresetFrequency = 63112u,
    /// <summary>Radio Channel Initialization Frequency Sync Time</summary>
    RadioChannelInitializationFrequencySyncTime = 63113u,
    /// <summary>Radio Channel Initialization Comsec Key</summary>
    RadioChannelInitializationComsecKey = 63114u,
    /// <summary>Radio Channel Initialization Alpha</summary>
    RadioChannelInitializationAlpha = 63115u,
    /// <summary>Algorithm Parameters</summary>
    AlgorithmParameters = 70000u,
    /// <summary>Dead Reckoning Algorithm (DRA)</summary>
    DeadReckoningAlgorithmDra = 71000u,
    /// <summary>DRA Location Threshold</summary>
    DraLocationThreshold = 71100u,
    /// <summary>DRA Orientation Threshold</summary>
    DraOrientationThreshold = 71200u,
    /// <summary>DRA Time Threshold</summary>
    DraTimeThreshold = 71300u,
    /// <summary>Simulation Management Parameters</summary>
    SimulationManagementParameters = 72000u,
    /// <summary>Checkpoint Interval</summary>
    CheckpointInterval = 72100u,
    /// <summary>Transmitter Time Threshold</summary>
    TransmitterTimeThreshold = 72600u,
    /// <summary>Receiver Time Threshold</summary>
    ReceiverTimeThreshold = 72700u,
    /// <summary>Interoperability Mode</summary>
    InteroperabilityMode = 73000u,
    /// <summary>SIMNET Data Collection</summary>
    SimnetDataCollection = 74000u,
    /// <summary>Event ID</summary>
    EventId = 75000u,
    /// <summary>Source Site ID</summary>
    SourceSiteId = 75100u,
    /// <summary>Source Host ID</summary>
    SourceHostId = 75200u,
    /// <summary>Articulated Parts</summary>
    ArticulatedParts = 90000u,
    /// <summary>Part ID</summary>
    PartId = 90050u,
    /// <summary>Index</summary>
    Index = 90070u,
    /// <summary>Position</summary>
    Position90100 = 90100u,
    /// <summary>Position Rate</summary>
    PositionRate = 90200u,
    /// <summary>Extension</summary>
    Extension = 90300u,
    /// <summary>Extension Rate</summary>
    ExtensionRate = 90400u,
    /// <summary>X</summary>
    X90500 = 90500u,
    /// <summary>X-rate</summary>
    XRate = 90600u,
    /// <summary>Y</summary>
    Y90700 = 90700u,
    /// <summary>Y-rate</summary>
    YRate = 90800u,
    /// <summary>Z</summary>
    Z90900 = 90900u,
    /// <summary>Z-rate</summary>
    ZRate = 91000u,
    /// <summary>Azimuth</summary>
    Azimuth91100 = 91100u,
    /// <summary>Azimuth Rate</summary>
    AzimuthRate = 91200u,
    /// <summary>Elevation</summary>
    Elevation = 91300u,
    /// <summary>Elevation Rate</summary>
    ElevationRate = 91400u,
    /// <summary>Rotation</summary>
    Rotation = 91500u,
    /// <summary>Rotation Rate</summary>
    RotationRate = 91600u,
    /// <summary>DRA Angular X-Velocity</summary>
    DraAngularXVelocity = 100001u,
    /// <summary>DRA Angular Y-Velocity</summary>
    DraAngularYVelocity = 100002u,
    /// <summary>DRA Angular Z-Velocity</summary>
    DraAngularZVelocity = 100003u,
    /// <summary>Appearance, Trailing Effects</summary>
    AppearanceTrailingEffects = 100004u,
    /// <summary>Appearance, Hatch</summary>
    AppearanceHatch = 100005u,
    /// <summary>Appearance, Character Set</summary>
    AppearanceCharacterSet = 100008u,
    /// <summary>Capability, Ammunition Supplier</summary>
    CapabilityAmmunitionSupplier = 100010u,
    /// <summary>Capability, Miscellaneous Supplier</summary>
    CapabilityMiscellaneousSupplier = 100011u,
    /// <summary>Capability, Repair Provider</summary>
    CapabilityRepairProvider = 100012u,
    /// <summary>Articulation Parameter</summary>
    ArticulationParameter = 100014u,
    /// <summary>Articulation Parameter Type</summary>
    ArticulationParameterType = 100047u,
    /// <summary>Articulation Parameter Value</summary>
    ArticulationParameterValue = 100048u,
    /// <summary>Time of Day-Scene</summary>
    TimeOfDayScene = 100058u,
    /// <summary>Latitude-North (Location of weather cell)</summary>
    LatitudeNorthLocationOfWeatherCell = 100061u,
    /// <summary>Longitude-East (Location of weather cell)</summary>
    LongitudeEastLocationOfWeatherCell = 100063u,
    /// <summary>Tactical Driver Status</summary>
    TacticalDriverStatus = 100068u,
    /// <summary>Sonar System Status</summary>
    SonarSystemStatus = 100100u,
    /// <summary>Accomplished accept</summary>
    AccomplishedAccept = 100160u,
    /// <summary>Upper latitude</summary>
    UpperLatitude = 100161u,
    /// <summary>Latitude-South (Location of weather cell)</summary>
    LatitudeSouthLocationOfWeatherCell = 100162u,
    /// <summary>Western longitude</summary>
    WesternLongitude = 100163u,
    /// <summary>Longitude-West (location of weather cell)</summary>
    LongitudeWestLocationOfWeatherCell = 100164u,
    /// <summary>CD ROM Number (Disk ID for terrain)</summary>
    CdRomNumberDiskIdForTerrain = 100165u,
    /// <summary>DTED disk ID</summary>
    DtedDiskId = 100166u,
    /// <summary>Altitude</summary>
    Altitude100167 = 100167u,
    /// <summary>Tactical System Status</summary>
    TacticalSystemStatus = 100169u,
    /// <summary>JTIDS Status</summary>
    JtidsStatus = 100170u,
    /// <summary>TADIL-J Status</summary>
    TadilJStatus = 100171u,
    /// <summary>DSDD Status</summary>
    DsddStatus = 100172u,
    /// <summary>Weapon System Status</summary>
    WeaponSystemStatus = 100200u,
    /// <summary>Subsystem status</summary>
    SubsystemStatus = 100205u,
    /// <summary>Number of interceptors fired</summary>
    NumberOfInterceptorsFired = 100206u,
    /// <summary>Number of interceptor detonations</summary>
    NumberOfInterceptorDetonations = 100207u,
    /// <summary>Number of message buffers dropped</summary>
    NumberOfMessageBuffersDropped = 100208u,
    /// <summary>Satellite sensor background (year, day)</summary>
    SatelliteSensorBackgroundYearDay = 100213u,
    /// <summary>Satellite sensor background (hour, minute)</summary>
    SatelliteSensorBackgroundHourMinute = 100214u,
    /// <summary>Script Number</summary>
    ScriptNumber = 100218u,
    /// <summary>Entity/Track/Update Data</summary>
    EntityTrackUpdateData = 100300u,
    /// <summary>Local/Force Training</summary>
    LocalForceTraining = 100400u,
    /// <summary>Entity/Track Identity Data</summary>
    EntityTrackIdentityData = 100500u,
    /// <summary>Entity for Track Event</summary>
    EntityForTrackEvent = 100510u,
    /// <summary>IFF (Friend-Foe) status</summary>
    IffFriendFoeStatus = 100520u,
    /// <summary>Engagement Data</summary>
    EngagementData = 100600u,
    /// <summary>Target Latitude</summary>
    TargetLatitude = 100610u,
    /// <summary>Target Longitude</summary>
    TargetLongitude = 100620u,
    /// <summary>Area of Interest (Ground Impact Circle) Center Latitude</summary>
    AreaOfInterestGroundImpactCircleCenterLatitude = 100631u,
    /// <summary>Area of Interest (Ground Impact Circle) Center Longitude</summary>
    AreaOfInterestGroundImpactCircleCenterLongitude = 100632u,
    /// <summary>Area of Interest (Ground Impact Circle) Radius</summary>
    AreaOfInterestGroundImpactCircleRadius = 100633u,
    /// <summary>Area of Interest Type</summary>
    AreaOfInterestType = 100634u,
    /// <summary>Target Aggregate ID</summary>
    TargetAggregateId = 100640u,
    /// <summary>GIC Identification Number</summary>
    GicIdentificationNumber = 100650u,
    /// <summary>Estimated Time of Flight to TBM Impact</summary>
    EstimatedTimeOfFlightToTbmImpact = 100660u,
    /// <summary>Estimated Intercept Time</summary>
    EstimatedInterceptTime = 100661u,
    /// <summary>Estimated Time of Flight to Next Waypoint</summary>
    EstimatedTimeOfFlightToNextWaypoint = 100662u,
    /// <summary>Entity/Track Equipment Data</summary>
    EntityTrackEquipmentData = 100700u,
    /// <summary>Emission/EW Data</summary>
    EmissionEwData = 100800u,
    /// <summary>Appearance Data</summary>
    AppearanceData = 100900u,
    /// <summary>Command/Order Data</summary>
    CommandOrderData = 101000u,
    /// <summary>Environmental Data</summary>
    EnvironmentalData = 101100u,
    /// <summary>Significant Event Data</summary>
    SignificantEventData = 101200u,
    /// <summary>Operator Action Data</summary>
    OperatorActionData = 101300u,
    /// <summary>ADA Engagement Mode</summary>
    AdaEngagementMode = 101310u,
    /// <summary>ADA Shooting Status</summary>
    AdaShootingStatus = 101320u,
    /// <summary>ADA Mode</summary>
    AdaMode = 101321u,
    /// <summary>ADA Radar Status</summary>
    AdaRadarStatus = 101330u,
    /// <summary>Shoot Command</summary>
    ShootCommand = 101340u,
    /// <summary>ADA Weapon Status</summary>
    AdaWeaponStatus = 101350u,
    /// <summary>ADA Firing Disciple</summary>
    AdaFiringDisciple = 101360u,
    /// <summary>Order Status</summary>
    OrderStatus = 101370u,
    /// <summary>Time Synchronization</summary>
    TimeSynchronization = 101400u,
    /// <summary>Tomahawk Data</summary>
    TomahawkData = 101500u,
    /// <summary>Number of Detonations</summary>
    NumberOfDetonations = 102100u,
    /// <summary>Number of Intercepts</summary>
    NumberOfIntercepts = 102200u,
    /// <summary>OBT Control MT-201</summary>
    ObtControlMt201 = 200201u,
    /// <summary>Sensor Data MT-202</summary>
    SensorDataMt202 = 200202u,
    /// <summary>Environmental Data MT-203</summary>
    EnvironmentalDataMt203 = 200203u,
    /// <summary>Ownship Data MT-204</summary>
    OwnshipDataMt204 = 200204u,
    /// <summary>Acoustic Contact Data MT-205</summary>
    AcousticContactDataMt205 = 200205u,
    /// <summary>Sonobuoy Data MT-207</summary>
    SonobuoyDataMt207 = 200207u,
    /// <summary>Sonobuoy Contact Data MT-210</summary>
    SonobuoyContactDataMt210 = 200210u,
    /// <summary>Helo Control MT-211</summary>
    HeloControlMt211 = 200211u,
    /// <summary>ESM Control Data</summary>
    EsmControlData = 200213u,
    /// <summary>ESM Contact Data MT-214</summary>
    EsmContactDataMt214 = 200214u,
    /// <summary>ESM Emitter Data MT-215</summary>
    EsmEmitterDataMt215 = 200215u,
    /// <summary>Weapon Definition Data MT-217</summary>
    WeaponDefinitionDataMt217 = 200216u,
    /// <summary>Weapon Preset Data MT-217</summary>
    WeaponPresetDataMt217 = 200217u,
    /// <summary>OBT Control MT-301</summary>
    ObtControlMt301 = 200301u,
    /// <summary>Sensor Data MT-302</summary>
    SensorDataMt302 = 200302u,
    /// <summary>Environmental Data MT-303m</summary>
    EnvironmentalDataMt303m = 200303u,
    /// <summary>Ownship Data MT-304</summary>
    OwnshipDataMt304 = 200304u,
    /// <summary>Acoustic Contact Data MT-305</summary>
    AcousticContactDataMt305 = 200305u,
    /// <summary>Sonobuoy Data MT-307</summary>
    SonobuoyDataMt307 = 200307u,
    /// <summary>Sonobuoy Contact Data MT-310</summary>
    SonobuoyContactDataMt310 = 200310u,
    /// <summary>Helo Scenario / Equipment Status</summary>
    HeloScenarioEquipmentStatus = 200311u,
    /// <summary>ESM Control Data MT-313</summary>
    EsmControlDataMt313 = 200313u,
    /// <summary>ESM Contact Data MT-314</summary>
    EsmContactDataMt314 = 200314u,
    /// <summary>ESM Emitter Data MT-315</summary>
    EsmEmitterDataMt315 = 200315u,
    /// <summary>Weapon Definition Data MT-316</summary>
    WeaponDefinitionDataMt316 = 200316u,
    /// <summary>Weapon Preset Data MT-317</summary>
    WeaponPresetDataMt317 = 200317u,
    /// <summary>Pairing/Association (eMT-56)</summary>
    PairingAssociationEMT56 = 200400u,
    /// <summary>Pointer (eMT-57)</summary>
    PointerEMT57 = 200401u,
    /// <summary>Reporting Responsibility (eMT-58)</summary>
    ReportingResponsibilityEMT58 = 200402u,
    /// <summary>Track Number (eMT-59)</summary>
    TrackNumberEMT59 = 200403u,
    /// <summary>ID for Link-11 Reporting (eMT-60)</summary>
    IdForLink11ReportingEMT60 = 200404u,
    /// <summary>Remote Track (eMT-62)</summary>
    RemoteTrackEMT62 = 200405u,
    /// <summary>Link-11 Error Rate (eMT-63)</summary>
    Link11ErrorRateEMT63 = 200406u,
    /// <summary>Track Quality (eMT-64)</summary>
    TrackQualityEMT64 = 200407u,
    /// <summary>Gridlock (eMT-65)</summary>
    GridlockEMT65 = 200408u,
    /// <summary>Kill (eMT-66)</summary>
    KillEMT66 = 200409u,
    /// <summary>Track ID Change / Resolution (eMT-68)</summary>
    TrackIdChangeResolutionEMT68 = 200410u,
    /// <summary>Weapons Status (eMT-69)</summary>
    WeaponsStatusEMT69 = 200411u,
    /// <summary>Link-11 Operator (eMT-70)</summary>
    Link11OperatorEMT70 = 200412u,
    /// <summary>Force Training Transmit (eMT-71)</summary>
    ForceTrainingTransmitEMT71 = 200413u,
    /// <summary>Force Training Receive (eMT-72)</summary>
    ForceTrainingReceiveEMT72 = 200414u,
    /// <summary>Interceptor Amplification (eMT-75)</summary>
    InterceptorAmplificationEMT75 = 200415u,
    /// <summary>Consumables (eMT-78)</summary>
    ConsumablesEMT78 = 200416u,
    /// <summary>Link-11 Local Track Quality (eMT-95)</summary>
    Link11LocalTrackQualityEMT95 = 200417u,
    /// <summary>DLRP (eMT-19)</summary>
    DlrpEMT19 = 200418u,
    /// <summary>Force Order (eMT-52)</summary>
    ForceOrderEMT52 = 200419u,
    /// <summary>Wilco / Cantco (eMT-53)</summary>
    WilcoCantcoEMT53 = 200420u,
    /// <summary>EMC Bearing (eMT-54)</summary>
    EmcBearingEMT54 = 200421u,
    /// <summary>Change Track Eligibility (eMT-55)</summary>
    ChangeTrackEligibilityEMT55 = 200422u,
    /// <summary>Land Mass Reference Point</summary>
    LandMassReferencePoint = 200423u,
    /// <summary>System Reference Point</summary>
    SystemReferencePoint = 200424u,
    /// <summary>PU Amplification</summary>
    PuAmplification = 200425u,
    /// <summary>Set/Drift</summary>
    SetDrift = 200426u,
    /// <summary>Begin Initialization (MT-1)</summary>
    BeginInitializationMt1 = 200427u,
    /// <summary>Status and Control (MT-3)</summary>
    StatusAndControlMt3 = 200428u,
    /// <summary>Scintillation Change (MT-39)</summary>
    ScintillationChangeMt39 = 200429u,
    /// <summary>Link 11 ID Control (MT-61)</summary>
    Link11IdControlMt61 = 200430u,
    /// <summary>PU Guard List</summary>
    PuGuardList = 200431u,
    /// <summary>Winds Aloft (MT-14)</summary>
    WindsAloftMt14 = 200432u,
    /// <summary>Surface Winds (MT-15)</summary>
    SurfaceWindsMt15 = 200433u,
    /// <summary>Sea State (MT-17)</summary>
    SeaStateMt17 = 200434u,
    /// <summary>Magnetic Variation (MT-37)</summary>
    MagneticVariationMt37 = 200435u,
    /// <summary>Track Eligibility (MT-29)</summary>
    TrackEligibilityMt29 = 200436u,
    /// <summary>Training Track Notification</summary>
    TrainingTrackNotification = 200437u,
    /// <summary>Tacan Data (MT-32)</summary>
    TacanDataMt32 = 200501u,
    /// <summary>Interceptor Amplification (MT-75)</summary>
    InterceptorAmplificationMt75 = 200502u,
    /// <summary>Tacan Assignment (MT-76)</summary>
    TacanAssignmentMt76 = 200503u,
    /// <summary>Autopilot Status (MT-77)</summary>
    AutopilotStatusMt77 = 200504u,
    /// <summary>Consumables (MT-78)</summary>
    ConsumablesMt78 = 200505u,
    /// <summary>Downlink (MT-79)</summary>
    DownlinkMt79 = 200506u,
    /// <summary>TIN Report (MT-80)</summary>
    TinReportMt80 = 200507u,
    /// <summary>Special Point Control (MT-81)</summary>
    SpecialPointControlMt81 = 200508u,
    /// <summary>Control Discretes (MT-82)</summary>
    ControlDiscretesMt82 = 200509u,
    /// <summary>Request Target Discretes(MT-83)</summary>
    RequestTargetDiscretesMt83 = 200510u,
    /// <summary>Target Discretes (MT-84)</summary>
    TargetDiscretesMt84 = 200511u,
    /// <summary>Reply Discretes (MT-85)</summary>
    ReplyDiscretesMt85 = 200512u,
    /// <summary>Command Maneuvers (MT-86)</summary>
    CommandManeuversMt86 = 200513u,
    /// <summary>Target Data (MT-87)</summary>
    TargetDataMt87 = 200514u,
    /// <summary>Target Pointer (MT-88)</summary>
    TargetPointerMt88 = 200515u,
    /// <summary>Intercept Data (MT-89)</summary>
    InterceptDataMt89 = 200516u,
    /// <summary>Decrement Missile Inventory (MT-90)</summary>
    DecrementMissileInventoryMt90 = 200517u,
    /// <summary>Link-4A Alert (MT-91)</summary>
    Link4aAlertMt91 = 200518u,
    /// <summary>Strike Control (MT-92)</summary>
    StrikeControlMt92 = 200519u,
    /// <summary>Speed Change (MT-25)</summary>
    SpeedChangeMt25 = 200521u,
    /// <summary>Course Change (MT-26)</summary>
    CourseChangeMt26 = 200522u,
    /// <summary>Altitude Change (MT-27)</summary>
    AltitudeChangeMt27 = 200523u,
    /// <summary>ACLS AN/SPN-46 Status</summary>
    AclsAnSpn46Status = 200524u,
    /// <summary>ACLS Aircraft Report</summary>
    AclsAircraftReport = 200525u,
    /// <summary>SPS-67 Radar Operator Functions</summary>
    Sps67RadarOperatorFunctions = 200600u,
    /// <summary>SPS-55 Radar Operator Functions</summary>
    Sps55RadarOperatorFunctions = 200601u,
    /// <summary>SPQ-9A Radar Operator Functions</summary>
    Spq9aRadarOperatorFunctions = 200602u,
    /// <summary>SPS-49 Radar Operator Functions</summary>
    Sps49RadarOperatorFunctions = 200603u,
    /// <summary>MK-23 Radar Operator Functions</summary>
    Mk23RadarOperatorFunctions = 200604u,
    /// <summary>SPS-48 Radar Operator Functions</summary>
    Sps48RadarOperatorFunctions = 200605u,
    /// <summary>SPS-40 Radar Operator Functions</summary>
    Sps40RadarOperatorFunctions = 200606u,
    /// <summary>MK-95 Radar Operator Functions</summary>
    Mk95RadarOperatorFunctions = 200607u,
    /// <summary>Kill/No Kill</summary>
    KillNoKill = 200608u,
    /// <summary>CMT pc</summary>
    CmtPc = 200609u,
    /// <summary>CMC4AirGlobalData</summary>
    CMC4AirGlobalData = 200610u,
    /// <summary>CMC4GlobalData</summary>
    CMC4GlobalData = 200611u,
    /// <summary>LINKSIM_COMMENT_PDU</summary>
    LinksimCommentPdu = 200612u,
    /// <summary>NSST Ownship Control</summary>
    NsstOwnshipControl = 200613u,
    /// <summary>Other</summary>
    Other = 240000u,
    /// <summary>Mass Of The Vehicle</summary>
    MassOfTheVehicle = 240001u,
    /// <summary>Force ID</summary>
    ForceId240002 = 240002u,
    /// <summary>Entity Type Kind</summary>
    EntityTypeKind = 240003u,
    /// <summary>Entity Type Domain</summary>
    EntityTypeDomain = 240004u,
    /// <summary>Entity Type Country</summary>
    EntityTypeCountry = 240005u,
    /// <summary>Entity Type Category</summary>
    EntityTypeCategory = 240006u,
    /// <summary>Entity Type Sub Category</summary>
    EntityTypeSubCategory = 240007u,
    /// <summary>Entity Type Specific</summary>
    EntityTypeSpecific = 240008u,
    /// <summary>Entity Type Extra</summary>
    EntityTypeExtra = 240009u,
    /// <summary>Alternative Entity Type Kind</summary>
    AlternativeEntityTypeKind = 240010u,
    /// <summary>Alternative Entity Type Domain</summary>
    AlternativeEntityTypeDomain = 240011u,
    /// <summary>Alternative Entity Type Country</summary>
    AlternativeEntityTypeCountry = 240012u,
    /// <summary>Alternative Entity Type Category</summary>
    AlternativeEntityTypeCategory = 240013u,
    /// <summary>Alternative Entity Type Sub Category</summary>
    AlternativeEntityTypeSubCategory = 240014u,
    /// <summary>Alternative Entity Type Specific</summary>
    AlternativeEntityTypeSpecific = 240015u,
    /// <summary>Alternative Entity Type Extra</summary>
    AlternativeEntityTypeExtra = 240016u,
    /// <summary>Entity Location X</summary>
    EntityLocationX = 240017u,
    /// <summary>Entity Location Y</summary>
    EntityLocationY = 240018u,
    /// <summary>Entity Location Z</summary>
    EntityLocationZ = 240019u,
    /// <summary>Entity Linear Velocity X</summary>
    EntityLinearVelocityX = 240020u,
    /// <summary>Entity Linear Velocity Y</summary>
    EntityLinearVelocityY = 240021u,
    /// <summary>Entity Linear Velocity Z</summary>
    EntityLinearVelocityZ = 240022u,
    /// <summary>Entity Orientation Psi</summary>
    EntityOrientationPsi = 240023u,
    /// <summary>Entity Orientation Theta</summary>
    EntityOrientationTheta = 240024u,
    /// <summary>Entity Orientation Phi</summary>
    EntityOrientationPhi = 240025u,
    /// <summary>Dead Reckoning Algorithm</summary>
    DeadReckoningAlgorithm = 240026u,
    /// <summary>Dead Reckoning Linear Acceleration X</summary>
    DeadReckoningLinearAccelerationX = 240027u,
    /// <summary>Dead Reckoning Linear Acceleration Y</summary>
    DeadReckoningLinearAccelerationY = 240028u,
    /// <summary>Dead Reckoning Linear Acceleration Z</summary>
    DeadReckoningLinearAccelerationZ = 240029u,
    /// <summary>Dead Reckoning Angular Velocity X</summary>
    DeadReckoningAngularVelocityX = 240030u,
    /// <summary>Dead Reckoning Angular Velocity Y</summary>
    DeadReckoningAngularVelocityY = 240031u,
    /// <summary>Dead Reckoning Angular Velocity Z</summary>
    DeadReckoningAngularVelocityZ = 240032u,
    /// <summary>Entity Appearance</summary>
    EntityAppearance = 240033u,
    /// <summary>Entity Marking Character Set</summary>
    EntityMarkingCharacterSet = 240034u,
    /// <summary>Entity Marking 11 Bytes</summary>
    EntityMarking11Bytes = 240035u,
    /// <summary>Capability</summary>
    Capability = 240036u,
    /// <summary>Number Articulation Parameters</summary>
    NumberArticulationParameters = 240037u,
    /// <summary>Articulation Parameter ID</summary>
    ArticulationParameterId = 240038u,
    /// <summary>Articulation Parameter Type</summary>
    ArticulationParameterType240039 = 240039u,
    /// <summary>Articulation Parameter Value</summary>
    ArticulationParameterValue240040 = 240040u,
    /// <summary>Type Of Stores</summary>
    TypeOfStores = 240041u,
    /// <summary>Quantity Of Stores</summary>
    QuantityOfStores = 240042u,
    /// <summary>Fuel Quantity</summary>
    FuelQuantity = 240043u,
    /// <summary>Radar System Status</summary>
    RadarSystemStatus = 240044u,
    /// <summary>Radio Communication System Status</summary>
    RadioCommunicationSystemStatus = 240045u,
    /// <summary>Default Time For Radio Transmission For Stationary Transmitters</summary>
    DefaultTimeForRadioTransmissionForStationaryTransmitters = 240046u,
    /// <summary>Default Time For Radio Transmission For Moving Transmitters</summary>
    DefaultTimeForRadioTransmissionForMovingTransmitters = 240047u,
    /// <summary>Body Part Damaged Ratio</summary>
    BodyPartDamagedRatio = 240048u,
    /// <summary>Name Of The Terrain Database File</summary>
    NameOfTheTerrainDatabaseFile = 240049u,
    /// <summary>Name Of Local File</summary>
    NameOfLocalFile = 240050u,
    /// <summary>Aimpoint Bearing</summary>
    AimpointBearing = 240051u,
    /// <summary>Aimpoint Elevation</summary>
    AimpointElevation = 240052u,
    /// <summary>Aimpoint Range</summary>
    AimpointRange = 240053u,
    /// <summary>Air Speed</summary>
    AirSpeed = 240054u,
    /// <summary>Altitude</summary>
    Altitude240055 = 240055u,
    /// <summary>Application Status</summary>
    ApplicationStatus = 240056u,
    /// <summary>Auto Iff</summary>
    AutoIff = 240057u,
    /// <summary>Beacon Delay</summary>
    BeaconDelay = 240058u,
    /// <summary>Bingo Fuel Setting</summary>
    BingoFuelSetting = 240059u,
    /// <summary>Cloud Bottom</summary>
    CloudBottom = 240060u,
    /// <summary>Cloud Top</summary>
    CloudTop = 240061u,
    /// <summary>Direction</summary>
    Direction = 240062u,
    /// <summary>End Action</summary>
    EndAction = 240063u,
    /// <summary>Frequency</summary>
    Frequency = 240064u,
    /// <summary>Freeze</summary>
    Freeze = 240065u,
    /// <summary>Heading</summary>
    Heading = 240066u,
    /// <summary>Identification</summary>
    Identification240067 = 240067u,
    /// <summary>Initial Point Data</summary>
    InitialPointData = 240068u,
    /// <summary>Latitude</summary>
    Latitude240069 = 240069u,
    /// <summary>Lights</summary>
    Lights240070 = 240070u,
    /// <summary>Linear</summary>
    Linear = 240071u,
    /// <summary>Longitude</summary>
    Longitude240072 = 240072u,
    /// <summary>Low Altitude</summary>
    LowAltitude = 240073u,
    /// <summary>Mfd Formats</summary>
    MfdFormats = 240074u,
    /// <summary>Nctr</summary>
    Nctr = 240075u,
    /// <summary>Number Projectiles</summary>
    NumberProjectiles = 240076u,
    /// <summary>Operation Code</summary>
    OperationCode = 240077u,
    /// <summary>Pitch</summary>
    Pitch = 240078u,
    /// <summary>Profiles</summary>
    Profiles = 240079u,
    /// <summary>Quantity</summary>
    Quantity240080 = 240080u,
    /// <summary>Radar Modes</summary>
    RadarModes = 240081u,
    /// <summary>Radar Search Volume</summary>
    RadarSearchVolume = 240082u,
    /// <summary>Roll</summary>
    Roll = 240083u,
    /// <summary>Rotation</summary>
    Rotation240084 = 240084u,
    /// <summary>Scale Factor X</summary>
    ScaleFactorX = 240085u,
    /// <summary>Scale Factor Y</summary>
    ScaleFactorY = 240086u,
    /// <summary>Shields</summary>
    Shields240087 = 240087u,
    /// <summary>Steerpoint</summary>
    Steerpoint = 240088u,
    /// <summary>Spare1</summary>
    Spare1 = 240089u,
    /// <summary>Spare2</summary>
    Spare2 = 240090u,
    /// <summary>Team</summary>
    Team = 240091u,
    /// <summary>Text</summary>
    Text = 240092u,
    /// <summary>Time Of Day</summary>
    TimeOfDay = 240093u,
    /// <summary>Trail Flag</summary>
    TrailFlag = 240094u,
    /// <summary>Trail Size</summary>
    TrailSize = 240095u,
    /// <summary>Type Of Projectile</summary>
    TypeOfProjectile = 240096u,
    /// <summary>Type Of Target</summary>
    TypeOfTarget = 240097u,
    /// <summary>Type Of Threat</summary>
    TypeOfThreat = 240098u,
    /// <summary>Uhf Frequency</summary>
    UhfFrequency = 240099u,
    /// <summary>Utm Altitude</summary>
    UtmAltitude = 240100u,
    /// <summary>Utm Latitude</summary>
    UtmLatitude = 240101u,
    /// <summary>Utm Longitude</summary>
    UtmLongitude = 240102u,
    /// <summary>Vhf Frequency</summary>
    VhfFrequency = 240103u,
    /// <summary>Visibility Range</summary>
    VisibilityRange = 240104u,
    /// <summary>Void Aaa Hit</summary>
    VoidAaaHit = 240105u,
    /// <summary>Void Collision</summary>
    VoidCollision = 240106u,
    /// <summary>Void Earth Hit</summary>
    VoidEarthHit = 240107u,
    /// <summary>Void Friendly</summary>
    VoidFriendly = 240108u,
    /// <summary>Void Gun Hit</summary>
    VoidGunHit = 240109u,
    /// <summary>Void Rocket Hit</summary>
    VoidRocketHit = 240110u,
    /// <summary>Void Sam Hit</summary>
    VoidSamHit = 240111u,
    /// <summary>Weapon Data</summary>
    WeaponData = 240112u,
    /// <summary>Weapon Type</summary>
    WeaponType = 240113u,
    /// <summary>Weather</summary>
    Weather240114 = 240114u,
    /// <summary>Wind Direction</summary>
    WindDirection240115 = 240115u,
    /// <summary>Wind Speed</summary>
    WindSpeed = 240116u,
    /// <summary>Wing Station</summary>
    WingStation = 240117u,
    /// <summary>Yaw</summary>
    Yaw = 240118u,
    /// <summary>Memory Offset</summary>
    MemoryOffset = 240119u,
    /// <summary>Memory Data</summary>
    MemoryData = 240120u,
    /// <summary>VASI</summary>
    Vasi = 240121u,
    /// <summary>Beacon</summary>
    Beacon = 240122u,
    /// <summary>Strobe</summary>
    Strobe = 240123u,
    /// <summary>Culture</summary>
    Culture = 240124u,
    /// <summary>Approach</summary>
    Approach = 240125u,
    /// <summary>Runway End</summary>
    RunwayEnd = 240126u,
    /// <summary>Obstruction</summary>
    Obstruction = 240127u,
    /// <summary>Runway Edge</summary>
    RunwayEdge = 240128u,
    /// <summary>Ramp Taxiway</summary>
    RampTaxiway = 240129u,
    /// <summary>Laser Bomb Code</summary>
    LaserBombCode = 240130u,
    /// <summary>Rack Type</summary>
    RackType = 240131u,
    /// <summary>HUD</summary>
    Hud = 240132u,
    /// <summary>RoleFileName</summary>
    RoleFileName = 240133u,
    /// <summary>PilotName</summary>
    PilotName = 240134u,
    /// <summary>PilotDesignation</summary>
    PilotDesignation = 240135u,
    /// <summary>Model Type</summary>
    ModelType = 240136u,
    /// <summary>DIS Type</summary>
    DisType = 240137u,
    /// <summary>Class</summary>
    ClassValue = 240138u,
    /// <summary>Channel</summary>
    Channel = 240139u,
    /// <summary>Entity Type</summary>
    EntityType240140 = 240140u,
    /// <summary>Alternative Entity Type</summary>
    AlternativeEntityType240141 = 240141u,
    /// <summary>Entity Location</summary>
    EntityLocation = 240142u,
    /// <summary>Entity Linear Velocity</summary>
    EntityLinearVelocity = 240143u,
    /// <summary>Entity Orientation</summary>
    EntityOrientation = 240144u,
    /// <summary>Dead Reckoning</summary>
    DeadReckoning = 240145u,
    /// <summary>Failure Symptom</summary>
    FailureSymptom = 240146u,
    /// <summary>Max Fuel</summary>
    MaxFuel = 240147u,
    /// <summary>Refueling Boom Connect</summary>
    RefuelingBoomConnect = 240148u,
    /// <summary>Altitude AGL</summary>
    AltitudeAgl = 240149u,
    /// <summary>Calibrated Airspeed</summary>
    CalibratedAirspeed = 240150u,
    /// <summary>TACAN Channel</summary>
    TacanChannel = 240151u,
    /// <summary>TACAN Band</summary>
    TacanBand = 240152u,
    /// <summary>TACAN Mode</summary>
    TacanMode = 240153u,
    /// <summary>Fuel Flow Rate (kg/min)</summary>
    FuelFlowRateKgMin = 270115u,
    /// <summary>Fuel Temperature (degC)</summary>
    FuelTemperatureDegC = 270116u,
    /// <summary>Fuel Pressure (Pa)</summary>
    FuelPressurePa = 270117u,
    /// <summary>SKE Slot</summary>
    SkeSlot = 270150u,
    /// <summary>SKE Lead</summary>
    SkeLead = 270151u,
    /// <summary>SKE Frequency</summary>
    SkeFrequency = 270152u,
    /// <summary>FCI Cmd</summary>
    FciCmd = 270153u,
    /// <summary>FCI Num</summary>
    FciNum = 270154u,
    /// <summary>SKE Bit Field</summary>
    SkeBitField = 270155u,
    /// <summary>Formation Position</summary>
    FormationPosition = 270156u,
    /// <summary>Formation Number</summary>
    FormationNumber = 270157u,
    /// <summary>FFS Mode Active</summary>
    FfsModeActive = 270158u,
    /// <summary>FFS Role</summary>
    FfsRole = 270159u,
    /// <summary>FFS VCAS</summary>
    FfsVcas = 270160u,
    /// <summary>FFS Bit Field</summary>
    FfsBitField = 270161u,
    /// <summary>FFS Call Sign</summary>
    FfsCallSign = 270162u,
    /// <summary>FFS Guidance Data</summary>
    FfsGuidanceData = 270163u,
    /// <summary>FFS Text Data</summary>
    FfsTextData = 270164u,
    /// <summary>FFS Airdrop Request Data</summary>
    FfsAirdropRequestData = 270165u,
    /// <summary>FFS Airdrop Data</summary>
    FfsAirdropData = 270166u,
    /// <summary>Horizontal Circular Error Probable (m)</summary>
    HorizontalCircularErrorProbableM = 300000u,
    /// <summary>Horizontal Position Error (m)</summary>
    HorizontalPositionErrorM = 300001u,
    /// <summary>Vertical Position Error (m)</summary>
    VerticalPositionErrorM = 300002u,
    /// <summary>Horizontal Velocity Error (m/s)</summary>
    HorizontalVelocityErrorMS = 300003u,
    /// <summary>Vertical Velocity Error (m/s)</summary>
    VerticalVelocityErrorMS = 300004u,
    /// <summary>4th Lowest Jammer to Signal Ratio for P(Y)-L1 (dB)</summary>
    Value4thLowestJammerToSignalRatioForPYL1DB = 300005u,
    /// <summary>4th Lowest Jammer to Signal Ratio for P(Y)-L2 (dB)</summary>
    Value4thLowestJammerToSignalRatioForPYL2DB = 300006u,
    /// <summary>GPS Figure of Merit</summary>
    GpsFigureOfMerit = 300007u,
    /// <summary>Weapon Transfer GPS State</summary>
    WeaponTransferGpsState = 300008u,
    /// <summary>Weapon Transfer Horizontal Position Error (m)</summary>
    WeaponTransferHorizontalPositionErrorM = 300009u,
    /// <summary>Weapon Transfer Vertical Position Error (m)</summary>
    WeaponTransferVerticalPositionErrorM = 300010u,
    /// <summary>Weapon Transfer Vertical Position Error (m)</summary>
    WeaponTransferVerticalPositionErrorM300011 = 300011u,
    /// <summary>Weapon Transfer Horizontal Velocity Error (m/s)</summary>
    WeaponTransferHorizontalVelocityErrorMS = 300012u,
    /// <summary>Time Transfer Error (sec)</summary>
    TimeTransferErrorSec = 300013u,
    /// <summary>Age of Ephemeris (sec)</summary>
    AgeOfEphemerisSec = 300014u,
    /// <summary>Non-Flyout Munition Entity Request DIS Type Enumeration</summary>
    NonFlyoutMunitionEntityRequestDisTypeEnumeration = 300016u,
    /// <summary>Non-Flyout Munition Entity Request Launch Point X (m)</summary>
    NonFlyoutMunitionEntityRequestLaunchPointXM = 300017u,
    /// <summary>Non-Flyout Munition Entity Request Launch Point Y (m)</summary>
    NonFlyoutMunitionEntityRequestLaunchPointYM = 300018u,
    /// <summary>Non-Flyout Munition Entity Request Launch Point Z (m)</summary>
    NonFlyoutMunitionEntityRequestLaunchPointZM = 300019u,
    /// <summary>Non-Flyout Munition Entity Request Maximum Altitude (m MSL)</summary>
    NonFlyoutMunitionEntityRequestMaximumAltitudeMMsl = 300020u,
    /// <summary>Non-Flyout Munition Entity Request Flight Path</summary>
    NonFlyoutMunitionEntityRequestFlightPath = 300021u,
    /// <summary>Non-Flyout Munition Entity Request Impact Point X (m)</summary>
    NonFlyoutMunitionEntityRequestImpactPointXM = 300022u,
    /// <summary>Non-Flyout Munition Entity Request Impact Point Y (m)</summary>
    NonFlyoutMunitionEntityRequestImpactPointYM = 300023u,
    /// <summary>Non-Flyout Munition Entity Request Impact Point Z (m)</summary>
    NonFlyoutMunitionEntityRequestImpactPointZM = 300024u,
    /// <summary>Non-Flyout Munition Entity Request Elapsed Flight Time (sec)</summary>
    NonFlyoutMunitionEntityRequestElapsedFlightTimeSec = 300025u,
    /// <summary>Non-Flyout Munition Entity Request Launch Time (sec)</summary>
    NonFlyoutMunitionEntityRequestLaunchTimeSec = 300026u,
    /// <summary>Time Error (sec)</summary>
    TimeErrorSec = 300027u,
    /// <summary>Link 16 Command Variety 1</summary>
    Link16CommandVariety1 = 301100u,
    /// <summary>Push</summary>
    Push = 301130u,
    /// <summary>Rolex</summary>
    Rolex = 301140u,
    /// <summary>Terminate Intercept</summary>
    TerminateIntercept = 301150u,
    /// <summary>Heal Damage</summary>
    HealDamage = 301151u,
    /// <summary>Destroy</summary>
    Destroy = 301152u,
    /// <summary>Transfer Control Management</summary>
    TransferControlManagement = 301160u,
    /// <summary>Link 16 Controls - PPLI Enable</summary>
    Link16ControlsPpliEnable = 301170u,
    /// <summary>Link 16 Controls - Command &amp; Control Enable</summary>
    Link16ControlsCommandControlEnable = 301171u,
    /// <summary>Link 16 Reference Point Message Initiation</summary>
    Link16ReferencePointMessageInitiation = 301174u,
    /// <summary>Assign External Entity Link 16 Track Number</summary>
    AssignExternalEntityLink16TrackNumber = 301175u,
    /// <summary>Link 16 Intelligence Info</summary>
    Link16IntelligenceInfo = 301176u,
    /// <summary>Link 16 Track Management</summary>
    Link16TrackManagement = 301177u,
    /// <summary>Link 16 Controls - CES Global PPLI Publish</summary>
    Link16ControlsCesGlobalPpliPublish = 301178u,
    /// <summary>Link 16 Controls - CES Global Surveillance Publish</summary>
    Link16ControlsCesGlobalSurveillancePublish = 301179u,
    /// <summary>Request Global Link 16 Configuration</summary>
    RequestGlobalLink16Configuration = 301180u,
    /// <summary>Link 16 Controls - Surveillance Enable</summary>
    Link16ControlsSurveillanceEnable = 301181u,
    /// <summary>Link 16 Pointer</summary>
    Link16Pointer = 301182u,
    /// <summary>Link 16 Vector</summary>
    Link16Vector = 301183u,
    /// <summary>Link 16 Control Unit Change</summary>
    Link16ControlUnitChange = 301184u,
    /// <summary>Link 16 Text</summary>
    Link16Text = 301185u,
    /// <summary>Request Link 16 Objects</summary>
    RequestLink16Objects = 301186u,
    /// <summary>Link 16 Ref Object Name List</summary>
    Link16RefObjectNameList = 301187u,
    /// <summary>Total Number of PDUs in Link 16 Ref Objects Response</summary>
    TotalNumberOfPDUsInLink16RefObjectsResponse = 301189u,
    /// <summary>PDU Number in Link 16 Ref Objects Response</summary>
    PduNumberInLink16RefObjectsResponse = 301190u,
    /// <summary>Total Number of Link 16 Ref Objects</summary>
    TotalNumberOfLink16RefObjects = 301191u,
    /// <summary>Link 16 Controls - F2F A Enable</summary>
    Link16ControlsF2fAEnable = 301197u,
    /// <summary>Link 16 Controls - F2F B Enable</summary>
    Link16ControlsF2fBEnable = 301198u,
    /// <summary>STN of Formation Leader</summary>
    StnOfFormationLeader = 301199u,
    /// <summary>Formation Name</summary>
    FormationName = 301200u,
    /// <summary>Formation Role</summary>
    FormationRole = 301201u,
    /// <summary>Surveillance Contributor Sensor Based Detection</summary>
    SurveillanceContributorSensorBasedDetection = 301202u,
    /// <summary>F2F A NPG</summary>
    F2fANpg = 301220u,
    /// <summary>Link 16 Controls - F2F A Net</summary>
    Link16ControlsF2fANet = 301221u,
    /// <summary>F2F B NPG</summary>
    F2fBNpg = 301222u,
    /// <summary>Link 16 Controls - F2F B Net</summary>
    Link16ControlsF2fBNet = 301223u,
    /// <summary>Surveillance Enabled NPB</summary>
    SurveillanceEnabledNpb = 301224u,
    /// <summary>Surveillance Enabled Net</summary>
    SurveillanceEnabledNet = 301225u,
    /// <summary>Control Unit Enabled</summary>
    ControlUnitEnabled = 301226u,
    /// <summary>Control Unit Enabled NPG</summary>
    ControlUnitEnabledNpg = 301227u,
    /// <summary>Control Unit Enabled Net</summary>
    ControlUnitEnabledNet = 301228u,
    /// <summary>Voice Frequency</summary>
    VoiceFrequency = 301229u,
    /// <summary>Link 16 JTIDS Voice Callsign</summary>
    Link16JtidsVoiceCallsign = 301234u,
    /// <summary>Entity ID of Control Unit</summary>
    EntityIdOfControlUnit = 301237u,
    /// <summary>STN of Control Unit</summary>
    StnOfControlUnit = 301238u,
    /// <summary>NTR Participation Level</summary>
    NtrParticipationLevel = 301239u,
    /// <summary>Link 16 Controls - CES Global PPLI Subscribe</summary>
    Link16ControlsCesGlobalPpliSubscribe = 301240u,
    /// <summary>Link 16 Controls - CES Global Surveillance Subscribe</summary>
    Link16ControlsCesGlobalSurveillanceSubscribe = 301241u,
    /// <summary>NTR in Mission</summary>
    NtrInMission = 301242u,
    /// <summary>NTR Marking</summary>
    NtrMarking = 301243u,
    /// <summary>NTR Receipt/Compliance</summary>
    NtrReceiptCompliance = 301244u,
    /// <summary>Formation F2F NPG</summary>
    FormationF2fNpg = 301255u,
    /// <summary>Formation F2F Channel</summary>
    FormationF2fChannel = 301256u,
    /// <summary>JLVC (JSPA) LogReport</summary>
    JlvcJspaLogReport = 400008u,
    /// <summary>JLVC (JSPA) SupplyAdjust</summary>
    JlvcJspaSupplyAdjust = 400009u,
    /// <summary>JLVC (JSPA) EntityControl</summary>
    JlvcJspaEntityControl = 400010u,
    /// <summary>JLVC (JSPA) HealthUpdate</summary>
    JlvcJspaHealthUpdate = 400011u,
    /// <summary>JLVC (JSPA) RepairComplete</summary>
    JlvcJspaRepairComplete = 400012u,
    /// <summary>JLVC (JSPA) UnitActivation</summary>
    JlvcJspaUnitActivation = 400013u,
    /// <summary>JLVC (JSPA) BattleDamageRepair</summary>
    JlvcJspaBattleDamageRepair = 400014u,
    /// <summary>JLVC (JSPA) Minefield</summary>
    JlvcJspaMinefield = 400015u,
    /// <summary>JLVC (JSPA) Wire</summary>
    JlvcJspaWire = 400016u,
    /// <summary>JLVC (JSPA) Abatis</summary>
    JlvcJspaAbatis = 400017u,
    /// <summary>JLVC (JSPA) Crater</summary>
    JlvcJspaCrater = 400018u,
    /// <summary>JLVC (JSPA) Ditch</summary>
    JlvcJspaDitch = 400019u,
    /// <summary>JLVC (JSPA) Lanes</summary>
    JlvcJspaLanes = 400020u,
    /// <summary>JLVC (JSPA) IED</summary>
    JlvcJspaIed = 400021u,
    /// <summary>JLVC (JSPA) Rubble</summary>
    JlvcJspaRubble = 400022u,
    /// <summary>JLVC (JSPA) SubmergedBarrier</summary>
    JlvcJspaSubmergedBarrier = 400023u,
    /// <summary>JLVC (JSPA) FloatingBarrier</summary>
    JlvcJspaFloatingBarrier = 400024u,
    /// <summary>JLVC (JSPA) Foxhole</summary>
    JlvcJspaFoxhole = 400025u,
    /// <summary>JLVC (JSPA) VehicleHole</summary>
    JlvcJspaVehicleHole = 400026u,
    /// <summary>JLVC (JSPA) VehicleFortification</summary>
    JlvcJspaVehicleFortification = 400027u,
    /// <summary>JLVC (JSPA) Sandbag</summary>
    JlvcJspaSandbag = 400028u,
    /// <summary>JLVC (JSPA) Checkpoint</summary>
    JlvcJspaCheckpoint = 400029u,
    /// <summary>JLVC (JSPA) ContamCloud2D</summary>
    JlvcJspaContamCloud2D = 400030u,
    /// <summary>JLVC (JSPA) PopulationEffect</summary>
    JlvcJspaPopulationEffect = 400031u,
    /// <summary>JLVC (JSPA) Mine</summary>
    JlvcJspaMine = 400032u,
    /// <summary>JLVC (JSPA) SeaMinefield</summary>
    JlvcJspaSeaMinefield = 400033u,
    /// <summary>JLVC ReasonForEffect</summary>
    JlvcReasonForEffect = 400034u,
    /// <summary>JLVC PhysicalEffect</summary>
    JlvcPhysicalEffect = 400035u,
    /// <summary>JLVC FunctionalEffect</summary>
    JlvcFunctionalEffect = 400036u,
    /// <summary>JLVC SourceLVCID</summary>
    JlvcSourceLVCID = 400037u,
    /// <summary>JLVC TargetLVCID</summary>
    JlvcTargetLVCID = 400038u,
    /// <summary>JLVC EventUUID</summary>
    JlvcEventUUID = 400039u,
    /// <summary>JLVC EffectGeometry</summary>
    JlvcEffectGeometry = 400040u,
    /// <summary>JLVC EffectRequestAcknowledgement</summary>
    JlvcEffectRequestAcknowledgement = 400041u,
    /// <summary>JLVC EffectAcknowledgeResponse</summary>
    JlvcEffectAcknowledgeResponse = 400042u,
    /// <summary>JLVC EffectLifecycle</summary>
    JlvcEffectLifecycle = 400043u,
    /// <summary>JLVC RelatedEventID</summary>
    JlvcRelatedEventID = 400044u,
    /// <summary>JLVC SystemFunctionalType</summary>
    JlvcSystemFunctionalType = 400045u,
    /// <summary>JLVC CapabilityType</summary>
    JlvcCapabilityType = 400046u,
    /// <summary>JLVC NetworkFunctionalType</summary>
    JlvcNetworkFunctionalType = 400047u,
    /// <summary>JLVC TargetEntityType</summary>
    JlvcTargetEntityType = 400048u,
    /// <summary>JLVC TargetEmitterType</summary>
    JlvcTargetEmitterType = 400049u,
    /// <summary>JLVC PlatformDomainType</summary>
    JlvcPlatformDomainType = 400050u,
    /// <summary>JLVC EffectAssessmentDegradationStruct</summary>
    JlvcEffectAssessmentDegradationStruct = 400051u,
    /// <summary>JLVC EffectPhysicalBdaStruct</summary>
    JlvcEffectPhysicalBdaStruct = 400052u,
    /// <summary>Munition</summary>
    Munition = 500001u,
    /// <summary>Engine Fuel</summary>
    EngineFuel = 500002u,
    /// <summary>Storage Fuel</summary>
    StorageFuel = 500003u,
    /// <summary>Not Used</summary>
    NotUsed = 500004u,
    /// <summary>Expendable</summary>
    Expendable = 500005u,
    /// <summary>Total Record Sets</summary>
    TotalRecordSets = 500006u,
    /// <summary>Launched Munition</summary>
    LaunchedMunition = 500007u,
    /// <summary>Association</summary>
    Association = 500008u,
    /// <summary>Sensor</summary>
    Sensor = 500009u,
    /// <summary>Munition Reload</summary>
    MunitionReload = 500010u,
    /// <summary>Engine Fuel Reload</summary>
    EngineFuelReload = 500011u,
    /// <summary>Storage Fuel Reload</summary>
    StorageFuelReload = 500012u,
    /// <summary>Expendable Reload</summary>
    ExpendableReload = 500013u,
    /// <summary>IFF Change Control - Mode 1 Code</summary>
    IffChangeControlMode1Code = 500014u,
    /// <summary>IFF Change Control - Mode 2 Code</summary>
    IffChangeControlMode2Code = 500015u,
    /// <summary>IFF Change Control - Mode 3 Code</summary>
    IffChangeControlMode3Code = 500016u,
    /// <summary>IFF Change Control - Mode 4 Code</summary>
    IffChangeControlMode4Code = 500017u,
    /// <summary>IFF Change Control - Mode 5 Code</summary>
    IffChangeControlMode5Code = 500018u,
    /// <summary>IFF Change Control - Mode 6 Code</summary>
    IffChangeControlMode6Code = 500019u,
    /// <summary>Link 16 Data</summary>
    Link16Data = 500021u,
    /// <summary>ARM Alert</summary>
    ArmAlert = 500022u,
    /// <summary>IFF Change Control - Mode On/Off</summary>
    IffChangeControlModeOnOff = 500023u,
    /// <summary>Weapon Status Data</summary>
    WeaponStatusData = 500024u,
    /// <summary>Expendable Status Data</summary>
    ExpendableStatusData = 500025u,
    /// <summary>Tactic Status Data</summary>
    TacticStatusData = 500026u,
    /// <summary>Emitter/Sensor Data</summary>
    EmitterSensorData = 500027u,
    /// <summary>IOS Control Data</summary>
    IosControlData = 500028u,
    /// <summary>Static Status Data</summary>
    StaticStatusData = 500029u,
    /// <summary>Request Inactive Entities</summary>
    RequestInactiveEntities = 500200u,
    /// <summary>Inactive Entity Quantity</summary>
    InactiveEntityQuantity = 500201u,
    /// <summary>Inactive Entity ID</summary>
    InactiveEntityId = 500202u,
    /// <summary>Inactive Entity Type</summary>
    InactiveEntityType = 500203u,
    /// <summary>Activation Trigger Type</summary>
    ActivationTriggerType = 500204u,
    /// <summary>Activation Trigger Value</summary>
    ActivationTriggerValue = 500205u,
    /// <summary>Air-to-Air Missile Qty</summary>
    AirToAirMissileQty = 551001u,
    /// <summary>AIM-7 Missile Qty</summary>
    Aim7MissileQty = 551002u,
    /// <summary>AIM-9 Missile Qty</summary>
    Aim9MissileQty = 551003u,
    /// <summary>AIM-120 Missile Qty</summary>
    Aim120MissileQty = 551004u,
    /// <summary>Air-to-Ground Missile Qty</summary>
    AirToGroundMissileQty = 551005u,
    /// <summary>Surface-to-Air Missile Qty</summary>
    SurfaceToAirMissileQty = 551006u,
    /// <summary>Bullet Qty</summary>
    BulletQty = 551007u,
    /// <summary>Chaff Qty</summary>
    ChaffQty = 552001u,
    /// <summary>Flare Qty</summary>
    FlareQty = 552002u,
    /// <summary>Fuel Level</summary>
    FuelLevel = 553001u,
    /// <summary>Route Type</summary>
    RouteType = 553002u,
    /// <summary>Threat Mode</summary>
    ThreatMode = 553003u,
    /// <summary>Target Occluded</summary>
    TargetOccluded = 553004u,
    /// <summary>Terrain Height</summary>
    TerrainHeight = 553005u,
    /// <summary>Entity Status</summary>
    EntityStatus = 553006u,
    /// <summary>Marshal Status</summary>
    MarshalStatus = 553007u,
    /// <summary>Power Plant Status</summary>
    PowerPlantStatus = 553008u,
    /// <summary>Nav Light Status</summary>
    NavLightStatus = 553009u,
    /// <summary>Interior Light Status</summary>
    InteriorLightStatus = 553010u,
    /// <summary>Landing Light Status</summary>
    LandingLightStatus = 553011u,
    /// <summary>Formation Light Status</summary>
    FormationLightStatus = 553012u,
    /// <summary>Anti-Collision Light Status</summary>
    AntiCollisionLightStatus = 553013u,
    /// <summary>Nav/Formation Flash Rate</summary>
    NavFormationFlashRate = 553014u,
    /// <summary>Anti-Col. 'On' Duration</summary>
    AntiColOnDuration = 553015u,
    /// <summary>Anti-Col. 'Off' Duration</summary>
    AntiColOffDuration = 553016u,
    /// <summary>Intercept Status</summary>
    InterceptStatus = 553017u,
    /// <summary>LifeForm Signaling Device Type</summary>
    LifeFormSignalingDeviceType = 553018u,
    /// <summary>LifeForm Movement Type</summary>
    LifeFormMovementType = 553019u,
    /// <summary>LifeForm In Vehicle</summary>
    LifeFormInVehicle = 553020u,
    /// <summary>Mobility Kill</summary>
    MobilityKill553021 = 553021u,
    /// <summary>Firepower Kill</summary>
    FirepowerKill = 553022u,
    /// <summary>Tanker Enabled/Disabled</summary>
    TankerEnabledDisabled = 553028u,
    /// <summary>Threat Status Tactic OK to Shoot Down Weapons</summary>
    ThreatStatusTacticOkToShootDownWeapons = 553029u,
    /// <summary>TACAN Channel</summary>
    TacanChannel554001 = 554001u,
    /// <summary>TACAN Band</summary>
    TacanBand554002 = 554002u,
    /// <summary>TACAN Mode</summary>
    TacanMode554003 = 554003u,
    /// <summary>RWR Status</summary>
    RwrStatus = 554004u,
    /// <summary>UHF Radio Frequency</summary>
    UhfRadioFrequency = 554005u,
    /// <summary>Emit Jamming Status</summary>
    EmitJammingStatus = 554006u,
    /// <summary>Emit Jamming Type</summary>
    EmitJammingType = 554007u,
    /// <summary>Receive Jamming Status</summary>
    ReceiveJammingStatus = 554008u,
    /// <summary>RADAR Mode</summary>
    RadarMode = 554009u,
    /// <summary>Available RADAR Modes</summary>
    AvailableRadarModes = 554010u,
    /// <summary>Jammer Pod Enumeration</summary>
    JammerPodEnumeration = 554100u,
    /// <summary>Jammer Pod Behavior</summary>
    JammerPodBehavior = 554101u,
    /// <summary>Jammer Pod Programs</summary>
    JammerPodPrograms = 554102u,
    /// <summary>Jammer Pod Receiver Sensitivity</summary>
    JammerPodReceiverSensitivity = 554103u,
    /// <summary>Jammer Pod Receiver Frequency Minimum</summary>
    JammerPodReceiverFrequencyMinimum = 554104u,
    /// <summary>Jammer Pod Receiver Frequency Maximum</summary>
    JammerPodReceiverFrequencyMaximum = 554105u,
    /// <summary>Jammer Pod Power</summary>
    JammerPodPower = 554106u,
    /// <summary>Jammer Pod Variability</summary>
    JammerPodVariability = 554107u,
    /// <summary>Jammer Pod Number of False Targets</summary>
    JammerPodNumberOfFalseTargets = 554108u,
    /// <summary>Jammer Pod Jammer Knob</summary>
    JammerPodJammerKnob = 554109u,
    /// <summary>Jammer Pod Missile Jamming</summary>
    JammerPodMissileJamming = 554110u,
    /// <summary>Emitter Override</summary>
    EmitterOverride555001 = 555001u,
    /// <summary>Jammer Override</summary>
    JammerOverride = 555002u,
    /// <summary>Disengage / Reengage</summary>
    DisengageReengage555003 = 555003u,
    /// <summary>Heading Override</summary>
    HeadingOverride = 555004u,
    /// <summary>Altitude Override</summary>
    AltitudeOverride = 555005u,
    /// <summary>Speed Override</summary>
    SpeedOverride = 555006u,
    /// <summary>Verbose Override</summary>
    VerboseOverride = 555007u,
    /// <summary>Occlusion Override</summary>
    OcclusionOverride = 555008u,
    /// <summary>Commit Range</summary>
    CommitRange = 556001u,
    /// <summary>Current Scenario IFF Mode 4A Code for This Threat's Affiliation</summary>
    CurrentScenarioIffMode4aCodeForThisThreatSAffiliation = 556007u,
    /// <summary>Current Scenario IFF Mode 4B Code for This Threat's Affiliation</summary>
    CurrentScenarioIffMode4bCodeForThisThreatSAffiliation = 556008u,
    /// <summary>Ok to Engage Waypoint Number</summary>
    OkToEngageWaypointNumber = 556016u,
    /// <summary>Max Speed at Sea Level</summary>
    MaxSpeedAtSeaLevel = 556017u,
    /// <summary>Max Speed</summary>
    MaxSpeed = 556018u,
    /// <summary>Current Waypoint Number</summary>
    CurrentWaypointNumber = 556019u,
    /// <summary>Route Information</summary>
    RouteInformation = 556020u,
    /// <summary>Threat Status Static Multi Target Track</summary>
    ThreatStatusStaticMultiTargetTrack = 556029u,
    /// <summary>Air-Air IR Missile Qty</summary>
    AirAirIrMissileQty = 557001u,
    /// <summary>Air-Air Radar Missile Qty</summary>
    AirAirRadarMissileQty = 557002u,
    /// <summary>Air-Ground IR Missile Qty</summary>
    AirGroundIrMissileQty = 557003u,
    /// <summary>Air-Ground Radar Missile Qty</summary>
    AirGroundRadarMissileQty = 557004u,
    /// <summary>Air-Ground Anti-Radiation Missile Qty</summary>
    AirGroundAntiRadiationMissileQty = 557005u,
    /// <summary>Air-Ground Bomb Qty</summary>
    AirGroundBombQty = 557006u,
    /// <summary>Air-Ground Rocket Qty</summary>
    AirGroundRocketQty = 557007u,
    /// <summary>Surface-Air IR Missile Qty</summary>
    SurfaceAirIrMissileQty = 557008u,
    /// <summary>Surface-Air Radar Missile Qty</summary>
    SurfaceAirRadarMissileQty = 557009u,
    /// <summary>Bullet Qty</summary>
    BulletQty557010 = 557010u,
    /// <summary>PPLI Publish Enabled</summary>
    PpliPublishEnabled = 559001u,
    /// <summary>Surveillance PublishEnabled</summary>
    SurveillancePublishEnabled = 559002u,
    /// <summary>NPG</summary>
    Npg = 559003u,
    /// <summary>NPG Channel</summary>
    NpgChannel = 559004u,
    /// <summary>JTIDS Track Number</summary>
    JtidsTrackNumber = 559005u,
    /// <summary>Link 16 Controls - Surveillance Reportable</summary>
    Link16ControlsSurveillanceReportable = 559006u,
    /// <summary>Link 16 Controls - Surveillance Track Quality</summary>
    Link16ControlsSurveillanceTrackQuality = 559007u,
    /// <summary>Link 16 Controls - Target Position Quality</summary>
    Link16ControlsTargetPositionQuality = 559008u,
    /// <summary>Link 16 Controls - Quality Error Type</summary>
    Link16ControlsQualityErrorType = 559009u,
    /// <summary>Link 16 Controls - Affiliation Determination Rule</summary>
    Link16ControlsAffiliationDeterminationRule = 559010u,
    /// <summary>Link 16 Controls - Reset Entity Affiliation</summary>
    Link16ControlsResetEntityAffiliation = 559011u,
    /// <summary>Link 16 Controls - Reset All Affiliation</summary>
    Link16ControlsResetAllAffiliation = 559012u,
    /// <summary>End of Messages</summary>
    EndOfMessages = 559999u,
    /// <summary>Malfunction Activate/Deactivate Set</summary>
    MalfunctionActivateDeactivateSet = 600001u,
    /// <summary>Malfunction Status</summary>
    MalfunctionStatus = 600002u,
    /// <summary>Request JTIDS Track Numbers</summary>
    RequestJtidsTrackNumbers = 600210u,
    /// <summary>Track Numbers vs EID</summary>
    TrackNumbersVsEid = 600212u,
    /// <summary>Total Number of JTIDS Track Numbers</summary>
    TotalNumberOfJtidsTrackNumbers = 600214u,
    /// <summary>PDU Number in JTIDS Track Number Response</summary>
    PduNumberInJtidsTrackNumberResponse = 600215u,
    /// <summary>Total Number of PDUs in JTIDS Track Number Response</summary>
    TotalNumberOfPDUsInJtidsTrackNumberResponse = 600216u,
    /// <summary>Air to Air Refueler Entities Request</summary>
    AirToAirRefuelerEntitiesRequest = 600218u,
    /// <summary>Air to Air Refueling Count</summary>
    AirToAirRefuelingCount = 600219u,
    /// <summary>Air To Air Refueler Entity</summary>
    AirToAirRefuelerEntity = 600220u,
    /// <summary>Formation Library Request</summary>
    FormationLibraryRequest = 600300u,
    /// <summary>Total Number Formation Library PDUs</summary>
    TotalNumberFormationLibraryPDUs = 600301u,
    /// <summary>PDU Number in Formation Library Response</summary>
    PduNumberInFormationLibraryResponse = 600302u,
    /// <summary>Total Number Formation Library Items in PDU</summary>
    TotalNumberFormationLibraryItemsInPdu = 600303u,
    /// <summary>Formation Library Variable</summary>
    FormationLibraryVariable = 600304u,
    /// <summary>Create Runtime Formation</summary>
    CreateRuntimeFormation = 600305u,
    /// <summary>Formation Request Header</summary>
    FormationRequestHeader = 600306u,
    /// <summary>Formation Position Absolute</summary>
    FormationPositionAbsolute = 600307u,
    /// <summary>Formation Position Relative</summary>
    FormationPositionRelative = 600308u,
    /// <summary>Expendables Reload</summary>
    ExpendablesReload = 610006u,
    /// <summary>Position Freeze</summary>
    PositionFreeze = 610007u,
    /// <summary>Activate Ownship</summary>
    ActivateOwnship = 610008u,
    /// <summary>Chocks</summary>
    Chocks = 610009u,
    /// <summary>Warm-up Cool-down Override</summary>
    WarmUpCoolDownOverride = 610010u,
    /// <summary>Ground Power</summary>
    GroundPower = 610011u,
    /// <summary>Scramble Start</summary>
    ScrambleStart = 610012u,
    /// <summary>Ownship as a Threat</summary>
    OwnshipAsAThreat = 610013u,
    /// <summary>Fuel External</summary>
    FuelExternal = 610015u,
    /// <summary>Fuel Internal</summary>
    FuelInternal = 610016u,
    /// <summary>Fuel Tank Temp</summary>
    FuelTankTemp = 610017u,
    /// <summary>Gross Weight</summary>
    GrossWeight = 610025u,
    /// <summary>Angle Of Attack</summary>
    AngleOfAttack = 610026u,
    /// <summary>G Load</summary>
    GLoad = 610027u,
    /// <summary>Weight On Wheels</summary>
    WeightOnWheels = 610029u,
    /// <summary>Stored Energy System Reload</summary>
    StoredEnergySystemReload = 610032u,
    /// <summary>Kill Override</summary>
    KillOverride = 610035u,
    /// <summary>Expendables Freeze</summary>
    ExpendablesFreeze = 610036u,
    /// <summary>GPS Satellites Enable/Disable</summary>
    GpsSatellitesEnableDisable = 610037u,
    /// <summary>Ownship Message Display</summary>
    OwnshipMessageDisplay = 610040u,
    /// <summary>Weapon Quantity Freeze</summary>
    WeaponQuantityFreeze = 610042u,
    /// <summary>Global Control - Freeze Weapons Quantity On All Ownships</summary>
    GlobalControlFreezeWeaponsQuantityOnAllOwnships = 610043u,
    /// <summary>Global Control - Freeze Fuel Quantity On All Ownships</summary>
    GlobalControlFreezeFuelQuantityOnAllOwnships = 610044u,
    /// <summary>Global Control - Freeze Kill Override On All Ownships</summary>
    GlobalControlFreezeKillOverrideOnAllOwnships = 610045u,
    /// <summary>Global Control - Freeze Crash Override On All Ownships</summary>
    GlobalControlFreezeCrashOverrideOnAllOwnships = 610046u,
    /// <summary>Ownship OFP Block Number</summary>
    OwnshipOfpBlockNumber = 610047u,
    /// <summary>Waypoint Information Query</summary>
    WaypointInformationQuery = 610048u,
    /// <summary>Waypoint Information</summary>
    WaypointInformation = 610049u,
    /// <summary>Ownship Subsystem Status Data</summary>
    OwnshipSubsystemStatusData = 610050u,
    /// <summary>Cockpit Switch Status</summary>
    CockpitSwitchStatus = 613002u,
    /// <summary>Integrated Control Panel Messages</summary>
    IntegratedControlPanelMessages = 613003u,
    /// <summary>Throttle Positions</summary>
    ThrottlePositions = 613004u,
    /// <summary>Current Critical Switch Position</summary>
    CurrentCriticalSwitchPosition = 613005u,
    /// <summary>Correct Critical Switch Position</summary>
    CorrectCriticalSwitchPosition = 613006u,
    /// <summary>Current Critical Switch Data</summary>
    CurrentCriticalSwitchData = 613007u,
    /// <summary>Correct Critical Switch Data</summary>
    CorrectCriticalSwitchData = 613008u,
    /// <summary>Mission Initial Conditions Set</summary>
    MissionInitialConditionsSet = 613013u,
    /// <summary>Global Control - Malfunction Active on All Ownships</summary>
    GlobalControlMalfunctionActiveOnAllOwnships = 613016u,
    /// <summary>Global Control - Malfunction Clear On All Ownships</summary>
    GlobalControlMalfunctionClearOnAllOwnships = 613017u,
    /// <summary>Validated Critical Switch Report</summary>
    ValidatedCriticalSwitchReport = 613020u,
    /// <summary>SAR Map Pathname</summary>
    SarMapPathname = 613021u,
    /// <summary>Validated Critical Switch Ownship ID</summary>
    ValidatedCriticalSwitchOwnshipId = 613022u,
    /// <summary>Lower Boom Event Report</summary>
    LowerBoomEventReport = 613027u,
    /// <summary>Raise Boom Event Report</summary>
    RaiseBoomEventReport = 613028u,
    /// <summary>Breakaway Event Report</summary>
    BreakawayEventReport = 613029u,
    /// <summary>Complete Event Report</summary>
    CompleteEventReport = 613030u,
    /// <summary>Aux Comm Panel Frequency Display</summary>
    AuxCommPanelFrequencyDisplay = 613031u,
    /// <summary>Network Station Information</summary>
    NetworkStationInformation = 615000u,
    /// <summary>Global Control Select Network Station</summary>
    GlobalControlSelectNetworkStation = 615001u,
    /// <summary>Network Station Under Global Control</summary>
    NetworkStationUnderGlobalControl = 615002u,
    /// <summary>Global Control Still Controlling</summary>
    GlobalControlStillControlling = 615003u,
    /// <summary>Global Control Release Control of Network Station</summary>
    GlobalControlReleaseControlOfNetworkStation = 615004u,
    /// <summary>Global Control Freeze Weapon Quantity</summary>
    GlobalControlFreezeWeaponQuantity = 615005u,
    /// <summary>Global Control Freeze Fuel Quantity</summary>
    GlobalControlFreezeFuelQuantity = 615006u,
    /// <summary>Global Control Freeze Kill Override</summary>
    GlobalControlFreezeKillOverride = 615007u,
    /// <summary>Global Control Freeze Crash Override</summary>
    GlobalControlFreezeCrashOverride = 615008u,
    /// <summary>Global Control Malfunction Active</summary>
    GlobalControlMalfunctionActive = 615009u,
    /// <summary>Global Control Malfunction Clear</summary>
    GlobalControlMalfunctionClear = 615010u,
    /// <summary>Global Control Start Devices</summary>
    GlobalControlStartDevices = 615011u,
    /// <summary>Global Control Freeze Devices</summary>
    GlobalControlFreezeDevices = 615012u,
    /// <summary>Global Control JTIDS Command</summary>
    GlobalControlJtidsCommand = 615013u,
    /// <summary>Network Station IC Set Information</summary>
    NetworkStationIcSetInformation = 615015u,
    /// <summary>Global Control Reset IC Set</summary>
    GlobalControlResetIcSet = 615017u,
    /// <summary>Number of Controlling Units</summary>
    NumberOfControllingUnits = 615018u,
    /// <summary>Network Station JTIDS Controlling Units</summary>
    NetworkStationJtidsControllingUnits = 615019u,
    /// <summary>Network Station JTIDS Objective Tracks</summary>
    NetworkStationJtidsObjectiveTracks = 615020u,
    /// <summary>Number of Reference Objects</summary>
    NumberOfReferenceObjects = 615021u,
    /// <summary>Network Station JTIDS Reference Objects</summary>
    NetworkStationJtidsReferenceObjects = 615022u,
    /// <summary>Networked Station Still Under Control</summary>
    NetworkedStationStillUnderControl = 615023u,
    /// <summary>Global Control Delete Threat Entities</summary>
    GlobalControlDeleteThreatEntities = 615024u,
    /// <summary>Network Station Ownship Callsigns</summary>
    NetworkStationOwnshipCallsigns = 615025u,
    /// <summary>Global Control Request Formation Library Data</summary>
    GlobalControlRequestFormationLibraryData = 615026u,
    /// <summary>Total Number Formation Library PDUs</summary>
    TotalNumberFormationLibraryPDUs615027 = 615027u,
    /// <summary>PDU Number in Formation Library Response</summary>
    PduNumberInFormationLibraryResponse615028 = 615028u,
    /// <summary>Total Number Formation Library Items in PDUs</summary>
    TotalNumberFormationLibraryItemsInPDUs = 615029u,
    /// <summary>Network Station Formation Library Item</summary>
    NetworkStationFormationLibraryItem = 615030u,
    /// <summary>Global Control Add Relative Formation</summary>
    GlobalControlAddRelativeFormation = 615031u,
    /// <summary>Network Station TIC Filename</summary>
    NetworkStationTicFilename = 615032u,
    /// <summary>Global Control Freeze Warm-up Override</summary>
    GlobalControlFreezeWarmUpOverride = 615033u,
    /// <summary>Global Control Reload SES</summary>
    GlobalControlReloadSes = 615034u,
    /// <summary>Global Control Reload Weapons</summary>
    GlobalControlReloadWeapons = 615035u,
    /// <summary>Global Control Reload Expendables</summary>
    GlobalControlReloadExpendables = 615036u,
    /// <summary>Global Control Reload Fuel</summary>
    GlobalControlReloadFuel = 615037u,
    /// <summary>Global Control Reload Firebottle</summary>
    GlobalControlReloadFirebottle = 615038u,
    /// <summary>Test Pattern (DORT)</summary>
    TestPatternDort = 700000u,
    /// <summary>Audio Test (DORT)</summary>
    AudioTestDort = 700001u,
    /// <summary>Audio Tone (DORT)</summary>
    AudioToneDort = 700002u,
    /// <summary>Calibrate Throttles (DORT)</summary>
    CalibrateThrottlesDort = 700003u,
    /// <summary>Operational Limits Event Report</summary>
    OperationalLimitsEventReport = 700004u,
    /// <summary>Operational Limits</summary>
    OperationalLimits = 700005u,
    /// <summary>Event Marker Message</summary>
    EventMarkerMessage = 1000620u,
    /// <summary>Receiver Aircraft Aero Model Data</summary>
    ReceiverAircraftAeroModelData = 2000000u,
    /// <summary>Tanker Aircraft Aero Model Data</summary>
    TankerAircraftAeroModelData = 2000010u,
    /// <summary>Boom Aircraft Aero Model Data</summary>
    BoomAircraftAeroModelData = 2000020u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData = 2000030u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000031 = 2000031u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000032 = 2000032u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000033 = 2000033u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000034 = 2000034u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000035 = 2000035u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000036 = 2000036u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000037 = 2000037u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000038 = 2000038u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000039 = 2000039u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000040 = 2000040u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000041 = 2000041u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000042 = 2000042u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000043 = 2000043u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000044 = 2000044u,
    /// <summary>Access to Image Generator Data</summary>
    AccessToImageGeneratorData2000045 = 2000045u,
    /// <summary>Host Load Number</summary>
    HostLoadNumber = 2000050u,
    /// <summary>Extended Fire Event Reports</summary>
    ExtendedFireEventReports = 5005001u,
    /// <summary>Battle Damage Assessment (BDA) Event Report</summary>
    BattleDamageAssessmentBdaEventReport = 5005002u,
    /// <summary>Extended Fire Event Launcher</summary>
    ExtendedFireEventLauncher = 5005003u,
    /// <summary>Extended Fire Event Missile</summary>
    ExtendedFireEventMissile = 5005006u,
    /// <summary>Extended Fire Event MRM Weapon</summary>
    ExtendedFireEventMrmWeapon = 5005008u,
    /// <summary>Extended Fire Event Gun Fire Control</summary>
    ExtendedFireEventGunFireControl = 5005009u,
    /// <summary>Extended Fire Event Bomb</summary>
    ExtendedFireEventBomb = 5005010u,
    /// <summary>Extended Fire Event Expendable</summary>
    ExtendedFireEventExpendable = 5005011u,
    /// <summary>Battle Damage Assessment</summary>
    BattleDamageAssessment = 5005012u,
    /// <summary>Extended Fire Pickle Event</summary>
    ExtendedFirePickleEvent = 5005014u,
    /// <summary>Radar Track Report</summary>
    RadarTrackReport = 5005055u,
    /// <summary>Jammer Report</summary>
    JammerReport = 5005060u,
    /// <summary>Jammer False Targets Report</summary>
    JammerFalseTargetsReport = 5005061u,
    /// <summary>Detect Event Report</summary>
    DetectEventReport = 5005063u,
    /// <summary>MALD Beam Report</summary>
    MaldBeamReport = 5005070u,
    /// <summary>Transmitter Radiation Volume</summary>
    [Obsolete("Deprecated by SISO-REF-010.")]
    TransmitterRadiationVolume = 5005080u,
    /// <summary>Transmitter Radiation Volume v2</summary>
    TransmitterRadiationVolumeV2 = 5005081u,
    /// <summary>Call State</summary>
    CallState = 5005100u,
    /// <summary>Call Endpoint Data</summary>
    CallEndpointData = 5005101u,
    /// <summary>Physical Network Definition</summary>
    PhysicalNetworkDefinition = 5007010u,
    /// <summary>Network Channel Definition</summary>
    NetworkChannelDefinition = 5007020u,
    /// <summary>Logical Network Definition</summary>
    LogicalNetworkDefinition = 5007030u,
    /// <summary>Logical Network - Entity Definition</summary>
    LogicalNetworkEntityDefinition = 5007040u,
    /// <summary>Physical Network - Entity Definition</summary>
    PhysicalNetworkEntityDefinition = 5007050u,
    /// <summary>C2 Message</summary>
    C2Message = 5008010u,
    /// <summary>Candidate Object</summary>
    CandidateObject = 5008020u,
    /// <summary>Set of Candidate Objects</summary>
    SetOfCandidateObjects = 5008030u,
    /// <summary>Bounded Region</summary>
    BoundedRegion = 5008040u,
    /// <summary>Angular Region</summary>
    AngularRegion = 5008050u,
    /// <summary>RoE Object</summary>
    RoEObject = 5008060u,
    /// <summary>Track Object</summary>
    TrackObject = 5008070u,
    /// <summary>Set of Track Objects</summary>
    SetOfTrackObjects = 5008080u,
    /// <summary>Logical Entity Definition</summary>
    LogicalEntityDefinition = 5009010u,
    /// <summary>Logical Entity Relationship Definition</summary>
    LogicalEntityRelationshipDefinition = 5009020u,
    /// <summary>Intent-Based EW Message</summary>
    IntentBasedEwMessage = 5507010u,
}


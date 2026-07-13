namespace OpenDisNet.Protocol;

public enum ProtocolFamily : byte
{
    Other = 0,
    EntityInformationInteraction = 1,
    Warfare = 2,
    Logistics = 3,
    RadioCommunications = 4,
    SimulationManagement = 5,
    DistributedEmissionRegeneration = 6,
    EntityManagement = 7,
    Minefield = 8,
    SyntheticEnvironment = 9,
    SimulationManagementWithReliability = 10,
    LiveEntity = 11,
    NonRealTime = 12,
    InformationOperations = 13,
    ExperimentalComputerGeneratedForces = 129,
    ExperimentalV2D = 130,
    PersistentObject = 140,
}

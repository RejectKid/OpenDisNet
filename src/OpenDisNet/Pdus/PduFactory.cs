// Factory for the 72 standardized DIS v7 PDU types.
using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

public static class PduFactory
{
    public static Pdu Create(PduType pduType, byte exerciseId = 0)
    {
        Pdu pdu = (byte)pduType switch
        {
            1 => new EntityStatePdu(),
            2 => new FirePdu(),
            3 => new DetonationPdu(),
            4 => new CollisionPdu(),
            5 => new ServiceRequestPdu(),
            6 => new ResupplyOfferPdu(),
            7 => new ResupplyReceivedPdu(),
            8 => new ResupplyCancelPdu(),
            9 => new RepairCompletePdu(),
            10 => new RepairResponsePdu(),
            11 => new CreateEntityPdu(),
            12 => new RemoveEntityPdu(),
            13 => new StartResumePdu(),
            14 => new StopFreezePdu(),
            15 => new AcknowledgePdu(),
            16 => new ActionRequestPdu(),
            17 => new ActionResponsePdu(),
            18 => new DataQueryPdu(),
            19 => new SetDataPdu(),
            20 => new DataPdu(),
            21 => new EventReportPdu(),
            22 => new CommentPdu(),
            23 => new ElectromagneticEmissionPdu(),
            24 => new DesignatorPdu(),
            25 => new TransmitterPdu(),
            26 => new SignalPdu(),
            27 => new ReceiverPdu(),
            28 => new IdentificationFriendOrFoePdu(),
            29 => new UnderwaterAcousticPdu(),
            30 => new SupplementalEmissionEntityStatePdu(),
            31 => new IntercomSignalPdu(),
            32 => new IntercomControlPdu(),
            33 => new AggregateStatePdu(),
            34 => new IsGroupOfPdu(),
            35 => new TransferOwnershipPdu(),
            36 => new IsPartOfPdu(),
            37 => new MinefieldStatePdu(),
            38 => new MinefieldQueryPdu(),
            39 => new MinefieldDataPdu(),
            40 => new MinefieldResponseNACKPdu(),
            41 => new EnvironmentalProcessPdu(),
            42 => new GriddedDataPdu(),
            43 => new PointObjectStatePdu(),
            44 => new LinearObjectStatePdu(),
            45 => new ArealObjectStatePdu(),
            46 => new TimeSpacePositionInformationPdu(),
            47 => new AppearancePdu(),
            48 => new ArticulatedPartsPdu(),
            49 => new LiveEntityFirePdu(),
            50 => new LiveEntityDetonationPdu(),
            51 => new CreateEntityReliablePdu(),
            52 => new RemoveEntityReliablePdu(),
            53 => new StartResumeReliablePdu(),
            54 => new StopFreezeReliablePdu(),
            55 => new AcknowledgeReliablePdu(),
            56 => new ActionRequestReliablePdu(),
            57 => new ActionResponseReliablePdu(),
            58 => new DataQueryReliablePdu(),
            59 => new SetDataReliablePdu(),
            60 => new DataReliablePdu(),
            61 => new EventReportReliablePdu(),
            62 => new CommentReliablePdu(),
            63 => new RecordReliablePdu(),
            64 => new SetRecordReliablePdu(),
            65 => new RecordQueryReliablePdu(),
            66 => new CollisionElasticPdu(),
            67 => new EntityStateUpdatePdu(),
            68 => new DirectedEnergyFirePdu(),
            69 => new EntityDamageStatusPdu(),
            70 => new InformationOperationsActionPdu(),
            71 => new InformationOperationsReportPdu(),
            72 => new AttributePdu(),
            _ => throw new ArgumentOutOfRangeException(nameof(pduType), pduType, "DIS v7 defines PDU types 1 through 72."),
        };

        pdu.ProtocolVersion = DisProtocolVersion.Ieee1278_1_2012;
        pdu.ExerciseId = exerciseId;
        pdu.PduType = pduType;
        pdu.ProtocolFamily = (ProtocolFamily)ProtocolFamilyFor((byte)pduType);
        if (pdu is PduBase body)
            body.PduStatus = new PduStatus();
        return pdu;
    }

    private static byte ProtocolFamilyFor(byte pduType) => pduType switch
    {
        1 or 4 or 66 or 67 or 72 => 1,
        2 or 3 or 68 or 69 => 2,
        5 or 6 or 7 or 8 or 9 or 10 => 3,
        25 or 26 or 27 or 31 or 32 => 4,
        11 or 12 or 13 or 14 or 15 or 16 or 17 or 18 or 19 or 20 or 21 or 22 => 5,
        23 or 24 or 28 or 29 or 30 => 6,
        33 or 34 or 35 or 36 => 7,
        37 or 38 or 39 or 40 => 8,
        41 or 42 or 43 or 44 or 45 => 9,
        51 or 52 or 53 or 54 or 55 or 56 or 57 or 58 or 59 or 60 or 61 or 62 or 63 or 64 or 65 => 10,
        46 or 47 or 48 or 49 or 50 => 11,
        70 or 71 => 13,
        _ => 0,
    };
}

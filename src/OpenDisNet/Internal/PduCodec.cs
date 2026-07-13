// DIS v7 binary codec. Every standardized PDU dispatch route is listed below.
using OpenDisNet.Binary;
using OpenDisNet.Enumerations;
using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

internal static partial class PduCodec
{
    public static Pdu Read(DisHeader header, ReadOnlySpan<byte> body)
    {
        Pdu value = PduFactory.Create(header.PduType, header.ExerciseId);
        ApplyHeader(value, header);
        var reader = new DisBinaryReader(body, DisHeader.Size);
        switch ((byte)header.PduType)
        {
            case 1:
                ReadEntityInformationInteractionFamilyPduFields(ref reader, (EntityStatePdu)value);
                ReadEntityStatePduFields(ref reader, (EntityStatePdu)value);
                break;
            case 2:
                ReadWarfareFamilyPduFields(ref reader, (FirePdu)value);
                ReadFirePduFields(ref reader, (FirePdu)value);
                break;
            case 3:
                ReadWarfareFamilyPduFields(ref reader, (DetonationPdu)value);
                ReadDetonationPduFields(ref reader, (DetonationPdu)value);
                break;
            case 4:
                ReadEntityInformationInteractionFamilyPduFields(ref reader, (CollisionPdu)value);
                ReadCollisionPduFields(ref reader, (CollisionPdu)value);
                break;
            case 5:
                ReadLogisticsFamilyPduFields(ref reader, (ServiceRequestPdu)value);
                ReadServiceRequestPduFields(ref reader, (ServiceRequestPdu)value);
                break;
            case 6:
                ReadLogisticsFamilyPduFields(ref reader, (ResupplyOfferPdu)value);
                ReadResupplyOfferPduFields(ref reader, (ResupplyOfferPdu)value);
                break;
            case 7:
                ReadLogisticsFamilyPduFields(ref reader, (ResupplyReceivedPdu)value);
                ReadResupplyReceivedPduFields(ref reader, (ResupplyReceivedPdu)value);
                break;
            case 8:
                ReadLogisticsFamilyPduFields(ref reader, (ResupplyCancelPdu)value);
                ReadResupplyCancelPduFields(ref reader, (ResupplyCancelPdu)value);
                break;
            case 9:
                ReadLogisticsFamilyPduFields(ref reader, (RepairCompletePdu)value);
                ReadRepairCompletePduFields(ref reader, (RepairCompletePdu)value);
                break;
            case 10:
                ReadLogisticsFamilyPduFields(ref reader, (RepairResponsePdu)value);
                ReadRepairResponsePduFields(ref reader, (RepairResponsePdu)value);
                break;
            case 11:
                ReadSimulationManagementFamilyPduFields(ref reader, (CreateEntityPdu)value);
                ReadCreateEntityPduFields(ref reader, (CreateEntityPdu)value);
                break;
            case 12:
                ReadSimulationManagementFamilyPduFields(ref reader, (RemoveEntityPdu)value);
                ReadRemoveEntityPduFields(ref reader, (RemoveEntityPdu)value);
                break;
            case 13:
                ReadSimulationManagementFamilyPduFields(ref reader, (StartResumePdu)value);
                ReadStartResumePduFields(ref reader, (StartResumePdu)value);
                break;
            case 14:
                ReadSimulationManagementFamilyPduFields(ref reader, (StopFreezePdu)value);
                ReadStopFreezePduFields(ref reader, (StopFreezePdu)value);
                break;
            case 15:
                ReadSimulationManagementFamilyPduFields(ref reader, (AcknowledgePdu)value);
                ReadAcknowledgePduFields(ref reader, (AcknowledgePdu)value);
                break;
            case 16:
                ReadSimulationManagementFamilyPduFields(ref reader, (ActionRequestPdu)value);
                ReadActionRequestPduFields(ref reader, (ActionRequestPdu)value);
                break;
            case 17:
                ReadSimulationManagementFamilyPduFields(ref reader, (ActionResponsePdu)value);
                ReadActionResponsePduFields(ref reader, (ActionResponsePdu)value);
                break;
            case 18:
                ReadSimulationManagementFamilyPduFields(ref reader, (DataQueryPdu)value);
                ReadDataQueryPduFields(ref reader, (DataQueryPdu)value);
                break;
            case 19:
                ReadSimulationManagementFamilyPduFields(ref reader, (SetDataPdu)value);
                ReadSetDataPduFields(ref reader, (SetDataPdu)value);
                break;
            case 20:
                ReadSimulationManagementFamilyPduFields(ref reader, (DataPdu)value);
                ReadDataPduFields(ref reader, (DataPdu)value);
                break;
            case 21:
                ReadSimulationManagementFamilyPduFields(ref reader, (EventReportPdu)value);
                ReadEventReportPduFields(ref reader, (EventReportPdu)value);
                break;
            case 22:
                ReadSimulationManagementFamilyPduFields(ref reader, (CommentPdu)value);
                ReadCommentPduFields(ref reader, (CommentPdu)value);
                break;
            case 23:
                ReadDistributedEmissionsRegenerationFamilyPduFields(ref reader, (ElectromagneticEmissionPdu)value);
                ReadElectromagneticEmissionPduFields(ref reader, (ElectromagneticEmissionPdu)value);
                break;
            case 24:
                ReadDistributedEmissionsRegenerationFamilyPduFields(ref reader, (DesignatorPdu)value);
                ReadDesignatorPduFields(ref reader, (DesignatorPdu)value);
                break;
            case 25:
                ReadRadioCommunicationsFamilyPduFields(ref reader, (TransmitterPdu)value);
                ReadTransmitterPduFields(ref reader, (TransmitterPdu)value);
                break;
            case 26:
                ReadRadioCommunicationsFamilyPduFields(ref reader, (SignalPdu)value);
                ReadSignalPduFields(ref reader, (SignalPdu)value);
                break;
            case 27:
                ReadRadioCommunicationsFamilyPduFields(ref reader, (ReceiverPdu)value);
                ReadReceiverPduFields(ref reader, (ReceiverPdu)value);
                break;
            case 28:
                ReadDistributedEmissionsRegenerationFamilyPduFields(ref reader, (IdentificationFriendOrFoePdu)value);
                ReadIdentificationFriendOrFoePduFields(ref reader, (IdentificationFriendOrFoePdu)value);
                break;
            case 29:
                ReadDistributedEmissionsRegenerationFamilyPduFields(ref reader, (UnderwaterAcousticPdu)value);
                ReadUnderwaterAcousticPduFields(ref reader, (UnderwaterAcousticPdu)value);
                break;
            case 30:
                ReadDistributedEmissionsRegenerationFamilyPduFields(ref reader, (SupplementalEmissionEntityStatePdu)value);
                ReadSupplementalEmissionEntityStatePduFields(ref reader, (SupplementalEmissionEntityStatePdu)value);
                break;
            case 31:
                ReadRadioCommunicationsFamilyPduFields(ref reader, (IntercomSignalPdu)value);
                ReadIntercomSignalPduFields(ref reader, (IntercomSignalPdu)value);
                break;
            case 32:
                ReadRadioCommunicationsFamilyPduFields(ref reader, (IntercomControlPdu)value);
                ReadIntercomControlPduFields(ref reader, (IntercomControlPdu)value);
                break;
            case 33:
                ReadEntityManagementFamilyPduFields(ref reader, (AggregateStatePdu)value);
                ReadAggregateStatePduFields(ref reader, (AggregateStatePdu)value);
                break;
            case 34:
                ReadEntityManagementFamilyPduFields(ref reader, (IsGroupOfPdu)value);
                ReadIsGroupOfPduFields(ref reader, (IsGroupOfPdu)value);
                break;
            case 35:
                ReadEntityManagementFamilyPduFields(ref reader, (TransferOwnershipPdu)value);
                ReadTransferOwnershipPduFields(ref reader, (TransferOwnershipPdu)value);
                break;
            case 36:
                ReadEntityManagementFamilyPduFields(ref reader, (IsPartOfPdu)value);
                ReadIsPartOfPduFields(ref reader, (IsPartOfPdu)value);
                break;
            case 37:
                ReadMinefieldFamilyPduFields(ref reader, (MinefieldStatePdu)value);
                ReadMinefieldStatePduFields(ref reader, (MinefieldStatePdu)value);
                break;
            case 38:
                ReadMinefieldFamilyPduFields(ref reader, (MinefieldQueryPdu)value);
                ReadMinefieldQueryPduFields(ref reader, (MinefieldQueryPdu)value);
                break;
            case 39:
                ReadMinefieldFamilyPduFields(ref reader, (MinefieldDataPdu)value);
                ReadMinefieldDataPduFields(ref reader, (MinefieldDataPdu)value);
                break;
            case 40:
                ReadMinefieldFamilyPduFields(ref reader, (MinefieldResponseNACKPdu)value);
                ReadMinefieldResponseNACKPduFields(ref reader, (MinefieldResponseNACKPdu)value);
                break;
            case 41:
                ReadSyntheticEnvironmentFamilyPduFields(ref reader, (EnvironmentalProcessPdu)value);
                ReadEnvironmentalProcessPduFields(ref reader, (EnvironmentalProcessPdu)value);
                break;
            case 42:
                ReadSyntheticEnvironmentFamilyPduFields(ref reader, (GriddedDataPdu)value);
                ReadGriddedDataPduFields(ref reader, (GriddedDataPdu)value);
                break;
            case 43:
                ReadSyntheticEnvironmentFamilyPduFields(ref reader, (PointObjectStatePdu)value);
                ReadPointObjectStatePduFields(ref reader, (PointObjectStatePdu)value);
                break;
            case 44:
                ReadSyntheticEnvironmentFamilyPduFields(ref reader, (LinearObjectStatePdu)value);
                ReadLinearObjectStatePduFields(ref reader, (LinearObjectStatePdu)value);
                break;
            case 45:
                ReadSyntheticEnvironmentFamilyPduFields(ref reader, (ArealObjectStatePdu)value);
                ReadArealObjectStatePduFields(ref reader, (ArealObjectStatePdu)value);
                break;
            case 46:
                ReadLiveEntityFamilyPduFields(ref reader, (TimeSpacePositionInformationPdu)value);
                ReadTimeSpacePositionInformationPduFields(ref reader, (TimeSpacePositionInformationPdu)value);
                break;
            case 47:
                ReadLiveEntityFamilyPduFields(ref reader, (AppearancePdu)value);
                ReadAppearancePduFields(ref reader, (AppearancePdu)value);
                break;
            case 48:
                ReadLiveEntityFamilyPduFields(ref reader, (ArticulatedPartsPdu)value);
                ReadArticulatedPartsPduFields(ref reader, (ArticulatedPartsPdu)value);
                break;
            case 49:
                ReadLiveEntityFamilyPduFields(ref reader, (LiveEntityFirePdu)value);
                ReadLiveEntityFirePduFields(ref reader, (LiveEntityFirePdu)value);
                break;
            case 50:
                ReadLiveEntityFamilyPduFields(ref reader, (LiveEntityDetonationPdu)value);
                ReadLiveEntityDetonationPduFields(ref reader, (LiveEntityDetonationPdu)value);
                break;
            case 51:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (CreateEntityReliablePdu)value);
                ReadCreateEntityReliablePduFields(ref reader, (CreateEntityReliablePdu)value);
                break;
            case 52:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (RemoveEntityReliablePdu)value);
                ReadRemoveEntityReliablePduFields(ref reader, (RemoveEntityReliablePdu)value);
                break;
            case 53:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (StartResumeReliablePdu)value);
                ReadStartResumeReliablePduFields(ref reader, (StartResumeReliablePdu)value);
                break;
            case 54:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (StopFreezeReliablePdu)value);
                ReadStopFreezeReliablePduFields(ref reader, (StopFreezeReliablePdu)value);
                break;
            case 55:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (AcknowledgeReliablePdu)value);
                ReadAcknowledgeReliablePduFields(ref reader, (AcknowledgeReliablePdu)value);
                break;
            case 56:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (ActionRequestReliablePdu)value);
                ReadActionRequestReliablePduFields(ref reader, (ActionRequestReliablePdu)value);
                break;
            case 57:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (ActionResponseReliablePdu)value);
                ReadActionResponseReliablePduFields(ref reader, (ActionResponseReliablePdu)value);
                break;
            case 58:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (DataQueryReliablePdu)value);
                ReadDataQueryReliablePduFields(ref reader, (DataQueryReliablePdu)value);
                break;
            case 59:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (SetDataReliablePdu)value);
                ReadSetDataReliablePduFields(ref reader, (SetDataReliablePdu)value);
                break;
            case 60:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (DataReliablePdu)value);
                ReadDataReliablePduFields(ref reader, (DataReliablePdu)value);
                break;
            case 61:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (EventReportReliablePdu)value);
                ReadEventReportReliablePduFields(ref reader, (EventReportReliablePdu)value);
                break;
            case 62:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (CommentReliablePdu)value);
                ReadCommentReliablePduFields(ref reader, (CommentReliablePdu)value);
                break;
            case 63:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (RecordReliablePdu)value);
                ReadRecordReliablePduFields(ref reader, (RecordReliablePdu)value);
                break;
            case 64:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (SetRecordReliablePdu)value);
                ReadSetRecordReliablePduFields(ref reader, (SetRecordReliablePdu)value);
                break;
            case 65:
                ReadSimulationManagementWithReliabilityFamilyPduFields(ref reader, (RecordQueryReliablePdu)value);
                ReadRecordQueryReliablePduFields(ref reader, (RecordQueryReliablePdu)value);
                break;
            case 66:
                ReadEntityInformationInteractionFamilyPduFields(ref reader, (CollisionElasticPdu)value);
                ReadCollisionElasticPduFields(ref reader, (CollisionElasticPdu)value);
                break;
            case 67:
                ReadEntityInformationInteractionFamilyPduFields(ref reader, (EntityStateUpdatePdu)value);
                ReadEntityStateUpdatePduFields(ref reader, (EntityStateUpdatePdu)value);
                break;
            case 68:
                ReadWarfareFamilyPduFields(ref reader, (DirectedEnergyFirePdu)value);
                ReadDirectedEnergyFirePduFields(ref reader, (DirectedEnergyFirePdu)value);
                break;
            case 69:
                ReadWarfareFamilyPduFields(ref reader, (EntityDamageStatusPdu)value);
                ReadEntityDamageStatusPduFields(ref reader, (EntityDamageStatusPdu)value);
                break;
            case 70:
                ReadInformationOperationsFamilyPduFields(ref reader, (InformationOperationsActionPdu)value);
                ReadInformationOperationsActionPduFields(ref reader, (InformationOperationsActionPdu)value);
                break;
            case 71:
                ReadInformationOperationsFamilyPduFields(ref reader, (InformationOperationsReportPdu)value);
                ReadInformationOperationsReportPduFields(ref reader, (InformationOperationsReportPdu)value);
                break;
            case 72:
                ReadEntityInformationInteractionFamilyPduFields(ref reader, (AttributePdu)value);
                ReadAttributePduFields(ref reader, (AttributePdu)value);
                break;
        }
        if (reader.Remaining != 0)
            throw new FormatException($"{reader.Remaining} unread bytes remain after decoding {header.PduType}.");
        return value;
    }

    public static int GetEncodedLength(Pdu value)
    {
        ArgumentNullException.ThrowIfNull(value);
        Prepare(value);
        int offset = DisHeader.Size;
        MeasureBody(value, ref offset);
        return offset;
    }

    public static byte[] Write(Pdu value)
    {
        int length = GetEncodedLength(value);
        byte[] bytes = new byte[length];
        Write(value, bytes);
        return bytes;
    }

    public static int Write(Pdu value, Span<byte> destination)
    {
        int length = GetEncodedLength(value);
        if (length > ushort.MaxValue) throw new ArgumentOutOfRangeException(nameof(value), "A DIS PDU cannot exceed 65,535 bytes.");
        if (destination.Length < length) throw new ArgumentException($"Destination requires {length} bytes.", nameof(destination));
        value.Length = (ushort)length;
        var writer = new DisBinaryWriter(destination[..length]);
        DisHeaderCodec.Write(ref writer, value.Header);
        WriteBody(value, ref writer);
        return writer.Offset;
    }

    private static void Prepare(Pdu value)
    {
        switch ((byte)value.PduType)
        {
            case 1:
                PrepareEntityInformationInteractionFamilyPduFields((EntityStatePdu)value);
                PrepareEntityStatePduFields((EntityStatePdu)value);
                break;
            case 2:
                PrepareWarfareFamilyPduFields((FirePdu)value);
                PrepareFirePduFields((FirePdu)value);
                break;
            case 3:
                PrepareWarfareFamilyPduFields((DetonationPdu)value);
                PrepareDetonationPduFields((DetonationPdu)value);
                break;
            case 4:
                PrepareEntityInformationInteractionFamilyPduFields((CollisionPdu)value);
                PrepareCollisionPduFields((CollisionPdu)value);
                break;
            case 5:
                PrepareLogisticsFamilyPduFields((ServiceRequestPdu)value);
                PrepareServiceRequestPduFields((ServiceRequestPdu)value);
                break;
            case 6:
                PrepareLogisticsFamilyPduFields((ResupplyOfferPdu)value);
                PrepareResupplyOfferPduFields((ResupplyOfferPdu)value);
                break;
            case 7:
                PrepareLogisticsFamilyPduFields((ResupplyReceivedPdu)value);
                PrepareResupplyReceivedPduFields((ResupplyReceivedPdu)value);
                break;
            case 8:
                PrepareLogisticsFamilyPduFields((ResupplyCancelPdu)value);
                PrepareResupplyCancelPduFields((ResupplyCancelPdu)value);
                break;
            case 9:
                PrepareLogisticsFamilyPduFields((RepairCompletePdu)value);
                PrepareRepairCompletePduFields((RepairCompletePdu)value);
                break;
            case 10:
                PrepareLogisticsFamilyPduFields((RepairResponsePdu)value);
                PrepareRepairResponsePduFields((RepairResponsePdu)value);
                break;
            case 11:
                PrepareSimulationManagementFamilyPduFields((CreateEntityPdu)value);
                PrepareCreateEntityPduFields((CreateEntityPdu)value);
                break;
            case 12:
                PrepareSimulationManagementFamilyPduFields((RemoveEntityPdu)value);
                PrepareRemoveEntityPduFields((RemoveEntityPdu)value);
                break;
            case 13:
                PrepareSimulationManagementFamilyPduFields((StartResumePdu)value);
                PrepareStartResumePduFields((StartResumePdu)value);
                break;
            case 14:
                PrepareSimulationManagementFamilyPduFields((StopFreezePdu)value);
                PrepareStopFreezePduFields((StopFreezePdu)value);
                break;
            case 15:
                PrepareSimulationManagementFamilyPduFields((AcknowledgePdu)value);
                PrepareAcknowledgePduFields((AcknowledgePdu)value);
                break;
            case 16:
                PrepareSimulationManagementFamilyPduFields((ActionRequestPdu)value);
                PrepareActionRequestPduFields((ActionRequestPdu)value);
                break;
            case 17:
                PrepareSimulationManagementFamilyPduFields((ActionResponsePdu)value);
                PrepareActionResponsePduFields((ActionResponsePdu)value);
                break;
            case 18:
                PrepareSimulationManagementFamilyPduFields((DataQueryPdu)value);
                PrepareDataQueryPduFields((DataQueryPdu)value);
                break;
            case 19:
                PrepareSimulationManagementFamilyPduFields((SetDataPdu)value);
                PrepareSetDataPduFields((SetDataPdu)value);
                break;
            case 20:
                PrepareSimulationManagementFamilyPduFields((DataPdu)value);
                PrepareDataPduFields((DataPdu)value);
                break;
            case 21:
                PrepareSimulationManagementFamilyPduFields((EventReportPdu)value);
                PrepareEventReportPduFields((EventReportPdu)value);
                break;
            case 22:
                PrepareSimulationManagementFamilyPduFields((CommentPdu)value);
                PrepareCommentPduFields((CommentPdu)value);
                break;
            case 23:
                PrepareDistributedEmissionsRegenerationFamilyPduFields((ElectromagneticEmissionPdu)value);
                PrepareElectromagneticEmissionPduFields((ElectromagneticEmissionPdu)value);
                break;
            case 24:
                PrepareDistributedEmissionsRegenerationFamilyPduFields((DesignatorPdu)value);
                PrepareDesignatorPduFields((DesignatorPdu)value);
                break;
            case 25:
                PrepareRadioCommunicationsFamilyPduFields((TransmitterPdu)value);
                PrepareTransmitterPduFields((TransmitterPdu)value);
                break;
            case 26:
                PrepareRadioCommunicationsFamilyPduFields((SignalPdu)value);
                PrepareSignalPduFields((SignalPdu)value);
                break;
            case 27:
                PrepareRadioCommunicationsFamilyPduFields((ReceiverPdu)value);
                PrepareReceiverPduFields((ReceiverPdu)value);
                break;
            case 28:
                PrepareDistributedEmissionsRegenerationFamilyPduFields((IdentificationFriendOrFoePdu)value);
                PrepareIdentificationFriendOrFoePduFields((IdentificationFriendOrFoePdu)value);
                break;
            case 29:
                PrepareDistributedEmissionsRegenerationFamilyPduFields((UnderwaterAcousticPdu)value);
                PrepareUnderwaterAcousticPduFields((UnderwaterAcousticPdu)value);
                break;
            case 30:
                PrepareDistributedEmissionsRegenerationFamilyPduFields((SupplementalEmissionEntityStatePdu)value);
                PrepareSupplementalEmissionEntityStatePduFields((SupplementalEmissionEntityStatePdu)value);
                break;
            case 31:
                PrepareRadioCommunicationsFamilyPduFields((IntercomSignalPdu)value);
                PrepareIntercomSignalPduFields((IntercomSignalPdu)value);
                break;
            case 32:
                PrepareRadioCommunicationsFamilyPduFields((IntercomControlPdu)value);
                PrepareIntercomControlPduFields((IntercomControlPdu)value);
                break;
            case 33:
                PrepareEntityManagementFamilyPduFields((AggregateStatePdu)value);
                PrepareAggregateStatePduFields((AggregateStatePdu)value);
                break;
            case 34:
                PrepareEntityManagementFamilyPduFields((IsGroupOfPdu)value);
                PrepareIsGroupOfPduFields((IsGroupOfPdu)value);
                break;
            case 35:
                PrepareEntityManagementFamilyPduFields((TransferOwnershipPdu)value);
                PrepareTransferOwnershipPduFields((TransferOwnershipPdu)value);
                break;
            case 36:
                PrepareEntityManagementFamilyPduFields((IsPartOfPdu)value);
                PrepareIsPartOfPduFields((IsPartOfPdu)value);
                break;
            case 37:
                PrepareMinefieldFamilyPduFields((MinefieldStatePdu)value);
                PrepareMinefieldStatePduFields((MinefieldStatePdu)value);
                break;
            case 38:
                PrepareMinefieldFamilyPduFields((MinefieldQueryPdu)value);
                PrepareMinefieldQueryPduFields((MinefieldQueryPdu)value);
                break;
            case 39:
                PrepareMinefieldFamilyPduFields((MinefieldDataPdu)value);
                PrepareMinefieldDataPduFields((MinefieldDataPdu)value);
                break;
            case 40:
                PrepareMinefieldFamilyPduFields((MinefieldResponseNACKPdu)value);
                PrepareMinefieldResponseNACKPduFields((MinefieldResponseNACKPdu)value);
                break;
            case 41:
                PrepareSyntheticEnvironmentFamilyPduFields((EnvironmentalProcessPdu)value);
                PrepareEnvironmentalProcessPduFields((EnvironmentalProcessPdu)value);
                break;
            case 42:
                PrepareSyntheticEnvironmentFamilyPduFields((GriddedDataPdu)value);
                PrepareGriddedDataPduFields((GriddedDataPdu)value);
                break;
            case 43:
                PrepareSyntheticEnvironmentFamilyPduFields((PointObjectStatePdu)value);
                PreparePointObjectStatePduFields((PointObjectStatePdu)value);
                break;
            case 44:
                PrepareSyntheticEnvironmentFamilyPduFields((LinearObjectStatePdu)value);
                PrepareLinearObjectStatePduFields((LinearObjectStatePdu)value);
                break;
            case 45:
                PrepareSyntheticEnvironmentFamilyPduFields((ArealObjectStatePdu)value);
                PrepareArealObjectStatePduFields((ArealObjectStatePdu)value);
                break;
            case 46:
                PrepareLiveEntityFamilyPduFields((TimeSpacePositionInformationPdu)value);
                PrepareTimeSpacePositionInformationPduFields((TimeSpacePositionInformationPdu)value);
                break;
            case 47:
                PrepareLiveEntityFamilyPduFields((AppearancePdu)value);
                PrepareAppearancePduFields((AppearancePdu)value);
                break;
            case 48:
                PrepareLiveEntityFamilyPduFields((ArticulatedPartsPdu)value);
                PrepareArticulatedPartsPduFields((ArticulatedPartsPdu)value);
                break;
            case 49:
                PrepareLiveEntityFamilyPduFields((LiveEntityFirePdu)value);
                PrepareLiveEntityFirePduFields((LiveEntityFirePdu)value);
                break;
            case 50:
                PrepareLiveEntityFamilyPduFields((LiveEntityDetonationPdu)value);
                PrepareLiveEntityDetonationPduFields((LiveEntityDetonationPdu)value);
                break;
            case 51:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((CreateEntityReliablePdu)value);
                PrepareCreateEntityReliablePduFields((CreateEntityReliablePdu)value);
                break;
            case 52:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((RemoveEntityReliablePdu)value);
                PrepareRemoveEntityReliablePduFields((RemoveEntityReliablePdu)value);
                break;
            case 53:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((StartResumeReliablePdu)value);
                PrepareStartResumeReliablePduFields((StartResumeReliablePdu)value);
                break;
            case 54:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((StopFreezeReliablePdu)value);
                PrepareStopFreezeReliablePduFields((StopFreezeReliablePdu)value);
                break;
            case 55:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((AcknowledgeReliablePdu)value);
                PrepareAcknowledgeReliablePduFields((AcknowledgeReliablePdu)value);
                break;
            case 56:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((ActionRequestReliablePdu)value);
                PrepareActionRequestReliablePduFields((ActionRequestReliablePdu)value);
                break;
            case 57:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((ActionResponseReliablePdu)value);
                PrepareActionResponseReliablePduFields((ActionResponseReliablePdu)value);
                break;
            case 58:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((DataQueryReliablePdu)value);
                PrepareDataQueryReliablePduFields((DataQueryReliablePdu)value);
                break;
            case 59:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((SetDataReliablePdu)value);
                PrepareSetDataReliablePduFields((SetDataReliablePdu)value);
                break;
            case 60:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((DataReliablePdu)value);
                PrepareDataReliablePduFields((DataReliablePdu)value);
                break;
            case 61:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((EventReportReliablePdu)value);
                PrepareEventReportReliablePduFields((EventReportReliablePdu)value);
                break;
            case 62:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((CommentReliablePdu)value);
                PrepareCommentReliablePduFields((CommentReliablePdu)value);
                break;
            case 63:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((RecordReliablePdu)value);
                PrepareRecordReliablePduFields((RecordReliablePdu)value);
                break;
            case 64:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((SetRecordReliablePdu)value);
                PrepareSetRecordReliablePduFields((SetRecordReliablePdu)value);
                break;
            case 65:
                PrepareSimulationManagementWithReliabilityFamilyPduFields((RecordQueryReliablePdu)value);
                PrepareRecordQueryReliablePduFields((RecordQueryReliablePdu)value);
                break;
            case 66:
                PrepareEntityInformationInteractionFamilyPduFields((CollisionElasticPdu)value);
                PrepareCollisionElasticPduFields((CollisionElasticPdu)value);
                break;
            case 67:
                PrepareEntityInformationInteractionFamilyPduFields((EntityStateUpdatePdu)value);
                PrepareEntityStateUpdatePduFields((EntityStateUpdatePdu)value);
                break;
            case 68:
                PrepareWarfareFamilyPduFields((DirectedEnergyFirePdu)value);
                PrepareDirectedEnergyFirePduFields((DirectedEnergyFirePdu)value);
                break;
            case 69:
                PrepareWarfareFamilyPduFields((EntityDamageStatusPdu)value);
                PrepareEntityDamageStatusPduFields((EntityDamageStatusPdu)value);
                break;
            case 70:
                PrepareInformationOperationsFamilyPduFields((InformationOperationsActionPdu)value);
                PrepareInformationOperationsActionPduFields((InformationOperationsActionPdu)value);
                break;
            case 71:
                PrepareInformationOperationsFamilyPduFields((InformationOperationsReportPdu)value);
                PrepareInformationOperationsReportPduFields((InformationOperationsReportPdu)value);
                break;
            case 72:
                PrepareEntityInformationInteractionFamilyPduFields((AttributePdu)value);
                PrepareAttributePduFields((AttributePdu)value);
                break;
            default: throw new ArgumentOutOfRangeException(nameof(value), value.PduType, "DIS v7 defines PDU types 1 through 72.");
        }
    }

    private static void WriteBody(Pdu value, ref DisBinaryWriter writer)
    {
        switch ((byte)value.PduType)
        {
            case 1:
                WriteEntityInformationInteractionFamilyPduFields(ref writer, (EntityStatePdu)value);
                WriteEntityStatePduFields(ref writer, (EntityStatePdu)value);
                break;
            case 2:
                WriteWarfareFamilyPduFields(ref writer, (FirePdu)value);
                WriteFirePduFields(ref writer, (FirePdu)value);
                break;
            case 3:
                WriteWarfareFamilyPduFields(ref writer, (DetonationPdu)value);
                WriteDetonationPduFields(ref writer, (DetonationPdu)value);
                break;
            case 4:
                WriteEntityInformationInteractionFamilyPduFields(ref writer, (CollisionPdu)value);
                WriteCollisionPduFields(ref writer, (CollisionPdu)value);
                break;
            case 5:
                WriteLogisticsFamilyPduFields(ref writer, (ServiceRequestPdu)value);
                WriteServiceRequestPduFields(ref writer, (ServiceRequestPdu)value);
                break;
            case 6:
                WriteLogisticsFamilyPduFields(ref writer, (ResupplyOfferPdu)value);
                WriteResupplyOfferPduFields(ref writer, (ResupplyOfferPdu)value);
                break;
            case 7:
                WriteLogisticsFamilyPduFields(ref writer, (ResupplyReceivedPdu)value);
                WriteResupplyReceivedPduFields(ref writer, (ResupplyReceivedPdu)value);
                break;
            case 8:
                WriteLogisticsFamilyPduFields(ref writer, (ResupplyCancelPdu)value);
                WriteResupplyCancelPduFields(ref writer, (ResupplyCancelPdu)value);
                break;
            case 9:
                WriteLogisticsFamilyPduFields(ref writer, (RepairCompletePdu)value);
                WriteRepairCompletePduFields(ref writer, (RepairCompletePdu)value);
                break;
            case 10:
                WriteLogisticsFamilyPduFields(ref writer, (RepairResponsePdu)value);
                WriteRepairResponsePduFields(ref writer, (RepairResponsePdu)value);
                break;
            case 11:
                WriteSimulationManagementFamilyPduFields(ref writer, (CreateEntityPdu)value);
                WriteCreateEntityPduFields(ref writer, (CreateEntityPdu)value);
                break;
            case 12:
                WriteSimulationManagementFamilyPduFields(ref writer, (RemoveEntityPdu)value);
                WriteRemoveEntityPduFields(ref writer, (RemoveEntityPdu)value);
                break;
            case 13:
                WriteSimulationManagementFamilyPduFields(ref writer, (StartResumePdu)value);
                WriteStartResumePduFields(ref writer, (StartResumePdu)value);
                break;
            case 14:
                WriteSimulationManagementFamilyPduFields(ref writer, (StopFreezePdu)value);
                WriteStopFreezePduFields(ref writer, (StopFreezePdu)value);
                break;
            case 15:
                WriteSimulationManagementFamilyPduFields(ref writer, (AcknowledgePdu)value);
                WriteAcknowledgePduFields(ref writer, (AcknowledgePdu)value);
                break;
            case 16:
                WriteSimulationManagementFamilyPduFields(ref writer, (ActionRequestPdu)value);
                WriteActionRequestPduFields(ref writer, (ActionRequestPdu)value);
                break;
            case 17:
                WriteSimulationManagementFamilyPduFields(ref writer, (ActionResponsePdu)value);
                WriteActionResponsePduFields(ref writer, (ActionResponsePdu)value);
                break;
            case 18:
                WriteSimulationManagementFamilyPduFields(ref writer, (DataQueryPdu)value);
                WriteDataQueryPduFields(ref writer, (DataQueryPdu)value);
                break;
            case 19:
                WriteSimulationManagementFamilyPduFields(ref writer, (SetDataPdu)value);
                WriteSetDataPduFields(ref writer, (SetDataPdu)value);
                break;
            case 20:
                WriteSimulationManagementFamilyPduFields(ref writer, (DataPdu)value);
                WriteDataPduFields(ref writer, (DataPdu)value);
                break;
            case 21:
                WriteSimulationManagementFamilyPduFields(ref writer, (EventReportPdu)value);
                WriteEventReportPduFields(ref writer, (EventReportPdu)value);
                break;
            case 22:
                WriteSimulationManagementFamilyPduFields(ref writer, (CommentPdu)value);
                WriteCommentPduFields(ref writer, (CommentPdu)value);
                break;
            case 23:
                WriteDistributedEmissionsRegenerationFamilyPduFields(ref writer, (ElectromagneticEmissionPdu)value);
                WriteElectromagneticEmissionPduFields(ref writer, (ElectromagneticEmissionPdu)value);
                break;
            case 24:
                WriteDistributedEmissionsRegenerationFamilyPduFields(ref writer, (DesignatorPdu)value);
                WriteDesignatorPduFields(ref writer, (DesignatorPdu)value);
                break;
            case 25:
                WriteRadioCommunicationsFamilyPduFields(ref writer, (TransmitterPdu)value);
                WriteTransmitterPduFields(ref writer, (TransmitterPdu)value);
                break;
            case 26:
                WriteRadioCommunicationsFamilyPduFields(ref writer, (SignalPdu)value);
                WriteSignalPduFields(ref writer, (SignalPdu)value);
                break;
            case 27:
                WriteRadioCommunicationsFamilyPduFields(ref writer, (ReceiverPdu)value);
                WriteReceiverPduFields(ref writer, (ReceiverPdu)value);
                break;
            case 28:
                WriteDistributedEmissionsRegenerationFamilyPduFields(ref writer, (IdentificationFriendOrFoePdu)value);
                WriteIdentificationFriendOrFoePduFields(ref writer, (IdentificationFriendOrFoePdu)value);
                break;
            case 29:
                WriteDistributedEmissionsRegenerationFamilyPduFields(ref writer, (UnderwaterAcousticPdu)value);
                WriteUnderwaterAcousticPduFields(ref writer, (UnderwaterAcousticPdu)value);
                break;
            case 30:
                WriteDistributedEmissionsRegenerationFamilyPduFields(ref writer, (SupplementalEmissionEntityStatePdu)value);
                WriteSupplementalEmissionEntityStatePduFields(ref writer, (SupplementalEmissionEntityStatePdu)value);
                break;
            case 31:
                WriteRadioCommunicationsFamilyPduFields(ref writer, (IntercomSignalPdu)value);
                WriteIntercomSignalPduFields(ref writer, (IntercomSignalPdu)value);
                break;
            case 32:
                WriteRadioCommunicationsFamilyPduFields(ref writer, (IntercomControlPdu)value);
                WriteIntercomControlPduFields(ref writer, (IntercomControlPdu)value);
                break;
            case 33:
                WriteEntityManagementFamilyPduFields(ref writer, (AggregateStatePdu)value);
                WriteAggregateStatePduFields(ref writer, (AggregateStatePdu)value);
                break;
            case 34:
                WriteEntityManagementFamilyPduFields(ref writer, (IsGroupOfPdu)value);
                WriteIsGroupOfPduFields(ref writer, (IsGroupOfPdu)value);
                break;
            case 35:
                WriteEntityManagementFamilyPduFields(ref writer, (TransferOwnershipPdu)value);
                WriteTransferOwnershipPduFields(ref writer, (TransferOwnershipPdu)value);
                break;
            case 36:
                WriteEntityManagementFamilyPduFields(ref writer, (IsPartOfPdu)value);
                WriteIsPartOfPduFields(ref writer, (IsPartOfPdu)value);
                break;
            case 37:
                WriteMinefieldFamilyPduFields(ref writer, (MinefieldStatePdu)value);
                WriteMinefieldStatePduFields(ref writer, (MinefieldStatePdu)value);
                break;
            case 38:
                WriteMinefieldFamilyPduFields(ref writer, (MinefieldQueryPdu)value);
                WriteMinefieldQueryPduFields(ref writer, (MinefieldQueryPdu)value);
                break;
            case 39:
                WriteMinefieldFamilyPduFields(ref writer, (MinefieldDataPdu)value);
                WriteMinefieldDataPduFields(ref writer, (MinefieldDataPdu)value);
                break;
            case 40:
                WriteMinefieldFamilyPduFields(ref writer, (MinefieldResponseNACKPdu)value);
                WriteMinefieldResponseNACKPduFields(ref writer, (MinefieldResponseNACKPdu)value);
                break;
            case 41:
                WriteSyntheticEnvironmentFamilyPduFields(ref writer, (EnvironmentalProcessPdu)value);
                WriteEnvironmentalProcessPduFields(ref writer, (EnvironmentalProcessPdu)value);
                break;
            case 42:
                WriteSyntheticEnvironmentFamilyPduFields(ref writer, (GriddedDataPdu)value);
                WriteGriddedDataPduFields(ref writer, (GriddedDataPdu)value);
                break;
            case 43:
                WriteSyntheticEnvironmentFamilyPduFields(ref writer, (PointObjectStatePdu)value);
                WritePointObjectStatePduFields(ref writer, (PointObjectStatePdu)value);
                break;
            case 44:
                WriteSyntheticEnvironmentFamilyPduFields(ref writer, (LinearObjectStatePdu)value);
                WriteLinearObjectStatePduFields(ref writer, (LinearObjectStatePdu)value);
                break;
            case 45:
                WriteSyntheticEnvironmentFamilyPduFields(ref writer, (ArealObjectStatePdu)value);
                WriteArealObjectStatePduFields(ref writer, (ArealObjectStatePdu)value);
                break;
            case 46:
                WriteLiveEntityFamilyPduFields(ref writer, (TimeSpacePositionInformationPdu)value);
                WriteTimeSpacePositionInformationPduFields(ref writer, (TimeSpacePositionInformationPdu)value);
                break;
            case 47:
                WriteLiveEntityFamilyPduFields(ref writer, (AppearancePdu)value);
                WriteAppearancePduFields(ref writer, (AppearancePdu)value);
                break;
            case 48:
                WriteLiveEntityFamilyPduFields(ref writer, (ArticulatedPartsPdu)value);
                WriteArticulatedPartsPduFields(ref writer, (ArticulatedPartsPdu)value);
                break;
            case 49:
                WriteLiveEntityFamilyPduFields(ref writer, (LiveEntityFirePdu)value);
                WriteLiveEntityFirePduFields(ref writer, (LiveEntityFirePdu)value);
                break;
            case 50:
                WriteLiveEntityFamilyPduFields(ref writer, (LiveEntityDetonationPdu)value);
                WriteLiveEntityDetonationPduFields(ref writer, (LiveEntityDetonationPdu)value);
                break;
            case 51:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (CreateEntityReliablePdu)value);
                WriteCreateEntityReliablePduFields(ref writer, (CreateEntityReliablePdu)value);
                break;
            case 52:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (RemoveEntityReliablePdu)value);
                WriteRemoveEntityReliablePduFields(ref writer, (RemoveEntityReliablePdu)value);
                break;
            case 53:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (StartResumeReliablePdu)value);
                WriteStartResumeReliablePduFields(ref writer, (StartResumeReliablePdu)value);
                break;
            case 54:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (StopFreezeReliablePdu)value);
                WriteStopFreezeReliablePduFields(ref writer, (StopFreezeReliablePdu)value);
                break;
            case 55:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (AcknowledgeReliablePdu)value);
                WriteAcknowledgeReliablePduFields(ref writer, (AcknowledgeReliablePdu)value);
                break;
            case 56:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (ActionRequestReliablePdu)value);
                WriteActionRequestReliablePduFields(ref writer, (ActionRequestReliablePdu)value);
                break;
            case 57:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (ActionResponseReliablePdu)value);
                WriteActionResponseReliablePduFields(ref writer, (ActionResponseReliablePdu)value);
                break;
            case 58:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (DataQueryReliablePdu)value);
                WriteDataQueryReliablePduFields(ref writer, (DataQueryReliablePdu)value);
                break;
            case 59:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (SetDataReliablePdu)value);
                WriteSetDataReliablePduFields(ref writer, (SetDataReliablePdu)value);
                break;
            case 60:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (DataReliablePdu)value);
                WriteDataReliablePduFields(ref writer, (DataReliablePdu)value);
                break;
            case 61:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (EventReportReliablePdu)value);
                WriteEventReportReliablePduFields(ref writer, (EventReportReliablePdu)value);
                break;
            case 62:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (CommentReliablePdu)value);
                WriteCommentReliablePduFields(ref writer, (CommentReliablePdu)value);
                break;
            case 63:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (RecordReliablePdu)value);
                WriteRecordReliablePduFields(ref writer, (RecordReliablePdu)value);
                break;
            case 64:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (SetRecordReliablePdu)value);
                WriteSetRecordReliablePduFields(ref writer, (SetRecordReliablePdu)value);
                break;
            case 65:
                WriteSimulationManagementWithReliabilityFamilyPduFields(ref writer, (RecordQueryReliablePdu)value);
                WriteRecordQueryReliablePduFields(ref writer, (RecordQueryReliablePdu)value);
                break;
            case 66:
                WriteEntityInformationInteractionFamilyPduFields(ref writer, (CollisionElasticPdu)value);
                WriteCollisionElasticPduFields(ref writer, (CollisionElasticPdu)value);
                break;
            case 67:
                WriteEntityInformationInteractionFamilyPduFields(ref writer, (EntityStateUpdatePdu)value);
                WriteEntityStateUpdatePduFields(ref writer, (EntityStateUpdatePdu)value);
                break;
            case 68:
                WriteWarfareFamilyPduFields(ref writer, (DirectedEnergyFirePdu)value);
                WriteDirectedEnergyFirePduFields(ref writer, (DirectedEnergyFirePdu)value);
                break;
            case 69:
                WriteWarfareFamilyPduFields(ref writer, (EntityDamageStatusPdu)value);
                WriteEntityDamageStatusPduFields(ref writer, (EntityDamageStatusPdu)value);
                break;
            case 70:
                WriteInformationOperationsFamilyPduFields(ref writer, (InformationOperationsActionPdu)value);
                WriteInformationOperationsActionPduFields(ref writer, (InformationOperationsActionPdu)value);
                break;
            case 71:
                WriteInformationOperationsFamilyPduFields(ref writer, (InformationOperationsReportPdu)value);
                WriteInformationOperationsReportPduFields(ref writer, (InformationOperationsReportPdu)value);
                break;
            case 72:
                WriteEntityInformationInteractionFamilyPduFields(ref writer, (AttributePdu)value);
                WriteAttributePduFields(ref writer, (AttributePdu)value);
                break;
            default: throw new ArgumentOutOfRangeException(nameof(value), value.PduType, "DIS v7 defines PDU types 1 through 72.");
        }
    }

    private static void MeasureBody(Pdu value, ref int offset)
    {
        switch ((byte)value.PduType)
        {
            case 1:
                MeasureEntityInformationInteractionFamilyPduFields((EntityStatePdu)value, ref offset);
                MeasureEntityStatePduFields((EntityStatePdu)value, ref offset);
                break;
            case 2:
                MeasureWarfareFamilyPduFields((FirePdu)value, ref offset);
                MeasureFirePduFields((FirePdu)value, ref offset);
                break;
            case 3:
                MeasureWarfareFamilyPduFields((DetonationPdu)value, ref offset);
                MeasureDetonationPduFields((DetonationPdu)value, ref offset);
                break;
            case 4:
                MeasureEntityInformationInteractionFamilyPduFields((CollisionPdu)value, ref offset);
                MeasureCollisionPduFields((CollisionPdu)value, ref offset);
                break;
            case 5:
                MeasureLogisticsFamilyPduFields((ServiceRequestPdu)value, ref offset);
                MeasureServiceRequestPduFields((ServiceRequestPdu)value, ref offset);
                break;
            case 6:
                MeasureLogisticsFamilyPduFields((ResupplyOfferPdu)value, ref offset);
                MeasureResupplyOfferPduFields((ResupplyOfferPdu)value, ref offset);
                break;
            case 7:
                MeasureLogisticsFamilyPduFields((ResupplyReceivedPdu)value, ref offset);
                MeasureResupplyReceivedPduFields((ResupplyReceivedPdu)value, ref offset);
                break;
            case 8:
                MeasureLogisticsFamilyPduFields((ResupplyCancelPdu)value, ref offset);
                MeasureResupplyCancelPduFields((ResupplyCancelPdu)value, ref offset);
                break;
            case 9:
                MeasureLogisticsFamilyPduFields((RepairCompletePdu)value, ref offset);
                MeasureRepairCompletePduFields((RepairCompletePdu)value, ref offset);
                break;
            case 10:
                MeasureLogisticsFamilyPduFields((RepairResponsePdu)value, ref offset);
                MeasureRepairResponsePduFields((RepairResponsePdu)value, ref offset);
                break;
            case 11:
                MeasureSimulationManagementFamilyPduFields((CreateEntityPdu)value, ref offset);
                MeasureCreateEntityPduFields((CreateEntityPdu)value, ref offset);
                break;
            case 12:
                MeasureSimulationManagementFamilyPduFields((RemoveEntityPdu)value, ref offset);
                MeasureRemoveEntityPduFields((RemoveEntityPdu)value, ref offset);
                break;
            case 13:
                MeasureSimulationManagementFamilyPduFields((StartResumePdu)value, ref offset);
                MeasureStartResumePduFields((StartResumePdu)value, ref offset);
                break;
            case 14:
                MeasureSimulationManagementFamilyPduFields((StopFreezePdu)value, ref offset);
                MeasureStopFreezePduFields((StopFreezePdu)value, ref offset);
                break;
            case 15:
                MeasureSimulationManagementFamilyPduFields((AcknowledgePdu)value, ref offset);
                MeasureAcknowledgePduFields((AcknowledgePdu)value, ref offset);
                break;
            case 16:
                MeasureSimulationManagementFamilyPduFields((ActionRequestPdu)value, ref offset);
                MeasureActionRequestPduFields((ActionRequestPdu)value, ref offset);
                break;
            case 17:
                MeasureSimulationManagementFamilyPduFields((ActionResponsePdu)value, ref offset);
                MeasureActionResponsePduFields((ActionResponsePdu)value, ref offset);
                break;
            case 18:
                MeasureSimulationManagementFamilyPduFields((DataQueryPdu)value, ref offset);
                MeasureDataQueryPduFields((DataQueryPdu)value, ref offset);
                break;
            case 19:
                MeasureSimulationManagementFamilyPduFields((SetDataPdu)value, ref offset);
                MeasureSetDataPduFields((SetDataPdu)value, ref offset);
                break;
            case 20:
                MeasureSimulationManagementFamilyPduFields((DataPdu)value, ref offset);
                MeasureDataPduFields((DataPdu)value, ref offset);
                break;
            case 21:
                MeasureSimulationManagementFamilyPduFields((EventReportPdu)value, ref offset);
                MeasureEventReportPduFields((EventReportPdu)value, ref offset);
                break;
            case 22:
                MeasureSimulationManagementFamilyPduFields((CommentPdu)value, ref offset);
                MeasureCommentPduFields((CommentPdu)value, ref offset);
                break;
            case 23:
                MeasureDistributedEmissionsRegenerationFamilyPduFields((ElectromagneticEmissionPdu)value, ref offset);
                MeasureElectromagneticEmissionPduFields((ElectromagneticEmissionPdu)value, ref offset);
                break;
            case 24:
                MeasureDistributedEmissionsRegenerationFamilyPduFields((DesignatorPdu)value, ref offset);
                MeasureDesignatorPduFields((DesignatorPdu)value, ref offset);
                break;
            case 25:
                MeasureRadioCommunicationsFamilyPduFields((TransmitterPdu)value, ref offset);
                MeasureTransmitterPduFields((TransmitterPdu)value, ref offset);
                break;
            case 26:
                MeasureRadioCommunicationsFamilyPduFields((SignalPdu)value, ref offset);
                MeasureSignalPduFields((SignalPdu)value, ref offset);
                break;
            case 27:
                MeasureRadioCommunicationsFamilyPduFields((ReceiverPdu)value, ref offset);
                MeasureReceiverPduFields((ReceiverPdu)value, ref offset);
                break;
            case 28:
                MeasureDistributedEmissionsRegenerationFamilyPduFields((IdentificationFriendOrFoePdu)value, ref offset);
                MeasureIdentificationFriendOrFoePduFields((IdentificationFriendOrFoePdu)value, ref offset);
                break;
            case 29:
                MeasureDistributedEmissionsRegenerationFamilyPduFields((UnderwaterAcousticPdu)value, ref offset);
                MeasureUnderwaterAcousticPduFields((UnderwaterAcousticPdu)value, ref offset);
                break;
            case 30:
                MeasureDistributedEmissionsRegenerationFamilyPduFields((SupplementalEmissionEntityStatePdu)value, ref offset);
                MeasureSupplementalEmissionEntityStatePduFields((SupplementalEmissionEntityStatePdu)value, ref offset);
                break;
            case 31:
                MeasureRadioCommunicationsFamilyPduFields((IntercomSignalPdu)value, ref offset);
                MeasureIntercomSignalPduFields((IntercomSignalPdu)value, ref offset);
                break;
            case 32:
                MeasureRadioCommunicationsFamilyPduFields((IntercomControlPdu)value, ref offset);
                MeasureIntercomControlPduFields((IntercomControlPdu)value, ref offset);
                break;
            case 33:
                MeasureEntityManagementFamilyPduFields((AggregateStatePdu)value, ref offset);
                MeasureAggregateStatePduFields((AggregateStatePdu)value, ref offset);
                break;
            case 34:
                MeasureEntityManagementFamilyPduFields((IsGroupOfPdu)value, ref offset);
                MeasureIsGroupOfPduFields((IsGroupOfPdu)value, ref offset);
                break;
            case 35:
                MeasureEntityManagementFamilyPduFields((TransferOwnershipPdu)value, ref offset);
                MeasureTransferOwnershipPduFields((TransferOwnershipPdu)value, ref offset);
                break;
            case 36:
                MeasureEntityManagementFamilyPduFields((IsPartOfPdu)value, ref offset);
                MeasureIsPartOfPduFields((IsPartOfPdu)value, ref offset);
                break;
            case 37:
                MeasureMinefieldFamilyPduFields((MinefieldStatePdu)value, ref offset);
                MeasureMinefieldStatePduFields((MinefieldStatePdu)value, ref offset);
                break;
            case 38:
                MeasureMinefieldFamilyPduFields((MinefieldQueryPdu)value, ref offset);
                MeasureMinefieldQueryPduFields((MinefieldQueryPdu)value, ref offset);
                break;
            case 39:
                MeasureMinefieldFamilyPduFields((MinefieldDataPdu)value, ref offset);
                MeasureMinefieldDataPduFields((MinefieldDataPdu)value, ref offset);
                break;
            case 40:
                MeasureMinefieldFamilyPduFields((MinefieldResponseNACKPdu)value, ref offset);
                MeasureMinefieldResponseNACKPduFields((MinefieldResponseNACKPdu)value, ref offset);
                break;
            case 41:
                MeasureSyntheticEnvironmentFamilyPduFields((EnvironmentalProcessPdu)value, ref offset);
                MeasureEnvironmentalProcessPduFields((EnvironmentalProcessPdu)value, ref offset);
                break;
            case 42:
                MeasureSyntheticEnvironmentFamilyPduFields((GriddedDataPdu)value, ref offset);
                MeasureGriddedDataPduFields((GriddedDataPdu)value, ref offset);
                break;
            case 43:
                MeasureSyntheticEnvironmentFamilyPduFields((PointObjectStatePdu)value, ref offset);
                MeasurePointObjectStatePduFields((PointObjectStatePdu)value, ref offset);
                break;
            case 44:
                MeasureSyntheticEnvironmentFamilyPduFields((LinearObjectStatePdu)value, ref offset);
                MeasureLinearObjectStatePduFields((LinearObjectStatePdu)value, ref offset);
                break;
            case 45:
                MeasureSyntheticEnvironmentFamilyPduFields((ArealObjectStatePdu)value, ref offset);
                MeasureArealObjectStatePduFields((ArealObjectStatePdu)value, ref offset);
                break;
            case 46:
                MeasureLiveEntityFamilyPduFields((TimeSpacePositionInformationPdu)value, ref offset);
                MeasureTimeSpacePositionInformationPduFields((TimeSpacePositionInformationPdu)value, ref offset);
                break;
            case 47:
                MeasureLiveEntityFamilyPduFields((AppearancePdu)value, ref offset);
                MeasureAppearancePduFields((AppearancePdu)value, ref offset);
                break;
            case 48:
                MeasureLiveEntityFamilyPduFields((ArticulatedPartsPdu)value, ref offset);
                MeasureArticulatedPartsPduFields((ArticulatedPartsPdu)value, ref offset);
                break;
            case 49:
                MeasureLiveEntityFamilyPduFields((LiveEntityFirePdu)value, ref offset);
                MeasureLiveEntityFirePduFields((LiveEntityFirePdu)value, ref offset);
                break;
            case 50:
                MeasureLiveEntityFamilyPduFields((LiveEntityDetonationPdu)value, ref offset);
                MeasureLiveEntityDetonationPduFields((LiveEntityDetonationPdu)value, ref offset);
                break;
            case 51:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((CreateEntityReliablePdu)value, ref offset);
                MeasureCreateEntityReliablePduFields((CreateEntityReliablePdu)value, ref offset);
                break;
            case 52:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((RemoveEntityReliablePdu)value, ref offset);
                MeasureRemoveEntityReliablePduFields((RemoveEntityReliablePdu)value, ref offset);
                break;
            case 53:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((StartResumeReliablePdu)value, ref offset);
                MeasureStartResumeReliablePduFields((StartResumeReliablePdu)value, ref offset);
                break;
            case 54:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((StopFreezeReliablePdu)value, ref offset);
                MeasureStopFreezeReliablePduFields((StopFreezeReliablePdu)value, ref offset);
                break;
            case 55:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((AcknowledgeReliablePdu)value, ref offset);
                MeasureAcknowledgeReliablePduFields((AcknowledgeReliablePdu)value, ref offset);
                break;
            case 56:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((ActionRequestReliablePdu)value, ref offset);
                MeasureActionRequestReliablePduFields((ActionRequestReliablePdu)value, ref offset);
                break;
            case 57:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((ActionResponseReliablePdu)value, ref offset);
                MeasureActionResponseReliablePduFields((ActionResponseReliablePdu)value, ref offset);
                break;
            case 58:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((DataQueryReliablePdu)value, ref offset);
                MeasureDataQueryReliablePduFields((DataQueryReliablePdu)value, ref offset);
                break;
            case 59:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((SetDataReliablePdu)value, ref offset);
                MeasureSetDataReliablePduFields((SetDataReliablePdu)value, ref offset);
                break;
            case 60:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((DataReliablePdu)value, ref offset);
                MeasureDataReliablePduFields((DataReliablePdu)value, ref offset);
                break;
            case 61:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((EventReportReliablePdu)value, ref offset);
                MeasureEventReportReliablePduFields((EventReportReliablePdu)value, ref offset);
                break;
            case 62:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((CommentReliablePdu)value, ref offset);
                MeasureCommentReliablePduFields((CommentReliablePdu)value, ref offset);
                break;
            case 63:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((RecordReliablePdu)value, ref offset);
                MeasureRecordReliablePduFields((RecordReliablePdu)value, ref offset);
                break;
            case 64:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((SetRecordReliablePdu)value, ref offset);
                MeasureSetRecordReliablePduFields((SetRecordReliablePdu)value, ref offset);
                break;
            case 65:
                MeasureSimulationManagementWithReliabilityFamilyPduFields((RecordQueryReliablePdu)value, ref offset);
                MeasureRecordQueryReliablePduFields((RecordQueryReliablePdu)value, ref offset);
                break;
            case 66:
                MeasureEntityInformationInteractionFamilyPduFields((CollisionElasticPdu)value, ref offset);
                MeasureCollisionElasticPduFields((CollisionElasticPdu)value, ref offset);
                break;
            case 67:
                MeasureEntityInformationInteractionFamilyPduFields((EntityStateUpdatePdu)value, ref offset);
                MeasureEntityStateUpdatePduFields((EntityStateUpdatePdu)value, ref offset);
                break;
            case 68:
                MeasureWarfareFamilyPduFields((DirectedEnergyFirePdu)value, ref offset);
                MeasureDirectedEnergyFirePduFields((DirectedEnergyFirePdu)value, ref offset);
                break;
            case 69:
                MeasureWarfareFamilyPduFields((EntityDamageStatusPdu)value, ref offset);
                MeasureEntityDamageStatusPduFields((EntityDamageStatusPdu)value, ref offset);
                break;
            case 70:
                MeasureInformationOperationsFamilyPduFields((InformationOperationsActionPdu)value, ref offset);
                MeasureInformationOperationsActionPduFields((InformationOperationsActionPdu)value, ref offset);
                break;
            case 71:
                MeasureInformationOperationsFamilyPduFields((InformationOperationsReportPdu)value, ref offset);
                MeasureInformationOperationsReportPduFields((InformationOperationsReportPdu)value, ref offset);
                break;
            case 72:
                MeasureEntityInformationInteractionFamilyPduFields((AttributePdu)value, ref offset);
                MeasureAttributePduFields((AttributePdu)value, ref offset);
                break;
            default: throw new ArgumentOutOfRangeException(nameof(value), value.PduType, "DIS v7 defines PDU types 1 through 72.");
        }
    }

    private static void ApplyHeader(Pdu value, DisHeader header)
    {
        value.ProtocolVersion = header.ProtocolVersion;
        value.ExerciseId = header.ExerciseId;
        value.PduType = header.PduType;
        value.ProtocolFamily = header.ProtocolFamily;
        value.Timestamp = header.Timestamp;
        value.Length = header.Length;
        if (value is PduBase body)
        {
            body.PduStatus = new PduStatus { Value = header.PduStatus };
            body.Padding = header.Padding;
        }
    }

    private static APA ReadAPA(ref DisBinaryReader reader)
    {
        var value = new APA();
        ReadAPAFields(ref reader, value);
        return value;
    }

    private static void ReadAPAFields(ref DisBinaryReader reader, APA value)
    {
        value.ParameterIndex = reader.ReadUInt16("parameterIndex");
        value.Value = reader.ReadUInt16("value");
    }

    private static void PrepareAPA(APA value)
    {
        PrepareAPAFields(value);
    }

    private static void PrepareAPAFields(APA value)
    {
    }

    private static void WriteAPA(ref DisBinaryWriter writer, APA value)
    {
        WriteAPAFields(ref writer, value);
    }

    private static void WriteAPAFields(ref DisBinaryWriter writer, APA value)
    {
        writer.WriteUInt16(value.ParameterIndex, "parameterIndex");
        writer.WriteUInt16(value.Value, "value");
    }

    private static void MeasureAPA(in APA value, ref int offset)
    {
        MeasureAPAFields(value, ref offset);
    }

    private static void MeasureAPAFields(in APA value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static AbstractIFFPduLayerData ReadAbstractIFFPduLayerData(ref DisBinaryReader reader)
    {
        var value = new AbstractIFFPduLayerData();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        return value;
    }

    private static void ReadAbstractIFFPduLayerDataFields(ref DisBinaryReader reader, AbstractIFFPduLayerData value)
    {
    }

    private static void PrepareAbstractIFFPduLayerData(AbstractIFFPduLayerData value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
    }

    private static void PrepareAbstractIFFPduLayerDataFields(AbstractIFFPduLayerData value)
    {
    }

    private static void WriteAbstractIFFPduLayerData(ref DisBinaryWriter writer, AbstractIFFPduLayerData value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
    }

    private static void WriteAbstractIFFPduLayerDataFields(ref DisBinaryWriter writer, AbstractIFFPduLayerData value)
    {
    }

    private static void MeasureAbstractIFFPduLayerData(in AbstractIFFPduLayerData value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
    }

    private static void MeasureAbstractIFFPduLayerDataFields(in AbstractIFFPduLayerData value, ref int offset)
    {
    }

    private static void ReadAcknowledgePduFields(ref DisBinaryReader reader, AcknowledgePdu value)
    {
        value.AcknowledgeFlag = (AcknowledgeAcknowledgeFlag)reader.ReadUInt16("acknowledgeFlag");
        value.ResponseFlag = (AcknowledgeResponseFlag)reader.ReadUInt16("responseFlag");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareAcknowledgePduFields(AcknowledgePdu value)
    {
    }

    private static void WriteAcknowledgePduFields(ref DisBinaryWriter writer, AcknowledgePdu value)
    {
        writer.WriteUInt16((ushort)value.AcknowledgeFlag, "acknowledgeFlag");
        writer.WriteUInt16((ushort)value.ResponseFlag, "responseFlag");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureAcknowledgePduFields(in AcknowledgePdu value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 4;
    }

    private static void ReadAcknowledgeReliablePduFields(ref DisBinaryReader reader, AcknowledgeReliablePdu value)
    {
        value.AcknowledgeFlag = (AcknowledgeAcknowledgeFlag)reader.ReadUInt16("acknowledgeFlag");
        value.ResponseFlag = (AcknowledgeResponseFlag)reader.ReadUInt16("responseFlag");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareAcknowledgeReliablePduFields(AcknowledgeReliablePdu value)
    {
    }

    private static void WriteAcknowledgeReliablePduFields(ref DisBinaryWriter writer, AcknowledgeReliablePdu value)
    {
        writer.WriteUInt16((ushort)value.AcknowledgeFlag, "acknowledgeFlag");
        writer.WriteUInt16((ushort)value.ResponseFlag, "responseFlag");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureAcknowledgeReliablePduFields(in AcknowledgeReliablePdu value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 4;
    }

    private static AcousticEmitter ReadAcousticEmitter(ref DisBinaryReader reader)
    {
        var value = new AcousticEmitter();
        ReadAcousticEmitterFields(ref reader, value);
        return value;
    }

    private static void ReadAcousticEmitterFields(ref DisBinaryReader reader, AcousticEmitter value)
    {
        value.AcousticSystemName = (UaAcousticSystemName)reader.ReadUInt16("acousticSystemName");
        value.AcousticFunction = (UaAcousticEmitterSystemFunction)reader.ReadByte("acousticFunction");
        value.AcousticIdNumber = reader.ReadByte("acousticIDNumber");
    }

    private static void PrepareAcousticEmitter(AcousticEmitter value)
    {
        PrepareAcousticEmitterFields(value);
    }

    private static void PrepareAcousticEmitterFields(AcousticEmitter value)
    {
    }

    private static void WriteAcousticEmitter(ref DisBinaryWriter writer, AcousticEmitter value)
    {
        WriteAcousticEmitterFields(ref writer, value);
    }

    private static void WriteAcousticEmitterFields(ref DisBinaryWriter writer, AcousticEmitter value)
    {
        writer.WriteUInt16((ushort)value.AcousticSystemName, "acousticSystemName");
        writer.WriteByte((byte)value.AcousticFunction, "acousticFunction");
        writer.WriteByte(value.AcousticIdNumber, "acousticIDNumber");
    }

    private static void MeasureAcousticEmitter(in AcousticEmitter value, ref int offset)
    {
        MeasureAcousticEmitterFields(value, ref offset);
    }

    private static void MeasureAcousticEmitterFields(in AcousticEmitter value, ref int offset)
    {
        offset += 2;
        offset += 1;
        offset += 1;
    }

    private static void ReadActionRequestPduFields(ref DisBinaryReader reader, ActionRequestPdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.ActionId = (ActionRequestActionId)reader.ReadUInt32("actionID");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatums");
        value.FixedDatums = new List<FixedDatum>(FixedDatumsCount);
        for (int index = 0; index < FixedDatumsCount; index++)
            value.FixedDatums.Add(ReadFixedDatum(ref reader));
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareActionRequestPduFields(ActionRequestPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatums);
        foreach (FixedDatum item in value.FixedDatums) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatums.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteActionRequestPduFields(ref DisBinaryWriter writer, ActionRequestPdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32((uint)value.ActionId, "actionID");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatums) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureActionRequestPduFields(in ActionRequestPdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatums) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadActionRequestReliablePduFields(ref DisBinaryReader reader, ActionRequestReliablePdu value)
    {
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.RequestId = reader.ReadUInt32("requestID");
        value.ActionId = (ActionRequestActionId)reader.ReadUInt32("actionID");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumRecordsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatumRecords");
        value.FixedDatumRecords = new List<FixedDatum>(FixedDatumRecordsCount);
        for (int index = 0; index < FixedDatumRecordsCount; index++)
            value.FixedDatumRecords.Add(ReadFixedDatum(ref reader));
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareActionRequestReliablePduFields(ActionRequestReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumRecords);
        foreach (FixedDatum item in value.FixedDatumRecords) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatumRecords.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteActionRequestReliablePduFields(ref DisBinaryWriter writer, ActionRequestReliablePdu value)
    {
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32((uint)value.ActionId, "actionID");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatumRecords) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureActionRequestReliablePduFields(in ActionRequestReliablePdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumRecords) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadActionResponsePduFields(ref DisBinaryReader reader, ActionResponsePdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.RequestStatus = (ActionResponseRequestStatus)reader.ReadUInt32("requestStatus");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatums");
        value.FixedDatums = new List<FixedDatum>(FixedDatumsCount);
        for (int index = 0; index < FixedDatumsCount; index++)
            value.FixedDatums.Add(ReadFixedDatum(ref reader));
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareActionResponsePduFields(ActionResponsePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatums);
        foreach (FixedDatum item in value.FixedDatums) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatums.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteActionResponsePduFields(ref DisBinaryWriter writer, ActionResponsePdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32((uint)value.RequestStatus, "requestStatus");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatums) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureActionResponsePduFields(in ActionResponsePdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatums) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadActionResponseReliablePduFields(ref DisBinaryReader reader, ActionResponseReliablePdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.ResponseStatus = (ActionResponseRequestStatus)reader.ReadUInt32("responseStatus");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumRecordsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatumRecords");
        value.FixedDatumRecords = new List<FixedDatum>(FixedDatumRecordsCount);
        for (int index = 0; index < FixedDatumRecordsCount; index++)
            value.FixedDatumRecords.Add(ReadFixedDatum(ref reader));
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareActionResponseReliablePduFields(ActionResponseReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumRecords);
        foreach (FixedDatum item in value.FixedDatumRecords) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatumRecords.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteActionResponseReliablePduFields(ref DisBinaryWriter writer, ActionResponseReliablePdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32((uint)value.ResponseStatus, "responseStatus");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatumRecords) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureActionResponseReliablePduFields(in ActionResponseReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumRecords) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static AggregateIdentifier ReadAggregateIdentifier(ref DisBinaryReader reader)
    {
        var value = new AggregateIdentifier();
        ReadAggregateIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadAggregateIdentifierFields(ref DisBinaryReader reader, AggregateIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.AggregateId = reader.ReadUInt16("aggregateID");
    }

    private static void PrepareAggregateIdentifier(AggregateIdentifier value)
    {
        PrepareAggregateIdentifierFields(value);
    }

    private static void PrepareAggregateIdentifierFields(AggregateIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteAggregateIdentifier(ref DisBinaryWriter writer, AggregateIdentifier value)
    {
        WriteAggregateIdentifierFields(ref writer, value);
    }

    private static void WriteAggregateIdentifierFields(ref DisBinaryWriter writer, AggregateIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.AggregateId, "aggregateID");
    }

    private static void MeasureAggregateIdentifier(in AggregateIdentifier value, ref int offset)
    {
        MeasureAggregateIdentifierFields(value, ref offset);
    }

    private static void MeasureAggregateIdentifierFields(in AggregateIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static AggregateMarking ReadAggregateMarking(ref DisBinaryReader reader)
    {
        var value = new AggregateMarking();
        ReadAggregateMarkingFields(ref reader, value);
        return value;
    }

    private static void ReadAggregateMarkingFields(ref DisBinaryReader reader, AggregateMarking value)
    {
        value.CharacterSet = (EntityMarkingCharacterSet)reader.ReadByte("characterSet");
        int CharactersCount = CheckedCount(31, reader.Remaining, "characters");
        value.Characters = new byte[CharactersCount];
        for (int index = 0; index < CharactersCount; index++)
            value.Characters[index] = reader.ReadByte("characters");
    }

    private static void PrepareAggregateMarking(AggregateMarking value)
    {
        PrepareAggregateMarkingFields(value);
    }

    private static void PrepareAggregateMarkingFields(AggregateMarking value)
    {
        ArgumentNullException.ThrowIfNull(value.Characters);
    }

    private static void WriteAggregateMarking(ref DisBinaryWriter writer, AggregateMarking value)
    {
        WriteAggregateMarkingFields(ref writer, value);
    }

    private static void WriteAggregateMarkingFields(ref DisBinaryWriter writer, AggregateMarking value)
    {
        writer.WriteByte((byte)value.CharacterSet, "characterSet");
        foreach (byte item in value.Characters) writer.WriteByte(item, "characters");
    }

    private static void MeasureAggregateMarking(in AggregateMarking value, ref int offset)
    {
        MeasureAggregateMarkingFields(value, ref offset);
    }

    private static void MeasureAggregateMarkingFields(in AggregateMarking value, ref int offset)
    {
        offset += 1;
        offset += checked(value.Characters.Length * 1);
    }

    private static void ReadAggregateStatePduFields(ref DisBinaryReader reader, AggregateStatePdu value)
    {
        value.AggregateId = ReadAggregateIdentifier(ref reader);
        value.ForceId = (ForceId)reader.ReadByte("forceID");
        value.AggregateState = (AggregateStateAggregateState)reader.ReadByte("aggregateState");
        value.AggregateType = ReadAggregateType(ref reader);
        value.Formation = (AggregateStateFormation)reader.ReadUInt32("formation");
        value.AggregateMarking = ReadAggregateMarking(ref reader);
        value.Dimensions = ReadVector3Float(ref reader);
        value.Orientation = ReadVector3Float(ref reader);
        value.CenterOfMass = ReadVector3Double(ref reader);
        value.Velocity = ReadVector3Float(ref reader);
        value.NumberOfDisAggregates = reader.ReadUInt16("numberOfDisAggregates");
        value.NumberOfDisEntities = reader.ReadUInt16("numberOfDisEntities");
        value.NumberOfSilentAggregateTypes = reader.ReadUInt16("numberOfSilentAggregateTypes");
        value.NumberOfSilentEntityTypes = reader.ReadUInt16("numberOfSilentEntityTypes");
        int AggregateIdListCount = CheckedCount(checked((int)value.NumberOfDisAggregates), reader.Remaining, "aggregateIDList");
        value.AggregateIdList = new List<AggregateIdentifier>(AggregateIdListCount);
        for (int index = 0; index < AggregateIdListCount; index++)
            value.AggregateIdList.Add(ReadAggregateIdentifier(ref reader));
        int EntityIdListCount = CheckedCount(checked((int)value.NumberOfDisEntities), reader.Remaining, "entityIDList");
        value.EntityIdList = new List<EntityId>(EntityIdListCount);
        for (int index = 0; index < EntityIdListCount; index++)
            value.EntityIdList.Add(ReadEntityId(ref reader));
        reader.Skip(Padding(reader.Offset, 4), "padTo32");
        int SilentAggregateSystemListCount = CheckedCount(checked((int)value.NumberOfSilentAggregateTypes), reader.Remaining, "silentAggregateSystemList");
        value.SilentAggregateSystemList = new List<EntityType>(SilentAggregateSystemListCount);
        for (int index = 0; index < SilentAggregateSystemListCount; index++)
            value.SilentAggregateSystemList.Add(ReadEntityType(ref reader));
        int SilentEntitySystemListCount = CheckedCount(checked((int)value.NumberOfSilentEntityTypes), reader.Remaining, "silentEntitySystemList");
        value.SilentEntitySystemList = new List<EntityType>(SilentEntitySystemListCount);
        for (int index = 0; index < SilentEntitySystemListCount; index++)
            value.SilentEntitySystemList.Add(ReadEntityType(ref reader));
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int VariableDatumListCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumList");
        value.VariableDatumList = new List<VariableDatum>(VariableDatumListCount);
        for (int index = 0; index < VariableDatumListCount; index++)
            value.VariableDatumList.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareAggregateStatePduFields(AggregateStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.AggregateId);
        PrepareAggregateIdentifier(value.AggregateId);
        ArgumentNullException.ThrowIfNull(value.AggregateType);
        PrepareAggregateType(value.AggregateType);
        ArgumentNullException.ThrowIfNull(value.AggregateMarking);
        PrepareAggregateMarking(value.AggregateMarking);
        ArgumentNullException.ThrowIfNull(value.Dimensions);
        PrepareVector3Float(value.Dimensions);
        ArgumentNullException.ThrowIfNull(value.Orientation);
        PrepareVector3Float(value.Orientation);
        ArgumentNullException.ThrowIfNull(value.CenterOfMass);
        PrepareVector3Double(value.CenterOfMass);
        ArgumentNullException.ThrowIfNull(value.Velocity);
        PrepareVector3Float(value.Velocity);
        ArgumentNullException.ThrowIfNull(value.AggregateIdList);
        foreach (AggregateIdentifier item in value.AggregateIdList) PrepareAggregateIdentifier(item);
        value.NumberOfDisAggregates = checked((ushort)value.AggregateIdList.Count);
        ArgumentNullException.ThrowIfNull(value.EntityIdList);
        foreach (EntityId item in value.EntityIdList) PrepareEntityId(item);
        value.NumberOfDisEntities = checked((ushort)value.EntityIdList.Count);
        ArgumentNullException.ThrowIfNull(value.SilentAggregateSystemList);
        foreach (EntityType item in value.SilentAggregateSystemList) PrepareEntityType(item);
        value.NumberOfSilentAggregateTypes = checked((ushort)value.SilentAggregateSystemList.Count);
        ArgumentNullException.ThrowIfNull(value.SilentEntitySystemList);
        foreach (EntityType item in value.SilentEntitySystemList) PrepareEntityType(item);
        value.NumberOfSilentEntityTypes = checked((ushort)value.SilentEntitySystemList.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumList);
        foreach (VariableDatum item in value.VariableDatumList) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumList.Count);
    }

    private static void WriteAggregateStatePduFields(ref DisBinaryWriter writer, AggregateStatePdu value)
    {
        WriteAggregateIdentifier(ref writer, value.AggregateId);
        writer.WriteByte((byte)value.ForceId, "forceID");
        writer.WriteByte((byte)value.AggregateState, "aggregateState");
        WriteAggregateType(ref writer, value.AggregateType);
        writer.WriteUInt32((uint)value.Formation, "formation");
        WriteAggregateMarking(ref writer, value.AggregateMarking);
        WriteVector3Float(ref writer, value.Dimensions);
        WriteVector3Float(ref writer, value.Orientation);
        WriteVector3Double(ref writer, value.CenterOfMass);
        WriteVector3Float(ref writer, value.Velocity);
        writer.WriteUInt16(value.NumberOfDisAggregates, "numberOfDisAggregates");
        writer.WriteUInt16(value.NumberOfDisEntities, "numberOfDisEntities");
        writer.WriteUInt16(value.NumberOfSilentAggregateTypes, "numberOfSilentAggregateTypes");
        writer.WriteUInt16(value.NumberOfSilentEntityTypes, "numberOfSilentEntityTypes");
        foreach (AggregateIdentifier item in value.AggregateIdList) WriteAggregateIdentifier(ref writer, item);
        foreach (EntityId item in value.EntityIdList) WriteEntityId(ref writer, item);
        writer.WriteZeros(Padding(writer.Offset, 4), "padTo32");
        foreach (EntityType item in value.SilentAggregateSystemList) WriteEntityType(ref writer, item);
        foreach (EntityType item in value.SilentEntitySystemList) WriteEntityType(ref writer, item);
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (VariableDatum item in value.VariableDatumList) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureAggregateStatePduFields(in AggregateStatePdu value, ref int offset)
    {
        MeasureAggregateIdentifier(value.AggregateId, ref offset);
        offset += 1;
        offset += 1;
        MeasureAggregateType(value.AggregateType, ref offset);
        offset += 4;
        MeasureAggregateMarking(value.AggregateMarking, ref offset);
        MeasureVector3Float(value.Dimensions, ref offset);
        MeasureVector3Float(value.Orientation, ref offset);
        MeasureVector3Double(value.CenterOfMass, ref offset);
        MeasureVector3Float(value.Velocity, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        foreach (AggregateIdentifier item in value.AggregateIdList) MeasureAggregateIdentifier(item, ref offset);
        foreach (EntityId item in value.EntityIdList) MeasureEntityId(item, ref offset);
        offset += Padding(offset, 4);
        foreach (EntityType item in value.SilentAggregateSystemList) MeasureEntityType(item, ref offset);
        foreach (EntityType item in value.SilentEntitySystemList) MeasureEntityType(item, ref offset);
        offset += 4;
        foreach (VariableDatum item in value.VariableDatumList) MeasureVariableDatum(item, ref offset);
    }

    private static AggregateType ReadAggregateType(ref DisBinaryReader reader)
    {
        var value = new AggregateType();
        ReadAggregateTypeFields(ref reader, value);
        return value;
    }

    private static void ReadAggregateTypeFields(ref DisBinaryReader reader, AggregateType value)
    {
        value.AggregateKind = (AggregateStateAggregateKind)reader.ReadByte("aggregateKind");
        value.Domain = (PlatformDomain)reader.ReadByte("domain");
        value.Country = (Country)reader.ReadUInt16("country");
        value.Category = reader.ReadByte("category");
        value.Subcategory = (AggregateStateSubcategory)reader.ReadByte("subcategory");
        value.SpecificInfo = (AggregateStateSpecific)reader.ReadByte("specificInfo");
        value.Extra = reader.ReadByte("extra");
    }

    private static void PrepareAggregateType(AggregateType value)
    {
        PrepareAggregateTypeFields(value);
    }

    private static void PrepareAggregateTypeFields(AggregateType value)
    {
    }

    private static void WriteAggregateType(ref DisBinaryWriter writer, AggregateType value)
    {
        WriteAggregateTypeFields(ref writer, value);
    }

    private static void WriteAggregateTypeFields(ref DisBinaryWriter writer, AggregateType value)
    {
        writer.WriteByte((byte)value.AggregateKind, "aggregateKind");
        writer.WriteByte((byte)value.Domain, "domain");
        writer.WriteUInt16((ushort)value.Country, "country");
        writer.WriteByte(value.Category, "category");
        writer.WriteByte((byte)value.Subcategory, "subcategory");
        writer.WriteByte((byte)value.SpecificInfo, "specificInfo");
        writer.WriteByte(value.Extra, "extra");
    }

    private static void MeasureAggregateType(in AggregateType value, ref int offset)
    {
        MeasureAggregateTypeFields(value, ref offset);
    }

    private static void MeasureAggregateTypeFields(in AggregateType value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static AngleDeception ReadAngleDeception(ref DisBinaryReader reader)
    {
        var value = new AngleDeception();
        ReadAngleDeceptionFields(ref reader, value);
        return value;
    }

    private static void ReadAngleDeceptionFields(ref DisBinaryReader reader, AngleDeception value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.Padding = reader.ReadUInt16("padding");
        value.EmitterNumber = reader.ReadByte("emitterNumber");
        value.BeamNumber = reader.ReadByte("beamNumber");
        value.StateIndicator = (EeAttributeStateIndicator)reader.ReadByte("stateIndicator");
        value.Padding2 = reader.ReadByte("padding2");
        value.AzimuthOffset = reader.ReadSingle("azimuthOffset");
        value.AzimuthWidth = reader.ReadSingle("azimuthWidth");
        value.AzimuthPullRate = reader.ReadSingle("azimuthPullRate");
        value.AzimuthPullAcceleration = reader.ReadSingle("azimuthPullAcceleration");
        value.ElevationOffset = reader.ReadSingle("elevationOffset");
        value.ElevationWidth = reader.ReadSingle("elevationWidth");
        value.ElevationPullRate = reader.ReadSingle("elevationPullRate");
        value.ElevationPullAcceleration = reader.ReadSingle("elevationPullAcceleration");
        value.Padding3 = reader.ReadUInt32("padding3");
    }

    private static void PrepareAngleDeception(AngleDeception value)
    {
        PrepareAngleDeceptionFields(value);
    }

    private static void PrepareAngleDeceptionFields(AngleDeception value)
    {
    }

    private static void WriteAngleDeception(ref DisBinaryWriter writer, AngleDeception value)
    {
        WriteAngleDeceptionFields(ref writer, value);
    }

    private static void WriteAngleDeceptionFields(ref DisBinaryWriter writer, AngleDeception value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteByte(value.EmitterNumber, "emitterNumber");
        writer.WriteByte(value.BeamNumber, "beamNumber");
        writer.WriteByte((byte)value.StateIndicator, "stateIndicator");
        writer.WriteByte(value.Padding2, "padding2");
        writer.WriteSingle(value.AzimuthOffset, "azimuthOffset");
        writer.WriteSingle(value.AzimuthWidth, "azimuthWidth");
        writer.WriteSingle(value.AzimuthPullRate, "azimuthPullRate");
        writer.WriteSingle(value.AzimuthPullAcceleration, "azimuthPullAcceleration");
        writer.WriteSingle(value.ElevationOffset, "elevationOffset");
        writer.WriteSingle(value.ElevationWidth, "elevationWidth");
        writer.WriteSingle(value.ElevationPullRate, "elevationPullRate");
        writer.WriteSingle(value.ElevationPullAcceleration, "elevationPullAcceleration");
        writer.WriteUInt32(value.Padding3, "padding3");
    }

    private static void MeasureAngleDeception(in AngleDeception value, ref int offset)
    {
        MeasureAngleDeceptionFields(value, ref offset);
    }

    private static void MeasureAngleDeceptionFields(in AngleDeception value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static AngularVelocityVector ReadAngularVelocityVector(ref DisBinaryReader reader)
    {
        var value = new AngularVelocityVector();
        ReadAngularVelocityVectorFields(ref reader, value);
        return value;
    }

    private static void ReadAngularVelocityVectorFields(ref DisBinaryReader reader, AngularVelocityVector value)
    {
        value.X = reader.ReadSingle("x");
        value.Y = reader.ReadSingle("y");
        value.Z = reader.ReadSingle("z");
    }

    private static void PrepareAngularVelocityVector(AngularVelocityVector value)
    {
        PrepareAngularVelocityVectorFields(value);
    }

    private static void PrepareAngularVelocityVectorFields(AngularVelocityVector value)
    {
    }

    private static void WriteAngularVelocityVector(ref DisBinaryWriter writer, AngularVelocityVector value)
    {
        WriteAngularVelocityVectorFields(ref writer, value);
    }

    private static void WriteAngularVelocityVectorFields(ref DisBinaryWriter writer, AngularVelocityVector value)
    {
        writer.WriteSingle(value.X, "x");
        writer.WriteSingle(value.Y, "y");
        writer.WriteSingle(value.Z, "z");
    }

    private static void MeasureAngularVelocityVector(in AngularVelocityVector value, ref int offset)
    {
        MeasureAngularVelocityVectorFields(value, ref offset);
    }

    private static void MeasureAngularVelocityVectorFields(in AngularVelocityVector value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static AntennaLocation ReadAntennaLocation(ref DisBinaryReader reader)
    {
        var value = new AntennaLocation();
        ReadAntennaLocationFields(ref reader, value);
        return value;
    }

    private static void ReadAntennaLocationFields(ref DisBinaryReader reader, AntennaLocation value)
    {
        value.AntennaLocationValue = ReadVector3Double(ref reader);
        value.RelativeAntennaLocation = ReadVector3Float(ref reader);
    }

    private static void PrepareAntennaLocation(AntennaLocation value)
    {
        PrepareAntennaLocationFields(value);
    }

    private static void PrepareAntennaLocationFields(AntennaLocation value)
    {
        ArgumentNullException.ThrowIfNull(value.AntennaLocationValue);
        PrepareVector3Double(value.AntennaLocationValue);
        ArgumentNullException.ThrowIfNull(value.RelativeAntennaLocation);
        PrepareVector3Float(value.RelativeAntennaLocation);
    }

    private static void WriteAntennaLocation(ref DisBinaryWriter writer, AntennaLocation value)
    {
        WriteAntennaLocationFields(ref writer, value);
    }

    private static void WriteAntennaLocationFields(ref DisBinaryWriter writer, AntennaLocation value)
    {
        WriteVector3Double(ref writer, value.AntennaLocationValue);
        WriteVector3Float(ref writer, value.RelativeAntennaLocation);
    }

    private static void MeasureAntennaLocation(in AntennaLocation value, ref int offset)
    {
        MeasureAntennaLocationFields(value, ref offset);
    }

    private static void MeasureAntennaLocationFields(in AntennaLocation value, ref int offset)
    {
        MeasureVector3Double(value.AntennaLocationValue, ref offset);
        MeasureVector3Float(value.RelativeAntennaLocation, ref offset);
    }

    private static Appearance ReadAppearance(ref DisBinaryReader reader)
    {
        var value = new Appearance();
        ReadAppearanceFields(ref reader, value);
        return value;
    }

    private static void ReadAppearanceFields(ref DisBinaryReader reader, Appearance value)
    {
        value.Visual = reader.ReadUInt32("visual");
        value.Ir = reader.ReadUInt32("ir");
        value.Em = reader.ReadUInt32("em");
        value.Audio = reader.ReadUInt32("audio");
    }

    private static void PrepareAppearance(Appearance value)
    {
        PrepareAppearanceFields(value);
    }

    private static void PrepareAppearanceFields(Appearance value)
    {
    }

    private static void WriteAppearance(ref DisBinaryWriter writer, Appearance value)
    {
        WriteAppearanceFields(ref writer, value);
    }

    private static void WriteAppearanceFields(ref DisBinaryWriter writer, Appearance value)
    {
        writer.WriteUInt32(value.Visual, "visual");
        writer.WriteUInt32(value.Ir, "ir");
        writer.WriteUInt32(value.Em, "em");
        writer.WriteUInt32(value.Audio, "audio");
    }

    private static void MeasureAppearance(in Appearance value, ref int offset)
    {
        MeasureAppearanceFields(value, ref offset);
    }

    private static void MeasureAppearanceFields(in Appearance value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static void ReadAppearancePduFields(ref DisBinaryReader reader, AppearancePdu value)
    {
        value.LiveEntityId = ReadEntityId(ref reader);
        value.AppearanceFlags = reader.ReadUInt16("appearanceFlags");
        value.ForceId = (ForceId)reader.ReadByte("forceId");
        value.EntityType = ReadEntityType(ref reader);
        value.AlternateEntityType = ReadEntityType(ref reader);
        value.EntityMarking = ReadEntityMarking(ref reader);
        value.Capabilities = new EntityCapabilities(reader.ReadUInt32("capabilities"));
        value.AppearanceFields = ReadAppearance(ref reader);
    }

    private static void PrepareAppearancePduFields(AppearancePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.LiveEntityId);
        PrepareEntityId(value.LiveEntityId);
        ArgumentNullException.ThrowIfNull(value.EntityType);
        PrepareEntityType(value.EntityType);
        ArgumentNullException.ThrowIfNull(value.AlternateEntityType);
        PrepareEntityType(value.AlternateEntityType);
        ArgumentNullException.ThrowIfNull(value.EntityMarking);
        PrepareEntityMarking(value.EntityMarking);
        ArgumentNullException.ThrowIfNull(value.AppearanceFields);
        PrepareAppearance(value.AppearanceFields);
    }

    private static void WriteAppearancePduFields(ref DisBinaryWriter writer, AppearancePdu value)
    {
        WriteEntityId(ref writer, value.LiveEntityId);
        writer.WriteUInt16(value.AppearanceFlags, "appearanceFlags");
        writer.WriteByte((byte)value.ForceId, "forceId");
        WriteEntityType(ref writer, value.EntityType);
        WriteEntityType(ref writer, value.AlternateEntityType);
        WriteEntityMarking(ref writer, value.EntityMarking);
        writer.WriteUInt32(value.Capabilities.Value, "capabilities");
        WriteAppearance(ref writer, value.AppearanceFields);
    }

    private static void MeasureAppearancePduFields(in AppearancePdu value, ref int offset)
    {
        MeasureEntityId(value.LiveEntityId, ref offset);
        offset += 2;
        offset += 1;
        MeasureEntityType(value.EntityType, ref offset);
        MeasureEntityType(value.AlternateEntityType, ref offset);
        MeasureEntityMarking(value.EntityMarking, ref offset);
        offset += 4;
        MeasureAppearance(value.AppearanceFields, ref offset);
    }

    private static void ReadArealObjectStatePduFields(ref DisBinaryReader reader, ArealObjectStatePdu value)
    {
        value.ObjectId = ReadObjectIdentifier(ref reader);
        value.ReferencedObjectId = ReadObjectIdentifier(ref reader);
        value.UpdateNumber = reader.ReadUInt16("updateNumber");
        value.ForceId = (ForceId)reader.ReadByte("forceID");
        value.Modifications = new ObjectStateModificationArealObject(reader.ReadUInt16("modifications"));
        value.ObjectType = ReadObjectType(ref reader);
        value.SpecificObjectAppearance = reader.ReadUInt32("specificObjectAppearance");
        value.GeneralObjectAppearance = reader.ReadUInt16("generalObjectAppearance");
        value.NumberOfPoints = reader.ReadUInt16("numberOfPoints");
        value.RequesterId = ReadSimulationAddress(ref reader);
        value.ReceivingId = ReadSimulationAddress(ref reader);
        int ObjectLocationCount = CheckedCount(checked((int)value.NumberOfPoints), reader.Remaining, "objectLocation");
        value.ObjectLocation = new List<Vector3Double>(ObjectLocationCount);
        for (int index = 0; index < ObjectLocationCount; index++)
            value.ObjectLocation.Add(ReadVector3Double(ref reader));
    }

    private static void PrepareArealObjectStatePduFields(ArealObjectStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ObjectId);
        PrepareObjectIdentifier(value.ObjectId);
        ArgumentNullException.ThrowIfNull(value.ReferencedObjectId);
        PrepareObjectIdentifier(value.ReferencedObjectId);
        ArgumentNullException.ThrowIfNull(value.ObjectType);
        PrepareObjectType(value.ObjectType);
        ArgumentNullException.ThrowIfNull(value.RequesterId);
        PrepareSimulationAddress(value.RequesterId);
        ArgumentNullException.ThrowIfNull(value.ReceivingId);
        PrepareSimulationAddress(value.ReceivingId);
        ArgumentNullException.ThrowIfNull(value.ObjectLocation);
        foreach (Vector3Double item in value.ObjectLocation) PrepareVector3Double(item);
        value.NumberOfPoints = checked((ushort)value.ObjectLocation.Count);
    }

    private static void WriteArealObjectStatePduFields(ref DisBinaryWriter writer, ArealObjectStatePdu value)
    {
        WriteObjectIdentifier(ref writer, value.ObjectId);
        WriteObjectIdentifier(ref writer, value.ReferencedObjectId);
        writer.WriteUInt16(value.UpdateNumber, "updateNumber");
        writer.WriteByte((byte)value.ForceId, "forceID");
        writer.WriteUInt16(value.Modifications.Value, "modifications");
        WriteObjectType(ref writer, value.ObjectType);
        writer.WriteUInt32(value.SpecificObjectAppearance, "specificObjectAppearance");
        writer.WriteUInt16(value.GeneralObjectAppearance, "generalObjectAppearance");
        writer.WriteUInt16(value.NumberOfPoints, "numberOfPoints");
        WriteSimulationAddress(ref writer, value.RequesterId);
        WriteSimulationAddress(ref writer, value.ReceivingId);
        foreach (Vector3Double item in value.ObjectLocation) WriteVector3Double(ref writer, item);
    }

    private static void MeasureArealObjectStatePduFields(in ArealObjectStatePdu value, ref int offset)
    {
        MeasureObjectIdentifier(value.ObjectId, ref offset);
        MeasureObjectIdentifier(value.ReferencedObjectId, ref offset);
        offset += 2;
        offset += 1;
        offset += 2;
        MeasureObjectType(value.ObjectType, ref offset);
        offset += 4;
        offset += 2;
        offset += 2;
        MeasureSimulationAddress(value.RequesterId, ref offset);
        MeasureSimulationAddress(value.ReceivingId, ref offset);
        foreach (Vector3Double item in value.ObjectLocation) MeasureVector3Double(item, ref offset);
    }

    private static ArticulatedPartVP ReadArticulatedPartVP(ref DisBinaryReader reader)
    {
        var value = new ArticulatedPartVP();
        ReadArticulatedPartVPFields(ref reader, value);
        return value;
    }

    private static void ReadArticulatedPartVPFields(ref DisBinaryReader reader, ArticulatedPartVP value)
    {
        value.RecordType = (VariableParameterRecordType)reader.ReadByte("recordType");
        value.ChangeIndicator = reader.ReadByte("changeIndicator");
        value.PartAttachedTo = reader.ReadUInt16("partAttachedTo");
        value.ParameterType = reader.ReadUInt32("parameterType");
        value.ParameterValue = reader.ReadSingle("parameterValue");
        value.Padding = reader.ReadUInt32("padding");
    }

    private static void PrepareArticulatedPartVP(ArticulatedPartVP value)
    {
        PrepareArticulatedPartVPFields(value);
    }

    private static void PrepareArticulatedPartVPFields(ArticulatedPartVP value)
    {
    }

    private static void WriteArticulatedPartVP(ref DisBinaryWriter writer, ArticulatedPartVP value)
    {
        WriteArticulatedPartVPFields(ref writer, value);
    }

    private static void WriteArticulatedPartVPFields(ref DisBinaryWriter writer, ArticulatedPartVP value)
    {
        writer.WriteByte((byte)value.RecordType, "recordType");
        writer.WriteByte(value.ChangeIndicator, "changeIndicator");
        writer.WriteUInt16(value.PartAttachedTo, "partAttachedTo");
        writer.WriteUInt32(value.ParameterType, "parameterType");
        writer.WriteSingle(value.ParameterValue, "parameterValue");
        writer.WriteUInt32(value.Padding, "padding");
    }

    private static void MeasureArticulatedPartVP(in ArticulatedPartVP value, ref int offset)
    {
        MeasureArticulatedPartVPFields(value, ref offset);
    }

    private static void MeasureArticulatedPartVPFields(in ArticulatedPartVP value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static void ReadArticulatedPartsPduFields(ref DisBinaryReader reader, ArticulatedPartsPdu value)
    {
        value.LiveEntityId = ReadEntityId(ref reader);
        value.NumberOfParameterRecords = reader.ReadByte("numberOfParameterRecords");
        int VariableParametersCount = CheckedCount(checked((int)value.NumberOfParameterRecords), reader.Remaining, "variableParameters");
        value.VariableParameters = new List<VariableParameter>(VariableParametersCount);
        for (int index = 0; index < VariableParametersCount; index++)
            value.VariableParameters.Add(ReadVariableParameter(ref reader));
    }

    private static void PrepareArticulatedPartsPduFields(ArticulatedPartsPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.LiveEntityId);
        PrepareEntityId(value.LiveEntityId);
        ArgumentNullException.ThrowIfNull(value.VariableParameters);
        foreach (VariableParameter item in value.VariableParameters) PrepareVariableParameter(item);
        value.NumberOfParameterRecords = checked((byte)value.VariableParameters.Count);
    }

    private static void WriteArticulatedPartsPduFields(ref DisBinaryWriter writer, ArticulatedPartsPdu value)
    {
        WriteEntityId(ref writer, value.LiveEntityId);
        writer.WriteByte(value.NumberOfParameterRecords, "numberOfParameterRecords");
        foreach (VariableParameter item in value.VariableParameters) WriteVariableParameter(ref writer, item);
    }

    private static void MeasureArticulatedPartsPduFields(in ArticulatedPartsPdu value, ref int offset)
    {
        MeasureEntityId(value.LiveEntityId, ref offset);
        offset += 1;
        foreach (VariableParameter item in value.VariableParameters) MeasureVariableParameter(item, ref offset);
    }

    private static Association ReadAssociation(ref DisBinaryReader reader)
    {
        var value = new Association();
        ReadAssociationFields(ref reader, value);
        return value;
    }

    private static void ReadAssociationFields(ref DisBinaryReader reader, Association value)
    {
        value.AssociationType = (EntityAssociationAssociationType)reader.ReadByte("associationType");
        value.Padding = reader.ReadByte("padding");
        value.AssociatedEntityId = ReadEntityIdentifier(ref reader);
        value.AssociatedLocation = ReadVector3Double(ref reader);
    }

    private static void PrepareAssociation(Association value)
    {
        PrepareAssociationFields(value);
    }

    private static void PrepareAssociationFields(Association value)
    {
        ArgumentNullException.ThrowIfNull(value.AssociatedEntityId);
        PrepareEntityIdentifier(value.AssociatedEntityId);
        ArgumentNullException.ThrowIfNull(value.AssociatedLocation);
        PrepareVector3Double(value.AssociatedLocation);
    }

    private static void WriteAssociation(ref DisBinaryWriter writer, Association value)
    {
        WriteAssociationFields(ref writer, value);
    }

    private static void WriteAssociationFields(ref DisBinaryWriter writer, Association value)
    {
        writer.WriteByte((byte)value.AssociationType, "associationType");
        writer.WriteByte(value.Padding, "padding");
        WriteEntityIdentifier(ref writer, value.AssociatedEntityId);
        WriteVector3Double(ref writer, value.AssociatedLocation);
    }

    private static void MeasureAssociation(in Association value, ref int offset)
    {
        MeasureAssociationFields(value, ref offset);
    }

    private static void MeasureAssociationFields(in Association value, ref int offset)
    {
        offset += 1;
        offset += 1;
        MeasureEntityIdentifier(value.AssociatedEntityId, ref offset);
        MeasureVector3Double(value.AssociatedLocation, ref offset);
    }

    private static AttachedPartVP ReadAttachedPartVP(ref DisBinaryReader reader)
    {
        var value = new AttachedPartVP();
        ReadAttachedPartVPFields(ref reader, value);
        return value;
    }

    private static void ReadAttachedPartVPFields(ref DisBinaryReader reader, AttachedPartVP value)
    {
        value.RecordType = (VariableParameterRecordType)reader.ReadByte("recordType");
        value.DetachedIndicator = (AttachedPartDetachedIndicator)reader.ReadByte("detachedIndicator");
        value.PartAttachedTo = reader.ReadUInt16("partAttachedTo");
        value.ParameterType = (AttachedParts)reader.ReadUInt32("parameterType");
        value.AttachedPartType = ReadEntityType(ref reader);
    }

    private static void PrepareAttachedPartVP(AttachedPartVP value)
    {
        PrepareAttachedPartVPFields(value);
    }

    private static void PrepareAttachedPartVPFields(AttachedPartVP value)
    {
        ArgumentNullException.ThrowIfNull(value.AttachedPartType);
        PrepareEntityType(value.AttachedPartType);
    }

    private static void WriteAttachedPartVP(ref DisBinaryWriter writer, AttachedPartVP value)
    {
        WriteAttachedPartVPFields(ref writer, value);
    }

    private static void WriteAttachedPartVPFields(ref DisBinaryWriter writer, AttachedPartVP value)
    {
        writer.WriteByte((byte)value.RecordType, "recordType");
        writer.WriteByte((byte)value.DetachedIndicator, "detachedIndicator");
        writer.WriteUInt16(value.PartAttachedTo, "partAttachedTo");
        writer.WriteUInt32((uint)value.ParameterType, "parameterType");
        WriteEntityType(ref writer, value.AttachedPartType);
    }

    private static void MeasureAttachedPartVP(in AttachedPartVP value, ref int offset)
    {
        MeasureAttachedPartVPFields(value, ref offset);
    }

    private static void MeasureAttachedPartVPFields(in AttachedPartVP value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        MeasureEntityType(value.AttachedPartType, ref offset);
    }

    private static Attribute ReadAttribute(ref DisBinaryReader reader)
    {
        var value = new Attribute();
        ReadAttributeFields(ref reader, value);
        return value;
    }

    private static void ReadAttributeFields(ref DisBinaryReader reader, Attribute value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        int RecordSpecificFieldsCount = CheckedCount(checked((int)value.RecordLength), reader.Remaining, "recordSpecificFields");
        value.RecordSpecificFields = new byte[RecordSpecificFieldsCount];
        for (int index = 0; index < RecordSpecificFieldsCount; index++)
            value.RecordSpecificFields[index] = reader.ReadByte("recordSpecificFields");
        reader.Skip(Padding(reader.Offset, 8), "padding");
    }

    private static void PrepareAttribute(Attribute value)
    {
        PrepareAttributeFields(value);
    }

    private static void PrepareAttributeFields(Attribute value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificFields);
        value.RecordLength = checked((ushort)value.RecordSpecificFields.Length);
    }

    private static void WriteAttribute(ref DisBinaryWriter writer, Attribute value)
    {
        WriteAttributeFields(ref writer, value);
    }

    private static void WriteAttributeFields(ref DisBinaryWriter writer, Attribute value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        foreach (byte item in value.RecordSpecificFields) writer.WriteByte(item, "recordSpecificFields");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding");
    }

    private static void MeasureAttribute(in Attribute value, ref int offset)
    {
        MeasureAttributeFields(value, ref offset);
    }

    private static void MeasureAttributeFields(in Attribute value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += checked(value.RecordSpecificFields.Length * 1);
        offset += Padding(offset, 8);
    }

    private static void ReadAttributePduFields(ref DisBinaryReader reader, AttributePdu value)
    {
        value.OriginatingSimulationAddress = ReadSimulationAddress(ref reader);
        value.Padding1 = reader.ReadInt32("padding1");
        value.Padding2 = reader.ReadInt16("padding2");
        value.AttributeRecordPduType = (PduType)reader.ReadByte("attributeRecordPduType");
        value.AttributeRecordProtocolVersion = (ProtocolFamily)reader.ReadByte("attributeRecordProtocolVersion");
        value.MasterAttributeRecordType = (VariableRecordType)reader.ReadUInt32("masterAttributeRecordType");
        value.ActionCode = (DisAttributeActionCode)reader.ReadByte("actionCode");
        value.Padding3 = reader.ReadByte("padding3");
        value.NumberAttributeRecordSet = reader.ReadUInt16("numberAttributeRecordSet");
        int AttributeRecordSetsCount = CheckedCount(checked((int)value.NumberAttributeRecordSet), reader.Remaining, "attributeRecordSets");
        value.AttributeRecordSets = new List<AttributeRecordSet>(AttributeRecordSetsCount);
        for (int index = 0; index < AttributeRecordSetsCount; index++)
            value.AttributeRecordSets.Add(ReadAttributeRecordSet(ref reader));
    }

    private static void PrepareAttributePduFields(AttributePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OriginatingSimulationAddress);
        PrepareSimulationAddress(value.OriginatingSimulationAddress);
        ArgumentNullException.ThrowIfNull(value.AttributeRecordSets);
        foreach (AttributeRecordSet item in value.AttributeRecordSets) PrepareAttributeRecordSet(item);
        value.NumberAttributeRecordSet = checked((ushort)value.AttributeRecordSets.Count);
    }

    private static void WriteAttributePduFields(ref DisBinaryWriter writer, AttributePdu value)
    {
        WriteSimulationAddress(ref writer, value.OriginatingSimulationAddress);
        writer.WriteInt32(value.Padding1, "padding1");
        writer.WriteInt16(value.Padding2, "padding2");
        writer.WriteByte((byte)value.AttributeRecordPduType, "attributeRecordPduType");
        writer.WriteByte((byte)value.AttributeRecordProtocolVersion, "attributeRecordProtocolVersion");
        writer.WriteUInt32((uint)value.MasterAttributeRecordType, "masterAttributeRecordType");
        writer.WriteByte((byte)value.ActionCode, "actionCode");
        writer.WriteByte(value.Padding3, "padding3");
        writer.WriteUInt16(value.NumberAttributeRecordSet, "numberAttributeRecordSet");
        foreach (AttributeRecordSet item in value.AttributeRecordSets) WriteAttributeRecordSet(ref writer, item);
    }

    private static void MeasureAttributePduFields(in AttributePdu value, ref int offset)
    {
        MeasureSimulationAddress(value.OriginatingSimulationAddress, ref offset);
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (AttributeRecordSet item in value.AttributeRecordSets) MeasureAttributeRecordSet(item, ref offset);
    }

    private static AttributeRecordSet ReadAttributeRecordSet(ref DisBinaryReader reader)
    {
        var value = new AttributeRecordSet();
        ReadAttributeRecordSetFields(ref reader, value);
        return value;
    }

    private static void ReadAttributeRecordSetFields(ref DisBinaryReader reader, AttributeRecordSet value)
    {
        value.EntityId = ReadEntityId(ref reader);
        value.NumberOfAttributeRecords = reader.ReadUInt16("numberOfAttributeRecords");
        int AttributeRecordsCount = CheckedCount(checked((int)value.NumberOfAttributeRecords), reader.Remaining, "attributeRecords");
        value.AttributeRecords = new List<Attribute>(AttributeRecordsCount);
        for (int index = 0; index < AttributeRecordsCount; index++)
            value.AttributeRecords.Add(ReadAttribute(ref reader));
    }

    private static void PrepareAttributeRecordSet(AttributeRecordSet value)
    {
        PrepareAttributeRecordSetFields(value);
    }

    private static void PrepareAttributeRecordSetFields(AttributeRecordSet value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
        ArgumentNullException.ThrowIfNull(value.AttributeRecords);
        foreach (Attribute item in value.AttributeRecords) PrepareAttribute(item);
        value.NumberOfAttributeRecords = checked((ushort)value.AttributeRecords.Count);
    }

    private static void WriteAttributeRecordSet(ref DisBinaryWriter writer, AttributeRecordSet value)
    {
        WriteAttributeRecordSetFields(ref writer, value);
    }

    private static void WriteAttributeRecordSetFields(ref DisBinaryWriter writer, AttributeRecordSet value)
    {
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteUInt16(value.NumberOfAttributeRecords, "numberOfAttributeRecords");
        foreach (Attribute item in value.AttributeRecords) WriteAttribute(ref writer, item);
    }

    private static void MeasureAttributeRecordSet(in AttributeRecordSet value, ref int offset)
    {
        MeasureAttributeRecordSetFields(value, ref offset);
    }

    private static void MeasureAttributeRecordSetFields(in AttributeRecordSet value, ref int offset)
    {
        MeasureEntityId(value.EntityId, ref offset);
        offset += 2;
        foreach (Attribute item in value.AttributeRecords) MeasureAttribute(item, ref offset);
    }

    private static BeamAntennaPattern ReadBeamAntennaPattern(ref DisBinaryReader reader)
    {
        var value = new BeamAntennaPattern();
        ReadBeamAntennaPatternFields(ref reader, value);
        return value;
    }

    private static void ReadBeamAntennaPatternFields(ref DisBinaryReader reader, BeamAntennaPattern value)
    {
        value.BeamDirection = ReadEulerAngles(ref reader);
        value.AzimuthBeamwidth = reader.ReadSingle("azimuthBeamwidth");
        value.ElevationBeamwidth = reader.ReadSingle("elevationBeamwidth");
        value.ReferenceSystem = (TransmitterAntennaPatternReferenceSystem)reader.ReadByte("referenceSystem");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        value.Ez = reader.ReadSingle("ez");
        value.Ex = reader.ReadSingle("ex");
        value.Phase = reader.ReadSingle("phase");
        value.Padding3 = reader.ReadUInt32("padding3");
    }

    private static void PrepareBeamAntennaPattern(BeamAntennaPattern value)
    {
        PrepareBeamAntennaPatternFields(value);
    }

    private static void PrepareBeamAntennaPatternFields(BeamAntennaPattern value)
    {
        ArgumentNullException.ThrowIfNull(value.BeamDirection);
        PrepareEulerAngles(value.BeamDirection);
    }

    private static void WriteBeamAntennaPattern(ref DisBinaryWriter writer, BeamAntennaPattern value)
    {
        WriteBeamAntennaPatternFields(ref writer, value);
    }

    private static void WriteBeamAntennaPatternFields(ref DisBinaryWriter writer, BeamAntennaPattern value)
    {
        WriteEulerAngles(ref writer, value.BeamDirection);
        writer.WriteSingle(value.AzimuthBeamwidth, "azimuthBeamwidth");
        writer.WriteSingle(value.ElevationBeamwidth, "elevationBeamwidth");
        writer.WriteByte((byte)value.ReferenceSystem, "referenceSystem");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        writer.WriteSingle(value.Ez, "ez");
        writer.WriteSingle(value.Ex, "ex");
        writer.WriteSingle(value.Phase, "phase");
        writer.WriteUInt32(value.Padding3, "padding3");
    }

    private static void MeasureBeamAntennaPattern(in BeamAntennaPattern value, ref int offset)
    {
        MeasureBeamAntennaPatternFields(value, ref offset);
    }

    private static void MeasureBeamAntennaPatternFields(in BeamAntennaPattern value, ref int offset)
    {
        MeasureEulerAngles(value.BeamDirection, ref offset);
        offset += 4;
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static BeamData ReadBeamData(ref DisBinaryReader reader)
    {
        var value = new BeamData();
        ReadBeamDataFields(ref reader, value);
        return value;
    }

    private static void ReadBeamDataFields(ref DisBinaryReader reader, BeamData value)
    {
        value.BeamAzimuthCenter = reader.ReadSingle("beamAzimuthCenter");
        value.BeamAzimuthSweep = reader.ReadSingle("beamAzimuthSweep");
        value.BeamElevationCenter = reader.ReadSingle("beamElevationCenter");
        value.BeamElevationSweep = reader.ReadSingle("beamElevationSweep");
        value.BeamSweepSync = reader.ReadSingle("beamSweepSync");
    }

    private static void PrepareBeamData(BeamData value)
    {
        PrepareBeamDataFields(value);
    }

    private static void PrepareBeamDataFields(BeamData value)
    {
    }

    private static void WriteBeamData(ref DisBinaryWriter writer, BeamData value)
    {
        WriteBeamDataFields(ref writer, value);
    }

    private static void WriteBeamDataFields(ref DisBinaryWriter writer, BeamData value)
    {
        writer.WriteSingle(value.BeamAzimuthCenter, "beamAzimuthCenter");
        writer.WriteSingle(value.BeamAzimuthSweep, "beamAzimuthSweep");
        writer.WriteSingle(value.BeamElevationCenter, "beamElevationCenter");
        writer.WriteSingle(value.BeamElevationSweep, "beamElevationSweep");
        writer.WriteSingle(value.BeamSweepSync, "beamSweepSync");
    }

    private static void MeasureBeamData(in BeamData value, ref int offset)
    {
        MeasureBeamDataFields(value, ref offset);
    }

    private static void MeasureBeamDataFields(in BeamData value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static BeamStatus ReadBeamStatus(ref DisBinaryReader reader)
    {
        var value = new BeamStatus();
        ReadBeamStatusFields(ref reader, value);
        return value;
    }

    private static void ReadBeamStatusFields(ref DisBinaryReader reader, BeamStatus value)
    {
        value.BeamState = (BeamStatusBeamState)reader.ReadByte("beamState");
    }

    private static void PrepareBeamStatus(BeamStatus value)
    {
        PrepareBeamStatusFields(value);
    }

    private static void PrepareBeamStatusFields(BeamStatus value)
    {
    }

    private static void WriteBeamStatus(ref DisBinaryWriter writer, BeamStatus value)
    {
        WriteBeamStatusFields(ref writer, value);
    }

    private static void WriteBeamStatusFields(ref DisBinaryWriter writer, BeamStatus value)
    {
        writer.WriteByte((byte)value.BeamState, "beamState");
    }

    private static void MeasureBeamStatus(in BeamStatus value, ref int offset)
    {
        MeasureBeamStatusFields(value, ref offset);
    }

    private static void MeasureBeamStatusFields(in BeamStatus value, ref int offset)
    {
        offset += 1;
    }

    private static BlankingSector ReadBlankingSector(ref DisBinaryReader reader)
    {
        var value = new BlankingSector();
        ReadBlankingSectorFields(ref reader, value);
        return value;
    }

    private static void ReadBlankingSectorFields(ref DisBinaryReader reader, BlankingSector value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.Padding = reader.ReadUInt16("padding");
        value.EmitterNumber = reader.ReadByte("emitterNumber");
        value.BeamNumber = reader.ReadByte("beamNumber");
        value.StateIndicator = (EeAttributeStateIndicator)reader.ReadByte("stateIndicator");
        value.Padding2 = reader.ReadByte("padding2");
        value.LeftAzimuth = reader.ReadSingle("leftAzimuth");
        value.RightAzimuth = reader.ReadSingle("rightAzimuth");
        value.LowerElevation = reader.ReadSingle("lowerElevation");
        value.UpperElevation = reader.ReadSingle("upperElevation");
        value.ResidualPower = reader.ReadSingle("residualPower");
        value.Padding3 = reader.ReadUInt64("padding3");
    }

    private static void PrepareBlankingSector(BlankingSector value)
    {
        PrepareBlankingSectorFields(value);
    }

    private static void PrepareBlankingSectorFields(BlankingSector value)
    {
    }

    private static void WriteBlankingSector(ref DisBinaryWriter writer, BlankingSector value)
    {
        WriteBlankingSectorFields(ref writer, value);
    }

    private static void WriteBlankingSectorFields(ref DisBinaryWriter writer, BlankingSector value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteByte(value.EmitterNumber, "emitterNumber");
        writer.WriteByte(value.BeamNumber, "beamNumber");
        writer.WriteByte((byte)value.StateIndicator, "stateIndicator");
        writer.WriteByte(value.Padding2, "padding2");
        writer.WriteSingle(value.LeftAzimuth, "leftAzimuth");
        writer.WriteSingle(value.RightAzimuth, "rightAzimuth");
        writer.WriteSingle(value.LowerElevation, "lowerElevation");
        writer.WriteSingle(value.UpperElevation, "upperElevation");
        writer.WriteSingle(value.ResidualPower, "residualPower");
        writer.WriteUInt64(value.Padding3, "padding3");
    }

    private static void MeasureBlankingSector(in BlankingSector value, ref int offset)
    {
        MeasureBlankingSectorFields(value, ref offset);
    }

    private static void MeasureBlankingSectorFields(in BlankingSector value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 8;
    }

    private static ChangeOptions ReadChangeOptions(ref DisBinaryReader reader)
    {
        var value = new ChangeOptions();
        ReadChangeOptionsFields(ref reader, value);
        return value;
    }

    private static void ReadChangeOptionsFields(ref DisBinaryReader reader, ChangeOptions value)
    {
        value.Value = reader.ReadByte("value");
    }

    private static void PrepareChangeOptions(ChangeOptions value)
    {
        PrepareChangeOptionsFields(value);
    }

    private static void PrepareChangeOptionsFields(ChangeOptions value)
    {
    }

    private static void WriteChangeOptions(ref DisBinaryWriter writer, ChangeOptions value)
    {
        WriteChangeOptionsFields(ref writer, value);
    }

    private static void WriteChangeOptionsFields(ref DisBinaryWriter writer, ChangeOptions value)
    {
        writer.WriteByte(value.Value, "value");
    }

    private static void MeasureChangeOptions(in ChangeOptions value, ref int offset)
    {
        MeasureChangeOptionsFields(value, ref offset);
    }

    private static void MeasureChangeOptionsFields(in ChangeOptions value, ref int offset)
    {
        offset += 1;
    }

    private static ClockTime ReadClockTime(ref DisBinaryReader reader)
    {
        var value = new ClockTime();
        ReadClockTimeFields(ref reader, value);
        return value;
    }

    private static void ReadClockTimeFields(ref DisBinaryReader reader, ClockTime value)
    {
        value.Hour = reader.ReadUInt32("hour");
        value.TimePastHour = reader.ReadUInt32("timePastHour");
    }

    private static void PrepareClockTime(ClockTime value)
    {
        PrepareClockTimeFields(value);
    }

    private static void PrepareClockTimeFields(ClockTime value)
    {
    }

    private static void WriteClockTime(ref DisBinaryWriter writer, ClockTime value)
    {
        WriteClockTimeFields(ref writer, value);
    }

    private static void WriteClockTimeFields(ref DisBinaryWriter writer, ClockTime value)
    {
        writer.WriteUInt32(value.Hour, "hour");
        writer.WriteUInt32(value.TimePastHour, "timePastHour");
    }

    private static void MeasureClockTime(in ClockTime value, ref int offset)
    {
        MeasureClockTimeFields(value, ref offset);
    }

    private static void MeasureClockTimeFields(in ClockTime value, ref int offset)
    {
        offset += 4;
        offset += 4;
    }

    private static void ReadCollisionElasticPduFields(ref DisBinaryReader reader, CollisionElasticPdu value)
    {
        value.IssuingEntityId = ReadEntityId(ref reader);
        value.CollidingEntityId = ReadEntityId(ref reader);
        value.CollisionEventId = ReadEventIdentifier(ref reader);
        value.Pad = reader.ReadUInt16("pad");
        value.ContactVelocity = ReadVector3Float(ref reader);
        value.Mass = reader.ReadSingle("mass");
        value.LocationOfImpact = ReadVector3Float(ref reader);
        value.CollisionIntermediateResultXX = reader.ReadSingle("collisionIntermediateResultXX");
        value.CollisionIntermediateResultXY = reader.ReadSingle("collisionIntermediateResultXY");
        value.CollisionIntermediateResultXZ = reader.ReadSingle("collisionIntermediateResultXZ");
        value.CollisionIntermediateResultYY = reader.ReadSingle("collisionIntermediateResultYY");
        value.CollisionIntermediateResultYZ = reader.ReadSingle("collisionIntermediateResultYZ");
        value.CollisionIntermediateResultZZ = reader.ReadSingle("collisionIntermediateResultZZ");
        value.UnitSurfaceNormal = ReadVector3Float(ref reader);
        value.CoefficientOfRestitution = reader.ReadSingle("coefficientOfRestitution");
    }

    private static void PrepareCollisionElasticPduFields(CollisionElasticPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.IssuingEntityId);
        PrepareEntityId(value.IssuingEntityId);
        ArgumentNullException.ThrowIfNull(value.CollidingEntityId);
        PrepareEntityId(value.CollidingEntityId);
        ArgumentNullException.ThrowIfNull(value.CollisionEventId);
        PrepareEventIdentifier(value.CollisionEventId);
        ArgumentNullException.ThrowIfNull(value.ContactVelocity);
        PrepareVector3Float(value.ContactVelocity);
        ArgumentNullException.ThrowIfNull(value.LocationOfImpact);
        PrepareVector3Float(value.LocationOfImpact);
        ArgumentNullException.ThrowIfNull(value.UnitSurfaceNormal);
        PrepareVector3Float(value.UnitSurfaceNormal);
    }

    private static void WriteCollisionElasticPduFields(ref DisBinaryWriter writer, CollisionElasticPdu value)
    {
        WriteEntityId(ref writer, value.IssuingEntityId);
        WriteEntityId(ref writer, value.CollidingEntityId);
        WriteEventIdentifier(ref writer, value.CollisionEventId);
        writer.WriteUInt16(value.Pad, "pad");
        WriteVector3Float(ref writer, value.ContactVelocity);
        writer.WriteSingle(value.Mass, "mass");
        WriteVector3Float(ref writer, value.LocationOfImpact);
        writer.WriteSingle(value.CollisionIntermediateResultXX, "collisionIntermediateResultXX");
        writer.WriteSingle(value.CollisionIntermediateResultXY, "collisionIntermediateResultXY");
        writer.WriteSingle(value.CollisionIntermediateResultXZ, "collisionIntermediateResultXZ");
        writer.WriteSingle(value.CollisionIntermediateResultYY, "collisionIntermediateResultYY");
        writer.WriteSingle(value.CollisionIntermediateResultYZ, "collisionIntermediateResultYZ");
        writer.WriteSingle(value.CollisionIntermediateResultZZ, "collisionIntermediateResultZZ");
        WriteVector3Float(ref writer, value.UnitSurfaceNormal);
        writer.WriteSingle(value.CoefficientOfRestitution, "coefficientOfRestitution");
    }

    private static void MeasureCollisionElasticPduFields(in CollisionElasticPdu value, ref int offset)
    {
        MeasureEntityId(value.IssuingEntityId, ref offset);
        MeasureEntityId(value.CollidingEntityId, ref offset);
        MeasureEventIdentifier(value.CollisionEventId, ref offset);
        offset += 2;
        MeasureVector3Float(value.ContactVelocity, ref offset);
        offset += 4;
        MeasureVector3Float(value.LocationOfImpact, ref offset);
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        MeasureVector3Float(value.UnitSurfaceNormal, ref offset);
        offset += 4;
    }

    private static void ReadCollisionPduFields(ref DisBinaryReader reader, CollisionPdu value)
    {
        value.IssuingEntityId = ReadEntityId(ref reader);
        value.CollidingEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.CollisionType = (CollisionType)reader.ReadByte("collisionType");
        value.Pad = reader.ReadByte("pad");
        value.Velocity = ReadVector3Float(ref reader);
        value.Mass = reader.ReadSingle("mass");
        value.Location = ReadVector3Float(ref reader);
    }

    private static void PrepareCollisionPduFields(CollisionPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.IssuingEntityId);
        PrepareEntityId(value.IssuingEntityId);
        ArgumentNullException.ThrowIfNull(value.CollidingEntityId);
        PrepareEntityId(value.CollidingEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.Velocity);
        PrepareVector3Float(value.Velocity);
        ArgumentNullException.ThrowIfNull(value.Location);
        PrepareVector3Float(value.Location);
    }

    private static void WriteCollisionPduFields(ref DisBinaryWriter writer, CollisionPdu value)
    {
        WriteEntityId(ref writer, value.IssuingEntityId);
        WriteEntityId(ref writer, value.CollidingEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        writer.WriteByte((byte)value.CollisionType, "collisionType");
        writer.WriteByte(value.Pad, "pad");
        WriteVector3Float(ref writer, value.Velocity);
        writer.WriteSingle(value.Mass, "mass");
        WriteVector3Float(ref writer, value.Location);
    }

    private static void MeasureCollisionPduFields(in CollisionPdu value, ref int offset)
    {
        MeasureEntityId(value.IssuingEntityId, ref offset);
        MeasureEntityId(value.CollidingEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        offset += 1;
        offset += 1;
        MeasureVector3Float(value.Velocity, ref offset);
        offset += 4;
        MeasureVector3Float(value.Location, ref offset);
    }

    private static void ReadCommentPduFields(ref DisBinaryReader reader, CommentPdu value)
    {
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareCommentPduFields(CommentPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteCommentPduFields(ref DisBinaryWriter writer, CommentPdu value)
    {
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureCommentPduFields(in CommentPdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadCommentReliablePduFields(ref DisBinaryReader reader, CommentReliablePdu value)
    {
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareCommentReliablePduFields(CommentReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteCommentReliablePduFields(ref DisBinaryWriter writer, CommentReliablePdu value)
    {
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureCommentReliablePduFields(in CommentReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static CommunicationsNodeID ReadCommunicationsNodeID(ref DisBinaryReader reader)
    {
        var value = new CommunicationsNodeID();
        ReadCommunicationsNodeIDFields(ref reader, value);
        return value;
    }

    private static void ReadCommunicationsNodeIDFields(ref DisBinaryReader reader, CommunicationsNodeID value)
    {
        value.EntityId = ReadEntityId(ref reader);
        value.ElementId = reader.ReadUInt16("elementID");
    }

    private static void PrepareCommunicationsNodeID(CommunicationsNodeID value)
    {
        PrepareCommunicationsNodeIDFields(value);
    }

    private static void PrepareCommunicationsNodeIDFields(CommunicationsNodeID value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
    }

    private static void WriteCommunicationsNodeID(ref DisBinaryWriter writer, CommunicationsNodeID value)
    {
        WriteCommunicationsNodeIDFields(ref writer, value);
    }

    private static void WriteCommunicationsNodeIDFields(ref DisBinaryWriter writer, CommunicationsNodeID value)
    {
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteUInt16(value.ElementId, "elementID");
    }

    private static void MeasureCommunicationsNodeID(in CommunicationsNodeID value, ref int offset)
    {
        MeasureCommunicationsNodeIDFields(value, ref offset);
    }

    private static void MeasureCommunicationsNodeIDFields(in CommunicationsNodeID value, ref int offset)
    {
        MeasureEntityId(value.EntityId, ref offset);
        offset += 2;
    }

    private static void ReadCreateEntityPduFields(ref DisBinaryReader reader, CreateEntityPdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareCreateEntityPduFields(CreateEntityPdu value)
    {
    }

    private static void WriteCreateEntityPduFields(ref DisBinaryWriter writer, CreateEntityPdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureCreateEntityPduFields(in CreateEntityPdu value, ref int offset)
    {
        offset += 4;
    }

    private static void ReadCreateEntityReliablePduFields(ref DisBinaryReader reader, CreateEntityReliablePdu value)
    {
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareCreateEntityReliablePduFields(CreateEntityReliablePdu value)
    {
    }

    private static void WriteCreateEntityReliablePduFields(ref DisBinaryWriter writer, CreateEntityReliablePdu value)
    {
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureCreateEntityReliablePduFields(in CreateEntityReliablePdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
    }

    private static DataFilterRecord ReadDataFilterRecord(ref DisBinaryReader reader)
    {
        var value = new DataFilterRecord();
        ReadDataFilterRecordFields(ref reader, value);
        return value;
    }

    private static void ReadDataFilterRecordFields(ref DisBinaryReader reader, DataFilterRecord value)
    {
        value.BitFlags = reader.ReadUInt32("bitFlags");
    }

    private static void PrepareDataFilterRecord(DataFilterRecord value)
    {
        PrepareDataFilterRecordFields(value);
    }

    private static void PrepareDataFilterRecordFields(DataFilterRecord value)
    {
    }

    private static void WriteDataFilterRecord(ref DisBinaryWriter writer, DataFilterRecord value)
    {
        WriteDataFilterRecordFields(ref writer, value);
    }

    private static void WriteDataFilterRecordFields(ref DisBinaryWriter writer, DataFilterRecord value)
    {
        writer.WriteUInt32(value.BitFlags, "bitFlags");
    }

    private static void MeasureDataFilterRecord(in DataFilterRecord value, ref int offset)
    {
        MeasureDataFilterRecordFields(value, ref offset);
    }

    private static void MeasureDataFilterRecordFields(in DataFilterRecord value, ref int offset)
    {
        offset += 4;
    }

    private static void ReadDataPduFields(ref DisBinaryReader reader, DataPdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.Padding1 = reader.ReadUInt32("padding1");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatums");
        value.FixedDatums = new List<FixedDatum>(FixedDatumsCount);
        for (int index = 0; index < FixedDatumsCount; index++)
            value.FixedDatums.Add(ReadFixedDatum(ref reader));
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareDataPduFields(DataPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatums);
        foreach (FixedDatum item in value.FixedDatums) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatums.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteDataPduFields(ref DisBinaryWriter writer, DataPdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32(value.Padding1, "padding1");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatums) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureDataPduFields(in DataPdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatums) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static DataQueryDatumSpecification ReadDataQueryDatumSpecification(ref DisBinaryReader reader)
    {
        var value = new DataQueryDatumSpecification();
        ReadDataQueryDatumSpecificationFields(ref reader, value);
        return value;
    }

    private static void ReadDataQueryDatumSpecificationFields(ref DisBinaryReader reader, DataQueryDatumSpecification value)
    {
        value.NumberOfFixedDatums = reader.ReadUInt32("numberOfFixedDatums");
        value.NumberOfVariableDatums = reader.ReadUInt32("numberOfVariableDatums");
        int FixedDatumIdListCount = CheckedCount(checked((int)value.NumberOfFixedDatums), reader.Remaining, "fixedDatumIDList");
        value.FixedDatumIdList = new List<UnsignedDISInteger>(FixedDatumIdListCount);
        for (int index = 0; index < FixedDatumIdListCount; index++)
            value.FixedDatumIdList.Add(ReadUnsignedDISInteger(ref reader));
        int VariableDatumIdListCount = CheckedCount(checked((int)value.NumberOfVariableDatums), reader.Remaining, "variableDatumIDList");
        value.VariableDatumIdList = new List<UnsignedDISInteger>(VariableDatumIdListCount);
        for (int index = 0; index < VariableDatumIdListCount; index++)
            value.VariableDatumIdList.Add(ReadUnsignedDISInteger(ref reader));
    }

    private static void PrepareDataQueryDatumSpecification(DataQueryDatumSpecification value)
    {
        PrepareDataQueryDatumSpecificationFields(value);
    }

    private static void PrepareDataQueryDatumSpecificationFields(DataQueryDatumSpecification value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumIdList);
        foreach (UnsignedDISInteger item in value.FixedDatumIdList) PrepareUnsignedDISInteger(item);
        value.NumberOfFixedDatums = checked((uint)value.FixedDatumIdList.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumIdList);
        foreach (UnsignedDISInteger item in value.VariableDatumIdList) PrepareUnsignedDISInteger(item);
        value.NumberOfVariableDatums = checked((uint)value.VariableDatumIdList.Count);
    }

    private static void WriteDataQueryDatumSpecification(ref DisBinaryWriter writer, DataQueryDatumSpecification value)
    {
        WriteDataQueryDatumSpecificationFields(ref writer, value);
    }

    private static void WriteDataQueryDatumSpecificationFields(ref DisBinaryWriter writer, DataQueryDatumSpecification value)
    {
        writer.WriteUInt32(value.NumberOfFixedDatums, "numberOfFixedDatums");
        writer.WriteUInt32(value.NumberOfVariableDatums, "numberOfVariableDatums");
        foreach (UnsignedDISInteger item in value.FixedDatumIdList) WriteUnsignedDISInteger(ref writer, item);
        foreach (UnsignedDISInteger item in value.VariableDatumIdList) WriteUnsignedDISInteger(ref writer, item);
    }

    private static void MeasureDataQueryDatumSpecification(in DataQueryDatumSpecification value, ref int offset)
    {
        MeasureDataQueryDatumSpecificationFields(value, ref offset);
    }

    private static void MeasureDataQueryDatumSpecificationFields(in DataQueryDatumSpecification value, ref int offset)
    {
        offset += 4;
        offset += 4;
        foreach (UnsignedDISInteger item in value.FixedDatumIdList) MeasureUnsignedDISInteger(item, ref offset);
        foreach (UnsignedDISInteger item in value.VariableDatumIdList) MeasureUnsignedDISInteger(item, ref offset);
    }

    private static void ReadDataQueryPduFields(ref DisBinaryReader reader, DataQueryPdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.TimeInterval = reader.ReadUInt32("timeInterval");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatums");
        value.FixedDatums = new List<FixedDatum>(FixedDatumsCount);
        for (int index = 0; index < FixedDatumsCount; index++)
            value.FixedDatums.Add(ReadFixedDatum(ref reader));
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareDataQueryPduFields(DataQueryPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatums);
        foreach (FixedDatum item in value.FixedDatums) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatums.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteDataQueryPduFields(ref DisBinaryWriter writer, DataQueryPdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32(value.TimeInterval, "timeInterval");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatums) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureDataQueryPduFields(in DataQueryPdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatums) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadDataQueryReliablePduFields(ref DisBinaryReader reader, DataQueryReliablePdu value)
    {
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.RequestId = reader.ReadUInt32("requestID");
        value.TimeInterval = reader.ReadUInt32("timeInterval");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumRecordsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatumRecords");
        value.FixedDatumRecords = new List<FixedDatum>(FixedDatumRecordsCount);
        for (int index = 0; index < FixedDatumRecordsCount; index++)
            value.FixedDatumRecords.Add(ReadFixedDatum(ref reader));
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareDataQueryReliablePduFields(DataQueryReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumRecords);
        foreach (FixedDatum item in value.FixedDatumRecords) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatumRecords.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteDataQueryReliablePduFields(ref DisBinaryWriter writer, DataQueryReliablePdu value)
    {
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32(value.TimeInterval, "timeInterval");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatumRecords) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureDataQueryReliablePduFields(in DataQueryReliablePdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumRecords) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadDataReliablePduFields(ref DisBinaryReader reader, DataReliablePdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumRecordsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatumRecords");
        value.FixedDatumRecords = new List<FixedDatum>(FixedDatumRecordsCount);
        for (int index = 0; index < FixedDatumRecordsCount; index++)
            value.FixedDatumRecords.Add(ReadFixedDatum(ref reader));
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareDataReliablePduFields(DataReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumRecords);
        foreach (FixedDatum item in value.FixedDatumRecords) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatumRecords.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteDataReliablePduFields(ref DisBinaryWriter writer, DataReliablePdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatumRecords) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureDataReliablePduFields(in DataReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumRecords) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static DatumSpecification ReadDatumSpecification(ref DisBinaryReader reader)
    {
        var value = new DatumSpecification();
        ReadDatumSpecificationFields(ref reader, value);
        return value;
    }

    private static void ReadDatumSpecificationFields(ref DisBinaryReader reader, DatumSpecification value)
    {
        value.NumberOfFixedDatums = reader.ReadUInt32("numberOfFixedDatums");
        value.NumberOfVariableDatums = reader.ReadUInt32("numberOfVariableDatums");
        int FixedDatumIdListCount = CheckedCount(checked((int)value.NumberOfFixedDatums), reader.Remaining, "fixedDatumIDList");
        value.FixedDatumIdList = new List<FixedDatum>(FixedDatumIdListCount);
        for (int index = 0; index < FixedDatumIdListCount; index++)
            value.FixedDatumIdList.Add(ReadFixedDatum(ref reader));
        int VariableDatumIdListCount = CheckedCount(checked((int)value.NumberOfVariableDatums), reader.Remaining, "variableDatumIDList");
        value.VariableDatumIdList = new List<VariableDatum>(VariableDatumIdListCount);
        for (int index = 0; index < VariableDatumIdListCount; index++)
            value.VariableDatumIdList.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareDatumSpecification(DatumSpecification value)
    {
        PrepareDatumSpecificationFields(value);
    }

    private static void PrepareDatumSpecificationFields(DatumSpecification value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumIdList);
        foreach (FixedDatum item in value.FixedDatumIdList) PrepareFixedDatum(item);
        value.NumberOfFixedDatums = checked((uint)value.FixedDatumIdList.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumIdList);
        foreach (VariableDatum item in value.VariableDatumIdList) PrepareVariableDatum(item);
        value.NumberOfVariableDatums = checked((uint)value.VariableDatumIdList.Count);
    }

    private static void WriteDatumSpecification(ref DisBinaryWriter writer, DatumSpecification value)
    {
        WriteDatumSpecificationFields(ref writer, value);
    }

    private static void WriteDatumSpecificationFields(ref DisBinaryWriter writer, DatumSpecification value)
    {
        writer.WriteUInt32(value.NumberOfFixedDatums, "numberOfFixedDatums");
        writer.WriteUInt32(value.NumberOfVariableDatums, "numberOfVariableDatums");
        foreach (FixedDatum item in value.FixedDatumIdList) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumIdList) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureDatumSpecification(in DatumSpecification value, ref int offset)
    {
        MeasureDatumSpecificationFields(value, ref offset);
    }

    private static void MeasureDatumSpecificationFields(in DatumSpecification value, ref int offset)
    {
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumIdList) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumIdList) MeasureVariableDatum(item, ref offset);
    }

    private static DeadReckoningParameters ReadDeadReckoningParameters(ref DisBinaryReader reader)
    {
        var value = new DeadReckoningParameters();
        ReadDeadReckoningParametersFields(ref reader, value);
        return value;
    }

    private static void ReadDeadReckoningParametersFields(ref DisBinaryReader reader, DeadReckoningParameters value)
    {
        value.DeadReckoningAlgorithm = (DeadReckoningAlgorithm)reader.ReadByte("deadReckoningAlgorithm");
        int ParametersCount = CheckedCount(15, reader.Remaining, "parameters");
        value.Parameters = new byte[ParametersCount];
        for (int index = 0; index < ParametersCount; index++)
            value.Parameters[index] = reader.ReadByte("parameters");
        value.EntityLinearAcceleration = ReadVector3Float(ref reader);
        value.EntityAngularVelocity = ReadVector3Float(ref reader);
    }

    private static void PrepareDeadReckoningParameters(DeadReckoningParameters value)
    {
        PrepareDeadReckoningParametersFields(value);
    }

    private static void PrepareDeadReckoningParametersFields(DeadReckoningParameters value)
    {
        ArgumentNullException.ThrowIfNull(value.Parameters);
        ArgumentNullException.ThrowIfNull(value.EntityLinearAcceleration);
        PrepareVector3Float(value.EntityLinearAcceleration);
        ArgumentNullException.ThrowIfNull(value.EntityAngularVelocity);
        PrepareVector3Float(value.EntityAngularVelocity);
    }

    private static void WriteDeadReckoningParameters(ref DisBinaryWriter writer, DeadReckoningParameters value)
    {
        WriteDeadReckoningParametersFields(ref writer, value);
    }

    private static void WriteDeadReckoningParametersFields(ref DisBinaryWriter writer, DeadReckoningParameters value)
    {
        writer.WriteByte((byte)value.DeadReckoningAlgorithm, "deadReckoningAlgorithm");
        foreach (byte item in value.Parameters) writer.WriteByte(item, "parameters");
        WriteVector3Float(ref writer, value.EntityLinearAcceleration);
        WriteVector3Float(ref writer, value.EntityAngularVelocity);
    }

    private static void MeasureDeadReckoningParameters(in DeadReckoningParameters value, ref int offset)
    {
        MeasureDeadReckoningParametersFields(value, ref offset);
    }

    private static void MeasureDeadReckoningParametersFields(in DeadReckoningParameters value, ref int offset)
    {
        offset += 1;
        offset += checked(value.Parameters.Length * 1);
        MeasureVector3Float(value.EntityLinearAcceleration, ref offset);
        MeasureVector3Float(value.EntityAngularVelocity, ref offset);
    }

    private static void ReadDesignatorPduFields(ref DisBinaryReader reader, DesignatorPdu value)
    {
        value.DesignatingEntityId = ReadEntityId(ref reader);
        value.CodeName = (DesignatorSystemName)reader.ReadUInt16("codeName");
        value.DesignatedEntityId = ReadEntityId(ref reader);
        value.DesignatorCode = (DesignatorDesignatorCode)reader.ReadUInt16("designatorCode");
        value.DesignatorPower = reader.ReadSingle("designatorPower");
        value.DesignatorWavelength = reader.ReadSingle("designatorWavelength");
        value.DesignatorSpotWrtDesignated = ReadVector3Float(ref reader);
        value.DesignatorSpotLocation = ReadVector3Double(ref reader);
        value.DeadReckoningAlgorithm = (DeadReckoningAlgorithm)reader.ReadByte("deadReckoningAlgorithm");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        value.EntityLinearAcceleration = ReadVector3Float(ref reader);
    }

    private static void PrepareDesignatorPduFields(DesignatorPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.DesignatingEntityId);
        PrepareEntityId(value.DesignatingEntityId);
        ArgumentNullException.ThrowIfNull(value.DesignatedEntityId);
        PrepareEntityId(value.DesignatedEntityId);
        ArgumentNullException.ThrowIfNull(value.DesignatorSpotWrtDesignated);
        PrepareVector3Float(value.DesignatorSpotWrtDesignated);
        ArgumentNullException.ThrowIfNull(value.DesignatorSpotLocation);
        PrepareVector3Double(value.DesignatorSpotLocation);
        ArgumentNullException.ThrowIfNull(value.EntityLinearAcceleration);
        PrepareVector3Float(value.EntityLinearAcceleration);
    }

    private static void WriteDesignatorPduFields(ref DisBinaryWriter writer, DesignatorPdu value)
    {
        WriteEntityId(ref writer, value.DesignatingEntityId);
        writer.WriteUInt16((ushort)value.CodeName, "codeName");
        WriteEntityId(ref writer, value.DesignatedEntityId);
        writer.WriteUInt16((ushort)value.DesignatorCode, "designatorCode");
        writer.WriteSingle(value.DesignatorPower, "designatorPower");
        writer.WriteSingle(value.DesignatorWavelength, "designatorWavelength");
        WriteVector3Float(ref writer, value.DesignatorSpotWrtDesignated);
        WriteVector3Double(ref writer, value.DesignatorSpotLocation);
        writer.WriteByte((byte)value.DeadReckoningAlgorithm, "deadReckoningAlgorithm");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        WriteVector3Float(ref writer, value.EntityLinearAcceleration);
    }

    private static void MeasureDesignatorPduFields(in DesignatorPdu value, ref int offset)
    {
        MeasureEntityId(value.DesignatingEntityId, ref offset);
        offset += 2;
        MeasureEntityId(value.DesignatedEntityId, ref offset);
        offset += 2;
        offset += 4;
        offset += 4;
        MeasureVector3Float(value.DesignatorSpotWrtDesignated, ref offset);
        MeasureVector3Double(value.DesignatorSpotLocation, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        MeasureVector3Float(value.EntityLinearAcceleration, ref offset);
    }

    private static void ReadDetonationPduFields(ref DisBinaryReader reader, DetonationPdu value)
    {
        value.SourceEntityId = ReadEntityId(ref reader);
        value.TargetEntityId = ReadEntityId(ref reader);
        value.ExplodingEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.Velocity = ReadVector3Float(ref reader);
        value.LocationInWorldCoordinates = ReadVector3Double(ref reader);
        value.Descriptor = ReadMunitionDescriptor(ref reader);
        value.LocationOfEntityCoordinates = ReadVector3Float(ref reader);
        value.DetonationResult = (DetonationResult)reader.ReadByte("detonationResult");
        value.NumberOfVariableParameters = reader.ReadByte("numberOfVariableParameters");
        value.Pad = reader.ReadUInt16("pad");
        int VariableParametersCount = CheckedCount(checked((int)value.NumberOfVariableParameters), reader.Remaining, "variableParameters");
        value.VariableParameters = new List<VariableParameter>(VariableParametersCount);
        for (int index = 0; index < VariableParametersCount; index++)
            value.VariableParameters.Add(ReadVariableParameter(ref reader));
    }

    private static void PrepareDetonationPduFields(DetonationPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.SourceEntityId);
        PrepareEntityId(value.SourceEntityId);
        ArgumentNullException.ThrowIfNull(value.TargetEntityId);
        PrepareEntityId(value.TargetEntityId);
        ArgumentNullException.ThrowIfNull(value.ExplodingEntityId);
        PrepareEntityId(value.ExplodingEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.Velocity);
        PrepareVector3Float(value.Velocity);
        ArgumentNullException.ThrowIfNull(value.LocationInWorldCoordinates);
        PrepareVector3Double(value.LocationInWorldCoordinates);
        ArgumentNullException.ThrowIfNull(value.Descriptor);
        PrepareMunitionDescriptor(value.Descriptor);
        ArgumentNullException.ThrowIfNull(value.LocationOfEntityCoordinates);
        PrepareVector3Float(value.LocationOfEntityCoordinates);
        ArgumentNullException.ThrowIfNull(value.VariableParameters);
        foreach (VariableParameter item in value.VariableParameters) PrepareVariableParameter(item);
        value.NumberOfVariableParameters = checked((byte)value.VariableParameters.Count);
    }

    private static void WriteDetonationPduFields(ref DisBinaryWriter writer, DetonationPdu value)
    {
        WriteEntityId(ref writer, value.SourceEntityId);
        WriteEntityId(ref writer, value.TargetEntityId);
        WriteEntityId(ref writer, value.ExplodingEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        WriteVector3Float(ref writer, value.Velocity);
        WriteVector3Double(ref writer, value.LocationInWorldCoordinates);
        WriteMunitionDescriptor(ref writer, value.Descriptor);
        WriteVector3Float(ref writer, value.LocationOfEntityCoordinates);
        writer.WriteByte((byte)value.DetonationResult, "detonationResult");
        writer.WriteByte(value.NumberOfVariableParameters, "numberOfVariableParameters");
        writer.WriteUInt16(value.Pad, "pad");
        foreach (VariableParameter item in value.VariableParameters) WriteVariableParameter(ref writer, item);
    }

    private static void MeasureDetonationPduFields(in DetonationPdu value, ref int offset)
    {
        MeasureEntityId(value.SourceEntityId, ref offset);
        MeasureEntityId(value.TargetEntityId, ref offset);
        MeasureEntityId(value.ExplodingEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        MeasureVector3Float(value.Velocity, ref offset);
        MeasureVector3Double(value.LocationInWorldCoordinates, ref offset);
        MeasureMunitionDescriptor(value.Descriptor, ref offset);
        MeasureVector3Float(value.LocationOfEntityCoordinates, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (VariableParameter item in value.VariableParameters) MeasureVariableParameter(item, ref offset);
    }

    private static DirectedEnergyAreaAimpoint ReadDirectedEnergyAreaAimpoint(ref DisBinaryReader reader)
    {
        var value = new DirectedEnergyAreaAimpoint();
        ReadDirectedEnergyAreaAimpointFields(ref reader, value);
        return value;
    }

    private static void ReadDirectedEnergyAreaAimpointFields(ref DisBinaryReader reader, DirectedEnergyAreaAimpoint value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.Padding = reader.ReadUInt16("padding");
        value.BeamAntennaPatternRecordCount = reader.ReadUInt16("beamAntennaPatternRecordCount");
        value.DirectedEnergyTargetEnergyDepositionRecordCount = reader.ReadUInt16("directedEnergyTargetEnergyDepositionRecordCount");
        int BeamAntennaParameterListCount = CheckedCount(checked((int)value.BeamAntennaPatternRecordCount), reader.Remaining, "beamAntennaParameterList");
        value.BeamAntennaParameterList = new List<BeamAntennaPattern>(BeamAntennaParameterListCount);
        for (int index = 0; index < BeamAntennaParameterListCount; index++)
            value.BeamAntennaParameterList.Add(ReadBeamAntennaPattern(ref reader));
        int DirectedEnergyTargetEnergyDepositionRecordListCount = CheckedCount(checked((int)value.DirectedEnergyTargetEnergyDepositionRecordCount), reader.Remaining, "directedEnergyTargetEnergyDepositionRecordList");
        value.DirectedEnergyTargetEnergyDepositionRecordList = new List<DirectedEnergyTargetEnergyDeposition>(DirectedEnergyTargetEnergyDepositionRecordListCount);
        for (int index = 0; index < DirectedEnergyTargetEnergyDepositionRecordListCount; index++)
            value.DirectedEnergyTargetEnergyDepositionRecordList.Add(ReadDirectedEnergyTargetEnergyDeposition(ref reader));
        reader.Skip(Padding(reader.Offset, 8), "padding2");
    }

    private static void PrepareDirectedEnergyAreaAimpoint(DirectedEnergyAreaAimpoint value)
    {
        PrepareDirectedEnergyAreaAimpointFields(value);
    }

    private static void PrepareDirectedEnergyAreaAimpointFields(DirectedEnergyAreaAimpoint value)
    {
        ArgumentNullException.ThrowIfNull(value.BeamAntennaParameterList);
        foreach (BeamAntennaPattern item in value.BeamAntennaParameterList) PrepareBeamAntennaPattern(item);
        value.BeamAntennaPatternRecordCount = checked((ushort)value.BeamAntennaParameterList.Count);
        ArgumentNullException.ThrowIfNull(value.DirectedEnergyTargetEnergyDepositionRecordList);
        foreach (DirectedEnergyTargetEnergyDeposition item in value.DirectedEnergyTargetEnergyDepositionRecordList) PrepareDirectedEnergyTargetEnergyDeposition(item);
        value.DirectedEnergyTargetEnergyDepositionRecordCount = checked((ushort)value.DirectedEnergyTargetEnergyDepositionRecordList.Count);
    }

    private static void WriteDirectedEnergyAreaAimpoint(ref DisBinaryWriter writer, DirectedEnergyAreaAimpoint value)
    {
        WriteDirectedEnergyAreaAimpointFields(ref writer, value);
    }

    private static void WriteDirectedEnergyAreaAimpointFields(ref DisBinaryWriter writer, DirectedEnergyAreaAimpoint value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteUInt16(value.BeamAntennaPatternRecordCount, "beamAntennaPatternRecordCount");
        writer.WriteUInt16(value.DirectedEnergyTargetEnergyDepositionRecordCount, "directedEnergyTargetEnergyDepositionRecordCount");
        foreach (BeamAntennaPattern item in value.BeamAntennaParameterList) WriteBeamAntennaPattern(ref writer, item);
        foreach (DirectedEnergyTargetEnergyDeposition item in value.DirectedEnergyTargetEnergyDepositionRecordList) WriteDirectedEnergyTargetEnergyDeposition(ref writer, item);
        writer.WriteZeros(Padding(writer.Offset, 8), "padding2");
    }

    private static void MeasureDirectedEnergyAreaAimpoint(in DirectedEnergyAreaAimpoint value, ref int offset)
    {
        MeasureDirectedEnergyAreaAimpointFields(value, ref offset);
    }

    private static void MeasureDirectedEnergyAreaAimpointFields(in DirectedEnergyAreaAimpoint value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        foreach (BeamAntennaPattern item in value.BeamAntennaParameterList) MeasureBeamAntennaPattern(item, ref offset);
        foreach (DirectedEnergyTargetEnergyDeposition item in value.DirectedEnergyTargetEnergyDepositionRecordList) MeasureDirectedEnergyTargetEnergyDeposition(item, ref offset);
        offset += Padding(offset, 8);
    }

    private static DirectedEnergyDamage ReadDirectedEnergyDamage(ref DisBinaryReader reader)
    {
        var value = new DirectedEnergyDamage();
        ReadDirectedEnergyDamageFields(ref reader, value);
        return value;
    }

    private static void ReadDirectedEnergyDamageFields(ref DisBinaryReader reader, DirectedEnergyDamage value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.Padding = reader.ReadUInt16("padding");
        value.DamageLocation = ReadVector3Float(ref reader);
        value.DamageDiameter = reader.ReadSingle("damageDiameter");
        value.Temperature = reader.ReadSingle("temperature");
        value.ComponentIdentification = (EntityDamageStatusComponentIdentification)reader.ReadByte("componentIdentification");
        value.ComponentDamageStatus = (DeDamageDescriptionComponentDamageStatus)reader.ReadByte("componentDamageStatus");
        value.ComponentVisualDamageStatus = new DeDamageDescriptionComponentVisualDamageStatus(reader.ReadByte("componentVisualDamageStatus"));
        value.ComponentVisualSmokeColor = (DeDamageDescriptionComponentVisualSmokeColor)reader.ReadByte("componentVisualSmokeColor");
        value.FireEventId = ReadEventIdentifier(ref reader);
        value.Padding2 = reader.ReadUInt16("padding2");
    }

    private static void PrepareDirectedEnergyDamage(DirectedEnergyDamage value)
    {
        PrepareDirectedEnergyDamageFields(value);
    }

    private static void PrepareDirectedEnergyDamageFields(DirectedEnergyDamage value)
    {
        ArgumentNullException.ThrowIfNull(value.DamageLocation);
        PrepareVector3Float(value.DamageLocation);
        ArgumentNullException.ThrowIfNull(value.FireEventId);
        PrepareEventIdentifier(value.FireEventId);
    }

    private static void WriteDirectedEnergyDamage(ref DisBinaryWriter writer, DirectedEnergyDamage value)
    {
        WriteDirectedEnergyDamageFields(ref writer, value);
    }

    private static void WriteDirectedEnergyDamageFields(ref DisBinaryWriter writer, DirectedEnergyDamage value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.Padding, "padding");
        WriteVector3Float(ref writer, value.DamageLocation);
        writer.WriteSingle(value.DamageDiameter, "damageDiameter");
        writer.WriteSingle(value.Temperature, "temperature");
        writer.WriteByte((byte)value.ComponentIdentification, "componentIdentification");
        writer.WriteByte((byte)value.ComponentDamageStatus, "componentDamageStatus");
        writer.WriteByte(value.ComponentVisualDamageStatus.Value, "componentVisualDamageStatus");
        writer.WriteByte((byte)value.ComponentVisualSmokeColor, "componentVisualSmokeColor");
        WriteEventIdentifier(ref writer, value.FireEventId);
        writer.WriteUInt16(value.Padding2, "padding2");
    }

    private static void MeasureDirectedEnergyDamage(in DirectedEnergyDamage value, ref int offset)
    {
        MeasureDirectedEnergyDamageFields(value, ref offset);
    }

    private static void MeasureDirectedEnergyDamageFields(in DirectedEnergyDamage value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 2;
        MeasureVector3Float(value.DamageLocation, ref offset);
        offset += 4;
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureEventIdentifier(value.FireEventId, ref offset);
        offset += 2;
    }

    private static void ReadDirectedEnergyFirePduFields(ref DisBinaryReader reader, DirectedEnergyFirePdu value)
    {
        value.FiringEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.MunitionType = ReadEntityType(ref reader);
        value.ShotStartTime = ReadClockTime(ref reader);
        value.CommulativeShotTime = reader.ReadSingle("commulativeShotTime");
        value.ApertureEmitterLocation = ReadVector3Float(ref reader);
        value.ApertureDiameter = reader.ReadSingle("apertureDiameter");
        value.Wavelength = reader.ReadSingle("wavelength");
        value.Pad1 = reader.ReadUInt32("pad1");
        value.PulseRepititionFrequency = reader.ReadSingle("pulseRepititionFrequency");
        value.PulseWidth = reader.ReadSingle("pulseWidth");
        value.Flags = new DeFireFlags(reader.ReadUInt16("flags"));
        value.PulseShape = (DeFirePulseShape)reader.ReadByte("pulseShape");
        value.Pad2 = reader.ReadByte("pad2");
        value.Pad3 = reader.ReadUInt32("pad3");
        value.Pad4 = reader.ReadUInt16("pad4");
        value.NumberOfDERecords = reader.ReadUInt16("numberOfDERecords");
        int DERecordsCount = CheckedCount(checked((int)value.NumberOfDERecords), reader.Remaining, "dERecords");
        value.DERecords = new List<StandardVariableSpecification>(DERecordsCount);
        for (int index = 0; index < DERecordsCount; index++)
            value.DERecords.Add(ReadStandardVariableSpecification(ref reader));
    }

    private static void PrepareDirectedEnergyFirePduFields(DirectedEnergyFirePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FiringEntityId);
        PrepareEntityId(value.FiringEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.MunitionType);
        PrepareEntityType(value.MunitionType);
        ArgumentNullException.ThrowIfNull(value.ShotStartTime);
        PrepareClockTime(value.ShotStartTime);
        ArgumentNullException.ThrowIfNull(value.ApertureEmitterLocation);
        PrepareVector3Float(value.ApertureEmitterLocation);
        ArgumentNullException.ThrowIfNull(value.DERecords);
        foreach (StandardVariableSpecification item in value.DERecords) PrepareStandardVariableSpecification(item);
        value.NumberOfDERecords = checked((ushort)value.DERecords.Count);
    }

    private static void WriteDirectedEnergyFirePduFields(ref DisBinaryWriter writer, DirectedEnergyFirePdu value)
    {
        WriteEntityId(ref writer, value.FiringEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        WriteEntityType(ref writer, value.MunitionType);
        WriteClockTime(ref writer, value.ShotStartTime);
        writer.WriteSingle(value.CommulativeShotTime, "commulativeShotTime");
        WriteVector3Float(ref writer, value.ApertureEmitterLocation);
        writer.WriteSingle(value.ApertureDiameter, "apertureDiameter");
        writer.WriteSingle(value.Wavelength, "wavelength");
        writer.WriteUInt32(value.Pad1, "pad1");
        writer.WriteSingle(value.PulseRepititionFrequency, "pulseRepititionFrequency");
        writer.WriteSingle(value.PulseWidth, "pulseWidth");
        writer.WriteUInt16(value.Flags.Value, "flags");
        writer.WriteByte((byte)value.PulseShape, "pulseShape");
        writer.WriteByte(value.Pad2, "pad2");
        writer.WriteUInt32(value.Pad3, "pad3");
        writer.WriteUInt16(value.Pad4, "pad4");
        writer.WriteUInt16(value.NumberOfDERecords, "numberOfDERecords");
        foreach (StandardVariableSpecification item in value.DERecords) WriteStandardVariableSpecification(ref writer, item);
    }

    private static void MeasureDirectedEnergyFirePduFields(in DirectedEnergyFirePdu value, ref int offset)
    {
        MeasureEntityId(value.FiringEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        MeasureEntityType(value.MunitionType, ref offset);
        MeasureClockTime(value.ShotStartTime, ref offset);
        offset += 4;
        MeasureVector3Float(value.ApertureEmitterLocation, ref offset);
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 2;
        offset += 2;
        foreach (StandardVariableSpecification item in value.DERecords) MeasureStandardVariableSpecification(item, ref offset);
    }

    private static DirectedEnergyPrecisionAimpoint ReadDirectedEnergyPrecisionAimpoint(ref DisBinaryReader reader)
    {
        var value = new DirectedEnergyPrecisionAimpoint();
        ReadDirectedEnergyPrecisionAimpointFields(ref reader, value);
        return value;
    }

    private static void ReadDirectedEnergyPrecisionAimpointFields(ref DisBinaryReader reader, DirectedEnergyPrecisionAimpoint value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.Padding = reader.ReadUInt16("padding");
        value.TargetSpotLocation = ReadVector3Double(ref reader);
        value.TargetSpotEntityLocation = ReadVector3Float(ref reader);
        value.TargetSpotVelocity = ReadVector3Float(ref reader);
        value.TargetSpotAcceleration = ReadVector3Float(ref reader);
        value.TargetEntityId = ReadEntityId(ref reader);
        value.TargetComponentId = reader.ReadByte("targetComponentID");
        value.BeamSpotType = (DePrecisionAimpointBeamSpotType)reader.ReadByte("beamSpotType");
        value.BeamSpotCrossSectionSemiMajorAxis = reader.ReadSingle("beamSpotCrossSectionSemiMajorAxis");
        value.BeamSpotCrossSectionSemiMinorAxis = reader.ReadSingle("beamSpotCrossSectionSemiMinorAxis");
        value.BeamSpotCrossSectionOrientationAngle = reader.ReadSingle("beamSpotCrossSectionOrientationAngle");
        value.PeakIrradiance = reader.ReadSingle("peakIrradiance");
        value.Padding2 = reader.ReadUInt32("padding2");
    }

    private static void PrepareDirectedEnergyPrecisionAimpoint(DirectedEnergyPrecisionAimpoint value)
    {
        PrepareDirectedEnergyPrecisionAimpointFields(value);
    }

    private static void PrepareDirectedEnergyPrecisionAimpointFields(DirectedEnergyPrecisionAimpoint value)
    {
        ArgumentNullException.ThrowIfNull(value.TargetSpotLocation);
        PrepareVector3Double(value.TargetSpotLocation);
        ArgumentNullException.ThrowIfNull(value.TargetSpotEntityLocation);
        PrepareVector3Float(value.TargetSpotEntityLocation);
        ArgumentNullException.ThrowIfNull(value.TargetSpotVelocity);
        PrepareVector3Float(value.TargetSpotVelocity);
        ArgumentNullException.ThrowIfNull(value.TargetSpotAcceleration);
        PrepareVector3Float(value.TargetSpotAcceleration);
        ArgumentNullException.ThrowIfNull(value.TargetEntityId);
        PrepareEntityId(value.TargetEntityId);
    }

    private static void WriteDirectedEnergyPrecisionAimpoint(ref DisBinaryWriter writer, DirectedEnergyPrecisionAimpoint value)
    {
        WriteDirectedEnergyPrecisionAimpointFields(ref writer, value);
    }

    private static void WriteDirectedEnergyPrecisionAimpointFields(ref DisBinaryWriter writer, DirectedEnergyPrecisionAimpoint value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.Padding, "padding");
        WriteVector3Double(ref writer, value.TargetSpotLocation);
        WriteVector3Float(ref writer, value.TargetSpotEntityLocation);
        WriteVector3Float(ref writer, value.TargetSpotVelocity);
        WriteVector3Float(ref writer, value.TargetSpotAcceleration);
        WriteEntityId(ref writer, value.TargetEntityId);
        writer.WriteByte(value.TargetComponentId, "targetComponentID");
        writer.WriteByte((byte)value.BeamSpotType, "beamSpotType");
        writer.WriteSingle(value.BeamSpotCrossSectionSemiMajorAxis, "beamSpotCrossSectionSemiMajorAxis");
        writer.WriteSingle(value.BeamSpotCrossSectionSemiMinorAxis, "beamSpotCrossSectionSemiMinorAxis");
        writer.WriteSingle(value.BeamSpotCrossSectionOrientationAngle, "beamSpotCrossSectionOrientationAngle");
        writer.WriteSingle(value.PeakIrradiance, "peakIrradiance");
        writer.WriteUInt32(value.Padding2, "padding2");
    }

    private static void MeasureDirectedEnergyPrecisionAimpoint(in DirectedEnergyPrecisionAimpoint value, ref int offset)
    {
        MeasureDirectedEnergyPrecisionAimpointFields(value, ref offset);
    }

    private static void MeasureDirectedEnergyPrecisionAimpointFields(in DirectedEnergyPrecisionAimpoint value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 2;
        MeasureVector3Double(value.TargetSpotLocation, ref offset);
        MeasureVector3Float(value.TargetSpotEntityLocation, ref offset);
        MeasureVector3Float(value.TargetSpotVelocity, ref offset);
        MeasureVector3Float(value.TargetSpotAcceleration, ref offset);
        MeasureEntityId(value.TargetEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static DirectedEnergyTargetEnergyDeposition ReadDirectedEnergyTargetEnergyDeposition(ref DisBinaryReader reader)
    {
        var value = new DirectedEnergyTargetEnergyDeposition();
        ReadDirectedEnergyTargetEnergyDepositionFields(ref reader, value);
        return value;
    }

    private static void ReadDirectedEnergyTargetEnergyDepositionFields(ref DisBinaryReader reader, DirectedEnergyTargetEnergyDeposition value)
    {
        value.TargetEntityId = ReadEntityId(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.PeakIrradiance = reader.ReadSingle("peakIrradiance");
    }

    private static void PrepareDirectedEnergyTargetEnergyDeposition(DirectedEnergyTargetEnergyDeposition value)
    {
        PrepareDirectedEnergyTargetEnergyDepositionFields(value);
    }

    private static void PrepareDirectedEnergyTargetEnergyDepositionFields(DirectedEnergyTargetEnergyDeposition value)
    {
        ArgumentNullException.ThrowIfNull(value.TargetEntityId);
        PrepareEntityId(value.TargetEntityId);
    }

    private static void WriteDirectedEnergyTargetEnergyDeposition(ref DisBinaryWriter writer, DirectedEnergyTargetEnergyDeposition value)
    {
        WriteDirectedEnergyTargetEnergyDepositionFields(ref writer, value);
    }

    private static void WriteDirectedEnergyTargetEnergyDepositionFields(ref DisBinaryWriter writer, DirectedEnergyTargetEnergyDeposition value)
    {
        WriteEntityId(ref writer, value.TargetEntityId);
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteSingle(value.PeakIrradiance, "peakIrradiance");
    }

    private static void MeasureDirectedEnergyTargetEnergyDeposition(in DirectedEnergyTargetEnergyDeposition value, ref int offset)
    {
        MeasureDirectedEnergyTargetEnergyDepositionFields(value, ref offset);
    }

    private static void MeasureDirectedEnergyTargetEnergyDepositionFields(in DirectedEnergyTargetEnergyDeposition value, ref int offset)
    {
        MeasureEntityId(value.TargetEntityId, ref offset);
        offset += 2;
        offset += 4;
    }

    private static void ReadDistributedEmissionsRegenerationFamilyPduFields(ref DisBinaryReader reader, DistributedEmissionsRegenerationFamilyPdu value)
    {
    }

    private static void PrepareDistributedEmissionsRegenerationFamilyPduFields(DistributedEmissionsRegenerationFamilyPdu value)
    {
    }

    private static void WriteDistributedEmissionsRegenerationFamilyPduFields(ref DisBinaryWriter writer, DistributedEmissionsRegenerationFamilyPdu value)
    {
    }

    private static void MeasureDistributedEmissionsRegenerationFamilyPduFields(in DistributedEmissionsRegenerationFamilyPdu value, ref int offset)
    {
    }

    private static Domain ReadDomain(ref DisBinaryReader reader)
    {
        var value = new Domain();
        ReadDomainFields(ref reader, value);
        return value;
    }

    private static void ReadDomainFields(ref DisBinaryReader reader, Domain value)
    {
        value.Value = reader.ReadByte("value");
    }

    private static void PrepareDomain(Domain value)
    {
        PrepareDomainFields(value);
    }

    private static void PrepareDomainFields(Domain value)
    {
    }

    private static void WriteDomain(ref DisBinaryWriter writer, Domain value)
    {
        WriteDomainFields(ref writer, value);
    }

    private static void WriteDomainFields(ref DisBinaryWriter writer, Domain value)
    {
        writer.WriteByte(value.Value, "value");
    }

    private static void MeasureDomain(in Domain value, ref int offset)
    {
        MeasureDomainFields(value, ref offset);
    }

    private static void MeasureDomainFields(in Domain value, ref int offset)
    {
        offset += 1;
    }

    private static EEFundamentalParameterData ReadEEFundamentalParameterData(ref DisBinaryReader reader)
    {
        var value = new EEFundamentalParameterData();
        ReadEEFundamentalParameterDataFields(ref reader, value);
        return value;
    }

    private static void ReadEEFundamentalParameterDataFields(ref DisBinaryReader reader, EEFundamentalParameterData value)
    {
        value.Frequency = reader.ReadSingle("frequency");
        value.FrequencyRange = reader.ReadSingle("frequencyRange");
        value.EffectiveRadiatedPower = reader.ReadSingle("effectiveRadiatedPower");
        value.PulseRepetitionFrequency = reader.ReadSingle("pulseRepetitionFrequency");
        value.PulseWidth = reader.ReadSingle("pulseWidth");
    }

    private static void PrepareEEFundamentalParameterData(EEFundamentalParameterData value)
    {
        PrepareEEFundamentalParameterDataFields(value);
    }

    private static void PrepareEEFundamentalParameterDataFields(EEFundamentalParameterData value)
    {
    }

    private static void WriteEEFundamentalParameterData(ref DisBinaryWriter writer, EEFundamentalParameterData value)
    {
        WriteEEFundamentalParameterDataFields(ref writer, value);
    }

    private static void WriteEEFundamentalParameterDataFields(ref DisBinaryWriter writer, EEFundamentalParameterData value)
    {
        writer.WriteSingle(value.Frequency, "frequency");
        writer.WriteSingle(value.FrequencyRange, "frequencyRange");
        writer.WriteSingle(value.EffectiveRadiatedPower, "effectiveRadiatedPower");
        writer.WriteSingle(value.PulseRepetitionFrequency, "pulseRepetitionFrequency");
        writer.WriteSingle(value.PulseWidth, "pulseWidth");
    }

    private static void MeasureEEFundamentalParameterData(in EEFundamentalParameterData value, ref int offset)
    {
        MeasureEEFundamentalParameterDataFields(value, ref offset);
    }

    private static void MeasureEEFundamentalParameterDataFields(in EEFundamentalParameterData value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static void ReadElectromagneticEmissionPduFields(ref DisBinaryReader reader, ElectromagneticEmissionPdu value)
    {
        value.EmittingEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.StateUpdateIndicator = (ElectromagneticEmissionStateUpdateIndicator)reader.ReadByte("stateUpdateIndicator");
        value.NumberOfSystems = reader.ReadByte("numberOfSystems");
        value.PaddingForEmissionsPdu = reader.ReadUInt16("paddingForEmissionsPdu");
        int SystemsCount = CheckedCount(checked((int)value.NumberOfSystems), reader.Remaining, "systems");
        value.Systems = new List<ElectronicEmitter>(SystemsCount);
        for (int index = 0; index < SystemsCount; index++)
            value.Systems.Add(ReadElectronicEmitter(ref reader));
    }

    private static void PrepareElectromagneticEmissionPduFields(ElectromagneticEmissionPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EmittingEntityId);
        PrepareEntityId(value.EmittingEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.Systems);
        foreach (ElectronicEmitter item in value.Systems) PrepareElectronicEmitter(item);
        value.NumberOfSystems = checked((byte)value.Systems.Count);
    }

    private static void WriteElectromagneticEmissionPduFields(ref DisBinaryWriter writer, ElectromagneticEmissionPdu value)
    {
        WriteEntityId(ref writer, value.EmittingEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        writer.WriteByte((byte)value.StateUpdateIndicator, "stateUpdateIndicator");
        writer.WriteByte(value.NumberOfSystems, "numberOfSystems");
        writer.WriteUInt16(value.PaddingForEmissionsPdu, "paddingForEmissionsPdu");
        foreach (ElectronicEmitter item in value.Systems) WriteElectronicEmitter(ref writer, item);
    }

    private static void MeasureElectromagneticEmissionPduFields(in ElectromagneticEmissionPdu value, ref int offset)
    {
        MeasureEntityId(value.EmittingEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (ElectronicEmitter item in value.Systems) MeasureElectronicEmitter(item, ref offset);
    }

    private static ElectronicEmitter ReadElectronicEmitter(ref DisBinaryReader reader)
    {
        var value = new ElectronicEmitter();
        ReadElectronicEmitterFields(ref reader, value);
        return value;
    }

    private static void ReadElectronicEmitterFields(ref DisBinaryReader reader, ElectronicEmitter value)
    {
        value.SystemDataLength = reader.ReadByte("systemDataLength");
        value.NumberOfBeams = reader.ReadByte("numberOfBeams");
        value.Padding = reader.ReadUInt16("padding");
        value.EmitterSystem = ReadEmitterSystem(ref reader);
        value.Location = ReadVector3Float(ref reader);
        int BeamsCount = CheckedCount(checked((int)value.NumberOfBeams), reader.Remaining, "beams");
        value.Beams = new List<EmitterBeam>(BeamsCount);
        for (int index = 0; index < BeamsCount; index++)
            value.Beams.Add(ReadEmitterBeam(ref reader));
    }

    private static void PrepareElectronicEmitter(ElectronicEmitter value)
    {
        PrepareElectronicEmitterFields(value);
    }

    private static void PrepareElectronicEmitterFields(ElectronicEmitter value)
    {
        ArgumentNullException.ThrowIfNull(value.EmitterSystem);
        PrepareEmitterSystem(value.EmitterSystem);
        ArgumentNullException.ThrowIfNull(value.Location);
        PrepareVector3Float(value.Location);
        ArgumentNullException.ThrowIfNull(value.Beams);
        foreach (EmitterBeam item in value.Beams) PrepareEmitterBeam(item);
        value.NumberOfBeams = checked((byte)value.Beams.Count);
    }

    private static void WriteElectronicEmitter(ref DisBinaryWriter writer, ElectronicEmitter value)
    {
        WriteElectronicEmitterFields(ref writer, value);
    }

    private static void WriteElectronicEmitterFields(ref DisBinaryWriter writer, ElectronicEmitter value)
    {
        writer.WriteByte(value.SystemDataLength, "systemDataLength");
        writer.WriteByte(value.NumberOfBeams, "numberOfBeams");
        writer.WriteUInt16(value.Padding, "padding");
        WriteEmitterSystem(ref writer, value.EmitterSystem);
        WriteVector3Float(ref writer, value.Location);
        foreach (EmitterBeam item in value.Beams) WriteEmitterBeam(ref writer, item);
    }

    private static void MeasureElectronicEmitter(in ElectronicEmitter value, ref int offset)
    {
        MeasureElectronicEmitterFields(value, ref offset);
    }

    private static void MeasureElectronicEmitterFields(in ElectronicEmitter value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        MeasureEmitterSystem(value.EmitterSystem, ref offset);
        MeasureVector3Float(value.Location, ref offset);
        foreach (EmitterBeam item in value.Beams) MeasureEmitterBeam(item, ref offset);
    }

    private static EmitterBeam ReadEmitterBeam(ref DisBinaryReader reader)
    {
        var value = new EmitterBeam();
        ReadEmitterBeamFields(ref reader, value);
        return value;
    }

    private static void ReadEmitterBeamFields(ref DisBinaryReader reader, EmitterBeam value)
    {
        value.BeamDataLength = reader.ReadByte("beamDataLength");
        value.BeamNumber = reader.ReadByte("beamNumber");
        value.BeamParameterIndex = reader.ReadUInt16("beamParameterIndex");
        value.FundamentalParameterData = ReadEEFundamentalParameterData(ref reader);
        value.BeamData = ReadBeamData(ref reader);
        value.BeamFunction = (ElectromagneticEmissionBeamFunction)reader.ReadByte("beamFunction");
        value.NumberOfTargets = reader.ReadByte("numberOfTargets");
        value.HighDensityTrackJam = (HighDensityTrackJam)reader.ReadByte("highDensityTrackJam");
        value.BeamStatus = ReadBeamStatus(ref reader);
        value.JammingTechnique = ReadJammingTechnique(ref reader);
        int TrackJamDataCount = CheckedCount(checked((int)value.NumberOfTargets), reader.Remaining, "trackJamData");
        value.TrackJamData = new List<TrackJamData>(TrackJamDataCount);
        for (int index = 0; index < TrackJamDataCount; index++)
            value.TrackJamData.Add(ReadTrackJamData(ref reader));
    }

    private static void PrepareEmitterBeam(EmitterBeam value)
    {
        PrepareEmitterBeamFields(value);
    }

    private static void PrepareEmitterBeamFields(EmitterBeam value)
    {
        ArgumentNullException.ThrowIfNull(value.FundamentalParameterData);
        PrepareEEFundamentalParameterData(value.FundamentalParameterData);
        ArgumentNullException.ThrowIfNull(value.BeamData);
        PrepareBeamData(value.BeamData);
        ArgumentNullException.ThrowIfNull(value.BeamStatus);
        PrepareBeamStatus(value.BeamStatus);
        ArgumentNullException.ThrowIfNull(value.JammingTechnique);
        PrepareJammingTechnique(value.JammingTechnique);
        ArgumentNullException.ThrowIfNull(value.TrackJamData);
        foreach (TrackJamData item in value.TrackJamData) PrepareTrackJamData(item);
        value.NumberOfTargets = checked((byte)value.TrackJamData.Count);
    }

    private static void WriteEmitterBeam(ref DisBinaryWriter writer, EmitterBeam value)
    {
        WriteEmitterBeamFields(ref writer, value);
    }

    private static void WriteEmitterBeamFields(ref DisBinaryWriter writer, EmitterBeam value)
    {
        writer.WriteByte(value.BeamDataLength, "beamDataLength");
        writer.WriteByte(value.BeamNumber, "beamNumber");
        writer.WriteUInt16(value.BeamParameterIndex, "beamParameterIndex");
        WriteEEFundamentalParameterData(ref writer, value.FundamentalParameterData);
        WriteBeamData(ref writer, value.BeamData);
        writer.WriteByte((byte)value.BeamFunction, "beamFunction");
        writer.WriteByte(value.NumberOfTargets, "numberOfTargets");
        writer.WriteByte((byte)value.HighDensityTrackJam, "highDensityTrackJam");
        WriteBeamStatus(ref writer, value.BeamStatus);
        WriteJammingTechnique(ref writer, value.JammingTechnique);
        foreach (TrackJamData item in value.TrackJamData) WriteTrackJamData(ref writer, item);
    }

    private static void MeasureEmitterBeam(in EmitterBeam value, ref int offset)
    {
        MeasureEmitterBeamFields(value, ref offset);
    }

    private static void MeasureEmitterBeamFields(in EmitterBeam value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        MeasureEEFundamentalParameterData(value.FundamentalParameterData, ref offset);
        MeasureBeamData(value.BeamData, ref offset);
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureBeamStatus(value.BeamStatus, ref offset);
        MeasureJammingTechnique(value.JammingTechnique, ref offset);
        foreach (TrackJamData item in value.TrackJamData) MeasureTrackJamData(item, ref offset);
    }

    private static EmitterSystem ReadEmitterSystem(ref DisBinaryReader reader)
    {
        var value = new EmitterSystem();
        ReadEmitterSystemFields(ref reader, value);
        return value;
    }

    private static void ReadEmitterSystemFields(ref DisBinaryReader reader, EmitterSystem value)
    {
        value.EmitterName = (EmitterName)reader.ReadUInt16("emitterName");
        value.EmitterFunction = (EmitterSystemFunction)reader.ReadByte("emitterFunction");
        value.EmitterIdNumber = reader.ReadByte("emitterIDNumber");
    }

    private static void PrepareEmitterSystem(EmitterSystem value)
    {
        PrepareEmitterSystemFields(value);
    }

    private static void PrepareEmitterSystemFields(EmitterSystem value)
    {
    }

    private static void WriteEmitterSystem(ref DisBinaryWriter writer, EmitterSystem value)
    {
        WriteEmitterSystemFields(ref writer, value);
    }

    private static void WriteEmitterSystemFields(ref DisBinaryWriter writer, EmitterSystem value)
    {
        writer.WriteUInt16((ushort)value.EmitterName, "emitterName");
        writer.WriteByte((byte)value.EmitterFunction, "emitterFunction");
        writer.WriteByte(value.EmitterIdNumber, "emitterIDNumber");
    }

    private static void MeasureEmitterSystem(in EmitterSystem value, ref int offset)
    {
        MeasureEmitterSystemFields(value, ref offset);
    }

    private static void MeasureEmitterSystemFields(in EmitterSystem value, ref int offset)
    {
        offset += 2;
        offset += 1;
        offset += 1;
    }

    private static EngineFuel ReadEngineFuel(ref DisBinaryReader reader)
    {
        var value = new EngineFuel();
        ReadEngineFuelFields(ref reader, value);
        return value;
    }

    private static void ReadEngineFuelFields(ref DisBinaryReader reader, EngineFuel value)
    {
        value.FuelQuantity = reader.ReadUInt32("fuelQuantity");
        value.FuelMeasurementUnits = (FuelMeasurementUnits)reader.ReadByte("fuelMeasurementUnits");
        value.FuelType = (SupplyFuelType)reader.ReadByte("fuelType");
        value.FuelLocation = (FuelLocation)reader.ReadByte("fuelLocation");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareEngineFuel(EngineFuel value)
    {
        PrepareEngineFuelFields(value);
    }

    private static void PrepareEngineFuelFields(EngineFuel value)
    {
    }

    private static void WriteEngineFuel(ref DisBinaryWriter writer, EngineFuel value)
    {
        WriteEngineFuelFields(ref writer, value);
    }

    private static void WriteEngineFuelFields(ref DisBinaryWriter writer, EngineFuel value)
    {
        writer.WriteUInt32(value.FuelQuantity, "fuelQuantity");
        writer.WriteByte((byte)value.FuelMeasurementUnits, "fuelMeasurementUnits");
        writer.WriteByte((byte)value.FuelType, "fuelType");
        writer.WriteByte((byte)value.FuelLocation, "fuelLocation");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureEngineFuel(in EngineFuel value, ref int offset)
    {
        MeasureEngineFuelFields(value, ref offset);
    }

    private static void MeasureEngineFuelFields(in EngineFuel value, ref int offset)
    {
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static EngineFuelReload ReadEngineFuelReload(ref DisBinaryReader reader)
    {
        var value = new EngineFuelReload();
        ReadEngineFuelReloadFields(ref reader, value);
        return value;
    }

    private static void ReadEngineFuelReloadFields(ref DisBinaryReader reader, EngineFuelReload value)
    {
        value.StandardQuantity = reader.ReadUInt32("standardQuantity");
        value.MaximumQuantity = reader.ReadUInt32("maximumQuantity");
        value.StandardQuantityReloadTime = reader.ReadUInt32("standardQuantityReloadTime");
        value.MaximumQuantityReloadTime = reader.ReadUInt32("maximumQuantityReloadTime");
        value.FuelMeasurmentUnits = (FuelMeasurementUnits)reader.ReadByte("fuelMeasurmentUnits");
        value.FuelType = (SupplyFuelType)reader.ReadByte("fuelType");
        value.FuelLocation = (FuelLocation)reader.ReadByte("fuelLocation");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareEngineFuelReload(EngineFuelReload value)
    {
        PrepareEngineFuelReloadFields(value);
    }

    private static void PrepareEngineFuelReloadFields(EngineFuelReload value)
    {
    }

    private static void WriteEngineFuelReload(ref DisBinaryWriter writer, EngineFuelReload value)
    {
        WriteEngineFuelReloadFields(ref writer, value);
    }

    private static void WriteEngineFuelReloadFields(ref DisBinaryWriter writer, EngineFuelReload value)
    {
        writer.WriteUInt32(value.StandardQuantity, "standardQuantity");
        writer.WriteUInt32(value.MaximumQuantity, "maximumQuantity");
        writer.WriteUInt32(value.StandardQuantityReloadTime, "standardQuantityReloadTime");
        writer.WriteUInt32(value.MaximumQuantityReloadTime, "maximumQuantityReloadTime");
        writer.WriteByte((byte)value.FuelMeasurmentUnits, "fuelMeasurmentUnits");
        writer.WriteByte((byte)value.FuelType, "fuelType");
        writer.WriteByte((byte)value.FuelLocation, "fuelLocation");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureEngineFuelReload(in EngineFuelReload value, ref int offset)
    {
        MeasureEngineFuelReloadFields(value, ref offset);
    }

    private static void MeasureEngineFuelReloadFields(in EngineFuelReload value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static EntityAssociationVP ReadEntityAssociationVP(ref DisBinaryReader reader)
    {
        var value = new EntityAssociationVP();
        ReadEntityAssociationVPFields(ref reader, value);
        return value;
    }

    private static void ReadEntityAssociationVPFields(ref DisBinaryReader reader, EntityAssociationVP value)
    {
        value.RecordType = (VariableParameterRecordType)reader.ReadByte("recordType");
        value.ChangeIndicator = (EntityVpRecordChangeIndicator)reader.ReadByte("changeIndicator");
        value.AssociationStatus = (EntityAssociationAssociationType)reader.ReadByte("associationStatus");
        value.AssociationType = (EntityAssociationPhysicalAssociationType)reader.ReadByte("associationType");
        value.EntityId = ReadEntityId(ref reader);
        value.OwnStationLocation = (IsPartOfStationName)reader.ReadUInt16("ownStationLocation");
        value.PhysicalConnectionType = (EntityAssociationPhysicalConnectionType)reader.ReadByte("physicalConnectionType");
        value.GroupMemberType = (EntityAssociationGroupMemberType)reader.ReadByte("groupMemberType");
        value.GroupNumber = reader.ReadUInt16("groupNumber");
    }

    private static void PrepareEntityAssociationVP(EntityAssociationVP value)
    {
        PrepareEntityAssociationVPFields(value);
    }

    private static void PrepareEntityAssociationVPFields(EntityAssociationVP value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
    }

    private static void WriteEntityAssociationVP(ref DisBinaryWriter writer, EntityAssociationVP value)
    {
        WriteEntityAssociationVPFields(ref writer, value);
    }

    private static void WriteEntityAssociationVPFields(ref DisBinaryWriter writer, EntityAssociationVP value)
    {
        writer.WriteByte((byte)value.RecordType, "recordType");
        writer.WriteByte((byte)value.ChangeIndicator, "changeIndicator");
        writer.WriteByte((byte)value.AssociationStatus, "associationStatus");
        writer.WriteByte((byte)value.AssociationType, "associationType");
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteUInt16((ushort)value.OwnStationLocation, "ownStationLocation");
        writer.WriteByte((byte)value.PhysicalConnectionType, "physicalConnectionType");
        writer.WriteByte((byte)value.GroupMemberType, "groupMemberType");
        writer.WriteUInt16(value.GroupNumber, "groupNumber");
    }

    private static void MeasureEntityAssociationVP(in EntityAssociationVP value, ref int offset)
    {
        MeasureEntityAssociationVPFields(value, ref offset);
    }

    private static void MeasureEntityAssociationVPFields(in EntityAssociationVP value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureEntityId(value.EntityId, ref offset);
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 2;
    }

    private static void ReadEntityDamageStatusPduFields(ref DisBinaryReader reader, EntityDamageStatusPdu value)
    {
        value.DamagedEntityId = ReadEntityId(ref reader);
        value.Padding1 = reader.ReadUInt16("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        value.NumberOfDamageDescription = reader.ReadUInt16("numberOfDamageDescription");
        int DamageDescriptionRecordsCount = CheckedCount(checked((int)value.NumberOfDamageDescription), reader.Remaining, "damageDescriptionRecords");
        value.DamageDescriptionRecords = new List<DirectedEnergyDamage>(DamageDescriptionRecordsCount);
        for (int index = 0; index < DamageDescriptionRecordsCount; index++)
            value.DamageDescriptionRecords.Add(ReadDirectedEnergyDamage(ref reader));
    }

    private static void PrepareEntityDamageStatusPduFields(EntityDamageStatusPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.DamagedEntityId);
        PrepareEntityId(value.DamagedEntityId);
        ArgumentNullException.ThrowIfNull(value.DamageDescriptionRecords);
        foreach (DirectedEnergyDamage item in value.DamageDescriptionRecords) PrepareDirectedEnergyDamage(item);
        value.NumberOfDamageDescription = checked((ushort)value.DamageDescriptionRecords.Count);
    }

    private static void WriteEntityDamageStatusPduFields(ref DisBinaryWriter writer, EntityDamageStatusPdu value)
    {
        WriteEntityId(ref writer, value.DamagedEntityId);
        writer.WriteUInt16(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        writer.WriteUInt16(value.NumberOfDamageDescription, "numberOfDamageDescription");
        foreach (DirectedEnergyDamage item in value.DamageDescriptionRecords) WriteDirectedEnergyDamage(ref writer, item);
    }

    private static void MeasureEntityDamageStatusPduFields(in EntityDamageStatusPdu value, ref int offset)
    {
        MeasureEntityId(value.DamagedEntityId, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        foreach (DirectedEnergyDamage item in value.DamageDescriptionRecords) MeasureDirectedEnergyDamage(item, ref offset);
    }

    private static EntityId ReadEntityId(ref DisBinaryReader reader)
    {
        var value = new EntityId();
        ReadEntityIdFields(ref reader, value);
        return value;
    }

    private static void ReadEntityIdFields(ref DisBinaryReader reader, EntityId value)
    {
        value.SiteId = reader.ReadUInt16("siteID");
        value.ApplicationId = reader.ReadUInt16("applicationID");
        value.EntityNumber = reader.ReadUInt16("entityID");
    }

    private static void PrepareEntityId(EntityId value)
    {
        PrepareEntityIdFields(value);
    }

    private static void PrepareEntityIdFields(EntityId value)
    {
    }

    private static void WriteEntityId(ref DisBinaryWriter writer, EntityId value)
    {
        WriteEntityIdFields(ref writer, value);
    }

    private static void WriteEntityIdFields(ref DisBinaryWriter writer, EntityId value)
    {
        writer.WriteUInt16(value.SiteId, "siteID");
        writer.WriteUInt16(value.ApplicationId, "applicationID");
        writer.WriteUInt16(value.EntityNumber, "entityID");
    }

    private static void MeasureEntityId(in EntityId value, ref int offset)
    {
        MeasureEntityIdFields(value, ref offset);
    }

    private static void MeasureEntityIdFields(in EntityId value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static EntityIdentifier ReadEntityIdentifier(ref DisBinaryReader reader)
    {
        var value = new EntityIdentifier();
        ReadEntityIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadEntityIdentifierFields(ref DisBinaryReader reader, EntityIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.EntityNumber = reader.ReadUInt16("entityNumber");
    }

    private static void PrepareEntityIdentifier(EntityIdentifier value)
    {
        PrepareEntityIdentifierFields(value);
    }

    private static void PrepareEntityIdentifierFields(EntityIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteEntityIdentifier(ref DisBinaryWriter writer, EntityIdentifier value)
    {
        WriteEntityIdentifierFields(ref writer, value);
    }

    private static void WriteEntityIdentifierFields(ref DisBinaryWriter writer, EntityIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.EntityNumber, "entityNumber");
    }

    private static void MeasureEntityIdentifier(in EntityIdentifier value, ref int offset)
    {
        MeasureEntityIdentifierFields(value, ref offset);
    }

    private static void MeasureEntityIdentifierFields(in EntityIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static void ReadEntityInformationInteractionFamilyPduFields(ref DisBinaryReader reader, EntityInformationInteractionFamilyPdu value)
    {
    }

    private static void PrepareEntityInformationInteractionFamilyPduFields(EntityInformationInteractionFamilyPdu value)
    {
    }

    private static void WriteEntityInformationInteractionFamilyPduFields(ref DisBinaryWriter writer, EntityInformationInteractionFamilyPdu value)
    {
    }

    private static void MeasureEntityInformationInteractionFamilyPduFields(in EntityInformationInteractionFamilyPdu value, ref int offset)
    {
    }

    private static void ReadEntityManagementFamilyPduFields(ref DisBinaryReader reader, EntityManagementFamilyPdu value)
    {
    }

    private static void PrepareEntityManagementFamilyPduFields(EntityManagementFamilyPdu value)
    {
    }

    private static void WriteEntityManagementFamilyPduFields(ref DisBinaryWriter writer, EntityManagementFamilyPdu value)
    {
    }

    private static void MeasureEntityManagementFamilyPduFields(in EntityManagementFamilyPdu value, ref int offset)
    {
    }

    private static EntityMarking ReadEntityMarking(ref DisBinaryReader reader)
    {
        var value = new EntityMarking();
        ReadEntityMarkingFields(ref reader, value);
        return value;
    }

    private static void ReadEntityMarkingFields(ref DisBinaryReader reader, EntityMarking value)
    {
        value.CharacterSet = (EntityMarkingCharacterSet)reader.ReadByte("characterSet");
        int CharactersCount = CheckedCount(11, reader.Remaining, "characters");
        value.Characters = new byte[CharactersCount];
        for (int index = 0; index < CharactersCount; index++)
            value.Characters[index] = reader.ReadByte("characters");
    }

    private static void PrepareEntityMarking(EntityMarking value)
    {
        PrepareEntityMarkingFields(value);
    }

    private static void PrepareEntityMarkingFields(EntityMarking value)
    {
        ArgumentNullException.ThrowIfNull(value.Characters);
    }

    private static void WriteEntityMarking(ref DisBinaryWriter writer, EntityMarking value)
    {
        WriteEntityMarkingFields(ref writer, value);
    }

    private static void WriteEntityMarkingFields(ref DisBinaryWriter writer, EntityMarking value)
    {
        writer.WriteByte((byte)value.CharacterSet, "characterSet");
        foreach (byte item in value.Characters) writer.WriteByte(item, "characters");
    }

    private static void MeasureEntityMarking(in EntityMarking value, ref int offset)
    {
        MeasureEntityMarkingFields(value, ref offset);
    }

    private static void MeasureEntityMarkingFields(in EntityMarking value, ref int offset)
    {
        offset += 1;
        offset += checked(value.Characters.Length * 1);
    }

    private static void ReadEntityStatePduFields(ref DisBinaryReader reader, EntityStatePdu value)
    {
        value.EntityId = ReadEntityId(ref reader);
        value.ForceId = (ForceId)reader.ReadByte("forceId");
        value.NumberOfVariableParameters = reader.ReadByte("numberOfVariableParameters");
        value.EntityType = ReadEntityType(ref reader);
        value.AlternativeEntityType = ReadEntityType(ref reader);
        value.EntityLinearVelocity = ReadVector3Float(ref reader);
        value.EntityLocation = ReadVector3Double(ref reader);
        value.EntityOrientation = ReadEulerAngles(ref reader);
        value.EntityAppearance = reader.ReadUInt32("entityAppearance");
        value.DeadReckoningParameters = ReadDeadReckoningParameters(ref reader);
        value.Marking = ReadEntityMarking(ref reader);
        value.Capabilities = new EntityCapabilities(reader.ReadUInt32("capabilities"));
        int VariableParametersCount = CheckedCount(checked((int)value.NumberOfVariableParameters), reader.Remaining, "variableParameters");
        value.VariableParameters = new List<VariableParameter>(VariableParametersCount);
        for (int index = 0; index < VariableParametersCount; index++)
            value.VariableParameters.Add(ReadVariableParameter(ref reader));
    }

    private static void PrepareEntityStatePduFields(EntityStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
        ArgumentNullException.ThrowIfNull(value.EntityType);
        PrepareEntityType(value.EntityType);
        ArgumentNullException.ThrowIfNull(value.AlternativeEntityType);
        PrepareEntityType(value.AlternativeEntityType);
        ArgumentNullException.ThrowIfNull(value.EntityLinearVelocity);
        PrepareVector3Float(value.EntityLinearVelocity);
        ArgumentNullException.ThrowIfNull(value.EntityLocation);
        PrepareVector3Double(value.EntityLocation);
        ArgumentNullException.ThrowIfNull(value.EntityOrientation);
        PrepareEulerAngles(value.EntityOrientation);
        ArgumentNullException.ThrowIfNull(value.DeadReckoningParameters);
        PrepareDeadReckoningParameters(value.DeadReckoningParameters);
        ArgumentNullException.ThrowIfNull(value.Marking);
        PrepareEntityMarking(value.Marking);
        ArgumentNullException.ThrowIfNull(value.VariableParameters);
        foreach (VariableParameter item in value.VariableParameters) PrepareVariableParameter(item);
        value.NumberOfVariableParameters = checked((byte)value.VariableParameters.Count);
    }

    private static void WriteEntityStatePduFields(ref DisBinaryWriter writer, EntityStatePdu value)
    {
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteByte((byte)value.ForceId, "forceId");
        writer.WriteByte(value.NumberOfVariableParameters, "numberOfVariableParameters");
        WriteEntityType(ref writer, value.EntityType);
        WriteEntityType(ref writer, value.AlternativeEntityType);
        WriteVector3Float(ref writer, value.EntityLinearVelocity);
        WriteVector3Double(ref writer, value.EntityLocation);
        WriteEulerAngles(ref writer, value.EntityOrientation);
        writer.WriteUInt32(value.EntityAppearance, "entityAppearance");
        WriteDeadReckoningParameters(ref writer, value.DeadReckoningParameters);
        WriteEntityMarking(ref writer, value.Marking);
        writer.WriteUInt32(value.Capabilities.Value, "capabilities");
        foreach (VariableParameter item in value.VariableParameters) WriteVariableParameter(ref writer, item);
    }

    private static void MeasureEntityStatePduFields(in EntityStatePdu value, ref int offset)
    {
        MeasureEntityId(value.EntityId, ref offset);
        offset += 1;
        offset += 1;
        MeasureEntityType(value.EntityType, ref offset);
        MeasureEntityType(value.AlternativeEntityType, ref offset);
        MeasureVector3Float(value.EntityLinearVelocity, ref offset);
        MeasureVector3Double(value.EntityLocation, ref offset);
        MeasureEulerAngles(value.EntityOrientation, ref offset);
        offset += 4;
        MeasureDeadReckoningParameters(value.DeadReckoningParameters, ref offset);
        MeasureEntityMarking(value.Marking, ref offset);
        offset += 4;
        foreach (VariableParameter item in value.VariableParameters) MeasureVariableParameter(item, ref offset);
    }

    private static void ReadEntityStateUpdatePduFields(ref DisBinaryReader reader, EntityStateUpdatePdu value)
    {
        value.EntityId = ReadEntityId(ref reader);
        value.Padding1 = reader.ReadByte("padding1");
        value.NumberOfVariableParameters = reader.ReadByte("numberOfVariableParameters");
        value.EntityLinearVelocity = ReadVector3Float(ref reader);
        value.EntityLocation = ReadVector3Double(ref reader);
        value.EntityOrientation = ReadEulerAngles(ref reader);
        value.EntityAppearance = reader.ReadUInt32("entityAppearance");
        int VariableParametersCount = CheckedCount(checked((int)value.NumberOfVariableParameters), reader.Remaining, "variableParameters");
        value.VariableParameters = new List<VariableParameter>(VariableParametersCount);
        for (int index = 0; index < VariableParametersCount; index++)
            value.VariableParameters.Add(ReadVariableParameter(ref reader));
    }

    private static void PrepareEntityStateUpdatePduFields(EntityStateUpdatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
        ArgumentNullException.ThrowIfNull(value.EntityLinearVelocity);
        PrepareVector3Float(value.EntityLinearVelocity);
        ArgumentNullException.ThrowIfNull(value.EntityLocation);
        PrepareVector3Double(value.EntityLocation);
        ArgumentNullException.ThrowIfNull(value.EntityOrientation);
        PrepareEulerAngles(value.EntityOrientation);
        ArgumentNullException.ThrowIfNull(value.VariableParameters);
        foreach (VariableParameter item in value.VariableParameters) PrepareVariableParameter(item);
        value.NumberOfVariableParameters = checked((byte)value.VariableParameters.Count);
    }

    private static void WriteEntityStateUpdatePduFields(ref DisBinaryWriter writer, EntityStateUpdatePdu value)
    {
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteByte(value.NumberOfVariableParameters, "numberOfVariableParameters");
        WriteVector3Float(ref writer, value.EntityLinearVelocity);
        WriteVector3Double(ref writer, value.EntityLocation);
        WriteEulerAngles(ref writer, value.EntityOrientation);
        writer.WriteUInt32(value.EntityAppearance, "entityAppearance");
        foreach (VariableParameter item in value.VariableParameters) WriteVariableParameter(ref writer, item);
    }

    private static void MeasureEntityStateUpdatePduFields(in EntityStateUpdatePdu value, ref int offset)
    {
        MeasureEntityId(value.EntityId, ref offset);
        offset += 1;
        offset += 1;
        MeasureVector3Float(value.EntityLinearVelocity, ref offset);
        MeasureVector3Double(value.EntityLocation, ref offset);
        MeasureEulerAngles(value.EntityOrientation, ref offset);
        offset += 4;
        foreach (VariableParameter item in value.VariableParameters) MeasureVariableParameter(item, ref offset);
    }

    private static EntityType ReadEntityType(ref DisBinaryReader reader)
    {
        var value = new EntityType();
        ReadEntityTypeFields(ref reader, value);
        return value;
    }

    private static void ReadEntityTypeFields(ref DisBinaryReader reader, EntityType value)
    {
        value.EntityKind = (EntityKind)reader.ReadByte("entityKind");
        value.Domain = ReadDomain(ref reader);
        value.Country = (Country)reader.ReadUInt16("country");
        value.Category = reader.ReadByte("category");
        value.SubCategory = reader.ReadByte("subCategory");
        value.Specific = reader.ReadByte("specific");
        value.Extra = reader.ReadByte("extra");
    }

    private static void PrepareEntityType(EntityType value)
    {
        PrepareEntityTypeFields(value);
    }

    private static void PrepareEntityTypeFields(EntityType value)
    {
        ArgumentNullException.ThrowIfNull(value.Domain);
        PrepareDomain(value.Domain);
    }

    private static void WriteEntityType(ref DisBinaryWriter writer, EntityType value)
    {
        WriteEntityTypeFields(ref writer, value);
    }

    private static void WriteEntityTypeFields(ref DisBinaryWriter writer, EntityType value)
    {
        writer.WriteByte((byte)value.EntityKind, "entityKind");
        WriteDomain(ref writer, value.Domain);
        writer.WriteUInt16((ushort)value.Country, "country");
        writer.WriteByte(value.Category, "category");
        writer.WriteByte(value.SubCategory, "subCategory");
        writer.WriteByte(value.Specific, "specific");
        writer.WriteByte(value.Extra, "extra");
    }

    private static void MeasureEntityType(in EntityType value, ref int offset)
    {
        MeasureEntityTypeFields(value, ref offset);
    }

    private static void MeasureEntityTypeFields(in EntityType value, ref int offset)
    {
        offset += 1;
        MeasureDomain(value.Domain, ref offset);
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static EntityTypeRaw ReadEntityTypeRaw(ref DisBinaryReader reader)
    {
        var value = new EntityTypeRaw();
        ReadEntityTypeRawFields(ref reader, value);
        return value;
    }

    private static void ReadEntityTypeRawFields(ref DisBinaryReader reader, EntityTypeRaw value)
    {
        value.EntityKind = (EntityKind)reader.ReadByte("entityKind");
        value.Domain = reader.ReadByte("domain");
        value.Country = reader.ReadUInt16("country");
        value.Category = reader.ReadByte("category");
        value.SubCategory = reader.ReadByte("subCategory");
        value.Specific = reader.ReadByte("specific");
        value.Extra = reader.ReadByte("extra");
    }

    private static void PrepareEntityTypeRaw(EntityTypeRaw value)
    {
        PrepareEntityTypeRawFields(value);
    }

    private static void PrepareEntityTypeRawFields(EntityTypeRaw value)
    {
    }

    private static void WriteEntityTypeRaw(ref DisBinaryWriter writer, EntityTypeRaw value)
    {
        WriteEntityTypeRawFields(ref writer, value);
    }

    private static void WriteEntityTypeRawFields(ref DisBinaryWriter writer, EntityTypeRaw value)
    {
        writer.WriteByte((byte)value.EntityKind, "entityKind");
        writer.WriteByte(value.Domain, "domain");
        writer.WriteUInt16(value.Country, "country");
        writer.WriteByte(value.Category, "category");
        writer.WriteByte(value.SubCategory, "subCategory");
        writer.WriteByte(value.Specific, "specific");
        writer.WriteByte(value.Extra, "extra");
    }

    private static void MeasureEntityTypeRaw(in EntityTypeRaw value, ref int offset)
    {
        MeasureEntityTypeRawFields(value, ref offset);
    }

    private static void MeasureEntityTypeRawFields(in EntityTypeRaw value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static EntityTypeVP ReadEntityTypeVP(ref DisBinaryReader reader)
    {
        var value = new EntityTypeVP();
        ReadEntityTypeVPFields(ref reader, value);
        return value;
    }

    private static void ReadEntityTypeVPFields(ref DisBinaryReader reader, EntityTypeVP value)
    {
        value.RecordType = (VariableParameterRecordType)reader.ReadByte("recordType");
        value.ChangeIndicator = (EntityVpRecordChangeIndicator)reader.ReadByte("changeIndicator");
        value.EntityType = ReadEntityType(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.Padding1 = reader.ReadUInt32("padding1");
    }

    private static void PrepareEntityTypeVP(EntityTypeVP value)
    {
        PrepareEntityTypeVPFields(value);
    }

    private static void PrepareEntityTypeVPFields(EntityTypeVP value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityType);
        PrepareEntityType(value.EntityType);
    }

    private static void WriteEntityTypeVP(ref DisBinaryWriter writer, EntityTypeVP value)
    {
        WriteEntityTypeVPFields(ref writer, value);
    }

    private static void WriteEntityTypeVPFields(ref DisBinaryWriter writer, EntityTypeVP value)
    {
        writer.WriteByte((byte)value.RecordType, "recordType");
        writer.WriteByte((byte)value.ChangeIndicator, "changeIndicator");
        WriteEntityType(ref writer, value.EntityType);
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteUInt32(value.Padding1, "padding1");
    }

    private static void MeasureEntityTypeVP(in EntityTypeVP value, ref int offset)
    {
        MeasureEntityTypeVPFields(value, ref offset);
    }

    private static void MeasureEntityTypeVPFields(in EntityTypeVP value, ref int offset)
    {
        offset += 1;
        offset += 1;
        MeasureEntityType(value.EntityType, ref offset);
        offset += 2;
        offset += 4;
    }

    private static Environment ReadEnvironment(ref DisBinaryReader reader)
    {
        var value = new Environment();
        ReadEnvironmentFields(ref reader, value);
        return value;
    }

    private static void ReadEnvironmentFields(ref DisBinaryReader reader, Environment value)
    {
        value.EnvironmentType = (EnvironmentalProcessRecordType)reader.ReadUInt32("environmentType");
        value.Length = reader.ReadUInt16("length");
        value.Index = reader.ReadByte("index");
        value.Padding1 = reader.ReadByte("padding1");
        int GeometryCount = CheckedCount(Math.Max(0, ((checked((int)value.Length) + 7) / 8) - 6), reader.Remaining, "geometry");
        value.Geometry = new byte[GeometryCount];
        for (int index = 0; index < GeometryCount; index++)
            value.Geometry[index] = reader.ReadByte("geometry");
        reader.Skip(Padding(reader.Offset, 8), "padding2");
    }

    private static void PrepareEnvironment(Environment value)
    {
        PrepareEnvironmentFields(value);
    }

    private static void PrepareEnvironmentFields(Environment value)
    {
        ArgumentNullException.ThrowIfNull(value.Geometry);
    }

    private static void WriteEnvironment(ref DisBinaryWriter writer, Environment value)
    {
        WriteEnvironmentFields(ref writer, value);
    }

    private static void WriteEnvironmentFields(ref DisBinaryWriter writer, Environment value)
    {
        writer.WriteUInt32((uint)value.EnvironmentType, "environmentType");
        writer.WriteUInt16(value.Length, "length");
        writer.WriteByte(value.Index, "index");
        writer.WriteByte(value.Padding1, "padding1");
        foreach (byte item in value.Geometry) writer.WriteByte(item, "geometry");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding2");
    }

    private static void MeasureEnvironment(in Environment value, ref int offset)
    {
        MeasureEnvironmentFields(value, ref offset);
    }

    private static void MeasureEnvironmentFields(in Environment value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += checked(value.Geometry.Length * 1);
        offset += Padding(offset, 8);
    }

    private static void ReadEnvironmentalProcessPduFields(ref DisBinaryReader reader, EnvironmentalProcessPdu value)
    {
        value.EnvironementalProcessId = ReadObjectIdentifier(ref reader);
        value.EnvironmentType = ReadEntityType(ref reader);
        value.ModelType = (EnvironmentalProcessModelType)reader.ReadByte("modelType");
        value.EnvironmentStatus = new EnvironmentalProcessEnvironmentStatus(reader.ReadByte("environmentStatus"));
        value.NumberOfEnvironmentRecords = reader.ReadUInt16("numberOfEnvironmentRecords");
        value.SequenceNumber = reader.ReadUInt16("sequenceNumber");
        int EnvironmentRecordsCount = CheckedCount(checked((int)value.NumberOfEnvironmentRecords), reader.Remaining, "environmentRecords");
        value.EnvironmentRecords = new List<Environment>(EnvironmentRecordsCount);
        for (int index = 0; index < EnvironmentRecordsCount; index++)
            value.EnvironmentRecords.Add(ReadEnvironment(ref reader));
    }

    private static void PrepareEnvironmentalProcessPduFields(EnvironmentalProcessPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EnvironementalProcessId);
        PrepareObjectIdentifier(value.EnvironementalProcessId);
        ArgumentNullException.ThrowIfNull(value.EnvironmentType);
        PrepareEntityType(value.EnvironmentType);
        ArgumentNullException.ThrowIfNull(value.EnvironmentRecords);
        foreach (Environment item in value.EnvironmentRecords) PrepareEnvironment(item);
        value.NumberOfEnvironmentRecords = checked((ushort)value.EnvironmentRecords.Count);
    }

    private static void WriteEnvironmentalProcessPduFields(ref DisBinaryWriter writer, EnvironmentalProcessPdu value)
    {
        WriteObjectIdentifier(ref writer, value.EnvironementalProcessId);
        WriteEntityType(ref writer, value.EnvironmentType);
        writer.WriteByte((byte)value.ModelType, "modelType");
        writer.WriteByte(value.EnvironmentStatus.Value, "environmentStatus");
        writer.WriteUInt16(value.NumberOfEnvironmentRecords, "numberOfEnvironmentRecords");
        writer.WriteUInt16(value.SequenceNumber, "sequenceNumber");
        foreach (Environment item in value.EnvironmentRecords) WriteEnvironment(ref writer, item);
    }

    private static void MeasureEnvironmentalProcessPduFields(in EnvironmentalProcessPdu value, ref int offset)
    {
        MeasureObjectIdentifier(value.EnvironementalProcessId, ref offset);
        MeasureEntityType(value.EnvironmentType, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 2;
        foreach (Environment item in value.EnvironmentRecords) MeasureEnvironment(item, ref offset);
    }

    private static EulerAngles ReadEulerAngles(ref DisBinaryReader reader)
    {
        var value = new EulerAngles();
        ReadEulerAnglesFields(ref reader, value);
        return value;
    }

    private static void ReadEulerAnglesFields(ref DisBinaryReader reader, EulerAngles value)
    {
        value.Psi = reader.ReadSingle("psi");
        value.Theta = reader.ReadSingle("theta");
        value.Phi = reader.ReadSingle("phi");
    }

    private static void PrepareEulerAngles(EulerAngles value)
    {
        PrepareEulerAnglesFields(value);
    }

    private static void PrepareEulerAnglesFields(EulerAngles value)
    {
    }

    private static void WriteEulerAngles(ref DisBinaryWriter writer, EulerAngles value)
    {
        WriteEulerAnglesFields(ref writer, value);
    }

    private static void WriteEulerAnglesFields(ref DisBinaryWriter writer, EulerAngles value)
    {
        writer.WriteSingle(value.Psi, "psi");
        writer.WriteSingle(value.Theta, "theta");
        writer.WriteSingle(value.Phi, "phi");
    }

    private static void MeasureEulerAngles(in EulerAngles value, ref int offset)
    {
        MeasureEulerAnglesFields(value, ref offset);
    }

    private static void MeasureEulerAnglesFields(in EulerAngles value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static EventIdentifier ReadEventIdentifier(ref DisBinaryReader reader)
    {
        var value = new EventIdentifier();
        ReadEventIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadEventIdentifierFields(ref DisBinaryReader reader, EventIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.EventNumber = reader.ReadUInt16("eventNumber");
    }

    private static void PrepareEventIdentifier(EventIdentifier value)
    {
        PrepareEventIdentifierFields(value);
    }

    private static void PrepareEventIdentifierFields(EventIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteEventIdentifier(ref DisBinaryWriter writer, EventIdentifier value)
    {
        WriteEventIdentifierFields(ref writer, value);
    }

    private static void WriteEventIdentifierFields(ref DisBinaryWriter writer, EventIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.EventNumber, "eventNumber");
    }

    private static void MeasureEventIdentifier(in EventIdentifier value, ref int offset)
    {
        MeasureEventIdentifierFields(value, ref offset);
    }

    private static void MeasureEventIdentifierFields(in EventIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static EventIdentifierLiveEntity ReadEventIdentifierLiveEntity(ref DisBinaryReader reader)
    {
        var value = new EventIdentifierLiveEntity();
        ReadEventIdentifierLiveEntityFields(ref reader, value);
        return value;
    }

    private static void ReadEventIdentifierLiveEntityFields(ref DisBinaryReader reader, EventIdentifierLiveEntity value)
    {
        value.SiteNumber = reader.ReadByte("siteNumber");
        value.ApplicationNumber = reader.ReadByte("applicationNumber");
        value.EventNumber = reader.ReadUInt16("eventNumber");
    }

    private static void PrepareEventIdentifierLiveEntity(EventIdentifierLiveEntity value)
    {
        PrepareEventIdentifierLiveEntityFields(value);
    }

    private static void PrepareEventIdentifierLiveEntityFields(EventIdentifierLiveEntity value)
    {
    }

    private static void WriteEventIdentifierLiveEntity(ref DisBinaryWriter writer, EventIdentifierLiveEntity value)
    {
        WriteEventIdentifierLiveEntityFields(ref writer, value);
    }

    private static void WriteEventIdentifierLiveEntityFields(ref DisBinaryWriter writer, EventIdentifierLiveEntity value)
    {
        writer.WriteByte(value.SiteNumber, "siteNumber");
        writer.WriteByte(value.ApplicationNumber, "applicationNumber");
        writer.WriteUInt16(value.EventNumber, "eventNumber");
    }

    private static void MeasureEventIdentifierLiveEntity(in EventIdentifierLiveEntity value, ref int offset)
    {
        MeasureEventIdentifierLiveEntityFields(value, ref offset);
    }

    private static void MeasureEventIdentifierLiveEntityFields(in EventIdentifierLiveEntity value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
    }

    private static void ReadEventReportPduFields(ref DisBinaryReader reader, EventReportPdu value)
    {
        value.EventType = (EventReportEventType)reader.ReadUInt32("eventType");
        value.Padding1 = reader.ReadUInt32("padding1");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatums");
        value.FixedDatums = new List<FixedDatum>(FixedDatumsCount);
        for (int index = 0; index < FixedDatumsCount; index++)
            value.FixedDatums.Add(ReadFixedDatum(ref reader));
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareEventReportPduFields(EventReportPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatums);
        foreach (FixedDatum item in value.FixedDatums) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatums.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteEventReportPduFields(ref DisBinaryWriter writer, EventReportPdu value)
    {
        writer.WriteUInt32((uint)value.EventType, "eventType");
        writer.WriteUInt32(value.Padding1, "padding1");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatums) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureEventReportPduFields(in EventReportPdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatums) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadEventReportReliablePduFields(ref DisBinaryReader reader, EventReportReliablePdu value)
    {
        value.EventType = (EventReportEventType)reader.ReadUInt32("eventType");
        value.Pad1 = reader.ReadUInt32("pad1");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumRecordsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatumRecords");
        value.FixedDatumRecords = new List<FixedDatum>(FixedDatumRecordsCount);
        for (int index = 0; index < FixedDatumRecordsCount; index++)
            value.FixedDatumRecords.Add(ReadFixedDatum(ref reader));
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareEventReportReliablePduFields(EventReportReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumRecords);
        foreach (FixedDatum item in value.FixedDatumRecords) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatumRecords.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteEventReportReliablePduFields(ref DisBinaryWriter writer, EventReportReliablePdu value)
    {
        writer.WriteUInt32((uint)value.EventType, "eventType");
        writer.WriteUInt32(value.Pad1, "pad1");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatumRecords) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureEventReportReliablePduFields(in EventReportReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumRecords) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static Expendable ReadExpendable(ref DisBinaryReader reader)
    {
        var value = new Expendable();
        ReadExpendableFields(ref reader, value);
        return value;
    }

    private static void ReadExpendableFields(ref DisBinaryReader reader, Expendable value)
    {
        value.ExpendableValue = ReadEntityType(ref reader);
        value.Station = reader.ReadUInt32("station");
        value.Quantity = reader.ReadUInt16("quantity");
        value.ExpendableStatus = (MunitionExpendableStatus)reader.ReadByte("expendableStatus");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareExpendable(Expendable value)
    {
        PrepareExpendableFields(value);
    }

    private static void PrepareExpendableFields(Expendable value)
    {
        ArgumentNullException.ThrowIfNull(value.ExpendableValue);
        PrepareEntityType(value.ExpendableValue);
    }

    private static void WriteExpendable(ref DisBinaryWriter writer, Expendable value)
    {
        WriteExpendableFields(ref writer, value);
    }

    private static void WriteExpendableFields(ref DisBinaryWriter writer, Expendable value)
    {
        WriteEntityType(ref writer, value.ExpendableValue);
        writer.WriteUInt32(value.Station, "station");
        writer.WriteUInt16(value.Quantity, "quantity");
        writer.WriteByte((byte)value.ExpendableStatus, "expendableStatus");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureExpendable(in Expendable value, ref int offset)
    {
        MeasureExpendableFields(value, ref offset);
    }

    private static void MeasureExpendableFields(in Expendable value, ref int offset)
    {
        MeasureEntityType(value.ExpendableValue, ref offset);
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
    }

    private static ExpendableDescriptor ReadExpendableDescriptor(ref DisBinaryReader reader)
    {
        var value = new ExpendableDescriptor();
        ReadExpendableDescriptorFields(ref reader, value);
        return value;
    }

    private static void ReadExpendableDescriptorFields(ref DisBinaryReader reader, ExpendableDescriptor value)
    {
        value.ExpendableType = ReadEntityType(ref reader);
        value.Padding = reader.ReadInt64("padding");
    }

    private static void PrepareExpendableDescriptor(ExpendableDescriptor value)
    {
        PrepareExpendableDescriptorFields(value);
    }

    private static void PrepareExpendableDescriptorFields(ExpendableDescriptor value)
    {
        ArgumentNullException.ThrowIfNull(value.ExpendableType);
        PrepareEntityType(value.ExpendableType);
    }

    private static void WriteExpendableDescriptor(ref DisBinaryWriter writer, ExpendableDescriptor value)
    {
        WriteExpendableDescriptorFields(ref writer, value);
    }

    private static void WriteExpendableDescriptorFields(ref DisBinaryWriter writer, ExpendableDescriptor value)
    {
        WriteEntityType(ref writer, value.ExpendableType);
        writer.WriteInt64(value.Padding, "padding");
    }

    private static void MeasureExpendableDescriptor(in ExpendableDescriptor value, ref int offset)
    {
        MeasureExpendableDescriptorFields(value, ref offset);
    }

    private static void MeasureExpendableDescriptorFields(in ExpendableDescriptor value, ref int offset)
    {
        MeasureEntityType(value.ExpendableType, ref offset);
        offset += 8;
    }

    private static ExpendableReload ReadExpendableReload(ref DisBinaryReader reader)
    {
        var value = new ExpendableReload();
        ReadExpendableReloadFields(ref reader, value);
        return value;
    }

    private static void ReadExpendableReloadFields(ref DisBinaryReader reader, ExpendableReload value)
    {
        value.Expendable = ReadEntityType(ref reader);
        value.Station = reader.ReadUInt32("station");
        value.StandardQuantity = reader.ReadUInt16("standardQuantity");
        value.MaximumQuantity = reader.ReadUInt16("maximumQuantity");
        value.StandardQuantityReloadTime = reader.ReadUInt32("standardQuantityReloadTime");
        value.MaximumQuantityReloadTime = reader.ReadUInt32("maximumQuantityReloadTime");
    }

    private static void PrepareExpendableReload(ExpendableReload value)
    {
        PrepareExpendableReloadFields(value);
    }

    private static void PrepareExpendableReloadFields(ExpendableReload value)
    {
        ArgumentNullException.ThrowIfNull(value.Expendable);
        PrepareEntityType(value.Expendable);
    }

    private static void WriteExpendableReload(ref DisBinaryWriter writer, ExpendableReload value)
    {
        WriteExpendableReloadFields(ref writer, value);
    }

    private static void WriteExpendableReloadFields(ref DisBinaryWriter writer, ExpendableReload value)
    {
        WriteEntityType(ref writer, value.Expendable);
        writer.WriteUInt32(value.Station, "station");
        writer.WriteUInt16(value.StandardQuantity, "standardQuantity");
        writer.WriteUInt16(value.MaximumQuantity, "maximumQuantity");
        writer.WriteUInt32(value.StandardQuantityReloadTime, "standardQuantityReloadTime");
        writer.WriteUInt32(value.MaximumQuantityReloadTime, "maximumQuantityReloadTime");
    }

    private static void MeasureExpendableReload(in ExpendableReload value, ref int offset)
    {
        MeasureExpendableReloadFields(value, ref offset);
    }

    private static void MeasureExpendableReloadFields(in ExpendableReload value, ref int offset)
    {
        MeasureEntityType(value.Expendable, ref offset);
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 4;
    }

    private static ExplosionDescriptor ReadExplosionDescriptor(ref DisBinaryReader reader)
    {
        var value = new ExplosionDescriptor();
        ReadExplosionDescriptorFields(ref reader, value);
        return value;
    }

    private static void ReadExplosionDescriptorFields(ref DisBinaryReader reader, ExplosionDescriptor value)
    {
        value.ExplodingObject = ReadEntityType(ref reader);
        value.ExplosiveMaterial = (ExplosiveMaterialCategories)reader.ReadUInt16("explosiveMaterial");
        value.Padding = reader.ReadUInt16("padding");
        value.ExplosiveForce = reader.ReadSingle("explosiveForce");
    }

    private static void PrepareExplosionDescriptor(ExplosionDescriptor value)
    {
        PrepareExplosionDescriptorFields(value);
    }

    private static void PrepareExplosionDescriptorFields(ExplosionDescriptor value)
    {
        ArgumentNullException.ThrowIfNull(value.ExplodingObject);
        PrepareEntityType(value.ExplodingObject);
    }

    private static void WriteExplosionDescriptor(ref DisBinaryWriter writer, ExplosionDescriptor value)
    {
        WriteExplosionDescriptorFields(ref writer, value);
    }

    private static void WriteExplosionDescriptorFields(ref DisBinaryWriter writer, ExplosionDescriptor value)
    {
        WriteEntityType(ref writer, value.ExplodingObject);
        writer.WriteUInt16((ushort)value.ExplosiveMaterial, "explosiveMaterial");
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteSingle(value.ExplosiveForce, "explosiveForce");
    }

    private static void MeasureExplosionDescriptor(in ExplosionDescriptor value, ref int offset)
    {
        MeasureExplosionDescriptorFields(value, ref offset);
    }

    private static void MeasureExplosionDescriptorFields(in ExplosionDescriptor value, ref int offset)
    {
        MeasureEntityType(value.ExplodingObject, ref offset);
        offset += 2;
        offset += 2;
        offset += 4;
    }

    private static FalseTargetsAttribute ReadFalseTargetsAttribute(ref DisBinaryReader reader)
    {
        var value = new FalseTargetsAttribute();
        ReadFalseTargetsAttributeFields(ref reader, value);
        return value;
    }

    private static void ReadFalseTargetsAttributeFields(ref DisBinaryReader reader, FalseTargetsAttribute value)
    {
        value.RecordType = reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.Padding = reader.ReadUInt16("padding");
        value.EmitterNumber = reader.ReadByte("emitterNumber");
        value.BeamNumber = reader.ReadByte("beamNumber");
        value.StateIndicator = (EeAttributeStateIndicator)reader.ReadByte("stateIndicator");
        value.Padding2 = reader.ReadByte("padding2");
        value.Padding3 = reader.ReadUInt16("padding3");
        value.FalseTargetCount = reader.ReadUInt16("falseTargetCount");
        value.WalkSpeed = reader.ReadSingle("walkSpeed");
        value.WalkAcceleration = reader.ReadSingle("walkAcceleration");
        value.MaximumWalkDistance = reader.ReadSingle("maximumWalkDistance");
        value.KeepTime = reader.ReadSingle("keepTime");
        value.EchoSpacing = reader.ReadSingle("echoSpacing");
        value.FirstTargetOffset = reader.ReadSingle("firstTargetOffset");
    }

    private static void PrepareFalseTargetsAttribute(FalseTargetsAttribute value)
    {
        PrepareFalseTargetsAttributeFields(value);
    }

    private static void PrepareFalseTargetsAttributeFields(FalseTargetsAttribute value)
    {
    }

    private static void WriteFalseTargetsAttribute(ref DisBinaryWriter writer, FalseTargetsAttribute value)
    {
        WriteFalseTargetsAttributeFields(ref writer, value);
    }

    private static void WriteFalseTargetsAttributeFields(ref DisBinaryWriter writer, FalseTargetsAttribute value)
    {
        writer.WriteUInt32(value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteByte(value.EmitterNumber, "emitterNumber");
        writer.WriteByte(value.BeamNumber, "beamNumber");
        writer.WriteByte((byte)value.StateIndicator, "stateIndicator");
        writer.WriteByte(value.Padding2, "padding2");
        writer.WriteUInt16(value.Padding3, "padding3");
        writer.WriteUInt16(value.FalseTargetCount, "falseTargetCount");
        writer.WriteSingle(value.WalkSpeed, "walkSpeed");
        writer.WriteSingle(value.WalkAcceleration, "walkAcceleration");
        writer.WriteSingle(value.MaximumWalkDistance, "maximumWalkDistance");
        writer.WriteSingle(value.KeepTime, "keepTime");
        writer.WriteSingle(value.EchoSpacing, "echoSpacing");
        writer.WriteSingle(value.FirstTargetOffset, "firstTargetOffset");
    }

    private static void MeasureFalseTargetsAttribute(in FalseTargetsAttribute value, ref int offset)
    {
        MeasureFalseTargetsAttributeFields(value, ref offset);
    }

    private static void MeasureFalseTargetsAttributeFields(in FalseTargetsAttribute value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static void ReadFirePduFields(ref DisBinaryReader reader, FirePdu value)
    {
        value.FiringEntityId = ReadEntityId(ref reader);
        value.TargetEntityId = ReadEntityId(ref reader);
        value.MunitionExpendibleId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.FireMissionIndex = reader.ReadUInt32("fireMissionIndex");
        value.LocationInWorldCoordinates = ReadVector3Double(ref reader);
        value.Descriptor = ReadMunitionDescriptor(ref reader);
        value.Velocity = ReadVector3Float(ref reader);
        value.Range = reader.ReadSingle("range");
    }

    private static void PrepareFirePduFields(FirePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FiringEntityId);
        PrepareEntityId(value.FiringEntityId);
        ArgumentNullException.ThrowIfNull(value.TargetEntityId);
        PrepareEntityId(value.TargetEntityId);
        ArgumentNullException.ThrowIfNull(value.MunitionExpendibleId);
        PrepareEntityId(value.MunitionExpendibleId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.LocationInWorldCoordinates);
        PrepareVector3Double(value.LocationInWorldCoordinates);
        ArgumentNullException.ThrowIfNull(value.Descriptor);
        PrepareMunitionDescriptor(value.Descriptor);
        ArgumentNullException.ThrowIfNull(value.Velocity);
        PrepareVector3Float(value.Velocity);
    }

    private static void WriteFirePduFields(ref DisBinaryWriter writer, FirePdu value)
    {
        WriteEntityId(ref writer, value.FiringEntityId);
        WriteEntityId(ref writer, value.TargetEntityId);
        WriteEntityId(ref writer, value.MunitionExpendibleId);
        WriteEventIdentifier(ref writer, value.EventId);
        writer.WriteUInt32(value.FireMissionIndex, "fireMissionIndex");
        WriteVector3Double(ref writer, value.LocationInWorldCoordinates);
        WriteMunitionDescriptor(ref writer, value.Descriptor);
        WriteVector3Float(ref writer, value.Velocity);
        writer.WriteSingle(value.Range, "range");
    }

    private static void MeasureFirePduFields(in FirePdu value, ref int offset)
    {
        MeasureEntityId(value.FiringEntityId, ref offset);
        MeasureEntityId(value.TargetEntityId, ref offset);
        MeasureEntityId(value.MunitionExpendibleId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        offset += 4;
        MeasureVector3Double(value.LocationInWorldCoordinates, ref offset);
        MeasureMunitionDescriptor(value.Descriptor, ref offset);
        MeasureVector3Float(value.Velocity, ref offset);
        offset += 4;
    }

    private static FixedDatum ReadFixedDatum(ref DisBinaryReader reader)
    {
        var value = new FixedDatum();
        ReadFixedDatumFields(ref reader, value);
        return value;
    }

    private static void ReadFixedDatumFields(ref DisBinaryReader reader, FixedDatum value)
    {
        value.FixedDatumId = (VariableRecordType)reader.ReadUInt32("fixedDatumID");
        value.FixedDatumValue = reader.ReadUInt32("fixedDatumValue");
    }

    private static void PrepareFixedDatum(FixedDatum value)
    {
        PrepareFixedDatumFields(value);
    }

    private static void PrepareFixedDatumFields(FixedDatum value)
    {
    }

    private static void WriteFixedDatum(ref DisBinaryWriter writer, FixedDatum value)
    {
        WriteFixedDatumFields(ref writer, value);
    }

    private static void WriteFixedDatumFields(ref DisBinaryWriter writer, FixedDatum value)
    {
        writer.WriteUInt32((uint)value.FixedDatumId, "fixedDatumID");
        writer.WriteUInt32(value.FixedDatumValue, "fixedDatumValue");
    }

    private static void MeasureFixedDatum(in FixedDatum value, ref int offset)
    {
        MeasureFixedDatumFields(value, ref offset);
    }

    private static void MeasureFixedDatumFields(in FixedDatum value, ref int offset)
    {
        offset += 4;
        offset += 4;
    }

    private static FundamentalOperationalData ReadFundamentalOperationalData(ref DisBinaryReader reader)
    {
        var value = new FundamentalOperationalData();
        ReadFundamentalOperationalDataFields(ref reader, value);
        return value;
    }

    private static void ReadFundamentalOperationalDataFields(ref DisBinaryReader reader, FundamentalOperationalData value)
    {
        value.SystemStatus = reader.ReadByte("systemStatus");
        value.DataField1 = reader.ReadByte("dataField1");
        value.InformationLayers = reader.ReadByte("informationLayers");
        value.DataField2 = reader.ReadByte("dataField2");
        value.Parameter1 = reader.ReadUInt16("parameter1");
        value.Parameter2 = reader.ReadUInt16("parameter2");
        value.Parameter3 = reader.ReadUInt16("parameter3");
        value.Parameter4 = reader.ReadUInt16("parameter4");
        value.Parameter5 = reader.ReadUInt16("parameter5");
        value.Parameter6 = reader.ReadUInt16("parameter6");
    }

    private static void PrepareFundamentalOperationalData(FundamentalOperationalData value)
    {
        PrepareFundamentalOperationalDataFields(value);
    }

    private static void PrepareFundamentalOperationalDataFields(FundamentalOperationalData value)
    {
    }

    private static void WriteFundamentalOperationalData(ref DisBinaryWriter writer, FundamentalOperationalData value)
    {
        WriteFundamentalOperationalDataFields(ref writer, value);
    }

    private static void WriteFundamentalOperationalDataFields(ref DisBinaryWriter writer, FundamentalOperationalData value)
    {
        writer.WriteByte(value.SystemStatus, "systemStatus");
        writer.WriteByte(value.DataField1, "dataField1");
        writer.WriteByte(value.InformationLayers, "informationLayers");
        writer.WriteByte(value.DataField2, "dataField2");
        writer.WriteUInt16(value.Parameter1, "parameter1");
        writer.WriteUInt16(value.Parameter2, "parameter2");
        writer.WriteUInt16(value.Parameter3, "parameter3");
        writer.WriteUInt16(value.Parameter4, "parameter4");
        writer.WriteUInt16(value.Parameter5, "parameter5");
        writer.WriteUInt16(value.Parameter6, "parameter6");
    }

    private static void MeasureFundamentalOperationalData(in FundamentalOperationalData value, ref int offset)
    {
        MeasureFundamentalOperationalDataFields(value, ref offset);
    }

    private static void MeasureFundamentalOperationalDataFields(in FundamentalOperationalData value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static GridAxisDescriptor ReadGridAxisDescriptor(ref DisBinaryReader reader)
    {
        var value = new GridAxisDescriptor();
        ReadGridAxisDescriptorFields(ref reader, value);
        return value;
    }

    private static void ReadGridAxisDescriptorFields(ref DisBinaryReader reader, GridAxisDescriptor value)
    {
        value.DomainInitialXi = reader.ReadDouble("domainInitialXi");
        value.DomainFinalXi = reader.ReadDouble("domainFinalXi");
        value.DomainPointsXi = reader.ReadUInt16("domainPointsXi");
        value.InterleafFactor = reader.ReadByte("interleafFactor");
        value.AxisType = (GridAxisDescriptorAxisType)reader.ReadByte("axisType");
    }

    private static void PrepareGridAxisDescriptor(GridAxisDescriptor value)
    {
        PrepareGridAxisDescriptorFields(value);
    }

    private static void PrepareGridAxisDescriptorFields(GridAxisDescriptor value)
    {
    }

    private static void WriteGridAxisDescriptor(ref DisBinaryWriter writer, GridAxisDescriptor value)
    {
        WriteGridAxisDescriptorFields(ref writer, value);
    }

    private static void WriteGridAxisDescriptorFields(ref DisBinaryWriter writer, GridAxisDescriptor value)
    {
        writer.WriteDouble(value.DomainInitialXi, "domainInitialXi");
        writer.WriteDouble(value.DomainFinalXi, "domainFinalXi");
        writer.WriteUInt16(value.DomainPointsXi, "domainPointsXi");
        writer.WriteByte(value.InterleafFactor, "interleafFactor");
        writer.WriteByte((byte)value.AxisType, "axisType");
    }

    private static void MeasureGridAxisDescriptor(in GridAxisDescriptor value, ref int offset)
    {
        MeasureGridAxisDescriptorFields(value, ref offset);
    }

    private static void MeasureGridAxisDescriptorFields(in GridAxisDescriptor value, ref int offset)
    {
        offset += 8;
        offset += 8;
        offset += 2;
        offset += 1;
        offset += 1;
    }

    private static GridAxisDescriptorFixed ReadGridAxisDescriptorFixed(ref DisBinaryReader reader)
    {
        var value = new GridAxisDescriptorFixed();
        ReadGridAxisDescriptorFields(ref reader, value);
        ReadGridAxisDescriptorFixedFields(ref reader, value);
        return value;
    }

    private static void ReadGridAxisDescriptorFixedFields(ref DisBinaryReader reader, GridAxisDescriptorFixed value)
    {
        value.NumberOfPointsOnXiAxis = reader.ReadUInt16("numberOfPointsOnXiAxis");
        value.InitialIndex = reader.ReadUInt16("initialIndex");
    }

    private static void PrepareGridAxisDescriptorFixed(GridAxisDescriptorFixed value)
    {
        PrepareGridAxisDescriptorFields(value);
        PrepareGridAxisDescriptorFixedFields(value);
    }

    private static void PrepareGridAxisDescriptorFixedFields(GridAxisDescriptorFixed value)
    {
    }

    private static void WriteGridAxisDescriptorFixed(ref DisBinaryWriter writer, GridAxisDescriptorFixed value)
    {
        WriteGridAxisDescriptorFields(ref writer, value);
        WriteGridAxisDescriptorFixedFields(ref writer, value);
    }

    private static void WriteGridAxisDescriptorFixedFields(ref DisBinaryWriter writer, GridAxisDescriptorFixed value)
    {
        writer.WriteUInt16(value.NumberOfPointsOnXiAxis, "numberOfPointsOnXiAxis");
        writer.WriteUInt16(value.InitialIndex, "initialIndex");
    }

    private static void MeasureGridAxisDescriptorFixed(in GridAxisDescriptorFixed value, ref int offset)
    {
        MeasureGridAxisDescriptorFields(value, ref offset);
        MeasureGridAxisDescriptorFixedFields(value, ref offset);
    }

    private static void MeasureGridAxisDescriptorFixedFields(in GridAxisDescriptorFixed value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static GridAxisDescriptorVariable ReadGridAxisDescriptorVariable(ref DisBinaryReader reader)
    {
        var value = new GridAxisDescriptorVariable();
        ReadGridAxisDescriptorFields(ref reader, value);
        ReadGridAxisDescriptorVariableFields(ref reader, value);
        return value;
    }

    private static void ReadGridAxisDescriptorVariableFields(ref DisBinaryReader reader, GridAxisDescriptorVariable value)
    {
        value.NumberOfPointsOnXiAxis = reader.ReadUInt16("numberOfPointsOnXiAxis");
        value.InitialIndex = reader.ReadUInt16("initialIndex");
        value.CoordinateScaleXi = reader.ReadDouble("coordinateScaleXi");
        value.CoordinateOffsetXi = reader.ReadDouble("coordinateOffsetXi");
        int XiValuesCount = CheckedCount(checked((int)value.NumberOfPointsOnXiAxis), reader.Remaining, "xiValues");
        value.XiValues = new ushort[XiValuesCount];
        for (int index = 0; index < XiValuesCount; index++)
            value.XiValues[index] = reader.ReadUInt16("xiValues");
        reader.Skip(Padding(reader.Offset, 8), "padding");
    }

    private static void PrepareGridAxisDescriptorVariable(GridAxisDescriptorVariable value)
    {
        PrepareGridAxisDescriptorFields(value);
        PrepareGridAxisDescriptorVariableFields(value);
    }

    private static void PrepareGridAxisDescriptorVariableFields(GridAxisDescriptorVariable value)
    {
        ArgumentNullException.ThrowIfNull(value.XiValues);
    }

    private static void WriteGridAxisDescriptorVariable(ref DisBinaryWriter writer, GridAxisDescriptorVariable value)
    {
        WriteGridAxisDescriptorFields(ref writer, value);
        WriteGridAxisDescriptorVariableFields(ref writer, value);
    }

    private static void WriteGridAxisDescriptorVariableFields(ref DisBinaryWriter writer, GridAxisDescriptorVariable value)
    {
        writer.WriteUInt16(value.NumberOfPointsOnXiAxis, "numberOfPointsOnXiAxis");
        writer.WriteUInt16(value.InitialIndex, "initialIndex");
        writer.WriteDouble(value.CoordinateScaleXi, "coordinateScaleXi");
        writer.WriteDouble(value.CoordinateOffsetXi, "coordinateOffsetXi");
        foreach (ushort item in value.XiValues) writer.WriteUInt16(item, "xiValues");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding");
    }

    private static void MeasureGridAxisDescriptorVariable(in GridAxisDescriptorVariable value, ref int offset)
    {
        MeasureGridAxisDescriptorFields(value, ref offset);
        MeasureGridAxisDescriptorVariableFields(value, ref offset);
    }

    private static void MeasureGridAxisDescriptorVariableFields(in GridAxisDescriptorVariable value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 8;
        offset += 8;
        offset += checked(value.XiValues.Length * 2);
        offset += Padding(offset, 8);
    }

    private static GridData ReadGridData(ref DisBinaryReader reader)
    {
        var value = new GridData();
        ReadGridDataFields(ref reader, value);
        return value;
    }

    private static void ReadGridDataFields(ref DisBinaryReader reader, GridData value)
    {
        value.SampleType = (GriddedDataSampleType)reader.ReadUInt16("sampleType");
        value.DataRepresentation = (GriddedDataDataRepresentation)reader.ReadUInt16("dataRepresentation");
    }

    private static void PrepareGridData(GridData value)
    {
        PrepareGridDataFields(value);
    }

    private static void PrepareGridDataFields(GridData value)
    {
    }

    private static void WriteGridData(ref DisBinaryWriter writer, GridData value)
    {
        WriteGridDataFields(ref writer, value);
    }

    private static void WriteGridDataFields(ref DisBinaryWriter writer, GridData value)
    {
        writer.WriteUInt16((ushort)value.SampleType, "sampleType");
        writer.WriteUInt16((ushort)value.DataRepresentation, "dataRepresentation");
    }

    private static void MeasureGridData(in GridData value, ref int offset)
    {
        MeasureGridDataFields(value, ref offset);
    }

    private static void MeasureGridDataFields(in GridData value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static GridDataType0 ReadGridDataType0(ref DisBinaryReader reader)
    {
        var value = new GridDataType0();
        ReadGridDataFields(ref reader, value);
        ReadGridDataType0Fields(ref reader, value);
        return value;
    }

    private static void ReadGridDataType0Fields(ref DisBinaryReader reader, GridDataType0 value)
    {
        value.NumberOfBytes = reader.ReadUInt16("numberOfBytes");
        int DataValuesCount = CheckedCount(checked((int)value.NumberOfBytes), reader.Remaining, "dataValues");
        value.DataValues = new byte[DataValuesCount];
        for (int index = 0; index < DataValuesCount; index++)
            value.DataValues[index] = reader.ReadByte("dataValues");
        reader.Skip(Padding(reader.Offset, 2), "padding");
    }

    private static void PrepareGridDataType0(GridDataType0 value)
    {
        PrepareGridDataFields(value);
        PrepareGridDataType0Fields(value);
    }

    private static void PrepareGridDataType0Fields(GridDataType0 value)
    {
        ArgumentNullException.ThrowIfNull(value.DataValues);
        value.NumberOfBytes = checked((ushort)value.DataValues.Length);
    }

    private static void WriteGridDataType0(ref DisBinaryWriter writer, GridDataType0 value)
    {
        WriteGridDataFields(ref writer, value);
        WriteGridDataType0Fields(ref writer, value);
    }

    private static void WriteGridDataType0Fields(ref DisBinaryWriter writer, GridDataType0 value)
    {
        writer.WriteUInt16(value.NumberOfBytes, "numberOfBytes");
        foreach (byte item in value.DataValues) writer.WriteByte(item, "dataValues");
        writer.WriteZeros(Padding(writer.Offset, 2), "padding");
    }

    private static void MeasureGridDataType0(in GridDataType0 value, ref int offset)
    {
        MeasureGridDataFields(value, ref offset);
        MeasureGridDataType0Fields(value, ref offset);
    }

    private static void MeasureGridDataType0Fields(in GridDataType0 value, ref int offset)
    {
        offset += 2;
        offset += checked(value.DataValues.Length * 1);
        offset += Padding(offset, 2);
    }

    private static GridDataType1 ReadGridDataType1(ref DisBinaryReader reader)
    {
        var value = new GridDataType1();
        ReadGridDataFields(ref reader, value);
        ReadGridDataType1Fields(ref reader, value);
        return value;
    }

    private static void ReadGridDataType1Fields(ref DisBinaryReader reader, GridDataType1 value)
    {
        value.FieldScale = reader.ReadSingle("fieldScale");
        value.FieldOffset = reader.ReadSingle("fieldOffset");
        value.NumberOfValues = reader.ReadUInt16("numberOfValues");
        int DataValuesCount = CheckedCount(checked((int)value.NumberOfValues), reader.Remaining, "dataValues");
        value.DataValues = new ushort[DataValuesCount];
        for (int index = 0; index < DataValuesCount; index++)
            value.DataValues[index] = reader.ReadUInt16("dataValues");
        reader.Skip(Padding(reader.Offset, 4), "padding");
    }

    private static void PrepareGridDataType1(GridDataType1 value)
    {
        PrepareGridDataFields(value);
        PrepareGridDataType1Fields(value);
    }

    private static void PrepareGridDataType1Fields(GridDataType1 value)
    {
        ArgumentNullException.ThrowIfNull(value.DataValues);
        value.NumberOfValues = checked((ushort)value.DataValues.Length);
    }

    private static void WriteGridDataType1(ref DisBinaryWriter writer, GridDataType1 value)
    {
        WriteGridDataFields(ref writer, value);
        WriteGridDataType1Fields(ref writer, value);
    }

    private static void WriteGridDataType1Fields(ref DisBinaryWriter writer, GridDataType1 value)
    {
        writer.WriteSingle(value.FieldScale, "fieldScale");
        writer.WriteSingle(value.FieldOffset, "fieldOffset");
        writer.WriteUInt16(value.NumberOfValues, "numberOfValues");
        foreach (ushort item in value.DataValues) writer.WriteUInt16(item, "dataValues");
        writer.WriteZeros(Padding(writer.Offset, 4), "padding");
    }

    private static void MeasureGridDataType1(in GridDataType1 value, ref int offset)
    {
        MeasureGridDataFields(value, ref offset);
        MeasureGridDataType1Fields(value, ref offset);
    }

    private static void MeasureGridDataType1Fields(in GridDataType1 value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 2;
        offset += checked(value.DataValues.Length * 2);
        offset += Padding(offset, 4);
    }

    private static GridDataType2 ReadGridDataType2(ref DisBinaryReader reader)
    {
        var value = new GridDataType2();
        ReadGridDataFields(ref reader, value);
        ReadGridDataType2Fields(ref reader, value);
        return value;
    }

    private static void ReadGridDataType2Fields(ref DisBinaryReader reader, GridDataType2 value)
    {
        value.NumberOfValues = reader.ReadUInt16("numberOfValues");
        value.Padding = reader.ReadUInt16("padding");
        int DataValuesCount = CheckedCount(checked((int)value.NumberOfValues), reader.Remaining, "dataValues");
        value.DataValues = new float[DataValuesCount];
        for (int index = 0; index < DataValuesCount; index++)
            value.DataValues[index] = reader.ReadSingle("dataValues");
    }

    private static void PrepareGridDataType2(GridDataType2 value)
    {
        PrepareGridDataFields(value);
        PrepareGridDataType2Fields(value);
    }

    private static void PrepareGridDataType2Fields(GridDataType2 value)
    {
        ArgumentNullException.ThrowIfNull(value.DataValues);
        value.NumberOfValues = checked((ushort)value.DataValues.Length);
    }

    private static void WriteGridDataType2(ref DisBinaryWriter writer, GridDataType2 value)
    {
        WriteGridDataFields(ref writer, value);
        WriteGridDataType2Fields(ref writer, value);
    }

    private static void WriteGridDataType2Fields(ref DisBinaryWriter writer, GridDataType2 value)
    {
        writer.WriteUInt16(value.NumberOfValues, "numberOfValues");
        writer.WriteUInt16(value.Padding, "padding");
        foreach (float item in value.DataValues) writer.WriteSingle(item, "dataValues");
    }

    private static void MeasureGridDataType2(in GridDataType2 value, ref int offset)
    {
        MeasureGridDataFields(value, ref offset);
        MeasureGridDataType2Fields(value, ref offset);
    }

    private static void MeasureGridDataType2Fields(in GridDataType2 value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += checked(value.DataValues.Length * 4);
    }

    private static void ReadGriddedDataPduFields(ref DisBinaryReader reader, GriddedDataPdu value)
    {
        value.EnvironmentalSimulationApplicationId = ReadSimulationIdentifier(ref reader);
        value.FieldNumber = reader.ReadUInt16("fieldNumber");
        value.PduNumber = reader.ReadUInt16("pduNumber");
        value.PduTotal = reader.ReadUInt16("pduTotal");
        value.CoordinateSystem = (GriddedDataCoordinateSystem)reader.ReadUInt16("coordinateSystem");
        value.NumberOfGridAxes = reader.ReadByte("numberOfGridAxes");
        value.ConstantGrid = (GriddedDataConstantGrid)reader.ReadByte("constantGrid");
        value.EnvironmentType = ReadEntityType(ref reader);
        value.Orientation = ReadEulerAngles(ref reader);
        value.SampleTime = ReadClockTime(ref reader);
        value.TotalValues = reader.ReadUInt32("totalValues");
        value.VectorDimension = reader.ReadByte("vectorDimension");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        int GridAxisDescriptorsCount = CheckedCount(checked((int)value.NumberOfGridAxes), reader.Remaining, "gridAxisDescriptors");
        value.GridAxisDescriptors = new List<GridAxisDescriptor>(GridAxisDescriptorsCount);
        for (int index = 0; index < GridAxisDescriptorsCount; index++)
            value.GridAxisDescriptors.Add(ReadGridAxisDescriptor(ref reader));
        int GridDataRecordsCount = CheckedCount(checked((int)value.NumberOfGridAxes), reader.Remaining, "gridDataRecords");
        value.GridDataRecords = new List<GridData>(GridDataRecordsCount);
        for (int index = 0; index < GridDataRecordsCount; index++)
            value.GridDataRecords.Add(ReadGridData(ref reader));
    }

    private static void PrepareGriddedDataPduFields(GriddedDataPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EnvironmentalSimulationApplicationId);
        PrepareSimulationIdentifier(value.EnvironmentalSimulationApplicationId);
        ArgumentNullException.ThrowIfNull(value.EnvironmentType);
        PrepareEntityType(value.EnvironmentType);
        ArgumentNullException.ThrowIfNull(value.Orientation);
        PrepareEulerAngles(value.Orientation);
        ArgumentNullException.ThrowIfNull(value.SampleTime);
        PrepareClockTime(value.SampleTime);
        ArgumentNullException.ThrowIfNull(value.GridAxisDescriptors);
        foreach (GridAxisDescriptor item in value.GridAxisDescriptors) PrepareGridAxisDescriptor(item);
        value.NumberOfGridAxes = checked((byte)value.GridAxisDescriptors.Count);
        ArgumentNullException.ThrowIfNull(value.GridDataRecords);
        foreach (GridData item in value.GridDataRecords) PrepareGridData(item);
        if (Convert.ToInt64(value.NumberOfGridAxes) != value.GridDataRecords.Count) throw new InvalidOperationException("Field 'numberOfGridAxes' must match the encoded length of 'gridDataRecords'.");
    }

    private static void WriteGriddedDataPduFields(ref DisBinaryWriter writer, GriddedDataPdu value)
    {
        WriteSimulationIdentifier(ref writer, value.EnvironmentalSimulationApplicationId);
        writer.WriteUInt16(value.FieldNumber, "fieldNumber");
        writer.WriteUInt16(value.PduNumber, "pduNumber");
        writer.WriteUInt16(value.PduTotal, "pduTotal");
        writer.WriteUInt16((ushort)value.CoordinateSystem, "coordinateSystem");
        writer.WriteByte(value.NumberOfGridAxes, "numberOfGridAxes");
        writer.WriteByte((byte)value.ConstantGrid, "constantGrid");
        WriteEntityType(ref writer, value.EnvironmentType);
        WriteEulerAngles(ref writer, value.Orientation);
        WriteClockTime(ref writer, value.SampleTime);
        writer.WriteUInt32(value.TotalValues, "totalValues");
        writer.WriteByte(value.VectorDimension, "vectorDimension");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        foreach (GridAxisDescriptor item in value.GridAxisDescriptors) WriteGridAxisDescriptor(ref writer, item);
        foreach (GridData item in value.GridDataRecords) WriteGridData(ref writer, item);
    }

    private static void MeasureGriddedDataPduFields(in GriddedDataPdu value, ref int offset)
    {
        MeasureSimulationIdentifier(value.EnvironmentalSimulationApplicationId, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        MeasureEntityType(value.EnvironmentType, ref offset);
        MeasureEulerAngles(value.Orientation, ref offset);
        MeasureClockTime(value.SampleTime, ref offset);
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (GridAxisDescriptor item in value.GridAxisDescriptors) MeasureGridAxisDescriptor(item, ref offset);
        foreach (GridData item in value.GridDataRecords) MeasureGridData(item, ref offset);
    }

    private static GroupID ReadGroupID(ref DisBinaryReader reader)
    {
        var value = new GroupID();
        ReadGroupIDFields(ref reader, value);
        return value;
    }

    private static void ReadGroupIDFields(ref DisBinaryReader reader, GroupID value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.GroupNumber = reader.ReadUInt16("groupNumber");
    }

    private static void PrepareGroupID(GroupID value)
    {
        PrepareGroupIDFields(value);
    }

    private static void PrepareGroupIDFields(GroupID value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteGroupID(ref DisBinaryWriter writer, GroupID value)
    {
        WriteGroupIDFields(ref writer, value);
    }

    private static void WriteGroupIDFields(ref DisBinaryWriter writer, GroupID value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.GroupNumber, "groupNumber");
    }

    private static void MeasureGroupID(in GroupID value, ref int offset)
    {
        MeasureGroupIDFields(value, ref offset);
    }

    private static void MeasureGroupIDFields(in GroupID value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static IFFData ReadIFFData(ref DisBinaryReader reader)
    {
        var value = new IFFData();
        ReadIFFDataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFDataFields(ref DisBinaryReader reader, IFFData value)
    {
        value.RecordType = (VariableRecordType)reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        int RecordSpecificFieldsCount = CheckedCount(Math.Max(0, checked((int)value.RecordLength) - 4), reader.Remaining, "recordSpecificFields");
        value.RecordSpecificFields = new byte[RecordSpecificFieldsCount];
        for (int index = 0; index < RecordSpecificFieldsCount; index++)
            value.RecordSpecificFields[index] = reader.ReadByte("recordSpecificFields");
        reader.Skip(Padding(reader.Offset, 4), "padding");
    }

    private static void PrepareIFFData(IFFData value)
    {
        PrepareIFFDataFields(value);
    }

    private static void PrepareIFFDataFields(IFFData value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificFields);
    }

    private static void WriteIFFData(ref DisBinaryWriter writer, IFFData value)
    {
        WriteIFFDataFields(ref writer, value);
    }

    private static void WriteIFFDataFields(ref DisBinaryWriter writer, IFFData value)
    {
        writer.WriteUInt32((uint)value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        foreach (byte item in value.RecordSpecificFields) writer.WriteByte(item, "recordSpecificFields");
        writer.WriteZeros(Padding(writer.Offset, 4), "padding");
    }

    private static void MeasureIFFData(in IFFData value, ref int offset)
    {
        MeasureIFFDataFields(value, ref offset);
    }

    private static void MeasureIFFDataFields(in IFFData value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += checked(value.RecordSpecificFields.Length * 1);
        offset += Padding(offset, 4);
    }

    private static IFFDataSpecification ReadIFFDataSpecification(ref DisBinaryReader reader)
    {
        var value = new IFFDataSpecification();
        ReadIFFDataSpecificationFields(ref reader, value);
        return value;
    }

    private static void ReadIFFDataSpecificationFields(ref DisBinaryReader reader, IFFDataSpecification value)
    {
        value.NumberOfIFFDataRecords = reader.ReadUInt16("numberOfIFFDataRecords");
        int IffDataRecordsCount = CheckedCount(checked((int)value.NumberOfIFFDataRecords), reader.Remaining, "iffDataRecords");
        value.IffDataRecords = new List<IFFData>(IffDataRecordsCount);
        for (int index = 0; index < IffDataRecordsCount; index++)
            value.IffDataRecords.Add(ReadIFFData(ref reader));
    }

    private static void PrepareIFFDataSpecification(IFFDataSpecification value)
    {
        PrepareIFFDataSpecificationFields(value);
    }

    private static void PrepareIFFDataSpecificationFields(IFFDataSpecification value)
    {
        ArgumentNullException.ThrowIfNull(value.IffDataRecords);
        foreach (IFFData item in value.IffDataRecords) PrepareIFFData(item);
        value.NumberOfIFFDataRecords = checked((ushort)value.IffDataRecords.Count);
    }

    private static void WriteIFFDataSpecification(ref DisBinaryWriter writer, IFFDataSpecification value)
    {
        WriteIFFDataSpecificationFields(ref writer, value);
    }

    private static void WriteIFFDataSpecificationFields(ref DisBinaryWriter writer, IFFDataSpecification value)
    {
        writer.WriteUInt16(value.NumberOfIFFDataRecords, "numberOfIFFDataRecords");
        foreach (IFFData item in value.IffDataRecords) WriteIFFData(ref writer, item);
    }

    private static void MeasureIFFDataSpecification(in IFFDataSpecification value, ref int offset)
    {
        MeasureIFFDataSpecificationFields(value, ref offset);
    }

    private static void MeasureIFFDataSpecificationFields(in IFFDataSpecification value, ref int offset)
    {
        offset += 2;
        foreach (IFFData item in value.IffDataRecords) MeasureIFFData(item, ref offset);
    }

    private static IFFFundamentalParameterData ReadIFFFundamentalParameterData(ref DisBinaryReader reader)
    {
        var value = new IFFFundamentalParameterData();
        ReadIFFFundamentalParameterDataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFFundamentalParameterDataFields(ref DisBinaryReader reader, IFFFundamentalParameterData value)
    {
        value.Erp = reader.ReadSingle("erp");
        value.Frequency = reader.ReadSingle("frequency");
        value.Pgrf = reader.ReadSingle("pgrf");
        value.PulseWidth = reader.ReadSingle("pulseWidth");
        value.BurstLength = reader.ReadUInt32("burstLength");
        value.ApplicableModes = (IffApplicableModes)reader.ReadByte("applicableModes");
        int SystemSpecificDataCount = CheckedCount(3, reader.Remaining, "systemSpecificData");
        value.SystemSpecificData = new byte[SystemSpecificDataCount];
        for (int index = 0; index < SystemSpecificDataCount; index++)
            value.SystemSpecificData[index] = reader.ReadByte("systemSpecificData");
    }

    private static void PrepareIFFFundamentalParameterData(IFFFundamentalParameterData value)
    {
        PrepareIFFFundamentalParameterDataFields(value);
    }

    private static void PrepareIFFFundamentalParameterDataFields(IFFFundamentalParameterData value)
    {
        ArgumentNullException.ThrowIfNull(value.SystemSpecificData);
    }

    private static void WriteIFFFundamentalParameterData(ref DisBinaryWriter writer, IFFFundamentalParameterData value)
    {
        WriteIFFFundamentalParameterDataFields(ref writer, value);
    }

    private static void WriteIFFFundamentalParameterDataFields(ref DisBinaryWriter writer, IFFFundamentalParameterData value)
    {
        writer.WriteSingle(value.Erp, "erp");
        writer.WriteSingle(value.Frequency, "frequency");
        writer.WriteSingle(value.Pgrf, "pgrf");
        writer.WriteSingle(value.PulseWidth, "pulseWidth");
        writer.WriteUInt32(value.BurstLength, "burstLength");
        writer.WriteByte((byte)value.ApplicableModes, "applicableModes");
        foreach (byte item in value.SystemSpecificData) writer.WriteByte(item, "systemSpecificData");
    }

    private static void MeasureIFFFundamentalParameterData(in IFFFundamentalParameterData value, ref int offset)
    {
        MeasureIFFFundamentalParameterDataFields(value, ref offset);
    }

    private static void MeasureIFFFundamentalParameterDataFields(in IFFFundamentalParameterData value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 1;
        offset += checked(value.SystemSpecificData.Length * 1);
    }

    private static IFFPduLayer2Data ReadIFFPduLayer2Data(ref DisBinaryReader reader)
    {
        var value = new IFFPduLayer2Data();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        ReadIFFPduLayer2DataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFPduLayer2DataFields(ref DisBinaryReader reader, IFFPduLayer2Data value)
    {
        value.LayerHeader = ReadLayerHeader(ref reader);
        value.BeamData = ReadBeamData(ref reader);
        value.SecondaryOpParameter1 = reader.ReadByte("secondaryOpParameter1");
        value.SecondaryOpParameter2 = reader.ReadByte("secondaryOpParameter2");
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = reader.ReadUInt16("numberOfIFFFundamentalParameterDataRecordsParameters");
        int IFFFundamentalParameterDataRecordCount = CheckedCount(checked((int)value.NumberOfIFFFundamentalParameterDataRecordsParameters), reader.Remaining, "IFFFundamentalParameterDataRecord");
        value.IFFFundamentalParameterDataRecord = new List<IFFFundamentalParameterData>(IFFFundamentalParameterDataRecordCount);
        for (int index = 0; index < IFFFundamentalParameterDataRecordCount; index++)
            value.IFFFundamentalParameterDataRecord.Add(ReadIFFFundamentalParameterData(ref reader));
    }

    private static void PrepareIFFPduLayer2Data(IFFPduLayer2Data value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
        PrepareIFFPduLayer2DataFields(value);
    }

    private static void PrepareIFFPduLayer2DataFields(IFFPduLayer2Data value)
    {
        ArgumentNullException.ThrowIfNull(value.LayerHeader);
        PrepareLayerHeader(value.LayerHeader);
        ArgumentNullException.ThrowIfNull(value.BeamData);
        PrepareBeamData(value.BeamData);
        ArgumentNullException.ThrowIfNull(value.IFFFundamentalParameterDataRecord);
        foreach (IFFFundamentalParameterData item in value.IFFFundamentalParameterDataRecord) PrepareIFFFundamentalParameterData(item);
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = checked((ushort)value.IFFFundamentalParameterDataRecord.Count);
    }

    private static void WriteIFFPduLayer2Data(ref DisBinaryWriter writer, IFFPduLayer2Data value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
        WriteIFFPduLayer2DataFields(ref writer, value);
    }

    private static void WriteIFFPduLayer2DataFields(ref DisBinaryWriter writer, IFFPduLayer2Data value)
    {
        WriteLayerHeader(ref writer, value.LayerHeader);
        WriteBeamData(ref writer, value.BeamData);
        writer.WriteByte(value.SecondaryOpParameter1, "secondaryOpParameter1");
        writer.WriteByte(value.SecondaryOpParameter2, "secondaryOpParameter2");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterDataRecordsParameters, "numberOfIFFFundamentalParameterDataRecordsParameters");
        foreach (IFFFundamentalParameterData item in value.IFFFundamentalParameterDataRecord) WriteIFFFundamentalParameterData(ref writer, item);
    }

    private static void MeasureIFFPduLayer2Data(in IFFPduLayer2Data value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
        MeasureIFFPduLayer2DataFields(value, ref offset);
    }

    private static void MeasureIFFPduLayer2DataFields(in IFFPduLayer2Data value, ref int offset)
    {
        MeasureLayerHeader(value.LayerHeader, ref offset);
        MeasureBeamData(value.BeamData, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (IFFFundamentalParameterData item in value.IFFFundamentalParameterDataRecord) MeasureIFFFundamentalParameterData(item, ref offset);
    }

    private static IFFPduLayer3InterrogatorFormatData ReadIFFPduLayer3InterrogatorFormatData(ref DisBinaryReader reader)
    {
        var value = new IFFPduLayer3InterrogatorFormatData();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        ReadIFFPduLayer3InterrogatorFormatDataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFPduLayer3InterrogatorFormatDataFields(ref DisBinaryReader reader, IFFPduLayer3InterrogatorFormatData value)
    {
        value.LayerHeader = ReadLayerHeader(ref reader);
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.Mode5InterrogatorBasicData = ReadMode5InterrogatorBasicData(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = reader.ReadUInt16("numberOfIFFFundamentalParameterDataRecordsParameters");
        int IFFFundamentalParameterDataRecordCount = CheckedCount(checked((int)value.NumberOfIFFFundamentalParameterDataRecordsParameters), reader.Remaining, "IFFFundamentalParameterDataRecord");
        value.IFFFundamentalParameterDataRecord = new List<IFFDataSpecification>(IFFFundamentalParameterDataRecordCount);
        for (int index = 0; index < IFFFundamentalParameterDataRecordCount; index++)
            value.IFFFundamentalParameterDataRecord.Add(ReadIFFDataSpecification(ref reader));
    }

    private static void PrepareIFFPduLayer3InterrogatorFormatData(IFFPduLayer3InterrogatorFormatData value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
        PrepareIFFPduLayer3InterrogatorFormatDataFields(value);
    }

    private static void PrepareIFFPduLayer3InterrogatorFormatDataFields(IFFPduLayer3InterrogatorFormatData value)
    {
        ArgumentNullException.ThrowIfNull(value.LayerHeader);
        PrepareLayerHeader(value.LayerHeader);
        ArgumentNullException.ThrowIfNull(value.Mode5InterrogatorBasicData);
        PrepareMode5InterrogatorBasicData(value.Mode5InterrogatorBasicData);
        ArgumentNullException.ThrowIfNull(value.IFFFundamentalParameterDataRecord);
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) PrepareIFFDataSpecification(item);
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = checked((ushort)value.IFFFundamentalParameterDataRecord.Count);
    }

    private static void WriteIFFPduLayer3InterrogatorFormatData(ref DisBinaryWriter writer, IFFPduLayer3InterrogatorFormatData value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
        WriteIFFPduLayer3InterrogatorFormatDataFields(ref writer, value);
    }

    private static void WriteIFFPduLayer3InterrogatorFormatDataFields(ref DisBinaryWriter writer, IFFPduLayer3InterrogatorFormatData value)
    {
        WriteLayerHeader(ref writer, value.LayerHeader);
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        WriteMode5InterrogatorBasicData(ref writer, value.Mode5InterrogatorBasicData);
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterDataRecordsParameters, "numberOfIFFFundamentalParameterDataRecordsParameters");
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) WriteIFFDataSpecification(ref writer, item);
    }

    private static void MeasureIFFPduLayer3InterrogatorFormatData(in IFFPduLayer3InterrogatorFormatData value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
        MeasureIFFPduLayer3InterrogatorFormatDataFields(value, ref offset);
    }

    private static void MeasureIFFPduLayer3InterrogatorFormatDataFields(in IFFPduLayer3InterrogatorFormatData value, ref int offset)
    {
        MeasureLayerHeader(value.LayerHeader, ref offset);
        offset += 2;
        offset += 2;
        MeasureMode5InterrogatorBasicData(value.Mode5InterrogatorBasicData, ref offset);
        offset += 2;
        offset += 2;
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) MeasureIFFDataSpecification(item, ref offset);
    }

    private static IFFPduLayer3TransponderFormatData ReadIFFPduLayer3TransponderFormatData(ref DisBinaryReader reader)
    {
        var value = new IFFPduLayer3TransponderFormatData();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        ReadIFFPduLayer3TransponderFormatDataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFPduLayer3TransponderFormatDataFields(ref DisBinaryReader reader, IFFPduLayer3TransponderFormatData value)
    {
        value.LayerHeader = ReadLayerHeader(ref reader);
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.Mode5TransponderBasicData = ReadMode5TransponderBasicData(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = reader.ReadUInt16("numberOfIFFFundamentalParameterDataRecordsParameters");
        int IFFFundamentalParameterDataRecordCount = CheckedCount(checked((int)value.NumberOfIFFFundamentalParameterDataRecordsParameters), reader.Remaining, "IFFFundamentalParameterDataRecord");
        value.IFFFundamentalParameterDataRecord = new List<IFFDataSpecification>(IFFFundamentalParameterDataRecordCount);
        for (int index = 0; index < IFFFundamentalParameterDataRecordCount; index++)
            value.IFFFundamentalParameterDataRecord.Add(ReadIFFDataSpecification(ref reader));
    }

    private static void PrepareIFFPduLayer3TransponderFormatData(IFFPduLayer3TransponderFormatData value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
        PrepareIFFPduLayer3TransponderFormatDataFields(value);
    }

    private static void PrepareIFFPduLayer3TransponderFormatDataFields(IFFPduLayer3TransponderFormatData value)
    {
        ArgumentNullException.ThrowIfNull(value.LayerHeader);
        PrepareLayerHeader(value.LayerHeader);
        ArgumentNullException.ThrowIfNull(value.Mode5TransponderBasicData);
        PrepareMode5TransponderBasicData(value.Mode5TransponderBasicData);
        ArgumentNullException.ThrowIfNull(value.IFFFundamentalParameterDataRecord);
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) PrepareIFFDataSpecification(item);
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = checked((ushort)value.IFFFundamentalParameterDataRecord.Count);
    }

    private static void WriteIFFPduLayer3TransponderFormatData(ref DisBinaryWriter writer, IFFPduLayer3TransponderFormatData value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
        WriteIFFPduLayer3TransponderFormatDataFields(ref writer, value);
    }

    private static void WriteIFFPduLayer3TransponderFormatDataFields(ref DisBinaryWriter writer, IFFPduLayer3TransponderFormatData value)
    {
        WriteLayerHeader(ref writer, value.LayerHeader);
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        WriteMode5TransponderBasicData(ref writer, value.Mode5TransponderBasicData);
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterDataRecordsParameters, "numberOfIFFFundamentalParameterDataRecordsParameters");
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) WriteIFFDataSpecification(ref writer, item);
    }

    private static void MeasureIFFPduLayer3TransponderFormatData(in IFFPduLayer3TransponderFormatData value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
        MeasureIFFPduLayer3TransponderFormatDataFields(value, ref offset);
    }

    private static void MeasureIFFPduLayer3TransponderFormatDataFields(in IFFPduLayer3TransponderFormatData value, ref int offset)
    {
        MeasureLayerHeader(value.LayerHeader, ref offset);
        offset += 2;
        offset += 2;
        MeasureMode5TransponderBasicData(value.Mode5TransponderBasicData, ref offset);
        offset += 2;
        offset += 2;
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) MeasureIFFDataSpecification(item, ref offset);
    }

    private static IFFPduLayer4InterrogatorFormatData ReadIFFPduLayer4InterrogatorFormatData(ref DisBinaryReader reader)
    {
        var value = new IFFPduLayer4InterrogatorFormatData();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        ReadIFFPduLayer4InterrogatorFormatDataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFPduLayer4InterrogatorFormatDataFields(ref DisBinaryReader reader, IFFPduLayer4InterrogatorFormatData value)
    {
        value.LayerHeader = ReadLayerHeader(ref reader);
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.ModeSInterrogatorBasicData = ReadModeSInterrogatorBasicData(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = reader.ReadUInt16("numberOfIFFFundamentalParameterDataRecordsParameters");
        int IFFFundamentalParameterDataRecordCount = CheckedCount(checked((int)value.NumberOfIFFFundamentalParameterDataRecordsParameters), reader.Remaining, "IFFFundamentalParameterDataRecord");
        value.IFFFundamentalParameterDataRecord = new List<IFFDataSpecification>(IFFFundamentalParameterDataRecordCount);
        for (int index = 0; index < IFFFundamentalParameterDataRecordCount; index++)
            value.IFFFundamentalParameterDataRecord.Add(ReadIFFDataSpecification(ref reader));
    }

    private static void PrepareIFFPduLayer4InterrogatorFormatData(IFFPduLayer4InterrogatorFormatData value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
        PrepareIFFPduLayer4InterrogatorFormatDataFields(value);
    }

    private static void PrepareIFFPduLayer4InterrogatorFormatDataFields(IFFPduLayer4InterrogatorFormatData value)
    {
        ArgumentNullException.ThrowIfNull(value.LayerHeader);
        PrepareLayerHeader(value.LayerHeader);
        ArgumentNullException.ThrowIfNull(value.ModeSInterrogatorBasicData);
        PrepareModeSInterrogatorBasicData(value.ModeSInterrogatorBasicData);
        ArgumentNullException.ThrowIfNull(value.IFFFundamentalParameterDataRecord);
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) PrepareIFFDataSpecification(item);
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = checked((ushort)value.IFFFundamentalParameterDataRecord.Count);
    }

    private static void WriteIFFPduLayer4InterrogatorFormatData(ref DisBinaryWriter writer, IFFPduLayer4InterrogatorFormatData value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
        WriteIFFPduLayer4InterrogatorFormatDataFields(ref writer, value);
    }

    private static void WriteIFFPduLayer4InterrogatorFormatDataFields(ref DisBinaryWriter writer, IFFPduLayer4InterrogatorFormatData value)
    {
        WriteLayerHeader(ref writer, value.LayerHeader);
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        WriteModeSInterrogatorBasicData(ref writer, value.ModeSInterrogatorBasicData);
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterDataRecordsParameters, "numberOfIFFFundamentalParameterDataRecordsParameters");
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) WriteIFFDataSpecification(ref writer, item);
    }

    private static void MeasureIFFPduLayer4InterrogatorFormatData(in IFFPduLayer4InterrogatorFormatData value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
        MeasureIFFPduLayer4InterrogatorFormatDataFields(value, ref offset);
    }

    private static void MeasureIFFPduLayer4InterrogatorFormatDataFields(in IFFPduLayer4InterrogatorFormatData value, ref int offset)
    {
        MeasureLayerHeader(value.LayerHeader, ref offset);
        offset += 2;
        offset += 2;
        MeasureModeSInterrogatorBasicData(value.ModeSInterrogatorBasicData, ref offset);
        offset += 2;
        offset += 2;
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) MeasureIFFDataSpecification(item, ref offset);
    }

    private static IFFPduLayer4TransponderFormatData ReadIFFPduLayer4TransponderFormatData(ref DisBinaryReader reader)
    {
        var value = new IFFPduLayer4TransponderFormatData();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        ReadIFFPduLayer4TransponderFormatDataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFPduLayer4TransponderFormatDataFields(ref DisBinaryReader reader, IFFPduLayer4TransponderFormatData value)
    {
        value.LayerHeader = ReadLayerHeader(ref reader);
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.ModeSTransponderBasicData = ReadModeSTransponderBasicData(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = reader.ReadUInt16("numberOfIFFFundamentalParameterDataRecordsParameters");
        int IFFFundamentalParameterDataRecordCount = CheckedCount(checked((int)value.NumberOfIFFFundamentalParameterDataRecordsParameters), reader.Remaining, "IFFFundamentalParameterDataRecord");
        value.IFFFundamentalParameterDataRecord = new List<IFFDataSpecification>(IFFFundamentalParameterDataRecordCount);
        for (int index = 0; index < IFFFundamentalParameterDataRecordCount; index++)
            value.IFFFundamentalParameterDataRecord.Add(ReadIFFDataSpecification(ref reader));
    }

    private static void PrepareIFFPduLayer4TransponderFormatData(IFFPduLayer4TransponderFormatData value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
        PrepareIFFPduLayer4TransponderFormatDataFields(value);
    }

    private static void PrepareIFFPduLayer4TransponderFormatDataFields(IFFPduLayer4TransponderFormatData value)
    {
        ArgumentNullException.ThrowIfNull(value.LayerHeader);
        PrepareLayerHeader(value.LayerHeader);
        ArgumentNullException.ThrowIfNull(value.ModeSTransponderBasicData);
        PrepareModeSTransponderBasicData(value.ModeSTransponderBasicData);
        ArgumentNullException.ThrowIfNull(value.IFFFundamentalParameterDataRecord);
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) PrepareIFFDataSpecification(item);
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = checked((ushort)value.IFFFundamentalParameterDataRecord.Count);
    }

    private static void WriteIFFPduLayer4TransponderFormatData(ref DisBinaryWriter writer, IFFPduLayer4TransponderFormatData value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
        WriteIFFPduLayer4TransponderFormatDataFields(ref writer, value);
    }

    private static void WriteIFFPduLayer4TransponderFormatDataFields(ref DisBinaryWriter writer, IFFPduLayer4TransponderFormatData value)
    {
        WriteLayerHeader(ref writer, value.LayerHeader);
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        WriteModeSTransponderBasicData(ref writer, value.ModeSTransponderBasicData);
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterDataRecordsParameters, "numberOfIFFFundamentalParameterDataRecordsParameters");
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) WriteIFFDataSpecification(ref writer, item);
    }

    private static void MeasureIFFPduLayer4TransponderFormatData(in IFFPduLayer4TransponderFormatData value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
        MeasureIFFPduLayer4TransponderFormatDataFields(value, ref offset);
    }

    private static void MeasureIFFPduLayer4TransponderFormatDataFields(in IFFPduLayer4TransponderFormatData value, ref int offset)
    {
        MeasureLayerHeader(value.LayerHeader, ref offset);
        offset += 2;
        offset += 2;
        MeasureModeSTransponderBasicData(value.ModeSTransponderBasicData, ref offset);
        offset += 2;
        offset += 2;
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) MeasureIFFDataSpecification(item, ref offset);
    }

    private static IFFPduLayer5Data ReadIFFPduLayer5Data(ref DisBinaryReader reader)
    {
        var value = new IFFPduLayer5Data();
        ReadAbstractIFFPduLayerDataFields(ref reader, value);
        ReadIFFPduLayer5DataFields(ref reader, value);
        return value;
    }

    private static void ReadIFFPduLayer5DataFields(ref DisBinaryReader reader, IFFPduLayer5Data value)
    {
        value.LayerHeader = ReadLayerHeader(ref reader);
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.Padding = reader.ReadUInt16("padding");
        value.ApplicableLayers = reader.ReadByte("applicableLayers");
        value.DataCategory = (DataCategory)reader.ReadByte("dataCategory");
        value.Padding2 = reader.ReadUInt16("padding2");
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = reader.ReadUInt16("numberOfIFFFundamentalParameterDataRecordsParameters");
        int IFFFundamentalParameterDataRecordCount = CheckedCount(checked((int)value.NumberOfIFFFundamentalParameterDataRecordsParameters), reader.Remaining, "IFFFundamentalParameterDataRecord");
        value.IFFFundamentalParameterDataRecord = new List<IFFDataSpecification>(IFFFundamentalParameterDataRecordCount);
        for (int index = 0; index < IFFFundamentalParameterDataRecordCount; index++)
            value.IFFFundamentalParameterDataRecord.Add(ReadIFFDataSpecification(ref reader));
    }

    private static void PrepareIFFPduLayer5Data(IFFPduLayer5Data value)
    {
        PrepareAbstractIFFPduLayerDataFields(value);
        PrepareIFFPduLayer5DataFields(value);
    }

    private static void PrepareIFFPduLayer5DataFields(IFFPduLayer5Data value)
    {
        ArgumentNullException.ThrowIfNull(value.LayerHeader);
        PrepareLayerHeader(value.LayerHeader);
        ArgumentNullException.ThrowIfNull(value.IFFFundamentalParameterDataRecord);
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) PrepareIFFDataSpecification(item);
        value.NumberOfIFFFundamentalParameterDataRecordsParameters = checked((ushort)value.IFFFundamentalParameterDataRecord.Count);
    }

    private static void WriteIFFPduLayer5Data(ref DisBinaryWriter writer, IFFPduLayer5Data value)
    {
        WriteAbstractIFFPduLayerDataFields(ref writer, value);
        WriteIFFPduLayer5DataFields(ref writer, value);
    }

    private static void WriteIFFPduLayer5DataFields(ref DisBinaryWriter writer, IFFPduLayer5Data value)
    {
        WriteLayerHeader(ref writer, value.LayerHeader);
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        writer.WriteUInt16(value.Padding, "padding");
        writer.WriteByte(value.ApplicableLayers, "applicableLayers");
        writer.WriteByte((byte)value.DataCategory, "dataCategory");
        writer.WriteUInt16(value.Padding2, "padding2");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterDataRecordsParameters, "numberOfIFFFundamentalParameterDataRecordsParameters");
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) WriteIFFDataSpecification(ref writer, item);
    }

    private static void MeasureIFFPduLayer5Data(in IFFPduLayer5Data value, ref int offset)
    {
        MeasureAbstractIFFPduLayerDataFields(value, ref offset);
        MeasureIFFPduLayer5DataFields(value, ref offset);
    }

    private static void MeasureIFFPduLayer5DataFields(in IFFPduLayer5Data value, ref int offset)
    {
        MeasureLayerHeader(value.LayerHeader, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 2;
        foreach (IFFDataSpecification item in value.IFFFundamentalParameterDataRecord) MeasureIFFDataSpecification(item, ref offset);
    }

    private static IOCommsNodeRecord ReadIOCommsNodeRecord(ref DisBinaryReader reader)
    {
        var value = new IOCommsNodeRecord();
        ReadIORecordFields(ref reader, value);
        ReadIOCommsNodeRecordFields(ref reader, value);
        return value;
    }

    private static void ReadIOCommsNodeRecordFields(ref DisBinaryReader reader, IOCommsNodeRecord value)
    {
        value.RecordType = (VariableRecordType)reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.CommsNodeType = (IoCommsNodeRecordCommsNodeType)reader.ReadByte("commsNodeType");
        value.Padding = reader.ReadByte("padding");
        value.CommsNodeId = ReadCommunicationsNodeID(ref reader);
    }

    private static void PrepareIOCommsNodeRecord(IOCommsNodeRecord value)
    {
        PrepareIORecordFields(value);
        PrepareIOCommsNodeRecordFields(value);
    }

    private static void PrepareIOCommsNodeRecordFields(IOCommsNodeRecord value)
    {
        ArgumentNullException.ThrowIfNull(value.CommsNodeId);
        PrepareCommunicationsNodeID(value.CommsNodeId);
    }

    private static void WriteIOCommsNodeRecord(ref DisBinaryWriter writer, IOCommsNodeRecord value)
    {
        WriteIORecordFields(ref writer, value);
        WriteIOCommsNodeRecordFields(ref writer, value);
    }

    private static void WriteIOCommsNodeRecordFields(ref DisBinaryWriter writer, IOCommsNodeRecord value)
    {
        writer.WriteUInt32((uint)value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteByte((byte)value.CommsNodeType, "commsNodeType");
        writer.WriteByte(value.Padding, "padding");
        WriteCommunicationsNodeID(ref writer, value.CommsNodeId);
    }

    private static void MeasureIOCommsNodeRecord(in IOCommsNodeRecord value, ref int offset)
    {
        MeasureIORecordFields(value, ref offset);
        MeasureIOCommsNodeRecordFields(value, ref offset);
    }

    private static void MeasureIOCommsNodeRecordFields(in IOCommsNodeRecord value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
        MeasureCommunicationsNodeID(value.CommsNodeId, ref offset);
    }

    private static IOEffectRecord ReadIOEffectRecord(ref DisBinaryReader reader)
    {
        var value = new IOEffectRecord();
        ReadIORecordFields(ref reader, value);
        ReadIOEffectRecordFields(ref reader, value);
        return value;
    }

    private static void ReadIOEffectRecordFields(ref DisBinaryReader reader, IOEffectRecord value)
    {
        value.RecordType = (VariableRecordType)reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.IoStatus = (IoEffectsRecordIoStatus)reader.ReadByte("ioStatus");
        value.IoLinkType = (IoEffectsRecordIoLinkType)reader.ReadByte("ioLinkType");
        value.IoEffect = (IoEffectsRecordIoEffect)reader.ReadByte("ioEffect");
        value.IoEffectDutyCycle = reader.ReadByte("ioEffectDutyCycle");
        value.IoEffectDuration = reader.ReadUInt16("ioEffectDuration");
        value.IoProcess = (IoEffectsRecordIoProcess)reader.ReadUInt16("ioProcess");
        value.Padding = reader.ReadUInt16("padding");
    }

    private static void PrepareIOEffectRecord(IOEffectRecord value)
    {
        PrepareIORecordFields(value);
        PrepareIOEffectRecordFields(value);
    }

    private static void PrepareIOEffectRecordFields(IOEffectRecord value)
    {
    }

    private static void WriteIOEffectRecord(ref DisBinaryWriter writer, IOEffectRecord value)
    {
        WriteIORecordFields(ref writer, value);
        WriteIOEffectRecordFields(ref writer, value);
    }

    private static void WriteIOEffectRecordFields(ref DisBinaryWriter writer, IOEffectRecord value)
    {
        writer.WriteUInt32((uint)value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteByte((byte)value.IoStatus, "ioStatus");
        writer.WriteByte((byte)value.IoLinkType, "ioLinkType");
        writer.WriteByte((byte)value.IoEffect, "ioEffect");
        writer.WriteByte(value.IoEffectDutyCycle, "ioEffectDutyCycle");
        writer.WriteUInt16(value.IoEffectDuration, "ioEffectDuration");
        writer.WriteUInt16((ushort)value.IoProcess, "ioProcess");
        writer.WriteUInt16(value.Padding, "padding");
    }

    private static void MeasureIOEffectRecord(in IOEffectRecord value, ref int offset)
    {
        MeasureIORecordFields(value, ref offset);
        MeasureIOEffectRecordFields(value, ref offset);
    }

    private static void MeasureIOEffectRecordFields(in IOEffectRecord value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static IORecord ReadIORecord(ref DisBinaryReader reader)
    {
        var value = new IORecord();
        ReadIORecordFields(ref reader, value);
        return value;
    }

    private static void ReadIORecordFields(ref DisBinaryReader reader, IORecord value)
    {
    }

    private static void PrepareIORecord(IORecord value)
    {
        PrepareIORecordFields(value);
    }

    private static void PrepareIORecordFields(IORecord value)
    {
    }

    private static void WriteIORecord(ref DisBinaryWriter writer, IORecord value)
    {
        WriteIORecordFields(ref writer, value);
    }

    private static void WriteIORecordFields(ref DisBinaryWriter writer, IORecord value)
    {
    }

    private static void MeasureIORecord(in IORecord value, ref int offset)
    {
        MeasureIORecordFields(value, ref offset);
    }

    private static void MeasureIORecordFields(in IORecord value, ref int offset)
    {
    }

    private static void ReadIdentificationFriendOrFoePduFields(ref DisBinaryReader reader, IdentificationFriendOrFoePdu value)
    {
        value.EmittingEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.Location = ReadVector3Float(ref reader);
        value.SystemId = ReadSystemIdentifier(ref reader);
        value.SystemDesignator = reader.ReadByte("systemDesignator");
        value.SystemSpecificData = reader.ReadByte("systemSpecificData");
        value.FundamentalParameters = ReadFundamentalOperationalData(ref reader);
        value.IFFPduLayer2Data = ReadIFFPduLayer2Data(ref reader);
        value.IFFPduLayer3TransponderFormatData = ReadIFFPduLayer3TransponderFormatData(ref reader);
        value.IFFPduLayer3InterrogatorFormatData = ReadIFFPduLayer3InterrogatorFormatData(ref reader);
        value.IFFPduLayer4InterrogatorFormatData = ReadIFFPduLayer4InterrogatorFormatData(ref reader);
        value.IFFPduLayer4TransponderFormatData = ReadIFFPduLayer4TransponderFormatData(ref reader);
        value.IFFPduLayer5Data = ReadIFFPduLayer5Data(ref reader);
    }

    private static void PrepareIdentificationFriendOrFoePduFields(IdentificationFriendOrFoePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EmittingEntityId);
        PrepareEntityId(value.EmittingEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.Location);
        PrepareVector3Float(value.Location);
        ArgumentNullException.ThrowIfNull(value.SystemId);
        PrepareSystemIdentifier(value.SystemId);
        ArgumentNullException.ThrowIfNull(value.FundamentalParameters);
        PrepareFundamentalOperationalData(value.FundamentalParameters);
        ArgumentNullException.ThrowIfNull(value.IFFPduLayer2Data);
        PrepareIFFPduLayer2Data(value.IFFPduLayer2Data);
        ArgumentNullException.ThrowIfNull(value.IFFPduLayer3TransponderFormatData);
        PrepareIFFPduLayer3TransponderFormatData(value.IFFPduLayer3TransponderFormatData);
        ArgumentNullException.ThrowIfNull(value.IFFPduLayer3InterrogatorFormatData);
        PrepareIFFPduLayer3InterrogatorFormatData(value.IFFPduLayer3InterrogatorFormatData);
        ArgumentNullException.ThrowIfNull(value.IFFPduLayer4InterrogatorFormatData);
        PrepareIFFPduLayer4InterrogatorFormatData(value.IFFPduLayer4InterrogatorFormatData);
        ArgumentNullException.ThrowIfNull(value.IFFPduLayer4TransponderFormatData);
        PrepareIFFPduLayer4TransponderFormatData(value.IFFPduLayer4TransponderFormatData);
        ArgumentNullException.ThrowIfNull(value.IFFPduLayer5Data);
        PrepareIFFPduLayer5Data(value.IFFPduLayer5Data);
    }

    private static void WriteIdentificationFriendOrFoePduFields(ref DisBinaryWriter writer, IdentificationFriendOrFoePdu value)
    {
        WriteEntityId(ref writer, value.EmittingEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        WriteVector3Float(ref writer, value.Location);
        WriteSystemIdentifier(ref writer, value.SystemId);
        writer.WriteByte(value.SystemDesignator, "systemDesignator");
        writer.WriteByte(value.SystemSpecificData, "systemSpecificData");
        WriteFundamentalOperationalData(ref writer, value.FundamentalParameters);
        WriteIFFPduLayer2Data(ref writer, value.IFFPduLayer2Data);
        WriteIFFPduLayer3TransponderFormatData(ref writer, value.IFFPduLayer3TransponderFormatData);
        WriteIFFPduLayer3InterrogatorFormatData(ref writer, value.IFFPduLayer3InterrogatorFormatData);
        WriteIFFPduLayer4InterrogatorFormatData(ref writer, value.IFFPduLayer4InterrogatorFormatData);
        WriteIFFPduLayer4TransponderFormatData(ref writer, value.IFFPduLayer4TransponderFormatData);
        WriteIFFPduLayer5Data(ref writer, value.IFFPduLayer5Data);
    }

    private static void MeasureIdentificationFriendOrFoePduFields(in IdentificationFriendOrFoePdu value, ref int offset)
    {
        MeasureEntityId(value.EmittingEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        MeasureVector3Float(value.Location, ref offset);
        MeasureSystemIdentifier(value.SystemId, ref offset);
        offset += 1;
        offset += 1;
        MeasureFundamentalOperationalData(value.FundamentalParameters, ref offset);
        MeasureIFFPduLayer2Data(value.IFFPduLayer2Data, ref offset);
        MeasureIFFPduLayer3TransponderFormatData(value.IFFPduLayer3TransponderFormatData, ref offset);
        MeasureIFFPduLayer3InterrogatorFormatData(value.IFFPduLayer3InterrogatorFormatData, ref offset);
        MeasureIFFPduLayer4InterrogatorFormatData(value.IFFPduLayer4InterrogatorFormatData, ref offset);
        MeasureIFFPduLayer4TransponderFormatData(value.IFFPduLayer4TransponderFormatData, ref offset);
        MeasureIFFPduLayer5Data(value.IFFPduLayer5Data, ref offset);
    }

    private static void ReadInformationOperationsActionPduFields(ref DisBinaryReader reader, InformationOperationsActionPdu value)
    {
        value.ReceivingSimId = ReadEntityId(ref reader);
        value.RequestId = reader.ReadUInt32("requestID");
        value.IOWarfareType = (IoActionIoWarfareType)reader.ReadUInt16("IOWarfareType");
        value.IOSimulationSource = (IoActionIoSimulationSource)reader.ReadUInt16("IOSimulationSource");
        value.IOActionType = (IoActionIoActionType)reader.ReadUInt16("IOActionType");
        value.IOActionPhase = (IoActionIoActionPhase)reader.ReadUInt16("IOActionPhase");
        value.Padding1 = reader.ReadUInt32("padding1");
        value.IoAttackerId = ReadEntityId(ref reader);
        value.IoPrimaryTargetId = ReadEntityId(ref reader);
        value.Padding2 = reader.ReadUInt16("padding2");
        value.NumberOfIORecords = reader.ReadUInt16("numberOfIORecords");
        int IoRecordsCount = CheckedCount(checked((int)value.NumberOfIORecords), reader.Remaining, "ioRecords");
        value.IoRecords = new List<IORecord>(IoRecordsCount);
        for (int index = 0; index < IoRecordsCount; index++)
            value.IoRecords.Add(ReadIORecord(ref reader));
    }

    private static void PrepareInformationOperationsActionPduFields(InformationOperationsActionPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ReceivingSimId);
        PrepareEntityId(value.ReceivingSimId);
        ArgumentNullException.ThrowIfNull(value.IoAttackerId);
        PrepareEntityId(value.IoAttackerId);
        ArgumentNullException.ThrowIfNull(value.IoPrimaryTargetId);
        PrepareEntityId(value.IoPrimaryTargetId);
        ArgumentNullException.ThrowIfNull(value.IoRecords);
        foreach (IORecord item in value.IoRecords) PrepareIORecord(item);
        value.NumberOfIORecords = checked((ushort)value.IoRecords.Count);
    }

    private static void WriteInformationOperationsActionPduFields(ref DisBinaryWriter writer, InformationOperationsActionPdu value)
    {
        WriteEntityId(ref writer, value.ReceivingSimId);
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt16((ushort)value.IOWarfareType, "IOWarfareType");
        writer.WriteUInt16((ushort)value.IOSimulationSource, "IOSimulationSource");
        writer.WriteUInt16((ushort)value.IOActionType, "IOActionType");
        writer.WriteUInt16((ushort)value.IOActionPhase, "IOActionPhase");
        writer.WriteUInt32(value.Padding1, "padding1");
        WriteEntityId(ref writer, value.IoAttackerId);
        WriteEntityId(ref writer, value.IoPrimaryTargetId);
        writer.WriteUInt16(value.Padding2, "padding2");
        writer.WriteUInt16(value.NumberOfIORecords, "numberOfIORecords");
        foreach (IORecord item in value.IoRecords) WriteIORecord(ref writer, item);
    }

    private static void MeasureInformationOperationsActionPduFields(in InformationOperationsActionPdu value, ref int offset)
    {
        MeasureEntityId(value.ReceivingSimId, ref offset);
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 4;
        MeasureEntityId(value.IoAttackerId, ref offset);
        MeasureEntityId(value.IoPrimaryTargetId, ref offset);
        offset += 2;
        offset += 2;
        foreach (IORecord item in value.IoRecords) MeasureIORecord(item, ref offset);
    }

    private static void ReadInformationOperationsFamilyPduFields(ref DisBinaryReader reader, InformationOperationsFamilyPdu value)
    {
        value.OriginatingSimId = ReadEntityId(ref reader);
    }

    private static void PrepareInformationOperationsFamilyPduFields(InformationOperationsFamilyPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OriginatingSimId);
        PrepareEntityId(value.OriginatingSimId);
    }

    private static void WriteInformationOperationsFamilyPduFields(ref DisBinaryWriter writer, InformationOperationsFamilyPdu value)
    {
        WriteEntityId(ref writer, value.OriginatingSimId);
    }

    private static void MeasureInformationOperationsFamilyPduFields(in InformationOperationsFamilyPdu value, ref int offset)
    {
        MeasureEntityId(value.OriginatingSimId, ref offset);
    }

    private static void ReadInformationOperationsReportPduFields(ref DisBinaryReader reader, InformationOperationsReportPdu value)
    {
        value.IoSimSource = (IoActionIoSimulationSource)reader.ReadUInt16("ioSimSource");
        value.IoReportType = (IoReportIoReportType)reader.ReadByte("ioReportType");
        value.Padding1 = reader.ReadByte("padding1");
        value.IoAttackerId = ReadEntityId(ref reader);
        value.IoPrimaryTargetId = ReadEntityId(ref reader);
        value.Padding2 = reader.ReadUInt16("padding2");
        value.Padding3 = reader.ReadUInt16("padding3");
        value.NumberOfIORecords = reader.ReadUInt16("numberOfIORecords");
        int IoRecordsCount = CheckedCount(checked((int)value.NumberOfIORecords), reader.Remaining, "ioRecords");
        value.IoRecords = new List<IORecord>(IoRecordsCount);
        for (int index = 0; index < IoRecordsCount; index++)
            value.IoRecords.Add(ReadIORecord(ref reader));
    }

    private static void PrepareInformationOperationsReportPduFields(InformationOperationsReportPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.IoAttackerId);
        PrepareEntityId(value.IoAttackerId);
        ArgumentNullException.ThrowIfNull(value.IoPrimaryTargetId);
        PrepareEntityId(value.IoPrimaryTargetId);
        ArgumentNullException.ThrowIfNull(value.IoRecords);
        foreach (IORecord item in value.IoRecords) PrepareIORecord(item);
        value.NumberOfIORecords = checked((ushort)value.IoRecords.Count);
    }

    private static void WriteInformationOperationsReportPduFields(ref DisBinaryWriter writer, InformationOperationsReportPdu value)
    {
        writer.WriteUInt16((ushort)value.IoSimSource, "ioSimSource");
        writer.WriteByte((byte)value.IoReportType, "ioReportType");
        writer.WriteByte(value.Padding1, "padding1");
        WriteEntityId(ref writer, value.IoAttackerId);
        WriteEntityId(ref writer, value.IoPrimaryTargetId);
        writer.WriteUInt16(value.Padding2, "padding2");
        writer.WriteUInt16(value.Padding3, "padding3");
        writer.WriteUInt16(value.NumberOfIORecords, "numberOfIORecords");
        foreach (IORecord item in value.IoRecords) WriteIORecord(ref writer, item);
    }

    private static void MeasureInformationOperationsReportPduFields(in InformationOperationsReportPdu value, ref int offset)
    {
        offset += 2;
        offset += 1;
        offset += 1;
        MeasureEntityId(value.IoAttackerId, ref offset);
        MeasureEntityId(value.IoPrimaryTargetId, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        foreach (IORecord item in value.IoRecords) MeasureIORecord(item, ref offset);
    }

    private static IntercomCommunicationsParameters ReadIntercomCommunicationsParameters(ref DisBinaryReader reader)
    {
        var value = new IntercomCommunicationsParameters();
        ReadIntercomCommunicationsParametersFields(ref reader, value);
        return value;
    }

    private static void ReadIntercomCommunicationsParametersFields(ref DisBinaryReader reader, IntercomCommunicationsParameters value)
    {
        value.RecordType = (IntercomControlRecordType)reader.ReadUInt16("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        int RecordSpecificFieldCount = CheckedCount(Math.Max(0, checked((int)value.RecordLength) - 4), reader.Remaining, "recordSpecificField");
        value.RecordSpecificField = new byte[RecordSpecificFieldCount];
        for (int index = 0; index < RecordSpecificFieldCount; index++)
            value.RecordSpecificField[index] = reader.ReadByte("recordSpecificField");
        reader.Skip(Padding(reader.Offset, 4), "padding");
    }

    private static void PrepareIntercomCommunicationsParameters(IntercomCommunicationsParameters value)
    {
        PrepareIntercomCommunicationsParametersFields(value);
    }

    private static void PrepareIntercomCommunicationsParametersFields(IntercomCommunicationsParameters value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificField);
    }

    private static void WriteIntercomCommunicationsParameters(ref DisBinaryWriter writer, IntercomCommunicationsParameters value)
    {
        WriteIntercomCommunicationsParametersFields(ref writer, value);
    }

    private static void WriteIntercomCommunicationsParametersFields(ref DisBinaryWriter writer, IntercomCommunicationsParameters value)
    {
        writer.WriteUInt16((ushort)value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        foreach (byte item in value.RecordSpecificField) writer.WriteByte(item, "recordSpecificField");
        writer.WriteZeros(Padding(writer.Offset, 4), "padding");
    }

    private static void MeasureIntercomCommunicationsParameters(in IntercomCommunicationsParameters value, ref int offset)
    {
        MeasureIntercomCommunicationsParametersFields(value, ref offset);
    }

    private static void MeasureIntercomCommunicationsParametersFields(in IntercomCommunicationsParameters value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += checked(value.RecordSpecificField.Length * 1);
        offset += Padding(offset, 4);
    }

    private static void ReadIntercomControlPduFields(ref DisBinaryReader reader, IntercomControlPdu value)
    {
        value.ControlType = (IntercomControlControlType)reader.ReadByte("controlType");
        value.CommunicationsChannelType = reader.ReadByte("communicationsChannelType");
        value.SourceEntityId = ReadEntityId(ref reader);
        value.SourceIntercomNumber = reader.ReadUInt16("sourceIntercomNumber");
        value.SourceLineId = reader.ReadByte("sourceLineID");
        value.TransmitPriority = reader.ReadByte("transmitPriority");
        value.TransmitLineState = (IntercomControlTransmitLineState)reader.ReadByte("transmitLineState");
        value.Command = (IntercomControlCommand)reader.ReadByte("command");
        value.MasterIntercomReferenceId = ReadEntityId(ref reader);
        value.MasterIntercomNumber = reader.ReadUInt16("masterIntercomNumber");
        value.MasterChannelId = reader.ReadUInt16("masterChannelID");
        value.IntercomParametersLength = reader.ReadUInt32("intercomParametersLength");
        int IntercomParametersCount = CheckedCount(checked((int)value.IntercomParametersLength), reader.Remaining, "intercomParameters");
        int IntercomParametersEnd = checked(reader.Offset + IntercomParametersCount);
        value.IntercomParameters = [];
        while (reader.Offset < IntercomParametersEnd)
        {
            value.IntercomParameters.Add(ReadIntercomCommunicationsParameters(ref reader));
            if (reader.Offset > IntercomParametersEnd) throw new FormatException("A intercomParameters record exceeds its declared byte length.");
        }
    }

    private static void PrepareIntercomControlPduFields(IntercomControlPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.SourceEntityId);
        PrepareEntityId(value.SourceEntityId);
        ArgumentNullException.ThrowIfNull(value.MasterIntercomReferenceId);
        PrepareEntityId(value.MasterIntercomReferenceId);
        ArgumentNullException.ThrowIfNull(value.IntercomParameters);
        foreach (IntercomCommunicationsParameters item in value.IntercomParameters) PrepareIntercomCommunicationsParameters(item);
        int IntercomParametersByteLength = 0;
        foreach (IntercomCommunicationsParameters item in value.IntercomParameters) MeasureIntercomCommunicationsParameters(item, ref IntercomParametersByteLength);
        value.IntercomParametersLength = checked((uint)IntercomParametersByteLength);
    }

    private static void WriteIntercomControlPduFields(ref DisBinaryWriter writer, IntercomControlPdu value)
    {
        writer.WriteByte((byte)value.ControlType, "controlType");
        writer.WriteByte(value.CommunicationsChannelType, "communicationsChannelType");
        WriteEntityId(ref writer, value.SourceEntityId);
        writer.WriteUInt16(value.SourceIntercomNumber, "sourceIntercomNumber");
        writer.WriteByte(value.SourceLineId, "sourceLineID");
        writer.WriteByte(value.TransmitPriority, "transmitPriority");
        writer.WriteByte((byte)value.TransmitLineState, "transmitLineState");
        writer.WriteByte((byte)value.Command, "command");
        WriteEntityId(ref writer, value.MasterIntercomReferenceId);
        writer.WriteUInt16(value.MasterIntercomNumber, "masterIntercomNumber");
        writer.WriteUInt16(value.MasterChannelId, "masterChannelID");
        writer.WriteUInt32(value.IntercomParametersLength, "intercomParametersLength");
        foreach (IntercomCommunicationsParameters item in value.IntercomParameters) WriteIntercomCommunicationsParameters(ref writer, item);
    }

    private static void MeasureIntercomControlPduFields(in IntercomControlPdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        MeasureEntityId(value.SourceEntityId, ref offset);
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureEntityId(value.MasterIntercomReferenceId, ref offset);
        offset += 2;
        offset += 2;
        offset += 4;
        foreach (IntercomCommunicationsParameters item in value.IntercomParameters) MeasureIntercomCommunicationsParameters(item, ref offset);
    }

    private static IntercomIdentifier ReadIntercomIdentifier(ref DisBinaryReader reader)
    {
        var value = new IntercomIdentifier();
        ReadIntercomIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadIntercomIdentifierFields(ref DisBinaryReader reader, IntercomIdentifier value)
    {
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.ReferenceNumber = reader.ReadUInt16("referenceNumber");
        value.IntercomNumber = reader.ReadUInt16("intercomNumber");
    }

    private static void PrepareIntercomIdentifier(IntercomIdentifier value)
    {
        PrepareIntercomIdentifierFields(value);
    }

    private static void PrepareIntercomIdentifierFields(IntercomIdentifier value)
    {
    }

    private static void WriteIntercomIdentifier(ref DisBinaryWriter writer, IntercomIdentifier value)
    {
        WriteIntercomIdentifierFields(ref writer, value);
    }

    private static void WriteIntercomIdentifierFields(ref DisBinaryWriter writer, IntercomIdentifier value)
    {
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        writer.WriteUInt16(value.ReferenceNumber, "referenceNumber");
        writer.WriteUInt16(value.IntercomNumber, "intercomNumber");
    }

    private static void MeasureIntercomIdentifier(in IntercomIdentifier value, ref int offset)
    {
        MeasureIntercomIdentifierFields(value, ref offset);
    }

    private static void MeasureIntercomIdentifierFields(in IntercomIdentifier value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static IntercomReferenceID ReadIntercomReferenceID(ref DisBinaryReader reader)
    {
        var value = new IntercomReferenceID();
        ReadIntercomReferenceIDFields(ref reader, value);
        return value;
    }

    private static void ReadIntercomReferenceIDFields(ref DisBinaryReader reader, IntercomReferenceID value)
    {
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.ReferenceNumber = reader.ReadUInt16("referenceNumber");
    }

    private static void PrepareIntercomReferenceID(IntercomReferenceID value)
    {
        PrepareIntercomReferenceIDFields(value);
    }

    private static void PrepareIntercomReferenceIDFields(IntercomReferenceID value)
    {
    }

    private static void WriteIntercomReferenceID(ref DisBinaryWriter writer, IntercomReferenceID value)
    {
        WriteIntercomReferenceIDFields(ref writer, value);
    }

    private static void WriteIntercomReferenceIDFields(ref DisBinaryWriter writer, IntercomReferenceID value)
    {
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        writer.WriteUInt16(value.ReferenceNumber, "referenceNumber");
    }

    private static void MeasureIntercomReferenceID(in IntercomReferenceID value, ref int offset)
    {
        MeasureIntercomReferenceIDFields(value, ref offset);
    }

    private static void MeasureIntercomReferenceIDFields(in IntercomReferenceID value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static void ReadIntercomSignalPduFields(ref DisBinaryReader reader, IntercomSignalPdu value)
    {
        value.IntercomReferenceId = ReadIntercomReferenceID(ref reader);
        value.IntercomNumber = reader.ReadUInt16("intercomNumber");
        value.EncodingScheme = reader.ReadUInt16("encodingScheme");
        value.TdlType = (SignalTdlType)reader.ReadUInt16("tdlType");
        value.SampleRate = reader.ReadUInt32("sampleRate");
        value.DataBitLength = reader.ReadUInt16("dataBitLength");
        value.SampleCount = reader.ReadUInt16("samples");
        int DataCount = CheckedCount((checked((int)value.DataBitLength) + 7) / 8, reader.Remaining, "data");
        value.Data = new byte[DataCount];
        for (int index = 0; index < DataCount; index++)
            value.Data[index] = reader.ReadByte("data");
        reader.Skip(Padding(reader.Offset, 4), "padTo32");
    }

    private static void PrepareIntercomSignalPduFields(IntercomSignalPdu value)
    {
        if (value.DataBitLength == 0 && value.Data.Length != 0)
            value.DataBitLength = checked((ushort)(value.Data.Length * 8));
        if ((value.DataBitLength + 7) / 8 != value.Data.Length)
            throw new ArgumentException("DataBitLength must match Data, allowing only unused bits in the final octet.", nameof(value));
        ArgumentNullException.ThrowIfNull(value.IntercomReferenceId);
        PrepareIntercomReferenceID(value.IntercomReferenceId);
        ArgumentNullException.ThrowIfNull(value.Data);
    }

    private static void WriteIntercomSignalPduFields(ref DisBinaryWriter writer, IntercomSignalPdu value)
    {
        WriteIntercomReferenceID(ref writer, value.IntercomReferenceId);
        writer.WriteUInt16(value.IntercomNumber, "intercomNumber");
        writer.WriteUInt16(value.EncodingScheme, "encodingScheme");
        writer.WriteUInt16((ushort)value.TdlType, "tdlType");
        writer.WriteUInt32(value.SampleRate, "sampleRate");
        writer.WriteUInt16(value.DataBitLength, "dataBitLength");
        writer.WriteUInt16(value.SampleCount, "samples");
        foreach (byte item in value.Data) writer.WriteByte(item, "data");
        writer.WriteZeros(Padding(writer.Offset, 4), "padTo32");
    }

    private static void MeasureIntercomSignalPduFields(in IntercomSignalPdu value, ref int offset)
    {
        MeasureIntercomReferenceID(value.IntercomReferenceId, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 2;
        offset += 2;
        offset += checked(value.Data.Length * 1);
        offset += Padding(offset, 4);
    }

    private static void ReadIsGroupOfPduFields(ref DisBinaryReader reader, IsGroupOfPdu value)
    {
        value.GroupEntityId = ReadEntityId(ref reader);
        value.GroupedEntityCategory = (IsGroupOfGroupedEntityCategory)reader.ReadByte("groupedEntityCategory");
        value.NumberOfGroupedEntities = reader.ReadByte("numberOfGroupedEntities");
        value.Pad = reader.ReadUInt32("pad");
        value.Latitude = reader.ReadDouble("latitude");
        value.Longitude = reader.ReadDouble("longitude");
        int GroupedEntityDescriptionsCount = CheckedCount(checked((int)value.NumberOfGroupedEntities), reader.Remaining, "groupedEntityDescriptions");
        value.GroupedEntityDescriptions = new List<VariableDatum>(GroupedEntityDescriptionsCount);
        for (int index = 0; index < GroupedEntityDescriptionsCount; index++)
            value.GroupedEntityDescriptions.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareIsGroupOfPduFields(IsGroupOfPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.GroupEntityId);
        PrepareEntityId(value.GroupEntityId);
        ArgumentNullException.ThrowIfNull(value.GroupedEntityDescriptions);
        foreach (VariableDatum item in value.GroupedEntityDescriptions) PrepareVariableDatum(item);
        value.NumberOfGroupedEntities = checked((byte)value.GroupedEntityDescriptions.Count);
    }

    private static void WriteIsGroupOfPduFields(ref DisBinaryWriter writer, IsGroupOfPdu value)
    {
        WriteEntityId(ref writer, value.GroupEntityId);
        writer.WriteByte((byte)value.GroupedEntityCategory, "groupedEntityCategory");
        writer.WriteByte(value.NumberOfGroupedEntities, "numberOfGroupedEntities");
        writer.WriteUInt32(value.Pad, "pad");
        writer.WriteDouble(value.Latitude, "latitude");
        writer.WriteDouble(value.Longitude, "longitude");
        foreach (VariableDatum item in value.GroupedEntityDescriptions) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureIsGroupOfPduFields(in IsGroupOfPdu value, ref int offset)
    {
        MeasureEntityId(value.GroupEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 8;
        offset += 8;
        foreach (VariableDatum item in value.GroupedEntityDescriptions) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadIsPartOfPduFields(ref DisBinaryReader reader, IsPartOfPdu value)
    {
        value.OrginatingEntityId = ReadEntityId(ref reader);
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.Relationship = ReadRelationship(ref reader);
        value.PartLocation = ReadVector3Float(ref reader);
        value.NamedLocationId = ReadNamedLocationIdentification(ref reader);
        value.PartEntityType = ReadEntityType(ref reader);
    }

    private static void PrepareIsPartOfPduFields(IsPartOfPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OrginatingEntityId);
        PrepareEntityId(value.OrginatingEntityId);
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.Relationship);
        PrepareRelationship(value.Relationship);
        ArgumentNullException.ThrowIfNull(value.PartLocation);
        PrepareVector3Float(value.PartLocation);
        ArgumentNullException.ThrowIfNull(value.NamedLocationId);
        PrepareNamedLocationIdentification(value.NamedLocationId);
        ArgumentNullException.ThrowIfNull(value.PartEntityType);
        PrepareEntityType(value.PartEntityType);
    }

    private static void WriteIsPartOfPduFields(ref DisBinaryWriter writer, IsPartOfPdu value)
    {
        WriteEntityId(ref writer, value.OrginatingEntityId);
        WriteEntityId(ref writer, value.ReceivingEntityId);
        WriteRelationship(ref writer, value.Relationship);
        WriteVector3Float(ref writer, value.PartLocation);
        WriteNamedLocationIdentification(ref writer, value.NamedLocationId);
        WriteEntityType(ref writer, value.PartEntityType);
    }

    private static void MeasureIsPartOfPduFields(in IsPartOfPdu value, ref int offset)
    {
        MeasureEntityId(value.OrginatingEntityId, ref offset);
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        MeasureRelationship(value.Relationship, ref offset);
        MeasureVector3Float(value.PartLocation, ref offset);
        MeasureNamedLocationIdentification(value.NamedLocationId, ref offset);
        MeasureEntityType(value.PartEntityType, ref offset);
    }

    private static JammingTechnique ReadJammingTechnique(ref DisBinaryReader reader)
    {
        var value = new JammingTechnique();
        ReadJammingTechniqueFields(ref reader, value);
        return value;
    }

    private static void ReadJammingTechniqueFields(ref DisBinaryReader reader, JammingTechnique value)
    {
        value.Kind = reader.ReadByte("kind");
        value.Category = reader.ReadByte("category");
        value.SubCategory = reader.ReadByte("subCategory");
        value.Specific = reader.ReadByte("specific");
    }

    private static void PrepareJammingTechnique(JammingTechnique value)
    {
        PrepareJammingTechniqueFields(value);
    }

    private static void PrepareJammingTechniqueFields(JammingTechnique value)
    {
    }

    private static void WriteJammingTechnique(ref DisBinaryWriter writer, JammingTechnique value)
    {
        WriteJammingTechniqueFields(ref writer, value);
    }

    private static void WriteJammingTechniqueFields(ref DisBinaryWriter writer, JammingTechnique value)
    {
        writer.WriteByte(value.Kind, "kind");
        writer.WriteByte(value.Category, "category");
        writer.WriteByte(value.SubCategory, "subCategory");
        writer.WriteByte(value.Specific, "specific");
    }

    private static void MeasureJammingTechnique(in JammingTechnique value, ref int offset)
    {
        MeasureJammingTechniqueFields(value, ref offset);
    }

    private static void MeasureJammingTechniqueFields(in JammingTechnique value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static LEVector3FixedByte ReadLEVector3FixedByte(ref DisBinaryReader reader)
    {
        var value = new LEVector3FixedByte();
        ReadLEVector3FixedByteFields(ref reader, value);
        return value;
    }

    private static void ReadLEVector3FixedByteFields(ref DisBinaryReader reader, LEVector3FixedByte value)
    {
        value.X = reader.ReadByte("x");
        value.Y = reader.ReadByte("y");
        value.Z = reader.ReadByte("z");
    }

    private static void PrepareLEVector3FixedByte(LEVector3FixedByte value)
    {
        PrepareLEVector3FixedByteFields(value);
    }

    private static void PrepareLEVector3FixedByteFields(LEVector3FixedByte value)
    {
    }

    private static void WriteLEVector3FixedByte(ref DisBinaryWriter writer, LEVector3FixedByte value)
    {
        WriteLEVector3FixedByteFields(ref writer, value);
    }

    private static void WriteLEVector3FixedByteFields(ref DisBinaryWriter writer, LEVector3FixedByte value)
    {
        writer.WriteByte(value.X, "x");
        writer.WriteByte(value.Y, "y");
        writer.WriteByte(value.Z, "z");
    }

    private static void MeasureLEVector3FixedByte(in LEVector3FixedByte value, ref int offset)
    {
        MeasureLEVector3FixedByteFields(value, ref offset);
    }

    private static void MeasureLEVector3FixedByteFields(in LEVector3FixedByte value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static LaunchedMunitionRecord ReadLaunchedMunitionRecord(ref DisBinaryReader reader)
    {
        var value = new LaunchedMunitionRecord();
        ReadLaunchedMunitionRecordFields(ref reader, value);
        return value;
    }

    private static void ReadLaunchedMunitionRecordFields(ref DisBinaryReader reader, LaunchedMunitionRecord value)
    {
        value.FireEventId = ReadEventIdentifier(ref reader);
        value.Padding = reader.ReadUInt16("padding");
        value.FiringEntityId = ReadEntityId(ref reader);
        value.Padding2 = reader.ReadUInt16("padding2");
        value.TargetEntityId = ReadEntityId(ref reader);
        value.Padding3 = reader.ReadUInt16("padding3");
        value.TargetLocation = ReadVector3Double(ref reader);
    }

    private static void PrepareLaunchedMunitionRecord(LaunchedMunitionRecord value)
    {
        PrepareLaunchedMunitionRecordFields(value);
    }

    private static void PrepareLaunchedMunitionRecordFields(LaunchedMunitionRecord value)
    {
        ArgumentNullException.ThrowIfNull(value.FireEventId);
        PrepareEventIdentifier(value.FireEventId);
        ArgumentNullException.ThrowIfNull(value.FiringEntityId);
        PrepareEntityId(value.FiringEntityId);
        ArgumentNullException.ThrowIfNull(value.TargetEntityId);
        PrepareEntityId(value.TargetEntityId);
        ArgumentNullException.ThrowIfNull(value.TargetLocation);
        PrepareVector3Double(value.TargetLocation);
    }

    private static void WriteLaunchedMunitionRecord(ref DisBinaryWriter writer, LaunchedMunitionRecord value)
    {
        WriteLaunchedMunitionRecordFields(ref writer, value);
    }

    private static void WriteLaunchedMunitionRecordFields(ref DisBinaryWriter writer, LaunchedMunitionRecord value)
    {
        WriteEventIdentifier(ref writer, value.FireEventId);
        writer.WriteUInt16(value.Padding, "padding");
        WriteEntityId(ref writer, value.FiringEntityId);
        writer.WriteUInt16(value.Padding2, "padding2");
        WriteEntityId(ref writer, value.TargetEntityId);
        writer.WriteUInt16(value.Padding3, "padding3");
        WriteVector3Double(ref writer, value.TargetLocation);
    }

    private static void MeasureLaunchedMunitionRecord(in LaunchedMunitionRecord value, ref int offset)
    {
        MeasureLaunchedMunitionRecordFields(value, ref offset);
    }

    private static void MeasureLaunchedMunitionRecordFields(in LaunchedMunitionRecord value, ref int offset)
    {
        MeasureEventIdentifier(value.FireEventId, ref offset);
        offset += 2;
        MeasureEntityId(value.FiringEntityId, ref offset);
        offset += 2;
        MeasureEntityId(value.TargetEntityId, ref offset);
        offset += 2;
        MeasureVector3Double(value.TargetLocation, ref offset);
    }

    private static LayerHeader ReadLayerHeader(ref DisBinaryReader reader)
    {
        var value = new LayerHeader();
        ReadLayerHeaderFields(ref reader, value);
        return value;
    }

    private static void ReadLayerHeaderFields(ref DisBinaryReader reader, LayerHeader value)
    {
        value.LayerNumber = reader.ReadByte("layerNumber");
        value.LayerSpecificInformation = reader.ReadByte("layerSpecificInformation");
        value.Length = reader.ReadUInt16("length");
    }

    private static void PrepareLayerHeader(LayerHeader value)
    {
        PrepareLayerHeaderFields(value);
    }

    private static void PrepareLayerHeaderFields(LayerHeader value)
    {
    }

    private static void WriteLayerHeader(ref DisBinaryWriter writer, LayerHeader value)
    {
        WriteLayerHeaderFields(ref writer, value);
    }

    private static void WriteLayerHeaderFields(ref DisBinaryWriter writer, LayerHeader value)
    {
        writer.WriteByte(value.LayerNumber, "layerNumber");
        writer.WriteByte(value.LayerSpecificInformation, "layerSpecificInformation");
        writer.WriteUInt16(value.Length, "length");
    }

    private static void MeasureLayerHeader(in LayerHeader value, ref int offset)
    {
        MeasureLayerHeaderFields(value, ref offset);
    }

    private static void MeasureLayerHeaderFields(in LayerHeader value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
    }

    private static void ReadLinearObjectStatePduFields(ref DisBinaryReader reader, LinearObjectStatePdu value)
    {
        value.ObjectId = ReadObjectIdentifier(ref reader);
        value.ReferencedObjectId = ReadObjectIdentifier(ref reader);
        value.UpdateNumber = reader.ReadUInt16("updateNumber");
        value.ForceId = (ForceId)reader.ReadByte("forceID");
        value.NumberOfLinearSegments = reader.ReadByte("numberOfLinearSegments");
        value.RequesterId = ReadSimulationAddress(ref reader);
        value.ReceivingId = ReadSimulationAddress(ref reader);
        value.ObjectType = ReadObjectType(ref reader);
        int LinearSegmentParametersCount = CheckedCount(checked((int)value.NumberOfLinearSegments), reader.Remaining, "linearSegmentParameters");
        value.LinearSegmentParameters = new List<LinearSegmentParameter>(LinearSegmentParametersCount);
        for (int index = 0; index < LinearSegmentParametersCount; index++)
            value.LinearSegmentParameters.Add(ReadLinearSegmentParameter(ref reader));
    }

    private static void PrepareLinearObjectStatePduFields(LinearObjectStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ObjectId);
        PrepareObjectIdentifier(value.ObjectId);
        ArgumentNullException.ThrowIfNull(value.ReferencedObjectId);
        PrepareObjectIdentifier(value.ReferencedObjectId);
        ArgumentNullException.ThrowIfNull(value.RequesterId);
        PrepareSimulationAddress(value.RequesterId);
        ArgumentNullException.ThrowIfNull(value.ReceivingId);
        PrepareSimulationAddress(value.ReceivingId);
        ArgumentNullException.ThrowIfNull(value.ObjectType);
        PrepareObjectType(value.ObjectType);
        ArgumentNullException.ThrowIfNull(value.LinearSegmentParameters);
        foreach (LinearSegmentParameter item in value.LinearSegmentParameters) PrepareLinearSegmentParameter(item);
        value.NumberOfLinearSegments = checked((byte)value.LinearSegmentParameters.Count);
    }

    private static void WriteLinearObjectStatePduFields(ref DisBinaryWriter writer, LinearObjectStatePdu value)
    {
        WriteObjectIdentifier(ref writer, value.ObjectId);
        WriteObjectIdentifier(ref writer, value.ReferencedObjectId);
        writer.WriteUInt16(value.UpdateNumber, "updateNumber");
        writer.WriteByte((byte)value.ForceId, "forceID");
        writer.WriteByte(value.NumberOfLinearSegments, "numberOfLinearSegments");
        WriteSimulationAddress(ref writer, value.RequesterId);
        WriteSimulationAddress(ref writer, value.ReceivingId);
        WriteObjectType(ref writer, value.ObjectType);
        foreach (LinearSegmentParameter item in value.LinearSegmentParameters) WriteLinearSegmentParameter(ref writer, item);
    }

    private static void MeasureLinearObjectStatePduFields(in LinearObjectStatePdu value, ref int offset)
    {
        MeasureObjectIdentifier(value.ObjectId, ref offset);
        MeasureObjectIdentifier(value.ReferencedObjectId, ref offset);
        offset += 2;
        offset += 1;
        offset += 1;
        MeasureSimulationAddress(value.RequesterId, ref offset);
        MeasureSimulationAddress(value.ReceivingId, ref offset);
        MeasureObjectType(value.ObjectType, ref offset);
        foreach (LinearSegmentParameter item in value.LinearSegmentParameters) MeasureLinearSegmentParameter(item, ref offset);
    }

    private static LinearSegmentParameter ReadLinearSegmentParameter(ref DisBinaryReader reader)
    {
        var value = new LinearSegmentParameter();
        ReadLinearSegmentParameterFields(ref reader, value);
        return value;
    }

    private static void ReadLinearSegmentParameterFields(ref DisBinaryReader reader, LinearSegmentParameter value)
    {
        value.SegmentNumber = reader.ReadByte("segmentNumber");
        value.SegmentModification = new ObjectStateModificationLinearObject(reader.ReadUInt16("segmentModification"));
        value.GeneralSegmentAppearance = new ObjectStateAppearanceGeneral(reader.ReadUInt16("generalSegmentAppearance"));
        value.SpecificSegmentAppearance = reader.ReadUInt32("specificSegmentAppearance");
        value.SegmentLocation = ReadVector3Double(ref reader);
        value.SegmentOrientation = ReadEulerAngles(ref reader);
        value.SegmentLength = reader.ReadSingle("segmentLength");
        value.SegmentWidth = reader.ReadSingle("segmentWidth");
        value.SegmentHeight = reader.ReadSingle("segmentHeight");
        value.SegmentDepth = reader.ReadSingle("segmentDepth");
        value.Padding = reader.ReadUInt32("padding");
    }

    private static void PrepareLinearSegmentParameter(LinearSegmentParameter value)
    {
        PrepareLinearSegmentParameterFields(value);
    }

    private static void PrepareLinearSegmentParameterFields(LinearSegmentParameter value)
    {
        ArgumentNullException.ThrowIfNull(value.SegmentLocation);
        PrepareVector3Double(value.SegmentLocation);
        ArgumentNullException.ThrowIfNull(value.SegmentOrientation);
        PrepareEulerAngles(value.SegmentOrientation);
    }

    private static void WriteLinearSegmentParameter(ref DisBinaryWriter writer, LinearSegmentParameter value)
    {
        WriteLinearSegmentParameterFields(ref writer, value);
    }

    private static void WriteLinearSegmentParameterFields(ref DisBinaryWriter writer, LinearSegmentParameter value)
    {
        writer.WriteByte(value.SegmentNumber, "segmentNumber");
        writer.WriteUInt16(value.SegmentModification.Value, "segmentModification");
        writer.WriteUInt16(value.GeneralSegmentAppearance.Value, "generalSegmentAppearance");
        writer.WriteUInt32(value.SpecificSegmentAppearance, "specificSegmentAppearance");
        WriteVector3Double(ref writer, value.SegmentLocation);
        WriteEulerAngles(ref writer, value.SegmentOrientation);
        writer.WriteSingle(value.SegmentLength, "segmentLength");
        writer.WriteSingle(value.SegmentWidth, "segmentWidth");
        writer.WriteSingle(value.SegmentHeight, "segmentHeight");
        writer.WriteSingle(value.SegmentDepth, "segmentDepth");
        writer.WriteUInt32(value.Padding, "padding");
    }

    private static void MeasureLinearSegmentParameter(in LinearSegmentParameter value, ref int offset)
    {
        MeasureLinearSegmentParameterFields(value, ref offset);
    }

    private static void MeasureLinearSegmentParameterFields(in LinearSegmentParameter value, ref int offset)
    {
        offset += 1;
        offset += 2;
        offset += 2;
        offset += 4;
        MeasureVector3Double(value.SegmentLocation, ref offset);
        MeasureEulerAngles(value.SegmentOrientation, ref offset);
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static LiveDeadReckoningParameters ReadLiveDeadReckoningParameters(ref DisBinaryReader reader)
    {
        var value = new LiveDeadReckoningParameters();
        ReadLiveDeadReckoningParametersFields(ref reader, value);
        return value;
    }

    private static void ReadLiveDeadReckoningParametersFields(ref DisBinaryReader reader, LiveDeadReckoningParameters value)
    {
        value.DeadReckoningAlgorithm = (DeadReckoningAlgorithm)reader.ReadByte("deadReckoningAlgorithm");
        value.EntityLinearAcceleration = ReadLEVector3FixedByte(ref reader);
        value.EntityAngularVelocity = ReadLEVector3FixedByte(ref reader);
    }

    private static void PrepareLiveDeadReckoningParameters(LiveDeadReckoningParameters value)
    {
        PrepareLiveDeadReckoningParametersFields(value);
    }

    private static void PrepareLiveDeadReckoningParametersFields(LiveDeadReckoningParameters value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityLinearAcceleration);
        PrepareLEVector3FixedByte(value.EntityLinearAcceleration);
        ArgumentNullException.ThrowIfNull(value.EntityAngularVelocity);
        PrepareLEVector3FixedByte(value.EntityAngularVelocity);
    }

    private static void WriteLiveDeadReckoningParameters(ref DisBinaryWriter writer, LiveDeadReckoningParameters value)
    {
        WriteLiveDeadReckoningParametersFields(ref writer, value);
    }

    private static void WriteLiveDeadReckoningParametersFields(ref DisBinaryWriter writer, LiveDeadReckoningParameters value)
    {
        writer.WriteByte((byte)value.DeadReckoningAlgorithm, "deadReckoningAlgorithm");
        WriteLEVector3FixedByte(ref writer, value.EntityLinearAcceleration);
        WriteLEVector3FixedByte(ref writer, value.EntityAngularVelocity);
    }

    private static void MeasureLiveDeadReckoningParameters(in LiveDeadReckoningParameters value, ref int offset)
    {
        MeasureLiveDeadReckoningParametersFields(value, ref offset);
    }

    private static void MeasureLiveDeadReckoningParametersFields(in LiveDeadReckoningParameters value, ref int offset)
    {
        offset += 1;
        MeasureLEVector3FixedByte(value.EntityLinearAcceleration, ref offset);
        MeasureLEVector3FixedByte(value.EntityAngularVelocity, ref offset);
    }

    private static void ReadLiveEntityDetonationPduFields(ref DisBinaryReader reader, LiveEntityDetonationPdu value)
    {
        value.FiringLiveEntityId = ReadEntityId(ref reader);
        value.DetonationFlag1 = reader.ReadByte("detonationFlag1");
        value.DetonationFlag2 = reader.ReadByte("detonationFlag2");
        value.TargetLiveEntityId = ReadEntityId(ref reader);
        value.MunitionLiveEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.WorldLocation = ReadLiveEntityRelativeWorldCoordinates(ref reader);
        value.Velocity = ReadLiveEntityLinearVelocity(ref reader);
        value.MunitionOrientation = ReadLiveEntityOrientation16(ref reader);
        value.MunitionDescriptor = ReadMunitionDescriptor(ref reader);
        value.EntityLocation = ReadLiveEntityLinearVelocity(ref reader);
        value.DetonationResult = reader.ReadByte("detonationResult");
    }

    private static void PrepareLiveEntityDetonationPduFields(LiveEntityDetonationPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FiringLiveEntityId);
        PrepareEntityId(value.FiringLiveEntityId);
        ArgumentNullException.ThrowIfNull(value.TargetLiveEntityId);
        PrepareEntityId(value.TargetLiveEntityId);
        ArgumentNullException.ThrowIfNull(value.MunitionLiveEntityId);
        PrepareEntityId(value.MunitionLiveEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.WorldLocation);
        PrepareLiveEntityRelativeWorldCoordinates(value.WorldLocation);
        ArgumentNullException.ThrowIfNull(value.Velocity);
        PrepareLiveEntityLinearVelocity(value.Velocity);
        ArgumentNullException.ThrowIfNull(value.MunitionOrientation);
        PrepareLiveEntityOrientation16(value.MunitionOrientation);
        ArgumentNullException.ThrowIfNull(value.MunitionDescriptor);
        PrepareMunitionDescriptor(value.MunitionDescriptor);
        ArgumentNullException.ThrowIfNull(value.EntityLocation);
        PrepareLiveEntityLinearVelocity(value.EntityLocation);
    }

    private static void WriteLiveEntityDetonationPduFields(ref DisBinaryWriter writer, LiveEntityDetonationPdu value)
    {
        WriteEntityId(ref writer, value.FiringLiveEntityId);
        writer.WriteByte(value.DetonationFlag1, "detonationFlag1");
        writer.WriteByte(value.DetonationFlag2, "detonationFlag2");
        WriteEntityId(ref writer, value.TargetLiveEntityId);
        WriteEntityId(ref writer, value.MunitionLiveEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        WriteLiveEntityRelativeWorldCoordinates(ref writer, value.WorldLocation);
        WriteLiveEntityLinearVelocity(ref writer, value.Velocity);
        WriteLiveEntityOrientation16(ref writer, value.MunitionOrientation);
        WriteMunitionDescriptor(ref writer, value.MunitionDescriptor);
        WriteLiveEntityLinearVelocity(ref writer, value.EntityLocation);
        writer.WriteByte(value.DetonationResult, "detonationResult");
    }

    private static void MeasureLiveEntityDetonationPduFields(in LiveEntityDetonationPdu value, ref int offset)
    {
        MeasureEntityId(value.FiringLiveEntityId, ref offset);
        offset += 1;
        offset += 1;
        MeasureEntityId(value.TargetLiveEntityId, ref offset);
        MeasureEntityId(value.MunitionLiveEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        MeasureLiveEntityRelativeWorldCoordinates(value.WorldLocation, ref offset);
        MeasureLiveEntityLinearVelocity(value.Velocity, ref offset);
        MeasureLiveEntityOrientation16(value.MunitionOrientation, ref offset);
        MeasureMunitionDescriptor(value.MunitionDescriptor, ref offset);
        MeasureLiveEntityLinearVelocity(value.EntityLocation, ref offset);
        offset += 1;
    }

    private static void ReadLiveEntityFamilyPduFields(ref DisBinaryReader reader, LiveEntityFamilyPdu value)
    {
    }

    private static void PrepareLiveEntityFamilyPduFields(LiveEntityFamilyPdu value)
    {
    }

    private static void WriteLiveEntityFamilyPduFields(ref DisBinaryWriter writer, LiveEntityFamilyPdu value)
    {
    }

    private static void MeasureLiveEntityFamilyPduFields(in LiveEntityFamilyPdu value, ref int offset)
    {
    }

    private static void ReadLiveEntityFirePduFields(ref DisBinaryReader reader, LiveEntityFirePdu value)
    {
        value.FiringLiveEntityId = ReadEntityId(ref reader);
        value.Flags = reader.ReadByte("flags");
        value.TargetLiveEntityId = ReadEntityId(ref reader);
        value.MunitionLiveEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.Location = ReadLiveEntityRelativeWorldCoordinates(ref reader);
        value.MunitionDescriptor = ReadMunitionDescriptor(ref reader);
        value.Velocity = ReadLiveEntityLinearVelocity(ref reader);
        value.Range = reader.ReadUInt16("range");
    }

    private static void PrepareLiveEntityFirePduFields(LiveEntityFirePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FiringLiveEntityId);
        PrepareEntityId(value.FiringLiveEntityId);
        ArgumentNullException.ThrowIfNull(value.TargetLiveEntityId);
        PrepareEntityId(value.TargetLiveEntityId);
        ArgumentNullException.ThrowIfNull(value.MunitionLiveEntityId);
        PrepareEntityId(value.MunitionLiveEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.Location);
        PrepareLiveEntityRelativeWorldCoordinates(value.Location);
        ArgumentNullException.ThrowIfNull(value.MunitionDescriptor);
        PrepareMunitionDescriptor(value.MunitionDescriptor);
        ArgumentNullException.ThrowIfNull(value.Velocity);
        PrepareLiveEntityLinearVelocity(value.Velocity);
    }

    private static void WriteLiveEntityFirePduFields(ref DisBinaryWriter writer, LiveEntityFirePdu value)
    {
        WriteEntityId(ref writer, value.FiringLiveEntityId);
        writer.WriteByte(value.Flags, "flags");
        WriteEntityId(ref writer, value.TargetLiveEntityId);
        WriteEntityId(ref writer, value.MunitionLiveEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        WriteLiveEntityRelativeWorldCoordinates(ref writer, value.Location);
        WriteMunitionDescriptor(ref writer, value.MunitionDescriptor);
        WriteLiveEntityLinearVelocity(ref writer, value.Velocity);
        writer.WriteUInt16(value.Range, "range");
    }

    private static void MeasureLiveEntityFirePduFields(in LiveEntityFirePdu value, ref int offset)
    {
        MeasureEntityId(value.FiringLiveEntityId, ref offset);
        offset += 1;
        MeasureEntityId(value.TargetLiveEntityId, ref offset);
        MeasureEntityId(value.MunitionLiveEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        MeasureLiveEntityRelativeWorldCoordinates(value.Location, ref offset);
        MeasureMunitionDescriptor(value.MunitionDescriptor, ref offset);
        MeasureLiveEntityLinearVelocity(value.Velocity, ref offset);
        offset += 2;
    }

    private static LiveEntityIdentifier ReadLiveEntityIdentifier(ref DisBinaryReader reader)
    {
        var value = new LiveEntityIdentifier();
        ReadLiveEntityIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityIdentifierFields(ref DisBinaryReader reader, LiveEntityIdentifier value)
    {
        value.LiveSimulationAddress = ReadLiveSimulationAddress(ref reader);
        value.EntityNumber = reader.ReadUInt16("entityNumber");
    }

    private static void PrepareLiveEntityIdentifier(LiveEntityIdentifier value)
    {
        PrepareLiveEntityIdentifierFields(value);
    }

    private static void PrepareLiveEntityIdentifierFields(LiveEntityIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.LiveSimulationAddress);
        PrepareLiveSimulationAddress(value.LiveSimulationAddress);
    }

    private static void WriteLiveEntityIdentifier(ref DisBinaryWriter writer, LiveEntityIdentifier value)
    {
        WriteLiveEntityIdentifierFields(ref writer, value);
    }

    private static void WriteLiveEntityIdentifierFields(ref DisBinaryWriter writer, LiveEntityIdentifier value)
    {
        WriteLiveSimulationAddress(ref writer, value.LiveSimulationAddress);
        writer.WriteUInt16(value.EntityNumber, "entityNumber");
    }

    private static void MeasureLiveEntityIdentifier(in LiveEntityIdentifier value, ref int offset)
    {
        MeasureLiveEntityIdentifierFields(value, ref offset);
    }

    private static void MeasureLiveEntityIdentifierFields(in LiveEntityIdentifier value, ref int offset)
    {
        MeasureLiveSimulationAddress(value.LiveSimulationAddress, ref offset);
        offset += 2;
    }

    private static LiveEntityLinearVelocity ReadLiveEntityLinearVelocity(ref DisBinaryReader reader)
    {
        var value = new LiveEntityLinearVelocity();
        ReadLiveEntityLinearVelocityFields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityLinearVelocityFields(ref DisBinaryReader reader, LiveEntityLinearVelocity value)
    {
        value.XComponent = reader.ReadUInt16("xComponent");
        value.YComponent = reader.ReadUInt16("yComponent");
        value.ZComponent = reader.ReadUInt16("zComponent");
    }

    private static void PrepareLiveEntityLinearVelocity(LiveEntityLinearVelocity value)
    {
        PrepareLiveEntityLinearVelocityFields(value);
    }

    private static void PrepareLiveEntityLinearVelocityFields(LiveEntityLinearVelocity value)
    {
    }

    private static void WriteLiveEntityLinearVelocity(ref DisBinaryWriter writer, LiveEntityLinearVelocity value)
    {
        WriteLiveEntityLinearVelocityFields(ref writer, value);
    }

    private static void WriteLiveEntityLinearVelocityFields(ref DisBinaryWriter writer, LiveEntityLinearVelocity value)
    {
        writer.WriteUInt16(value.XComponent, "xComponent");
        writer.WriteUInt16(value.YComponent, "yComponent");
        writer.WriteUInt16(value.ZComponent, "zComponent");
    }

    private static void MeasureLiveEntityLinearVelocity(in LiveEntityLinearVelocity value, ref int offset)
    {
        MeasureLiveEntityLinearVelocityFields(value, ref offset);
    }

    private static void MeasureLiveEntityLinearVelocityFields(in LiveEntityLinearVelocity value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static LiveEntityOrientation ReadLiveEntityOrientation(ref DisBinaryReader reader)
    {
        var value = new LiveEntityOrientation();
        ReadLiveEntityOrientationFields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityOrientationFields(ref DisBinaryReader reader, LiveEntityOrientation value)
    {
        value.Psi = reader.ReadByte("psi");
        value.Theta = reader.ReadByte("theta");
        value.Phi = reader.ReadByte("phi");
    }

    private static void PrepareLiveEntityOrientation(LiveEntityOrientation value)
    {
        PrepareLiveEntityOrientationFields(value);
    }

    private static void PrepareLiveEntityOrientationFields(LiveEntityOrientation value)
    {
    }

    private static void WriteLiveEntityOrientation(ref DisBinaryWriter writer, LiveEntityOrientation value)
    {
        WriteLiveEntityOrientationFields(ref writer, value);
    }

    private static void WriteLiveEntityOrientationFields(ref DisBinaryWriter writer, LiveEntityOrientation value)
    {
        writer.WriteByte(value.Psi, "psi");
        writer.WriteByte(value.Theta, "theta");
        writer.WriteByte(value.Phi, "phi");
    }

    private static void MeasureLiveEntityOrientation(in LiveEntityOrientation value, ref int offset)
    {
        MeasureLiveEntityOrientationFields(value, ref offset);
    }

    private static void MeasureLiveEntityOrientationFields(in LiveEntityOrientation value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static LiveEntityOrientation16 ReadLiveEntityOrientation16(ref DisBinaryReader reader)
    {
        var value = new LiveEntityOrientation16();
        ReadLiveEntityOrientation16Fields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityOrientation16Fields(ref DisBinaryReader reader, LiveEntityOrientation16 value)
    {
        value.Psi = reader.ReadUInt16("psi");
        value.Theta = reader.ReadUInt16("theta");
        value.Phi = reader.ReadUInt16("phi");
    }

    private static void PrepareLiveEntityOrientation16(LiveEntityOrientation16 value)
    {
        PrepareLiveEntityOrientation16Fields(value);
    }

    private static void PrepareLiveEntityOrientation16Fields(LiveEntityOrientation16 value)
    {
    }

    private static void WriteLiveEntityOrientation16(ref DisBinaryWriter writer, LiveEntityOrientation16 value)
    {
        WriteLiveEntityOrientation16Fields(ref writer, value);
    }

    private static void WriteLiveEntityOrientation16Fields(ref DisBinaryWriter writer, LiveEntityOrientation16 value)
    {
        writer.WriteUInt16(value.Psi, "psi");
        writer.WriteUInt16(value.Theta, "theta");
        writer.WriteUInt16(value.Phi, "phi");
    }

    private static void MeasureLiveEntityOrientation16(in LiveEntityOrientation16 value, ref int offset)
    {
        MeasureLiveEntityOrientation16Fields(value, ref offset);
    }

    private static void MeasureLiveEntityOrientation16Fields(in LiveEntityOrientation16 value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static LiveEntityOrientationError ReadLiveEntityOrientationError(ref DisBinaryReader reader)
    {
        var value = new LiveEntityOrientationError();
        ReadLiveEntityOrientationErrorFields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityOrientationErrorFields(ref DisBinaryReader reader, LiveEntityOrientationError value)
    {
        value.AzimuthError = reader.ReadUInt16("azimuthError");
        value.ElevationError = reader.ReadUInt16("elevationError");
        value.RotationError = reader.ReadUInt16("rotationError");
    }

    private static void PrepareLiveEntityOrientationError(LiveEntityOrientationError value)
    {
        PrepareLiveEntityOrientationErrorFields(value);
    }

    private static void PrepareLiveEntityOrientationErrorFields(LiveEntityOrientationError value)
    {
    }

    private static void WriteLiveEntityOrientationError(ref DisBinaryWriter writer, LiveEntityOrientationError value)
    {
        WriteLiveEntityOrientationErrorFields(ref writer, value);
    }

    private static void WriteLiveEntityOrientationErrorFields(ref DisBinaryWriter writer, LiveEntityOrientationError value)
    {
        writer.WriteUInt16(value.AzimuthError, "azimuthError");
        writer.WriteUInt16(value.ElevationError, "elevationError");
        writer.WriteUInt16(value.RotationError, "rotationError");
    }

    private static void MeasureLiveEntityOrientationError(in LiveEntityOrientationError value, ref int offset)
    {
        MeasureLiveEntityOrientationErrorFields(value, ref offset);
    }

    private static void MeasureLiveEntityOrientationErrorFields(in LiveEntityOrientationError value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static LiveEntityPositionError ReadLiveEntityPositionError(ref DisBinaryReader reader)
    {
        var value = new LiveEntityPositionError();
        ReadLiveEntityPositionErrorFields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityPositionErrorFields(ref DisBinaryReader reader, LiveEntityPositionError value)
    {
        value.HorizontalError = reader.ReadUInt16("horizontalError");
        value.VerticalError = reader.ReadUInt16("verticalError");
    }

    private static void PrepareLiveEntityPositionError(LiveEntityPositionError value)
    {
        PrepareLiveEntityPositionErrorFields(value);
    }

    private static void PrepareLiveEntityPositionErrorFields(LiveEntityPositionError value)
    {
    }

    private static void WriteLiveEntityPositionError(ref DisBinaryWriter writer, LiveEntityPositionError value)
    {
        WriteLiveEntityPositionErrorFields(ref writer, value);
    }

    private static void WriteLiveEntityPositionErrorFields(ref DisBinaryWriter writer, LiveEntityPositionError value)
    {
        writer.WriteUInt16(value.HorizontalError, "horizontalError");
        writer.WriteUInt16(value.VerticalError, "verticalError");
    }

    private static void MeasureLiveEntityPositionError(in LiveEntityPositionError value, ref int offset)
    {
        MeasureLiveEntityPositionErrorFields(value, ref offset);
    }

    private static void MeasureLiveEntityPositionErrorFields(in LiveEntityPositionError value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static LiveEntityRelativeWorldCoordinates ReadLiveEntityRelativeWorldCoordinates(ref DisBinaryReader reader)
    {
        var value = new LiveEntityRelativeWorldCoordinates();
        ReadLiveEntityRelativeWorldCoordinatesFields(ref reader, value);
        return value;
    }

    private static void ReadLiveEntityRelativeWorldCoordinatesFields(ref DisBinaryReader reader, LiveEntityRelativeWorldCoordinates value)
    {
        value.ReferencePoint = reader.ReadUInt16("referencePoint");
        value.DeltaX = reader.ReadUInt16("deltaX");
        value.DeltaY = reader.ReadUInt16("deltaY");
        value.DeltaZ = reader.ReadUInt16("deltaZ");
    }

    private static void PrepareLiveEntityRelativeWorldCoordinates(LiveEntityRelativeWorldCoordinates value)
    {
        PrepareLiveEntityRelativeWorldCoordinatesFields(value);
    }

    private static void PrepareLiveEntityRelativeWorldCoordinatesFields(LiveEntityRelativeWorldCoordinates value)
    {
    }

    private static void WriteLiveEntityRelativeWorldCoordinates(ref DisBinaryWriter writer, LiveEntityRelativeWorldCoordinates value)
    {
        WriteLiveEntityRelativeWorldCoordinatesFields(ref writer, value);
    }

    private static void WriteLiveEntityRelativeWorldCoordinatesFields(ref DisBinaryWriter writer, LiveEntityRelativeWorldCoordinates value)
    {
        writer.WriteUInt16(value.ReferencePoint, "referencePoint");
        writer.WriteUInt16(value.DeltaX, "deltaX");
        writer.WriteUInt16(value.DeltaY, "deltaY");
        writer.WriteUInt16(value.DeltaZ, "deltaZ");
    }

    private static void MeasureLiveEntityRelativeWorldCoordinates(in LiveEntityRelativeWorldCoordinates value, ref int offset)
    {
        MeasureLiveEntityRelativeWorldCoordinatesFields(value, ref offset);
    }

    private static void MeasureLiveEntityRelativeWorldCoordinatesFields(in LiveEntityRelativeWorldCoordinates value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static LiveSimulationAddress ReadLiveSimulationAddress(ref DisBinaryReader reader)
    {
        var value = new LiveSimulationAddress();
        ReadLiveSimulationAddressFields(ref reader, value);
        return value;
    }

    private static void ReadLiveSimulationAddressFields(ref DisBinaryReader reader, LiveSimulationAddress value)
    {
        value.LiveSiteNumber = reader.ReadByte("liveSiteNumber");
        value.LiveApplicationNumber = reader.ReadByte("liveApplicationNumber");
    }

    private static void PrepareLiveSimulationAddress(LiveSimulationAddress value)
    {
        PrepareLiveSimulationAddressFields(value);
    }

    private static void PrepareLiveSimulationAddressFields(LiveSimulationAddress value)
    {
    }

    private static void WriteLiveSimulationAddress(ref DisBinaryWriter writer, LiveSimulationAddress value)
    {
        WriteLiveSimulationAddressFields(ref writer, value);
    }

    private static void WriteLiveSimulationAddressFields(ref DisBinaryWriter writer, LiveSimulationAddress value)
    {
        writer.WriteByte(value.LiveSiteNumber, "liveSiteNumber");
        writer.WriteByte(value.LiveApplicationNumber, "liveApplicationNumber");
    }

    private static void MeasureLiveSimulationAddress(in LiveSimulationAddress value, ref int offset)
    {
        MeasureLiveSimulationAddressFields(value, ref offset);
    }

    private static void MeasureLiveSimulationAddressFields(in LiveSimulationAddress value, ref int offset)
    {
        offset += 1;
        offset += 1;
    }

    private static void ReadLogisticsFamilyPduFields(ref DisBinaryReader reader, LogisticsFamilyPdu value)
    {
    }

    private static void PrepareLogisticsFamilyPduFields(LogisticsFamilyPdu value)
    {
    }

    private static void WriteLogisticsFamilyPduFields(ref DisBinaryWriter writer, LogisticsFamilyPdu value)
    {
    }

    private static void MeasureLogisticsFamilyPduFields(in LogisticsFamilyPdu value, ref int offset)
    {
    }

    private static MineEmplacementTime ReadMineEmplacementTime(ref DisBinaryReader reader)
    {
        var value = new MineEmplacementTime();
        ReadMineEmplacementTimeFields(ref reader, value);
        return value;
    }

    private static void ReadMineEmplacementTimeFields(ref DisBinaryReader reader, MineEmplacementTime value)
    {
        value.Hour = reader.ReadUInt32("hour");
        value.TimePastTheHour = reader.ReadUInt32("timePastTheHour");
    }

    private static void PrepareMineEmplacementTime(MineEmplacementTime value)
    {
        PrepareMineEmplacementTimeFields(value);
    }

    private static void PrepareMineEmplacementTimeFields(MineEmplacementTime value)
    {
    }

    private static void WriteMineEmplacementTime(ref DisBinaryWriter writer, MineEmplacementTime value)
    {
        WriteMineEmplacementTimeFields(ref writer, value);
    }

    private static void WriteMineEmplacementTimeFields(ref DisBinaryWriter writer, MineEmplacementTime value)
    {
        writer.WriteUInt32(value.Hour, "hour");
        writer.WriteUInt32(value.TimePastTheHour, "timePastTheHour");
    }

    private static void MeasureMineEmplacementTime(in MineEmplacementTime value, ref int offset)
    {
        MeasureMineEmplacementTimeFields(value, ref offset);
    }

    private static void MeasureMineEmplacementTimeFields(in MineEmplacementTime value, ref int offset)
    {
        offset += 4;
        offset += 4;
    }

    private static MineEntityIdentifier ReadMineEntityIdentifier(ref DisBinaryReader reader)
    {
        var value = new MineEntityIdentifier();
        ReadMineEntityIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadMineEntityIdentifierFields(ref DisBinaryReader reader, MineEntityIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.MineEntityNumber = reader.ReadUInt16("mineEntityNumber");
    }

    private static void PrepareMineEntityIdentifier(MineEntityIdentifier value)
    {
        PrepareMineEntityIdentifierFields(value);
    }

    private static void PrepareMineEntityIdentifierFields(MineEntityIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteMineEntityIdentifier(ref DisBinaryWriter writer, MineEntityIdentifier value)
    {
        WriteMineEntityIdentifierFields(ref writer, value);
    }

    private static void WriteMineEntityIdentifierFields(ref DisBinaryWriter writer, MineEntityIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.MineEntityNumber, "mineEntityNumber");
    }

    private static void MeasureMineEntityIdentifier(in MineEntityIdentifier value, ref int offset)
    {
        MeasureMineEntityIdentifierFields(value, ref offset);
    }

    private static void MeasureMineEntityIdentifierFields(in MineEntityIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static void ReadMinefieldDataPduFields(ref DisBinaryReader reader, MinefieldDataPdu value)
    {
        value.MinefieldId = ReadMinefieldIdentifier(ref reader);
        value.RequestingEntityId = ReadSimulationIdentifier(ref reader);
        value.MinefieldSequenceNumber = reader.ReadUInt16("minefieldSequenceNumber");
        value.RequestId = reader.ReadByte("requestID");
        value.PduSequenceNumber = reader.ReadByte("pduSequenceNumber");
        value.NumberOfPdus = reader.ReadByte("numberOfPdus");
        value.NumberOfMinesInThisPdu = reader.ReadByte("numberOfMinesInThisPdu");
        value.NumberOfSensorTypes = reader.ReadByte("numberOfSensorTypes");
        value.Padding = reader.ReadByte("padding");
        value.DataFilter = ReadDataFilterRecord(ref reader);
        value.MineType = ReadEntityType(ref reader);
        int SensorTypesCount = CheckedCount(checked((int)value.NumberOfSensorTypes), reader.Remaining, "sensorTypes");
        value.SensorTypes = new List<MinefieldSensorType>(SensorTypesCount);
        for (int index = 0; index < SensorTypesCount; index++)
            value.SensorTypes.Add(ReadMinefieldSensorType(ref reader));
        reader.Skip(Padding(reader.Offset, 4), "padTo32");
        int MineLocationCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "mineLocation");
        value.MineLocation = new List<Vector3Float>(MineLocationCount);
        for (int index = 0; index < MineLocationCount; index++)
            value.MineLocation.Add(ReadVector3Float(ref reader));
        if ((value.DataFilter.BitFlags & (1u << 0)) != 0)
        {
            int GroundBurialDepthOffsetCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "groundBurialDepthOffset");
            value.GroundBurialDepthOffset = new float[GroundBurialDepthOffsetCount];
            for (int index = 0; index < GroundBurialDepthOffsetCount; index++)
                value.GroundBurialDepthOffset[index] = reader.ReadSingle("groundBurialDepthOffset");
        }
        if ((value.DataFilter.BitFlags & (1u << 1)) != 0)
        {
            int WaterBurialDepthOffsetCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "waterBurialDepthOffset");
            value.WaterBurialDepthOffset = new float[WaterBurialDepthOffsetCount];
            for (int index = 0; index < WaterBurialDepthOffsetCount; index++)
                value.WaterBurialDepthOffset[index] = reader.ReadSingle("waterBurialDepthOffset");
        }
        if ((value.DataFilter.BitFlags & (1u << 2)) != 0)
        {
            int SnowBurialDepthOffsetCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "snowBurialDepthOffset");
            value.SnowBurialDepthOffset = new float[SnowBurialDepthOffsetCount];
            for (int index = 0; index < SnowBurialDepthOffsetCount; index++)
                value.SnowBurialDepthOffset[index] = reader.ReadSingle("snowBurialDepthOffset");
        }
        if ((value.DataFilter.BitFlags & (1u << 3)) != 0)
        {
            int MineOrientationCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "mineOrientation");
            value.MineOrientation = new List<EulerAngles>(MineOrientationCount);
            for (int index = 0; index < MineOrientationCount; index++)
                value.MineOrientation.Add(ReadEulerAngles(ref reader));
        }
        if ((value.DataFilter.BitFlags & (1u << 4)) != 0)
        {
            int ThermalContrastCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "thermalContrast");
            value.ThermalContrast = new float[ThermalContrastCount];
            for (int index = 0; index < ThermalContrastCount; index++)
                value.ThermalContrast[index] = reader.ReadSingle("thermalContrast");
        }
        if ((value.DataFilter.BitFlags & (1u << 5)) != 0)
        {
            int ReflectanceCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "reflectance");
            value.Reflectance = new float[ReflectanceCount];
            for (int index = 0; index < ReflectanceCount; index++)
                value.Reflectance[index] = reader.ReadSingle("reflectance");
        }
        if ((value.DataFilter.BitFlags & (1u << 6)) != 0)
        {
            int MineEmplacementTimeCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "mineEmplacementTime");
            value.MineEmplacementTime = new List<MineEmplacementTime>(MineEmplacementTimeCount);
            for (int index = 0; index < MineEmplacementTimeCount; index++)
                value.MineEmplacementTime.Add(ReadMineEmplacementTime(ref reader));
        }
        int MineEntityNumberCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "mineEntityNumber");
        value.MineEntityNumber = new ushort[MineEntityNumberCount];
        for (int index = 0; index < MineEntityNumberCount; index++)
            value.MineEntityNumber[index] = reader.ReadUInt16("mineEntityNumber");
        if ((value.DataFilter.BitFlags & (1u << 8)) != 0)
        {
            int FusingCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "fusing");
            value.Fusing = new List<MinefieldDataFusing>(FusingCount);
            for (int index = 0; index < FusingCount; index++)
                value.Fusing.Add(new MinefieldDataFusing(reader.ReadUInt16("fusing")));
        }
        if ((value.DataFilter.BitFlags & (1u << 9)) != 0)
        {
            int ScalarDetectionCoefficientCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "scalarDetectionCoefficient");
            value.ScalarDetectionCoefficient = new byte[ScalarDetectionCoefficientCount];
            for (int index = 0; index < ScalarDetectionCoefficientCount; index++)
                value.ScalarDetectionCoefficient[index] = reader.ReadByte("scalarDetectionCoefficient");
        }
        if ((value.DataFilter.BitFlags & (1u << 10)) != 0)
        {
            int PaintSchemeCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "paintScheme");
            value.PaintScheme = new List<MinefieldDataPaintScheme>(PaintSchemeCount);
            for (int index = 0; index < PaintSchemeCount; index++)
                value.PaintScheme.Add(new MinefieldDataPaintScheme(reader.ReadByte("paintScheme")));
        }
        reader.Skip(Padding(reader.Offset, 4), "padTo32_2");
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            int NumberOfTripDetonationWiresCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "numberOfTripDetonationWires");
            value.NumberOfTripDetonationWires = new byte[NumberOfTripDetonationWiresCount];
            for (int index = 0; index < NumberOfTripDetonationWiresCount; index++)
                value.NumberOfTripDetonationWires[index] = reader.ReadByte("numberOfTripDetonationWires");
        }
        reader.Skip(Padding(reader.Offset, 4), "padTo32_3");
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            int NumberOfVerticesCount = CheckedCount(checked((int)value.NumberOfMinesInThisPdu), reader.Remaining, "numberOfVertices");
            value.NumberOfVertices = new byte[NumberOfVerticesCount];
            for (int index = 0; index < NumberOfVerticesCount; index++)
                value.NumberOfVertices[index] = reader.ReadByte("numberOfVertices");
        }
    }

    private static void PrepareMinefieldDataPduFields(MinefieldDataPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.MinefieldId);
        PrepareMinefieldIdentifier(value.MinefieldId);
        ArgumentNullException.ThrowIfNull(value.RequestingEntityId);
        PrepareSimulationIdentifier(value.RequestingEntityId);
        ArgumentNullException.ThrowIfNull(value.DataFilter);
        PrepareDataFilterRecord(value.DataFilter);
        ArgumentNullException.ThrowIfNull(value.MineType);
        PrepareEntityType(value.MineType);
        ArgumentNullException.ThrowIfNull(value.SensorTypes);
        foreach (MinefieldSensorType item in value.SensorTypes) PrepareMinefieldSensorType(item);
        value.NumberOfSensorTypes = checked((byte)value.SensorTypes.Count);
        ArgumentNullException.ThrowIfNull(value.MineLocation);
        foreach (Vector3Float item in value.MineLocation) PrepareVector3Float(item);
        value.NumberOfMinesInThisPdu = checked((byte)value.MineLocation.Count);
        if (value.GroundBurialDepthOffset.Length != 0) value.DataFilter.BitFlags |= 1u << 0;
        if ((value.DataFilter.BitFlags & (1u << 0)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.GroundBurialDepthOffset);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.GroundBurialDepthOffset.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'groundBurialDepthOffset'.");
        }
        if (value.WaterBurialDepthOffset.Length != 0) value.DataFilter.BitFlags |= 1u << 1;
        if ((value.DataFilter.BitFlags & (1u << 1)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.WaterBurialDepthOffset);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.WaterBurialDepthOffset.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'waterBurialDepthOffset'.");
        }
        if (value.SnowBurialDepthOffset.Length != 0) value.DataFilter.BitFlags |= 1u << 2;
        if ((value.DataFilter.BitFlags & (1u << 2)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.SnowBurialDepthOffset);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.SnowBurialDepthOffset.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'snowBurialDepthOffset'.");
        }
        if (value.MineOrientation.Count != 0) value.DataFilter.BitFlags |= 1u << 3;
        if ((value.DataFilter.BitFlags & (1u << 3)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.MineOrientation);
            foreach (EulerAngles item in value.MineOrientation) PrepareEulerAngles(item);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.MineOrientation.Count) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'mineOrientation'.");
        }
        if (value.ThermalContrast.Length != 0) value.DataFilter.BitFlags |= 1u << 4;
        if ((value.DataFilter.BitFlags & (1u << 4)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.ThermalContrast);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.ThermalContrast.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'thermalContrast'.");
        }
        if (value.Reflectance.Length != 0) value.DataFilter.BitFlags |= 1u << 5;
        if ((value.DataFilter.BitFlags & (1u << 5)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.Reflectance);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.Reflectance.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'reflectance'.");
        }
        if (value.MineEmplacementTime.Count != 0) value.DataFilter.BitFlags |= 1u << 6;
        if ((value.DataFilter.BitFlags & (1u << 6)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.MineEmplacementTime);
            foreach (MineEmplacementTime item in value.MineEmplacementTime) PrepareMineEmplacementTime(item);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.MineEmplacementTime.Count) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'mineEmplacementTime'.");
        }
        ArgumentNullException.ThrowIfNull(value.MineEntityNumber);
        if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.MineEntityNumber.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'mineEntityNumber'.");
        if (value.Fusing.Count != 0) value.DataFilter.BitFlags |= 1u << 8;
        if ((value.DataFilter.BitFlags & (1u << 8)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.Fusing);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.Fusing.Count) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'fusing'.");
        }
        if (value.ScalarDetectionCoefficient.Length != 0) value.DataFilter.BitFlags |= 1u << 9;
        if ((value.DataFilter.BitFlags & (1u << 9)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.ScalarDetectionCoefficient);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.ScalarDetectionCoefficient.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'scalarDetectionCoefficient'.");
        }
        if (value.PaintScheme.Count != 0) value.DataFilter.BitFlags |= 1u << 10;
        if ((value.DataFilter.BitFlags & (1u << 10)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.PaintScheme);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.PaintScheme.Count) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'paintScheme'.");
        }
        if (value.NumberOfTripDetonationWires.Length != 0) value.DataFilter.BitFlags |= 1u << 7;
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.NumberOfTripDetonationWires);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.NumberOfTripDetonationWires.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'numberOfTripDetonationWires'.");
        }
        if (value.NumberOfVertices.Length != 0) value.DataFilter.BitFlags |= 1u << 7;
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            ArgumentNullException.ThrowIfNull(value.NumberOfVertices);
            if (Convert.ToInt64(value.NumberOfMinesInThisPdu) != value.NumberOfVertices.Length) throw new InvalidOperationException("Field 'numberOfMinesInThisPdu' must match the encoded length of 'numberOfVertices'.");
        }
    }

    private static void WriteMinefieldDataPduFields(ref DisBinaryWriter writer, MinefieldDataPdu value)
    {
        WriteMinefieldIdentifier(ref writer, value.MinefieldId);
        WriteSimulationIdentifier(ref writer, value.RequestingEntityId);
        writer.WriteUInt16(value.MinefieldSequenceNumber, "minefieldSequenceNumber");
        writer.WriteByte(value.RequestId, "requestID");
        writer.WriteByte(value.PduSequenceNumber, "pduSequenceNumber");
        writer.WriteByte(value.NumberOfPdus, "numberOfPdus");
        writer.WriteByte(value.NumberOfMinesInThisPdu, "numberOfMinesInThisPdu");
        writer.WriteByte(value.NumberOfSensorTypes, "numberOfSensorTypes");
        writer.WriteByte(value.Padding, "padding");
        WriteDataFilterRecord(ref writer, value.DataFilter);
        WriteEntityType(ref writer, value.MineType);
        foreach (MinefieldSensorType item in value.SensorTypes) WriteMinefieldSensorType(ref writer, item);
        writer.WriteZeros(Padding(writer.Offset, 4), "padTo32");
        foreach (Vector3Float item in value.MineLocation) WriteVector3Float(ref writer, item);
        if ((value.DataFilter.BitFlags & (1u << 0)) != 0)
        {
            foreach (float item in value.GroundBurialDepthOffset) writer.WriteSingle(item, "groundBurialDepthOffset");
        }
        if ((value.DataFilter.BitFlags & (1u << 1)) != 0)
        {
            foreach (float item in value.WaterBurialDepthOffset) writer.WriteSingle(item, "waterBurialDepthOffset");
        }
        if ((value.DataFilter.BitFlags & (1u << 2)) != 0)
        {
            foreach (float item in value.SnowBurialDepthOffset) writer.WriteSingle(item, "snowBurialDepthOffset");
        }
        if ((value.DataFilter.BitFlags & (1u << 3)) != 0)
        {
            foreach (EulerAngles item in value.MineOrientation) WriteEulerAngles(ref writer, item);
        }
        if ((value.DataFilter.BitFlags & (1u << 4)) != 0)
        {
            foreach (float item in value.ThermalContrast) writer.WriteSingle(item, "thermalContrast");
        }
        if ((value.DataFilter.BitFlags & (1u << 5)) != 0)
        {
            foreach (float item in value.Reflectance) writer.WriteSingle(item, "reflectance");
        }
        if ((value.DataFilter.BitFlags & (1u << 6)) != 0)
        {
            foreach (MineEmplacementTime item in value.MineEmplacementTime) WriteMineEmplacementTime(ref writer, item);
        }
        foreach (ushort item in value.MineEntityNumber) writer.WriteUInt16(item, "mineEntityNumber");
        if ((value.DataFilter.BitFlags & (1u << 8)) != 0)
        {
            foreach (MinefieldDataFusing item in value.Fusing) writer.WriteUInt16(item.Value, "fusing");
        }
        if ((value.DataFilter.BitFlags & (1u << 9)) != 0)
        {
            foreach (byte item in value.ScalarDetectionCoefficient) writer.WriteByte(item, "scalarDetectionCoefficient");
        }
        if ((value.DataFilter.BitFlags & (1u << 10)) != 0)
        {
            foreach (MinefieldDataPaintScheme item in value.PaintScheme) writer.WriteByte(item.Value, "paintScheme");
        }
        writer.WriteZeros(Padding(writer.Offset, 4), "padTo32_2");
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            foreach (byte item in value.NumberOfTripDetonationWires) writer.WriteByte(item, "numberOfTripDetonationWires");
        }
        writer.WriteZeros(Padding(writer.Offset, 4), "padTo32_3");
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            foreach (byte item in value.NumberOfVertices) writer.WriteByte(item, "numberOfVertices");
        }
    }

    private static void MeasureMinefieldDataPduFields(in MinefieldDataPdu value, ref int offset)
    {
        MeasureMinefieldIdentifier(value.MinefieldId, ref offset);
        MeasureSimulationIdentifier(value.RequestingEntityId, ref offset);
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureDataFilterRecord(value.DataFilter, ref offset);
        MeasureEntityType(value.MineType, ref offset);
        foreach (MinefieldSensorType item in value.SensorTypes) MeasureMinefieldSensorType(item, ref offset);
        offset += Padding(offset, 4);
        foreach (Vector3Float item in value.MineLocation) MeasureVector3Float(item, ref offset);
        if ((value.DataFilter.BitFlags & (1u << 0)) != 0)
        {
            offset += checked(value.GroundBurialDepthOffset.Length * 4);
        }
        if ((value.DataFilter.BitFlags & (1u << 1)) != 0)
        {
            offset += checked(value.WaterBurialDepthOffset.Length * 4);
        }
        if ((value.DataFilter.BitFlags & (1u << 2)) != 0)
        {
            offset += checked(value.SnowBurialDepthOffset.Length * 4);
        }
        if ((value.DataFilter.BitFlags & (1u << 3)) != 0)
        {
            foreach (EulerAngles item in value.MineOrientation) MeasureEulerAngles(item, ref offset);
        }
        if ((value.DataFilter.BitFlags & (1u << 4)) != 0)
        {
            offset += checked(value.ThermalContrast.Length * 4);
        }
        if ((value.DataFilter.BitFlags & (1u << 5)) != 0)
        {
            offset += checked(value.Reflectance.Length * 4);
        }
        if ((value.DataFilter.BitFlags & (1u << 6)) != 0)
        {
            foreach (MineEmplacementTime item in value.MineEmplacementTime) MeasureMineEmplacementTime(item, ref offset);
        }
        offset += checked(value.MineEntityNumber.Length * 2);
        if ((value.DataFilter.BitFlags & (1u << 8)) != 0)
        {
            offset += checked(value.Fusing.Count * 2);
        }
        if ((value.DataFilter.BitFlags & (1u << 9)) != 0)
        {
            offset += checked(value.ScalarDetectionCoefficient.Length * 1);
        }
        if ((value.DataFilter.BitFlags & (1u << 10)) != 0)
        {
            offset += checked(value.PaintScheme.Count * 1);
        }
        offset += Padding(offset, 4);
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            offset += checked(value.NumberOfTripDetonationWires.Length * 1);
        }
        offset += Padding(offset, 4);
        if ((value.DataFilter.BitFlags & (1u << 7)) != 0)
        {
            offset += checked(value.NumberOfVertices.Length * 1);
        }
    }

    private static void ReadMinefieldFamilyPduFields(ref DisBinaryReader reader, MinefieldFamilyPdu value)
    {
    }

    private static void PrepareMinefieldFamilyPduFields(MinefieldFamilyPdu value)
    {
    }

    private static void WriteMinefieldFamilyPduFields(ref DisBinaryWriter writer, MinefieldFamilyPdu value)
    {
    }

    private static void MeasureMinefieldFamilyPduFields(in MinefieldFamilyPdu value, ref int offset)
    {
    }

    private static MinefieldIdentifier ReadMinefieldIdentifier(ref DisBinaryReader reader)
    {
        var value = new MinefieldIdentifier();
        ReadMinefieldIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadMinefieldIdentifierFields(ref DisBinaryReader reader, MinefieldIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.MinefieldNumber = reader.ReadUInt16("minefieldNumber");
    }

    private static void PrepareMinefieldIdentifier(MinefieldIdentifier value)
    {
        PrepareMinefieldIdentifierFields(value);
    }

    private static void PrepareMinefieldIdentifierFields(MinefieldIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteMinefieldIdentifier(ref DisBinaryWriter writer, MinefieldIdentifier value)
    {
        WriteMinefieldIdentifierFields(ref writer, value);
    }

    private static void WriteMinefieldIdentifierFields(ref DisBinaryWriter writer, MinefieldIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.MinefieldNumber, "minefieldNumber");
    }

    private static void MeasureMinefieldIdentifier(in MinefieldIdentifier value, ref int offset)
    {
        MeasureMinefieldIdentifierFields(value, ref offset);
    }

    private static void MeasureMinefieldIdentifierFields(in MinefieldIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static void ReadMinefieldQueryPduFields(ref DisBinaryReader reader, MinefieldQueryPdu value)
    {
        value.MinefieldId = ReadMinefieldIdentifier(ref reader);
        value.RequestingEntityId = ReadEntityId(ref reader);
        value.RequestId = reader.ReadByte("requestID");
        value.NumberOfPerimeterPoints = reader.ReadByte("numberOfPerimeterPoints");
        value.Padding = reader.ReadByte("padding");
        value.NumberOfSensorTypes = reader.ReadByte("numberOfSensorTypes");
        value.DataFilter = ReadDataFilterRecord(ref reader);
        value.RequestedMineType = ReadEntityType(ref reader);
        int RequestedPerimeterPointsCount = CheckedCount(checked((int)value.NumberOfPerimeterPoints), reader.Remaining, "requestedPerimeterPoints");
        value.RequestedPerimeterPoints = new List<Vector2Float>(RequestedPerimeterPointsCount);
        for (int index = 0; index < RequestedPerimeterPointsCount; index++)
            value.RequestedPerimeterPoints.Add(ReadVector2Float(ref reader));
        int SensorTypesCount = CheckedCount(checked((int)value.NumberOfSensorTypes), reader.Remaining, "sensorTypes");
        value.SensorTypes = new List<MinefieldSensorType>(SensorTypesCount);
        for (int index = 0; index < SensorTypesCount; index++)
            value.SensorTypes.Add(ReadMinefieldSensorType(ref reader));
    }

    private static void PrepareMinefieldQueryPduFields(MinefieldQueryPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.MinefieldId);
        PrepareMinefieldIdentifier(value.MinefieldId);
        ArgumentNullException.ThrowIfNull(value.RequestingEntityId);
        PrepareEntityId(value.RequestingEntityId);
        ArgumentNullException.ThrowIfNull(value.DataFilter);
        PrepareDataFilterRecord(value.DataFilter);
        ArgumentNullException.ThrowIfNull(value.RequestedMineType);
        PrepareEntityType(value.RequestedMineType);
        ArgumentNullException.ThrowIfNull(value.RequestedPerimeterPoints);
        foreach (Vector2Float item in value.RequestedPerimeterPoints) PrepareVector2Float(item);
        value.NumberOfPerimeterPoints = checked((byte)value.RequestedPerimeterPoints.Count);
        ArgumentNullException.ThrowIfNull(value.SensorTypes);
        foreach (MinefieldSensorType item in value.SensorTypes) PrepareMinefieldSensorType(item);
        value.NumberOfSensorTypes = checked((byte)value.SensorTypes.Count);
    }

    private static void WriteMinefieldQueryPduFields(ref DisBinaryWriter writer, MinefieldQueryPdu value)
    {
        WriteMinefieldIdentifier(ref writer, value.MinefieldId);
        WriteEntityId(ref writer, value.RequestingEntityId);
        writer.WriteByte(value.RequestId, "requestID");
        writer.WriteByte(value.NumberOfPerimeterPoints, "numberOfPerimeterPoints");
        writer.WriteByte(value.Padding, "padding");
        writer.WriteByte(value.NumberOfSensorTypes, "numberOfSensorTypes");
        WriteDataFilterRecord(ref writer, value.DataFilter);
        WriteEntityType(ref writer, value.RequestedMineType);
        foreach (Vector2Float item in value.RequestedPerimeterPoints) WriteVector2Float(ref writer, item);
        foreach (MinefieldSensorType item in value.SensorTypes) WriteMinefieldSensorType(ref writer, item);
    }

    private static void MeasureMinefieldQueryPduFields(in MinefieldQueryPdu value, ref int offset)
    {
        MeasureMinefieldIdentifier(value.MinefieldId, ref offset);
        MeasureEntityId(value.RequestingEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureDataFilterRecord(value.DataFilter, ref offset);
        MeasureEntityType(value.RequestedMineType, ref offset);
        foreach (Vector2Float item in value.RequestedPerimeterPoints) MeasureVector2Float(item, ref offset);
        foreach (MinefieldSensorType item in value.SensorTypes) MeasureMinefieldSensorType(item, ref offset);
    }

    private static void ReadMinefieldResponseNACKPduFields(ref DisBinaryReader reader, MinefieldResponseNACKPdu value)
    {
        value.MinefieldId = ReadMinefieldIdentifier(ref reader);
        value.RequestingEntityId = ReadSimulationIdentifier(ref reader);
        value.RequestId = reader.ReadByte("requestID");
        value.NumberOfMissingPdus = reader.ReadByte("numberOfMissingPdus");
        int MissingPduSequenceNumbersCount = CheckedCount(checked((int)value.NumberOfMissingPdus), reader.Remaining, "missingPduSequenceNumbers");
        value.MissingPduSequenceNumbers = new byte[MissingPduSequenceNumbersCount];
        for (int index = 0; index < MissingPduSequenceNumbersCount; index++)
            value.MissingPduSequenceNumbers[index] = reader.ReadByte("missingPduSequenceNumbers");
    }

    private static void PrepareMinefieldResponseNACKPduFields(MinefieldResponseNACKPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.MinefieldId);
        PrepareMinefieldIdentifier(value.MinefieldId);
        ArgumentNullException.ThrowIfNull(value.RequestingEntityId);
        PrepareSimulationIdentifier(value.RequestingEntityId);
        ArgumentNullException.ThrowIfNull(value.MissingPduSequenceNumbers);
        value.NumberOfMissingPdus = checked((byte)value.MissingPduSequenceNumbers.Length);
    }

    private static void WriteMinefieldResponseNACKPduFields(ref DisBinaryWriter writer, MinefieldResponseNACKPdu value)
    {
        WriteMinefieldIdentifier(ref writer, value.MinefieldId);
        WriteSimulationIdentifier(ref writer, value.RequestingEntityId);
        writer.WriteByte(value.RequestId, "requestID");
        writer.WriteByte(value.NumberOfMissingPdus, "numberOfMissingPdus");
        foreach (byte item in value.MissingPduSequenceNumbers) writer.WriteByte(item, "missingPduSequenceNumbers");
    }

    private static void MeasureMinefieldResponseNACKPduFields(in MinefieldResponseNACKPdu value, ref int offset)
    {
        MeasureMinefieldIdentifier(value.MinefieldId, ref offset);
        MeasureSimulationIdentifier(value.RequestingEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += checked(value.MissingPduSequenceNumbers.Length * 1);
    }

    private static MinefieldSensorType ReadMinefieldSensorType(ref DisBinaryReader reader)
    {
        var value = new MinefieldSensorType();
        ReadMinefieldSensorTypeFields(ref reader, value);
        return value;
    }

    private static void ReadMinefieldSensorTypeFields(ref DisBinaryReader reader, MinefieldSensorType value)
    {
        value.SensorType = reader.ReadUInt16("sensorType");
    }

    private static void PrepareMinefieldSensorType(MinefieldSensorType value)
    {
        PrepareMinefieldSensorTypeFields(value);
    }

    private static void PrepareMinefieldSensorTypeFields(MinefieldSensorType value)
    {
    }

    private static void WriteMinefieldSensorType(ref DisBinaryWriter writer, MinefieldSensorType value)
    {
        WriteMinefieldSensorTypeFields(ref writer, value);
    }

    private static void WriteMinefieldSensorTypeFields(ref DisBinaryWriter writer, MinefieldSensorType value)
    {
        writer.WriteUInt16(value.SensorType, "sensorType");
    }

    private static void MeasureMinefieldSensorType(in MinefieldSensorType value, ref int offset)
    {
        MeasureMinefieldSensorTypeFields(value, ref offset);
    }

    private static void MeasureMinefieldSensorTypeFields(in MinefieldSensorType value, ref int offset)
    {
        offset += 2;
    }

    private static void ReadMinefieldStatePduFields(ref DisBinaryReader reader, MinefieldStatePdu value)
    {
        value.MinefieldId = ReadMinefieldIdentifier(ref reader);
        value.MinefieldSequence = reader.ReadUInt16("minefieldSequence");
        value.ForceId = (ForceId)reader.ReadByte("forceID");
        value.NumberOfPerimeterPoints = reader.ReadByte("numberOfPerimeterPoints");
        value.MinefieldType = ReadEntityType(ref reader);
        value.NumberOfMineTypes = reader.ReadUInt16("numberOfMineTypes");
        value.MinefieldLocation = ReadVector3Double(ref reader);
        value.MinefieldOrientation = ReadEulerAngles(ref reader);
        value.Appearance = new MinefieldStateAppearanceBitMap(reader.ReadUInt16("appearance"));
        value.ProtocolMode = ReadProtocolMode(ref reader);
        int PerimeterPointsCount = CheckedCount(checked((int)value.NumberOfPerimeterPoints), reader.Remaining, "perimeterPoints");
        value.PerimeterPoints = new List<Vector2Float>(PerimeterPointsCount);
        for (int index = 0; index < PerimeterPointsCount; index++)
            value.PerimeterPoints.Add(ReadVector2Float(ref reader));
        int MineTypeCount = CheckedCount(checked((int)value.NumberOfMineTypes), reader.Remaining, "mineType");
        value.MineType = new List<EntityType>(MineTypeCount);
        for (int index = 0; index < MineTypeCount; index++)
            value.MineType.Add(ReadEntityType(ref reader));
    }

    private static void PrepareMinefieldStatePduFields(MinefieldStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.MinefieldId);
        PrepareMinefieldIdentifier(value.MinefieldId);
        ArgumentNullException.ThrowIfNull(value.MinefieldType);
        PrepareEntityType(value.MinefieldType);
        ArgumentNullException.ThrowIfNull(value.MinefieldLocation);
        PrepareVector3Double(value.MinefieldLocation);
        ArgumentNullException.ThrowIfNull(value.MinefieldOrientation);
        PrepareEulerAngles(value.MinefieldOrientation);
        ArgumentNullException.ThrowIfNull(value.ProtocolMode);
        PrepareProtocolMode(value.ProtocolMode);
        ArgumentNullException.ThrowIfNull(value.PerimeterPoints);
        foreach (Vector2Float item in value.PerimeterPoints) PrepareVector2Float(item);
        value.NumberOfPerimeterPoints = checked((byte)value.PerimeterPoints.Count);
        ArgumentNullException.ThrowIfNull(value.MineType);
        foreach (EntityType item in value.MineType) PrepareEntityType(item);
        value.NumberOfMineTypes = checked((ushort)value.MineType.Count);
    }

    private static void WriteMinefieldStatePduFields(ref DisBinaryWriter writer, MinefieldStatePdu value)
    {
        WriteMinefieldIdentifier(ref writer, value.MinefieldId);
        writer.WriteUInt16(value.MinefieldSequence, "minefieldSequence");
        writer.WriteByte((byte)value.ForceId, "forceID");
        writer.WriteByte(value.NumberOfPerimeterPoints, "numberOfPerimeterPoints");
        WriteEntityType(ref writer, value.MinefieldType);
        writer.WriteUInt16(value.NumberOfMineTypes, "numberOfMineTypes");
        WriteVector3Double(ref writer, value.MinefieldLocation);
        WriteEulerAngles(ref writer, value.MinefieldOrientation);
        writer.WriteUInt16(value.Appearance.Value, "appearance");
        WriteProtocolMode(ref writer, value.ProtocolMode);
        foreach (Vector2Float item in value.PerimeterPoints) WriteVector2Float(ref writer, item);
        foreach (EntityType item in value.MineType) WriteEntityType(ref writer, item);
    }

    private static void MeasureMinefieldStatePduFields(in MinefieldStatePdu value, ref int offset)
    {
        MeasureMinefieldIdentifier(value.MinefieldId, ref offset);
        offset += 2;
        offset += 1;
        offset += 1;
        MeasureEntityType(value.MinefieldType, ref offset);
        offset += 2;
        MeasureVector3Double(value.MinefieldLocation, ref offset);
        MeasureEulerAngles(value.MinefieldOrientation, ref offset);
        offset += 2;
        MeasureProtocolMode(value.ProtocolMode, ref offset);
        foreach (Vector2Float item in value.PerimeterPoints) MeasureVector2Float(item, ref offset);
        foreach (EntityType item in value.MineType) MeasureEntityType(item, ref offset);
    }

    private static Mode5InterrogatorBasicData ReadMode5InterrogatorBasicData(ref DisBinaryReader reader)
    {
        var value = new Mode5InterrogatorBasicData();
        ReadMode5InterrogatorBasicDataFields(ref reader, value);
        return value;
    }

    private static void ReadMode5InterrogatorBasicDataFields(ref DisBinaryReader reader, Mode5InterrogatorBasicData value)
    {
        value.Mode5InterrogatorStatus = reader.ReadByte("mode5InterrogatorStatus");
        value.Padding = reader.ReadByte("padding");
        value.Padding2 = reader.ReadUInt16("padding2");
        value.Mode5MessageFormatsPresent = reader.ReadUInt32("mode5MessageFormatsPresent");
        value.EntityId = ReadEntityId(ref reader);
        value.Padding3 = reader.ReadUInt16("padding3");
    }

    private static void PrepareMode5InterrogatorBasicData(Mode5InterrogatorBasicData value)
    {
        PrepareMode5InterrogatorBasicDataFields(value);
    }

    private static void PrepareMode5InterrogatorBasicDataFields(Mode5InterrogatorBasicData value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
    }

    private static void WriteMode5InterrogatorBasicData(ref DisBinaryWriter writer, Mode5InterrogatorBasicData value)
    {
        WriteMode5InterrogatorBasicDataFields(ref writer, value);
    }

    private static void WriteMode5InterrogatorBasicDataFields(ref DisBinaryWriter writer, Mode5InterrogatorBasicData value)
    {
        writer.WriteByte(value.Mode5InterrogatorStatus, "mode5InterrogatorStatus");
        writer.WriteByte(value.Padding, "padding");
        writer.WriteUInt16(value.Padding2, "padding2");
        writer.WriteUInt32(value.Mode5MessageFormatsPresent, "mode5MessageFormatsPresent");
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteUInt16(value.Padding3, "padding3");
    }

    private static void MeasureMode5InterrogatorBasicData(in Mode5InterrogatorBasicData value, ref int offset)
    {
        MeasureMode5InterrogatorBasicDataFields(value, ref offset);
    }

    private static void MeasureMode5InterrogatorBasicDataFields(in Mode5InterrogatorBasicData value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        MeasureEntityId(value.EntityId, ref offset);
        offset += 2;
    }

    private static Mode5TransponderBasicData ReadMode5TransponderBasicData(ref DisBinaryReader reader)
    {
        var value = new Mode5TransponderBasicData();
        ReadMode5TransponderBasicDataFields(ref reader, value);
        return value;
    }

    private static void ReadMode5TransponderBasicDataFields(ref DisBinaryReader reader, Mode5TransponderBasicData value)
    {
        value.Mode5Status = reader.ReadUInt16("mode5Status");
        value.PersonalIdentificationNumber = reader.ReadUInt16("personalIdentificationNumber");
        value.Mode5MessageFormatsPresent = reader.ReadUInt32("mode5MessageFormatsPresent");
        value.EnhancedMode1 = reader.ReadUInt16("enhancedMode1");
        value.NationalOrigin = reader.ReadUInt16("nationalOrigin");
        value.SupplementalData = reader.ReadByte("supplementalData");
        value.NavigationSource = (NavigationSource)reader.ReadByte("navigationSource");
        value.FigureOfMerit = reader.ReadByte("figureOfMerit");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareMode5TransponderBasicData(Mode5TransponderBasicData value)
    {
        PrepareMode5TransponderBasicDataFields(value);
    }

    private static void PrepareMode5TransponderBasicDataFields(Mode5TransponderBasicData value)
    {
    }

    private static void WriteMode5TransponderBasicData(ref DisBinaryWriter writer, Mode5TransponderBasicData value)
    {
        WriteMode5TransponderBasicDataFields(ref writer, value);
    }

    private static void WriteMode5TransponderBasicDataFields(ref DisBinaryWriter writer, Mode5TransponderBasicData value)
    {
        writer.WriteUInt16(value.Mode5Status, "mode5Status");
        writer.WriteUInt16(value.PersonalIdentificationNumber, "personalIdentificationNumber");
        writer.WriteUInt32(value.Mode5MessageFormatsPresent, "mode5MessageFormatsPresent");
        writer.WriteUInt16(value.EnhancedMode1, "enhancedMode1");
        writer.WriteUInt16(value.NationalOrigin, "nationalOrigin");
        writer.WriteByte(value.SupplementalData, "supplementalData");
        writer.WriteByte((byte)value.NavigationSource, "navigationSource");
        writer.WriteByte(value.FigureOfMerit, "figureOfMerit");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureMode5TransponderBasicData(in Mode5TransponderBasicData value, ref int offset)
    {
        MeasureMode5TransponderBasicDataFields(value, ref offset);
    }

    private static void MeasureMode5TransponderBasicDataFields(in Mode5TransponderBasicData value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static ModeSInterrogatorBasicData ReadModeSInterrogatorBasicData(ref DisBinaryReader reader)
    {
        var value = new ModeSInterrogatorBasicData();
        ReadModeSInterrogatorBasicDataFields(ref reader, value);
        return value;
    }

    private static void ReadModeSInterrogatorBasicDataFields(ref DisBinaryReader reader, ModeSInterrogatorBasicData value)
    {
        value.ModeSInterrogatorStatus = reader.ReadByte("modeSInterrogatorStatus");
        value.Padding = reader.ReadByte("padding");
        value.ModeSLevelsPresent = reader.ReadByte("modeSLevelsPresent");
        value.Padding2 = reader.ReadByte("padding2");
        value.Padding3 = reader.ReadUInt32("padding3");
        value.Padding4 = reader.ReadUInt32("padding4");
        value.Padding5 = reader.ReadUInt32("padding5");
        value.Padding6 = reader.ReadUInt32("padding6");
        value.Padding7 = reader.ReadUInt32("padding7");
    }

    private static void PrepareModeSInterrogatorBasicData(ModeSInterrogatorBasicData value)
    {
        PrepareModeSInterrogatorBasicDataFields(value);
    }

    private static void PrepareModeSInterrogatorBasicDataFields(ModeSInterrogatorBasicData value)
    {
    }

    private static void WriteModeSInterrogatorBasicData(ref DisBinaryWriter writer, ModeSInterrogatorBasicData value)
    {
        WriteModeSInterrogatorBasicDataFields(ref writer, value);
    }

    private static void WriteModeSInterrogatorBasicDataFields(ref DisBinaryWriter writer, ModeSInterrogatorBasicData value)
    {
        writer.WriteByte(value.ModeSInterrogatorStatus, "modeSInterrogatorStatus");
        writer.WriteByte(value.Padding, "padding");
        writer.WriteByte(value.ModeSLevelsPresent, "modeSLevelsPresent");
        writer.WriteByte(value.Padding2, "padding2");
        writer.WriteUInt32(value.Padding3, "padding3");
        writer.WriteUInt32(value.Padding4, "padding4");
        writer.WriteUInt32(value.Padding5, "padding5");
        writer.WriteUInt32(value.Padding6, "padding6");
        writer.WriteUInt32(value.Padding7, "padding7");
    }

    private static void MeasureModeSInterrogatorBasicData(in ModeSInterrogatorBasicData value, ref int offset)
    {
        MeasureModeSInterrogatorBasicDataFields(value, ref offset);
    }

    private static void MeasureModeSInterrogatorBasicDataFields(in ModeSInterrogatorBasicData value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static ModeSTransponderBasicData ReadModeSTransponderBasicData(ref DisBinaryReader reader)
    {
        var value = new ModeSTransponderBasicData();
        ReadModeSTransponderBasicDataFields(ref reader, value);
        return value;
    }

    private static void ReadModeSTransponderBasicDataFields(ref DisBinaryReader reader, ModeSTransponderBasicData value)
    {
        value.ModeSTransponderStatus = reader.ReadUInt16("modeSTransponderStatus");
        value.ModeSLevelsPresent = reader.ReadByte("modeSLevelsPresent");
        value.AircraftPresentDomain = (AircraftPresentDomain)reader.ReadByte("aircraftPresentDomain");
        value.AircraftIdentification = reader.ReadUInt64("aircraftIdentification");
        value.AircraftAddress = reader.ReadUInt32("aircraftAddress");
        value.AircraftIdentificationType = (AircraftIdentificationType)reader.ReadByte("aircraftIdentificationType");
        value.DapSource = reader.ReadByte("dapSource");
        value.ModeSAltitude = reader.ReadUInt16("modeSAltitude");
        value.CapabilityReport = (CapabilityReport)reader.ReadByte("capabilityReport");
        value.Padding = reader.ReadByte("padding");
        value.Padding2 = reader.ReadUInt16("padding2");
    }

    private static void PrepareModeSTransponderBasicData(ModeSTransponderBasicData value)
    {
        PrepareModeSTransponderBasicDataFields(value);
    }

    private static void PrepareModeSTransponderBasicDataFields(ModeSTransponderBasicData value)
    {
    }

    private static void WriteModeSTransponderBasicData(ref DisBinaryWriter writer, ModeSTransponderBasicData value)
    {
        WriteModeSTransponderBasicDataFields(ref writer, value);
    }

    private static void WriteModeSTransponderBasicDataFields(ref DisBinaryWriter writer, ModeSTransponderBasicData value)
    {
        writer.WriteUInt16(value.ModeSTransponderStatus, "modeSTransponderStatus");
        writer.WriteByte(value.ModeSLevelsPresent, "modeSLevelsPresent");
        writer.WriteByte((byte)value.AircraftPresentDomain, "aircraftPresentDomain");
        writer.WriteUInt64(value.AircraftIdentification, "aircraftIdentification");
        writer.WriteUInt32(value.AircraftAddress, "aircraftAddress");
        writer.WriteByte((byte)value.AircraftIdentificationType, "aircraftIdentificationType");
        writer.WriteByte(value.DapSource, "dapSource");
        writer.WriteUInt16(value.ModeSAltitude, "modeSAltitude");
        writer.WriteByte((byte)value.CapabilityReport, "capabilityReport");
        writer.WriteByte(value.Padding, "padding");
        writer.WriteUInt16(value.Padding2, "padding2");
    }

    private static void MeasureModeSTransponderBasicData(in ModeSTransponderBasicData value, ref int offset)
    {
        MeasureModeSTransponderBasicDataFields(value, ref offset);
    }

    private static void MeasureModeSTransponderBasicDataFields(in ModeSTransponderBasicData value, ref int offset)
    {
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 8;
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 2;
    }

    private static ModulationParameters ReadModulationParameters(ref DisBinaryReader reader)
    {
        var value = new ModulationParameters();
        ReadModulationParametersFields(ref reader, value);
        return value;
    }

    private static void ReadModulationParametersFields(ref DisBinaryReader reader, ModulationParameters value)
    {
        int RecordSpecificFieldsCount = CheckedCount(0, reader.Remaining, "recordSpecificFields");
        value.RecordSpecificFields = new byte[RecordSpecificFieldsCount];
        for (int index = 0; index < RecordSpecificFieldsCount; index++)
            value.RecordSpecificFields[index] = reader.ReadByte("recordSpecificFields");
        reader.Skip(Padding(reader.Offset, 8), "padding");
    }

    private static void PrepareModulationParameters(ModulationParameters value)
    {
        PrepareModulationParametersFields(value);
    }

    private static void PrepareModulationParametersFields(ModulationParameters value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificFields);
    }

    private static void WriteModulationParameters(ref DisBinaryWriter writer, ModulationParameters value)
    {
        WriteModulationParametersFields(ref writer, value);
    }

    private static void WriteModulationParametersFields(ref DisBinaryWriter writer, ModulationParameters value)
    {
        foreach (byte item in value.RecordSpecificFields) writer.WriteByte(item, "recordSpecificFields");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding");
    }

    private static void MeasureModulationParameters(in ModulationParameters value, ref int offset)
    {
        MeasureModulationParametersFields(value, ref offset);
    }

    private static void MeasureModulationParametersFields(in ModulationParameters value, ref int offset)
    {
        offset += checked(value.RecordSpecificFields.Length * 1);
        offset += Padding(offset, 8);
    }

    private static ModulationType ReadModulationType(ref DisBinaryReader reader)
    {
        var value = new ModulationType();
        ReadModulationTypeFields(ref reader, value);
        return value;
    }

    private static void ReadModulationTypeFields(ref DisBinaryReader reader, ModulationType value)
    {
        value.SpreadSpectrum = reader.ReadUInt16("spreadSpectrum");
        value.MajorModulation = (TransmitterMajorModulation)reader.ReadUInt16("majorModulation");
        value.Detail = reader.ReadUInt16("detail");
        value.RadioSystem = (TransmitterModulationTypeSystem)reader.ReadUInt16("radioSystem");
    }

    private static void PrepareModulationType(ModulationType value)
    {
        PrepareModulationTypeFields(value);
    }

    private static void PrepareModulationTypeFields(ModulationType value)
    {
    }

    private static void WriteModulationType(ref DisBinaryWriter writer, ModulationType value)
    {
        WriteModulationTypeFields(ref writer, value);
    }

    private static void WriteModulationTypeFields(ref DisBinaryWriter writer, ModulationType value)
    {
        writer.WriteUInt16(value.SpreadSpectrum, "spreadSpectrum");
        writer.WriteUInt16((ushort)value.MajorModulation, "majorModulation");
        writer.WriteUInt16(value.Detail, "detail");
        writer.WriteUInt16((ushort)value.RadioSystem, "radioSystem");
    }

    private static void MeasureModulationType(in ModulationType value, ref int offset)
    {
        MeasureModulationTypeFields(value, ref offset);
    }

    private static void MeasureModulationTypeFields(in ModulationType value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static Munition ReadMunition(ref DisBinaryReader reader)
    {
        var value = new Munition();
        ReadMunitionFields(ref reader, value);
        return value;
    }

    private static void ReadMunitionFields(ref DisBinaryReader reader, Munition value)
    {
        value.MunitionType = ReadEntityType(ref reader);
        value.Station = reader.ReadUInt32("station");
        value.Quantity = reader.ReadUInt16("quantity");
        value.MunitionStatus = (MunitionExpendableStatus)reader.ReadByte("munitionStatus");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareMunition(Munition value)
    {
        PrepareMunitionFields(value);
    }

    private static void PrepareMunitionFields(Munition value)
    {
        ArgumentNullException.ThrowIfNull(value.MunitionType);
        PrepareEntityType(value.MunitionType);
    }

    private static void WriteMunition(ref DisBinaryWriter writer, Munition value)
    {
        WriteMunitionFields(ref writer, value);
    }

    private static void WriteMunitionFields(ref DisBinaryWriter writer, Munition value)
    {
        WriteEntityType(ref writer, value.MunitionType);
        writer.WriteUInt32(value.Station, "station");
        writer.WriteUInt16(value.Quantity, "quantity");
        writer.WriteByte((byte)value.MunitionStatus, "munitionStatus");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureMunition(in Munition value, ref int offset)
    {
        MeasureMunitionFields(value, ref offset);
    }

    private static void MeasureMunitionFields(in Munition value, ref int offset)
    {
        MeasureEntityType(value.MunitionType, ref offset);
        offset += 4;
        offset += 2;
        offset += 1;
        offset += 1;
    }

    private static MunitionDescriptor ReadMunitionDescriptor(ref DisBinaryReader reader)
    {
        var value = new MunitionDescriptor();
        ReadMunitionDescriptorFields(ref reader, value);
        return value;
    }

    private static void ReadMunitionDescriptorFields(ref DisBinaryReader reader, MunitionDescriptor value)
    {
        value.MunitionType = ReadEntityType(ref reader);
        value.Warhead = (MunitionDescriptorWarhead)reader.ReadUInt16("warhead");
        value.Fuse = (MunitionDescriptorFuse)reader.ReadUInt16("fuse");
        value.Quantity = reader.ReadUInt16("quantity");
        value.Rate = reader.ReadUInt16("rate");
    }

    private static void PrepareMunitionDescriptor(MunitionDescriptor value)
    {
        PrepareMunitionDescriptorFields(value);
    }

    private static void PrepareMunitionDescriptorFields(MunitionDescriptor value)
    {
        ArgumentNullException.ThrowIfNull(value.MunitionType);
        PrepareEntityType(value.MunitionType);
    }

    private static void WriteMunitionDescriptor(ref DisBinaryWriter writer, MunitionDescriptor value)
    {
        WriteMunitionDescriptorFields(ref writer, value);
    }

    private static void WriteMunitionDescriptorFields(ref DisBinaryWriter writer, MunitionDescriptor value)
    {
        WriteEntityType(ref writer, value.MunitionType);
        writer.WriteUInt16((ushort)value.Warhead, "warhead");
        writer.WriteUInt16((ushort)value.Fuse, "fuse");
        writer.WriteUInt16(value.Quantity, "quantity");
        writer.WriteUInt16(value.Rate, "rate");
    }

    private static void MeasureMunitionDescriptor(in MunitionDescriptor value, ref int offset)
    {
        MeasureMunitionDescriptorFields(value, ref offset);
    }

    private static void MeasureMunitionDescriptorFields(in MunitionDescriptor value, ref int offset)
    {
        MeasureEntityType(value.MunitionType, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static MunitionReload ReadMunitionReload(ref DisBinaryReader reader)
    {
        var value = new MunitionReload();
        ReadMunitionReloadFields(ref reader, value);
        return value;
    }

    private static void ReadMunitionReloadFields(ref DisBinaryReader reader, MunitionReload value)
    {
        value.MunitionType = ReadEntityType(ref reader);
        value.Station = reader.ReadUInt32("station");
        value.StandardQuantity = reader.ReadUInt16("standardQuantity");
        value.MaximumQuantity = reader.ReadUInt16("maximumQuantity");
        value.StandardQuantityReloadTime = reader.ReadUInt32("standardQuantityReloadTime");
        value.MaximumQuantityReloadTime = reader.ReadUInt32("maximumQuantityReloadTime");
    }

    private static void PrepareMunitionReload(MunitionReload value)
    {
        PrepareMunitionReloadFields(value);
    }

    private static void PrepareMunitionReloadFields(MunitionReload value)
    {
        ArgumentNullException.ThrowIfNull(value.MunitionType);
        PrepareEntityType(value.MunitionType);
    }

    private static void WriteMunitionReload(ref DisBinaryWriter writer, MunitionReload value)
    {
        WriteMunitionReloadFields(ref writer, value);
    }

    private static void WriteMunitionReloadFields(ref DisBinaryWriter writer, MunitionReload value)
    {
        WriteEntityType(ref writer, value.MunitionType);
        writer.WriteUInt32(value.Station, "station");
        writer.WriteUInt16(value.StandardQuantity, "standardQuantity");
        writer.WriteUInt16(value.MaximumQuantity, "maximumQuantity");
        writer.WriteUInt32(value.StandardQuantityReloadTime, "standardQuantityReloadTime");
        writer.WriteUInt32(value.MaximumQuantityReloadTime, "maximumQuantityReloadTime");
    }

    private static void MeasureMunitionReload(in MunitionReload value, ref int offset)
    {
        MeasureMunitionReloadFields(value, ref offset);
    }

    private static void MeasureMunitionReloadFields(in MunitionReload value, ref int offset)
    {
        MeasureEntityType(value.MunitionType, ref offset);
        offset += 4;
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 4;
    }

    private static NamedLocationIdentification ReadNamedLocationIdentification(ref DisBinaryReader reader)
    {
        var value = new NamedLocationIdentification();
        ReadNamedLocationIdentificationFields(ref reader, value);
        return value;
    }

    private static void ReadNamedLocationIdentificationFields(ref DisBinaryReader reader, NamedLocationIdentification value)
    {
        value.StationName = (IsPartOfStationName)reader.ReadUInt16("stationName");
        value.StationNumber = reader.ReadUInt16("stationNumber");
    }

    private static void PrepareNamedLocationIdentification(NamedLocationIdentification value)
    {
        PrepareNamedLocationIdentificationFields(value);
    }

    private static void PrepareNamedLocationIdentificationFields(NamedLocationIdentification value)
    {
    }

    private static void WriteNamedLocationIdentification(ref DisBinaryWriter writer, NamedLocationIdentification value)
    {
        WriteNamedLocationIdentificationFields(ref writer, value);
    }

    private static void WriteNamedLocationIdentificationFields(ref DisBinaryWriter writer, NamedLocationIdentification value)
    {
        writer.WriteUInt16((ushort)value.StationName, "stationName");
        writer.WriteUInt16(value.StationNumber, "stationNumber");
    }

    private static void MeasureNamedLocationIdentification(in NamedLocationIdentification value, ref int offset)
    {
        MeasureNamedLocationIdentificationFields(value, ref offset);
    }

    private static void MeasureNamedLocationIdentificationFields(in NamedLocationIdentification value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static ObjectIdentifier ReadObjectIdentifier(ref DisBinaryReader reader)
    {
        var value = new ObjectIdentifier();
        ReadObjectIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadObjectIdentifierFields(ref DisBinaryReader reader, ObjectIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.ObjectNumber = reader.ReadUInt16("objectNumber");
    }

    private static void PrepareObjectIdentifier(ObjectIdentifier value)
    {
        PrepareObjectIdentifierFields(value);
    }

    private static void PrepareObjectIdentifierFields(ObjectIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteObjectIdentifier(ref DisBinaryWriter writer, ObjectIdentifier value)
    {
        WriteObjectIdentifierFields(ref writer, value);
    }

    private static void WriteObjectIdentifierFields(ref DisBinaryWriter writer, ObjectIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.ObjectNumber, "objectNumber");
    }

    private static void MeasureObjectIdentifier(in ObjectIdentifier value, ref int offset)
    {
        MeasureObjectIdentifierFields(value, ref offset);
    }

    private static void MeasureObjectIdentifierFields(in ObjectIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static ObjectType ReadObjectType(ref DisBinaryReader reader)
    {
        var value = new ObjectType();
        ReadObjectTypeFields(ref reader, value);
        return value;
    }

    private static void ReadObjectTypeFields(ref DisBinaryReader reader, ObjectType value)
    {
        value.Domain = (PlatformDomain)reader.ReadByte("domain");
        value.ObjectKind = (ObjectKind)reader.ReadByte("objectKind");
        value.Category = reader.ReadByte("category");
        value.SubCategory = reader.ReadByte("subCategory");
    }

    private static void PrepareObjectType(ObjectType value)
    {
        PrepareObjectTypeFields(value);
    }

    private static void PrepareObjectTypeFields(ObjectType value)
    {
    }

    private static void WriteObjectType(ref DisBinaryWriter writer, ObjectType value)
    {
        WriteObjectTypeFields(ref writer, value);
    }

    private static void WriteObjectTypeFields(ref DisBinaryWriter writer, ObjectType value)
    {
        writer.WriteByte((byte)value.Domain, "domain");
        writer.WriteByte((byte)value.ObjectKind, "objectKind");
        writer.WriteByte(value.Category, "category");
        writer.WriteByte(value.SubCategory, "subCategory");
    }

    private static void MeasureObjectType(in ObjectType value, ref int offset)
    {
        MeasureObjectTypeFields(value, ref offset);
    }

    private static void MeasureObjectTypeFields(in ObjectType value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static OwnershipStatusRecord ReadOwnershipStatusRecord(ref DisBinaryReader reader)
    {
        var value = new OwnershipStatusRecord();
        ReadOwnershipStatusRecordFields(ref reader, value);
        return value;
    }

    private static void ReadOwnershipStatusRecordFields(ref DisBinaryReader reader, OwnershipStatusRecord value)
    {
        value.EntityId = ReadEntityId(ref reader);
        value.OwnershipStatus = (OwnershipStatus)reader.ReadByte("ownershipStatus");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareOwnershipStatusRecord(OwnershipStatusRecord value)
    {
        PrepareOwnershipStatusRecordFields(value);
    }

    private static void PrepareOwnershipStatusRecordFields(OwnershipStatusRecord value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
    }

    private static void WriteOwnershipStatusRecord(ref DisBinaryWriter writer, OwnershipStatusRecord value)
    {
        WriteOwnershipStatusRecordFields(ref writer, value);
    }

    private static void WriteOwnershipStatusRecordFields(ref DisBinaryWriter writer, OwnershipStatusRecord value)
    {
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteByte((byte)value.OwnershipStatus, "ownershipStatus");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureOwnershipStatusRecord(in OwnershipStatusRecord value, ref int offset)
    {
        MeasureOwnershipStatusRecordFields(value, ref offset);
    }

    private static void MeasureOwnershipStatusRecordFields(in OwnershipStatusRecord value, ref int offset)
    {
        MeasureEntityId(value.EntityId, ref offset);
        offset += 1;
        offset += 1;
    }

    private static void ReadPduFields(ref DisBinaryReader reader, Pdu value)
    {
        value.ProtocolVersion = (DisProtocolVersion)reader.ReadByte("protocolVersion");
        value.ExerciseId = reader.ReadByte("exerciseID");
        value.PduType = (PduType)reader.ReadByte("pduType");
        value.ProtocolFamily = (ProtocolFamily)reader.ReadByte("protocolFamily");
        value.Timestamp = reader.ReadUInt32("timestamp");
        value.Length = reader.ReadUInt16("length");
    }

    private static void PreparePduFields(Pdu value)
    {
    }

    private static void WritePduFields(ref DisBinaryWriter writer, Pdu value)
    {
        writer.WriteByte((byte)value.ProtocolVersion, "protocolVersion");
        writer.WriteByte(value.ExerciseId, "exerciseID");
        writer.WriteByte((byte)value.PduType, "pduType");
        writer.WriteByte((byte)value.ProtocolFamily, "protocolFamily");
        writer.WriteUInt32(value.Timestamp, "timestamp");
        writer.WriteUInt16(value.Length, "length");
    }

    private static void MeasurePduFields(in Pdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 4;
        offset += 2;
    }

    private static void ReadPduBaseFields(ref DisBinaryReader reader, PduBase value)
    {
        value.PduStatus = ReadPduStatus(ref reader);
        value.Padding = reader.ReadByte("padding");
    }

    private static void PreparePduBaseFields(PduBase value)
    {
        ArgumentNullException.ThrowIfNull(value.PduStatus);
        PreparePduStatus(value.PduStatus);
    }

    private static void WritePduBaseFields(ref DisBinaryWriter writer, PduBase value)
    {
        WritePduStatus(ref writer, value.PduStatus);
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasurePduBaseFields(in PduBase value, ref int offset)
    {
        MeasurePduStatus(value.PduStatus, ref offset);
        offset += 1;
    }

    private static PduStatus ReadPduStatus(ref DisBinaryReader reader)
    {
        var value = new PduStatus();
        ReadPduStatusFields(ref reader, value);
        return value;
    }

    private static void ReadPduStatusFields(ref DisBinaryReader reader, PduStatus value)
    {
        value.Value = reader.ReadByte("value");
    }

    private static void PreparePduStatus(PduStatus value)
    {
        PreparePduStatusFields(value);
    }

    private static void PreparePduStatusFields(PduStatus value)
    {
    }

    private static void WritePduStatus(ref DisBinaryWriter writer, PduStatus value)
    {
        WritePduStatusFields(ref writer, value);
    }

    private static void WritePduStatusFields(ref DisBinaryWriter writer, PduStatus value)
    {
        writer.WriteByte(value.Value, "value");
    }

    private static void MeasurePduStatus(in PduStatus value, ref int offset)
    {
        MeasurePduStatusFields(value, ref offset);
    }

    private static void MeasurePduStatusFields(in PduStatus value, ref int offset)
    {
        offset += 1;
    }

    private static void ReadPointObjectStatePduFields(ref DisBinaryReader reader, PointObjectStatePdu value)
    {
        value.ObjectId = ReadEntityId(ref reader);
        value.ReferencedObjectId = ReadObjectIdentifier(ref reader);
        value.UpdateNumber = reader.ReadUInt32("updateNumber");
        value.ForceId = (ForceId)reader.ReadByte("forceID");
        value.Modifications = new ObjectStateModificationPointObject(reader.ReadUInt16("modifications"));
        value.ObjectType = ReadObjectType(ref reader);
        value.ObjectLocation = ReadVector3Double(ref reader);
        value.ObjectOrientation = ReadEulerAngles(ref reader);
        value.SpecificObjectAppearance = reader.ReadUInt32("specificObjectAppearance");
        value.GenerObjectAppearance = new ObjectStateAppearanceGeneral(reader.ReadUInt16("generObjectAppearance"));
        value.Padding1 = reader.ReadUInt16("padding1");
        value.RequesterId = ReadSimulationAddress(ref reader);
        value.ReceivingId = ReadSimulationAddress(ref reader);
        value.Pad2 = reader.ReadUInt32("pad2");
    }

    private static void PreparePointObjectStatePduFields(PointObjectStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ObjectId);
        PrepareEntityId(value.ObjectId);
        ArgumentNullException.ThrowIfNull(value.ReferencedObjectId);
        PrepareObjectIdentifier(value.ReferencedObjectId);
        ArgumentNullException.ThrowIfNull(value.ObjectType);
        PrepareObjectType(value.ObjectType);
        ArgumentNullException.ThrowIfNull(value.ObjectLocation);
        PrepareVector3Double(value.ObjectLocation);
        ArgumentNullException.ThrowIfNull(value.ObjectOrientation);
        PrepareEulerAngles(value.ObjectOrientation);
        ArgumentNullException.ThrowIfNull(value.RequesterId);
        PrepareSimulationAddress(value.RequesterId);
        ArgumentNullException.ThrowIfNull(value.ReceivingId);
        PrepareSimulationAddress(value.ReceivingId);
    }

    private static void WritePointObjectStatePduFields(ref DisBinaryWriter writer, PointObjectStatePdu value)
    {
        WriteEntityId(ref writer, value.ObjectId);
        WriteObjectIdentifier(ref writer, value.ReferencedObjectId);
        writer.WriteUInt32(value.UpdateNumber, "updateNumber");
        writer.WriteByte((byte)value.ForceId, "forceID");
        writer.WriteUInt16(value.Modifications.Value, "modifications");
        WriteObjectType(ref writer, value.ObjectType);
        WriteVector3Double(ref writer, value.ObjectLocation);
        WriteEulerAngles(ref writer, value.ObjectOrientation);
        writer.WriteUInt32(value.SpecificObjectAppearance, "specificObjectAppearance");
        writer.WriteUInt16(value.GenerObjectAppearance.Value, "generObjectAppearance");
        writer.WriteUInt16(value.Padding1, "padding1");
        WriteSimulationAddress(ref writer, value.RequesterId);
        WriteSimulationAddress(ref writer, value.ReceivingId);
        writer.WriteUInt32(value.Pad2, "pad2");
    }

    private static void MeasurePointObjectStatePduFields(in PointObjectStatePdu value, ref int offset)
    {
        MeasureEntityId(value.ObjectId, ref offset);
        MeasureObjectIdentifier(value.ReferencedObjectId, ref offset);
        offset += 4;
        offset += 1;
        offset += 2;
        MeasureObjectType(value.ObjectType, ref offset);
        MeasureVector3Double(value.ObjectLocation, ref offset);
        MeasureEulerAngles(value.ObjectOrientation, ref offset);
        offset += 4;
        offset += 2;
        offset += 2;
        MeasureSimulationAddress(value.RequesterId, ref offset);
        MeasureSimulationAddress(value.ReceivingId, ref offset);
        offset += 4;
    }

    private static PropulsionSystemData ReadPropulsionSystemData(ref DisBinaryReader reader)
    {
        var value = new PropulsionSystemData();
        ReadPropulsionSystemDataFields(ref reader, value);
        return value;
    }

    private static void ReadPropulsionSystemDataFields(ref DisBinaryReader reader, PropulsionSystemData value)
    {
        value.PowerSetting = reader.ReadSingle("powerSetting");
        value.EngineRpm = reader.ReadSingle("engineRpm");
    }

    private static void PreparePropulsionSystemData(PropulsionSystemData value)
    {
        PreparePropulsionSystemDataFields(value);
    }

    private static void PreparePropulsionSystemDataFields(PropulsionSystemData value)
    {
    }

    private static void WritePropulsionSystemData(ref DisBinaryWriter writer, PropulsionSystemData value)
    {
        WritePropulsionSystemDataFields(ref writer, value);
    }

    private static void WritePropulsionSystemDataFields(ref DisBinaryWriter writer, PropulsionSystemData value)
    {
        writer.WriteSingle(value.PowerSetting, "powerSetting");
        writer.WriteSingle(value.EngineRpm, "engineRpm");
    }

    private static void MeasurePropulsionSystemData(in PropulsionSystemData value, ref int offset)
    {
        MeasurePropulsionSystemDataFields(value, ref offset);
    }

    private static void MeasurePropulsionSystemDataFields(in PropulsionSystemData value, ref int offset)
    {
        offset += 4;
        offset += 4;
    }

    private static ProtocolMode ReadProtocolMode(ref DisBinaryReader reader)
    {
        var value = new ProtocolMode();
        ReadProtocolModeFields(ref reader, value);
        return value;
    }

    private static void ReadProtocolModeFields(ref DisBinaryReader reader, ProtocolMode value)
    {
        value.ProtocolModeValue = reader.ReadUInt16("protocolMode");
    }

    private static void PrepareProtocolMode(ProtocolMode value)
    {
        PrepareProtocolModeFields(value);
    }

    private static void PrepareProtocolModeFields(ProtocolMode value)
    {
    }

    private static void WriteProtocolMode(ref DisBinaryWriter writer, ProtocolMode value)
    {
        WriteProtocolModeFields(ref writer, value);
    }

    private static void WriteProtocolModeFields(ref DisBinaryWriter writer, ProtocolMode value)
    {
        writer.WriteUInt16(value.ProtocolModeValue, "protocolMode");
    }

    private static void MeasureProtocolMode(in ProtocolMode value, ref int offset)
    {
        MeasureProtocolModeFields(value, ref offset);
    }

    private static void MeasureProtocolModeFields(in ProtocolMode value, ref int offset)
    {
        offset += 2;
    }

    private static RadioCommsHeader ReadRadioCommsHeader(ref DisBinaryReader reader)
    {
        var value = new RadioCommsHeader();
        ReadRadioCommsHeaderFields(ref reader, value);
        return value;
    }

    private static void ReadRadioCommsHeaderFields(ref DisBinaryReader reader, RadioCommsHeader value)
    {
        value.RadioReferenceId = ReadEntityId(ref reader);
        value.RadioNumber = reader.ReadUInt16("radioNumber");
    }

    private static void PrepareRadioCommsHeader(RadioCommsHeader value)
    {
        PrepareRadioCommsHeaderFields(value);
    }

    private static void PrepareRadioCommsHeaderFields(RadioCommsHeader value)
    {
        ArgumentNullException.ThrowIfNull(value.RadioReferenceId);
        PrepareEntityId(value.RadioReferenceId);
    }

    private static void WriteRadioCommsHeader(ref DisBinaryWriter writer, RadioCommsHeader value)
    {
        WriteRadioCommsHeaderFields(ref writer, value);
    }

    private static void WriteRadioCommsHeaderFields(ref DisBinaryWriter writer, RadioCommsHeader value)
    {
        WriteEntityId(ref writer, value.RadioReferenceId);
        writer.WriteUInt16(value.RadioNumber, "radioNumber");
    }

    private static void MeasureRadioCommsHeader(in RadioCommsHeader value, ref int offset)
    {
        MeasureRadioCommsHeaderFields(value, ref offset);
    }

    private static void MeasureRadioCommsHeaderFields(in RadioCommsHeader value, ref int offset)
    {
        MeasureEntityId(value.RadioReferenceId, ref offset);
        offset += 2;
    }

    private static void ReadRadioCommunicationsFamilyPduFields(ref DisBinaryReader reader, RadioCommunicationsFamilyPdu value)
    {
    }

    private static void PrepareRadioCommunicationsFamilyPduFields(RadioCommunicationsFamilyPdu value)
    {
    }

    private static void WriteRadioCommunicationsFamilyPduFields(ref DisBinaryWriter writer, RadioCommunicationsFamilyPdu value)
    {
    }

    private static void MeasureRadioCommunicationsFamilyPduFields(in RadioCommunicationsFamilyPdu value, ref int offset)
    {
    }

    private static RadioIdentifier ReadRadioIdentifier(ref DisBinaryReader reader)
    {
        var value = new RadioIdentifier();
        ReadRadioIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadRadioIdentifierFields(ref DisBinaryReader reader, RadioIdentifier value)
    {
        value.SiteNumber = reader.ReadUInt16("siteNumber");
        value.ApplicationNumber = reader.ReadUInt16("applicationNumber");
        value.ReferenceNumber = reader.ReadUInt16("referenceNumber");
        value.RadioNumber = reader.ReadUInt16("radioNumber");
    }

    private static void PrepareRadioIdentifier(RadioIdentifier value)
    {
        PrepareRadioIdentifierFields(value);
    }

    private static void PrepareRadioIdentifierFields(RadioIdentifier value)
    {
    }

    private static void WriteRadioIdentifier(ref DisBinaryWriter writer, RadioIdentifier value)
    {
        WriteRadioIdentifierFields(ref writer, value);
    }

    private static void WriteRadioIdentifierFields(ref DisBinaryWriter writer, RadioIdentifier value)
    {
        writer.WriteUInt16(value.SiteNumber, "siteNumber");
        writer.WriteUInt16(value.ApplicationNumber, "applicationNumber");
        writer.WriteUInt16(value.ReferenceNumber, "referenceNumber");
        writer.WriteUInt16(value.RadioNumber, "radioNumber");
    }

    private static void MeasureRadioIdentifier(in RadioIdentifier value, ref int offset)
    {
        MeasureRadioIdentifierFields(value, ref offset);
    }

    private static void MeasureRadioIdentifierFields(in RadioIdentifier value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
    }

    private static RadioType ReadRadioType(ref DisBinaryReader reader)
    {
        var value = new RadioType();
        ReadRadioTypeFields(ref reader, value);
        return value;
    }

    private static void ReadRadioTypeFields(ref DisBinaryReader reader, RadioType value)
    {
        value.EntityKind = (EntityKind)reader.ReadByte("entityKind");
        value.Domain = reader.ReadByte("domain");
        value.Country = (Country)reader.ReadUInt16("country");
        value.Category = (RadioCategory)reader.ReadByte("category");
        value.Subcategory = (RadioSubcategory)reader.ReadByte("subcategory");
        value.Specific = reader.ReadByte("specific");
        value.Extra = reader.ReadByte("extra");
    }

    private static void PrepareRadioType(RadioType value)
    {
        PrepareRadioTypeFields(value);
    }

    private static void PrepareRadioTypeFields(RadioType value)
    {
    }

    private static void WriteRadioType(ref DisBinaryWriter writer, RadioType value)
    {
        WriteRadioTypeFields(ref writer, value);
    }

    private static void WriteRadioTypeFields(ref DisBinaryWriter writer, RadioType value)
    {
        writer.WriteByte((byte)value.EntityKind, "entityKind");
        writer.WriteByte(value.Domain, "domain");
        writer.WriteUInt16((ushort)value.Country, "country");
        writer.WriteByte((byte)value.Category, "category");
        writer.WriteByte((byte)value.Subcategory, "subcategory");
        writer.WriteByte(value.Specific, "specific");
        writer.WriteByte(value.Extra, "extra");
    }

    private static void MeasureRadioType(in RadioType value, ref int offset)
    {
        MeasureRadioTypeFields(value, ref offset);
    }

    private static void MeasureRadioTypeFields(in RadioType value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static void ReadReceiverPduFields(ref DisBinaryReader reader, ReceiverPdu value)
    {
        value.RadioHeader = ReadRadioCommsHeader(ref reader);
        value.ReceiverState = (ReceiverReceiverState)reader.ReadUInt16("receiverState");
        value.Padding1 = reader.ReadUInt16("padding1");
        value.ReceivedPower = reader.ReadSingle("receivedPower");
        value.TransmitterEntityId = ReadEntityId(ref reader);
        value.TransmitterRadioId = reader.ReadUInt16("transmitterRadioId");
    }

    private static void PrepareReceiverPduFields(ReceiverPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RadioHeader);
        PrepareRadioCommsHeader(value.RadioHeader);
        ArgumentNullException.ThrowIfNull(value.TransmitterEntityId);
        PrepareEntityId(value.TransmitterEntityId);
    }

    private static void WriteReceiverPduFields(ref DisBinaryWriter writer, ReceiverPdu value)
    {
        WriteRadioCommsHeader(ref writer, value.RadioHeader);
        writer.WriteUInt16((ushort)value.ReceiverState, "receiverState");
        writer.WriteUInt16(value.Padding1, "padding1");
        writer.WriteSingle(value.ReceivedPower, "receivedPower");
        WriteEntityId(ref writer, value.TransmitterEntityId);
        writer.WriteUInt16(value.TransmitterRadioId, "transmitterRadioId");
    }

    private static void MeasureReceiverPduFields(in ReceiverPdu value, ref int offset)
    {
        MeasureRadioCommsHeader(value.RadioHeader, ref offset);
        offset += 2;
        offset += 2;
        offset += 4;
        MeasureEntityId(value.TransmitterEntityId, ref offset);
        offset += 2;
    }

    private static void ReadRecordQueryReliablePduFields(ref DisBinaryReader reader, RecordQueryReliablePdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.EventType = (RecordQueryREventType)reader.ReadUInt16("eventType");
        value.Time = reader.ReadUInt32("time");
        value.NumberOfRecords = reader.ReadUInt32("numberOfRecords");
        int RecordIdsCount = CheckedCount(checked((int)value.NumberOfRecords), reader.Remaining, "recordIDs");
        value.RecordIds = new List<RecordQuerySpecification>(RecordIdsCount);
        for (int index = 0; index < RecordIdsCount; index++)
            value.RecordIds.Add(ReadRecordQuerySpecification(ref reader));
    }

    private static void PrepareRecordQueryReliablePduFields(RecordQueryReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordIds);
        foreach (RecordQuerySpecification item in value.RecordIds) PrepareRecordQuerySpecification(item);
        value.NumberOfRecords = checked((uint)value.RecordIds.Count);
    }

    private static void WriteRecordQueryReliablePduFields(ref DisBinaryWriter writer, RecordQueryReliablePdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16((ushort)value.EventType, "eventType");
        writer.WriteUInt32(value.Time, "time");
        writer.WriteUInt32(value.NumberOfRecords, "numberOfRecords");
        foreach (RecordQuerySpecification item in value.RecordIds) WriteRecordQuerySpecification(ref writer, item);
    }

    private static void MeasureRecordQueryReliablePduFields(in RecordQueryReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        foreach (RecordQuerySpecification item in value.RecordIds) MeasureRecordQuerySpecification(item, ref offset);
    }

    private static RecordQuerySpecification ReadRecordQuerySpecification(ref DisBinaryReader reader)
    {
        var value = new RecordQuerySpecification();
        ReadRecordQuerySpecificationFields(ref reader, value);
        return value;
    }

    private static void ReadRecordQuerySpecificationFields(ref DisBinaryReader reader, RecordQuerySpecification value)
    {
        value.NumberOfRecords = reader.ReadUInt32("numberOfRecords");
        int RecordIdsCount = CheckedCount(checked((int)value.NumberOfRecords), reader.Remaining, "recordIDs");
        value.RecordIds = new List<VariableRecordType>(RecordIdsCount);
        for (int index = 0; index < RecordIdsCount; index++)
            value.RecordIds.Add((VariableRecordType)reader.ReadUInt32("recordIDs"));
    }

    private static void PrepareRecordQuerySpecification(RecordQuerySpecification value)
    {
        PrepareRecordQuerySpecificationFields(value);
    }

    private static void PrepareRecordQuerySpecificationFields(RecordQuerySpecification value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordIds);
        value.NumberOfRecords = checked((uint)value.RecordIds.Count);
    }

    private static void WriteRecordQuerySpecification(ref DisBinaryWriter writer, RecordQuerySpecification value)
    {
        WriteRecordQuerySpecificationFields(ref writer, value);
    }

    private static void WriteRecordQuerySpecificationFields(ref DisBinaryWriter writer, RecordQuerySpecification value)
    {
        writer.WriteUInt32(value.NumberOfRecords, "numberOfRecords");
        foreach (VariableRecordType item in value.RecordIds) writer.WriteUInt32((uint)item, "recordIDs");
    }

    private static void MeasureRecordQuerySpecification(in RecordQuerySpecification value, ref int offset)
    {
        MeasureRecordQuerySpecificationFields(value, ref offset);
    }

    private static void MeasureRecordQuerySpecificationFields(in RecordQuerySpecification value, ref int offset)
    {
        offset += 4;
        offset += checked(value.RecordIds.Count * 4);
    }

    private static void ReadRecordReliablePduFields(ref DisBinaryReader reader, RecordReliablePdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.EventType = (RecordREventType)reader.ReadUInt16("eventType");
        value.NumberOfRecordSets = reader.ReadUInt32("numberOfRecordSets");
        int RecordSetsCount = CheckedCount(checked((int)value.NumberOfRecordSets), reader.Remaining, "recordSets");
        value.RecordSets = new List<RecordSpecification>(RecordSetsCount);
        for (int index = 0; index < RecordSetsCount; index++)
            value.RecordSets.Add(ReadRecordSpecification(ref reader));
    }

    private static void PrepareRecordReliablePduFields(RecordReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSets);
        foreach (RecordSpecification item in value.RecordSets) PrepareRecordSpecification(item);
        value.NumberOfRecordSets = checked((uint)value.RecordSets.Count);
    }

    private static void WriteRecordReliablePduFields(ref DisBinaryWriter writer, RecordReliablePdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16((ushort)value.EventType, "eventType");
        writer.WriteUInt32(value.NumberOfRecordSets, "numberOfRecordSets");
        foreach (RecordSpecification item in value.RecordSets) WriteRecordSpecification(ref writer, item);
    }

    private static void MeasureRecordReliablePduFields(in RecordReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        foreach (RecordSpecification item in value.RecordSets) MeasureRecordSpecification(item, ref offset);
    }

    private static RecordSpecification ReadRecordSpecification(ref DisBinaryReader reader)
    {
        var value = new RecordSpecification();
        ReadRecordSpecificationFields(ref reader, value);
        return value;
    }

    private static void ReadRecordSpecificationFields(ref DisBinaryReader reader, RecordSpecification value)
    {
        value.NumberOfRecordSets = reader.ReadUInt32("numberOfRecordSets");
        int RecordSetsCount = CheckedCount(checked((int)value.NumberOfRecordSets), reader.Remaining, "recordSets");
        value.RecordSets = new List<RecordSpecificationElement>(RecordSetsCount);
        for (int index = 0; index < RecordSetsCount; index++)
            value.RecordSets.Add(ReadRecordSpecificationElement(ref reader));
    }

    private static void PrepareRecordSpecification(RecordSpecification value)
    {
        PrepareRecordSpecificationFields(value);
    }

    private static void PrepareRecordSpecificationFields(RecordSpecification value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSets);
        foreach (RecordSpecificationElement item in value.RecordSets) PrepareRecordSpecificationElement(item);
        value.NumberOfRecordSets = checked((uint)value.RecordSets.Count);
    }

    private static void WriteRecordSpecification(ref DisBinaryWriter writer, RecordSpecification value)
    {
        WriteRecordSpecificationFields(ref writer, value);
    }

    private static void WriteRecordSpecificationFields(ref DisBinaryWriter writer, RecordSpecification value)
    {
        writer.WriteUInt32(value.NumberOfRecordSets, "numberOfRecordSets");
        foreach (RecordSpecificationElement item in value.RecordSets) WriteRecordSpecificationElement(ref writer, item);
    }

    private static void MeasureRecordSpecification(in RecordSpecification value, ref int offset)
    {
        MeasureRecordSpecificationFields(value, ref offset);
    }

    private static void MeasureRecordSpecificationFields(in RecordSpecification value, ref int offset)
    {
        offset += 4;
        foreach (RecordSpecificationElement item in value.RecordSets) MeasureRecordSpecificationElement(item, ref offset);
    }

    private static RecordSpecificationElement ReadRecordSpecificationElement(ref DisBinaryReader reader)
    {
        var value = new RecordSpecificationElement();
        ReadRecordSpecificationElementFields(ref reader, value);
        return value;
    }

    private static void ReadRecordSpecificationElementFields(ref DisBinaryReader reader, RecordSpecificationElement value)
    {
        value.RecordId = (VariableRecordType)reader.ReadUInt32("recordID");
        value.RecordSetSerialNumber = reader.ReadUInt32("recordSetSerialNumber");
        value.Padding = reader.ReadUInt32("padding");
        value.RecordLength = reader.ReadUInt16("recordLength");
        value.RecordCount = reader.ReadUInt16("recordCount");
        int RecordValuesCount = CheckedCount((checked((int)value.RecordLength) * checked((int)value.RecordCount) + 7) / 8, reader.Remaining, "recordValues");
        value.RecordValues = new byte[RecordValuesCount];
        for (int index = 0; index < RecordValuesCount; index++)
            value.RecordValues[index] = reader.ReadByte("recordValues");
        int PadTo64Count = CheckedCount(Padding(reader.Offset, 8), reader.Remaining, "padTo64");
        value.PadTo64 = new byte[PadTo64Count];
        for (int index = 0; index < PadTo64Count; index++)
            value.PadTo64[index] = reader.ReadByte("padTo64");
    }

    private static void PrepareRecordSpecificationElement(RecordSpecificationElement value)
    {
        PrepareRecordSpecificationElementFields(value);
    }

    private static void PrepareRecordSpecificationElementFields(RecordSpecificationElement value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordValues);
        ArgumentNullException.ThrowIfNull(value.PadTo64);
    }

    private static void WriteRecordSpecificationElement(ref DisBinaryWriter writer, RecordSpecificationElement value)
    {
        WriteRecordSpecificationElementFields(ref writer, value);
    }

    private static void WriteRecordSpecificationElementFields(ref DisBinaryWriter writer, RecordSpecificationElement value)
    {
        writer.WriteUInt32((uint)value.RecordId, "recordID");
        writer.WriteUInt32(value.RecordSetSerialNumber, "recordSetSerialNumber");
        writer.WriteUInt32(value.Padding, "padding");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        writer.WriteUInt16(value.RecordCount, "recordCount");
        foreach (byte item in value.RecordValues) writer.WriteByte(item, "recordValues");
        foreach (byte item in value.PadTo64) writer.WriteByte(item, "padTo64");
    }

    private static void MeasureRecordSpecificationElement(in RecordSpecificationElement value, ref int offset)
    {
        MeasureRecordSpecificationElementFields(value, ref offset);
    }

    private static void MeasureRecordSpecificationElementFields(in RecordSpecificationElement value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 2;
        offset += 2;
        offset += checked(value.RecordValues.Length * 1);
        offset += checked(value.PadTo64.Length * 1);
    }

    private static Relationship ReadRelationship(ref DisBinaryReader reader)
    {
        var value = new Relationship();
        ReadRelationshipFields(ref reader, value);
        return value;
    }

    private static void ReadRelationshipFields(ref DisBinaryReader reader, Relationship value)
    {
        value.Nature = (IsPartOfNature)reader.ReadUInt16("nature");
        value.Position = (IsPartOfPosition)reader.ReadUInt16("position");
    }

    private static void PrepareRelationship(Relationship value)
    {
        PrepareRelationshipFields(value);
    }

    private static void PrepareRelationshipFields(Relationship value)
    {
    }

    private static void WriteRelationship(ref DisBinaryWriter writer, Relationship value)
    {
        WriteRelationshipFields(ref writer, value);
    }

    private static void WriteRelationshipFields(ref DisBinaryWriter writer, Relationship value)
    {
        writer.WriteUInt16((ushort)value.Nature, "nature");
        writer.WriteUInt16((ushort)value.Position, "position");
    }

    private static void MeasureRelationship(in Relationship value, ref int offset)
    {
        MeasureRelationshipFields(value, ref offset);
    }

    private static void MeasureRelationshipFields(in Relationship value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static void ReadRemoveEntityPduFields(ref DisBinaryReader reader, RemoveEntityPdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareRemoveEntityPduFields(RemoveEntityPdu value)
    {
    }

    private static void WriteRemoveEntityPduFields(ref DisBinaryWriter writer, RemoveEntityPdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureRemoveEntityPduFields(in RemoveEntityPdu value, ref int offset)
    {
        offset += 4;
    }

    private static void ReadRemoveEntityReliablePduFields(ref DisBinaryReader reader, RemoveEntityReliablePdu value)
    {
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareRemoveEntityReliablePduFields(RemoveEntityReliablePdu value)
    {
    }

    private static void WriteRemoveEntityReliablePduFields(ref DisBinaryWriter writer, RemoveEntityReliablePdu value)
    {
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureRemoveEntityReliablePduFields(in RemoveEntityReliablePdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
    }

    private static void ReadRepairCompletePduFields(ref DisBinaryReader reader, RepairCompletePdu value)
    {
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.RepairingEntityId = ReadEntityId(ref reader);
        value.Repair = (RepairCompleteRepair)reader.ReadUInt16("repair");
        value.Padding4 = reader.ReadUInt16("padding4");
    }

    private static void PrepareRepairCompletePduFields(RepairCompletePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.RepairingEntityId);
        PrepareEntityId(value.RepairingEntityId);
    }

    private static void WriteRepairCompletePduFields(ref DisBinaryWriter writer, RepairCompletePdu value)
    {
        WriteEntityId(ref writer, value.ReceivingEntityId);
        WriteEntityId(ref writer, value.RepairingEntityId);
        writer.WriteUInt16((ushort)value.Repair, "repair");
        writer.WriteUInt16(value.Padding4, "padding4");
    }

    private static void MeasureRepairCompletePduFields(in RepairCompletePdu value, ref int offset)
    {
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        MeasureEntityId(value.RepairingEntityId, ref offset);
        offset += 2;
        offset += 2;
    }

    private static void ReadRepairResponsePduFields(ref DisBinaryReader reader, RepairResponsePdu value)
    {
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.RepairingEntityId = ReadEntityId(ref reader);
        value.RepairResult = (RepairResponseRepairResult)reader.ReadUInt16("repairResult");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
    }

    private static void PrepareRepairResponsePduFields(RepairResponsePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.RepairingEntityId);
        PrepareEntityId(value.RepairingEntityId);
    }

    private static void WriteRepairResponsePduFields(ref DisBinaryWriter writer, RepairResponsePdu value)
    {
        WriteEntityId(ref writer, value.ReceivingEntityId);
        WriteEntityId(ref writer, value.RepairingEntityId);
        writer.WriteUInt16((ushort)value.RepairResult, "repairResult");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
    }

    private static void MeasureRepairResponsePduFields(in RepairResponsePdu value, ref int offset)
    {
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        MeasureEntityId(value.RepairingEntityId, ref offset);
        offset += 2;
        offset += 1;
        offset += 2;
    }

    private static RequestID ReadRequestID(ref DisBinaryReader reader)
    {
        var value = new RequestID();
        ReadRequestIDFields(ref reader, value);
        return value;
    }

    private static void ReadRequestIDFields(ref DisBinaryReader reader, RequestID value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareRequestID(RequestID value)
    {
        PrepareRequestIDFields(value);
    }

    private static void PrepareRequestIDFields(RequestID value)
    {
    }

    private static void WriteRequestID(ref DisBinaryWriter writer, RequestID value)
    {
        WriteRequestIDFields(ref writer, value);
    }

    private static void WriteRequestIDFields(ref DisBinaryWriter writer, RequestID value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureRequestID(in RequestID value, ref int offset)
    {
        MeasureRequestIDFields(value, ref offset);
    }

    private static void MeasureRequestIDFields(in RequestID value, ref int offset)
    {
        offset += 4;
    }

    private static void ReadResupplyCancelPduFields(ref DisBinaryReader reader, ResupplyCancelPdu value)
    {
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.SupplyingEntityId = ReadEntityId(ref reader);
    }

    private static void PrepareResupplyCancelPduFields(ResupplyCancelPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.SupplyingEntityId);
        PrepareEntityId(value.SupplyingEntityId);
    }

    private static void WriteResupplyCancelPduFields(ref DisBinaryWriter writer, ResupplyCancelPdu value)
    {
        WriteEntityId(ref writer, value.ReceivingEntityId);
        WriteEntityId(ref writer, value.SupplyingEntityId);
    }

    private static void MeasureResupplyCancelPduFields(in ResupplyCancelPdu value, ref int offset)
    {
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        MeasureEntityId(value.SupplyingEntityId, ref offset);
    }

    private static void ReadResupplyOfferPduFields(ref DisBinaryReader reader, ResupplyOfferPdu value)
    {
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.SupplyingEntityId = ReadEntityId(ref reader);
        value.NumberOfSupplyTypes = reader.ReadByte("numberOfSupplyTypes");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        int SuppliesCount = CheckedCount(checked((int)value.NumberOfSupplyTypes), reader.Remaining, "supplies");
        value.Supplies = new List<SupplyQuantity>(SuppliesCount);
        for (int index = 0; index < SuppliesCount; index++)
            value.Supplies.Add(ReadSupplyQuantity(ref reader));
    }

    private static void PrepareResupplyOfferPduFields(ResupplyOfferPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.SupplyingEntityId);
        PrepareEntityId(value.SupplyingEntityId);
        ArgumentNullException.ThrowIfNull(value.Supplies);
        foreach (SupplyQuantity item in value.Supplies) PrepareSupplyQuantity(item);
        value.NumberOfSupplyTypes = checked((byte)value.Supplies.Count);
    }

    private static void WriteResupplyOfferPduFields(ref DisBinaryWriter writer, ResupplyOfferPdu value)
    {
        WriteEntityId(ref writer, value.ReceivingEntityId);
        WriteEntityId(ref writer, value.SupplyingEntityId);
        writer.WriteByte(value.NumberOfSupplyTypes, "numberOfSupplyTypes");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        foreach (SupplyQuantity item in value.Supplies) WriteSupplyQuantity(ref writer, item);
    }

    private static void MeasureResupplyOfferPduFields(in ResupplyOfferPdu value, ref int offset)
    {
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        MeasureEntityId(value.SupplyingEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (SupplyQuantity item in value.Supplies) MeasureSupplyQuantity(item, ref offset);
    }

    private static void ReadResupplyReceivedPduFields(ref DisBinaryReader reader, ResupplyReceivedPdu value)
    {
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.SupplyingEntityId = ReadEntityId(ref reader);
        value.NumberOfSupplyTypes = reader.ReadByte("numberOfSupplyTypes");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        int SuppliesCount = CheckedCount(checked((int)value.NumberOfSupplyTypes), reader.Remaining, "supplies");
        value.Supplies = new List<SupplyQuantity>(SuppliesCount);
        for (int index = 0; index < SuppliesCount; index++)
            value.Supplies.Add(ReadSupplyQuantity(ref reader));
    }

    private static void PrepareResupplyReceivedPduFields(ResupplyReceivedPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.SupplyingEntityId);
        PrepareEntityId(value.SupplyingEntityId);
        ArgumentNullException.ThrowIfNull(value.Supplies);
        foreach (SupplyQuantity item in value.Supplies) PrepareSupplyQuantity(item);
        value.NumberOfSupplyTypes = checked((byte)value.Supplies.Count);
    }

    private static void WriteResupplyReceivedPduFields(ref DisBinaryWriter writer, ResupplyReceivedPdu value)
    {
        WriteEntityId(ref writer, value.ReceivingEntityId);
        WriteEntityId(ref writer, value.SupplyingEntityId);
        writer.WriteByte(value.NumberOfSupplyTypes, "numberOfSupplyTypes");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        foreach (SupplyQuantity item in value.Supplies) WriteSupplyQuantity(ref writer, item);
    }

    private static void MeasureResupplyReceivedPduFields(in ResupplyReceivedPdu value, ref int offset)
    {
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        MeasureEntityId(value.SupplyingEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (SupplyQuantity item in value.Supplies) MeasureSupplyQuantity(item, ref offset);
    }

    private static SecondaryOperationalData ReadSecondaryOperationalData(ref DisBinaryReader reader)
    {
        var value = new SecondaryOperationalData();
        ReadSecondaryOperationalDataFields(ref reader, value);
        return value;
    }

    private static void ReadSecondaryOperationalDataFields(ref DisBinaryReader reader, SecondaryOperationalData value)
    {
        value.OperationalData1 = reader.ReadByte("operationalData1");
        value.OperationalData2 = reader.ReadByte("operationalData2");
        value.NumberOfIFFFundamentalParameterRecords = reader.ReadUInt16("numberOfIFFFundamentalParameterRecords");
    }

    private static void PrepareSecondaryOperationalData(SecondaryOperationalData value)
    {
        PrepareSecondaryOperationalDataFields(value);
    }

    private static void PrepareSecondaryOperationalDataFields(SecondaryOperationalData value)
    {
    }

    private static void WriteSecondaryOperationalData(ref DisBinaryWriter writer, SecondaryOperationalData value)
    {
        WriteSecondaryOperationalDataFields(ref writer, value);
    }

    private static void WriteSecondaryOperationalDataFields(ref DisBinaryWriter writer, SecondaryOperationalData value)
    {
        writer.WriteByte(value.OperationalData1, "operationalData1");
        writer.WriteByte(value.OperationalData2, "operationalData2");
        writer.WriteUInt16(value.NumberOfIFFFundamentalParameterRecords, "numberOfIFFFundamentalParameterRecords");
    }

    private static void MeasureSecondaryOperationalData(in SecondaryOperationalData value, ref int offset)
    {
        MeasureSecondaryOperationalDataFields(value, ref offset);
    }

    private static void MeasureSecondaryOperationalDataFields(in SecondaryOperationalData value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
    }

    private static Sensor ReadSensor(ref DisBinaryReader reader)
    {
        var value = new Sensor();
        ReadSensorFields(ref reader, value);
        return value;
    }

    private static void ReadSensorFields(ref DisBinaryReader reader, Sensor value)
    {
        value.SensorTypeSource = (SensorTypeSource)reader.ReadByte("sensorTypeSource");
        value.SensorOnOffStatus = (SensorOnOffStatus)reader.ReadByte("sensorOnOffStatus");
        value.SensorType = reader.ReadUInt16("sensorType");
        value.Station = reader.ReadUInt32("station");
        value.Quantity = reader.ReadUInt16("quantity");
        value.Padding = reader.ReadUInt16("padding");
    }

    private static void PrepareSensor(Sensor value)
    {
        PrepareSensorFields(value);
    }

    private static void PrepareSensorFields(Sensor value)
    {
    }

    private static void WriteSensor(ref DisBinaryWriter writer, Sensor value)
    {
        WriteSensorFields(ref writer, value);
    }

    private static void WriteSensorFields(ref DisBinaryWriter writer, Sensor value)
    {
        writer.WriteByte((byte)value.SensorTypeSource, "sensorTypeSource");
        writer.WriteByte((byte)value.SensorOnOffStatus, "sensorOnOffStatus");
        writer.WriteUInt16(value.SensorType, "sensorType");
        writer.WriteUInt32(value.Station, "station");
        writer.WriteUInt16(value.Quantity, "quantity");
        writer.WriteUInt16(value.Padding, "padding");
    }

    private static void MeasureSensor(in Sensor value, ref int offset)
    {
        MeasureSensorFields(value, ref offset);
    }

    private static void MeasureSensorFields(in Sensor value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 2;
        offset += 2;
    }

    private static SeparationVP ReadSeparationVP(ref DisBinaryReader reader)
    {
        var value = new SeparationVP();
        ReadSeparationVPFields(ref reader, value);
        return value;
    }

    private static void ReadSeparationVPFields(ref DisBinaryReader reader, SeparationVP value)
    {
        value.RecordType = (VariableParameterRecordType)reader.ReadByte("recordType");
        value.ReasonForSeparation = (SeparationVpReasonforSeparation)reader.ReadByte("reasonForSeparation");
        value.PreEntityIndicator = (SeparationVpPreEntityIndicator)reader.ReadByte("preEntityIndicator");
        value.Padding1 = reader.ReadByte("padding1");
        value.ParentEntityId = ReadEntityId(ref reader);
        value.Padding2 = reader.ReadUInt16("padding2");
        value.StationLocation = ReadNamedLocationIdentification(ref reader);
    }

    private static void PrepareSeparationVP(SeparationVP value)
    {
        PrepareSeparationVPFields(value);
    }

    private static void PrepareSeparationVPFields(SeparationVP value)
    {
        ArgumentNullException.ThrowIfNull(value.ParentEntityId);
        PrepareEntityId(value.ParentEntityId);
        ArgumentNullException.ThrowIfNull(value.StationLocation);
        PrepareNamedLocationIdentification(value.StationLocation);
    }

    private static void WriteSeparationVP(ref DisBinaryWriter writer, SeparationVP value)
    {
        WriteSeparationVPFields(ref writer, value);
    }

    private static void WriteSeparationVPFields(ref DisBinaryWriter writer, SeparationVP value)
    {
        writer.WriteByte((byte)value.RecordType, "recordType");
        writer.WriteByte((byte)value.ReasonForSeparation, "reasonForSeparation");
        writer.WriteByte((byte)value.PreEntityIndicator, "preEntityIndicator");
        writer.WriteByte(value.Padding1, "padding1");
        WriteEntityId(ref writer, value.ParentEntityId);
        writer.WriteUInt16(value.Padding2, "padding2");
        WriteNamedLocationIdentification(ref writer, value.StationLocation);
    }

    private static void MeasureSeparationVP(in SeparationVP value, ref int offset)
    {
        MeasureSeparationVPFields(value, ref offset);
    }

    private static void MeasureSeparationVPFields(in SeparationVP value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        MeasureEntityId(value.ParentEntityId, ref offset);
        offset += 2;
        MeasureNamedLocationIdentification(value.StationLocation, ref offset);
    }

    private static void ReadServiceRequestPduFields(ref DisBinaryReader reader, ServiceRequestPdu value)
    {
        value.RequestingEntityId = ReadEntityId(ref reader);
        value.ServicingEntityId = ReadEntityId(ref reader);
        value.ServiceTypeRequested = (ServiceRequestServiceTypeRequested)reader.ReadByte("serviceTypeRequested");
        value.NumberOfSupplyTypes = reader.ReadByte("numberOfSupplyTypes");
        value.Padding1 = reader.ReadUInt16("padding1");
        int SuppliesCount = CheckedCount(checked((int)value.NumberOfSupplyTypes), reader.Remaining, "supplies");
        value.Supplies = new List<SupplyQuantity>(SuppliesCount);
        for (int index = 0; index < SuppliesCount; index++)
            value.Supplies.Add(ReadSupplyQuantity(ref reader));
    }

    private static void PrepareServiceRequestPduFields(ServiceRequestPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RequestingEntityId);
        PrepareEntityId(value.RequestingEntityId);
        ArgumentNullException.ThrowIfNull(value.ServicingEntityId);
        PrepareEntityId(value.ServicingEntityId);
        ArgumentNullException.ThrowIfNull(value.Supplies);
        foreach (SupplyQuantity item in value.Supplies) PrepareSupplyQuantity(item);
        value.NumberOfSupplyTypes = checked((byte)value.Supplies.Count);
    }

    private static void WriteServiceRequestPduFields(ref DisBinaryWriter writer, ServiceRequestPdu value)
    {
        WriteEntityId(ref writer, value.RequestingEntityId);
        WriteEntityId(ref writer, value.ServicingEntityId);
        writer.WriteByte((byte)value.ServiceTypeRequested, "serviceTypeRequested");
        writer.WriteByte(value.NumberOfSupplyTypes, "numberOfSupplyTypes");
        writer.WriteUInt16(value.Padding1, "padding1");
        foreach (SupplyQuantity item in value.Supplies) WriteSupplyQuantity(ref writer, item);
    }

    private static void MeasureServiceRequestPduFields(in ServiceRequestPdu value, ref int offset)
    {
        MeasureEntityId(value.RequestingEntityId, ref offset);
        MeasureEntityId(value.ServicingEntityId, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        foreach (SupplyQuantity item in value.Supplies) MeasureSupplyQuantity(item, ref offset);
    }

    private static void ReadSetDataPduFields(ref DisBinaryReader reader, SetDataPdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.Padding1 = reader.ReadUInt32("padding1");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatums");
        value.FixedDatums = new List<FixedDatum>(FixedDatumsCount);
        for (int index = 0; index < FixedDatumsCount; index++)
            value.FixedDatums.Add(ReadFixedDatum(ref reader));
        int VariableDatumsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatums");
        value.VariableDatums = new List<VariableDatum>(VariableDatumsCount);
        for (int index = 0; index < VariableDatumsCount; index++)
            value.VariableDatums.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareSetDataPduFields(SetDataPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatums);
        foreach (FixedDatum item in value.FixedDatums) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatums.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatums);
        foreach (VariableDatum item in value.VariableDatums) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatums.Count);
    }

    private static void WriteSetDataPduFields(ref DisBinaryWriter writer, SetDataPdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32(value.Padding1, "padding1");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatums) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatums) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureSetDataPduFields(in SetDataPdu value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatums) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatums) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadSetDataReliablePduFields(ref DisBinaryReader reader, SetDataReliablePdu value)
    {
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.RequestId = reader.ReadUInt32("requestID");
        value.NumberOfFixedDatumRecords = reader.ReadUInt32("numberOfFixedDatumRecords");
        value.NumberOfVariableDatumRecords = reader.ReadUInt32("numberOfVariableDatumRecords");
        int FixedDatumRecordsCount = CheckedCount(checked((int)value.NumberOfFixedDatumRecords), reader.Remaining, "fixedDatumRecords");
        value.FixedDatumRecords = new List<FixedDatum>(FixedDatumRecordsCount);
        for (int index = 0; index < FixedDatumRecordsCount; index++)
            value.FixedDatumRecords.Add(ReadFixedDatum(ref reader));
        int VariableDatumRecordsCount = CheckedCount(checked((int)value.NumberOfVariableDatumRecords), reader.Remaining, "variableDatumRecords");
        value.VariableDatumRecords = new List<VariableDatum>(VariableDatumRecordsCount);
        for (int index = 0; index < VariableDatumRecordsCount; index++)
            value.VariableDatumRecords.Add(ReadVariableDatum(ref reader));
    }

    private static void PrepareSetDataReliablePduFields(SetDataReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.FixedDatumRecords);
        foreach (FixedDatum item in value.FixedDatumRecords) PrepareFixedDatum(item);
        value.NumberOfFixedDatumRecords = checked((uint)value.FixedDatumRecords.Count);
        ArgumentNullException.ThrowIfNull(value.VariableDatumRecords);
        foreach (VariableDatum item in value.VariableDatumRecords) PrepareVariableDatum(item);
        value.NumberOfVariableDatumRecords = checked((uint)value.VariableDatumRecords.Count);
    }

    private static void WriteSetDataReliablePduFields(ref DisBinaryWriter writer, SetDataReliablePdu value)
    {
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteUInt32(value.NumberOfFixedDatumRecords, "numberOfFixedDatumRecords");
        writer.WriteUInt32(value.NumberOfVariableDatumRecords, "numberOfVariableDatumRecords");
        foreach (FixedDatum item in value.FixedDatumRecords) WriteFixedDatum(ref writer, item);
        foreach (VariableDatum item in value.VariableDatumRecords) WriteVariableDatum(ref writer, item);
    }

    private static void MeasureSetDataReliablePduFields(in SetDataReliablePdu value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
        foreach (FixedDatum item in value.FixedDatumRecords) MeasureFixedDatum(item, ref offset);
        foreach (VariableDatum item in value.VariableDatumRecords) MeasureVariableDatum(item, ref offset);
    }

    private static void ReadSetRecordReliablePduFields(ref DisBinaryReader reader, SetRecordReliablePdu value)
    {
        value.RequestId = reader.ReadUInt32("requestID");
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.Pad3 = reader.ReadUInt32("pad3");
        value.NumberOfRecordSets = reader.ReadUInt32("numberOfRecordSets");
        int RecordSetsCount = CheckedCount(checked((int)value.NumberOfRecordSets), reader.Remaining, "recordSets");
        value.RecordSets = new List<RecordSpecification>(RecordSetsCount);
        for (int index = 0; index < RecordSetsCount; index++)
            value.RecordSets.Add(ReadRecordSpecification(ref reader));
    }

    private static void PrepareSetRecordReliablePduFields(SetRecordReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSets);
        foreach (RecordSpecification item in value.RecordSets) PrepareRecordSpecification(item);
        value.NumberOfRecordSets = checked((uint)value.RecordSets.Count);
    }

    private static void WriteSetRecordReliablePduFields(ref DisBinaryWriter writer, SetRecordReliablePdu value)
    {
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.Pad3, "pad3");
        writer.WriteUInt32(value.NumberOfRecordSets, "numberOfRecordSets");
        foreach (RecordSpecification item in value.RecordSets) WriteRecordSpecification(ref writer, item);
    }

    private static void MeasureSetRecordReliablePduFields(in SetRecordReliablePdu value, ref int offset)
    {
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
        offset += 4;
        foreach (RecordSpecification item in value.RecordSets) MeasureRecordSpecification(item, ref offset);
    }

    private static ShaftRPM ReadShaftRPM(ref DisBinaryReader reader)
    {
        var value = new ShaftRPM();
        ReadShaftRPMFields(ref reader, value);
        return value;
    }

    private static void ReadShaftRPMFields(ref DisBinaryReader reader, ShaftRPM value)
    {
        value.CurrentRPM = reader.ReadUInt16("currentRPM");
        value.OrderedRPM = reader.ReadUInt16("orderedRPM");
        value.RPMrateOfChange = reader.ReadInt32("RPMrateOfChange");
    }

    private static void PrepareShaftRPM(ShaftRPM value)
    {
        PrepareShaftRPMFields(value);
    }

    private static void PrepareShaftRPMFields(ShaftRPM value)
    {
    }

    private static void WriteShaftRPM(ref DisBinaryWriter writer, ShaftRPM value)
    {
        WriteShaftRPMFields(ref writer, value);
    }

    private static void WriteShaftRPMFields(ref DisBinaryWriter writer, ShaftRPM value)
    {
        writer.WriteUInt16(value.CurrentRPM, "currentRPM");
        writer.WriteUInt16(value.OrderedRPM, "orderedRPM");
        writer.WriteInt32(value.RPMrateOfChange, "RPMrateOfChange");
    }

    private static void MeasureShaftRPM(in ShaftRPM value, ref int offset)
    {
        MeasureShaftRPMFields(value, ref offset);
    }

    private static void MeasureShaftRPMFields(in ShaftRPM value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 4;
    }

    private static void ReadSignalPduFields(ref DisBinaryReader reader, SignalPdu value)
    {
        value.RadioHeader = ReadRadioCommsHeader(ref reader);
        value.EncodingScheme = reader.ReadUInt16("encodingScheme");
        value.TdlType = (SignalTdlType)reader.ReadUInt16("tdlType");
        value.SampleRate = reader.ReadUInt32("sampleRate");
        value.DataBitLength = reader.ReadUInt16("dataBitLength");
        value.SampleCount = reader.ReadUInt16("samples");
        int DataCount = CheckedCount((checked((int)value.DataBitLength) + 7) / 8, reader.Remaining, "data");
        value.Data = new byte[DataCount];
        for (int index = 0; index < DataCount; index++)
            value.Data[index] = reader.ReadByte("data");
        reader.Skip(Padding(reader.Offset, 4), "padTo32");
    }

    private static void PrepareSignalPduFields(SignalPdu value)
    {
        if (value.DataBitLength == 0 && value.Data.Length != 0)
            value.DataBitLength = checked((ushort)(value.Data.Length * 8));
        if ((value.DataBitLength + 7) / 8 != value.Data.Length)
            throw new ArgumentException("DataBitLength must match Data, allowing only unused bits in the final octet.", nameof(value));
        ArgumentNullException.ThrowIfNull(value.RadioHeader);
        PrepareRadioCommsHeader(value.RadioHeader);
        ArgumentNullException.ThrowIfNull(value.Data);
    }

    private static void WriteSignalPduFields(ref DisBinaryWriter writer, SignalPdu value)
    {
        WriteRadioCommsHeader(ref writer, value.RadioHeader);
        writer.WriteUInt16(value.EncodingScheme, "encodingScheme");
        writer.WriteUInt16((ushort)value.TdlType, "tdlType");
        writer.WriteUInt32(value.SampleRate, "sampleRate");
        writer.WriteUInt16(value.DataBitLength, "dataBitLength");
        writer.WriteUInt16(value.SampleCount, "samples");
        foreach (byte item in value.Data) writer.WriteByte(item, "data");
        writer.WriteZeros(Padding(writer.Offset, 4), "padTo32");
    }

    private static void MeasureSignalPduFields(in SignalPdu value, ref int offset)
    {
        MeasureRadioCommsHeader(value.RadioHeader, ref offset);
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 2;
        offset += 2;
        offset += checked(value.Data.Length * 1);
        offset += Padding(offset, 4);
    }

    private static SilentEntitySystem ReadSilentEntitySystem(ref DisBinaryReader reader)
    {
        var value = new SilentEntitySystem();
        ReadSilentEntitySystemFields(ref reader, value);
        return value;
    }

    private static void ReadSilentEntitySystemFields(ref DisBinaryReader reader, SilentEntitySystem value)
    {
        value.NumberOfEntities = reader.ReadUInt16("numberOfEntities");
        value.NumberOfAppearanceRecords = reader.ReadUInt16("numberOfAppearanceRecords");
        value.EntityType = ReadEntityType(ref reader);
        int AppearanceRecordListCount = CheckedCount(checked((int)value.NumberOfAppearanceRecords), reader.Remaining, "appearanceRecordList");
        value.AppearanceRecordList = new uint[AppearanceRecordListCount];
        for (int index = 0; index < AppearanceRecordListCount; index++)
            value.AppearanceRecordList[index] = reader.ReadUInt32("appearanceRecordList");
    }

    private static void PrepareSilentEntitySystem(SilentEntitySystem value)
    {
        PrepareSilentEntitySystemFields(value);
    }

    private static void PrepareSilentEntitySystemFields(SilentEntitySystem value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityType);
        PrepareEntityType(value.EntityType);
        ArgumentNullException.ThrowIfNull(value.AppearanceRecordList);
        value.NumberOfAppearanceRecords = checked((ushort)value.AppearanceRecordList.Length);
    }

    private static void WriteSilentEntitySystem(ref DisBinaryWriter writer, SilentEntitySystem value)
    {
        WriteSilentEntitySystemFields(ref writer, value);
    }

    private static void WriteSilentEntitySystemFields(ref DisBinaryWriter writer, SilentEntitySystem value)
    {
        writer.WriteUInt16(value.NumberOfEntities, "numberOfEntities");
        writer.WriteUInt16(value.NumberOfAppearanceRecords, "numberOfAppearanceRecords");
        WriteEntityType(ref writer, value.EntityType);
        foreach (uint item in value.AppearanceRecordList) writer.WriteUInt32(item, "appearanceRecordList");
    }

    private static void MeasureSilentEntitySystem(in SilentEntitySystem value, ref int offset)
    {
        MeasureSilentEntitySystemFields(value, ref offset);
    }

    private static void MeasureSilentEntitySystemFields(in SilentEntitySystem value, ref int offset)
    {
        offset += 2;
        offset += 2;
        MeasureEntityType(value.EntityType, ref offset);
        offset += checked(value.AppearanceRecordList.Length * 4);
    }

    private static SimulationAddress ReadSimulationAddress(ref DisBinaryReader reader)
    {
        var value = new SimulationAddress();
        ReadSimulationAddressFields(ref reader, value);
        return value;
    }

    private static void ReadSimulationAddressFields(ref DisBinaryReader reader, SimulationAddress value)
    {
        value.Site = reader.ReadUInt16("site");
        value.Application = reader.ReadUInt16("application");
    }

    private static void PrepareSimulationAddress(SimulationAddress value)
    {
        PrepareSimulationAddressFields(value);
    }

    private static void PrepareSimulationAddressFields(SimulationAddress value)
    {
    }

    private static void WriteSimulationAddress(ref DisBinaryWriter writer, SimulationAddress value)
    {
        WriteSimulationAddressFields(ref writer, value);
    }

    private static void WriteSimulationAddressFields(ref DisBinaryWriter writer, SimulationAddress value)
    {
        writer.WriteUInt16(value.Site, "site");
        writer.WriteUInt16(value.Application, "application");
    }

    private static void MeasureSimulationAddress(in SimulationAddress value, ref int offset)
    {
        MeasureSimulationAddressFields(value, ref offset);
    }

    private static void MeasureSimulationAddressFields(in SimulationAddress value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static SimulationIdentifier ReadSimulationIdentifier(ref DisBinaryReader reader)
    {
        var value = new SimulationIdentifier();
        ReadSimulationIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadSimulationIdentifierFields(ref DisBinaryReader reader, SimulationIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.ReferenceNumber = reader.ReadUInt16("referenceNumber");
    }

    private static void PrepareSimulationIdentifier(SimulationIdentifier value)
    {
        PrepareSimulationIdentifierFields(value);
    }

    private static void PrepareSimulationIdentifierFields(SimulationIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteSimulationIdentifier(ref DisBinaryWriter writer, SimulationIdentifier value)
    {
        WriteSimulationIdentifierFields(ref writer, value);
    }

    private static void WriteSimulationIdentifierFields(ref DisBinaryWriter writer, SimulationIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.ReferenceNumber, "referenceNumber");
    }

    private static void MeasureSimulationIdentifier(in SimulationIdentifier value, ref int offset)
    {
        MeasureSimulationIdentifierFields(value, ref offset);
    }

    private static void MeasureSimulationIdentifierFields(in SimulationIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static void ReadSimulationManagementFamilyPduFields(ref DisBinaryReader reader, SimulationManagementFamilyPdu value)
    {
        value.OriginatingId = ReadSimulationIdentifier(ref reader);
        value.ReceivingId = ReadSimulationIdentifier(ref reader);
    }

    private static void PrepareSimulationManagementFamilyPduFields(SimulationManagementFamilyPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OriginatingId);
        PrepareSimulationIdentifier(value.OriginatingId);
        ArgumentNullException.ThrowIfNull(value.ReceivingId);
        PrepareSimulationIdentifier(value.ReceivingId);
    }

    private static void WriteSimulationManagementFamilyPduFields(ref DisBinaryWriter writer, SimulationManagementFamilyPdu value)
    {
        WriteSimulationIdentifier(ref writer, value.OriginatingId);
        WriteSimulationIdentifier(ref writer, value.ReceivingId);
    }

    private static void MeasureSimulationManagementFamilyPduFields(in SimulationManagementFamilyPdu value, ref int offset)
    {
        MeasureSimulationIdentifier(value.OriginatingId, ref offset);
        MeasureSimulationIdentifier(value.ReceivingId, ref offset);
    }

    private static void ReadSimulationManagementWithReliabilityFamilyPduFields(ref DisBinaryReader reader, SimulationManagementWithReliabilityFamilyPdu value)
    {
        value.OriginatingId = ReadSimulationIdentifier(ref reader);
        value.ReceivingId = ReadSimulationIdentifier(ref reader);
    }

    private static void PrepareSimulationManagementWithReliabilityFamilyPduFields(SimulationManagementWithReliabilityFamilyPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OriginatingId);
        PrepareSimulationIdentifier(value.OriginatingId);
        ArgumentNullException.ThrowIfNull(value.ReceivingId);
        PrepareSimulationIdentifier(value.ReceivingId);
    }

    private static void WriteSimulationManagementWithReliabilityFamilyPduFields(ref DisBinaryWriter writer, SimulationManagementWithReliabilityFamilyPdu value)
    {
        WriteSimulationIdentifier(ref writer, value.OriginatingId);
        WriteSimulationIdentifier(ref writer, value.ReceivingId);
    }

    private static void MeasureSimulationManagementWithReliabilityFamilyPduFields(in SimulationManagementWithReliabilityFamilyPdu value, ref int offset)
    {
        MeasureSimulationIdentifier(value.OriginatingId, ref offset);
        MeasureSimulationIdentifier(value.ReceivingId, ref offset);
    }

    private static StandardVariableRecord ReadStandardVariableRecord(ref DisBinaryReader reader)
    {
        var value = new StandardVariableRecord();
        ReadStandardVariableRecordFields(ref reader, value);
        return value;
    }

    private static void ReadStandardVariableRecordFields(ref DisBinaryReader reader, StandardVariableRecord value)
    {
        value.RecordType = (VariableRecordType)reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        int RecordSpecificFieldsCount = CheckedCount(checked((int)value.RecordLength), reader.Remaining, "recordSpecificFields");
        value.RecordSpecificFields = new byte[RecordSpecificFieldsCount];
        for (int index = 0; index < RecordSpecificFieldsCount; index++)
            value.RecordSpecificFields[index] = reader.ReadByte("recordSpecificFields");
        reader.Skip(Padding(reader.Offset, 8), "padding");
    }

    private static void PrepareStandardVariableRecord(StandardVariableRecord value)
    {
        PrepareStandardVariableRecordFields(value);
    }

    private static void PrepareStandardVariableRecordFields(StandardVariableRecord value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificFields);
        value.RecordLength = checked((ushort)value.RecordSpecificFields.Length);
    }

    private static void WriteStandardVariableRecord(ref DisBinaryWriter writer, StandardVariableRecord value)
    {
        WriteStandardVariableRecordFields(ref writer, value);
    }

    private static void WriteStandardVariableRecordFields(ref DisBinaryWriter writer, StandardVariableRecord value)
    {
        writer.WriteUInt32((uint)value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        foreach (byte item in value.RecordSpecificFields) writer.WriteByte(item, "recordSpecificFields");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding");
    }

    private static void MeasureStandardVariableRecord(in StandardVariableRecord value, ref int offset)
    {
        MeasureStandardVariableRecordFields(value, ref offset);
    }

    private static void MeasureStandardVariableRecordFields(in StandardVariableRecord value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += checked(value.RecordSpecificFields.Length * 1);
        offset += Padding(offset, 8);
    }

    private static StandardVariableSpecification ReadStandardVariableSpecification(ref DisBinaryReader reader)
    {
        var value = new StandardVariableSpecification();
        ReadStandardVariableSpecificationFields(ref reader, value);
        return value;
    }

    private static void ReadStandardVariableSpecificationFields(ref DisBinaryReader reader, StandardVariableSpecification value)
    {
        value.NumberOfStandardVariableRecords = reader.ReadUInt16("numberOfStandardVariableRecords");
        int StandardVariablesCount = CheckedCount(checked((int)value.NumberOfStandardVariableRecords), reader.Remaining, "standardVariables");
        value.StandardVariables = new List<StandardVariableRecord>(StandardVariablesCount);
        for (int index = 0; index < StandardVariablesCount; index++)
            value.StandardVariables.Add(ReadStandardVariableRecord(ref reader));
    }

    private static void PrepareStandardVariableSpecification(StandardVariableSpecification value)
    {
        PrepareStandardVariableSpecificationFields(value);
    }

    private static void PrepareStandardVariableSpecificationFields(StandardVariableSpecification value)
    {
        ArgumentNullException.ThrowIfNull(value.StandardVariables);
        foreach (StandardVariableRecord item in value.StandardVariables) PrepareStandardVariableRecord(item);
        value.NumberOfStandardVariableRecords = checked((ushort)value.StandardVariables.Count);
    }

    private static void WriteStandardVariableSpecification(ref DisBinaryWriter writer, StandardVariableSpecification value)
    {
        WriteStandardVariableSpecificationFields(ref writer, value);
    }

    private static void WriteStandardVariableSpecificationFields(ref DisBinaryWriter writer, StandardVariableSpecification value)
    {
        writer.WriteUInt16(value.NumberOfStandardVariableRecords, "numberOfStandardVariableRecords");
        foreach (StandardVariableRecord item in value.StandardVariables) WriteStandardVariableRecord(ref writer, item);
    }

    private static void MeasureStandardVariableSpecification(in StandardVariableSpecification value, ref int offset)
    {
        MeasureStandardVariableSpecificationFields(value, ref offset);
    }

    private static void MeasureStandardVariableSpecificationFields(in StandardVariableSpecification value, ref int offset)
    {
        offset += 2;
        foreach (StandardVariableRecord item in value.StandardVariables) MeasureStandardVariableRecord(item, ref offset);
    }

    private static void ReadStartResumePduFields(ref DisBinaryReader reader, StartResumePdu value)
    {
        value.RealWorldTime = ReadClockTime(ref reader);
        value.SimulationTime = ReadClockTime(ref reader);
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareStartResumePduFields(StartResumePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RealWorldTime);
        PrepareClockTime(value.RealWorldTime);
        ArgumentNullException.ThrowIfNull(value.SimulationTime);
        PrepareClockTime(value.SimulationTime);
    }

    private static void WriteStartResumePduFields(ref DisBinaryWriter writer, StartResumePdu value)
    {
        WriteClockTime(ref writer, value.RealWorldTime);
        WriteClockTime(ref writer, value.SimulationTime);
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureStartResumePduFields(in StartResumePdu value, ref int offset)
    {
        MeasureClockTime(value.RealWorldTime, ref offset);
        MeasureClockTime(value.SimulationTime, ref offset);
        offset += 4;
    }

    private static void ReadStartResumeReliablePduFields(ref DisBinaryReader reader, StartResumeReliablePdu value)
    {
        value.RealWorldTime = ReadClockTime(ref reader);
        value.SimulationTime = ReadClockTime(ref reader);
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.Pad2 = reader.ReadUInt16("pad2");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareStartResumeReliablePduFields(StartResumeReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RealWorldTime);
        PrepareClockTime(value.RealWorldTime);
        ArgumentNullException.ThrowIfNull(value.SimulationTime);
        PrepareClockTime(value.SimulationTime);
    }

    private static void WriteStartResumeReliablePduFields(ref DisBinaryWriter writer, StartResumeReliablePdu value)
    {
        WriteClockTime(ref writer, value.RealWorldTime);
        WriteClockTime(ref writer, value.SimulationTime);
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt16(value.Pad2, "pad2");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureStartResumeReliablePduFields(in StartResumeReliablePdu value, ref int offset)
    {
        MeasureClockTime(value.RealWorldTime, ref offset);
        MeasureClockTime(value.SimulationTime, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
    }

    private static void ReadStopFreezePduFields(ref DisBinaryReader reader, StopFreezePdu value)
    {
        value.RealWorldTime = ReadClockTime(ref reader);
        value.Reason = (StopFreezeReason)reader.ReadByte("reason");
        value.FrozenBehavior = new StopFreezeFrozenBehavior(reader.ReadByte("frozenBehavior"));
        value.Padding1 = reader.ReadUInt16("padding1");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareStopFreezePduFields(StopFreezePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RealWorldTime);
        PrepareClockTime(value.RealWorldTime);
    }

    private static void WriteStopFreezePduFields(ref DisBinaryWriter writer, StopFreezePdu value)
    {
        WriteClockTime(ref writer, value.RealWorldTime);
        writer.WriteByte((byte)value.Reason, "reason");
        writer.WriteByte(value.FrozenBehavior.Value, "frozenBehavior");
        writer.WriteUInt16(value.Padding1, "padding1");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureStopFreezePduFields(in StopFreezePdu value, ref int offset)
    {
        MeasureClockTime(value.RealWorldTime, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 4;
    }

    private static void ReadStopFreezeReliablePduFields(ref DisBinaryReader reader, StopFreezeReliablePdu value)
    {
        value.RealWorldTime = ReadClockTime(ref reader);
        value.Reason = (StopFreezeReason)reader.ReadByte("reason");
        value.FrozenBehavior = new StopFreezeFrozenBehavior(reader.ReadByte("frozenBehavior"));
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.Pad1 = reader.ReadByte("pad1");
        value.RequestId = reader.ReadUInt32("requestID");
    }

    private static void PrepareStopFreezeReliablePduFields(StopFreezeReliablePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RealWorldTime);
        PrepareClockTime(value.RealWorldTime);
    }

    private static void WriteStopFreezeReliablePduFields(ref DisBinaryWriter writer, StopFreezeReliablePdu value)
    {
        WriteClockTime(ref writer, value.RealWorldTime);
        writer.WriteByte((byte)value.Reason, "reason");
        writer.WriteByte(value.FrozenBehavior.Value, "frozenBehavior");
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte(value.Pad1, "pad1");
        writer.WriteUInt32(value.RequestId, "requestID");
    }

    private static void MeasureStopFreezeReliablePduFields(in StopFreezeReliablePdu value, ref int offset)
    {
        MeasureClockTime(value.RealWorldTime, ref offset);
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 4;
    }

    private static StorageFuel ReadStorageFuel(ref DisBinaryReader reader)
    {
        var value = new StorageFuel();
        ReadStorageFuelFields(ref reader, value);
        return value;
    }

    private static void ReadStorageFuelFields(ref DisBinaryReader reader, StorageFuel value)
    {
        value.FuelQuantity = reader.ReadUInt32("fuelQuantity");
        value.FuelMeasurementUnits = (FuelMeasurementUnits)reader.ReadByte("fuelMeasurementUnits");
        value.FuelType = (SupplyFuelType)reader.ReadByte("fuelType");
        value.FuelLocation = (FuelLocation)reader.ReadByte("fuelLocation");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareStorageFuel(StorageFuel value)
    {
        PrepareStorageFuelFields(value);
    }

    private static void PrepareStorageFuelFields(StorageFuel value)
    {
    }

    private static void WriteStorageFuel(ref DisBinaryWriter writer, StorageFuel value)
    {
        WriteStorageFuelFields(ref writer, value);
    }

    private static void WriteStorageFuelFields(ref DisBinaryWriter writer, StorageFuel value)
    {
        writer.WriteUInt32(value.FuelQuantity, "fuelQuantity");
        writer.WriteByte((byte)value.FuelMeasurementUnits, "fuelMeasurementUnits");
        writer.WriteByte((byte)value.FuelType, "fuelType");
        writer.WriteByte((byte)value.FuelLocation, "fuelLocation");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureStorageFuel(in StorageFuel value, ref int offset)
    {
        MeasureStorageFuelFields(value, ref offset);
    }

    private static void MeasureStorageFuelFields(in StorageFuel value, ref int offset)
    {
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static StorageFuelReload ReadStorageFuelReload(ref DisBinaryReader reader)
    {
        var value = new StorageFuelReload();
        ReadStorageFuelReloadFields(ref reader, value);
        return value;
    }

    private static void ReadStorageFuelReloadFields(ref DisBinaryReader reader, StorageFuelReload value)
    {
        value.StandardQuantity = reader.ReadUInt32("standardQuantity");
        value.MaximumQuantity = reader.ReadUInt32("maximumQuantity");
        value.StandardQuantityReloadTime = reader.ReadUInt32("standardQuantityReloadTime");
        value.MaximumQuantityReloadTime = reader.ReadUInt32("maximumQuantityReloadTime");
        value.FuelMeasurementUnits = (FuelMeasurementUnits)reader.ReadByte("fuelMeasurementUnits");
        value.FuelType = (SupplyFuelType)reader.ReadByte("fuelType");
        value.FuelLocation = (FuelLocation)reader.ReadByte("fuelLocation");
        value.Padding = reader.ReadByte("padding");
    }

    private static void PrepareStorageFuelReload(StorageFuelReload value)
    {
        PrepareStorageFuelReloadFields(value);
    }

    private static void PrepareStorageFuelReloadFields(StorageFuelReload value)
    {
    }

    private static void WriteStorageFuelReload(ref DisBinaryWriter writer, StorageFuelReload value)
    {
        WriteStorageFuelReloadFields(ref writer, value);
    }

    private static void WriteStorageFuelReloadFields(ref DisBinaryWriter writer, StorageFuelReload value)
    {
        writer.WriteUInt32(value.StandardQuantity, "standardQuantity");
        writer.WriteUInt32(value.MaximumQuantity, "maximumQuantity");
        writer.WriteUInt32(value.StandardQuantityReloadTime, "standardQuantityReloadTime");
        writer.WriteUInt32(value.MaximumQuantityReloadTime, "maximumQuantityReloadTime");
        writer.WriteByte((byte)value.FuelMeasurementUnits, "fuelMeasurementUnits");
        writer.WriteByte((byte)value.FuelType, "fuelType");
        writer.WriteByte((byte)value.FuelLocation, "fuelLocation");
        writer.WriteByte(value.Padding, "padding");
    }

    private static void MeasureStorageFuelReload(in StorageFuelReload value, ref int offset)
    {
        MeasureStorageFuelReloadFields(value, ref offset);
    }

    private static void MeasureStorageFuelReloadFields(in StorageFuelReload value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
    }

    private static void ReadSupplementalEmissionEntityStatePduFields(ref DisBinaryReader reader, SupplementalEmissionEntityStatePdu value)
    {
        value.OrginatingEntityId = ReadEntityId(ref reader);
        value.InfraredSignatureRepresentationIndex = reader.ReadUInt16("infraredSignatureRepresentationIndex");
        value.AcousticSignatureRepresentationIndex = reader.ReadUInt16("acousticSignatureRepresentationIndex");
        value.RadarCrossSectionSignatureRepresentationIndex = reader.ReadUInt16("radarCrossSectionSignatureRepresentationIndex");
        value.NumberOfPropulsionSystems = reader.ReadUInt16("numberOfPropulsionSystems");
        value.NumberOfVectoringNozzleSystems = reader.ReadUInt16("numberOfVectoringNozzleSystems");
        int PropulsionSystemDataCount = CheckedCount(checked((int)value.NumberOfPropulsionSystems), reader.Remaining, "propulsionSystemData");
        value.PropulsionSystemData = new List<PropulsionSystemData>(PropulsionSystemDataCount);
        for (int index = 0; index < PropulsionSystemDataCount; index++)
            value.PropulsionSystemData.Add(ReadPropulsionSystemData(ref reader));
        int VectoringSystemDataCount = CheckedCount(checked((int)value.NumberOfVectoringNozzleSystems), reader.Remaining, "vectoringSystemData");
        value.VectoringSystemData = new List<VectoringNozzleSystem>(VectoringSystemDataCount);
        for (int index = 0; index < VectoringSystemDataCount; index++)
            value.VectoringSystemData.Add(ReadVectoringNozzleSystem(ref reader));
    }

    private static void PrepareSupplementalEmissionEntityStatePduFields(SupplementalEmissionEntityStatePdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OrginatingEntityId);
        PrepareEntityId(value.OrginatingEntityId);
        ArgumentNullException.ThrowIfNull(value.PropulsionSystemData);
        foreach (PropulsionSystemData item in value.PropulsionSystemData) PreparePropulsionSystemData(item);
        value.NumberOfPropulsionSystems = checked((ushort)value.PropulsionSystemData.Count);
        ArgumentNullException.ThrowIfNull(value.VectoringSystemData);
        foreach (VectoringNozzleSystem item in value.VectoringSystemData) PrepareVectoringNozzleSystem(item);
        value.NumberOfVectoringNozzleSystems = checked((ushort)value.VectoringSystemData.Count);
    }

    private static void WriteSupplementalEmissionEntityStatePduFields(ref DisBinaryWriter writer, SupplementalEmissionEntityStatePdu value)
    {
        WriteEntityId(ref writer, value.OrginatingEntityId);
        writer.WriteUInt16(value.InfraredSignatureRepresentationIndex, "infraredSignatureRepresentationIndex");
        writer.WriteUInt16(value.AcousticSignatureRepresentationIndex, "acousticSignatureRepresentationIndex");
        writer.WriteUInt16(value.RadarCrossSectionSignatureRepresentationIndex, "radarCrossSectionSignatureRepresentationIndex");
        writer.WriteUInt16(value.NumberOfPropulsionSystems, "numberOfPropulsionSystems");
        writer.WriteUInt16(value.NumberOfVectoringNozzleSystems, "numberOfVectoringNozzleSystems");
        foreach (PropulsionSystemData item in value.PropulsionSystemData) WritePropulsionSystemData(ref writer, item);
        foreach (VectoringNozzleSystem item in value.VectoringSystemData) WriteVectoringNozzleSystem(ref writer, item);
    }

    private static void MeasureSupplementalEmissionEntityStatePduFields(in SupplementalEmissionEntityStatePdu value, ref int offset)
    {
        MeasureEntityId(value.OrginatingEntityId, ref offset);
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        offset += 2;
        foreach (PropulsionSystemData item in value.PropulsionSystemData) MeasurePropulsionSystemData(item, ref offset);
        foreach (VectoringNozzleSystem item in value.VectoringSystemData) MeasureVectoringNozzleSystem(item, ref offset);
    }

    private static SupplyQuantity ReadSupplyQuantity(ref DisBinaryReader reader)
    {
        var value = new SupplyQuantity();
        ReadSupplyQuantityFields(ref reader, value);
        return value;
    }

    private static void ReadSupplyQuantityFields(ref DisBinaryReader reader, SupplyQuantity value)
    {
        value.SupplyType = ReadEntityType(ref reader);
        value.Quantity = reader.ReadSingle("quantity");
    }

    private static void PrepareSupplyQuantity(SupplyQuantity value)
    {
        PrepareSupplyQuantityFields(value);
    }

    private static void PrepareSupplyQuantityFields(SupplyQuantity value)
    {
        ArgumentNullException.ThrowIfNull(value.SupplyType);
        PrepareEntityType(value.SupplyType);
    }

    private static void WriteSupplyQuantity(ref DisBinaryWriter writer, SupplyQuantity value)
    {
        WriteSupplyQuantityFields(ref writer, value);
    }

    private static void WriteSupplyQuantityFields(ref DisBinaryWriter writer, SupplyQuantity value)
    {
        WriteEntityType(ref writer, value.SupplyType);
        writer.WriteSingle(value.Quantity, "quantity");
    }

    private static void MeasureSupplyQuantity(in SupplyQuantity value, ref int offset)
    {
        MeasureSupplyQuantityFields(value, ref offset);
    }

    private static void MeasureSupplyQuantityFields(in SupplyQuantity value, ref int offset)
    {
        MeasureEntityType(value.SupplyType, ref offset);
        offset += 4;
    }

    private static void ReadSyntheticEnvironmentFamilyPduFields(ref DisBinaryReader reader, SyntheticEnvironmentFamilyPdu value)
    {
    }

    private static void PrepareSyntheticEnvironmentFamilyPduFields(SyntheticEnvironmentFamilyPdu value)
    {
    }

    private static void WriteSyntheticEnvironmentFamilyPduFields(ref DisBinaryWriter writer, SyntheticEnvironmentFamilyPdu value)
    {
    }

    private static void MeasureSyntheticEnvironmentFamilyPduFields(in SyntheticEnvironmentFamilyPdu value, ref int offset)
    {
    }

    private static SystemIdentifier ReadSystemIdentifier(ref DisBinaryReader reader)
    {
        var value = new SystemIdentifier();
        ReadSystemIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadSystemIdentifierFields(ref DisBinaryReader reader, SystemIdentifier value)
    {
        value.SystemType = (IffSystemType)reader.ReadUInt16("systemType");
        value.SystemName = (IffSystemName)reader.ReadUInt16("systemName");
        value.SystemMode = (IffSystemMode)reader.ReadByte("systemMode");
        value.ChangeOptions = ReadChangeOptions(ref reader);
    }

    private static void PrepareSystemIdentifier(SystemIdentifier value)
    {
        PrepareSystemIdentifierFields(value);
    }

    private static void PrepareSystemIdentifierFields(SystemIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.ChangeOptions);
        PrepareChangeOptions(value.ChangeOptions);
    }

    private static void WriteSystemIdentifier(ref DisBinaryWriter writer, SystemIdentifier value)
    {
        WriteSystemIdentifierFields(ref writer, value);
    }

    private static void WriteSystemIdentifierFields(ref DisBinaryWriter writer, SystemIdentifier value)
    {
        writer.WriteUInt16((ushort)value.SystemType, "systemType");
        writer.WriteUInt16((ushort)value.SystemName, "systemName");
        writer.WriteByte((byte)value.SystemMode, "systemMode");
        WriteChangeOptions(ref writer, value.ChangeOptions);
    }

    private static void MeasureSystemIdentifier(in SystemIdentifier value, ref int offset)
    {
        MeasureSystemIdentifierFields(value, ref offset);
    }

    private static void MeasureSystemIdentifierFields(in SystemIdentifier value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 1;
        MeasureChangeOptions(value.ChangeOptions, ref offset);
    }

    private static void ReadTimeSpacePositionInformationPduFields(ref DisBinaryReader reader, TimeSpacePositionInformationPdu value)
    {
        value.LiveEntityId = ReadEntityId(ref reader);
        value.TSPIFlag = reader.ReadByte("TSPIFlag");
        value.EntityLocation = ReadLiveEntityRelativeWorldCoordinates(ref reader);
        value.EntityLinearVelocity = ReadLiveEntityLinearVelocity(ref reader);
        value.EntityOrientation = ReadLiveEntityOrientation(ref reader);
        value.PositionError = ReadLiveEntityPositionError(ref reader);
        value.OrientationError = ReadLiveEntityOrientationError(ref reader);
        value.DeadReckoningParameters = ReadLiveDeadReckoningParameters(ref reader);
        value.MeasuredSpeed = reader.ReadUInt16("measuredSpeed");
        value.SystemSpecificDataLength = reader.ReadByte("systemSpecificDataLength");
        int SystemSpecificDataCount = CheckedCount(checked((int)value.SystemSpecificDataLength), reader.Remaining, "systemSpecificData");
        value.SystemSpecificData = new byte[SystemSpecificDataCount];
        for (int index = 0; index < SystemSpecificDataCount; index++)
            value.SystemSpecificData[index] = reader.ReadByte("systemSpecificData");
    }

    private static void PrepareTimeSpacePositionInformationPduFields(TimeSpacePositionInformationPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.LiveEntityId);
        PrepareEntityId(value.LiveEntityId);
        ArgumentNullException.ThrowIfNull(value.EntityLocation);
        PrepareLiveEntityRelativeWorldCoordinates(value.EntityLocation);
        ArgumentNullException.ThrowIfNull(value.EntityLinearVelocity);
        PrepareLiveEntityLinearVelocity(value.EntityLinearVelocity);
        ArgumentNullException.ThrowIfNull(value.EntityOrientation);
        PrepareLiveEntityOrientation(value.EntityOrientation);
        ArgumentNullException.ThrowIfNull(value.PositionError);
        PrepareLiveEntityPositionError(value.PositionError);
        ArgumentNullException.ThrowIfNull(value.OrientationError);
        PrepareLiveEntityOrientationError(value.OrientationError);
        ArgumentNullException.ThrowIfNull(value.DeadReckoningParameters);
        PrepareLiveDeadReckoningParameters(value.DeadReckoningParameters);
        ArgumentNullException.ThrowIfNull(value.SystemSpecificData);
        value.SystemSpecificDataLength = checked((byte)value.SystemSpecificData.Length);
    }

    private static void WriteTimeSpacePositionInformationPduFields(ref DisBinaryWriter writer, TimeSpacePositionInformationPdu value)
    {
        WriteEntityId(ref writer, value.LiveEntityId);
        writer.WriteByte(value.TSPIFlag, "TSPIFlag");
        WriteLiveEntityRelativeWorldCoordinates(ref writer, value.EntityLocation);
        WriteLiveEntityLinearVelocity(ref writer, value.EntityLinearVelocity);
        WriteLiveEntityOrientation(ref writer, value.EntityOrientation);
        WriteLiveEntityPositionError(ref writer, value.PositionError);
        WriteLiveEntityOrientationError(ref writer, value.OrientationError);
        WriteLiveDeadReckoningParameters(ref writer, value.DeadReckoningParameters);
        writer.WriteUInt16(value.MeasuredSpeed, "measuredSpeed");
        writer.WriteByte(value.SystemSpecificDataLength, "systemSpecificDataLength");
        foreach (byte item in value.SystemSpecificData) writer.WriteByte(item, "systemSpecificData");
    }

    private static void MeasureTimeSpacePositionInformationPduFields(in TimeSpacePositionInformationPdu value, ref int offset)
    {
        MeasureEntityId(value.LiveEntityId, ref offset);
        offset += 1;
        MeasureLiveEntityRelativeWorldCoordinates(value.EntityLocation, ref offset);
        MeasureLiveEntityLinearVelocity(value.EntityLinearVelocity, ref offset);
        MeasureLiveEntityOrientation(value.EntityOrientation, ref offset);
        MeasureLiveEntityPositionError(value.PositionError, ref offset);
        MeasureLiveEntityOrientationError(value.OrientationError, ref offset);
        MeasureLiveDeadReckoningParameters(value.DeadReckoningParameters, ref offset);
        offset += 2;
        offset += 1;
        offset += checked(value.SystemSpecificData.Length * 1);
    }

    private static TotalRecordSets ReadTotalRecordSets(ref DisBinaryReader reader)
    {
        var value = new TotalRecordSets();
        ReadTotalRecordSetsFields(ref reader, value);
        return value;
    }

    private static void ReadTotalRecordSetsFields(ref DisBinaryReader reader, TotalRecordSets value)
    {
        value.TotalRecordSetsValue = reader.ReadUInt16("totalRecordSets");
        value.Padding = reader.ReadUInt16("padding");
    }

    private static void PrepareTotalRecordSets(TotalRecordSets value)
    {
        PrepareTotalRecordSetsFields(value);
    }

    private static void PrepareTotalRecordSetsFields(TotalRecordSets value)
    {
    }

    private static void WriteTotalRecordSets(ref DisBinaryWriter writer, TotalRecordSets value)
    {
        WriteTotalRecordSetsFields(ref writer, value);
    }

    private static void WriteTotalRecordSetsFields(ref DisBinaryWriter writer, TotalRecordSets value)
    {
        writer.WriteUInt16(value.TotalRecordSetsValue, "totalRecordSets");
        writer.WriteUInt16(value.Padding, "padding");
    }

    private static void MeasureTotalRecordSets(in TotalRecordSets value, ref int offset)
    {
        MeasureTotalRecordSetsFields(value, ref offset);
    }

    private static void MeasureTotalRecordSetsFields(in TotalRecordSets value, ref int offset)
    {
        offset += 2;
        offset += 2;
    }

    private static TrackJamData ReadTrackJamData(ref DisBinaryReader reader)
    {
        var value = new TrackJamData();
        ReadTrackJamDataFields(ref reader, value);
        return value;
    }

    private static void ReadTrackJamDataFields(ref DisBinaryReader reader, TrackJamData value)
    {
        value.EntityId = ReadEntityId(ref reader);
        value.EmitterNumber = reader.ReadByte("emitterNumber");
        value.BeamNumber = reader.ReadByte("beamNumber");
    }

    private static void PrepareTrackJamData(TrackJamData value)
    {
        PrepareTrackJamDataFields(value);
    }

    private static void PrepareTrackJamDataFields(TrackJamData value)
    {
        ArgumentNullException.ThrowIfNull(value.EntityId);
        PrepareEntityId(value.EntityId);
    }

    private static void WriteTrackJamData(ref DisBinaryWriter writer, TrackJamData value)
    {
        WriteTrackJamDataFields(ref writer, value);
    }

    private static void WriteTrackJamDataFields(ref DisBinaryWriter writer, TrackJamData value)
    {
        WriteEntityId(ref writer, value.EntityId);
        writer.WriteByte(value.EmitterNumber, "emitterNumber");
        writer.WriteByte(value.BeamNumber, "beamNumber");
    }

    private static void MeasureTrackJamData(in TrackJamData value, ref int offset)
    {
        MeasureTrackJamDataFields(value, ref offset);
    }

    private static void MeasureTrackJamDataFields(in TrackJamData value, ref int offset)
    {
        MeasureEntityId(value.EntityId, ref offset);
        offset += 1;
        offset += 1;
    }

    private static void ReadTransferOwnershipPduFields(ref DisBinaryReader reader, TransferOwnershipPdu value)
    {
        value.OriginatingEntityId = ReadEntityId(ref reader);
        value.ReceivingEntityId = ReadEntityId(ref reader);
        value.RequestId = reader.ReadUInt32("requestID");
        value.RequiredReliabilityService = (RequiredReliabilityService)reader.ReadByte("requiredReliabilityService");
        value.TransferType = (TransferControlTransferType)reader.ReadByte("transferType");
        value.TransferEntityId = ReadEntityId(ref reader);
        value.RecordSets = ReadRecordSpecification(ref reader);
    }

    private static void PrepareTransferOwnershipPduFields(TransferOwnershipPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.OriginatingEntityId);
        PrepareEntityId(value.OriginatingEntityId);
        ArgumentNullException.ThrowIfNull(value.ReceivingEntityId);
        PrepareEntityId(value.ReceivingEntityId);
        ArgumentNullException.ThrowIfNull(value.TransferEntityId);
        PrepareEntityId(value.TransferEntityId);
        ArgumentNullException.ThrowIfNull(value.RecordSets);
        PrepareRecordSpecification(value.RecordSets);
    }

    private static void WriteTransferOwnershipPduFields(ref DisBinaryWriter writer, TransferOwnershipPdu value)
    {
        WriteEntityId(ref writer, value.OriginatingEntityId);
        WriteEntityId(ref writer, value.ReceivingEntityId);
        writer.WriteUInt32(value.RequestId, "requestID");
        writer.WriteByte((byte)value.RequiredReliabilityService, "requiredReliabilityService");
        writer.WriteByte((byte)value.TransferType, "transferType");
        WriteEntityId(ref writer, value.TransferEntityId);
        WriteRecordSpecification(ref writer, value.RecordSets);
    }

    private static void MeasureTransferOwnershipPduFields(in TransferOwnershipPdu value, ref int offset)
    {
        MeasureEntityId(value.OriginatingEntityId, ref offset);
        MeasureEntityId(value.ReceivingEntityId, ref offset);
        offset += 4;
        offset += 1;
        offset += 1;
        MeasureEntityId(value.TransferEntityId, ref offset);
        MeasureRecordSpecification(value.RecordSets, ref offset);
    }

    private static void ReadTransmitterPduFields(ref DisBinaryReader reader, TransmitterPdu value)
    {
        value.RadioHeader = ReadRadioCommsHeader(ref reader);
        value.RadioEntityType = ReadRadioType(ref reader);
        value.TransmitState = (TransmitterTransmitState)reader.ReadByte("transmitState");
        value.InputSource = (TransmitterInputSource)reader.ReadByte("inputSource");
        value.VariableTransmitterParameterCount = reader.ReadUInt16("variableTransmitterParameterCount");
        value.AntennaLocation = ReadVector3Double(ref reader);
        value.RelativeAntennaLocation = ReadVector3Float(ref reader);
        value.AntennaPatternType = (TransmitterAntennaPatternType)reader.ReadUInt16("antennaPatternType");
        value.AntennaPatternCount = reader.ReadUInt16("antennaPatternCount");
        value.Frequency = reader.ReadUInt64("frequency");
        value.TransmitFrequencyBandwidth = reader.ReadSingle("transmitFrequencyBandwidth");
        value.Power = reader.ReadSingle("power");
        value.ModulationType = ReadModulationType(ref reader);
        value.CryptoSystem = (TransmitterCryptoSystem)reader.ReadUInt16("cryptoSystem");
        value.CryptoKeyId = reader.ReadUInt16("cryptoKeyId");
        value.ModulationParameterCount = reader.ReadByte("modulationParameterCount");
        value.Padding1 = reader.ReadByte("padding1");
        value.Padding2 = reader.ReadUInt16("padding2");
        int ModulationParametersCount = CheckedCount(checked((int)value.ModulationParameterCount), reader.Remaining, "modulationParameters");
        value.ModulationParameters = new byte[ModulationParametersCount];
        for (int index = 0; index < ModulationParametersCount; index++)
            value.ModulationParameters[index] = reader.ReadByte("modulationParameters");
        int AntennaPatternParametersCount = CheckedCount(checked((int)value.AntennaPatternCount), reader.Remaining, "antennaPatternParameters");
        value.AntennaPatternParameters = new byte[AntennaPatternParametersCount];
        for (int index = 0; index < AntennaPatternParametersCount; index++)
            value.AntennaPatternParameters[index] = reader.ReadByte("antennaPatternParameters");
        int VariableTransmitterParametersCount = CheckedCount(checked((int)value.VariableTransmitterParameterCount), reader.Remaining, "variableTransmitterParameters");
        value.VariableTransmitterParameters = new List<VariableTransmitterParameters>(VariableTransmitterParametersCount);
        for (int index = 0; index < VariableTransmitterParametersCount; index++)
            value.VariableTransmitterParameters.Add(ReadVariableTransmitterParameters(ref reader));
    }

    private static void PrepareTransmitterPduFields(TransmitterPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.RadioHeader);
        PrepareRadioCommsHeader(value.RadioHeader);
        ArgumentNullException.ThrowIfNull(value.RadioEntityType);
        PrepareRadioType(value.RadioEntityType);
        ArgumentNullException.ThrowIfNull(value.AntennaLocation);
        PrepareVector3Double(value.AntennaLocation);
        ArgumentNullException.ThrowIfNull(value.RelativeAntennaLocation);
        PrepareVector3Float(value.RelativeAntennaLocation);
        ArgumentNullException.ThrowIfNull(value.ModulationType);
        PrepareModulationType(value.ModulationType);
        ArgumentNullException.ThrowIfNull(value.ModulationParameters);
        value.ModulationParameterCount = checked((byte)value.ModulationParameters.Length);
        ArgumentNullException.ThrowIfNull(value.AntennaPatternParameters);
        value.AntennaPatternCount = checked((ushort)value.AntennaPatternParameters.Length);
        ArgumentNullException.ThrowIfNull(value.VariableTransmitterParameters);
        foreach (VariableTransmitterParameters item in value.VariableTransmitterParameters) PrepareVariableTransmitterParameters(item);
        value.VariableTransmitterParameterCount = checked((ushort)value.VariableTransmitterParameters.Count);
    }

    private static void WriteTransmitterPduFields(ref DisBinaryWriter writer, TransmitterPdu value)
    {
        WriteRadioCommsHeader(ref writer, value.RadioHeader);
        WriteRadioType(ref writer, value.RadioEntityType);
        writer.WriteByte((byte)value.TransmitState, "transmitState");
        writer.WriteByte((byte)value.InputSource, "inputSource");
        writer.WriteUInt16(value.VariableTransmitterParameterCount, "variableTransmitterParameterCount");
        WriteVector3Double(ref writer, value.AntennaLocation);
        WriteVector3Float(ref writer, value.RelativeAntennaLocation);
        writer.WriteUInt16((ushort)value.AntennaPatternType, "antennaPatternType");
        writer.WriteUInt16(value.AntennaPatternCount, "antennaPatternCount");
        writer.WriteUInt64(value.Frequency, "frequency");
        writer.WriteSingle(value.TransmitFrequencyBandwidth, "transmitFrequencyBandwidth");
        writer.WriteSingle(value.Power, "power");
        WriteModulationType(ref writer, value.ModulationType);
        writer.WriteUInt16((ushort)value.CryptoSystem, "cryptoSystem");
        writer.WriteUInt16(value.CryptoKeyId, "cryptoKeyId");
        writer.WriteByte(value.ModulationParameterCount, "modulationParameterCount");
        writer.WriteByte(value.Padding1, "padding1");
        writer.WriteUInt16(value.Padding2, "padding2");
        foreach (byte item in value.ModulationParameters) writer.WriteByte(item, "modulationParameters");
        foreach (byte item in value.AntennaPatternParameters) writer.WriteByte(item, "antennaPatternParameters");
        foreach (VariableTransmitterParameters item in value.VariableTransmitterParameters) WriteVariableTransmitterParameters(ref writer, item);
    }

    private static void MeasureTransmitterPduFields(in TransmitterPdu value, ref int offset)
    {
        MeasureRadioCommsHeader(value.RadioHeader, ref offset);
        MeasureRadioType(value.RadioEntityType, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        MeasureVector3Double(value.AntennaLocation, ref offset);
        MeasureVector3Float(value.RelativeAntennaLocation, ref offset);
        offset += 2;
        offset += 2;
        offset += 8;
        offset += 4;
        offset += 4;
        MeasureModulationType(value.ModulationType, ref offset);
        offset += 2;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 2;
        offset += checked(value.ModulationParameters.Length * 1);
        offset += checked(value.AntennaPatternParameters.Length * 1);
        foreach (VariableTransmitterParameters item in value.VariableTransmitterParameters) MeasureVariableTransmitterParameters(item, ref offset);
    }

    private static UABeam ReadUABeam(ref DisBinaryReader reader)
    {
        var value = new UABeam();
        ReadUABeamFields(ref reader, value);
        return value;
    }

    private static void ReadUABeamFields(ref DisBinaryReader reader, UABeam value)
    {
        value.BeamDataLength = reader.ReadByte("beamDataLength");
        value.BeamNumber = reader.ReadByte("beamNumber");
        value.Padding = reader.ReadUInt16("padding");
        value.FundamentalParameterData = ReadUAFundamentalParameter(ref reader);
    }

    private static void PrepareUABeam(UABeam value)
    {
        PrepareUABeamFields(value);
    }

    private static void PrepareUABeamFields(UABeam value)
    {
        ArgumentNullException.ThrowIfNull(value.FundamentalParameterData);
        PrepareUAFundamentalParameter(value.FundamentalParameterData);
    }

    private static void WriteUABeam(ref DisBinaryWriter writer, UABeam value)
    {
        WriteUABeamFields(ref writer, value);
    }

    private static void WriteUABeamFields(ref DisBinaryWriter writer, UABeam value)
    {
        writer.WriteByte(value.BeamDataLength, "beamDataLength");
        writer.WriteByte(value.BeamNumber, "beamNumber");
        writer.WriteUInt16(value.Padding, "padding");
        WriteUAFundamentalParameter(ref writer, value.FundamentalParameterData);
    }

    private static void MeasureUABeam(in UABeam value, ref int offset)
    {
        MeasureUABeamFields(value, ref offset);
    }

    private static void MeasureUABeamFields(in UABeam value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        MeasureUAFundamentalParameter(value.FundamentalParameterData, ref offset);
    }

    private static UAEmitter ReadUAEmitter(ref DisBinaryReader reader)
    {
        var value = new UAEmitter();
        ReadUAEmitterFields(ref reader, value);
        return value;
    }

    private static void ReadUAEmitterFields(ref DisBinaryReader reader, UAEmitter value)
    {
        value.SystemDataLength = reader.ReadByte("systemDataLength");
        value.NumberOfBeams = reader.ReadByte("numberOfBeams");
        value.Padding = reader.ReadUInt16("padding");
        value.AcousticEmitter = ReadAcousticEmitter(ref reader);
        value.Location = ReadVector3Float(ref reader);
        int BeamsCount = CheckedCount(checked((int)value.NumberOfBeams), reader.Remaining, "beams");
        value.Beams = new List<UABeam>(BeamsCount);
        for (int index = 0; index < BeamsCount; index++)
            value.Beams.Add(ReadUABeam(ref reader));
    }

    private static void PrepareUAEmitter(UAEmitter value)
    {
        PrepareUAEmitterFields(value);
    }

    private static void PrepareUAEmitterFields(UAEmitter value)
    {
        ArgumentNullException.ThrowIfNull(value.AcousticEmitter);
        PrepareAcousticEmitter(value.AcousticEmitter);
        ArgumentNullException.ThrowIfNull(value.Location);
        PrepareVector3Float(value.Location);
        ArgumentNullException.ThrowIfNull(value.Beams);
        foreach (UABeam item in value.Beams) PrepareUABeam(item);
        value.NumberOfBeams = checked((byte)value.Beams.Count);
    }

    private static void WriteUAEmitter(ref DisBinaryWriter writer, UAEmitter value)
    {
        WriteUAEmitterFields(ref writer, value);
    }

    private static void WriteUAEmitterFields(ref DisBinaryWriter writer, UAEmitter value)
    {
        writer.WriteByte(value.SystemDataLength, "systemDataLength");
        writer.WriteByte(value.NumberOfBeams, "numberOfBeams");
        writer.WriteUInt16(value.Padding, "padding");
        WriteAcousticEmitter(ref writer, value.AcousticEmitter);
        WriteVector3Float(ref writer, value.Location);
        foreach (UABeam item in value.Beams) WriteUABeam(ref writer, item);
    }

    private static void MeasureUAEmitter(in UAEmitter value, ref int offset)
    {
        MeasureUAEmitterFields(value, ref offset);
    }

    private static void MeasureUAEmitterFields(in UAEmitter value, ref int offset)
    {
        offset += 1;
        offset += 1;
        offset += 2;
        MeasureAcousticEmitter(value.AcousticEmitter, ref offset);
        MeasureVector3Float(value.Location, ref offset);
        foreach (UABeam item in value.Beams) MeasureUABeam(item, ref offset);
    }

    private static UAFundamentalParameter ReadUAFundamentalParameter(ref DisBinaryReader reader)
    {
        var value = new UAFundamentalParameter();
        ReadUAFundamentalParameterFields(ref reader, value);
        return value;
    }

    private static void ReadUAFundamentalParameterFields(ref DisBinaryReader reader, UAFundamentalParameter value)
    {
        value.ActiveEmissionParameterIndex = (UaActiveEmissionParameterIndex)reader.ReadUInt16("activeEmissionParameterIndex");
        value.ScanPattern = (UaScanPattern)reader.ReadUInt16("scanPattern");
        value.BeamCenterAzimuthHorizontal = reader.ReadSingle("beamCenterAzimuthHorizontal");
        value.AzimuthalBeamwidthHorizontal = reader.ReadSingle("azimuthalBeamwidthHorizontal");
        value.BeamCenterDepressionElevation = reader.ReadSingle("beamCenterDepressionElevation");
        value.DepressionElevationBeamWidth = reader.ReadSingle("depressionElevationBeamWidth");
    }

    private static void PrepareUAFundamentalParameter(UAFundamentalParameter value)
    {
        PrepareUAFundamentalParameterFields(value);
    }

    private static void PrepareUAFundamentalParameterFields(UAFundamentalParameter value)
    {
    }

    private static void WriteUAFundamentalParameter(ref DisBinaryWriter writer, UAFundamentalParameter value)
    {
        WriteUAFundamentalParameterFields(ref writer, value);
    }

    private static void WriteUAFundamentalParameterFields(ref DisBinaryWriter writer, UAFundamentalParameter value)
    {
        writer.WriteUInt16((ushort)value.ActiveEmissionParameterIndex, "activeEmissionParameterIndex");
        writer.WriteUInt16((ushort)value.ScanPattern, "scanPattern");
        writer.WriteSingle(value.BeamCenterAzimuthHorizontal, "beamCenterAzimuthHorizontal");
        writer.WriteSingle(value.AzimuthalBeamwidthHorizontal, "azimuthalBeamwidthHorizontal");
        writer.WriteSingle(value.BeamCenterDepressionElevation, "beamCenterDepressionElevation");
        writer.WriteSingle(value.DepressionElevationBeamWidth, "depressionElevationBeamWidth");
    }

    private static void MeasureUAFundamentalParameter(in UAFundamentalParameter value, ref int offset)
    {
        MeasureUAFundamentalParameterFields(value, ref offset);
    }

    private static void MeasureUAFundamentalParameterFields(in UAFundamentalParameter value, ref int offset)
    {
        offset += 2;
        offset += 2;
        offset += 4;
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static UnattachedIdentifier ReadUnattachedIdentifier(ref DisBinaryReader reader)
    {
        var value = new UnattachedIdentifier();
        ReadUnattachedIdentifierFields(ref reader, value);
        return value;
    }

    private static void ReadUnattachedIdentifierFields(ref DisBinaryReader reader, UnattachedIdentifier value)
    {
        value.SimulationAddress = ReadSimulationAddress(ref reader);
        value.ReferenceNumber = reader.ReadUInt16("referenceNumber");
    }

    private static void PrepareUnattachedIdentifier(UnattachedIdentifier value)
    {
        PrepareUnattachedIdentifierFields(value);
    }

    private static void PrepareUnattachedIdentifierFields(UnattachedIdentifier value)
    {
        ArgumentNullException.ThrowIfNull(value.SimulationAddress);
        PrepareSimulationAddress(value.SimulationAddress);
    }

    private static void WriteUnattachedIdentifier(ref DisBinaryWriter writer, UnattachedIdentifier value)
    {
        WriteUnattachedIdentifierFields(ref writer, value);
    }

    private static void WriteUnattachedIdentifierFields(ref DisBinaryWriter writer, UnattachedIdentifier value)
    {
        WriteSimulationAddress(ref writer, value.SimulationAddress);
        writer.WriteUInt16(value.ReferenceNumber, "referenceNumber");
    }

    private static void MeasureUnattachedIdentifier(in UnattachedIdentifier value, ref int offset)
    {
        MeasureUnattachedIdentifierFields(value, ref offset);
    }

    private static void MeasureUnattachedIdentifierFields(in UnattachedIdentifier value, ref int offset)
    {
        MeasureSimulationAddress(value.SimulationAddress, ref offset);
        offset += 2;
    }

    private static void ReadUnderwaterAcousticPduFields(ref DisBinaryReader reader, UnderwaterAcousticPdu value)
    {
        value.EmittingEntityId = ReadEntityId(ref reader);
        value.EventId = ReadEventIdentifier(ref reader);
        value.StateChangeIndicator = (UaStateChangeUpdateIndicator)reader.ReadByte("stateChangeIndicator");
        value.Pad = reader.ReadByte("pad");
        value.PassiveParameterIndex = (UaPassiveParameterIndex)reader.ReadUInt16("passiveParameterIndex");
        value.PropulsionPlantConfiguration = reader.ReadByte("propulsionPlantConfiguration");
        value.NumberOfShafts = reader.ReadByte("numberOfShafts");
        value.NumberOfAPAs = reader.ReadByte("numberOfAPAs");
        value.NumberOfUAEmitterSystems = reader.ReadByte("numberOfUAEmitterSystems");
        int ShaftRPMsCount = CheckedCount(checked((int)value.NumberOfShafts), reader.Remaining, "shaftRPMs");
        value.ShaftRPMs = new List<ShaftRPM>(ShaftRPMsCount);
        for (int index = 0; index < ShaftRPMsCount; index++)
            value.ShaftRPMs.Add(ReadShaftRPM(ref reader));
        int ApaDataCount = CheckedCount(checked((int)value.NumberOfAPAs), reader.Remaining, "apaData");
        value.ApaData = new List<APA>(ApaDataCount);
        for (int index = 0; index < ApaDataCount; index++)
            value.ApaData.Add(ReadAPA(ref reader));
        int EmitterSystemsCount = CheckedCount(checked((int)value.NumberOfUAEmitterSystems), reader.Remaining, "emitterSystems");
        value.EmitterSystems = new List<UAEmitter>(EmitterSystemsCount);
        for (int index = 0; index < EmitterSystemsCount; index++)
            value.EmitterSystems.Add(ReadUAEmitter(ref reader));
    }

    private static void PrepareUnderwaterAcousticPduFields(UnderwaterAcousticPdu value)
    {
        ArgumentNullException.ThrowIfNull(value.EmittingEntityId);
        PrepareEntityId(value.EmittingEntityId);
        ArgumentNullException.ThrowIfNull(value.EventId);
        PrepareEventIdentifier(value.EventId);
        ArgumentNullException.ThrowIfNull(value.ShaftRPMs);
        foreach (ShaftRPM item in value.ShaftRPMs) PrepareShaftRPM(item);
        value.NumberOfShafts = checked((byte)value.ShaftRPMs.Count);
        ArgumentNullException.ThrowIfNull(value.ApaData);
        foreach (APA item in value.ApaData) PrepareAPA(item);
        value.NumberOfAPAs = checked((byte)value.ApaData.Count);
        ArgumentNullException.ThrowIfNull(value.EmitterSystems);
        foreach (UAEmitter item in value.EmitterSystems) PrepareUAEmitter(item);
        value.NumberOfUAEmitterSystems = checked((byte)value.EmitterSystems.Count);
    }

    private static void WriteUnderwaterAcousticPduFields(ref DisBinaryWriter writer, UnderwaterAcousticPdu value)
    {
        WriteEntityId(ref writer, value.EmittingEntityId);
        WriteEventIdentifier(ref writer, value.EventId);
        writer.WriteByte((byte)value.StateChangeIndicator, "stateChangeIndicator");
        writer.WriteByte(value.Pad, "pad");
        writer.WriteUInt16((ushort)value.PassiveParameterIndex, "passiveParameterIndex");
        writer.WriteByte(value.PropulsionPlantConfiguration, "propulsionPlantConfiguration");
        writer.WriteByte(value.NumberOfShafts, "numberOfShafts");
        writer.WriteByte(value.NumberOfAPAs, "numberOfAPAs");
        writer.WriteByte(value.NumberOfUAEmitterSystems, "numberOfUAEmitterSystems");
        foreach (ShaftRPM item in value.ShaftRPMs) WriteShaftRPM(ref writer, item);
        foreach (APA item in value.ApaData) WriteAPA(ref writer, item);
        foreach (UAEmitter item in value.EmitterSystems) WriteUAEmitter(ref writer, item);
    }

    private static void MeasureUnderwaterAcousticPduFields(in UnderwaterAcousticPdu value, ref int offset)
    {
        MeasureEntityId(value.EmittingEntityId, ref offset);
        MeasureEventIdentifier(value.EventId, ref offset);
        offset += 1;
        offset += 1;
        offset += 2;
        offset += 1;
        offset += 1;
        offset += 1;
        offset += 1;
        foreach (ShaftRPM item in value.ShaftRPMs) MeasureShaftRPM(item, ref offset);
        foreach (APA item in value.ApaData) MeasureAPA(item, ref offset);
        foreach (UAEmitter item in value.EmitterSystems) MeasureUAEmitter(item, ref offset);
    }

    private static UnsignedDISInteger ReadUnsignedDISInteger(ref DisBinaryReader reader)
    {
        var value = new UnsignedDISInteger();
        ReadUnsignedDISIntegerFields(ref reader, value);
        return value;
    }

    private static void ReadUnsignedDISIntegerFields(ref DisBinaryReader reader, UnsignedDISInteger value)
    {
        value.Val = reader.ReadUInt32("val");
    }

    private static void PrepareUnsignedDISInteger(UnsignedDISInteger value)
    {
        PrepareUnsignedDISIntegerFields(value);
    }

    private static void PrepareUnsignedDISIntegerFields(UnsignedDISInteger value)
    {
    }

    private static void WriteUnsignedDISInteger(ref DisBinaryWriter writer, UnsignedDISInteger value)
    {
        WriteUnsignedDISIntegerFields(ref writer, value);
    }

    private static void WriteUnsignedDISIntegerFields(ref DisBinaryWriter writer, UnsignedDISInteger value)
    {
        writer.WriteUInt32(value.Val, "val");
    }

    private static void MeasureUnsignedDISInteger(in UnsignedDISInteger value, ref int offset)
    {
        MeasureUnsignedDISIntegerFields(value, ref offset);
    }

    private static void MeasureUnsignedDISIntegerFields(in UnsignedDISInteger value, ref int offset)
    {
        offset += 4;
    }

    private static VariableDatum ReadVariableDatum(ref DisBinaryReader reader)
    {
        var value = new VariableDatum();
        ReadVariableDatumFields(ref reader, value);
        return value;
    }

    private static void ReadVariableDatumFields(ref DisBinaryReader reader, VariableDatum value)
    {
        value.VariableDatumId = (VariableRecordType)reader.ReadUInt32("variableDatumID");
        value.VariableDatumLength = reader.ReadUInt32("variableDatumLength");
        int VariableDatumValueCount = CheckedCount((checked((int)value.VariableDatumLength) + 7) / 8, reader.Remaining, "variableDatumValue");
        value.VariableDatumValue = new byte[VariableDatumValueCount];
        for (int index = 0; index < VariableDatumValueCount; index++)
            value.VariableDatumValue[index] = reader.ReadByte("variableDatumValue");
        reader.Skip(Padding(reader.Offset, 8), "padding");
    }

    private static void PrepareVariableDatum(VariableDatum value)
    {
        PrepareVariableDatumFields(value);
    }

    private static void PrepareVariableDatumFields(VariableDatum value)
    {
        ArgumentNullException.ThrowIfNull(value.VariableDatumValue);
        value.VariableDatumLength = checked((uint)checked(value.VariableDatumValue.Length * 8));
    }

    private static void WriteVariableDatum(ref DisBinaryWriter writer, VariableDatum value)
    {
        WriteVariableDatumFields(ref writer, value);
    }

    private static void WriteVariableDatumFields(ref DisBinaryWriter writer, VariableDatum value)
    {
        writer.WriteUInt32((uint)value.VariableDatumId, "variableDatumID");
        writer.WriteUInt32(value.VariableDatumLength, "variableDatumLength");
        foreach (byte item in value.VariableDatumValue) writer.WriteByte(item, "variableDatumValue");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding");
    }

    private static void MeasureVariableDatum(in VariableDatum value, ref int offset)
    {
        MeasureVariableDatumFields(value, ref offset);
    }

    private static void MeasureVariableDatumFields(in VariableDatum value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += checked(value.VariableDatumValue.Length * 1);
        offset += Padding(offset, 8);
    }

    private static VariableParameter ReadVariableParameter(ref DisBinaryReader reader)
    {
        var value = new VariableParameter();
        ReadVariableParameterFields(ref reader, value);
        return value;
    }

    private static void ReadVariableParameterFields(ref DisBinaryReader reader, VariableParameter value)
    {
        value.RecordType = (VariableParameterRecordType)reader.ReadByte("recordType");
        int RecordSpecificFieldsCount = CheckedCount(15, reader.Remaining, "recordSpecificFields");
        value.RecordSpecificFields = new byte[RecordSpecificFieldsCount];
        for (int index = 0; index < RecordSpecificFieldsCount; index++)
            value.RecordSpecificFields[index] = reader.ReadByte("recordSpecificFields");
    }

    private static void PrepareVariableParameter(VariableParameter value)
    {
        PrepareVariableParameterFields(value);
    }

    private static void PrepareVariableParameterFields(VariableParameter value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificFields);
    }

    private static void WriteVariableParameter(ref DisBinaryWriter writer, VariableParameter value)
    {
        WriteVariableParameterFields(ref writer, value);
    }

    private static void WriteVariableParameterFields(ref DisBinaryWriter writer, VariableParameter value)
    {
        writer.WriteByte((byte)value.RecordType, "recordType");
        foreach (byte item in value.RecordSpecificFields) writer.WriteByte(item, "recordSpecificFields");
    }

    private static void MeasureVariableParameter(in VariableParameter value, ref int offset)
    {
        MeasureVariableParameterFields(value, ref offset);
    }

    private static void MeasureVariableParameterFields(in VariableParameter value, ref int offset)
    {
        offset += 1;
        offset += checked(value.RecordSpecificFields.Length * 1);
    }

    private static VariableTransmitterParameters ReadVariableTransmitterParameters(ref DisBinaryReader reader)
    {
        var value = new VariableTransmitterParameters();
        ReadVariableTransmitterParametersFields(ref reader, value);
        return value;
    }

    private static void ReadVariableTransmitterParametersFields(ref DisBinaryReader reader, VariableTransmitterParameters value)
    {
        value.RecordType = (VariableRecordType)reader.ReadUInt32("recordType");
        value.RecordLength = reader.ReadUInt16("recordLength");
        int RecordSpecificFieldsCount = CheckedCount(Math.Max(0, checked((int)value.RecordLength) - 4), reader.Remaining, "recordSpecificFields");
        value.RecordSpecificFields = new byte[RecordSpecificFieldsCount];
        for (int index = 0; index < RecordSpecificFieldsCount; index++)
            value.RecordSpecificFields[index] = reader.ReadByte("recordSpecificFields");
        reader.Skip(Padding(reader.Offset, 8), "padding");
    }

    private static void PrepareVariableTransmitterParameters(VariableTransmitterParameters value)
    {
        PrepareVariableTransmitterParametersFields(value);
    }

    private static void PrepareVariableTransmitterParametersFields(VariableTransmitterParameters value)
    {
        ArgumentNullException.ThrowIfNull(value.RecordSpecificFields);
    }

    private static void WriteVariableTransmitterParameters(ref DisBinaryWriter writer, VariableTransmitterParameters value)
    {
        WriteVariableTransmitterParametersFields(ref writer, value);
    }

    private static void WriteVariableTransmitterParametersFields(ref DisBinaryWriter writer, VariableTransmitterParameters value)
    {
        writer.WriteUInt32((uint)value.RecordType, "recordType");
        writer.WriteUInt16(value.RecordLength, "recordLength");
        foreach (byte item in value.RecordSpecificFields) writer.WriteByte(item, "recordSpecificFields");
        writer.WriteZeros(Padding(writer.Offset, 8), "padding");
    }

    private static void MeasureVariableTransmitterParameters(in VariableTransmitterParameters value, ref int offset)
    {
        MeasureVariableTransmitterParametersFields(value, ref offset);
    }

    private static void MeasureVariableTransmitterParametersFields(in VariableTransmitterParameters value, ref int offset)
    {
        offset += 4;
        offset += 2;
        offset += checked(value.RecordSpecificFields.Length * 1);
        offset += Padding(offset, 8);
    }

    private static Vector2Float ReadVector2Float(ref DisBinaryReader reader)
    {
        var value = new Vector2Float();
        ReadVector2FloatFields(ref reader, value);
        return value;
    }

    private static void ReadVector2FloatFields(ref DisBinaryReader reader, Vector2Float value)
    {
        value.X = reader.ReadSingle("x");
        value.Y = reader.ReadSingle("y");
    }

    private static void PrepareVector2Float(Vector2Float value)
    {
        PrepareVector2FloatFields(value);
    }

    private static void PrepareVector2FloatFields(Vector2Float value)
    {
    }

    private static void WriteVector2Float(ref DisBinaryWriter writer, Vector2Float value)
    {
        WriteVector2FloatFields(ref writer, value);
    }

    private static void WriteVector2FloatFields(ref DisBinaryWriter writer, Vector2Float value)
    {
        writer.WriteSingle(value.X, "x");
        writer.WriteSingle(value.Y, "y");
    }

    private static void MeasureVector2Float(in Vector2Float value, ref int offset)
    {
        MeasureVector2FloatFields(value, ref offset);
    }

    private static void MeasureVector2FloatFields(in Vector2Float value, ref int offset)
    {
        offset += 4;
        offset += 4;
    }

    private static Vector3Double ReadVector3Double(ref DisBinaryReader reader)
    {
        var value = new Vector3Double();
        ReadVector3DoubleFields(ref reader, value);
        return value;
    }

    private static void ReadVector3DoubleFields(ref DisBinaryReader reader, Vector3Double value)
    {
        value.X = reader.ReadDouble("x");
        value.Y = reader.ReadDouble("y");
        value.Z = reader.ReadDouble("z");
    }

    private static void PrepareVector3Double(Vector3Double value)
    {
        PrepareVector3DoubleFields(value);
    }

    private static void PrepareVector3DoubleFields(Vector3Double value)
    {
    }

    private static void WriteVector3Double(ref DisBinaryWriter writer, Vector3Double value)
    {
        WriteVector3DoubleFields(ref writer, value);
    }

    private static void WriteVector3DoubleFields(ref DisBinaryWriter writer, Vector3Double value)
    {
        writer.WriteDouble(value.X, "x");
        writer.WriteDouble(value.Y, "y");
        writer.WriteDouble(value.Z, "z");
    }

    private static void MeasureVector3Double(in Vector3Double value, ref int offset)
    {
        MeasureVector3DoubleFields(value, ref offset);
    }

    private static void MeasureVector3DoubleFields(in Vector3Double value, ref int offset)
    {
        offset += 8;
        offset += 8;
        offset += 8;
    }

    private static Vector3Float ReadVector3Float(ref DisBinaryReader reader)
    {
        var value = new Vector3Float();
        ReadVector3FloatFields(ref reader, value);
        return value;
    }

    private static void ReadVector3FloatFields(ref DisBinaryReader reader, Vector3Float value)
    {
        value.X = reader.ReadSingle("x");
        value.Y = reader.ReadSingle("y");
        value.Z = reader.ReadSingle("z");
    }

    private static void PrepareVector3Float(Vector3Float value)
    {
        PrepareVector3FloatFields(value);
    }

    private static void PrepareVector3FloatFields(Vector3Float value)
    {
    }

    private static void WriteVector3Float(ref DisBinaryWriter writer, Vector3Float value)
    {
        WriteVector3FloatFields(ref writer, value);
    }

    private static void WriteVector3FloatFields(ref DisBinaryWriter writer, Vector3Float value)
    {
        writer.WriteSingle(value.X, "x");
        writer.WriteSingle(value.Y, "y");
        writer.WriteSingle(value.Z, "z");
    }

    private static void MeasureVector3Float(in Vector3Float value, ref int offset)
    {
        MeasureVector3FloatFields(value, ref offset);
    }

    private static void MeasureVector3FloatFields(in Vector3Float value, ref int offset)
    {
        offset += 4;
        offset += 4;
        offset += 4;
    }

    private static VectoringNozzleSystem ReadVectoringNozzleSystem(ref DisBinaryReader reader)
    {
        var value = new VectoringNozzleSystem();
        ReadVectoringNozzleSystemFields(ref reader, value);
        return value;
    }

    private static void ReadVectoringNozzleSystemFields(ref DisBinaryReader reader, VectoringNozzleSystem value)
    {
        value.HorizontalDeflectionAngle = reader.ReadSingle("horizontalDeflectionAngle");
        value.VerticalDeflectionAngle = reader.ReadSingle("verticalDeflectionAngle");
    }

    private static void PrepareVectoringNozzleSystem(VectoringNozzleSystem value)
    {
        PrepareVectoringNozzleSystemFields(value);
    }

    private static void PrepareVectoringNozzleSystemFields(VectoringNozzleSystem value)
    {
    }

    private static void WriteVectoringNozzleSystem(ref DisBinaryWriter writer, VectoringNozzleSystem value)
    {
        WriteVectoringNozzleSystemFields(ref writer, value);
    }

    private static void WriteVectoringNozzleSystemFields(ref DisBinaryWriter writer, VectoringNozzleSystem value)
    {
        writer.WriteSingle(value.HorizontalDeflectionAngle, "horizontalDeflectionAngle");
        writer.WriteSingle(value.VerticalDeflectionAngle, "verticalDeflectionAngle");
    }

    private static void MeasureVectoringNozzleSystem(in VectoringNozzleSystem value, ref int offset)
    {
        MeasureVectoringNozzleSystemFields(value, ref offset);
    }

    private static void MeasureVectoringNozzleSystemFields(in VectoringNozzleSystem value, ref int offset)
    {
        offset += 4;
        offset += 4;
    }

    private static void ReadWarfareFamilyPduFields(ref DisBinaryReader reader, WarfareFamilyPdu value)
    {
    }

    private static void PrepareWarfareFamilyPduFields(WarfareFamilyPdu value)
    {
    }

    private static void WriteWarfareFamilyPduFields(ref DisBinaryWriter writer, WarfareFamilyPdu value)
    {
    }

    private static void MeasureWarfareFamilyPduFields(in WarfareFamilyPdu value, ref int offset)
    {
    }

}

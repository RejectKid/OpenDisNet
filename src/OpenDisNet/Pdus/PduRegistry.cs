using OpenDisNet.Protocol;
using OpenDisNet.Binary;
using OpenDisNet.Records;

namespace OpenDisNet.Pdus;

internal static class PduRegistry
{
    public static IDisPdu Parse(DisHeader header, ReadOnlySpan<byte> body)
    {
        var reader = new DisBinaryReader(body);
        IDisPdu pdu = header.PduType switch
        {
            PduType.EntityState => ReadEntityState(header, ref reader),
            PduType.Fire => ReadFire(header, ref reader),
            PduType.Detonation => ReadDetonation(header, ref reader),
            >= PduType.Collision and <= PduType.Attribute =>
                OpenDisNet.Dis7.Dis7PduCodec.Read(header, body),
            _ => new UnknownPdu(header, body.ToArray()),
        };
        if (pdu is not UnknownPdu and not OpenDisNet.Dis7.Pdu && reader.Remaining != 0)
            throw new DisParseException(reader.Offset, "PDU body", reader.Remaining, 0);
        return pdu;
    }

    public static int GetLength(IDisPdu pdu) => pdu switch
    {
        OpenDisNet.Dis7.Pdu x => OpenDisNet.Dis7.Dis7PduCodec.GetEncodedLength(x),
        EntityStatePdu x => 144 + CheckedVariableCount(x.VariableParameters) * VariableParameter.Size,
        FirePdu => 96,
        DetonationPdu x => 104 + CheckedVariableCount(x.VariableParameters) * VariableParameter.Size,
        UnknownPdu x => DisHeader.Size + x.Body.Length,
        _ => throw new NotSupportedException($"No writer is registered for {pdu.GetType().Name}."),
    };

    public static void WriteBody(IDisPdu pdu, ref DisBinaryWriter w)
    {
        switch (pdu)
        {
            case OpenDisNet.Dis7.Pdu:
                throw new InvalidOperationException("Generated DIS v7 PDUs are written by Dis7PduCodec.");
            case EntityStatePdu x: WriteEntityState(x, ref w); break;
            case FirePdu x: WriteFire(x, ref w); break;
            case DetonationPdu x: WriteDetonation(x, ref w); break;
            case UnknownPdu x: w.WriteBytes(x.Body.Span); break;
            default: throw new NotSupportedException($"No writer is registered for {pdu.GetType().Name}.");
        }
    }

    private static EntityStatePdu ReadEntityState(DisHeader h, ref DisBinaryReader r)
    {
        EntityId id = EntityId.Read(ref r);
        byte force = r.ReadByte("forceId");
        int count = r.ReadByte("numberOfVariableParameters");
        EntityType type = EntityType.Read(ref r);
        EntityType alternate = EntityType.Read(ref r);
        Vector3Float velocity = Vector3Float.Read(ref r);
        Vector3Double location = Vector3Double.Read(ref r);
        EulerAngles orientation = EulerAngles.Read(ref r);
        uint appearance = r.ReadUInt32("appearance");
        DeadReckoningParameters deadReckoning = DeadReckoningParameters.Read(ref r);
        EntityMarking marking = EntityMarking.Read(ref r);
        uint capabilities = r.ReadUInt32("capabilities");
        return new(h, id, force, type, alternate, velocity, location, orientation, appearance, deadReckoning, marking, capabilities, ReadVariables(count, ref r));
    }

    private static FirePdu ReadFire(DisHeader h, ref DisBinaryReader r) => new(
        h, EntityId.Read(ref r), EntityId.Read(ref r), EntityId.Read(ref r), EventId.Read(ref r),
        r.ReadUInt32("fireMissionIndex"), Vector3Double.Read(ref r), MunitionDescriptor.Read(ref r),
        Vector3Float.Read(ref r), r.ReadSingle("range"));

    private static DetonationPdu ReadDetonation(DisHeader h, ref DisBinaryReader r)
    {
        EntityId source = EntityId.Read(ref r); EntityId target = EntityId.Read(ref r); EntityId exploding = EntityId.Read(ref r);
        EventId eventId = EventId.Read(ref r); Vector3Float velocity = Vector3Float.Read(ref r); Vector3Double location = Vector3Double.Read(ref r);
        MunitionDescriptor descriptor = MunitionDescriptor.Read(ref r); Vector3Float relative = Vector3Float.Read(ref r);
        byte result = r.ReadByte("detonationResult"); int count = r.ReadByte("numberOfVariableParameters"); r.Skip(2);
        return new(h, source, target, exploding, eventId, velocity, location, descriptor, relative, result, ReadVariables(count, ref r));
    }

    private static void WriteEntityState(EntityStatePdu x, ref DisBinaryWriter w)
    {
        x.EntityId.Write(ref w); w.WriteByte(x.ForceId); w.WriteByte((byte)CheckedVariableCount(x.VariableParameters));
        x.EntityType.Write(ref w); x.AlternativeEntityType.Write(ref w); x.LinearVelocity.Write(ref w); x.Location.Write(ref w);
        x.Orientation.Write(ref w); w.WriteUInt32(x.Appearance); x.DeadReckoning.Write(ref w); x.Marking.Write(ref w);
        w.WriteUInt32(x.Capabilities); WriteVariables(x.VariableParameters, ref w);
    }

    private static void WriteFire(FirePdu x, ref DisBinaryWriter w)
    {
        x.FiringEntityId.Write(ref w); x.TargetEntityId.Write(ref w); x.MunitionEntityId.Write(ref w); x.EventId.Write(ref w);
        w.WriteUInt32(x.FireMissionIndex); x.Location.Write(ref w); x.Descriptor.Write(ref w); x.Velocity.Write(ref w); w.WriteSingle(x.Range);
    }

    private static void WriteDetonation(DetonationPdu x, ref DisBinaryWriter w)
    {
        x.SourceEntityId.Write(ref w); x.TargetEntityId.Write(ref w); x.ExplodingEntityId.Write(ref w); x.EventId.Write(ref w);
        x.Velocity.Write(ref w); x.Location.Write(ref w); x.Descriptor.Write(ref w); x.EntityRelativeLocation.Write(ref w);
        w.WriteByte(x.DetonationResult); w.WriteByte((byte)CheckedVariableCount(x.VariableParameters)); w.WriteZeros(2); WriteVariables(x.VariableParameters, ref w);
    }

    private static IReadOnlyList<VariableParameter> ReadVariables(int count, ref DisBinaryReader r)
    {
        if (count == 0) return Array.Empty<VariableParameter>();
        var values = new VariableParameter[count];
        for (int i = 0; i < count; i++) values[i] = VariableParameter.Read(ref r);
        return values;
    }

    private static void WriteVariables(IReadOnlyList<VariableParameter> values, ref DisBinaryWriter w)
    { for (int i = 0; i < values.Count; i++) values[i].Write(ref w); }

    private static int CheckedVariableCount(IReadOnlyList<VariableParameter> values) =>
        values.Count <= byte.MaxValue ? values.Count : throw new ArgumentOutOfRangeException(nameof(values), "DIS limits variable parameters to 255 records.");
}

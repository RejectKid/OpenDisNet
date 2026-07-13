using OpenDisNet.Protocol;

namespace OpenDisNet.Binary;

public static class DisHeaderCodec
{
    public static DisHeader Read(ref DisBinaryReader reader)
    {
        var version = (DisProtocolVersion)reader.ReadByte(nameof(DisHeader.ProtocolVersion));
        byte exerciseId = reader.ReadByte(nameof(DisHeader.ExerciseId));
        var pduType = (PduType)reader.ReadByte(nameof(DisHeader.PduType));
        var family = (ProtocolFamily)reader.ReadByte(nameof(DisHeader.ProtocolFamily));
        uint timestamp = reader.ReadUInt32(nameof(DisHeader.Timestamp));
        ushort length = reader.ReadUInt16(nameof(DisHeader.Length));
        byte status = family == ProtocolFamily.LiveEntity ? (byte)0 : reader.ReadByte(nameof(DisHeader.PduStatus));
        byte padding = family == ProtocolFamily.LiveEntity ? (byte)0 : reader.ReadByte(nameof(DisHeader.Padding));
        return new(version, exerciseId, pduType, family, timestamp, length, status, padding);
    }

    public static void Write(ref DisBinaryWriter writer, in DisHeader header)
    {
        writer.WriteByte((byte)header.ProtocolVersion, nameof(header.ProtocolVersion));
        writer.WriteByte(header.ExerciseId, nameof(header.ExerciseId));
        writer.WriteByte((byte)header.PduType, nameof(header.PduType));
        writer.WriteByte((byte)header.ProtocolFamily, nameof(header.ProtocolFamily));
        writer.WriteUInt32(header.Timestamp, nameof(header.Timestamp));
        writer.WriteUInt16(header.Length, nameof(header.Length));
        if (header.ProtocolFamily != ProtocolFamily.LiveEntity)
        {
            writer.WriteByte(header.PduStatus, nameof(header.PduStatus));
            writer.WriteByte(header.Padding, nameof(header.Padding));
        }
    }
}

using OpenDisNet.Protocol;

namespace OpenDisNet.Binary;

public static class DisHeaderCodec
{
    public static DisHeader Read(ref DisBinaryReader reader) => new(
        (DisProtocolVersion)reader.ReadByte(nameof(DisHeader.ProtocolVersion)),
        reader.ReadByte(nameof(DisHeader.ExerciseId)),
        (PduType)reader.ReadByte(nameof(DisHeader.PduType)),
        (ProtocolFamily)reader.ReadByte(nameof(DisHeader.ProtocolFamily)),
        reader.ReadUInt32(nameof(DisHeader.Timestamp)),
        reader.ReadUInt16(nameof(DisHeader.Length)),
        reader.ReadByte(nameof(DisHeader.PduStatus)),
        reader.ReadByte(nameof(DisHeader.Padding)));

    public static void Write(ref DisBinaryWriter writer, in DisHeader header)
    {
        writer.WriteByte((byte)header.ProtocolVersion, nameof(header.ProtocolVersion));
        writer.WriteByte(header.ExerciseId, nameof(header.ExerciseId));
        writer.WriteByte((byte)header.PduType, nameof(header.PduType));
        writer.WriteByte((byte)header.ProtocolFamily, nameof(header.ProtocolFamily));
        writer.WriteUInt32(header.Timestamp, nameof(header.Timestamp));
        writer.WriteUInt16(header.Length, nameof(header.Length));
        writer.WriteByte(header.PduStatus, nameof(header.PduStatus));
        writer.WriteByte(header.Padding, nameof(header.Padding));
    }
}

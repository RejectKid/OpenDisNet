using System.Buffers.Binary;

namespace OpenDisNet.Binary;

/// <summary>Bounds-checked network-byte-order reader used by DIS codecs.</summary>
public ref struct DisBinaryReader
{
    private readonly ReadOnlySpan<byte> _source;
    private readonly int _origin;
    private int _offset;

    public DisBinaryReader(ReadOnlySpan<byte> source, int origin = 0)
    {
        _source = source;
        _origin = origin;
    }
    public readonly int Offset => _origin + _offset;
    public readonly int Remaining => _source.Length - _offset;

    public byte ReadByte(string field = "value")
    {
        Ensure(1, field);
        return _source[_offset++];
    }

    public sbyte ReadSByte(string field = "value") => unchecked((sbyte)ReadByte(field));

    public ushort ReadUInt16(string field = "value")
    {
        Ensure(2, field);
        ushort value = BinaryPrimitives.ReadUInt16BigEndian(_source[_offset..]);
        _offset += 2;
        return value;
    }

    public short ReadInt16(string field = "value") => unchecked((short)ReadUInt16(field));

    public uint ReadUInt32(string field = "value")
    {
        Ensure(4, field);
        uint value = BinaryPrimitives.ReadUInt32BigEndian(_source[_offset..]);
        _offset += 4;
        return value;
    }

    public int ReadInt32(string field = "value") => unchecked((int)ReadUInt32(field));

    public ulong ReadUInt64(string field = "value")
    {
        Ensure(8, field);
        ulong value = BinaryPrimitives.ReadUInt64BigEndian(_source[_offset..]);
        _offset += 8;
        return value;
    }

    public long ReadInt64(string field = "value") => unchecked((long)ReadUInt64(field));
    public float ReadSingle(string field = "value") => BitConverter.Int32BitsToSingle(ReadInt32(field));
    public double ReadDouble(string field = "value") => BitConverter.Int64BitsToDouble(ReadInt64(field));

    public ReadOnlySpan<byte> ReadBytes(int count, string field = "value")
    {
        Ensure(count, field);
        ReadOnlySpan<byte> value = _source.Slice(_offset, count);
        _offset += count;
        return value;
    }

    public void Skip(int count, string field = "padding") => _ = ReadBytes(count, field);

    private readonly void Ensure(int count, string field)
    {
        if (count < 0 || count > Remaining)
            throw new DisParseException(Offset, field, count, Remaining);
    }
}

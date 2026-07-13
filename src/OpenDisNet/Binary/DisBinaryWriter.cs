using System.Buffers.Binary;

namespace OpenDisNet.Binary;

/// <summary>Bounds-checked network-byte-order writer used by DIS codecs.</summary>
public ref struct DisBinaryWriter
{
    private readonly Span<byte> _destination;
    private int _offset;

    public DisBinaryWriter(Span<byte> destination) => _destination = destination;
    public readonly int Offset => _offset;
    public readonly int Remaining => _destination.Length - _offset;

    public void WriteByte(byte value, string field = "value")
    {
        Ensure(1, field);
        _destination[_offset++] = value;
    }

    public void WriteSByte(sbyte value, string field = "value") => WriteByte(unchecked((byte)value), field);

    public void WriteUInt16(ushort value, string field = "value")
    {
        Ensure(2, field);
        BinaryPrimitives.WriteUInt16BigEndian(_destination[_offset..], value);
        _offset += 2;
    }

    public void WriteInt16(short value, string field = "value") => WriteUInt16(unchecked((ushort)value), field);

    public void WriteUInt32(uint value, string field = "value")
    {
        Ensure(4, field);
        BinaryPrimitives.WriteUInt32BigEndian(_destination[_offset..], value);
        _offset += 4;
    }

    public void WriteInt32(int value, string field = "value") => WriteUInt32(unchecked((uint)value), field);

    public void WriteUInt64(ulong value, string field = "value")
    {
        Ensure(8, field);
        BinaryPrimitives.WriteUInt64BigEndian(_destination[_offset..], value);
        _offset += 8;
    }

    public void WriteInt64(long value, string field = "value") => WriteUInt64(unchecked((ulong)value), field);
    public void WriteSingle(float value, string field = "value") => WriteInt32(BitConverter.SingleToInt32Bits(value), field);
    public void WriteDouble(double value, string field = "value") => WriteInt64(BitConverter.DoubleToInt64Bits(value), field);

    public void WriteBytes(scoped ReadOnlySpan<byte> value, string field = "value")
    {
        Ensure(value.Length, field);
        value.CopyTo(_destination[_offset..]);
        _offset += value.Length;
    }

    public void WriteZeros(int count, string field = "padding")
    {
        Ensure(count, field);
        _destination.Slice(_offset, count).Clear();
        _offset += count;
    }

    private readonly void Ensure(int count, string field)
    {
        if (count < 0 || count > Remaining)
            throw new ArgumentException($"Writing '{field}' requires {count} bytes at offset {_offset}, but only {Remaining} remain.");
    }
}

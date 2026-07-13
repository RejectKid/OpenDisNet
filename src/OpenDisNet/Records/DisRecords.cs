using System.Text;
using OpenDisNet.Binary;

namespace OpenDisNet.Records;

public readonly record struct EntityId(ushort Site, ushort Application, ushort Entity)
{
    public const int Size = 6;
    internal static EntityId Read(ref DisBinaryReader r) => new(r.ReadUInt16("site"), r.ReadUInt16("application"), r.ReadUInt16("entity"));
    internal void Write(ref DisBinaryWriter w) { w.WriteUInt16(Site); w.WriteUInt16(Application); w.WriteUInt16(Entity); }
    public override string ToString() => $"{Site}:{Application}:{Entity}";
}

public readonly record struct SimulationAddress(ushort Site, ushort Application)
{
    public const int Size = 4;
    internal static SimulationAddress Read(ref DisBinaryReader r) => new(r.ReadUInt16("site"), r.ReadUInt16("application"));
    internal void Write(ref DisBinaryWriter w) { w.WriteUInt16(Site); w.WriteUInt16(Application); }
}

public readonly record struct EventId(SimulationAddress SimulationAddress, ushort EventNumber)
{
    public const int Size = 6;
    internal static EventId Read(ref DisBinaryReader r) => new(SimulationAddress.Read(ref r), r.ReadUInt16("eventNumber"));
    internal void Write(ref DisBinaryWriter w) { SimulationAddress.Write(ref w); w.WriteUInt16(EventNumber); }
}

public readonly record struct EntityType(byte Kind, byte Domain, ushort Country, byte Category, byte Subcategory, byte Specific, byte Extra)
{
    public const int Size = 8;
    internal static EntityType Read(ref DisBinaryReader r) => new(r.ReadByte("kind"), r.ReadByte("domain"), r.ReadUInt16("country"), r.ReadByte("category"), r.ReadByte("subcategory"), r.ReadByte("specific"), r.ReadByte("extra"));
    internal void Write(ref DisBinaryWriter w) { w.WriteByte(Kind); w.WriteByte(Domain); w.WriteUInt16(Country); w.WriteByte(Category); w.WriteByte(Subcategory); w.WriteByte(Specific); w.WriteByte(Extra); }
}

public readonly record struct Vector3Float(float X, float Y, float Z)
{
    public const int Size = 12;
    internal static Vector3Float Read(ref DisBinaryReader r) => new(r.ReadSingle("x"), r.ReadSingle("y"), r.ReadSingle("z"));
    internal void Write(ref DisBinaryWriter w) { w.WriteSingle(X); w.WriteSingle(Y); w.WriteSingle(Z); }
}

public readonly record struct Vector3Double(double X, double Y, double Z)
{
    public const int Size = 24;
    internal static Vector3Double Read(ref DisBinaryReader r) => new(r.ReadDouble("x"), r.ReadDouble("y"), r.ReadDouble("z"));
    internal void Write(ref DisBinaryWriter w) { w.WriteDouble(X); w.WriteDouble(Y); w.WriteDouble(Z); }
}

public readonly record struct EulerAngles(float Psi, float Theta, float Phi)
{
    public const int Size = 12;
    internal static EulerAngles Read(ref DisBinaryReader r) => new(r.ReadSingle("psi"), r.ReadSingle("theta"), r.ReadSingle("phi"));
    internal void Write(ref DisBinaryWriter w) { w.WriteSingle(Psi); w.WriteSingle(Theta); w.WriteSingle(Phi); }
}

public readonly record struct DeadReckoningParameters(byte Algorithm, ReadOnlyMemory<byte> OtherParameters, Vector3Float LinearAcceleration, Vector3Float AngularVelocity)
{
    public const int Size = 40;

    public DeadReckoningParameters(byte algorithm, Vector3Float linearAcceleration, Vector3Float angularVelocity)
        : this(algorithm, new byte[15], linearAcceleration, angularVelocity) { }

    internal static DeadReckoningParameters Read(ref DisBinaryReader r) =>
        new(r.ReadByte("deadReckoningAlgorithm"), r.ReadBytes(15, "otherParameters").ToArray(), Vector3Float.Read(ref r), Vector3Float.Read(ref r));

    internal void Write(ref DisBinaryWriter w)
    {
        if (OtherParameters.Length != 15) throw new ArgumentException("Dead-reckoning other parameters must contain exactly 15 bytes.");
        w.WriteByte(Algorithm); w.WriteBytes(OtherParameters.Span); LinearAcceleration.Write(ref w); AngularVelocity.Write(ref w);
    }
}

public readonly record struct EntityMarking(byte CharacterSet, string Text)
{
    public const int Size = 12;
    internal static EntityMarking Read(ref DisBinaryReader r)
    {
        byte characterSet = r.ReadByte("characterSet");
        ReadOnlySpan<byte> bytes = r.ReadBytes(11, "marking");
        int end = bytes.IndexOf((byte)0);
        return new(characterSet, Encoding.ASCII.GetString(end < 0 ? bytes : bytes[..end]));
    }

    internal void Write(ref DisBinaryWriter w)
    {
        w.WriteByte(CharacterSet);
        Span<byte> field = stackalloc byte[11];
        int count = Encoding.ASCII.GetBytes(Text.AsSpan(), field);
        if (count > 11) throw new ArgumentException("Entity marking is limited to 11 ASCII bytes.");
        w.WriteBytes(field);
    }
}

public readonly record struct MunitionDescriptor(EntityType MunitionType, ushort Warhead, ushort Fuse, ushort Quantity, ushort Rate)
{
    public const int Size = 16;
    internal static MunitionDescriptor Read(ref DisBinaryReader r) => new(EntityType.Read(ref r), r.ReadUInt16("warhead"), r.ReadUInt16("fuse"), r.ReadUInt16("quantity"), r.ReadUInt16("rate"));
    internal void Write(ref DisBinaryWriter w) { MunitionType.Write(ref w); w.WriteUInt16(Warhead); w.WriteUInt16(Fuse); w.WriteUInt16(Quantity); w.WriteUInt16(Rate); }
}

public readonly record struct VariableParameter(ReadOnlyMemory<byte> Data)
{
    public const int Size = 16;
    public byte RecordType => Data.Length == 0 ? (byte)0 : Data.Span[0];
    internal static VariableParameter Read(ref DisBinaryReader r) => new(r.ReadBytes(Size, "variableParameter").ToArray());
    internal void Write(ref DisBinaryWriter w)
    {
        if (Data.Length != Size) throw new ArgumentException("A variable parameter must contain exactly 16 bytes.");
        w.WriteBytes(Data.Span);
    }
}

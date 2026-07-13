using OpenDisNet.Binary;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Binary;

public sealed class DisHeaderCodecTests
{
    [Fact]
    public void ReadsVersion7HeaderInNetworkByteOrder()
    {
        byte[] bytes = [7, 3, 1, 1, 0x01, 0x02, 0x03, 0x04, 0, 12, 0xA5, 0];
        var reader = new DisBinaryReader(bytes);

        DisHeader header = DisHeaderCodec.Read(ref reader);

        Assert.Equal(DisProtocolVersion.Ieee1278_1_2012, header.ProtocolVersion);
        Assert.Equal((byte)3, header.ExerciseId);
        Assert.Equal(PduType.EntityState, header.PduType);
        Assert.Equal(0x01020304u, header.Timestamp);
        Assert.Equal((ushort)12, header.Length);
        Assert.Equal((byte)0xA5, header.PduStatus);
        Assert.Equal(12, reader.Offset);
    }

    [Fact]
    public void WriterRoundTripsHeader()
    {
        var expected = new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 9, PduType.Fire, ProtocolFamily.Warfare, 42, 12, 0, 0);
        Span<byte> bytes = stackalloc byte[12];
        var writer = new DisBinaryWriter(bytes);
        DisHeaderCodec.Write(ref writer, expected);
        var reader = new DisBinaryReader(bytes);

        Assert.Equal(expected, DisHeaderCodec.Read(ref reader));
    }
}

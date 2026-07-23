using OpenDisNet.Binary;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Binary;

[TestClass]
public sealed class DisHeaderCodecTests
{
    [TestMethod]
    public void ReadsVersion7HeaderInNetworkByteOrder()
    {
        byte[] bytes = [7, 3, 1, 1, 0x01, 0x02, 0x03, 0x04, 0, 12, 0xA5, 0];
        var reader = new DisBinaryReader(bytes);

        DisHeader header = DisHeaderCodec.Read(ref reader);

        Assert.AreEqual(DisProtocolVersion.Ieee1278_1_2012, header.ProtocolVersion);
        Assert.AreEqual((byte)3, header.ExerciseId);
        Assert.AreEqual(PduType.EntityState, header.PduType);
        Assert.AreEqual(0x01020304u, header.Timestamp);
        Assert.AreEqual((ushort)12, header.Length);
        Assert.AreEqual((byte)0xA5, header.PduStatus);
        Assert.AreEqual(12, reader.Offset);
    }

    [TestMethod]
    public void WriterRoundTripsHeader()
    {
        var expected = new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 9, PduType.Fire, ProtocolFamily.Warfare, 42, 12, 0, 0);
        Span<byte> bytes = stackalloc byte[12];
        var writer = new DisBinaryWriter(bytes);
        DisHeaderCodec.Write(ref writer, expected);
        var reader = new DisBinaryReader(bytes);

        Assert.AreEqual(expected, DisHeaderCodec.Read(ref reader));
    }
}

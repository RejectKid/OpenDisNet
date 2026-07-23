using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests;

[TestClass]
public sealed class DisSerializerTests
{
    [TestMethod]
    public void DirectConstructionInitializesWireIdentity()
    {
        var signal = new SignalPdu { ExerciseId = 7 };

        Assert.AreEqual(DisProtocolVersion.Ieee1278_1_2012, signal.Header.ProtocolVersion);
        Assert.AreEqual(PduType.Signal, signal.Header.PduType);
        Assert.AreEqual(ProtocolFamily.RadioCommunications, signal.Header.ProtocolFamily);
        Assert.AreEqual((byte)7, signal.Header.ExerciseId);
    }

    [TestMethod]
    public void GenericDeserializeReturnsExpectedPdu()
    {
        var signal = new SignalPdu { Radio = new RadioId(new EntityId(1, 2, 3), 4) };
        signal.SetData([0xaa, 0xc0], meaningfulBitLength: 10);

        SignalPdu parsed = DisSerializer.Deserialize<SignalPdu>(DisSerializer.Serialize(signal));

        Assert.AreEqual((ushort)3, parsed.Radio.Entity.EntityNumber);
        Assert.AreEqual((ushort)10, parsed.DataBitLength);
        Assert.AreSequenceEqual(new byte[] { 0xaa, 0xc0 }, parsed.Data);
    }

    [TestMethod]
    public void GenericTryDeserializeReportsTypeMismatch()
    {
        byte[] bytes = DisSerializer.Serialize(new SignalPdu());
        Assert.IsFalse(DisSerializer.TryDeserialize<FirePdu>(bytes, out _, out DisParseError error));
        Assert.AreEqual(DisParseErrorCode.UnexpectedPduType, error.Code);
    }

    [TestMethod]
    public void RejectsTruncatedHeader()
    {
        Assert.IsFalse(DisSerializer.TryDeserialize(new byte[11], out _, out DisParseError error));
        Assert.AreEqual(DisParseErrorCode.TruncatedHeader, error.Code);
    }

    [TestMethod]
    public void PreservesUnknownPduBody()
    {
        byte[] bytes = [7, 1, 200, 0, 0, 0, 0, 0, 0, 15, 0, 0, 1, 2, 3];
        Assert.IsTrue(DisSerializer.TryDeserialize(bytes, out IDisPdu? parsed, out DisParseError error), error.Message);
        var unknown = Assert.IsInstanceOfType<UnknownPdu>(parsed);
        Assert.AreSequenceEqual(new byte[] { 1, 2, 3 }, unknown.Body.ToArray());
    }
}

using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests;

public sealed class DisSerializerTests
{
    [Fact]
    public void DirectConstructionInitializesWireIdentity()
    {
        var signal = new SignalPdu { ExerciseId = 7 };

        Assert.Equal(DisProtocolVersion.Ieee1278_1_2012, signal.Header.ProtocolVersion);
        Assert.Equal(PduType.Signal, signal.Header.PduType);
        Assert.Equal(ProtocolFamily.RadioCommunications, signal.Header.ProtocolFamily);
        Assert.Equal((byte)7, signal.Header.ExerciseId);
    }

    [Fact]
    public void GenericDeserializeReturnsExpectedPdu()
    {
        var signal = new SignalPdu { Radio = new RadioId(new EntityId(1, 2, 3), 4) };
        signal.SetData([0xaa, 0xc0], meaningfulBitLength: 10);

        SignalPdu parsed = DisSerializer.Deserialize<SignalPdu>(DisSerializer.Serialize(signal));

        Assert.Equal((ushort)3, parsed.Radio.Entity.EntityNumber);
        Assert.Equal((ushort)10, parsed.DataBitLength);
        Assert.Equal(new byte[] { 0xaa, 0xc0 }, parsed.Data);
    }

    [Fact]
    public void GenericTryDeserializeReportsTypeMismatch()
    {
        byte[] bytes = DisSerializer.Serialize(new SignalPdu());
        Assert.False(DisSerializer.TryDeserialize<FirePdu>(bytes, out _, out DisParseError error));
        Assert.Equal(DisParseErrorCode.UnexpectedPduType, error.Code);
    }

    [Fact]
    public void RejectsTruncatedHeader()
    {
        Assert.False(DisSerializer.TryDeserialize(new byte[11], out _, out DisParseError error));
        Assert.Equal(DisParseErrorCode.TruncatedHeader, error.Code);
    }

    [Fact]
    public void PreservesUnknownPduBody()
    {
        byte[] bytes = [7, 1, 200, 0, 0, 0, 0, 0, 0, 15, 0, 0, 1, 2, 3];
        Assert.True(DisSerializer.TryDeserialize(bytes, out IDisPdu? parsed, out DisParseError error), error.Message);
        var unknown = Assert.IsType<UnknownPdu>(parsed);
        Assert.Equal(new byte[] { 1, 2, 3 }, unknown.Body.ToArray());
    }
}

using OpenDisNet.Dis7;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

public sealed class GeneratedCodecSmokeTests
{
    public static TheoryData<byte> StandardPduTypes =>
        new(Enumerable.Range(1, 72).Select(x => (byte)x));

    [Theory]
    [MemberData(nameof(StandardPduTypes))]
    public void DefaultPduRoundTripsWithoutUnreadBytes(byte value)
    {
        Pdu original = Dis7PduFactory.Create((PduType)value, exerciseId: 4);

        byte[] encoded = Dis7PduCodec.Write(original);
        Pdu decoded = Dis7PduCodec.Read(original.Header, encoded.AsSpan(DisHeader.Size));

        Assert.Equal(value, decoded.PduType);
        Assert.Equal(encoded.Length, original.Length);
        Assert.Equal(encoded, Dis7PduCodec.Write(decoded));
    }

    [Fact]
    public void PublicReaderAndWriterHandleGeneratedPdus()
    {
        var original = (SignalPdu)Dis7PduFactory.Create(PduType.Signal, exerciseId: 9);
        original.EncodingScheme = 0x1234;
        original.TdlType = 7;
        original.SampleRate = 48_000;
        original.DataLength = 13;
        original.Samples = 2;
        original.Data = [0xA5, 0xE0];

        byte[] encoded = DisPduWriter.Write(original);
        Assert.True(DisPduReader.TryParse(encoded, out global::OpenDisNet.Pdus.IDisPdu? parsed, out DisParseError error), error.Message);

        SignalPdu signal = Assert.IsType<SignalPdu>(parsed);
        Assert.Equal(original.Data, signal.Data);
        Assert.Equal((ushort)13, signal.DataLength);
        Assert.Equal(encoded, DisPduWriter.Write(signal));
    }

    [Fact]
    public void GeneratedCodecRejectsDeclaredListThatExceedsBody()
    {
        var original = (SignalPdu)Dis7PduFactory.Create(PduType.Signal);
        original.DataLength = 16;
        original.Data = [1, 2];
        byte[] encoded = Dis7PduCodec.Write(original);
        byte[] truncated = encoded[..^1];
        truncated[8] = (byte)(truncated.Length >> 8);
        truncated[9] = (byte)truncated.Length;

        Assert.False(DisPduReader.TryParse(truncated, out _, out DisParseError error));
        Assert.Equal(DisParseErrorCode.InvalidField, error.Code);
    }
}

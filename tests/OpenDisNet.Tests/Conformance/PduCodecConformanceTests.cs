using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

public sealed class PduCodecConformanceTests
{
    public static TheoryData<byte> StandardPduTypes =>
        new(Enumerable.Range(1, 72).Select(x => (byte)x));

    [Theory]
    [MemberData(nameof(StandardPduTypes))]
    public void DefaultPduRoundTripsWithoutUnreadBytes(byte value)
    {
        Pdu original = PduFactory.Create((PduType)value, exerciseId: 4);

        byte[] encoded = DisSerializer.Serialize(original);
        Pdu decoded = Assert.IsAssignableFrom<Pdu>(DisSerializer.Deserialize(encoded));

        Assert.Equal(value, decoded.PduType);
        Assert.Equal(encoded.Length, original.Length);
        Assert.Equal(encoded, DisSerializer.Serialize(decoded));
    }

    [Fact]
    public void PublicSerializerHandlesTypedPdus()
    {
        var original = (SignalPdu)PduFactory.Create(PduType.Signal, exerciseId: 9);
        original.EncodingScheme = 0x1234;
        original.TdlType = 7;
        original.SampleRate = 48_000;
        original.DataBitLength = 13;
        original.Samples = 2;
        original.Data = [0xA5, 0xE0];

        byte[] encoded = DisSerializer.Serialize(original);
        Assert.True(DisSerializer.TryDeserialize(encoded, out global::OpenDisNet.Pdus.IDisPdu? parsed, out DisParseError error), error.Message);

        SignalPdu signal = Assert.IsType<SignalPdu>(parsed);
        Assert.Equal(original.Data, signal.Data);
        Assert.Equal((ushort)13, signal.DataBitLength);
        Assert.Equal(encoded, DisSerializer.Serialize(signal));
    }

    [Fact]
    public void SerializerFacadeHidesCodecImplementation()
    {
        Pdu original = PduFactory.Create(PduType.Acknowledge, exerciseId: 3);

        byte[] encoded = DisSerializer.Serialize(original);
        global::OpenDisNet.Pdus.IDisPdu decoded = DisSerializer.Deserialize(encoded);

        Assert.Equal(PduType.Acknowledge, decoded.Header.PduType);
        Assert.Equal(encoded, DisSerializer.Serialize(decoded));
    }

    [Fact]
    public void RejectsDeclaredListThatExceedsBody()
    {
        var original = (SignalPdu)PduFactory.Create(PduType.Signal);
        original.DataBitLength = 16;
        original.Data = [1, 2];
        byte[] encoded = DisSerializer.Serialize(original);
        byte[] truncated = encoded[..^1];
        truncated[8] = (byte)(truncated.Length >> 8);
        truncated[9] = (byte)truncated.Length;

        Assert.False(DisSerializer.TryDeserialize(truncated, out _, out DisParseError error));
        Assert.Equal(DisParseErrorCode.InvalidField, error.Code);
    }

    [Fact]
    public void TransmitterUsesOctetLengthsAndSynchronizesThemAutomatically()
    {
        var original = (TransmitterPdu)PduFactory.Create(PduType.Transmitter);
        original.ModulationParameters = [1, 2, 3, 4, 0, 0, 0, 0];
        original.AntennaPatternParameters = Enumerable.Range(0, 40).Select(x => (byte)x).ToArray();

        byte[] encoded = DisSerializer.Serialize(original);
        var decoded = Assert.IsType<TransmitterPdu>(DisSerializer.Deserialize(encoded));

        Assert.Equal(original.ModulationParameters, decoded.ModulationParameters);
        Assert.Equal(original.AntennaPatternParameters, decoded.AntennaPatternParameters);
        Assert.Equal(encoded, DisSerializer.Serialize(decoded));
    }

    [Fact]
    public void IntercomParameterByteLengthFramesMultipleRecords()
    {
        var original = (IntercomControlPdu)PduFactory.Create(PduType.IntercomControl);
        original.IntercomParameters =
        [
            new() { RecordType = 1, RecordLength = 8, RecordSpecificField = [1, 2, 3, 4] },
            new() { RecordType = 2, RecordLength = 8, RecordSpecificField = [5, 6, 7, 8] },
        ];

        byte[] encoded = DisSerializer.Serialize(original);
        var decoded = Assert.IsType<IntercomControlPdu>(DisSerializer.Deserialize(encoded));

        Assert.Equal(2, decoded.IntercomParameters.Count);
        Assert.Equal([1, 2, 3, 4], decoded.IntercomParameters[0].RecordSpecificField);
        Assert.Equal([5, 6, 7, 8], decoded.IntercomParameters[1].RecordSpecificField);
        Assert.Equal(encoded, DisSerializer.Serialize(decoded));
    }

    [Fact]
    public void MinefieldDataFilterControlsOptionalPerMineFields()
    {
        var original = (MinefieldDataPdu)PduFactory.Create(PduType.MinefieldData);
        original.SensorTypes = [new() { SensorType = 12 }];
        original.MineLocation =
        [
            new() { X = 1, Y = 2, Z = 3 },
            new() { X = 4, Y = 5, Z = 6 },
        ];
        original.GroundBurialDepthOffset = [0.25f, 0.5f];
        original.MineEntityNumber = [101, 102];

        byte[] encoded = DisSerializer.Serialize(original);
        var decoded = Assert.IsType<MinefieldDataPdu>(DisSerializer.Deserialize(encoded));

        Assert.Equal(1u, original.DataFilter.BitFlags);
        Assert.Equal(original.GroundBurialDepthOffset, decoded.GroundBurialDepthOffset);
        Assert.Empty(decoded.WaterBurialDepthOffset);
        Assert.Equal(original.MineEntityNumber, decoded.MineEntityNumber);
        Assert.Equal(encoded, DisSerializer.Serialize(decoded));
    }
}

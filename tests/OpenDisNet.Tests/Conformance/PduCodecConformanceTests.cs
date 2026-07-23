using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

[TestClass]
public sealed class PduCodecConformanceTests
{
    public static IEnumerable<object[]> StandardPduTypes =>
        Enumerable.Range(1, 72).Select(x => new object[] { (byte)x });

    [TestMethod]
    [DynamicData(nameof(StandardPduTypes))]
    public void DefaultPduRoundTripsWithoutUnreadBytes(byte value)
    {
        Pdu original = PduFactory.Create((PduType)value, exerciseId: 4);

        byte[] encoded = DisSerializer.Serialize(original);
        Pdu decoded = Assert.IsInstanceOfType<Pdu>(DisSerializer.Deserialize(encoded));

        Assert.AreEqual(value, (byte)decoded.PduType);
        Assert.AreEqual(encoded.Length, original.Length);
        Assert.AreSequenceEqual(encoded, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
    public void PublicSerializerHandlesTypedPdus()
    {
        var original = (SignalPdu)PduFactory.Create(PduType.Signal, exerciseId: 9);
        original.EncodingScheme = 0x1234;
        original.TdlType = SignalTdlType.Link16LegacyFormatJtidsFdlTadilJ;
        original.SampleRate = 48_000;
        original.DataBitLength = 13;
        original.SampleCount = 2;
        original.Data = [0xA5, 0xE0];

        byte[] encoded = DisSerializer.Serialize(original);
        Assert.IsTrue(DisSerializer.TryDeserialize(encoded, out global::OpenDisNet.Pdus.IDisPdu? parsed, out DisParseError error), error.Message);

        SignalPdu signal = Assert.IsInstanceOfType<SignalPdu>(parsed);
        Assert.AreSequenceEqual(original.Data, signal.Data);
        Assert.AreEqual((ushort)13, signal.DataBitLength);
        Assert.AreSequenceEqual(encoded, DisSerializer.Serialize(signal));
    }

    [TestMethod]
    public void SerializerFacadeHidesCodecImplementation()
    {
        Pdu original = PduFactory.Create(PduType.Acknowledge, exerciseId: 3);

        byte[] encoded = DisSerializer.Serialize(original);
        global::OpenDisNet.Pdus.IDisPdu decoded = DisSerializer.Deserialize(encoded);

        Assert.AreEqual(PduType.Acknowledge, decoded.Header.PduType);
        Assert.AreSequenceEqual(encoded, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
    public void RejectsDeclaredListThatExceedsBody()
    {
        var original = (SignalPdu)PduFactory.Create(PduType.Signal);
        original.DataBitLength = 16;
        original.Data = [1, 2];
        byte[] encoded = DisSerializer.Serialize(original);
        byte[] truncated = encoded[..^1];
        truncated[8] = (byte)(truncated.Length >> 8);
        truncated[9] = (byte)truncated.Length;

        Assert.IsFalse(DisSerializer.TryDeserialize(truncated, out _, out DisParseError error));
        Assert.AreEqual(DisParseErrorCode.InvalidField, error.Code);
    }

    [TestMethod]
    public void TransmitterUsesOctetLengthsAndSynchronizesThemAutomatically()
    {
        var original = (TransmitterPdu)PduFactory.Create(PduType.Transmitter);
        original.ModulationParameters = [1, 2, 3, 4, 0, 0, 0, 0];
        original.AntennaPatternParameters = Enumerable.Range(0, 40).Select(x => (byte)x).ToArray();

        byte[] encoded = DisSerializer.Serialize(original);
        var decoded = Assert.IsInstanceOfType<TransmitterPdu>(DisSerializer.Deserialize(encoded));

        Assert.AreSequenceEqual(original.ModulationParameters, decoded.ModulationParameters);
        Assert.AreSequenceEqual(original.AntennaPatternParameters, decoded.AntennaPatternParameters);
        Assert.AreSequenceEqual(encoded, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
    public void IntercomParameterByteLengthFramesMultipleRecords()
    {
        var original = (IntercomControlPdu)PduFactory.Create(PduType.IntercomControl);
        original.IntercomParameters =
        [
            new() { RecordType = IntercomControlRecordType.SpecificDestinationRecord, RecordLength = 8, RecordSpecificField = [1, 2, 3, 4] },
            new() { RecordType = IntercomControlRecordType.GroupDestinationRecord, RecordLength = 8, RecordSpecificField = [5, 6, 7, 8] },
        ];

        byte[] encoded = DisSerializer.Serialize(original);
        var decoded = Assert.IsInstanceOfType<IntercomControlPdu>(DisSerializer.Deserialize(encoded));

        Assert.AreEqual(2, decoded.IntercomParameters.Count);
        Assert.AreSequenceEqual(new byte[] { 1, 2, 3, 4 }, decoded.IntercomParameters[0].RecordSpecificField);
        Assert.AreSequenceEqual(new byte[] { 5, 6, 7, 8 }, decoded.IntercomParameters[1].RecordSpecificField);
        Assert.AreSequenceEqual(encoded, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
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
        var decoded = Assert.IsInstanceOfType<MinefieldDataPdu>(DisSerializer.Deserialize(encoded));

        Assert.AreEqual(1u, original.DataFilter.BitFlags);
        Assert.AreSequenceEqual(original.GroundBurialDepthOffset, decoded.GroundBurialDepthOffset);
        Assert.AreEqual(0, decoded.WaterBurialDepthOffset.Length);
        Assert.AreSequenceEqual(original.MineEntityNumber, decoded.MineEntityNumber);
        Assert.AreSequenceEqual(encoded, DisSerializer.Serialize(decoded));
    }
}

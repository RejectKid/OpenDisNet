using System.Text;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Enumerations;

[TestClass]
public sealed class SisoEnumerationTests
{
    [TestMethod]
    public void SignalUsesNamedSisoValuesOnTheWire()
    {
        var original = new SignalPdu
        {
            EncodingScheme = SignalEncodingScheme.EncodedAudio(SignalEncodingType.Opus),
            TdlType = SignalTdlType.Link16StandardizedFormatJtidsMidsTadilJ,
            SampleRate = 48_000,
            SampleCount = 1,
        };
        original.SetData("test"u8);

        byte[] bytes = DisSerializer.Serialize(original);
        var decoded = Assert.IsInstanceOfType<SignalPdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual(SignalTdlType.Link16StandardizedFormatJtidsMidsTadilJ, decoded.TdlType);
        Assert.AreEqual(SignalEncodingClass.EncodedAudio, decoded.EncodingScheme.Class);
        Assert.AreEqual(SignalEncodingType.Opus, decoded.EncodingScheme.AudioType);
        Assert.AreEqual("test", Encoding.UTF8.GetString(decoded.Data));
        Assert.AreSequenceEqual(bytes, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
    public void SignalEncodingSchemeSeparatesClassAndFourteenBitDetail()
    {
        SignalEncodingScheme value = SignalEncodingScheme.Data(SignalEncodingClass.RawBinaryData, messageCount: 12);

        Assert.AreEqual(SignalEncodingClass.RawBinaryData, value.Class);
        Assert.AreEqual((ushort)12, value.TypeOrMessageCount);
        Assert.AreEqual((ushort)0x400C, value.Value);
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => value.WithTypeOrMessageCount(0x4000));
    }

    [TestMethod]
    public void UnknownEnumerationValuesRoundTripLosslessly()
    {
        var original = new SignalPdu
        {
            TdlType = (SignalTdlType)0xFEED,
        };

        byte[] bytes = DisSerializer.Serialize(original);
        var decoded = Assert.IsInstanceOfType<SignalPdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual((SignalTdlType)0xFEED, decoded.TdlType);
        Assert.AreSequenceEqual(bytes, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
    public void BitfieldHelpersPreserveReservedBitsAndRoundTrip()
    {
        StopFreezeFrozenBehavior behavior = new StopFreezeFrozenBehavior(0x80)
            .WithRunSimulationClock(true)
            .WithProcessUpdates(true);
        var original = new StopFreezePdu
        {
            Reason = StopFreezeReason.Recess,
            FrozenBehavior = behavior,
        };

        byte[] bytes = DisSerializer.Serialize(original);
        var decoded = Assert.IsInstanceOfType<StopFreezePdu>(DisSerializer.Deserialize(bytes));

        Assert.IsTrue(decoded.FrozenBehavior.RunSimulationClock);
        Assert.IsFalse(decoded.FrozenBehavior.TransmitUpdates);
        Assert.IsTrue(decoded.FrozenBehavior.ProcessUpdates);
        Assert.AreEqual((byte)0x85, decoded.FrozenBehavior.Value);
        Assert.AreSequenceEqual(bytes, DisSerializer.Serialize(decoded));
    }

    [TestMethod]
    public void MultiBitFieldsHaveValidatedImmutableSetters()
    {
        MinefieldDataFusing value = MinefieldDataFusing.None
            .WithPrimary(42)
            .WithSecondary(7)
            .WithHasAntiHandlingDevice(true);

        Assert.AreEqual((ushort)42, value.Primary);
        Assert.AreEqual((ushort)7, value.Secondary);
        Assert.IsTrue(value.HasAntiHandlingDevice);
        Assert.ThrowsExactly<ArgumentOutOfRangeException>(() => value.WithPrimary(128));
    }
}

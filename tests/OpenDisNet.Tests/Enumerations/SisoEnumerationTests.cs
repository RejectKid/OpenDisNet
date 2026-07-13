using System.Text;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Enumerations;

public sealed class SisoEnumerationTests
{
    [Fact]
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
        var decoded = Assert.IsType<SignalPdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(SignalTdlType.Link16StandardizedFormatJtidsMidsTadilJ, decoded.TdlType);
        Assert.Equal(SignalEncodingClass.EncodedAudio, decoded.EncodingScheme.Class);
        Assert.Equal(SignalEncodingType.Opus, decoded.EncodingScheme.AudioType);
        Assert.Equal("test", Encoding.UTF8.GetString(decoded.Data));
        Assert.Equal(bytes, DisSerializer.Serialize(decoded));
    }

    [Fact]
    public void SignalEncodingSchemeSeparatesClassAndFourteenBitDetail()
    {
        SignalEncodingScheme value = SignalEncodingScheme.Data(SignalEncodingClass.RawBinaryData, messageCount: 12);

        Assert.Equal(SignalEncodingClass.RawBinaryData, value.Class);
        Assert.Equal((ushort)12, value.TypeOrMessageCount);
        Assert.Equal((ushort)0x400C, value.Value);
        Assert.Throws<ArgumentOutOfRangeException>(() => value.WithTypeOrMessageCount(0x4000));
    }

    [Fact]
    public void UnknownEnumerationValuesRoundTripLosslessly()
    {
        var original = new SignalPdu
        {
            TdlType = (SignalTdlType)0xFEED,
        };

        byte[] bytes = DisSerializer.Serialize(original);
        var decoded = Assert.IsType<SignalPdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal((SignalTdlType)0xFEED, decoded.TdlType);
        Assert.Equal(bytes, DisSerializer.Serialize(decoded));
    }

    [Fact]
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
        var decoded = Assert.IsType<StopFreezePdu>(DisSerializer.Deserialize(bytes));

        Assert.True(decoded.FrozenBehavior.RunSimulationClock);
        Assert.False(decoded.FrozenBehavior.TransmitUpdates);
        Assert.True(decoded.FrozenBehavior.ProcessUpdates);
        Assert.Equal((byte)0x85, decoded.FrozenBehavior.Value);
        Assert.Equal(bytes, DisSerializer.Serialize(decoded));
    }

    [Fact]
    public void MultiBitFieldsHaveValidatedImmutableSetters()
    {
        MinefieldDataFusing value = MinefieldDataFusing.None
            .WithPrimary(42)
            .WithSecondary(7)
            .WithHasAntiHandlingDevice(true);

        Assert.Equal((ushort)42, value.Primary);
        Assert.Equal((ushort)7, value.Secondary);
        Assert.True(value.HasAntiHandlingDevice);
        Assert.Throws<ArgumentOutOfRangeException>(() => value.WithPrimary(128));
    }
}

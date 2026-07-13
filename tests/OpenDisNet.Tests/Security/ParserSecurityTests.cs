using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using OpenDisNet.Tests.Conformance;

namespace OpenDisNet.Tests.Security;

public sealed class ParserSecurityTests
{
    private static readonly DisParseOptions BoundedOptions = new()
    {
        MaximumPduLength = 4_096,
        RequireExactDatagramLength = true,
        RequireVersion7 = true,
    };

    [Fact]
    public void DeterministicRandomDatagramsNeverEscapeTryDeserialize()
    {
        var random = new Random(0x1278_0001);

        for (int iteration = 0; iteration < 10_000; iteration++)
        {
            int length = iteration < 4_096 ? iteration : random.Next(0, 4_097);
            byte[] datagram = new byte[length];
            random.NextBytes(datagram);

            if (DisSerializer.TryDeserialize(datagram, out IDisPdu? pdu, out DisParseError error, BoundedOptions))
            {
                Assert.NotNull(pdu);
                byte[] canonical = DisSerializer.Serialize(pdu);
                Assert.InRange(canonical.Length, DisHeader.MinimumSize, ushort.MaxValue);
            }
            else
            {
                Assert.NotEqual(DisParseErrorCode.None, error.Code);
                Assert.InRange(error.Offset, 0, Math.Max(datagram.Length, DisHeader.Size));
            }
        }
    }

    [Fact]
    public void BitMutationsAcrossEveryPduNeverEscapeTryDeserialize()
    {
        byte[] masks = [0x01, 0x80, 0xFF];

        foreach (byte value in Enumerable.Range(1, 72).Select(x => (byte)x))
        {
            byte[] valid = DisSerializer.Serialize(DeterministicPduFixture.Create((PduType)value));
            foreach (int offset in Enumerable.Range(0, valid.Length))
            {
                foreach (byte mask in masks)
                {
                    byte[] mutated = (byte[])valid.Clone();
                    mutated[offset] ^= mask;

                    if (DisSerializer.TryDeserialize(mutated, out IDisPdu? parsed, out _, BoundedOptions))
                    {
                        Assert.NotNull(parsed);
                        byte[] canonical = DisSerializer.Serialize(parsed);
                        Assert.InRange(canonical.Length, DisHeader.MinimumSize, ushort.MaxValue);
                    }
                }
            }
        }
    }

    [Fact]
    public void ConfiguredLengthLimitIsEnforcedBeforeBodyParsing()
    {
        byte[] datagram = DisSerializer.Serialize(DeterministicPduFixture.Create(PduType.EntityState));
        var options = new DisParseOptions { MaximumPduLength = datagram.Length - 1 };

        Assert.False(DisSerializer.TryDeserialize(datagram, out _, out DisParseError error, options));
        Assert.Equal(DisParseErrorCode.InvalidLength, error.Code);
        Assert.Equal(8, error.Offset);
    }

    [Fact]
    public void MaximumDeclaredLengthCannotAllocateFromATruncatedDatagram()
    {
        byte[] datagram =
        [
            7, 1, (byte)PduType.EntityState, (byte)ProtocolFamily.EntityInformationInteraction,
            0, 0, 0, 0,
            0xFF, 0xFF,
            0, 0,
        ];

        Assert.False(DisSerializer.TryDeserialize(datagram, out _, out DisParseError error, BoundedOptions));
        Assert.Equal(DisParseErrorCode.InvalidLength, error.Code);
    }
}

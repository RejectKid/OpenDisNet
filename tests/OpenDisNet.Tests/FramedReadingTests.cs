using System.Buffers;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests;

[TestClass]
public sealed class FramedReadingTests
{
    [TestMethod]
    public void PermissiveVersionParsingPreservesNonVersion7Body()
    {
        byte[] body = [0xAA, 0xBB, 0xCC, 0xDD];
        var header = new DisHeader(
            (DisProtocolVersion)6,
            1,
            PduType.EntityState,
            ProtocolFamily.EntityInformationInteraction,
            42,
            0,
            0,
            0);
        byte[] datagram = DisSerializer.Serialize(new UnknownPdu(header, body));

        Assert.IsFalse(DisSerializer.TryDeserialize(datagram, out _, out DisParseError strictError));
        Assert.AreEqual(DisParseErrorCode.UnsupportedProtocolVersion, strictError.Code);

        var options = new DisParseOptions { RequireVersion7 = false };
        Assert.IsTrue(DisSerializer.TryDeserialize(datagram, out IDisPdu? parsed, out _, options));
        UnknownPdu unknown = Assert.IsInstanceOfType<UnknownPdu>(parsed);
        Assert.AreEqual((byte)6, (byte)unknown.Header.ProtocolVersion);
        Assert.AreSequenceEqual(body, unknown.Body.ToArray());
    }

    [TestMethod]
    public void HeaderInspectionDoesNotRequireThePduBody()
    {
        byte[] datagram = DisSerializer.Serialize(new FirePdu());

        Assert.IsTrue(DisSerializer.TryReadHeader(datagram.AsSpan(0, DisHeader.Size), out DisHeader header, out _));
        Assert.AreEqual(PduType.Fire, header.PduType);
        Assert.AreEqual(datagram.Length, header.Length);
    }

    [TestMethod]
    public void FramedSpanReadingConsumesOnePduAtATime()
    {
        byte[] first = DisSerializer.Serialize(new FirePdu());
        byte[] second = DisSerializer.Serialize(new EntityStatePdu());
        byte[] combined = [.. first, .. second];

        Assert.AreEqual(DisReadStatus.Done, DisSerializer.TryRead(combined, out IDisPdu? firstPdu, out int firstConsumed, out _));
        Assert.IsInstanceOfType<FirePdu>(firstPdu);
        Assert.AreEqual(first.Length, firstConsumed);

        Assert.AreEqual(DisReadStatus.Done, DisSerializer.TryRead(combined.AsSpan(firstConsumed), out IDisPdu? secondPdu, out int secondConsumed, out _));
        Assert.IsInstanceOfType<EntityStatePdu>(secondPdu);
        Assert.AreEqual(second.Length, secondConsumed);
    }

    [TestMethod]
    public void SegmentedReadingMatchesContiguousReading()
    {
        byte[] datagram = DisSerializer.Serialize(new EntityStatePdu());
        ReadOnlySequence<byte> sequence = CreateSequence(datagram, split: 5);

        Assert.IsTrue(DisSerializer.TryReadHeader(sequence, out DisHeader header, out _));
        Assert.AreEqual(PduType.EntityState, header.PduType);
        Assert.AreEqual(DisReadStatus.Done, DisSerializer.TryRead(sequence, out IDisPdu? pdu, out int consumed, out _));
        Assert.IsInstanceOfType<EntityStatePdu>(pdu);
        Assert.AreEqual(datagram.Length, consumed);
    }

    [TestMethod]
    public void FramedReadingDistinguishesIncompleteAndInvalidInput()
    {
        byte[] datagram = DisSerializer.Serialize(new FirePdu());
        Assert.AreEqual(DisReadStatus.NeedMoreData, DisSerializer.TryRead(datagram.AsSpan(0, datagram.Length - 1), out _, out int incompleteConsumed, out DisParseError incompleteError));
        Assert.AreEqual(0, incompleteConsumed);
        Assert.AreEqual(DisParseErrorCode.TruncatedPdu, incompleteError.Code);

        byte[] invalid = (byte[])datagram.Clone();
        invalid[8] = 0;
        invalid[9] = 1;
        Assert.AreEqual(DisReadStatus.InvalidData, DisSerializer.TryRead(invalid, out _, out int invalidConsumed, out DisParseError invalidError));
        Assert.AreEqual(0, invalidConsumed);
        Assert.AreEqual(DisParseErrorCode.InvalidLength, invalidError.Code);
    }

    [TestMethod]
    public void FramedReadingHonorsMaximumPduLength()
    {
        byte[] datagram = DisSerializer.Serialize(new EntityStatePdu());
        var options = new DisParseOptions { MaximumPduLength = datagram.Length - 1 };

        Assert.AreEqual(DisReadStatus.InvalidData, DisSerializer.TryRead(datagram, out _, out _, out DisParseError error, options));
        Assert.AreEqual(DisParseErrorCode.InvalidLength, error.Code);
    }

    private static ReadOnlySequence<byte> CreateSequence(byte[] bytes, int split)
    {
        var first = new Segment(bytes.AsMemory(0, split));
        Segment last = first.Append(bytes.AsMemory(split));
        return new ReadOnlySequence<byte>(first, 0, last, last.Memory.Length);
    }

    private sealed class Segment : ReadOnlySequenceSegment<byte>
    {
        public Segment(ReadOnlyMemory<byte> memory) => Memory = memory;

        public Segment Append(ReadOnlyMemory<byte> memory)
        {
            var segment = new Segment(memory) { RunningIndex = RunningIndex + Memory.Length };
            Next = segment;
            return segment;
        }
    }
}

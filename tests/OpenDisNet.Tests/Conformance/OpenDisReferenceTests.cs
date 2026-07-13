using DISnet.DataStreamUtilities;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using OpenDisNet.Records;
using ReferenceFirePdu = DISnet.FirePdu;

namespace OpenDisNet.Tests.Conformance;

public sealed class OpenDisReferenceTests
{
    [Fact]
    public void FirePduBytesAreAcceptedByIndependentReferenceImplementation()
    {
        var header = new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 7, PduType.Fire, ProtocolFamily.Warfare, 123, 0, 0, 0);
        var expected = new FirePdu(
            header,
            new(1, 2, 3),
            new(4, 5, 6),
            new(7, 8, 9),
            new(new(10, 11), 12),
            13,
            new(14, 15, 16),
            new(new(2, 1, 225, 3, 4, 5, 6), 100, 200, 3, 4),
            new(17, 18, 19),
            20);

        byte[] bytes = DisPduWriter.Write(expected);
        var reference = new ReferenceFirePdu();
        reference.Unmarshal(new DataInputStream(bytes, Endian.Big));

        Assert.Equal((byte)7, reference.ProtocolVersion);
        Assert.Equal((ushort)96, reference.Length);
        Assert.Equal((ushort)1, reference.FiringEntityID.SimulationAddress.Site);
        Assert.Equal((ushort)6, reference.TargetEntityID.EntityNumber);
        Assert.Equal((uint)13, reference.FireMissionIndex);
        Assert.Equal(20F, reference.Range);
    }
}

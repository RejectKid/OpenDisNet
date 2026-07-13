using DISnet.DataStreamUtilities;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using ReferenceFirePdu = DISnet.FirePdu;

namespace OpenDisNet.Tests.Conformance;

public sealed class OpenDisReferenceTests
{
    [Fact]
    public void FirePduBytesAreAcceptedByIndependentReferenceImplementation()
    {
        var expected = (FirePdu)PduFactory.Create(PduType.Fire, exerciseId: 7);
        expected.Timestamp = 123;
        expected.FiringEntityId = new EntityId(1, 2, 3);
        expected.TargetEntityId = new EntityId(4, 5, 6);
        expected.FireMissionIndex = 13;
        expected.Range = 20;

        byte[] bytes = DisSerializer.Serialize(expected);
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

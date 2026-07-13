using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

public sealed class GeneratedPduFactoryTests
{
    [Fact]
    public void FactoryCreatesEveryStandardizedPduWithVersionAndFamily()
    {
        for (byte value = 1; value <= 72; value++)
        {
            Pdu pdu = PduFactory.Create((PduType)value, exerciseId: 19);

            Assert.IsAssignableFrom<IDisPdu>(pdu);
            Assert.Equal(value, (byte)pdu.Header.PduType);
            Assert.Equal(DisProtocolVersion.Ieee1278_1_2012, pdu.Header.ProtocolVersion);
            Assert.Equal((byte)19, pdu.Header.ExerciseId);
            Assert.NotEqual(ProtocolFamily.Other, pdu.Header.ProtocolFamily);
        }
    }
}

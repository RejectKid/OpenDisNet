using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

[TestClass]
public sealed class PduFactoryTests
{
    [TestMethod]
    public void CreatesEveryStandardizedPduWithVersionAndFamily()
    {
        for (byte value = 1; value <= 72; value++)
        {
            Pdu pdu = PduFactory.Create((PduType)value, exerciseId: 19);

            Assert.IsInstanceOfType<IDisPdu>(pdu);
            Assert.AreEqual(value, (byte)pdu.Header.PduType);
            Assert.AreEqual(DisProtocolVersion.Ieee1278_1_2012, pdu.Header.ProtocolVersion);
            Assert.AreEqual((byte)19, pdu.Header.ExerciseId);
            Assert.AreNotEqual(ProtocolFamily.Other, pdu.Header.ProtocolFamily);
        }
    }
}

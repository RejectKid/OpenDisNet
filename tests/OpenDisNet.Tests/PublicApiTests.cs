using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests;

[TestClass]
public sealed class PublicApiTests
{
    [TestMethod]
    public void ProtocolModelsUseOneConsumerNamespace()
    {
        Type[] exported = typeof(Pdu).Assembly.GetExportedTypes();

        Assert.IsFalse(exported.Any(
            x => x.Namespace is "OpenDisNet.Dis7" or "OpenDisNet.Generated" or "OpenDisNet.Records"));
        Assert.AreEqual(72, exported.Count(x => x.Namespace == "OpenDisNet.Pdus" && typeof(Pdu).IsAssignableFrom(x) && !x.IsAbstract));
    }

    [TestMethod]
    public void DerivedWireCountsAreNotPartOfThePublicModel()
    {
        Assert.IsNull(typeof(EntityStatePdu).GetProperty("NumberOfVariableParameters"));
        Assert.IsNull(typeof(SignalPdu).GetProperty("DataLength"));
        Assert.IsNull(typeof(TransmitterPdu).GetProperty("ModulationParameterCount"));
        Assert.IsNotNull(typeof(SignalPdu).GetProperty("DataBitLength"));
    }

    [TestMethod]
    public void EveryConcretePduCanBeConstructedWithCorrectWireIdentity()
    {
        foreach (byte value in Enumerable.Range(1, 72).Select(x => (byte)x))
        {
            Pdu factoryPdu = PduFactory.Create((PduType)value);
            var directlyCreated = Assert.IsInstanceOfType<Pdu>(Activator.CreateInstance(factoryPdu.GetType()));

            Assert.AreEqual((PduType)value, directlyCreated.Header.PduType);
            Assert.AreEqual(DisProtocolVersion.Ieee1278_1_2012, directlyCreated.Header.ProtocolVersion);
            Assert.AreNotEqual(ProtocolFamily.Other, directlyCreated.Header.ProtocolFamily);
        }
    }
}

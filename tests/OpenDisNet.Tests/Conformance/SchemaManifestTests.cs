using OpenDisNet.Internal;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

[TestClass]
public sealed class SchemaManifestTests
{
    [TestMethod]
    public void ManifestCoversEveryStandardizedDis7PduType()
    {
        Assert.AreSequenceEqual(
            Enumerable.Range(1, 72).Select(x => (byte)x),
            Dis7SchemaManifest.Pdus.ToArray().Select(x => x.Type));
        Assert.AreEqual(72, Dis7SchemaManifest.Pdus.ToArray().Select(x => x.ModelName).Distinct(StringComparer.Ordinal).Count());
        foreach (var descriptor in Dis7SchemaManifest.Pdus)
            Assert.AreEqual(descriptor.ModelName, PduFactory.Create((PduType)descriptor.Type).GetType().Name);
    }

    [TestMethod]
    public void EverySchemaClassHasAGeneratedPublicModel()
    {
        Type[] models = typeof(OpenDisNet.Pdus.EntityStatePdu).Assembly
            .GetExportedTypes()
            .Where(x => x.Namespace == "OpenDisNet.Pdus")
            .Where(x => x.IsClass && x.Name != "UnknownPdu")
            .Where(x => !(x.IsAbstract && x.IsSealed))
            .ToArray();

        Assert.AreEqual(233, models.Length);
        foreach (var descriptor in Dis7SchemaManifest.Pdus)
            Assert.IsTrue(models.Any(x => x.Name == descriptor.ModelName));
    }
}

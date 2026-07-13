using OpenDisNet.Internal;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

public sealed class SchemaManifestTests
{
    [Fact]
    public void ManifestCoversEveryStandardizedDis7PduType()
    {
        Assert.Equal(233, Dis7SchemaManifest.ClassCount);
        Assert.Equal(72, Dis7SchemaManifest.PduCount);
        Assert.Equal(Enumerable.Range(1, 72).Select(x => (byte)x), Dis7SchemaManifest.Pdus.ToArray().Select(x => x.Type));
        Assert.Equal(72, Dis7SchemaManifest.Pdus.ToArray().Select(x => x.ModelName).Distinct(StringComparer.Ordinal).Count());
        foreach (var descriptor in Dis7SchemaManifest.Pdus)
            Assert.Equal(descriptor.ModelName, PduFactory.Create((PduType)descriptor.Type).GetType().Name);
    }

    [Fact]
    public void EverySchemaClassHasAGeneratedPublicModel()
    {
        Type[] models = typeof(OpenDisNet.Pdus.EntityStatePdu).Assembly
            .GetExportedTypes()
            .Where(x => x.Namespace == "OpenDisNet.Pdus")
            .Where(x => x.IsClass && x.Name != "UnknownPdu")
            .Where(x => !(x.IsAbstract && x.IsSealed))
            .ToArray();

        Assert.Equal(233, models.Length);
        foreach (var descriptor in Dis7SchemaManifest.Pdus)
            Assert.Contains(models, x => x.Name == descriptor.ModelName);
    }
}

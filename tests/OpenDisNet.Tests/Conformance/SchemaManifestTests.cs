using OpenDisNet.Generated;

namespace OpenDisNet.Tests.Conformance;

public sealed class SchemaManifestTests
{
    [Fact]
    public void ManifestCoversEveryStandardizedDis7PduType()
    {
        Assert.Equal(253, Dis7SchemaManifest.ClassCount);
        Assert.Equal(72, Dis7SchemaManifest.PduCount);
        Assert.Equal(Enumerable.Range(1, 72).Select(x => (byte)x), Dis7SchemaManifest.Pdus.ToArray().Select(x => x.Type));
        Assert.Equal(72, Dis7SchemaManifest.Pdus.ToArray().Select(x => x.ModelName).Distinct(StringComparer.Ordinal).Count());
    }
}

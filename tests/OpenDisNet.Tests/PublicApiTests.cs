using OpenDisNet.Pdus;

namespace OpenDisNet.Tests;

public sealed class PublicApiTests
{
    [Fact]
    public void ProtocolModelsUseOneConsumerNamespace()
    {
        Type[] exported = typeof(Pdu).Assembly.GetExportedTypes();

        Assert.DoesNotContain(exported, x => x.Namespace is "OpenDisNet.Dis7" or "OpenDisNet.Generated" or "OpenDisNet.Records");
        Assert.Equal(72, exported.Count(x => x.Namespace == "OpenDisNet.Pdus" && typeof(Pdu).IsAssignableFrom(x) && !x.IsAbstract));
    }

    [Fact]
    public void DerivedWireCountsAreNotPartOfThePublicModel()
    {
        Assert.Null(typeof(EntityStatePdu).GetProperty("NumberOfVariableParameters"));
        Assert.Null(typeof(SignalPdu).GetProperty("DataLength"));
        Assert.Null(typeof(TransmitterPdu).GetProperty("ModulationParameterCount"));
        Assert.NotNull(typeof(SignalPdu).GetProperty("DataBitLength"));
    }
}

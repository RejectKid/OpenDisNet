using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using OpenDisNet.Records;

namespace OpenDisNet.Tests.Pdus;

public sealed class EntityStatePduTests
{
    [Fact]
    public void EntityStatePduRoundTrips()
    {
        var header = new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 4, PduType.EntityState, ProtocolFamily.EntityInformationInteraction, 44, 0, 0, 0);
        var expected = new EntityStatePdu(header, new(1, 2, 3), 2, new(1, 1, 225, 2, 3, 4, 5), default,
            new(10, 20, 30), new(100, 200, 300), new(1, 2, 3), 0x10203040,
            new(4, new(0, 0, 0), new(0, 0, 0)), new(1, "EAGLE-1"), 7, Array.Empty<VariableParameter>());

        byte[] bytes = DisPduWriter.Write(expected);
        var actual = Assert.IsType<EntityStatePdu>(DisPduReader.Parse(bytes));

        Assert.Equal(144, bytes.Length);
        Assert.Equal("EAGLE-1", actual.Marking.Text);
        Assert.Equal(header with { Length = 144 }, actual.Header);
        Assert.Equal(expected.EntityId, actual.EntityId);
        Assert.Equal(expected.EntityType, actual.EntityType);
        Assert.Equal(expected.Location, actual.Location);
        Assert.Equal(expected.Orientation, actual.Orientation);
        Assert.Equal(expected.DeadReckoning.Algorithm, actual.DeadReckoning.Algorithm);
        Assert.Equal(expected.DeadReckoning.OtherParameters.ToArray(), actual.DeadReckoning.OtherParameters.ToArray());
        Assert.Empty(actual.VariableParameters);
    }
}

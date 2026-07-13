using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Pdus;

public sealed class WarfarePduTests
{
    [Fact]
    public void FirePduRoundTrips()
    {
        var expected = (FirePdu)PduFactory.Create(PduType.Fire, exerciseId: 1);
        expected.FiringEntityId = new() { SiteId = 1, ApplicationId = 2, EntityId = 3 };
        expected.TargetEntityId = new() { SiteId = 1, ApplicationId = 2, EntityId = 4 };
        expected.MunitionExpendibleId = new() { SiteId = 1, ApplicationId = 2, EntityId = 5 };
        expected.FireMissionIndex = 7;
        expected.Range = 5_000;

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsType<FirePdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(96, bytes.Length);
        Assert.Equal((ushort)3, actual.FiringEntityId.EntityId);
        Assert.Equal(5_000, actual.Range);
    }

    [Fact]
    public void DetonationPduRoundTripsVariableParameters()
    {
        var expected = (DetonationPdu)PduFactory.Create(PduType.Detonation);
        expected.VariableParameters.Add(new()
        {
            RecordType = 5,
            RecordSpecificFields = Enumerable.Range(1, 15).Select(x => (byte)x).ToArray(),
        });

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsType<DetonationPdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(120, bytes.Length);
        Assert.Equal(expected.VariableParameters[0].RecordSpecificFields, actual.VariableParameters[0].RecordSpecificFields);
    }
}

using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Pdus;

public sealed class WarfarePduTests
{
    [Fact]
    public void FirePduRoundTrips()
    {
        var expected = (FirePdu)PduFactory.Create(PduType.Fire, exerciseId: 1);
        expected.FiringEntityId = new EntityId(1, 2, 3);
        expected.TargetEntityId = new EntityId(1, 2, 4);
        expected.MunitionExpendibleId = new EntityId(1, 2, 5);
        expected.FireMissionIndex = 7;
        expected.Range = 5_000;

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsType<FirePdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(96, bytes.Length);
        Assert.Equal((ushort)3, actual.FiringEntityId.EntityNumber);
        Assert.Equal(5_000, actual.Range);
    }

    [Fact]
    public void DetonationPduRoundTripsVariableParameters()
    {
        var expected = (DetonationPdu)PduFactory.Create(PduType.Detonation);
        expected.VariableParameters.Add(new()
        {
            RecordType = (VariableParameterRecordType)5,
            RecordSpecificFields = Enumerable.Range(1, 15).Select(x => (byte)x).ToArray(),
        });

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsType<DetonationPdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(120, bytes.Length);
        Assert.Equal(expected.VariableParameters[0].RecordSpecificFields, actual.VariableParameters[0].RecordSpecificFields);
    }
}

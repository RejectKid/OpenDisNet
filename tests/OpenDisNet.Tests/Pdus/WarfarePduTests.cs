using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Pdus;

[TestClass]
public sealed class WarfarePduTests
{
    [TestMethod]
    public void FirePduRoundTrips()
    {
        var expected = (FirePdu)PduFactory.Create(PduType.Fire, exerciseId: 1);
        expected.FiringEntityId = new EntityId(1, 2, 3);
        expected.TargetEntityId = new EntityId(1, 2, 4);
        expected.MunitionExpendibleId = new EntityId(1, 2, 5);
        expected.FireMissionIndex = 7;
        expected.Range = 5_000;

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsInstanceOfType<FirePdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual(96, bytes.Length);
        Assert.AreEqual((ushort)3, actual.FiringEntityId.EntityNumber);
        Assert.AreEqual(5_000, actual.Range);
    }

    [TestMethod]
    public void DetonationPduRoundTripsVariableParameters()
    {
        var expected = (DetonationPdu)PduFactory.Create(PduType.Detonation);
        expected.VariableParameters.Add(new()
        {
            RecordType = (VariableParameterRecordType)5,
            RecordSpecificFields = Enumerable.Range(1, 15).Select(x => (byte)x).ToArray(),
        });

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsInstanceOfType<DetonationPdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual(120, bytes.Length);
        Assert.AreSequenceEqual(
            expected.VariableParameters[0].RecordSpecificFields,
            actual.VariableParameters[0].RecordSpecificFields);
    }
}

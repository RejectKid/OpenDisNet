using System.Text;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Pdus;

[TestClass]
public sealed class EntityStatePduTests
{
    [TestMethod]
    public void EntityStatePduUsesObjectInitializerAndRoundTrips()
    {
        var expected = (EntityStatePdu)PduFactory.Create(PduType.EntityState, exerciseId: 4);
        expected.EntityId = new EntityId(1, 2, 3);
        expected.ForceId = ForceId.Opposing;
        expected.EntityLocation = new() { X = 100, Y = 200, Z = 300 };
        expected.EntityOrientation = new() { Psi = 1, Theta = 2, Phi = 3 };
        expected.Marking.CharacterSet = EntityMarkingCharacterSet.Ascii;
        Encoding.ASCII.GetBytes("EAGLE-1").CopyTo(expected.Marking.Characters, 0);

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsInstanceOfType<EntityStatePdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual(144, bytes.Length);
        Assert.AreEqual((ushort)3, actual.EntityId.EntityNumber);
        Assert.AreEqual(300, actual.EntityLocation.Z);
        StringAssert.StartsWith(Encoding.ASCII.GetString(actual.Marking.Characters), "EAGLE-1");
    }
}

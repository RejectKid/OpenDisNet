using System.Text;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Pdus;

public sealed class EntityStatePduTests
{
    [Fact]
    public void EntityStatePduUsesObjectInitializerAndRoundTrips()
    {
        var expected = (EntityStatePdu)PduFactory.Create(PduType.EntityState, exerciseId: 4);
        expected.EntityId = new EntityId(1, 2, 3);
        expected.ForceId = 2;
        expected.EntityLocation = new() { X = 100, Y = 200, Z = 300 };
        expected.EntityOrientation = new() { Psi = 1, Theta = 2, Phi = 3 };
        expected.Marking.CharacterSet = 1;
        Encoding.ASCII.GetBytes("EAGLE-1").CopyTo(expected.Marking.Characters, 0);

        byte[] bytes = DisSerializer.Serialize(expected);
        var actual = Assert.IsType<EntityStatePdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(144, bytes.Length);
        Assert.Equal((ushort)3, actual.EntityId.EntityNumber);
        Assert.Equal(300, actual.EntityLocation.Z);
        Assert.StartsWith("EAGLE-1", Encoding.ASCII.GetString(actual.Marking.Characters));
    }
}

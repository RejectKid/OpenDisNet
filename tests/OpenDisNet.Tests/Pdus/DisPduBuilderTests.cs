using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;

namespace OpenDisNet.Tests.Pdus;

[TestClass]
public sealed class DisPduBuilderTests
{
    [TestMethod]
    public void EntityStateBuilderCreatesRoundTrippablePdu()
    {
        EntityStatePdu pdu = DisPduBuilder.CreateEntityState(
            new EntityId(1, 2, 3),
            new EntityType { EntityKind = EntityKind.Platform },
            new Vector3Double { X = 10, Y = 20, Z = 30 },
            ForceId.Friendly,
            exerciseId: 4);

        EntityStatePdu parsed = DisSerializer.Deserialize<EntityStatePdu>(DisSerializer.Serialize(pdu));
        Assert.AreEqual((byte)4, parsed.ExerciseId);
        Assert.AreEqual((ushort)3, parsed.EntityId.EntityNumber);
        Assert.AreEqual(30, parsed.EntityLocation.Z);
    }

    [TestMethod]
    public void FireAndDetonationBuildersDeriveEventAddress()
    {
        var source = new EntityId(10, 20, 30);
        var target = new EntityId(10, 20, 31);
        var munition = new EntityId(10, 20, 32);
        var descriptor = new MunitionDescriptor { Quantity = 1 };
        var location = new Vector3Double { X = 100, Y = 200, Z = 300 };
        var velocity = new Vector3Float { X = 1, Y = 2, Z = 3 };

        FirePdu fire = DisPduBuilder.CreateFire(source, target, munition, 99, descriptor, location, velocity, range: 500);
        DetonationPdu detonation = DisPduBuilder.CreateDetonation(source, target, munition, 99, descriptor, location, velocity, DetonationResult.EntityImpact);

        Assert.AreEqual((ushort)10, fire.EventId.SimulationAddress.Site);
        Assert.AreEqual((ushort)20, fire.EventId.SimulationAddress.Application);
        Assert.AreEqual((ushort)99, detonation.EventId.EventNumber);
        Assert.IsInstanceOfType<FirePdu>(DisSerializer.Deserialize(DisSerializer.Serialize(fire)));
        Assert.IsInstanceOfType<DetonationPdu>(DisSerializer.Deserialize(DisSerializer.Serialize(detonation)));
    }

    [TestMethod]
    public void TransmitterBuilderPopulatesRadioAndOperatingState()
    {
        TransmitterPdu transmitter = DisPduBuilder.CreateTransmitter(
            new RadioId(new EntityId(1, 2, 3), 7),
            new RadioType(),
            frequency: 225_000_000,
            power: 50);

        Assert.AreEqual((ushort)7, transmitter.RadioHeader.RadioNumber);
        Assert.AreEqual(TransmitterTransmitState.OnAndTransmitting, transmitter.TransmitState);
        Assert.IsInstanceOfType<TransmitterPdu>(DisSerializer.Deserialize(DisSerializer.Serialize(transmitter)));
    }
}

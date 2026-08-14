using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using OpenDisNet.Validation;

namespace OpenDisNet.Tests.Validation;

[TestClass]
public sealed class DisValidatorTests
{
    [TestMethod]
    public void BuilderOutputPassesSemanticValidation()
    {
        EntityStatePdu pdu = DisPduBuilder.CreateEntityState(
            new EntityId(1, 2, 3),
            new EntityType { EntityKind = EntityKind.Platform },
            new Vector3Double { X = 1, Y = 2, Z = 3 });

        DisValidationResult result = DisValidator.Validate(pdu);
        Assert.IsTrue(result.IsValid);
        Assert.IsFalse(result.HasWarnings);
        Assert.HasCount(0, result.Issues);
    }

    [TestMethod]
    public void ValidatorReportsNumericAndDiscriminatorErrors()
    {
        var fire = new FirePdu
        {
            FiringEntityId = new EntityId(1, 2, 3),
            Range = -1,
            Velocity = new Vector3Float { X = float.NaN },
            ProtocolFamily = ProtocolFamily.RadioCommunications,
        };

        DisValidationResult result = DisValidator.Validate(fire);
        Assert.IsFalse(result.IsValid);
        Assert.IsTrue(result.Issues.Any(issue => issue.Path == nameof(FirePdu.Range)));
        Assert.IsTrue(result.Issues.Any(issue => issue.Path == $"{nameof(FirePdu.Velocity)}.{nameof(Vector3Float.X)}"));
        Assert.IsTrue(result.Issues.Any(issue => issue.Path == nameof(Pdu.ProtocolFamily)));
    }

    [TestMethod]
    public void ValidatorReportsIncompleteTransmitterAndWarnings()
    {
        var transmitter = new TransmitterPdu
        {
            TransmitState = TransmitterTransmitState.OnAndTransmitting,
            Power = 1,
        };

        DisValidationResult result = DisValidator.Validate(transmitter);
        Assert.IsFalse(result.IsValid);
        Assert.IsTrue(result.HasWarnings);
        Assert.IsTrue(result.Issues.Any(issue => issue.Path == nameof(TransmitterPdu.Frequency)));
        Assert.IsTrue(result.Issues.Any(issue => issue.Severity == DisValidationSeverity.Warning));
    }

    [TestMethod]
    public void ValidatorReportsNullRequiredModelsWithoutThrowing()
    {
        var entity = new EntityStatePdu
        {
            EntityId = null!,
            EntityLocation = null!,
            EntityOrientation = null!,
        };

        DisValidationResult result = DisValidator.Validate(entity);
        Assert.IsFalse(result.IsValid);
        Assert.IsTrue(result.Issues.Any(issue => issue.Path == nameof(EntityStatePdu.EntityId)));
        Assert.IsTrue(result.Issues.Any(issue => issue.Path == nameof(EntityStatePdu.EntityLocation)));
    }
}

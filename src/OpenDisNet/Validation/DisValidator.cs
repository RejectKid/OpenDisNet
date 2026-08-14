using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Validation;

/// <summary>Performs non-mutating semantic checks separately from wire-format parsing.</summary>
public static class DisValidator
{
    /// <summary>Validates discriminator consistency and common PDU-specific numeric invariants.</summary>
    public static DisValidationResult Validate(IDisPdu pdu)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        var issues = new List<DisValidationIssue>();

        if (pdu is Pdu typed)
            ValidateDiscriminators(typed, issues);

        switch (pdu)
        {
            case EntityStatePdu entityState:
                ValidateVector(entityState.EntityLocation, nameof(EntityStatePdu.EntityLocation), issues);
                ValidateVector(entityState.EntityLinearVelocity, nameof(EntityStatePdu.EntityLinearVelocity), issues);
                ValidateAngles(entityState.EntityOrientation, nameof(EntityStatePdu.EntityOrientation), issues);
                WarnIfUnset(entityState.EntityId, nameof(EntityStatePdu.EntityId), issues);
                break;
            case FirePdu fire:
                ValidateVector(fire.LocationInWorldCoordinates, nameof(FirePdu.LocationInWorldCoordinates), issues);
                ValidateVector(fire.Velocity, nameof(FirePdu.Velocity), issues);
                ValidateNonNegative(fire.Range, nameof(FirePdu.Range), issues);
                WarnIfUnset(fire.FiringEntityId, nameof(FirePdu.FiringEntityId), issues);
                break;
            case DetonationPdu detonation:
                ValidateVector(detonation.LocationInWorldCoordinates, nameof(DetonationPdu.LocationInWorldCoordinates), issues);
                ValidateVector(detonation.LocationOfEntityCoordinates, nameof(DetonationPdu.LocationOfEntityCoordinates), issues);
                ValidateVector(detonation.Velocity, nameof(DetonationPdu.Velocity), issues);
                WarnIfUnset(detonation.SourceEntityId, nameof(DetonationPdu.SourceEntityId), issues);
                break;
            case TransmitterPdu transmitter:
                ValidateNonNegative(transmitter.Power, nameof(TransmitterPdu.Power), issues);
                ValidateNonNegative(transmitter.TransmitFrequencyBandwidth, nameof(TransmitterPdu.TransmitFrequencyBandwidth), issues);
                if (transmitter.TransmitState == TransmitterTransmitState.OnAndTransmitting && transmitter.Frequency == 0)
                    AddError(issues, nameof(TransmitterPdu.Frequency), "A transmitting radio must specify a non-zero frequency.");
                if (transmitter.RadioHeader is null)
                    AddError(issues, nameof(TransmitterPdu.RadioHeader), "The radio header is required.");
                else
                    WarnIfUnset(transmitter.RadioHeader.RadioReferenceId, $"{nameof(TransmitterPdu.RadioHeader)}.{nameof(RadioCommsHeader.RadioReferenceId)}", issues);
                break;
            case SignalPdu signal:
                ValidateSignalData(signal, issues);
                break;
        }

        return new DisValidationResult(issues.ToArray());
    }

    private static void ValidateDiscriminators(Pdu pdu, List<DisValidationIssue> issues)
    {
        if (pdu.ProtocolVersion != DisProtocolVersion.Ieee1278_1_2012)
            AddError(issues, nameof(Pdu.ProtocolVersion), "Typed OpenDisNet PDUs use DIS protocol version 7.");

        try
        {
            Pdu expected = PduFactory.Create(pdu.PduType);
            if (expected.GetType() != pdu.GetType())
                AddError(issues, nameof(Pdu.PduType), $"{pdu.GetType().Name} cannot use PDU type {pdu.PduType}.");
            if (expected.ProtocolFamily != pdu.ProtocolFamily)
                AddError(issues, nameof(Pdu.ProtocolFamily), $"{pdu.GetType().Name} belongs to protocol family {expected.ProtocolFamily}.");
        }
        catch (ArgumentOutOfRangeException)
        {
            AddError(issues, nameof(Pdu.PduType), $"PDU type {(byte)pdu.PduType} is not a standardized DIS v7 type.");
        }
    }

    private static void ValidateSignalData(SignalPdu signal, List<DisValidationIssue> issues)
    {
        if (signal.Data is null)
        {
            AddError(issues, nameof(SignalPdu.Data), "Signal data is required.");
            return;
        }

        int maximumBits = checked(signal.Data.Length * 8);
        int minimumBits = signal.Data.Length == 0 ? 0 : checked((signal.Data.Length - 1) * 8 + 1);
        if (signal.DataBitLength < minimumBits || signal.DataBitLength > maximumBits)
            AddError(issues, nameof(SignalPdu.DataBitLength), "The meaningful bit length must describe every supplied octet, allowing only unused bits in the final octet.");
    }

    private static void ValidateAngles(EulerAngles? value, string path, List<DisValidationIssue> issues)
    {
        if (value is null)
        {
            AddError(issues, path, "The value is required.");
            return;
        }
        ValidateFinite(value.Psi, $"{path}.{nameof(EulerAngles.Psi)}", issues);
        ValidateFinite(value.Theta, $"{path}.{nameof(EulerAngles.Theta)}", issues);
        ValidateFinite(value.Phi, $"{path}.{nameof(EulerAngles.Phi)}", issues);
    }

    private static void ValidateVector(Vector3Double? value, string path, List<DisValidationIssue> issues)
    {
        if (value is null)
        {
            AddError(issues, path, "The value is required.");
            return;
        }
        ValidateFinite(value.X, $"{path}.{nameof(Vector3Double.X)}", issues);
        ValidateFinite(value.Y, $"{path}.{nameof(Vector3Double.Y)}", issues);
        ValidateFinite(value.Z, $"{path}.{nameof(Vector3Double.Z)}", issues);
    }

    private static void ValidateVector(Vector3Float? value, string path, List<DisValidationIssue> issues)
    {
        if (value is null)
        {
            AddError(issues, path, "The value is required.");
            return;
        }
        ValidateFinite(value.X, $"{path}.{nameof(Vector3Float.X)}", issues);
        ValidateFinite(value.Y, $"{path}.{nameof(Vector3Float.Y)}", issues);
        ValidateFinite(value.Z, $"{path}.{nameof(Vector3Float.Z)}", issues);
    }

    private static void ValidateNonNegative(float value, string path, List<DisValidationIssue> issues)
    {
        ValidateFinite(value, path, issues);
        if (float.IsFinite(value) && value < 0)
            AddError(issues, path, "The value cannot be negative.");
    }

    private static void ValidateFinite(double value, string path, List<DisValidationIssue> issues)
    {
        if (!double.IsFinite(value))
            AddError(issues, path, "The value must be finite.");
    }

    private static void WarnIfUnset(EntityId? entityId, string path, List<DisValidationIssue> issues)
    {
        if (entityId is null)
        {
            AddError(issues, path, "The entity identifier is required.");
            return;
        }
        if (entityId.SiteId == 0 && entityId.ApplicationId == 0 && entityId.EntityNumber == 0)
            issues.Add(new(DisValidationSeverity.Warning, path, "The entity identifier is unset."));
    }

    private static void AddError(List<DisValidationIssue> issues, string path, string message) =>
        issues.Add(new(DisValidationSeverity.Error, path, message));
}

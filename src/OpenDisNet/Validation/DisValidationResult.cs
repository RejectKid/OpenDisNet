namespace OpenDisNet.Validation;

/// <summary>Contains the non-mutating semantic validation result for a PDU.</summary>
public sealed class DisValidationResult
{
    internal DisValidationResult(IReadOnlyList<DisValidationIssue> issues) => Issues = issues;

    /// <summary>Gets every issue in deterministic field order.</summary>
    public IReadOnlyList<DisValidationIssue> Issues { get; }

    /// <summary>Gets whether validation found no errors. Warnings do not make a result invalid.</summary>
    public bool IsValid => !Issues.Any(issue => issue.Severity == DisValidationSeverity.Error);

    /// <summary>Gets whether validation found at least one warning.</summary>
    public bool HasWarnings => Issues.Any(issue => issue.Severity == DisValidationSeverity.Warning);
}

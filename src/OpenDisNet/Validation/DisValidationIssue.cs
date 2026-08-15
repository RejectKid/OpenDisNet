namespace OpenDisNet.Validation;

/// <summary>Severity assigned to a semantic validation issue.</summary>
public enum DisValidationSeverity
{
    /// <summary>The value is legal on the wire but is likely incomplete or unintended.</summary>
    Warning,

    /// <summary>The value is internally inconsistent or cannot represent a meaningful PDU.</summary>
    Error,
}

/// <summary>Describes one semantic issue in a decoded or constructed PDU.</summary>
public sealed class DisValidationIssue
{
    internal DisValidationIssue(DisValidationSeverity severity, string path, string message)
    {
        Severity = severity;
        Path = path;
        Message = message;
    }

    /// <summary>Gets the severity of the issue.</summary>
    public DisValidationSeverity Severity { get; }

    /// <summary>Gets the property path associated with the issue.</summary>
    public string Path { get; }

    /// <summary>Gets the human-readable explanation.</summary>
    public string Message { get; }
}

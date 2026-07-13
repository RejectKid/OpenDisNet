namespace OpenDisNet.Binary;

public sealed class DisParseException : Exception
{
    public DisParseException(int offset, string field, int required, int remaining)
        : base($"Field '{field}' requires {required} bytes at offset {offset}, but only {remaining} remain.")
    {
        Offset = offset;
        Field = field;
        RequiredBytes = required;
        RemainingBytes = remaining;
    }

    public int Offset { get; }
    public string Field { get; }
    public int RequiredBytes { get; }
    public int RemainingBytes { get; }
}

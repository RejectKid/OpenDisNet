namespace OpenDisNet;

public sealed record DisParseOptions
{
    public static DisParseOptions Default { get; } = new();
    public bool RequireVersion7 { get; init; } = true;
    public bool RequireExactDatagramLength { get; init; } = false;
    public int MaximumPduLength { get; init; } = ushort.MaxValue;
}

namespace OpenDisNet.Generator;

internal static class PublicNames
{
    private static readonly (string Source, string Replacement)[] Acronyms =
    [
        ("DIS", "Dis"),
        ("IFF", "Iff"),
        ("TDL", "Tdl"),
        ("UA", "Ua"),
        ("IO", "Io"),
        ("VP", "Vp"),
        ("DE", "De"),
        ("EE", "Ee"),
        ("ID", "Id"),
    ];

    public static string SisoType(string name, int uid) => uid switch
    {
        3 => "DisProtocolVersion",
        4 => "PduType",
        5 => "ProtocolFamily",
        _ => Acronyms.Aggregate(name, (current, item) => current.Replace(item.Source, item.Replacement, StringComparison.Ordinal)),
    };

    public static bool IsProtocolHeaderType(int uid) => uid is 3 or 4 or 5;
}

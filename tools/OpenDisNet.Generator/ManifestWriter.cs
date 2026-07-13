using System.Text;

namespace OpenDisNet.Generator;

internal static class ManifestWriter
{
    public static string Create(DisSchema schema)
    {
        var text = new StringBuilder();
        text.AppendLine("// Internal catalog used to audit DIS v7 source coverage.");
        text.AppendLine("using OpenDisNet.Protocol;");
        text.AppendLine();
        text.AppendLine("namespace OpenDisNet.Internal;");
        text.AppendLine();
        text.AppendLine("internal static class Dis7SchemaManifest");
        text.AppendLine("{");
        text.AppendLine($"    public const int ClassCount = {schema.Classes.Length};");
        text.AppendLine($"    public const int PduCount = {schema.Pdus.Length};");
        text.AppendLine("    private static readonly DisPduDescriptor[] Entries =");
        text.AppendLine("    [");
        foreach (PduDefinition pdu in schema.Pdus)
            text.AppendLine($"        new({pdu.Type}, \"{Escape(pdu.Name)}\", \"{Escape(pdu.SourceFile)}\"),");
        text.AppendLine("    ];");
        text.AppendLine();
        text.AppendLine("    public static ReadOnlySpan<DisPduDescriptor> Pdus => Entries;");
        text.AppendLine("}");
        return text.ToString().ReplaceLineEndings("\n");
    }

    private static string Escape(string value) => value.Replace("\\", "\\\\", StringComparison.Ordinal).Replace("\"", "\\\"", StringComparison.Ordinal);
}

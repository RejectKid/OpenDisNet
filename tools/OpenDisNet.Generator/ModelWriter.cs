using System.Text;

namespace OpenDisNet.Generator;

internal static class ModelWriter
{
    public static string Create(DisSchema schema, string sourceFile)
    {
        var text = new StringBuilder();
        text.AppendLine($"// DIS v7 protocol models reviewed from {sourceFile}.");
        text.AppendLine("#pragma warning disable CS0108");
        text.AppendLine("using OpenDisNet.Enumerations;");
        text.AppendLine("using OpenDisNet.Protocol;");
        text.AppendLine();
        text.AppendLine("namespace OpenDisNet.Pdus;");
        text.AppendLine();

        foreach (ClassDefinition definition in schema.Classes.Where(x => x.SourceFile == sourceFile).OrderBy(x => x.Name, StringComparer.Ordinal))
        {
            WriteDocumentation(text, definition.Comment, 0);
            string abstractModifier = definition.IsAbstract && definition.Name != "PduStatus" ? "abstract " : string.Empty;
            string baseClause = definition.BaseName == "root" ? string.Empty : $" : {definition.BaseName}";
            text.AppendLine($"public {abstractModifier}partial class {definition.Name}{baseClause}");
            text.AppendLine("{");

            PduDefinition? pdu = schema.Pdus.FirstOrDefault(x => x.Name == definition.Name);
            if (pdu is not null)
            {
                text.AppendLine($"    /// <summary>Creates a DIS v7 {definition.Name} with its wire discriminator fields initialized.</summary>");
                text.AppendLine($"    public {definition.Name}() => Initialize({pdu.Type}, {Family(pdu.SourceFile)});");
                text.AppendLine();
            }

            foreach (FieldDefinition field in definition.Fields)
            {
                if (field.Kind is FieldKind.PaddingBoundary or FieldKind.StaticIvar)
                    continue;
                WriteDocumentation(text, field.Comment, 1);
                string propertyName = PropertyName(field.Name);
                if (definition.Name is "SignalPdu" or "IntercomSignalPdu" && propertyName == "Samples")
                    propertyName = "SampleCount";
                if (definition.Name == "EntityId" && propertyName == "EntityId")
                    propertyName = "EntityNumber";
                if (string.Equals(propertyName, definition.Name, StringComparison.Ordinal))
                    propertyName += "Value";
                string type = definition.Name is "SignalPdu" or "IntercomSignalPdu" && propertyName == "EncodingScheme"
                    ? "SignalEncodingScheme"
                    : TypeName(field);
                string initializer = Initializer(field);
                string access = field.IsHidden ? "internal" : "public";
                text.AppendLine($"    {access} {type} {propertyName} {{ get; set; }}{initializer}");
                text.AppendLine();
            }

            text.AppendLine("}");
            text.AppendLine();
        }

        return text.ToString().ReplaceLineEndings("\n");
    }

    private static string TypeName(FieldDefinition field) => field.Kind switch
    {
        FieldKind.Primitive => Primitive(field.TypeName),
        FieldKind.ClassReference => field.TypeName,
        FieldKind.Enumeration or FieldKind.BitField => field.TypeName,
        FieldKind.ObjectList => $"List<{field.TypeName}>",
        FieldKind.PrimitiveList => $"{Primitive(field.TypeName)}[]",
        _ => throw new InvalidOperationException($"Cannot emit model field kind {field.Kind}."),
    };

    private static string Initializer(FieldDefinition field) => field.Kind switch
    {
        FieldKind.ClassReference => $" = new {field.TypeName}();",
        FieldKind.ObjectList => " = [];",
        FieldKind.PrimitiveList => field.FixedLength is int length ? $" = new {Primitive(field.TypeName)}[{length}];" : " = [];",
        _ => string.Empty,
    };

    private static string Primitive(string type) => type.Trim() switch
    {
        "uint8" => "byte",
        "int8" => "sbyte",
        "uint16" => "ushort",
        "int16" => "short",
        "uint32" => "uint",
        "int32" => "int",
        "uint64" => "ulong",
        "int64" => "long",
        "float32" => "float",
        "float64" => "double",
        _ => throw new InvalidDataException($"Unsupported primitive '{type}'."),
    };

    private static string UnsignedBits(int? bits) => bits switch
    {
        <= 8 => "byte",
        <= 16 => "ushort",
        <= 32 => "uint",
        <= 64 => "ulong",
        _ => throw new InvalidDataException($"Unsupported enumeration width '{bits}'."),
    };

    private static string PropertyName(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new InvalidDataException("A field name cannot be empty.");
        string normalized = value.Replace("ID", "Id", StringComparison.Ordinal);
        return char.ToUpperInvariant(normalized[0]) + normalized[1..];
    }

    private static void WriteDocumentation(StringBuilder text, string? comment, int indent)
    {
        if (string.IsNullOrWhiteSpace(comment))
            return;
        string prefix = new(' ', indent * 4);
        text.AppendLine($"{prefix}/// <summary>");
        foreach (string line in comment.Replace("\r", string.Empty, StringComparison.Ordinal).Split('\n'))
            text.AppendLine($"{prefix}/// {EscapeXml(line.Trim())}");
        text.AppendLine($"{prefix}/// </summary>");
    }

    private static string EscapeXml(string value) => value
        .Replace("&", "&amp;", StringComparison.Ordinal)
        .Replace("<", "&lt;", StringComparison.Ordinal)
        .Replace(">", "&gt;", StringComparison.Ordinal);

    private static byte Family(string sourceFile) => sourceFile switch
    {
        "EntityInformationFamilyPdus.xml" => 1,
        "WarfareFamilyPdus.xml" => 2,
        "LogisticsFamilyPdus.xml" => 3,
        "RadioCommunicationsFamilyPdus.xml" => 4,
        "SimulationManagementFamilyPdus.xml" => 5,
        "DistributedEmissionsFamilyPdus.xml" => 6,
        "EntityManagementFamilyPdus.xml" => 7,
        "MinefieldFamilyPdus.xml" => 8,
        "SyntheticEnvironmentFamilyPdus.xml" => 9,
        "SimulationManagementWithReliabilityFamilyPdus.xml" => 10,
        "LiveEntityFamilyPdus.xml" => 11,
        "InformationOperationsFamilyPdus.xml" => 13,
        _ => throw new InvalidDataException($"No protocol-family mapping for '{sourceFile}'."),
    };
}

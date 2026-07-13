using System.Globalization;
using System.Text;

namespace OpenDisNet.Generator;

internal static class EnumerationWriter
{
    public static string Create(DisSchema schema)
    {
        var text = new StringBuilder();
        text.AppendLine("// Derived from SISO-REF-010-2025 v36. Reprinted with permission from SISO Inc.");
        text.AppendLine("namespace OpenDisNet.Enumerations;");
        text.AppendLine();
        foreach (SisoTypeDefinition definition in schema.SisoTypes.OrderBy(x => x.Name, StringComparer.Ordinal))
        {
            if (PublicNames.IsProtocolHeaderType(definition.Uid)) continue;
            if (definition.Kind == "sisoenum") WriteEnum(text, definition);
            else WriteBitField(text, definition);
        }
        return text.ToString().ReplaceLineEndings("\n");
    }

    private static void WriteEnum(StringBuilder text, SisoTypeDefinition definition)
    {
        text.AppendLine($"/// <summary>SISO-REF-010 v36 enumeration UID {definition.Uid}.</summary>");
        text.AppendLine($"public enum {PublicNames.SisoType(definition.Name, definition.Uid)} : {Underlying(definition.Bits)}");
        text.AppendLine("{");
        foreach (SisoMemberDefinition member in definition.Members)
        {
            WriteMemberDocumentation(text, member, 1);
            if (member.Deprecated) text.AppendLine("    [Obsolete(\"Deprecated by SISO-REF-010.\")]");
            text.AppendLine($"    {member.Name} = {Literal(member.Value!.Value, definition.Bits)},");
        }
        text.AppendLine("}");
        text.AppendLine();
    }

    private static void WriteBitField(StringBuilder text, SisoTypeDefinition definition)
    {
        string type = Underlying(definition.Bits);
        text.AppendLine($"/// <summary>SISO-REF-010 v36 bitfield UID {definition.Uid}. Unknown and reserved bits are preserved in <see cref=\"Value\"/>.</summary>");
        string name = PublicNames.SisoType(definition.Name, definition.Uid);
        text.AppendLine($"public readonly partial record struct {name}({type} Value)");
        text.AppendLine("{");
        text.AppendLine($"    public static {name} None => new(0);");
        text.AppendLine();
        foreach (SisoMemberDefinition member in definition.Members)
        {
            int length = member.Length ?? 1;
            int position = member.BitPosition!.Value;
            ulong valueMask = length == 64 ? ulong.MaxValue : (1UL << length) - 1;
            ulong shiftedMask = valueMask << position;
            WriteMemberDocumentation(text, member, 1);
            if (length == 1)
            {
                text.AppendLine($"    public bool {member.Name} => (Value & {Literal(shiftedMask, definition.Bits)}) != 0;");
                text.AppendLine($"    public {name} With{member.Name}(bool value) => new(({type})(value ? Value | {Literal(shiftedMask, definition.Bits)} : Value & ~{Literal(shiftedMask, definition.Bits)}));");
            }
            else
            {
                text.AppendLine($"    public {type} {member.Name} => ({type})((Value >> {position}) & {Literal(valueMask, definition.Bits)});");
                text.AppendLine($"    public {name} With{member.Name}({type} value)");
                text.AppendLine("    {");
                text.AppendLine($"        if (value > {Literal(valueMask, definition.Bits)}) throw new ArgumentOutOfRangeException(nameof(value));");
                text.AppendLine($"        return new(({type})((Value & ~{Literal(shiftedMask, definition.Bits)}) | (({type})(value << {position}) & {Literal(shiftedMask, definition.Bits)})));");
                text.AppendLine("    }");
            }
            text.AppendLine();
        }
        text.AppendLine($"    public static implicit operator {name}({type} value) => new(value);");
        text.AppendLine($"    public static implicit operator {type}({name} value) => value.Value;");
        text.AppendLine($"    public override string ToString() => $\"0x{{Value:X{definition.Bits / 4}}}\";");
        text.AppendLine("}");
        text.AppendLine();
    }

    private static void WriteMemberDocumentation(StringBuilder text, SisoMemberDefinition member, int indent)
    {
        if (string.IsNullOrWhiteSpace(member.Description)) return;
        string prefix = new(' ', indent * 4);
        text.AppendLine($"{prefix}/// <summary>{EscapeXml(member.Description)}</summary>");
    }

    private static string Underlying(int bits) => bits switch
    {
        <= 8 => "byte",
        <= 16 => "ushort",
        <= 32 => "uint",
        <= 64 => "ulong",
        _ => throw new InvalidDataException($"Unsupported SISO width {bits} bits."),
    };

    private static string Literal(ulong value, int bits) => bits switch
    {
        <= 8 => value.ToString(CultureInfo.InvariantCulture),
        <= 16 => value.ToString(CultureInfo.InvariantCulture),
        <= 32 => value.ToString(CultureInfo.InvariantCulture) + "u",
        <= 64 => value.ToString(CultureInfo.InvariantCulture) + "ul",
        _ => throw new InvalidDataException(),
    };

    private static string EscapeXml(string value) => value
        .Replace("&", "&amp;", StringComparison.Ordinal)
        .Replace("<", "&lt;", StringComparison.Ordinal)
        .Replace(">", "&gt;", StringComparison.Ordinal);
}

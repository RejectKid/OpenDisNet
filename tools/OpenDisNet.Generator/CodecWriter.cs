using System.Text;

namespace OpenDisNet.Generator;

internal static class CodecWriter
{
    public static string Create(DisSchema schema)
    {
        var text = new StringBuilder();
        var classes = schema.Classes.ToDictionary(x => x.Name, StringComparer.Ordinal);

        text.AppendLine("// DIS v7 binary codec. Every standardized PDU dispatch route is listed below.");
        text.AppendLine("using OpenDisNet.Binary;");
        text.AppendLine("using OpenDisNet.Protocol;");
        text.AppendLine();
        text.AppendLine("namespace OpenDisNet.Pdus;");
        text.AppendLine();
        text.AppendLine("internal static partial class PduCodec");
        text.AppendLine("{");
        WritePublicApi(text, schema, classes);

        foreach (ClassDefinition definition in schema.Classes.OrderBy(x => x.Name, StringComparer.Ordinal))
        {
            WriteRecordMethods(text, definition, IsPdu(definition, classes));
        }

        text.AppendLine("}");
        return text.ToString().ReplaceLineEndings("\n");
    }

    private static void WritePublicApi(StringBuilder text, DisSchema schema, IReadOnlyDictionary<string, ClassDefinition> classes)
    {
        text.AppendLine("    public static Pdu Read(DisHeader header, ReadOnlySpan<byte> body)");
        text.AppendLine("    {");
        text.AppendLine("        Pdu value = PduFactory.Create(header.PduType, header.ExerciseId);");
        text.AppendLine("        ApplyHeader(value, header);");
        text.AppendLine("        var reader = new DisBinaryReader(body, DisHeader.Size);");
        text.AppendLine("        switch ((byte)header.PduType)");
        text.AppendLine("        {");
        foreach (PduDefinition pdu in schema.Pdus)
        {
            text.AppendLine($"            case {pdu.Type}:");
            foreach (ClassDefinition part in Linearized(pdu.Name, classes).Where(x => x.Name is not "Pdu" and not "PduBase"))
                text.AppendLine($"                Read{part.Name}Fields(ref reader, ({pdu.Name})value);");
            text.AppendLine("                break;");
        }
        text.AppendLine("        }");
        text.AppendLine("        if (reader.Remaining != 0)");
        text.AppendLine("            throw new FormatException($\"{reader.Remaining} unread bytes remain after decoding {header.PduType}.\");");
        text.AppendLine("        return value;");
        text.AppendLine("    }");
        text.AppendLine();

        text.AppendLine("    public static int GetEncodedLength(Pdu value)");
        text.AppendLine("    {");
        text.AppendLine("        ArgumentNullException.ThrowIfNull(value);");
        text.AppendLine("        Prepare(value);");
        text.AppendLine("        int offset = DisHeader.Size;");
        text.AppendLine("        MeasureBody(value, ref offset);");
        text.AppendLine("        return offset;");
        text.AppendLine("    }");
        text.AppendLine();

        text.AppendLine("    public static byte[] Write(Pdu value)");
        text.AppendLine("    {");
        text.AppendLine("        int length = GetEncodedLength(value);");
        text.AppendLine("        byte[] bytes = new byte[length];");
        text.AppendLine("        Write(value, bytes);");
        text.AppendLine("        return bytes;");
        text.AppendLine("    }");
        text.AppendLine();

        text.AppendLine("    public static int Write(Pdu value, Span<byte> destination)");
        text.AppendLine("    {");
        text.AppendLine("        int length = GetEncodedLength(value);");
        text.AppendLine("        if (length > ushort.MaxValue) throw new ArgumentOutOfRangeException(nameof(value), \"A DIS PDU cannot exceed 65,535 bytes.\");");
        text.AppendLine("        if (destination.Length < length) throw new ArgumentException($\"Destination requires {length} bytes.\", nameof(destination));");
        text.AppendLine("        value.Length = (ushort)length;");
        text.AppendLine("        var writer = new DisBinaryWriter(destination[..length]);");
        text.AppendLine("        DisHeaderCodec.Write(ref writer, value.Header);");
        text.AppendLine("        WriteBody(value, ref writer);");
        text.AppendLine("        return writer.Offset;");
        text.AppendLine("    }");
        text.AppendLine();

        WritePduSwitchMethod(text, schema, classes, "Prepare", (part, pdu) => $"Prepare{part.Name}Fields(({pdu.Name})value);");
        WritePduSwitchMethod(text, schema, classes, "WriteBody", (part, pdu) => $"Write{part.Name}Fields(ref writer, ({pdu.Name})value);", "ref DisBinaryWriter writer");
        WritePduSwitchMethod(text, schema, classes, "MeasureBody", (part, pdu) => $"Measure{part.Name}Fields(({pdu.Name})value, ref offset);", "ref int offset");

        text.AppendLine("    private static void ApplyHeader(Pdu value, DisHeader header)");
        text.AppendLine("    {");
        text.AppendLine("        value.ProtocolVersion = (byte)header.ProtocolVersion;");
        text.AppendLine("        value.ExerciseId = header.ExerciseId;");
        text.AppendLine("        value.PduType = (byte)header.PduType;");
        text.AppendLine("        value.ProtocolFamily = (byte)header.ProtocolFamily;");
        text.AppendLine("        value.Timestamp = header.Timestamp;");
        text.AppendLine("        value.Length = header.Length;");
        text.AppendLine("        if (value is PduBase body)");
        text.AppendLine("        {");
        text.AppendLine("            body.PduStatus = new PduStatus { Value = header.PduStatus };");
        text.AppendLine("            body.Padding = header.Padding;");
        text.AppendLine("        }");
        text.AppendLine("    }");
        text.AppendLine();
    }

    private static void WritePduSwitchMethod(
        StringBuilder text,
        DisSchema schema,
        IReadOnlyDictionary<string, ClassDefinition> classes,
        string name,
        Func<ClassDefinition, PduDefinition, string> statement,
        string? extraParameter = null)
    {
        string parameters = extraParameter is null ? "Pdu value" : $"Pdu value, {extraParameter}";
        text.AppendLine($"    private static void {name}({parameters})");
        text.AppendLine("    {");
        text.AppendLine("        switch ((byte)value.PduType)");
        text.AppendLine("        {");
        foreach (PduDefinition pdu in schema.Pdus)
        {
            text.AppendLine($"            case {pdu.Type}:");
            foreach (ClassDefinition part in Linearized(pdu.Name, classes).Where(x => x.Name is not "Pdu" and not "PduBase"))
                text.AppendLine($"                {statement(part, pdu)}");
            text.AppendLine("                break;");
        }
        text.AppendLine("            default: throw new ArgumentOutOfRangeException(nameof(value), value.PduType, \"DIS v7 defines PDU types 1 through 72.\");");
        text.AppendLine("        }");
        text.AppendLine("    }");
        text.AppendLine();
    }

    private static void WriteRecordMethods(StringBuilder text, ClassDefinition definition, bool isPdu)
    {
        if (!isPdu)
        {
            text.AppendLine($"    private static {definition.Name} Read{definition.Name}(ref DisBinaryReader reader)");
            text.AppendLine("    {");
            text.AppendLine($"        var value = new {definition.Name}();");
            if (definition.BaseName != "root")
                text.AppendLine($"        Read{definition.BaseName}Fields(ref reader, value);");
            text.AppendLine($"        Read{definition.Name}Fields(ref reader, value);");
            text.AppendLine("        return value;");
            text.AppendLine("    }");
            text.AppendLine();
        }

        text.AppendLine($"    private static void Read{definition.Name}Fields(ref DisBinaryReader reader, {definition.Name} value)");
        text.AppendLine("    {");
        foreach (FieldDefinition field in definition.Fields)
            WriteReadField(text, field, definition.Name);
        text.AppendLine("    }");
        text.AppendLine();

        if (!isPdu)
        {
            text.AppendLine($"    private static void Prepare{definition.Name}({definition.Name} value)");
            text.AppendLine("    {");
            if (definition.BaseName != "root")
                text.AppendLine($"        Prepare{definition.BaseName}Fields(value);");
            text.AppendLine($"        Prepare{definition.Name}Fields(value);");
            text.AppendLine("    }");
            text.AppendLine();
        }

        text.AppendLine($"    private static void Prepare{definition.Name}Fields({definition.Name} value)");
        text.AppendLine("    {");
        if (definition.Name is "SignalPdu" or "IntercomSignalPdu")
        {
            text.AppendLine("        if (value.DataBitLength == 0 && value.Data.Length != 0)");
            text.AppendLine("            value.DataBitLength = checked((ushort)(value.Data.Length * 8));");
            text.AppendLine("        if ((value.DataBitLength + 7) / 8 != value.Data.Length)");
            text.AppendLine("            throw new ArgumentException(\"DataBitLength must match Data, allowing only unused bits in the final octet.\", nameof(value));");
        }
        var countOwners = new HashSet<string>(StringComparer.Ordinal);
        foreach (FieldDefinition field in definition.Fields)
            WritePrepareField(text, field, definition, countOwners);
        text.AppendLine("    }");
        text.AppendLine();

        if (!isPdu)
        {
            text.AppendLine($"    private static void Write{definition.Name}(ref DisBinaryWriter writer, {definition.Name} value)");
            text.AppendLine("    {");
            if (definition.BaseName != "root")
                text.AppendLine($"        Write{definition.BaseName}Fields(ref writer, value);");
            text.AppendLine($"        Write{definition.Name}Fields(ref writer, value);");
            text.AppendLine("    }");
            text.AppendLine();
        }

        text.AppendLine($"    private static void Write{definition.Name}Fields(ref DisBinaryWriter writer, {definition.Name} value)");
        text.AppendLine("    {");
        foreach (FieldDefinition field in definition.Fields)
            WriteWriteField(text, field, definition.Name);
        text.AppendLine("    }");
        text.AppendLine();

        if (!isPdu)
        {
            text.AppendLine($"    private static void Measure{definition.Name}(in {definition.Name} value, ref int offset)");
            text.AppendLine("    {");
            if (definition.BaseName != "root")
                text.AppendLine($"        Measure{definition.BaseName}Fields(value, ref offset);");
            text.AppendLine($"        Measure{definition.Name}Fields(value, ref offset);");
            text.AppendLine("    }");
            text.AppendLine();
        }

        text.AppendLine($"    private static void Measure{definition.Name}Fields(in {definition.Name} value, ref int offset)");
        text.AppendLine("    {");
        foreach (FieldDefinition field in definition.Fields)
            WriteMeasureField(text, field, definition.Name);
        text.AppendLine("    }");
        text.AppendLine();
    }

    private static void WriteReadField(StringBuilder text, FieldDefinition field, string owner)
    {
        string property = PropertyName(field, owner);
        string? condition = ConditionalFieldExpression(owner, field.Name);
        if (condition is not null)
        {
            text.AppendLine($"        if ({condition})");
            text.AppendLine("        {");
        }
        switch (field.Kind)
        {
            case FieldKind.Primitive:
                text.AppendLine($"        value.{property} = reader.{ReadMethod(field.TypeName)}(\"{field.Name}\");");
                break;
            case FieldKind.ClassReference:
                text.AppendLine($"        value.{property} = Read{field.TypeName}(ref reader);");
                break;
            case FieldKind.Enumeration:
            case FieldKind.BitField:
                text.AppendLine($"        value.{property} = reader.{ReadBits(field.BitSize)}(\"{field.Name}\");");
                break;
            case FieldKind.ObjectList:
                WriteReadList(text, field, property, owner);
                break;
            case FieldKind.PrimitiveList:
                WriteReadPrimitiveList(text, field, property, owner);
                break;
            case FieldKind.PaddingBoundary:
                text.AppendLine($"        reader.Skip(Padding(reader.Offset, {BoundaryBytes(field)}), \"{field.Name}\");");
                break;
            case FieldKind.StaticIvar:
                break;
        }
        if (condition is not null)
            text.AppendLine("        }");
    }

    private static void WriteReadList(StringBuilder text, FieldDefinition field, string property, string owner)
    {
        string count = CountExpression(field, "value");
        string itemType = field.BitSize is null ? field.TypeName : UnsignedBits(field.BitSize);
        text.AppendLine($"        int {property}Count = CheckedCount({count}, reader.Remaining, \"{field.Name}\");");

        if (IsByteLengthObjectList(owner, field.Name))
        {
            text.AppendLine($"        int {property}End = checked(reader.Offset + {property}Count);");
            text.AppendLine($"        value.{property} = [];");
            text.AppendLine($"        while (reader.Offset < {property}End)");
            text.AppendLine("        {");
            text.AppendLine($"            value.{property}.Add(Read{itemType}(ref reader));");
            text.AppendLine($"            if (reader.Offset > {property}End) throw new FormatException(\"A {field.Name} record exceeds its declared byte length.\");");
            text.AppendLine("        }");
            return;
        }

        text.AppendLine($"        value.{property} = new List<{itemType}>({property}Count);");
        text.AppendLine($"        for (int index = 0; index < {property}Count; index++)");
        string read = field.BitSize is null ? $"Read{field.TypeName}(ref reader)" : $"reader.{ReadBits(field.BitSize)}(\"{field.Name}\")";
        text.AppendLine($"            value.{property}.Add({read});");
    }

    private static void WriteReadPrimitiveList(StringBuilder text, FieldDefinition field, string property, string owner)
    {
        string count = field.IsDynamicLength
            ? "Math.Max(0, checked((int)value.RecordLength) - 4)"
            : owner == "Environment" && field.Name == "geometry"
                ? "Math.Max(0, ((checked((int)value.Length) + 7) / 8) - 6)"
                : field.FixedLength == 0 && field.CountFieldName is null
                    ? VariableCountExpression(owner, field.Name)
                    : CountExpression(field, "value");
        string type = Primitive(field.TypeName);
        text.AppendLine($"        int {property}Count = CheckedCount({count}, reader.Remaining, \"{field.Name}\");");
        text.AppendLine($"        value.{property} = new {type}[{property}Count];");
        text.AppendLine($"        for (int index = 0; index < {property}Count; index++)");
        text.AppendLine($"            value.{property}[index] = reader.{ReadMethod(field.TypeName)}(\"{field.Name}\");");
    }

    private static void WritePrepareField(StringBuilder text, FieldDefinition field, ClassDefinition definition, HashSet<string> countOwners)
    {
        string owner = definition.Name;
        string property = PropertyName(field, owner);
        string? condition = ConditionalFieldExpression(owner, field.Name);
        if (condition is not null)
        {
            string collectionCount = field.Kind == FieldKind.PrimitiveList ? $"value.{property}.Length" : $"value.{property}.Count";
            text.AppendLine($"        if ({collectionCount} != 0) value.DataFilter.BitFlags |= 1u << {MinefieldDataBit(field.Name)};");
            text.AppendLine($"        if ({condition})");
            text.AppendLine("        {");
        }
        if (field.Kind == FieldKind.ClassReference)
        {
            text.AppendLine($"        ArgumentNullException.ThrowIfNull(value.{property});");
            text.AppendLine($"        Prepare{field.TypeName}(value.{property});");
        }
        else if (field.Kind is FieldKind.ObjectList or FieldKind.PrimitiveList)
        {
            text.AppendLine($"        ArgumentNullException.ThrowIfNull(value.{property});");
            if (field.Kind == FieldKind.ObjectList && field.BitSize is null)
                text.AppendLine($"        foreach ({field.TypeName} item in value.{property}) Prepare{field.TypeName}(item);");
            if (field.CountFieldName is not null)
            {
                string countProperty = PropertyName(field.CountFieldName, owner);
                if (IsByteLengthObjectList(owner, field.Name))
                {
                    text.AppendLine($"        int {property}ByteLength = 0;");
                    text.AppendLine($"        foreach ({field.TypeName} item in value.{property}) Measure{field.TypeName}(item, ref {property}ByteLength);");
                    text.AppendLine($"        value.{countProperty} = checked((uint){property}ByteLength);");
                    countOwners.Add(field.CountFieldName);
                    return;
                }
                string countValue = IsBitCount(field) ? $"checked(value.{property}.Length * 8)" : $"value.{property}.Count";
                if (field.Kind == FieldKind.PrimitiveList)
                    countValue = IsBitCount(field) ? $"checked(value.{property}.Length * 8)" : $"value.{property}.Length";
                FieldDefinition countField = definition.Fields.Single(x => x.Name == field.CountFieldName);
                string countType = Primitive(countField.TypeName);
                if (countOwners.Add(field.CountFieldName))
                    text.AppendLine($"        value.{countProperty} = checked(({countType}){countValue});");
                else
                    text.AppendLine($"        if (Convert.ToInt64(value.{countProperty}) != {countValue}) throw new InvalidOperationException(\"Field '{field.CountFieldName}' must match the encoded length of '{field.Name}'.\");");
            }
        }
        if (condition is not null)
            text.AppendLine("        }");
    }

    private static void WriteWriteField(StringBuilder text, FieldDefinition field, string owner)
    {
        string property = PropertyName(field, owner);
        string? condition = ConditionalFieldExpression(owner, field.Name);
        if (condition is not null)
        {
            text.AppendLine($"        if ({condition})");
            text.AppendLine("        {");
        }
        switch (field.Kind)
        {
            case FieldKind.Primitive:
                text.AppendLine($"        writer.{WriteMethod(field.TypeName)}(value.{property}, \"{field.Name}\");");
                break;
            case FieldKind.ClassReference:
                text.AppendLine($"        Write{field.TypeName}(ref writer, value.{property});");
                break;
            case FieldKind.Enumeration:
            case FieldKind.BitField:
                text.AppendLine($"        writer.{WriteBits(field.BitSize)}(value.{property}, \"{field.Name}\");");
                break;
            case FieldKind.ObjectList:
                if (field.BitSize is null)
                    text.AppendLine($"        foreach ({field.TypeName} item in value.{property}) Write{field.TypeName}(ref writer, item);");
                else
                    text.AppendLine($"        foreach ({UnsignedBits(field.BitSize)} item in value.{property}) writer.{WriteBits(field.BitSize)}(item, \"{field.Name}\");");
                break;
            case FieldKind.PrimitiveList:
                text.AppendLine($"        foreach ({Primitive(field.TypeName)} item in value.{property}) writer.{WriteMethod(field.TypeName)}(item, \"{field.Name}\");");
                break;
            case FieldKind.PaddingBoundary:
                text.AppendLine($"        writer.WriteZeros(Padding(writer.Offset, {BoundaryBytes(field)}), \"{field.Name}\");");
                break;
            case FieldKind.StaticIvar:
                break;
        }
        if (condition is not null)
            text.AppendLine("        }");
    }

    private static void WriteMeasureField(StringBuilder text, FieldDefinition field, string owner)
    {
        string property = PropertyName(field, owner);
        string? condition = ConditionalFieldExpression(owner, field.Name);
        if (condition is not null)
        {
            text.AppendLine($"        if ({condition})");
            text.AppendLine("        {");
        }
        switch (field.Kind)
        {
            case FieldKind.Primitive:
                text.AppendLine($"        offset += {PrimitiveSize(field.TypeName)};");
                break;
            case FieldKind.ClassReference:
                text.AppendLine($"        Measure{field.TypeName}(value.{property}, ref offset);");
                break;
            case FieldKind.Enumeration:
            case FieldKind.BitField:
                text.AppendLine($"        offset += {BitsBytes(field.BitSize)};");
                break;
            case FieldKind.ObjectList:
                if (field.BitSize is null)
                    text.AppendLine($"        foreach ({field.TypeName} item in value.{property}) Measure{field.TypeName}(item, ref offset);");
                else
                    text.AppendLine($"        offset += checked(value.{property}.Count * {BitsBytes(field.BitSize)});");
                break;
            case FieldKind.PrimitiveList:
                text.AppendLine($"        offset += checked(value.{property}.Length * {PrimitiveSize(field.TypeName)});");
                break;
            case FieldKind.PaddingBoundary:
                text.AppendLine($"        offset += Padding(offset, {BoundaryBytes(field)});");
                break;
            case FieldKind.StaticIvar:
                break;
        }
        if (condition is not null)
            text.AppendLine("        }");
    }

    private static IReadOnlyList<ClassDefinition> Linearized(string name, IReadOnlyDictionary<string, ClassDefinition> classes)
    {
        var result = new List<ClassDefinition>();
        ClassDefinition current = classes[name];
        while (true)
        {
            result.Add(current);
            if (current.BaseName == "root")
                break;
            current = classes[current.BaseName];
        }
        result.Reverse();
        return result;
    }

    private static bool IsPdu(ClassDefinition definition, IReadOnlyDictionary<string, ClassDefinition> classes)
    {
        ClassDefinition current = definition;
        while (current.BaseName != "root")
        {
            if (current.Name == "Pdu")
                return true;
            current = classes[current.BaseName];
        }
        return current.Name == "Pdu";
    }

    private static string CountExpression(FieldDefinition field, string value) =>
        field.FixedLength is int fixedLength && fixedLength > 0
            ? fixedLength.ToString(System.Globalization.CultureInfo.InvariantCulture)
            : field.CountFieldName is not null
                ? IsBitCount(field)
                    ? $"(checked((int){value}.{PropertyName(field.CountFieldName, string.Empty)}) + 7) / 8"
                    : $"checked((int){value}.{PropertyName(field.CountFieldName, string.Empty)})"
                : throw new InvalidDataException($"List '{field.Name}' has no length source.");

    private static bool IsBitCount(FieldDefinition field) =>
        field.Kind == FieldKind.PrimitiveList &&
        string.Equals(field.Name, "variableDatumValue", StringComparison.Ordinal);

    private static bool IsByteLengthObjectList(string owner, string field) =>
        (owner, field) is ("IntercomControlPdu", "intercomParameters");

    private static string? ConditionalFieldExpression(string owner, string field) =>
        owner == "MinefieldDataPdu" && MinefieldDataBit(field) >= 0
            ? $"(value.DataFilter.BitFlags & (1u << {MinefieldDataBit(field)})) != 0"
            : null;

    private static int MinefieldDataBit(string field) => field switch
    {
        "groundBurialDepthOffset" => 0,
        "waterBurialDepthOffset" => 1,
        "snowBurialDepthOffset" => 2,
        "mineOrientation" => 3,
        "thermalContrast" => 4,
        "reflectance" => 5,
        "mineEmplacementTime" => 6,
        "numberOfTripDetonationWires" or "numberOfVertices" => 7,
        "fusing" => 8,
        "scalarDetectionCoefficient" => 9,
        "paintScheme" => 10,
        _ => -1,
    };

    private static string VariableCountExpression(string owner, string field) => (owner, field) switch
    {
        ("GridAxisDescriptorVariable", "xiValues") => "checked((int)value.NumberOfPointsOnXiAxis)",
        ("IntercomCommunicationsParameters", "recordSpecificField") => "Math.Max(0, checked((int)value.RecordLength) - 4)",
        ("VariableTransmitterParameters", "recordSpecificFields") => "Math.Max(0, checked((int)value.RecordLength) - 4)",
        ("RecordSpecificationElement", "recordValues") => "(checked((int)value.RecordLength) * checked((int)value.RecordCount) + 7) / 8",
        ("RecordSpecificationElement", "padTo64") => "Padding(reader.Offset, 8)",
        ("SignalPdu", "data") => "(checked((int)value.DataBitLength) + 7) / 8",
        ("IntercomSignalPdu", "data") => "(checked((int)value.DataBitLength) + 7) / 8",
        ("ModulationParameters", "recordSpecificFields") => "0",
        _ => throw new InvalidDataException($"Variable primitive list '{owner}.{field}' needs an explicit length rule."),
    };

    private static string PropertyName(FieldDefinition field, string owner)
    {
        string property = PropertyName(field.Name, owner);
        return property;
    }

    private static string PropertyName(string value, string owner)
    {
        string normalized = value.Replace("ID", "Id", StringComparison.Ordinal);
        string property = char.ToUpperInvariant(normalized[0]) + normalized[1..];
        if (owner == "EntityId" && property == "EntityId")
            return "EntityNumber";
        return string.Equals(property, owner, StringComparison.Ordinal) ? property + "Value" : property;
    }

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

    private static int PrimitiveSize(string type) => type.Trim() switch
    {
        "uint8" or "int8" => 1,
        "uint16" or "int16" => 2,
        "uint32" or "int32" or "float32" => 4,
        "uint64" or "int64" or "float64" => 8,
        _ => throw new InvalidDataException($"Unsupported primitive '{type}'."),
    };

    private static string ReadMethod(string type) => type.Trim() switch
    {
        "uint8" => "ReadByte",
        "int8" => "ReadSByte",
        "uint16" => "ReadUInt16",
        "int16" => "ReadInt16",
        "uint32" => "ReadUInt32",
        "int32" => "ReadInt32",
        "uint64" => "ReadUInt64",
        "int64" => "ReadInt64",
        "float32" => "ReadSingle",
        "float64" => "ReadDouble",
        _ => throw new InvalidDataException($"Unsupported primitive '{type}'."),
    };

    private static string WriteMethod(string type) => type.Trim() switch
    {
        "uint8" => "WriteByte",
        "int8" => "WriteSByte",
        "uint16" => "WriteUInt16",
        "int16" => "WriteInt16",
        "uint32" => "WriteUInt32",
        "int32" => "WriteInt32",
        "uint64" => "WriteUInt64",
        "int64" => "WriteInt64",
        "float32" => "WriteSingle",
        "float64" => "WriteDouble",
        _ => throw new InvalidDataException($"Unsupported primitive '{type}'."),
    };

    private static string UnsignedBits(int? bits) => bits switch { <= 8 => "byte", <= 16 => "ushort", <= 32 => "uint", <= 64 => "ulong", _ => throw new InvalidDataException() };
    private static int BitsBytes(int? bits) => bits switch { <= 8 => 1, <= 16 => 2, <= 32 => 4, <= 64 => 8, _ => throw new InvalidDataException() };
    private static string ReadBits(int? bits) => bits switch { <= 8 => "ReadByte", <= 16 => "ReadUInt16", <= 32 => "ReadUInt32", <= 64 => "ReadUInt64", _ => throw new InvalidDataException() };
    private static string WriteBits(int? bits) => bits switch { <= 8 => "WriteByte", <= 16 => "WriteUInt16", <= 32 => "WriteUInt32", <= 64 => "WriteUInt64", _ => throw new InvalidDataException() };
    private static int BoundaryBytes(FieldDefinition field) => int.Parse(field.TypeName, System.Globalization.CultureInfo.InvariantCulture) / 8;
}

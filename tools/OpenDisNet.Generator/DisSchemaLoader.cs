using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using System.Xml.Linq;

namespace OpenDisNet.Generator;

internal static class DisSchemaLoader
{
    private static readonly string[] FamilyFiles =
    [
        "EntityInformationFamilyPdus.xml",
        "WarfareFamilyPdus.xml",
        "LogisticsFamilyPdus.xml",
        "SimulationManagementFamilyPdus.xml",
        "DistributedEmissionsFamilyPdus.xml",
        "RadioCommunicationsFamilyPdus.xml",
        "EntityManagementFamilyPdus.xml",
        "MinefieldFamilyPdus.xml",
        "SyntheticEnvironmentFamilyPdus.xml",
        "SimulationManagementWithReliabilityFamilyPdus.xml",
        "InformationOperationsFamilyPdus.xml",
        "LiveEntityFamilyPdus.xml",
    ];

    public static DisSchema Load()
    {
        IReadOnlyDictionary<string, SisoWireType> sisoTypes = LoadSisoWireTypes();
        string[] files = ["DIS_7_2012.xml", .. FamilyFiles];
        var classes = ImmutableArray.CreateBuilder<ClassDefinition>();
        var pdus = ImmutableArray.CreateBuilder<PduDefinition>();

        foreach (string file in files)
        {
            string resourceName = $"{typeof(DisSchemaLoader).Namespace}.Schemas.DIS7.{file}";
            using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
                ?? throw new InvalidDataException($"Missing embedded schema resource '{resourceName}'.");
            XDocument document = XDocument.Load(stream, LoadOptions.SetLineInfo);
            foreach (XElement element in document.Root?.Elements("class") ?? [])
            {
                ClassDefinition definition = ParseClass(element, file, sisoTypes);
                classes.Add(definition);

                XElement? pduType = element.Elements("initialValue")
                    .SingleOrDefault(x => (string?)x.Attribute("name") == "pduType");
                XAttribute? id = element.Attribute("id");
                if (pduType is not null && id is not null && !definition.IsAbstract)
                {
                    XElement? family = element.Elements("initialValue")
                        .SingleOrDefault(x => (string?)x.Attribute("name") == "protocolFamily");
                    pdus.Add(new(
                        byte.Parse(id.Value, CultureInfo.InvariantCulture),
                        definition.Name,
                        (string?)family?.Attribute("value") ?? string.Empty,
                        file));
                }
            }
        }

        Validate(classes, pdus);
        return new(classes.ToImmutable(), pdus.OrderBy(x => x.Type).ToImmutableArray(), files.ToImmutableArray());
    }

    private static ClassDefinition ParseClass(XElement element, string sourceFile, IReadOnlyDictionary<string, SisoWireType> sisoTypes)
    {
        string name = PublicTypeName(Required(element, "name"));
        var fields = element.Elements("attribute").Select(x => ParseField(x, sisoTypes)).ToImmutableArray();
        return new(
            name,
            PublicTypeName((string?)element.Attribute("inheritsFrom") ?? "root"),
            string.Equals((string?)element.Attribute("abstract"), "true", StringComparison.OrdinalIgnoreCase),
            (string?)element.Attribute("comment"),
            fields,
            sourceFile);
    }

    private static FieldDefinition ParseField(XElement attribute, IReadOnlyDictionary<string, SisoWireType> sisoTypes)
    {
        string name = Required(attribute, "name");
        XElement shape = attribute.Elements().SingleOrDefault()
            ?? throw new InvalidDataException($"Attribute '{name}' has no wire shape.");

        return shape.Name.LocalName switch
        {
            "primitive" => Field(name, FieldKind.Primitive, Required(shape, "type")),
            "classRef" => Field(name, FieldKind.ClassReference, PublicTypeName(Required(shape, "name"))),
            "sisoenum" => SisoField(FieldKind.Enumeration),
            "sisobitfield" => SisoField(FieldKind.BitField),
            "objectlist" => ParseObjectList(name, shape, sisoTypes),
            "primitivelist" => new(
                name,
                FieldKind.PrimitiveList,
                Required(shape.Elements().Single(), "type"),
                (string?)shape.Attribute("countFieldName") ?? (string?)shape.Attribute("bitCountFieldName"),
                OptionalInt(shape, "length"),
                null,
                string.Equals((string?)shape.Attribute("isDynamicListLengthField"), "true", StringComparison.OrdinalIgnoreCase),
                Hidden(attribute),
                Comment(attribute)),
            "padtoboundary" => Field(name, FieldKind.PaddingBoundary, Required(shape, "length")),
            "staticivar" => Field(name, FieldKind.StaticIvar, (string?)shape.Attribute("type") ?? string.Empty),
            _ => throw new InvalidDataException($"Attribute '{name}' uses unsupported wire shape '{shape.Name.LocalName}'."),
        };

        FieldDefinition Field(string fieldName, FieldKind kind, string typeName) =>
            new(fieldName, kind, typeName, null, null, null, false, Hidden(attribute), Comment(attribute));

        FieldDefinition SisoField(FieldKind kind)
        {
            string typeName = Required(shape, "type");
            if (!sisoTypes.TryGetValue(typeName, out SisoWireType? wireType))
                throw new InvalidDataException($"Missing SISO wire metadata for '{typeName}'.");
            return new(name, kind, typeName, null, null, wireType.Bits, false, Hidden(attribute), Comment(attribute));
        }
    }

    private static string PublicTypeName(string name) =>
        string.Equals(name, "EntityID", StringComparison.Ordinal) ? "EntityId" : name;

    private static FieldDefinition ParseObjectList(string name, XElement shape, IReadOnlyDictionary<string, SisoWireType> sisoTypes)
    {
        XElement item = shape.Elements().Single();
        string type = item.Name.LocalName == "classRef" ? PublicTypeName(Required(item, "name")) : Required(item, "type");
        int? bitSize = null;
        if (item.Name.LocalName is "sisoenum" or "sisobitfield")
        {
            if (!sisoTypes.TryGetValue(type, out SisoWireType? wireType))
                throw new InvalidDataException($"Missing SISO wire metadata for list item '{type}'.");
            bitSize = wireType.Bits;
        }
        return new(name, FieldKind.ObjectList, type, (string?)shape.Attribute("countFieldName"), OptionalInt(shape, "length"), bitSize, false, Hidden(shape.Parent!), Comment(shape.Parent!));
    }

    private static void Validate(ImmutableArray<ClassDefinition>.Builder classes, ImmutableArray<PduDefinition>.Builder pdus)
    {
        string[] duplicateClasses = classes.GroupBy(x => x.Name).Where(x => x.Count() > 1).Select(x => x.Key).ToArray();
        if (duplicateClasses.Length != 0)
            throw new InvalidDataException($"Duplicate class definitions: {string.Join(", ", duplicateClasses)}");

        if (pdus.Count != 72)
            throw new InvalidDataException($"Expected 72 concrete DIS v7 PDUs; found {pdus.Count}.");

        byte[] expected = Enumerable.Range(1, 72).Select(x => (byte)x).ToArray();
        byte[] actual = pdus.Select(x => x.Type).Order().ToArray();
        if (!actual.SequenceEqual(expected))
            throw new InvalidDataException($"PDU identifiers must cover 1 through 72 exactly; found {string.Join(", ", actual)}.");

        var names = classes.Select(x => x.Name).ToHashSet(StringComparer.Ordinal);
        string[] missingBases = classes
            .Where(x => x.BaseName != "root" && !names.Contains(x.BaseName))
            .Select(x => $"{x.Name}->{x.BaseName}")
            .ToArray();
        if (missingBases.Length != 0)
            throw new InvalidDataException($"Missing base classes: {string.Join(", ", missingBases)}");
    }

    private static string Required(XElement element, string attribute) =>
        (string?)element.Attribute(attribute)
        ?? throw new InvalidDataException($"Element '{element.Name}' requires attribute '{attribute}'.");

    private static int? OptionalInt(XElement element, string attribute) =>
        int.TryParse((string?)element.Attribute(attribute), CultureInfo.InvariantCulture, out int value) ? value : null;

    private static string? Comment(XElement element) => (string?)element.Attribute("comment");

    private static bool Hidden(XElement element) =>
        string.Equals((string?)element.Attribute("hidden"), "true", StringComparison.OrdinalIgnoreCase);

    private static IReadOnlyDictionary<string, SisoWireType> LoadSisoWireTypes()
    {
        const string resourceName = "OpenDisNet.Generator.Schemas.SISO.referenced-types-v35.json";
        using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
            ?? throw new InvalidDataException($"Missing embedded SISO metadata '{resourceName}'.");
        SisoWireType[] values = JsonSerializer.Deserialize<SisoWireType[]>(stream, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        }) ?? throw new InvalidDataException("SISO metadata is empty.");
        return values.ToDictionary(x => x.Name, StringComparer.Ordinal);
    }

    private sealed record SisoWireType(string Name, int Uid, int Bits, string Kind);
}

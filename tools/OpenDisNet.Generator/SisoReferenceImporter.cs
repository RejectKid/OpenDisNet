using System.Globalization;
using System.IO.Compression;
using System.Reflection;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace OpenDisNet.Generator;

internal static partial class SisoReferenceImporter
{
    public static void Import(string archivePath, string catalogPath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(archivePath);
        XDocument document;
        if (archivePath == "-")
        {
            document = XDocument.Load(Console.In);
        }
        else if (Path.GetExtension(archivePath).Equals(".xml", StringComparison.OrdinalIgnoreCase))
        {
            document = XDocument.Load(archivePath);
        }
        else
        {
            using ZipArchive archive = ZipFile.OpenRead(archivePath);
            ZipArchiveEntry xmlEntry = archive.GetEntry("SISO-REF-010.xml")
                ?? throw new InvalidDataException("The archive does not contain SISO-REF-010.xml.");
            using Stream xmlStream = xmlEntry.Open();
            document = XDocument.Load(xmlStream);
        }
        XElement root = document.Root ?? throw new InvalidDataException("The SISO document has no root element.");
        if ((string?)root.Attribute("title") != "SISO-REF-010-v36")
            throw new InvalidDataException($"Expected SISO-REF-010-v36; found '{(string?)root.Attribute("title")}'.");

        const string baselineResource = "OpenDisNet.Generator.Schemas.SISO.dis7-referenced-types.json";
        using Stream baselineStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(baselineResource)
            ?? throw new InvalidDataException($"Missing embedded baseline '{baselineResource}'.");
        BaselineType[] baseline = JsonSerializer.Deserialize<BaselineType[]>(baselineStream, JsonOptions())
            ?? throw new InvalidDataException("The baseline SISO reference list is empty.");
        var definitions = new List<CatalogType>(baseline.Length);

        foreach (BaselineType reference in baseline.OrderBy(x => x.Uid))
        {
            XElement element = root.Descendants().SingleOrDefault(x => (int?)x.Attribute("uid") == reference.Uid)
                ?? throw new InvalidDataException($"SISO v36 does not define UID {reference.Uid} ({reference.Name}).");
            string kind = element.Name.LocalName switch
            {
                "enum" => "sisoenum",
                "bitfield" => "sisobitfield",
                _ => throw new InvalidDataException($"UID {reference.Uid} has unsupported kind '{element.Name.LocalName}'."),
            };
            int bits = RequiredInt(element, "size");
            if (bits != reference.Bits)
                throw new InvalidDataException($"UID {reference.Uid} changed wire width from {reference.Bits} to {bits} bits.");

            var usedNames = new HashSet<string>(StringComparer.Ordinal);
            CatalogMember[] members = kind == reference.Kind
                ? element.Elements().Where(x => x.Name.LocalName is "enumrow" or "bitfieldrow")
                    .Select(row => CreateMember(row, kind, usedNames))
                    .ToArray()
                : [];
            if (kind != reference.Kind)
                Console.Error.WriteLine($"UID {reference.Uid} is a {kind} catalog selector but DIS uses it as {reference.Kind}; preserving the DIS wire type without misleading members.");
            definitions.Add(new(reference.Name, reference.Uid, bits, reference.Kind, members));
        }

        string json = JsonSerializer.Serialize(definitions, JsonOptions(writeIndented: true)) + Environment.NewLine;
        File.WriteAllText(catalogPath, json);
        Console.WriteLine($"Imported {definitions.Count} DIS-referenced SISO v36 types from '{archivePath}'.");
    }

    private static CatalogMember CreateMember(XElement row, string kind, HashSet<string> usedNames)
    {
        string sourceName = kind == "sisoenum" ? Required(row, "description") : Required(row, "name");
        ulong? value = kind == "sisoenum" ? ulong.Parse(Required(row, "value"), CultureInfo.InvariantCulture) : null;
        int? position = kind == "sisobitfield" ? RequiredInt(row, "bit_position") : null;
        int? length = kind == "sisobitfield" ? (int?)row.Attribute("length") ?? 1 : null;
        string name = Identifier(sourceName);
        if (!usedNames.Add(name))
        {
            string suffix = value?.ToString(CultureInfo.InvariantCulture) ?? position?.ToString(CultureInfo.InvariantCulture) ?? "Value";
            name += suffix;
            for (int index = 2; !usedNames.Add(name); index++) name = $"{name}{index}";
        }
        return new(
            name,
            value,
            position,
            length,
            (string?)row.Attribute("description"),
            (int?)row.Attribute("xref"),
            string.Equals((string?)row.Attribute("deprecated"), "true", StringComparison.OrdinalIgnoreCase)
                || string.Equals((string?)row.Attribute("status"), "deprecated", StringComparison.OrdinalIgnoreCase));
    }

    private static string Identifier(string value)
    {
        string[] words = NonAlphaNumeric().Split(value).Where(x => x.Length != 0).ToArray();
        string result = string.Concat(words.Select(PascalWord));
        if (result.Length == 0) result = "Value";
        if (char.IsDigit(result[0])) result = "Value" + result;
        return result switch
        {
            "Class" or "Event" or "Fixed" or "Internal" or "Object" or "Params" or "Ref" or "String" => result + "Value",
            _ => result,
        };
    }

    private static string PascalWord(string word)
    {
        if (word.Length == 1) return word.ToUpperInvariant();
        return char.ToUpperInvariant(word[0]) + (word.All(c => !char.IsLetter(c) || char.IsUpper(c)) ? word[1..].ToLowerInvariant() : word[1..]);
    }

    private static string Required(XElement element, string attribute) =>
        (string?)element.Attribute(attribute) ?? throw new InvalidDataException($"Element '{element.Name}' requires '{attribute}'.");

    private static int RequiredInt(XElement element, string attribute) =>
        int.Parse(Required(element, attribute), CultureInfo.InvariantCulture);

    private static JsonSerializerOptions JsonOptions(bool writeIndented = false) => new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        PropertyNameCaseInsensitive = true,
        WriteIndented = writeIndented,
    };

    [GeneratedRegex("[^A-Za-z0-9]+")]
    private static partial Regex NonAlphaNumeric();

    private sealed record BaselineType(string Name, int Uid, int Bits, string Kind);
    private sealed record CatalogType(string Name, int Uid, int Bits, string Kind, CatalogMember[] Members);
    private sealed record CatalogMember(string Name, ulong? Value, int? BitPosition, int? Length, string? Description, int? CrossReference, bool Deprecated);
}

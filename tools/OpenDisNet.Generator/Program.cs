using OpenDisNet.Generator;

string repositoryRoot = FindRepositoryRoot(AppContext.BaseDirectory);
string catalogOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Internal", "SchemaCatalog.cs");
string factoryOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Pdus", "PduFactory.cs");
string codecOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Internal", "PduCodec.cs");
bool verify = args.Contains("--verify", StringComparer.Ordinal);

DisSchema schema = DisSchemaLoader.Load();
string generatedCatalog = ManifestWriter.Create(schema);
string generatedFactory = FactoryWriter.Create(schema);
string generatedCodec = CodecWriter.Create(schema);
Dictionary<string, string> modelOutputs = schema.SourceFiles.ToDictionary(
    sourceFile => ModelOutput(repositoryRoot, sourceFile),
    sourceFile => ModelWriter.Create(schema, sourceFile),
    StringComparer.OrdinalIgnoreCase);

if (verify)
{
    bool stale = !Matches(catalogOutput, generatedCatalog)
        || !Matches(factoryOutput, generatedFactory)
        || !Matches(codecOutput, generatedCodec)
        || modelOutputs.Any(x => !Matches(x.Key, x.Value));
    if (stale)
    {
        Console.Error.WriteLine("Checked-in DIS protocol source is stale. Run the protocol source tool.");
        return 1;
    }
}
else
{
    Directory.CreateDirectory(Path.GetDirectoryName(catalogOutput)!);
    File.WriteAllText(catalogOutput, generatedCatalog);
    File.WriteAllText(factoryOutput, generatedFactory);
    File.WriteAllText(codecOutput, generatedCodec);
    foreach ((string path, string contents) in modelOutputs)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);
        File.WriteAllText(path, contents);
    }
}

static bool Matches(string path, string expected)
{
    if (!File.Exists(path)) return false;
    using var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
    using var reader = new StreamReader(stream);
    return reader.ReadToEnd().ReplaceLineEndings("\n") == expected;
}

Console.WriteLine($"Validated {schema.Classes.Length} classes and {schema.Pdus.Length} PDUs (types 1-72).");
return 0;

static string ModelOutput(string repositoryRoot, string sourceFile)
{
    string fileName = sourceFile == "DIS_7_2012.xml"
        ? "Records.cs"
        : sourceFile.Replace("FamilyPdus.xml", "Pdus.cs", StringComparison.Ordinal);
    return Path.Combine(repositoryRoot, "src", "OpenDisNet", "Pdus", "Families", fileName);
}

static string FindRepositoryRoot(string start)
{
    var directory = new DirectoryInfo(start);
    while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "OpenDisNet.slnx")))
        directory = directory.Parent;
    return directory?.FullName ?? throw new DirectoryNotFoundException("Could not locate the OpenDisNet repository root.");
}

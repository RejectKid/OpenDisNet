using OpenDisNet.Generator;

string repositoryRoot = FindRepositoryRoot(AppContext.BaseDirectory);
string output = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Internal", "SchemaManifest.g.cs");
string modelsOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Pdus", "PduModels.g.cs");
string factoryOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Pdus", "PduFactory.g.cs");
string codecOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Internal", "PduCodec.g.cs");
bool verify = args.Contains("--verify", StringComparer.Ordinal);

DisSchema schema = DisSchemaLoader.Load();
string generated = ManifestWriter.Create(schema);
string generatedModels = ModelWriter.Create(schema);
string generatedFactory = FactoryWriter.Create(schema);
string generatedCodec = CodecWriter.Create(schema);

if (verify)
{
    if (!Matches(output, generated) || !Matches(modelsOutput, generatedModels) || !Matches(factoryOutput, generatedFactory) || !Matches(codecOutput, generatedCodec))
    {
        Console.Error.WriteLine($"Generated output is stale: {output}");
        return 1;
    }
}
else
{
    Directory.CreateDirectory(Path.GetDirectoryName(output)!);
    File.WriteAllText(output, generated);
    File.WriteAllText(modelsOutput, generatedModels);
    File.WriteAllText(factoryOutput, generatedFactory);
    File.WriteAllText(codecOutput, generatedCodec);
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

static string FindRepositoryRoot(string start)
{
    var directory = new DirectoryInfo(start);
    while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "OpenDisNet.slnx")))
        directory = directory.Parent;
    return directory?.FullName ?? throw new DirectoryNotFoundException("Could not locate the OpenDisNet repository root.");
}

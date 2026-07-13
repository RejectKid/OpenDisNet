using OpenDisNet.Generator;

string repositoryRoot = FindRepositoryRoot(AppContext.BaseDirectory);
string output = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Generated", "Dis7SchemaManifest.g.cs");
string modelsOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Generated", "Dis7Models.g.cs");
string factoryOutput = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Generated", "Dis7PduFactory.g.cs");
bool verify = args.Contains("--verify", StringComparer.Ordinal);

DisSchema schema = DisSchemaLoader.Load();
string generated = ManifestWriter.Create(schema);
string generatedModels = ModelWriter.Create(schema);
string generatedFactory = FactoryWriter.Create(schema);

if (verify)
{
    if (!Matches(output, generated) || !Matches(modelsOutput, generatedModels) || !Matches(factoryOutput, generatedFactory))
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
}

static bool Matches(string path, string expected) =>
    File.Exists(path) && File.ReadAllText(path).ReplaceLineEndings("\n") == expected;

Console.WriteLine($"Validated {schema.Classes.Length} classes and {schema.Pdus.Length} PDUs (types 1-72).");
return 0;

static string FindRepositoryRoot(string start)
{
    var directory = new DirectoryInfo(start);
    while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "OpenDisNet.slnx")))
        directory = directory.Parent;
    return directory?.FullName ?? throw new DirectoryNotFoundException("Could not locate the OpenDisNet repository root.");
}

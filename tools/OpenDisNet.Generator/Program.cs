using OpenDisNet.Generator;

string repositoryRoot = FindRepositoryRoot(AppContext.BaseDirectory);
string output = Path.Combine(repositoryRoot, "src", "OpenDisNet", "Generated", "Dis7SchemaManifest.g.cs");
bool verify = args.Contains("--verify", StringComparer.Ordinal);

DisSchema schema = DisSchemaLoader.Load();
string generated = ManifestWriter.Create(schema);

if (verify)
{
    if (!File.Exists(output) || File.ReadAllText(output).ReplaceLineEndings("\n") != generated)
    {
        Console.Error.WriteLine($"Generated output is stale: {output}");
        return 1;
    }
}
else
{
    Directory.CreateDirectory(Path.GetDirectoryName(output)!);
    File.WriteAllText(output, generated);
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

using System.Security.Cryptography;
using System.Text.Json;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

public sealed class ConformanceAuditTests
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    [Fact]
    public void AuditedInputsHaveNotChanged()
    {
        string root = FindRepositoryRoot();
        AuditManifest manifest = ReadManifest(root);

        Assert.Equal("1.0", manifest.AuditVersion);
        Assert.Equal(72, manifest.PduTypeCount);
        Assert.Equal(233, manifest.ConcreteWireClassCount);
        Assert.Equal(17, manifest.Artifacts.Length);

        foreach (AuditArtifact artifact in manifest.Artifacts)
        {
            string path = Path.Combine(root, artifact.Path.Replace('/', Path.DirectorySeparatorChar));
            Assert.True(File.Exists(path), $"Audited input is missing: {artifact.Path}");
            string actual = Convert.ToHexStringLower(SHA256.HashData(File.ReadAllBytes(path)));
            Assert.Equal(artifact.Sha256, actual);
        }
    }

    [Fact]
    public void AuditAccountsForEveryStandardPduAndFamily()
    {
        string root = FindRepositoryRoot();
        AuditManifest manifest = ReadManifest(root);
        int[] auditedTypes = manifest.Families.SelectMany(x => x.Types).Order().ToArray();

        Assert.Equal(Enumerable.Range(1, 72), auditedTypes);
        Assert.Equal(72, manifest.Families.Sum(x => x.Count));
        Assert.Equal(12, manifest.Families.Length);

        foreach (AuditFamily family in manifest.Families)
        {
            Assert.Equal(family.Count, family.Types.Length);
            foreach (int type in family.Types)
            {
                Pdu pdu = PduFactory.Create((PduType)type);
                Assert.Equal((ProtocolFamily)family.Value, pdu.ProtocolFamily);
            }
        }
    }

    private static AuditManifest ReadManifest(string root)
    {
        string path = Path.Combine(root, "tests", "OpenDisNet.Tests", "Conformance", "Audit", "v1.0.json");
        return JsonSerializer.Deserialize<AuditManifest>(File.ReadAllText(path), JsonOptions)
            ?? throw new InvalidDataException("The 1.0 conformance audit manifest is empty.");
    }

    private static string FindRepositoryRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "OpenDisNet.slnx")))
            directory = directory.Parent;
        return directory?.FullName ?? throw new DirectoryNotFoundException("Could not locate the OpenDisNet repository root.");
    }

    private sealed record AuditManifest(
        string AuditVersion,
        string WireStandard,
        string EnumerationStandard,
        int PduTypeCount,
        int ConcreteWireClassCount,
        AuditFamily[] Families,
        AuditArtifact[] Artifacts);

    private sealed record AuditFamily(int Value, int Count, int[] Types);

    private sealed record AuditArtifact(string Path, string Sha256);
}

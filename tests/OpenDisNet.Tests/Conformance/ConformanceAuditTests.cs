using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

[TestClass]
public sealed class ConformanceAuditTests
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
    };

    [TestMethod]
    public void AuditedInputsHaveNotChanged()
    {
        string root = FindRepositoryRoot();
        AuditManifest manifest = ReadManifest(root);

        Assert.AreEqual("1.0.1", manifest.AuditVersion);
        Assert.AreEqual(72, manifest.PduTypeCount);
        Assert.AreEqual(233, manifest.ConcreteWireClassCount);
        Assert.AreEqual(17, manifest.Artifacts.Length);

        foreach (AuditArtifact artifact in manifest.Artifacts)
        {
            string path = Path.Combine(root, artifact.Path.Replace('/', Path.DirectorySeparatorChar));
            Assert.IsTrue(File.Exists(path), $"Audited input is missing: {artifact.Path}");
            byte[] normalized = Encoding.UTF8.GetBytes(File.ReadAllText(path).ReplaceLineEndings("\n"));
            string actual = Convert.ToHexStringLower(SHA256.HashData(normalized));
            Assert.AreEqual(artifact.Sha256, actual);
        }
    }

    [TestMethod]
    public void AuditAccountsForEveryStandardPduAndFamily()
    {
        string root = FindRepositoryRoot();
        AuditManifest manifest = ReadManifest(root);
        int[] auditedTypes = manifest.Families.SelectMany(x => x.Types).Order().ToArray();

        Assert.AreSequenceEqual(Enumerable.Range(1, 72), auditedTypes);
        Assert.AreEqual(72, manifest.Families.Sum(x => x.Count));
        Assert.AreEqual(12, manifest.Families.Length);

        foreach (AuditFamily family in manifest.Families)
        {
            Assert.AreEqual(family.Count, family.Types.Length);
            foreach (int type in family.Types)
            {
                Pdu pdu = PduFactory.Create((PduType)type);
                Assert.AreEqual((ProtocolFamily)family.Value, pdu.ProtocolFamily);
            }
        }
    }

    private static AuditManifest ReadManifest(string root)
    {
        string path = Path.Combine(root, "tests", "OpenDisNet.Tests", "Conformance", "Audit", "v1.0.1.json");
        return JsonSerializer.Deserialize<AuditManifest>(File.ReadAllText(path), JsonOptions)
            ?? throw new InvalidDataException("The 1.0.1 conformance audit manifest is empty.");
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

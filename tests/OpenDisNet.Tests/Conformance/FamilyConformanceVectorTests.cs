using System.Text.Json;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

[TestClass]
public sealed class FamilyConformanceVectorTests
{
    // These fixtures expose known defects in the reference generator's
    // variable-length/padding output. Keep them explicit instead of weakening
    // the native C# codec to reproduce non-conformant bytes.
    private static readonly HashSet<int> PopulatedReferenceIncompatibilities =
    [
        16, 17, 18, 19, 20, 21, 22, 25, 32, 33, 34, 35, 39, 41,
        43, 44, 45, 56, 57, 58, 59, 60, 61, 62, 63, 64, 68, 72,
    ];

    public static IEnumerable<object[]> AllFamilies =>
    [
        [(byte)1, "0.3 Entity Information"], [(byte)2, "0.3 Warfare"],
        [(byte)3, "0.4 Logistics"], [(byte)5, "0.4 Simulation Management"],
        [(byte)6, "0.5 Distributed Emissions"], [(byte)4, "0.5 Radio Communications"],
        [(byte)7, "0.6 Entity Management"], [(byte)8, "0.6 Minefield"],
        [(byte)9, "0.7 Synthetic Environment"], [(byte)10, "0.7 Simulation Management with Reliability"],
        [(byte)11, "0.8 Live Entity"], [(byte)13, "0.8 Information Operations"],
    ];

    public static IEnumerable<object[]> StandardPduTypes =>
        Enumerable.Range(1, 72).Select(x => new object[] { (byte)x });

    public static IEnumerable<object[]> OpenDisJavaVectors =>
        ReadOpenDisJavaVectors()
            .Where(x => x.Type is not 43 and not 45)
            .Select(x => new object[] { (byte)x.Type, x.Name, x.Hex });

    public static IEnumerable<object[]> OpenDisJavaPopulatedVectors =>
        ReadOpenDisJavaVectors("opendis7-java-populated.json")
            .Where(x => !PopulatedReferenceIncompatibilities.Contains(x.Type))
            .Select(x => new object[] { (byte)x.Type, x.Name, x.Hex });

    [TestMethod]
    [DynamicData(nameof(StandardPduTypes))]
    public void PopulatedPduRoundTripsByteIdentically(byte value)
    {
        Pdu original = DeterministicPduFixture.Create((PduType)value);

        byte[] bytes = DisSerializer.Serialize(original);
        Pdu decoded = Assert.IsInstanceOfType<Pdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual(original.GetType(), decoded.GetType());
        Assert.AreSequenceEqual(bytes, DisSerializer.Serialize(decoded));
        Assert.IsTrue(bytes.Length > 12);
    }

    [TestMethod]
    [DynamicData(nameof(OpenDisJavaVectors))]
    public void IndependentOpenDisJavaVectorRoundTrips(byte value, string referenceName, string hex)
    {
        byte[] bytes = Convert.FromHexString(hex);
        Pdu decoded = Assert.IsInstanceOfType<Pdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual((PduType)value, decoded.PduType);
        Assert.AreSequenceEqual(bytes, DisSerializer.Serialize(decoded));
        Assert.IsFalse(string.IsNullOrWhiteSpace(referenceName));
    }

    [TestMethod]
    [DynamicData(nameof(OpenDisJavaPopulatedVectors))]
    public void IndependentPopulatedOpenDisJavaVectorRoundTrips(byte value, string referenceName, string hex)
    {
        byte[] bytes = Convert.FromHexString(hex);
        Pdu decoded = Assert.IsInstanceOfType<Pdu>(DisSerializer.Deserialize(bytes));

        Assert.AreEqual((PduType)value, decoded.PduType);
        Assert.AreSequenceEqual(bytes, DisSerializer.Serialize(decoded));
        Assert.IsFalse(string.IsNullOrWhiteSpace(referenceName));
    }

    [TestMethod]
    [DynamicData(nameof(AllFamilies))]
    public void EveryByteBoundaryRejectsTruncation(byte family, string milestone)
    {
        Pdu[] pdus = Enumerable.Range(1, 72)
            .Select(x => DeterministicPduFixture.Create((PduType)x))
            .Where(x => (byte)x.ProtocolFamily == family)
            .ToArray();
        Assert.IsTrue(pdus.Length > 0);

        foreach (Pdu pdu in pdus)
        {
            byte[] bytes = DisSerializer.Serialize(pdu);
            for (int length = 0; length < bytes.Length; length++)
            {
                bool parsed = DisSerializer.TryDeserialize(bytes.AsSpan(0, length), out _, out DisParseError error);
                Assert.IsFalse(parsed, $"{milestone}: {pdu.GetType().Name} accepted truncation at byte {length}.");
                Assert.AreNotEqual(DisParseErrorCode.None, error.Code);
            }
        }
    }

    [TestMethod]
    public void IndependentVectorSetCoversEveryStandardPduExactlyOnce()
    {
        OpenDisJavaVector[] vectors = ReadOpenDisJavaVectors();
        Assert.AreEqual(72, vectors.Length);
        Assert.AreSequenceEqual(Enumerable.Range(1, 72), vectors.Select(x => x.Type).Order());
    }

    [TestMethod]
    public void CompatiblePopulatedReferenceVectorsCoverEveryPduFamily()
    {
        OpenDisJavaVector[] vectors = ReadOpenDisJavaVectors("opendis7-java-populated.json")
            .Where(x => !PopulatedReferenceIncompatibilities.Contains(x.Type))
            .ToArray();

        Assert.AreEqual(44, vectors.Length);
        Assert.AreSequenceEqual(
            AllFamilies.Select(row => (byte)row[0]).Order(),
            vectors.Select(x => Convert.FromHexString(x.Hex)[3]).Distinct().Order());
    }

    [TestMethod]
    [DataRow(43)]
    [DataRow(45)]
    public void OpenDisJavaBitfieldWidthDifferencesRemainExplicit(int type)
    {
        OpenDisJavaVector vector = ReadOpenDisJavaVectors().Single(x => x.Type == type);

        Assert.IsFalse(DisSerializer.TryDeserialize(Convert.FromHexString(vector.Hex), out _, out DisParseError error));
        Assert.AreEqual(DisParseErrorCode.InvalidField, error.Code);
    }

    private static OpenDisJavaVector[] ReadOpenDisJavaVectors(string fileName = "opendis7-java-default.json")
    {
        string path = Path.Combine(AppContext.BaseDirectory, "Conformance", "Vectors", fileName);
        return JsonSerializer.Deserialize<OpenDisJavaVector[]>(File.ReadAllText(path), new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        }) ?? throw new InvalidDataException("The Open-DIS Java conformance vector set is empty.");
    }

    private sealed record OpenDisJavaVector(int Type, string Name, string Hex);
}

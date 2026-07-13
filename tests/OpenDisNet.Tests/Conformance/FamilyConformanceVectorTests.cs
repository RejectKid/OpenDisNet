using System.Text.Json;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Tests.Conformance;

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

    public static TheoryData<byte, string> AllFamilies => new()
    {
        { 1, "0.3 Entity Information" }, { 2, "0.3 Warfare" },
        { 3, "0.4 Logistics" }, { 5, "0.4 Simulation Management" },
        { 6, "0.5 Distributed Emissions" }, { 4, "0.5 Radio Communications" },
        { 7, "0.6 Entity Management" }, { 8, "0.6 Minefield" },
        { 9, "0.7 Synthetic Environment" }, { 10, "0.7 Simulation Management with Reliability" },
        { 11, "0.8 Live Entity" }, { 13, "0.8 Information Operations" },
    };

    public static TheoryData<byte> StandardPduTypes =>
        new(Enumerable.Range(1, 72).Select(x => (byte)x));

    public static TheoryData<byte, string, string> OpenDisJavaVectors
    {
        get
        {
            var data = new TheoryData<byte, string, string>();
            foreach (OpenDisJavaVector vector in ReadOpenDisJavaVectors().Where(x => x.Type is not 43 and not 45))
                data.Add((byte)vector.Type, vector.Name, vector.Hex);
            return data;
        }
    }

    public static TheoryData<byte, string, string> OpenDisJavaPopulatedVectors
    {
        get
        {
            var data = new TheoryData<byte, string, string>();
            foreach (OpenDisJavaVector vector in ReadOpenDisJavaVectors("opendis7-java-populated.json")
                         .Where(x => !PopulatedReferenceIncompatibilities.Contains(x.Type)))
                data.Add((byte)vector.Type, vector.Name, vector.Hex);
            return data;
        }
    }

    [Theory]
    [MemberData(nameof(StandardPduTypes))]
    public void PopulatedPduRoundTripsByteIdentically(byte value)
    {
        Pdu original = DeterministicPduFixture.Create((PduType)value);

        byte[] bytes = DisSerializer.Serialize(original);
        Pdu decoded = Assert.IsAssignableFrom<Pdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal(original.GetType(), decoded.GetType());
        Assert.Equal(bytes, DisSerializer.Serialize(decoded));
        Assert.True(bytes.Length > 12);
    }

    [Theory]
    [MemberData(nameof(OpenDisJavaVectors))]
    public void IndependentOpenDisJavaVectorRoundTrips(byte value, string referenceName, string hex)
    {
        byte[] bytes = Convert.FromHexString(hex);
        Pdu decoded = Assert.IsAssignableFrom<Pdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal((PduType)value, decoded.PduType);
        Assert.Equal(bytes, DisSerializer.Serialize(decoded));
        Assert.False(string.IsNullOrWhiteSpace(referenceName));
    }

    [Theory]
    [MemberData(nameof(OpenDisJavaPopulatedVectors))]
    public void IndependentPopulatedOpenDisJavaVectorRoundTrips(byte value, string referenceName, string hex)
    {
        byte[] bytes = Convert.FromHexString(hex);
        Pdu decoded = Assert.IsAssignableFrom<Pdu>(DisSerializer.Deserialize(bytes));

        Assert.Equal((PduType)value, decoded.PduType);
        Assert.Equal(bytes, DisSerializer.Serialize(decoded));
        Assert.False(string.IsNullOrWhiteSpace(referenceName));
    }

    [Theory]
    [MemberData(nameof(AllFamilies))]
    public void EveryByteBoundaryRejectsTruncation(byte family, string milestone)
    {
        Pdu[] pdus = Enumerable.Range(1, 72)
            .Select(x => DeterministicPduFixture.Create((PduType)x))
            .Where(x => (byte)x.ProtocolFamily == family)
            .ToArray();
        Assert.NotEmpty(pdus);

        foreach (Pdu pdu in pdus)
        {
            byte[] bytes = DisSerializer.Serialize(pdu);
            for (int length = 0; length < bytes.Length; length++)
            {
                bool parsed = DisSerializer.TryDeserialize(bytes.AsSpan(0, length), out _, out DisParseError error);
                Assert.False(parsed, $"{milestone}: {pdu.GetType().Name} accepted truncation at byte {length}.");
                Assert.NotEqual(DisParseErrorCode.None, error.Code);
            }
        }
    }

    [Fact]
    public void IndependentVectorSetCoversEveryStandardPduExactlyOnce()
    {
        OpenDisJavaVector[] vectors = ReadOpenDisJavaVectors();
        Assert.Equal(72, vectors.Length);
        Assert.Equal(Enumerable.Range(1, 72), vectors.Select(x => x.Type).Order());
    }

    [Fact]
    public void CompatiblePopulatedReferenceVectorsCoverEveryPduFamily()
    {
        OpenDisJavaVector[] vectors = ReadOpenDisJavaVectors("opendis7-java-populated.json")
            .Where(x => !PopulatedReferenceIncompatibilities.Contains(x.Type))
            .ToArray();

        Assert.Equal(44, vectors.Length);
        Assert.Equal(
            AllFamilies.Select(row => (byte)row[0]).Order(),
            vectors.Select(x => Convert.FromHexString(x.Hex)[3]).Distinct().Order());
    }

    [Theory]
    [InlineData(43)]
    [InlineData(45)]
    public void OpenDisJavaBitfieldWidthDifferencesRemainExplicit(int type)
    {
        OpenDisJavaVector vector = Assert.Single(ReadOpenDisJavaVectors(), x => x.Type == type);

        Assert.False(DisSerializer.TryDeserialize(Convert.FromHexString(vector.Hex), out _, out DisParseError error));
        Assert.Equal(DisParseErrorCode.InvalidField, error.Code);
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

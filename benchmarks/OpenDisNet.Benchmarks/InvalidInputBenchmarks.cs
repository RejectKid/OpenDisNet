using BenchmarkDotNet.Attributes;
using OpenDisNet.Pdus;

namespace OpenDisNet.Benchmarks;

public enum InvalidInputScenario
{
    TruncatedHeader,
    TruncatedPdu,
    RandomKilobyte,
}

[MemoryDiagnoser]
public class InvalidInputBenchmarks
{
    private byte[] _datagram = null!;

    [ParamsAllValues]
    public InvalidInputScenario Scenario { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _datagram = Scenario switch
        {
            InvalidInputScenario.TruncatedHeader => [7, 1, 1],
            InvalidInputScenario.TruncatedPdu => CreateTruncatedPdu(),
            InvalidInputScenario.RandomKilobyte => CreateRandomInput(),
            _ => throw new ArgumentOutOfRangeException(),
        };
    }

    [Benchmark(Baseline = true)]
    public bool TryDeserialize() => DisSerializer.TryDeserialize(_datagram, out _, out _);

    [Benchmark]
    public DisReadStatus TryRead() => DisSerializer.TryRead(_datagram, out _, out _, out _);

    private static byte[] CreateTruncatedPdu()
    {
        var signal = new SignalPdu { Radio = new RadioId(new EntityId(1, 1, 1), 1) };
        signal.SetData(new byte[160]);
        return DisSerializer.Serialize(signal)[..^1];
    }

    private static byte[] CreateRandomInput()
    {
        var bytes = new byte[1024];
        new Random(42).NextBytes(bytes);
        return bytes;
    }
}

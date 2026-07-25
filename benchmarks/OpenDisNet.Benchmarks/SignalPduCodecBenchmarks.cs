using BenchmarkDotNet.Attributes;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;

namespace OpenDisNet.Benchmarks;

[MemoryDiagnoser]
public class SignalPduCodecBenchmarks
{
    private SignalPdu _signal = null!;
    private byte[] _datagram = null!;
    private byte[] _destination = null!;

    [Params(32, 160, 1024)]
    public int PayloadBytes { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        byte[] payload = new byte[PayloadBytes];
        for (int index = 0; index < payload.Length; index++)
            payload[index] = unchecked((byte)(index * 31));

        _signal = new SignalPdu
        {
            ExerciseId = 1,
            Timestamp = 42,
            Radio = new RadioId(new EntityId(1, 10, 42), 7),
            EncodingScheme = SignalEncodingScheme.EncodedAudio(SignalEncodingType.Opus),
            TdlType = SignalTdlType.Other,
            SampleRate = 8_000,
            SampleCount = checked((ushort)Math.Min(PayloadBytes, ushort.MaxValue)),
        };
        _signal.SetData(payload);

        _datagram = DisSerializer.Serialize(_signal);
        _destination = new byte[_datagram.Length];
    }

    [Benchmark(Baseline = true)]
    public SignalPdu DeserializeTyped() =>
        DisSerializer.Deserialize<SignalPdu>(_datagram);

    [Benchmark]
    public bool TryDeserializeTyped() =>
        DisSerializer.TryDeserialize<SignalPdu>(_datagram, out _, out _);

    [Benchmark]
    public byte[] SerializeAllocated() =>
        DisSerializer.Serialize(_signal);

    [Benchmark]
    public int SerializeCallerOwned() =>
        DisSerializer.Serialize(_signal, _destination);
}

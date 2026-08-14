using BenchmarkDotNet.Attributes;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

namespace OpenDisNet.Benchmarks;

public enum PduScenario
{
    EntityState,
    Fire,
    Transmitter,
    UnknownVendor,
}

[MemoryDiagnoser]
public class RepresentativePduBenchmarks
{
    private IDisPdu _pdu = null!;
    private byte[] _datagram = null!;
    private byte[] _destination = null!;

    [ParamsAllValues]
    public PduScenario Scenario { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _pdu = CreatePdu(Scenario);
        _datagram = DisSerializer.Serialize(_pdu);
        _destination = new byte[_datagram.Length];
    }

    [Benchmark(Baseline = true)]
    public IDisPdu Deserialize() => DisSerializer.Deserialize(_datagram);

    [Benchmark]
    public DisReadStatus TryRead() => DisSerializer.TryRead(_datagram, out _, out _, out _);

    [Benchmark]
    public bool TryReadHeader() => DisSerializer.TryReadHeader(_datagram, out _, out _);

    [Benchmark]
    public int SerializeCallerOwned() => DisSerializer.Serialize(_pdu, _destination);

    private static IDisPdu CreatePdu(PduScenario scenario) => scenario switch
    {
        PduScenario.EntityState => DisPduBuilder.CreateEntityState(
            new EntityId(1, 10, 42),
            new EntityType
            {
                EntityKind = EntityKind.Platform,
                Domain = new Domain { Value = (byte)PlatformDomain.Air },
                Country = Country.UnitedStatesOfAmericaUsa,
                Category = 1,
            },
            new Vector3Double { X = 1_000, Y = 2_000, Z = 3_000 },
            ForceId.Friendly,
            exerciseId: 1),
        PduScenario.Fire => DisPduBuilder.CreateFire(
            new EntityId(1, 10, 42),
            new EntityId(1, 10, 43),
            new EntityId(1, 10, 44),
            7,
            new MunitionDescriptor { Quantity = 1 },
            new Vector3Double { X = 100, Y = 200, Z = 300 },
            new Vector3Float { X = 400, Y = 500, Z = 600 },
            range: 5_000,
            exerciseId: 1),
        PduScenario.Transmitter => CreateTransmitter(),
        PduScenario.UnknownVendor => new UnknownPdu(
            new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 1, (PduType)200, (ProtocolFamily)200, 42, 0, 0, 0),
            Enumerable.Range(0, 256).Select(index => unchecked((byte)(index * 31))).ToArray()),
        _ => throw new ArgumentOutOfRangeException(nameof(scenario)),
    };

    private static TransmitterPdu CreateTransmitter()
    {
        TransmitterPdu transmitter = DisPduBuilder.CreateTransmitter(
            new RadioId(new EntityId(1, 10, 42), 7),
            new RadioType(),
            frequency: 225_000_000,
            power: 50,
            exerciseId: 1);
        transmitter.ModulationParameters = Enumerable.Range(0, 64).Select(index => (byte)index).ToArray();
        return transmitter;
    }
}

# OpenDisNet

[![CI](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml/badge.svg)](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml)
[![Benchmarks](https://github.com/RejectKid/OpenDisNet/actions/workflows/benchmarks.yml/badge.svg)](https://github.com/RejectKid/OpenDisNet/actions/workflows/benchmarks.yml)
[![Fuzz smoke](https://github.com/RejectKid/OpenDisNet/actions/workflows/fuzz.yml/badge.svg)](https://github.com/RejectKid/OpenDisNet/actions/workflows/fuzz.yml)
[![NuGet](https://img.shields.io/nuget/v/OpenDisNet.svg)](https://www.nuget.org/packages/OpenDisNet)
[![GitHub Release](https://img.shields.io/github/v/release/RejectKid/OpenDisNet)](https://github.com/RejectKid/OpenDisNet/releases/latest)

OpenDisNet is a high-performance, type-safe, native C#/.NET parser and
serializer for IEEE 1278.1-2012 Distributed Interactive Simulation (DIS)
Protocol Version 7. It provides binary codecs for all 72 standardized PDU types.

> **Development status:** Stable 1.x release. All 72 DIS v7 PDU identifiers have
> typed native C# codecs, every family has populated, independent, malformed,
> and hostile-input evidence, and the public API is compatibility-frozen. See
> the [`1.0 audit`](docs/conformance-audit-v1.0.md),
> [`1.0.1 maintenance note`](docs/conformance-maintenance-v1.0.1.md), and
> [`conformance matrix`](docs/conformance.md).

## Install

```shell
dotnet add package OpenDisNet
```

## Parse a datagram

```csharp
using OpenDisNet;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;

if (DisSerializer.TryDeserialize<SignalPdu>(datagram, out SignalPdu? signal, out DisParseError error))
{
    Console.WriteLine($"Radio {signal.Radio.Number}: {signal.DataBitLength} meaningful bits");
    audioDecoder.Decode(signal.Data, signal.SampleRate);
}
else
{
    Console.Error.WriteLine($"Byte {error.Offset}: {error.Message}");
}
```

The parser checks framing, protocol version, declared length, and field bounds.
Unknown and vendor-defined PDU bodies are retained rather than discarded.
Use `DisSerializer.Serialize(pdu)` for the reverse operation. See the
[public API design](docs/api-design.md) for the supported design rules.

When reading packet captures, pipelines, or buffers containing multiple PDUs,
use the framed API. It distinguishes incomplete input from invalid input and
reports exactly how many octets to advance:

```csharp
DisReadStatus status = DisSerializer.TryRead(
    buffer,
    out IDisPdu? pdu,
    out int consumed,
    out DisParseError error);

if (status == DisReadStatus.Done)
    buffer = buffer[consumed..];
```

The same API accepts `ReadOnlySequence<byte>`. `TryReadHeader` inspects routing
fields without decoding or allocating a PDU body. If version enforcement is
explicitly disabled, non-v7 bodies are returned as `UnknownPdu`; they are never
interpreted using a v7 layout.

## Build and validate common PDUs

`DisPduBuilder` establishes discriminators and related fields for common
workflows. Semantic validation remains separate from bounded wire parsing:

```csharp
using OpenDisNet.Validation;

FirePdu fire = DisPduBuilder.CreateFire(
    firingEntity,
    targetEntity,
    munitionEntity,
    42,
    descriptor,
    launchLocation,
    velocity,
    range: 5_000,
    exerciseId: 1);

DisValidationResult validation = DisValidator.Validate(fire);
foreach (DisValidationIssue issue in validation.Issues)
    Console.WriteLine($"{issue.Severity}: {issue.Path}: {issue.Message}");
```

Builders are also available for Entity State, Detonation, and Transmitter PDUs.
Validation reports discriminator inconsistencies, non-finite coordinates,
invalid physical values, incomplete radio state, and unset primary identifiers
without changing the PDU.

## Create and serialize a Signal PDU

Signal data normally comes from an audio codec, tactical-data-link implementation,
file, or another application component. OpenDisNet handles its DIS framing without
requiring callers to construct protocol bytes by hand.

```csharp
using OpenDisNet;
using OpenDisNet.Pdus;

ReadOnlyMemory<byte> encodedAudio = audioEncoder.Encode(samples);

var signal = new SignalPdu
{
    ExerciseId = 1,
    Timestamp = 42,
    Radio = new RadioId(new EntityId(1, 10, 42), 7),
    EncodingScheme = SignalEncodingScheme.EncodedAudio(SignalEncodingType.Opus),
    TdlType = SignalTdlType.Other,
    SampleRate = 8_000,
    SampleCount = 1,
};
signal.SetData(encodedAudio.Span);

byte[] datagram = DisSerializer.Serialize(signal);
```

Protocol version, family, PDU type, PDU length, collection counts, and padding
are managed by the library. Signal payload interpretation remains with the
application because DIS can carry many audio encodings and tactical data-link
formats. For the uncommon case of a non-byte-aligned payload, `SetData` also
accepts an explicit meaningful bit length.

## Typed wire values

Fields defined by SISO-REF-010 v36 use generated enums instead of unexplained
integers. Composite bitfields expose named properties and immutable `With...`
methods while retaining their complete wire value:

```csharp
using OpenDisNet.Enumerations;

signal.TdlType = SignalTdlType.Link16StandardizedFormatJtidsMidsTadilJ;

var behavior = StopFreezeFrozenBehavior.None
    .WithRunSimulationClock(true)
    .WithProcessUpdates(true);
```

Forward compatibility is lossless. An unrecognized enumeration can be assigned
with a normal enum cast, and unknown or reserved bitfield bits remain available
through `Value`; parsing and reserialization preserve both exactly.

## Standards and provenance

- Wire format target: IEEE Std 1278.1-2012 (DIS v7).
- Enumeration target: SISO-REF-010-2025 (version 36).
- Cross-check sources include NPS MOVES Open-DIS projects and independent packet
  decoders. OpenDisNet is not a port and does not copy their public API design.
- The NuGet package has no Java code, dependency, runtime requirement, or
  Java-facing API. Reference implementations supply test bytes only.

See [the standards baseline](docs/standards.md) and
[conformance matrix](docs/conformance.md) for exact, release-specific coverage,
and [architecture](docs/architecture.md) for the independent .NET design.

OpenDisNet is not affiliated with or endorsed by IEEE, SISO, NPS, or the U.S.
Government. Users are responsible for obtaining standards needed for their own
conformance review.

## Build

```shell
dotnet restore
dotnet test --configuration Release
dotnet pack src/OpenDisNet/OpenDisNet.csproj --configuration Release
```

The library targets .NET 8, .NET 9, and .NET 10 and uses nullable annotations,
deterministic builds, and symbol packages.

The implementation is reviewable in ordinary source files: PDU classes are
grouped under [`src/OpenDisNet/Pdus/Families`](src/OpenDisNet/Pdus/Families),
all 72 binary dispatch paths are in
[`src/OpenDisNet/Internal/PduCodec.cs`](src/OpenDisNet/Internal/PduCodec.cs),
and checked big-endian primitives are under
[`src/OpenDisNet/Binary`](src/OpenDisNet/Binary).

## Benchmarks

The BenchmarkDotNet suite measures typed, framed, and header-only parsing plus
caller-owned serialization across Signal payload sizes and representative fixed,
variable, vendor-defined, and malformed PDUs. Run it on any supported runtime:

```shell
dotnet run --project benchmarks/OpenDisNet.Benchmarks -c Release -f net10.0
```

Replace `net10.0` with `net8.0` or `net9.0` for runtime comparisons. Benchmark
artifacts are written beneath `BenchmarkDotNet.Artifacts` and are not committed.

The [benchmark workflow](https://github.com/RejectKid/OpenDisNet/actions/workflows/benchmarks.yml)
runs a fast BenchmarkDotNet `Dry` smoke test across .NET 8, 9, and 10 for
relevant pull requests. Dry-mode timings only validate the harness; they are not
performance measurements. Full cross-runtime measurements run after relevant
changes land on `main`, every Monday, and on manual dispatch. The workflow adds
the Markdown table to its job summary and retains the HTML, Markdown, CSV, and
JSON results as downloadable artifacts for 30 days.

GitHub-hosted runners are appropriate for comparing runtimes within one run.
Use controlled, dedicated hardware before treating results from different runs
as a strict performance regression gate.

The parser also has a coverage-guided SharpFuzz target and a bounded CI mutation
campaign. See [parser fuzzing](docs/fuzzing.md) for local smoke, corpus creation,
instrumentation, and sustained fuzzing instructions.

## Security

Treat network datagrams as untrusted. See [`SECURITY.md`](SECURITY.md) for the
supported reporting process and parser safety guarantees.

## License

MIT. See [`THIRD-PARTY-NOTICES.md`](THIRD-PARTY-NOTICES.md) for reference-source
attribution.

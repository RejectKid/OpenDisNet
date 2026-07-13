# OpenDisNet

[![CI](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml/badge.svg)](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml)
[![NuGet](https://img.shields.io/nuget/v/OpenDisNet.svg)](https://www.nuget.org/packages/OpenDisNet)
[![GitHub Release](https://img.shields.io/github/v/release/RejectKid/OpenDisNet)](https://github.com/RejectKid/OpenDisNet/releases/latest)

OpenDisNet is a high-performance, type-safe .NET codec for Distributed
Interactive Simulation (DIS) Protocol Version 7, defined by IEEE 1278.1-2012.

> **Development status:** 1.0 release audit. All 72 DIS v7 PDU identifiers have
> typed native C# codecs, every family has populated, independent, malformed,
> and hostile-input evidence, and the public API is compatibility-frozen. See
> the [`1.0 audit`](docs/conformance-audit-v1.0.md) and
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

The library targets .NET 9 and .NET 10 and uses nullable annotations,
deterministic builds, and symbol packages.

The implementation is reviewable in ordinary source files: PDU classes are
grouped under [`src/OpenDisNet/Pdus/Families`](src/OpenDisNet/Pdus/Families),
all 72 binary dispatch paths are in
[`src/OpenDisNet/Internal/PduCodec.cs`](src/OpenDisNet/Internal/PduCodec.cs),
and checked big-endian primitives are under
[`src/OpenDisNet/Binary`](src/OpenDisNet/Binary).

## Security

Treat network datagrams as untrusted. See [`SECURITY.md`](SECURITY.md) for the
supported reporting process and parser safety guarantees.

## License

MIT. See [`THIRD-PARTY-NOTICES.md`](THIRD-PARTY-NOTICES.md) for reference-source
attribution.

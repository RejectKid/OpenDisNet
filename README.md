# OpenDisNet

[![CI](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml/badge.svg)](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml)
[![NuGet](https://img.shields.io/nuget/v/OpenDisNet.svg)](https://www.nuget.org/packages/OpenDisNet)
[![GitHub Release](https://img.shields.io/github/v/release/RejectKid/OpenDisNet)](https://github.com/RejectKid/OpenDisNet/releases/latest)

OpenDisNet is a high-performance, type-safe .NET codec for Distributed
Interactive Simulation (DIS) Protocol Version 7, defined by IEEE 1278.1-2012.

> **Development status:** pre-release. All 72 DIS v7 PDU identifiers have typed
> models and generated binary codecs. Family-level semantic conformance and
> independent vectors are tracked in [`docs/conformance.md`](docs/conformance.md).

## Install

```shell
dotnet add package OpenDisNet
```

## Parse a datagram

```csharp
using OpenDisNet;
using OpenDisNet.Pdus;

if (DisSerializer.TryDeserialize<SignalPdu>(datagram, out SignalPdu? signal, out DisParseError error))
{
    Console.WriteLine($"Radio {signal.Radio.Number}: {signal.DataBitLength} meaningful bits");
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

## Create and serialize a PDU

```csharp
using OpenDisNet;
using OpenDisNet.Pdus;
var signal = new SignalPdu
{
    ExerciseId = 1,
    Timestamp = 42,
    Radio = new RadioId(new EntityId(1, 10, 42), number: 7),
    EncodingScheme = 1,
    TdlType = 0,
    SampleRate = 8_000,
    SampleCount = 1,
};
signal.SetData([0xaa, 0xbb, 0xc0], meaningfulBitLength: 20);

byte[] datagram = DisSerializer.Serialize(signal);
```

Protocol version, family, PDU type, PDU length, collection counts, and padding
are managed by the library.

## Standards and provenance

- Wire format target: IEEE Std 1278.1-2012 (DIS v7).
- Enumeration target: SISO-REF-010-2025 (version 36).
- Cross-check sources include NPS MOVES Open-DIS projects and independent packet
  decoders. OpenDisNet is not a port and does not copy their public API design.

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

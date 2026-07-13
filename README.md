# OpenDisNet

[![CI](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml/badge.svg)](https://github.com/RejectKid/OpenDisNet/actions/workflows/ci.yml)
[![NuGet](https://img.shields.io/nuget/v/OpenDisNet.svg)](https://www.nuget.org/packages/OpenDisNet)

OpenDisNet is a high-performance, type-safe .NET codec for Distributed
Interactive Simulation (DIS) Protocol Version 7, defined by IEEE 1278.1-2012.

> **Development status:** pre-release. The common framing and defensive binary
> layer are implemented. Typed PDU coverage is tracked in
> [`docs/conformance.md`](docs/conformance.md); do not assume unlisted PDUs are
> semantically decoded.

## Install

```shell
dotnet add package OpenDisNet
```

## Parse a datagram

```csharp
using OpenDisNet;
using OpenDisNet.Pdus;

if (DisPduReader.TryParse(datagram, out IDisPdu? pdu, out DisParseError error))
{
    Console.WriteLine($"{pdu.Header.PduType}: {pdu.Header.Length} bytes");
}
else
{
    Console.Error.WriteLine($"Byte {error.Offset}: {error.Message}");
}
```

The parser checks framing, protocol version, declared length, and field bounds.
Unknown and vendor-defined PDU bodies are retained rather than discarded.

## Standards and provenance

- Wire format target: IEEE Std 1278.1-2012 (DIS v7).
- Enumeration target: SISO-REF-010-2025 (version 36).
- Reference baseline: NPS MOVES `open-dis/opendis7-java` and its source generator.

See [the standards baseline](docs/standards.md) and
[conformance matrix](docs/conformance.md) for exact, release-specific coverage.

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

## Security

Treat network datagrams as untrusted. See [`SECURITY.md`](SECURITY.md) for the
supported reporting process and parser safety guarantees.

## License

MIT. See [`THIRD-PARTY-NOTICES.md`](THIRD-PARTY-NOTICES.md) for reference-source
attribution.

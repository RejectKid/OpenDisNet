# Standards baseline

OpenDisNet targets:

- IEEE Std 1278.1-2012, DIS Application Protocols (protocol version 7).
- SISO-REF-010-2025, Reference for Enumerations for Simulation
  Interoperability, version 36.
- IEEE Std 1278.2-2015 for communication-services context; networking remains
  outside the core codec package.

IEEE lists P1278.1 as an active revision project superseding the 2012 edition.
Draft material is not treated as a published interoperability contract. A
future published DIS revision will receive an explicit protocol-version layer.

## Implementation references

The NPS MOVES/Open DIS projects are used as independent, BSD-licensed
cross-checks:

- `open-dis/opendis7-java`
- `open-dis/opendis7-source-generator`
- `open-dis/open-dis-csharp`

The Java source generator reports 72 DIS v7 PDUs and provides machine-readable
layout descriptions. It is an offline reference only: OpenDisNet is a native
C#/.NET design with no Java code, dependency, or runtime requirement. Its
conformance claim is based on its own coverage matrix and tests, not merely the
presence of a corresponding reference class.

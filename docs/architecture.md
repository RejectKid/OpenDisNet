# Architecture

OpenDisNet is an independent .NET design. Other DIS implementations are used as
cross-checks, not as API templates or source ports.

## Public surface

- `IDisPdu` and the DIS v7 PDU classes are the protocol model.
- `DisPduReader` and `DisPduWriter` are the stable datagram API.
- `PduFactory` creates correctly initialized protocol-version-7 PDUs.
- Length, count, and bit-length fields are synchronized by the writer rather
  than requiring callers to maintain duplicate wire metadata.
- Open-ended, system-specific records retain their raw octets so applications
  can support vendor extensions without losing data.

## Binary layer

`DisBinaryReader` and `DisBinaryWriter` use bounds-checked spans and explicit
network byte order. Codecs do not depend on reflection, runtime code generation,
or platform endianness. Parsing validates the common header before dispatch and
never reads beyond the declared PDU boundary.

## Source generation

The repository-owned schema is reviewed input to a C# source generator. It
eliminates repetitive field code; it does not dictate the public design.
Corrections and .NET naming are maintained locally when upstream descriptions
are ambiguous, inaccurate, or shaped around another language. CI verifies that
all generated output is deterministic and that the catalog contains exactly the
72 DIS v7 PDU type identifiers.

## Conformance

Every PDU must pass construction and binary round-trip tests. Variable and
conditional layouts additionally require populated vectors, malformed-input
tests, and an independent implementation or packet-decoder comparison before
the corresponding family is marked semantically conformant.

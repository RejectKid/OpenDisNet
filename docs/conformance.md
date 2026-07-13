# DIS v7 conformance matrix

OpenDisNet distinguishes wire framing from semantic decoding. A checked item
means the PDU has a typed model, parser, writer, known-vector tests, malformed
input tests, and round-trip tests.

## Foundation

- [x] Common 12-byte PDU header and Live Entity 10-byte header
- [x] Big-endian integer and IEEE-754 primitives
- [x] Defensive length and version validation
- [x] Unknown/future PDU preservation
- [x] Public protocol models for all 233 concrete DIS v7 wire classes
- [x] Machine-verified catalog of all 72 standardized PDU model types
- [x] Binary dispatch, parsing, and serialization for PDU types 1-72
- [x] Default construction and byte-identical round trip for PDU types 1-72
- [x] Automatic synchronization of list, octet, and bit-length fields
- [x] Deterministically populated round trips for every PDU type (1-72)
- [x] 70 independent default reference vectors and 44 compatible populated vectors
- [ ] Independent populated vectors for every variable-layout PDU
- [x] Truncation-at-every-boundary coverage for every PDU family
- [x] SISO-REF-010-2025 v36 typed enumerations and structured bitfields
- [x] Lossless round trip of unknown enumeration values and reserved bitfield bits

## PDU families

- [x] 0.3 Entity Information/Interaction
- [x] 0.3 Warfare
- [x] 0.4 Logistics
- [x] 0.4 Simulation Management
- [x] 0.5 Distributed Emission Regeneration
- [x] 0.5 Radio Communications
- [x] 0.6 Entity Management
- [x] 0.6 Minefield
- [x] 0.7 Synthetic Environment
- [x] 0.7 Simulation Management with Reliability
- [x] 0.8 Live Entity
- [x] 0.8 Information Operations

Family coverage is implemented and exercised entirely in C#/.NET. Frozen bytes
from an independent implementation are test inputs only; they are not product
code or a runtime/build dependency. Two default vectors and 28 aggressively
populated vectors expose documented defects in that reference generator and are
retained as differential evidence rather than copied into OpenDisNet behavior.

This file is a release gate. Version 1.0 will not be labeled complete until all
applicable entries are checked and independently audited.

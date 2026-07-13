# DIS v7 conformance matrix

OpenDisNet distinguishes wire framing from semantic decoding. A checked item
means the PDU has a typed model, parser, writer, known-vector tests, malformed
input tests, and round-trip tests.

## Foundation

- [x] Common 12-byte PDU header
- [x] Big-endian integer and IEEE-754 primitives
- [x] Defensive length and version validation
- [x] Unknown/future PDU preservation
- [x] Public protocol models for all 253 reviewed DIS v7 schema classes
- [x] Machine-verified catalog of all 72 standardized PDU model types
- [x] Binary dispatch, parsing, and serialization for PDU types 1-72
- [x] Default construction and byte-identical round trip for PDU types 1-72
- [x] Automatic synchronization of list, octet, and bit-length fields
- [x] Populated Signal, Transmitter, Intercom Control, and Minefield Data cases
- [ ] Independent populated vectors for every variable-layout PDU
- [ ] Truncation-at-every-boundary and mutation coverage for every PDU family
- [ ] SISO-REF-010-2025 v36 generated enumerations

## PDU families

- [ ] Entity Information/Interaction (Entity State implemented)
- [ ] Warfare (Fire and Detonation implemented)
- [ ] Logistics
- [ ] Simulation Management
- [ ] Distributed Emission Regeneration
- [ ] Radio Communications (populated Signal, Transmitter, and Intercom Control exercised)
- [ ] Entity Management
- [ ] Minefield (conditional Minefield Data fields exercised)
- [ ] Synthetic Environment
- [ ] Simulation Management with Reliability
- [ ] Live Entity
- [ ] Information Operations

This file is a release gate. Version 1.0 will not be labeled complete until all
applicable entries are checked and independently audited.

# DIS v7 conformance matrix

OpenDisNet distinguishes wire framing from semantic decoding. A checked item
means the PDU has a typed model, parser, writer, known-vector tests, malformed
input tests, and round-trip tests.

## Foundation

- [x] Common 12-byte PDU header
- [x] Big-endian integer and IEEE-754 primitives
- [x] Defensive length and version validation
- [x] Unknown/future PDU preservation
- [ ] Typed DIS v7 PDU suite
- [ ] SISO-REF-010-2025 v36 generated enumerations

## PDU families

- [ ] Entity Information/Interaction
- [ ] Warfare
- [ ] Logistics
- [ ] Simulation Management
- [ ] Distributed Emission Regeneration
- [ ] Radio Communications
- [ ] Entity Management
- [ ] Minefield
- [ ] Synthetic Environment
- [ ] Simulation Management with Reliability
- [ ] Live Entity
- [ ] Information Operations

This file is a release gate. Version 1.0 will not be labeled complete until all
applicable entries are checked and independently audited.

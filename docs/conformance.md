# DIS v7 conformance matrix

OpenDisNet distinguishes wire framing from semantic decoding. A checked item
means the PDU has a typed model, parser, writer, known-vector tests, malformed
input tests, and round-trip tests.

## Foundation

- [x] Common 12-byte PDU header
- [x] Big-endian integer and IEEE-754 primitives
- [x] Defensive length and version validation
- [x] Unknown/future PDU preservation
- [x] Generated public low-level models for all 253 DIS v7 schema classes
- [x] Machine-verified catalog of all 72 standardized PDU model types
- [ ] Typed DIS v7 PDU suite (3 of 72 standardized PDU types implemented)
- [ ] SISO-REF-010-2025 v36 generated enumerations

## PDU families

- [ ] Entity Information/Interaction (Entity State implemented)
- [ ] Warfare (Fire and Detonation implemented)
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

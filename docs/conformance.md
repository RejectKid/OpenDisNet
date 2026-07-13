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
- [x] Variable-layout audit: 44 independent populated vectors across all
  families, with 28 documented reference-generator exceptions covered natively
- [x] Truncation-at-every-boundary coverage for every PDU family
- [x] SISO-REF-010-2025 v36 typed enumerations and structured bitfields
- [x] Lossless round trip of unknown enumeration values and reserved bitfield bits

## Historical family delivery milestones

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

## Historical 0.9 release-readiness milestone

- [x] Frozen, compiler-enforced public C# API baseline
- [x] NuGet package compatibility validation against 0.8.0
- [x] Packed-package consumer validation on .NET 9 and .NET 10
- [x] Prerelease-aware GitHub and NuGet publishing workflow
- [x] External RC validation checklist and structured feedback form
- [x] External RC feedback channel reviewed; no high-impact finding remains open

## Completed 1.0 release gates

- [x] SHA-256-pinned conformance audit manifest and published audit report
- [x] Every PDU type and protocol family accounted for exactly once
- [x] Hostile-input random and mutation regression suite
- [x] Binary/package compatibility baseline updated to 0.9.0
- [x] Low-or-higher NuGet vulnerability audit enforced for all dependencies
- [x] Pull-request dependency review and scheduled CodeQL analysis
- [x] Release tags restricted to commits on `main`
- [x] SHA-256 package checksums and GitHub build-provenance attestations

Family coverage is implemented and exercised entirely in C#/.NET. Frozen bytes
from an independent implementation are test inputs only; they are not product
code or a runtime/build dependency. Two default vectors and 28 aggressively
populated vectors expose documented defects in that reference generator and are
retained as differential evidence rather than copied into OpenDisNet behavior.

This file records the release gates completed for version 1.0. Future releases
must retain the applicable checks and document any changed conformance scope.

The completed scope, evidence, limitations, and differential exceptions are in
the [1.0 conformance audit](conformance-audit-v1.0.md). The documentation-only
schema corrections and test-harness cleanup in 1.0.1 are recorded in the
[1.0.1 maintenance note](conformance-maintenance-v1.0.1.md).

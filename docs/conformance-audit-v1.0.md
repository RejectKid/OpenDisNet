# OpenDisNet 1.0 conformance audit

## Result

The OpenDisNet project audit found the 1.0 candidate internally consistent with
its declared IEEE 1278.1-2012 (DIS v7) and SISO-REF-010-2025 v36 scope. The
machine-readable audit manifest pins every schema, enumeration catalog,
independent vector corpus, family/type mapping, and the frozen public API by
SHA-256. CI fails if an audited input changes without an explicit audit update.

This is a project-maintained engineering audit. It is not IEEE or SISO
certification, government approval, or a substitute for system-level
interoperability testing in a user's own environment.

## Audited scope

| Area | Evidence | Result |
|---|---|---|
| Wire model | 13 pinned DIS schema inputs; generator freshness check | 233 concrete wire classes |
| PDU dispatch | Manifest maps every standard identifier exactly once | 72 PDU types in 12 families |
| Native populated coverage | Deterministic non-default construction and byte-identical round trip | 72 of 72 PDU types |
| Independent default corpus | Frozen reference bytes | 70 exact round trips; 2 explicit differential cases |
| Independent populated corpus | Frozen non-default reference bytes | 44 exact round trips spanning all families |
| Malformed input | Truncation at every byte boundary | Every PDU type and family |
| Hostile input | Fixed-seed random corpus and byte mutation | 10,000 datagrams plus three mutations per byte of every populated PDU |
| Enumeration data | Pinned SISO v36 catalog | Typed values plus lossless unknown/reserved values |
| API compatibility | Compiler API file and NuGet package validation | Frozen surface; binary baseline 0.9.0 |

The authoritative identities and family/type inventory are in
`tests/OpenDisNet.Tests/Conformance/Audit/v1.0.json`. Tests recompute every hash
and compare the manifest with the factory's wire identity.

## Differential exceptions

The independent Open-DIS reference is test-only and is not a product dependency.
Its default Point Object State and Areal Object State encodings write a 16-bit
Modifications field although the reference layout XML declares 8 bits. Those two
inputs are retained and required to fail explicitly.

Twenty-eight aggressively populated reference vectors expose inconsistent
length or padding output in that reference generator. They are recorded as
differential exceptions rather than used to make OpenDisNet reproduce malformed
bytes. The affected OpenDisNet types remain covered by native populated vectors,
full boundary truncation, hostile-input mutation, schema generation checks, and
default independent vectors. Forty-four compatible populated reference vectors
cover all 12 protocol families.

## Release decision

Within the scope above, no unresolved high-impact wire-correctness, data-loss,
API-compatibility, or parser-safety defect is known. Future claims must update
the manifest and this audit whenever a pinned input, public API, or supported
standard changes.

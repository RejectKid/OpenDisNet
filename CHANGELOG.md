# Changelog

All notable changes are documented here. This project follows Semantic
Versioning starting with 1.0 and uses prerelease versions when conformance is
incomplete.

## 1.0.2 - Unreleased

- Ensured NuGet package, assembly, file, and informational versions agree for
  release and CI builds, with package-level validation for both target frameworks.
- Refreshed the test platform and GitHub Actions dependencies and removed the
  unused code-coverage collector.
- Expanded NuGet metadata and search terms for Distributed Interactive
  Simulation, IEEE 1278.1, DIS v7, SISO, PDU parsing, and binary serialization.
- Added a package icon, explicit project/repository links, release-notes link,
  and clearer package title and description.
- Added a coordinated GitHub social preview and expanded repository discovery
  topics.

## 1.0.1 - 2026-07-13

- Updated local package defaults and the binary-compatibility baseline for the
  stable 1.x line.
- Replaced completed prerelease language with durable stable-release guidance.
- Corrected public XML documentation inherited from the generator schemas.
- Removed the unused generated C# reference project while retaining the compact,
  independently produced conformance-vector corpus.

## 1.0.0 - 2026-07-13

- Added the 1.0 conformance audit manifest and report, pinning DIS schemas, SISO
  data, independent vector corpora, family mappings, and the public API by
  SHA-256.
- Added hostile-input security tests covering 10,000 deterministic random
  datagrams and three byte mutations across every populated PDU encoding.
- Updated package compatibility validation to the published 0.9.0 baseline and
  enforced low-or-higher transitive NuGet vulnerability auditing.
- Added pull-request dependency review, main-branch tag verification, package
  checksums, and GitHub build-provenance attestations.

## 0.9.0 - 2026-07-13

- Froze the complete public C# surface with compiler-enforced API baselines and
  NuGet package compatibility validation against OpenDisNet 0.8.0.
- Added an external-style smoke consumer that installs the packed artifact and
  exercises all 72 PDU factory/codec paths on .NET 9 and .NET 10.
- Added prerelease-aware publishing, an external 0.9 RC test checklist, and a
  structured GitHub feedback form.
- Corrected the `RadioId` construction example discovered by the package smoke
  consumer.

## 0.8.0 - 2026-07-13

- Added deterministic populated conformance cases for all 72 DIS v7 PDU types,
  independent byte vectors, and truncation checks at every byte boundary across
  all 12 protocol families planned for versions 0.3 through 0.8.
- Corrected the 10-byte Live Entity header layout, offset-aware 64-bit padding,
  per-field enumeration/bitfield widths, and synchronization of variable record
  lengths and counts.
- Added conditional IFF information layers and polymorphic Information
  Operations effect/communications records to the native C# codec.

## 0.2.0 - 2026-07-13

- Added strongly typed SISO-REF-010-2025 v36 enumerations for every DIS v7
  schema reference, with .NET-style public names.
- Added structured bitfield value types with validated accessors, immutable
  mutation helpers, and preservation of unknown or reserved bits.
- Added a typed Signal encoding scheme API for encoding class, audio type, and
  tactical-data-link message count.
- Added deterministic import of the official SISO v36 machine-readable data and
  lossless unknown-value compatibility tests.
- Made descriptive PDU names such as `AcknowledgeReliablePdu` canonical and
  removed 20 empty acronym-based alias shells from the public model surface.

## 0.1.1 - 2026-07-13

- Replaced hand-authored Signal PDU payload bytes in documentation with
  realistic application-produced audio examples.

## 0.1.0 - 2026-07-13

- Added solution foundation, DIS v7 framing, binary primitives, and defensive
  unknown-PDU parsing.
- Added typed Entity State, Fire, and Detonation PDU parsing and serialization.
- Added cross-platform CI, CodeQL, Dependabot, OIDC NuGet publishing, and a UDP
  packet-inspector sample.
- Added deterministic schema validation and generated low-level models for all
  253 DIS v7 classes, including all 72 standardized PDU model types.

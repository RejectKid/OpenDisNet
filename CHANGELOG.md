# Changelog

All notable changes are documented here. This project follows Semantic
Versioning after 1.0 and uses prerelease versions while conformance is incomplete.

## Unreleased

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
- Added solution foundation, DIS v7 framing, binary primitives, and defensive
  unknown-PDU parsing.
- Added typed Entity State, Fire, and Detonation PDU parsing and serialization.
- Added cross-platform CI, CodeQL, Dependabot, OIDC NuGet publishing, and a UDP
  packet-inspector sample.
- Added deterministic schema validation and generated low-level models for all
  253 DIS v7 classes, including all 72 standardized PDU model types.

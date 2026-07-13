# OpenDisNet 1.0.1 conformance maintenance

Version 1.0.1 does not change the supported DIS wire model, SISO enumeration
baseline, public API, or conformance-vector corpus audited for version 1.0.

The maintenance manifest `tests/OpenDisNet.Tests/Conformance/Audit/v1.0.1.json`
retains the complete 1.0 inventory and updates two schema hashes solely because
their human-readable comments were corrected. Generated public XML documentation
changed, but no field name, type, width, ordering, condition, padding, factory
mapping, parser behavior, or serialized byte changed.

The test-only generated C# reference project and its single Fire PDU consumer
were removed. The frozen independent corpus remains: 70 compatible default
vectors and 44 compatible populated vectors span all 12 protocol families, with
documented differential exceptions retained. Native populated, truncation, and
hostile-input coverage for all 72 PDU types is unchanged.

The original `v1.0.json` manifest and
[`1.0 audit report`](conformance-audit-v1.0.md) remain unchanged as historical
release evidence.

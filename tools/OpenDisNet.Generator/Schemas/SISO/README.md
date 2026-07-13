# SISO wire metadata

`dis7-referenced-types.json` identifies the SISO types used by the DIS v7 layout,
including the composite Signal encoding fields. `referenced-types-v36.json` is
the compact, deterministic catalog generated from the official
SISO-REF-010-2025 v36 machine-readable XML product data.

“Reprinted with permission from SISO Inc.”

To reproduce an import, run the generator with
`--import-siso-v36 <official-archive-or-xml>`. Passing `-` reads the XML from
standard input. The importer verifies the v36 title, every UID, and every wire
width before replacing the checked-in catalog.

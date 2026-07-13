# Architecture

1. `DisBinaryReader` and `DisBinaryWriter` perform checked big-endian access.
2. Record codecs represent reusable IEEE 1278.1 data structures.
3. Typed PDU codecs compose records and validate PDU-local counts and lengths.
4. `DisPduReader` and `DisPduWriter` provide framing, dispatch, and the stable API.

The remaining DIS v7 models will be generated from reviewed machine-readable
layouts derived from the NPS MOVES source-generator XML. Generated output must
be deterministic, carry provenance, and have binary-vector and truncation tests.

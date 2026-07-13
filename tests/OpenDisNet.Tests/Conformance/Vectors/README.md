# Independent DIS v7 vectors

These are test-only interoperability fixtures. The OpenDisNet library and
NuGet package contain no Java code, Java dependency, Java runtime requirement,
or Java-facing API. Open-DIS Java was used only as an offline independent source
of wire bytes so the native C# codec is not tested solely against itself.

`opendis7-java-populated.json` was marshalled by the NPS MOVES
`open-dis/opendis7-java` implementation at commit
`9493e02f69e3473d7887b00c9b72aa5fbc56d155`.

The default set covers all 72 standardized PDU classes. Signal data is
normalized to an empty array when its declared bit length is zero. The Point
Object State and Areal Object State vectors are retained as explicit
differential cases: the Java generator writes their Modifications fields as 16
bits, while its own DIS layout XML declares those fields as 8 bits. The other
70 default vectors must decode and re-encode byte-identically.

The populated set assigns deterministic non-zero primitive, enumeration,
record, array, and list values where the Java wire model permits them. These
octets are independent differential inputs and are not generated or rewritten
by OpenDisNet.

The vector provenance is intentionally pinned so a future reference-library
change cannot silently change the conformance baseline.

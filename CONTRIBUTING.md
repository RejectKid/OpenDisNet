# Contributing

Contributions should include specification-section provenance, known binary
vectors, round-trip tests, and malformed-input tests. Run `dotnet test
--configuration Release` before opening a pull request. Do not submit IEEE
specification text or non-public operational packet captures.

The 1.x public API follows semantic versioning. Additive API changes must update
`src/OpenDisNet/PublicAPI.Unshipped.txt`, include tests, and describe the
consumer benefit in the changelog. Removals or incompatible signature changes
require explicit breaking-change review and belong in the next major release.

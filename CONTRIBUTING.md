# Contributing

Contributions should include specification-section provenance, known binary
vectors, round-trip tests, and malformed-input tests. Run `dotnet test
--configuration Release` before opening a pull request. Do not submit IEEE
specification text or non-public operational packet captures.

The public API is frozen during the 0.9 release-candidate cycle. Additive API
changes must update `src/OpenDisNet/PublicAPI.Unshipped.txt`, include tests, and
describe the consumer benefit in the changelog. Removals or signature changes
require explicit breaking-change review and a new release candidate.

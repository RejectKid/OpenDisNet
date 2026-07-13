# Security policy

## Supported versions

The latest 1.x release receives security fixes. A security fix may be backported
when a supported application cannot reasonably upgrade, at the maintainers'
discretion.

## Reporting

Please use GitHub private vulnerability reporting. Do not include sensitive or
classified packet captures in a report.

## Parser guarantees

OpenDisNet treats all datagrams as untrusted, validates declared lengths before
dispatch, bounds-checks every primitive access, and limits allocation driven by
wire-provided counts. These guarantees do not make decoded simulation content
trustworthy.

Applications should set `DisParseOptions.MaximumPduLength` to the smallest value
their traffic requires and apply network-level rate and source controls. A valid
but high-rate stream can still consume CPU, and semantic simulation values are
not authorization decisions.

## Release security gates

- Low-or-higher vulnerabilities in direct or transitive NuGet dependencies fail
  restore.
- Pull requests receive dependency review, cross-platform tests, parser hostile-
  input regression tests, formatting checks, and CodeQL analysis.
- Weekly CodeQL analysis covers changes outside pull-request activity.
- Release packages include SHA-256 checksums and GitHub build-provenance
  attestations and are published to NuGet through short-lived OIDC credentials.

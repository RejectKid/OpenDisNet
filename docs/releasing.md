# Releasing

Releases are immutable and tag-driven. The `release.yml` workflow tests, packs,
publishes to NuGet.org, and creates a GitHub release for tags such as `v0.2.0`.
GitHub-generated notes are categorized using `.github/release.yml`, and package
plus symbol artifacts are attached to the release shown on the repository page.

Prerelease tags use SemVer identifiers such as `v0.9.0-rc.1`. The workflow
derives the package version from the tag and marks the GitHub release as a
prerelease automatically. Before publishing any tag, the workflow validates the
public API, compares the package with the 0.9.0 compatibility baseline, and runs
an external-style consumer against the packed artifact on .NET 9 and .NET 10.

The RC testing contract and feedback process are documented in
[`release-candidate.md`](release-candidate.md). Promote an RC to a stable tag
only after its exit criteria are satisfied; published NuGet versions and GitHub
releases are never rewritten.

## 1.0 security gates

A release tag must identify a commit contained in `main`. The release workflow
then repeats locked restore with low-or-higher transitive NuGet vulnerability
auditing, tests, package compatibility validation, and NuGet-only consumer runs.
It creates `SHA256SUMS` and GitHub build-provenance attestations before trusted
publishing. The checksum file, package, and symbol package are attached to the
immutable GitHub release.

Verify a downloaded package with GitHub CLI:

```shell
gh attestation verify OpenDisNet.1.0.0.nupkg --repo RejectKid/OpenDisNet
```

The 1.0 tag is permitted only when the
[conformance audit](conformance-audit-v1.0.md) and all checks in the
[conformance matrix](conformance.md) are complete.

## One-time NuGet.org setup

1. Reserve or publish the `OpenDisNet` package ID under the intended NuGet.org owner.
2. In NuGet.org **Trusted Publishing**, create a GitHub policy for owner
   `RejectKid`, repository `OpenDisNet`, workflow `release.yml`, and environment
   `release`.
3. Add the NuGet.org profile name as the GitHub Actions secret `NUGET_USER`.
4. Add required reviewers to the GitHub `release` environment if desired.

The workflow uses OIDC to request an hour-long NuGet key. No long-lived NuGet
API key is stored in GitHub.

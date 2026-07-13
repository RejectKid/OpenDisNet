# Releasing

Releases are immutable and tag-driven. The `release.yml` workflow tests, packs,
publishes to NuGet.org, and creates a GitHub release for tags such as `v0.2.0`.
GitHub-generated notes are categorized using `.github/release.yml`, and package
plus symbol artifacts are attached to the release shown on the repository page.

## One-time NuGet.org setup

1. Reserve or publish the `OpenDisNet` package ID under the intended NuGet.org owner.
2. In NuGet.org **Trusted Publishing**, create a GitHub policy for owner
   `RejectKid`, repository `OpenDisNet`, workflow `release.yml`, and environment
   `release`.
3. Add the NuGet.org profile name as the GitHub Actions secret `NUGET_USER`.
4. Add required reviewers to the GitHub `release` environment if desired.

The workflow uses OIDC to request an hour-long NuGet key. No long-lived NuGet
API key is stored in GitHub.

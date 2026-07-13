# 0.9 external release candidate

Version 0.9 is the public API freeze and external validation stage before 1.0.
The current C# surface is recorded in `PublicAPI.Shipped.txt`; builds reject an
undocumented addition or removal, and package validation compares every new
artifact with the published 0.8.0 package.

## Install an RC

Release candidates use SemVer tags such as `v0.9.0-rc.1`. After a candidate is
published, install that exact version so test results remain reproducible:

```shell
dotnet add package OpenDisNet --version 0.9.0-rc.1
```

GitHub and NuGet identify RC builds as prereleases. Do not use an RC in a
production exercise unless your own release policy permits prerelease packages.

## External validation checklist

Test the workflows that resemble your application rather than only constructing
empty PDUs:

1. Deserialize representative, non-sensitive DIS v7 datagrams from each family
   your application consumes.
2. Inspect the typed properties your application needs and reserialize the PDU.
3. Construct and transmit representative PDUs using ordinary object initializers.
4. Confirm unknown enumeration values, reserved bits, and vendor-defined bodies
   survive a decode/encode round trip when applicable.
5. Exercise caller-owned buffers or sustained packet rates if allocation and
   throughput matter to your application.
6. Build with nullable analysis and warnings enabled to expose API friction.

Never attach controlled, private, or operational packet captures. Reduce a
problem to synthetic bytes or property values before reporting it.

## Report results

Use the repository's **Release candidate feedback** issue form. Include the
exact package version, target framework, operating system, PDU families tested,
and whether the problem concerns API usability, wire interoperability,
performance, or documentation.

## 1.0 exit criteria

- Public API analyzer and 0.8.0 package-compatibility validation remain clean.
- The packed-package consumer passes on .NET 9 and .NET 10.
- No unresolved high-impact wire-correctness or data-loss defect remains.
- External testing covers real application workflows without relying on
  sensitive captures.
- Any intentional API change after the freeze is documented, reviewed as a
  breaking-change candidate, and followed by another RC.

# Security policy

## Supported versions

Only the latest published OpenDisNet release receives security fixes while the
project remains pre-1.0.

## Reporting

Please use GitHub private vulnerability reporting. Do not include sensitive or
classified packet captures in a report.

## Parser guarantees

OpenDisNet treats all datagrams as untrusted, validates declared lengths before
dispatch, bounds-checks every primitive access, and limits allocation driven by
wire-provided counts. These guarantees do not make decoded simulation content
trustworthy.

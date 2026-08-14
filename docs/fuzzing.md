# Parser fuzzing

`OpenDisNet.Fuzz` is a SharpFuzz 2.3 harness for the public header, datagram,
framed-span, and segmented-sequence parsing paths. Successful parses are also
semantically validated, serialized, and parsed again. Unexpected exceptions or
differences between contiguous and segmented framing are treated as crashes.

Run the bounded deterministic smoke corpus used by CI:

```shell
dotnet run --project tests/OpenDisNet.Fuzz -c Release -- --smoke
```

Create a starting corpus containing all 72 standardized PDU types plus malformed
and non-v7 inputs:

```shell
dotnet run --project tests/OpenDisNet.Fuzz -c Release -- --write-corpus artifacts/fuzz-corpus
```

For a sustained coverage-guided campaign, install AFL++ and the
`SharpFuzz.CommandLine` tool, instrument the Release build of
`OpenDisNet.Fuzz.dll`, and run AFL++ against the generated corpus. Follow the
[SharpFuzz usage instructions](https://github.com/Metalnem/SharpFuzz#usage) for
the current instrumentation and runner commands. Fuzz findings and generated
corpora belong under `artifacts/` and must not be committed without minimizing
them and adding a focused regression test.

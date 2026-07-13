# Public API design

OpenDisNet is designed for application developers who need to send or receive
DIS packets, not for users of a particular source generator.

## Primary workflow

```csharp
SignalPdu signal = DisSerializer.Deserialize<SignalPdu>(datagram);
Console.WriteLine(signal.Radio.Entity);

byte[] response = DisSerializer.Serialize(signal);
```

The same serializer accepts caller-owned `Span<byte>` storage for allocation-
sensitive applications. `TryDeserialize` returns a structured error for
untrusted network input.

## Design rules

1. PDU class names and properties use normal .NET naming.
2. Constructors provide valid defaults; object initializers are sufficient for
   ordinary use.
3. The serializer owns protocol version, PDU type, protocol family, PDU length,
   list counts, derived lengths, record lengths, and required padding. APIs such
   as `SignalPdu.SetData` safely capture meaningful lengths that are part of the
   user's data.
4. Collections use `List<T>` or arrays according to whether records or raw
   octets are represented. Callers never update a parallel count property.
5. Known records are strongly typed. Standard-defined open or system-specific
   payloads use an explicit raw-octet value that round-trips unchanged.
6. SISO-defined values use enums and structured bitfield value types. Unknown
   enumeration values and reserved bits always round-trip losslessly.
7. Unknown PDU types and vendor data are preserved when their framing is valid.
8. Parsing is bounded, big-endian, deterministic, and independent of reflection.
9. Public APIs do not expose generator metadata, source XML terminology, or
   classes copied from another DIS implementation.

## Compatibility

The 0.9 release-candidate line freezes the complete public C# surface before
1.0. `PublicAPI.Shipped.txt` is the reviewable contract. Compiler analyzers
reject an unrecorded public addition or removal, and NuGet package validation
compares new artifacts with version 0.8.0 for binary compatibility.

New API belongs in `PublicAPI.Unshipped.txt` and requires tests plus a changelog
entry. Removing or changing frozen API requires explicit breaking-change review
and another release candidate. After 1.0, public names and wire behavior follow
semantic versioning. Internal codec generation may change without becoming part
of the supported API.

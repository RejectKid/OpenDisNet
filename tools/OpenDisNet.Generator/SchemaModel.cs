using System.Collections.Immutable;

namespace OpenDisNet.Generator;

internal sealed record DisSchema(
    ImmutableArray<ClassDefinition> Classes,
    ImmutableArray<PduDefinition> Pdus,
    ImmutableArray<string> SourceFiles,
    ImmutableArray<SisoTypeDefinition> SisoTypes);

internal sealed record SisoTypeDefinition(
    string Name,
    int Uid,
    int Bits,
    string Kind,
    ImmutableArray<SisoMemberDefinition> Members);

internal sealed record SisoMemberDefinition(
    string Name,
    ulong? Value,
    int? BitPosition,
    int? Length,
    string? Description,
    int? CrossReference,
    bool Deprecated);

internal sealed record ClassDefinition(
    string Name,
    string BaseName,
    bool IsAbstract,
    string? Comment,
    ImmutableArray<FieldDefinition> Fields,
    string SourceFile);

internal sealed record PduDefinition(
    byte Type,
    string Name,
    string ProtocolFamilyExpression,
    string SourceFile);

internal sealed record FieldDefinition(
    string Name,
    FieldKind Kind,
    string TypeName,
    string? CountFieldName,
    int? FixedLength,
    int? BitSize,
    bool IsDynamicLength,
    bool IsHidden,
    string? Comment,
    FieldKind? ElementKind = null);

internal enum FieldKind
{
    Primitive,
    ClassReference,
    Enumeration,
    BitField,
    ObjectList,
    PrimitiveList,
    PaddingBoundary,
    StaticIvar,
}

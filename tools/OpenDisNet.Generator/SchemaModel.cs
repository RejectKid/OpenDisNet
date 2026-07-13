using System.Collections.Immutable;

namespace OpenDisNet.Generator;

internal sealed record DisSchema(
    ImmutableArray<ClassDefinition> Classes,
    ImmutableArray<PduDefinition> Pdus,
    ImmutableArray<string> SourceFiles);

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
    string? Comment);

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

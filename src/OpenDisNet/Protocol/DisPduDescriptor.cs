namespace OpenDisNet.Protocol;

/// <summary>Identifies one standardized DIS v7 PDU wire type.</summary>
internal readonly record struct DisPduDescriptor(byte Type, string ModelName, string SchemaSource);

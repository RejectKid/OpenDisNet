using OpenDisNet.Enumerations;

namespace OpenDisNet.Pdus;

/// <summary>
/// The DIS Signal encoding scheme: a two-bit encoding class followed by a
/// fourteen-bit audio encoding type or tactical-data-link message count.
/// </summary>
public readonly record struct SignalEncodingScheme(ushort Value)
{
    private const ushort DetailMask = 0x3FFF;

    /// <summary>The two most significant bits of the encoding scheme.</summary>
    public SignalEncodingClass Class => (SignalEncodingClass)(Value >> 14);

    /// <summary>The fourteen least significant bits, retained without interpretation.</summary>
    public ushort TypeOrMessageCount => (ushort)(Value & DetailMask);

    /// <summary>The audio encoding type. This is meaningful when <see cref="Class"/> is encoded audio.</summary>
    public SignalEncodingType AudioType => (SignalEncodingType)TypeOrMessageCount;

    /// <summary>Creates an encoded-audio scheme from a SISO v36 encoding type.</summary>
    public static SignalEncodingScheme EncodedAudio(SignalEncodingType type) =>
        new(CheckedDetail((ushort)type));

    /// <summary>Creates a non-audio scheme with its TDL message count or application-defined detail.</summary>
    public static SignalEncodingScheme Data(SignalEncodingClass encodingClass, ushort messageCount = 0)
    {
        if (encodingClass == SignalEncodingClass.EncodedAudio)
            throw new ArgumentException("Use EncodedAudio for the encoded-audio class.", nameof(encodingClass));
        return new((ushort)(((ushort)encodingClass << 14) | CheckedDetail(messageCount)));
    }

    public SignalEncodingScheme WithClass(SignalEncodingClass encodingClass) =>
        new((ushort)(((ushort)encodingClass << 14) | TypeOrMessageCount));

    public SignalEncodingScheme WithTypeOrMessageCount(ushort value) =>
        new((ushort)((Value & ~DetailMask) | CheckedDetail(value)));

    public static implicit operator SignalEncodingScheme(ushort value) => new(value);
    public static implicit operator ushort(SignalEncodingScheme value) => value.Value;

    public override string ToString() => $"{Class}: {TypeOrMessageCount} (0x{Value:X4})";

    private static ushort CheckedDetail(ushort value) =>
        value <= DetailMask ? value : throw new ArgumentOutOfRangeException(nameof(value), "The encoding detail is limited to 14 bits.");
}

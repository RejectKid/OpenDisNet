namespace OpenDisNet;

public enum DisParseErrorCode
{
    None,
    TruncatedHeader,
    InvalidLength,
    UnsupportedProtocolVersion,
    TruncatedPdu,
    TrailingData,
    InvalidField,
}

public readonly record struct DisParseError(DisParseErrorCode Code, string Message, int Offset = 0);

namespace OpenDisNet.Protocol;

/// <summary>DIS protocol versions assigned by IEEE 1278.</summary>
public enum DisProtocolVersion : byte
{
    Other = 0,
    Ieee1278_1993 = 1,
    DisVersion2 = 2,
    DisVersion3 = 3,
    Ieee1278_1_1995 = 5,
    Ieee1278_1A_1998 = 6,
    Ieee1278_1_2012 = 7,
}

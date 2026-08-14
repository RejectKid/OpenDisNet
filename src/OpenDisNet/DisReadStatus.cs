namespace OpenDisNet;

/// <summary>Describes the outcome of reading one framed DIS PDU from a buffer.</summary>
public enum DisReadStatus
{
    /// <summary>One complete PDU was decoded.</summary>
    Done,

    /// <summary>The buffer ended before the complete PDU was available.</summary>
    NeedMoreData,

    /// <summary>The buffer contains an invalid DIS header or PDU.</summary>
    InvalidData,
}

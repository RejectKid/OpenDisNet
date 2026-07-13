using OpenDisNet.Pdus;

namespace OpenDisNet;

/// <summary>Serializes and deserializes Distributed Interactive Simulation PDUs.</summary>
public static class DisSerializer
{
    /// <summary>Deserializes one complete DIS datagram.</summary>
    public static IDisPdu Deserialize(ReadOnlySpan<byte> datagram, DisParseOptions? options = null) =>
        DisPduReader.Parse(datagram, options);

    /// <summary>Attempts to deserialize one complete DIS datagram without throwing for invalid input.</summary>
    public static bool TryDeserialize(
        ReadOnlySpan<byte> datagram,
        out IDisPdu? pdu,
        out DisParseError error,
        DisParseOptions? options = null) =>
        DisPduReader.TryParse(datagram, out pdu, out error, options);

    /// <summary>Returns the number of octets required to serialize a PDU.</summary>
    public static int GetSerializedLength(IDisPdu pdu)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        return DisPduWriter.GetEncodedLength(pdu);
    }

    /// <summary>Serializes a PDU into a newly allocated datagram.</summary>
    public static byte[] Serialize(IDisPdu pdu)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        return DisPduWriter.Write(pdu);
    }

    /// <summary>Serializes a PDU into caller-owned storage and returns the octets written.</summary>
    public static int Serialize(IDisPdu pdu, Span<byte> destination)
    {
        ArgumentNullException.ThrowIfNull(pdu);
        return DisPduWriter.Write(pdu, destination);
    }
}

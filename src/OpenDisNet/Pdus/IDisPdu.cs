using OpenDisNet.Protocol;

namespace OpenDisNet.Pdus;

public interface IDisPdu
{
    DisHeader Header { get; }
}

using System.Net;
using System.Net.Sockets;
using OpenDisNet;
using OpenDisNet.Pdus;

int port = args.Length > 0 && int.TryParse(args[0], out int parsedPort) ? parsedPort : 3000;
using var udp = new UdpClient(new IPEndPoint(IPAddress.Any, port));
Console.WriteLine($"Listening for DIS v7 datagrams on UDP {port}. Press Ctrl+C to stop.");

while (true)
{
    UdpReceiveResult received = await udp.ReceiveAsync();
    if (DisSerializer.TryDeserialize(received.Buffer, out IDisPdu? pdu, out DisParseError error))
        Console.WriteLine($"{received.RemoteEndPoint} {pdu!.Header.PduType,-34} {pdu.Header.Length,5} bytes");
    else
        Console.Error.WriteLine($"{received.RemoteEndPoint} invalid at byte {error.Offset}: {error.Message}");
}

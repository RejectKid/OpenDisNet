using OpenDisNet;
using OpenDisNet.Enumerations;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;

var signal = new SignalPdu
{
    ExerciseId = 7,
    Timestamp = 0x01020304,
    Radio = new RadioId(new EntityId(1, 2, 3), 4),
    EncodingScheme = SignalEncodingScheme.EncodedAudio(SignalEncodingType.Opus),
    TdlType = SignalTdlType.Other,
    SampleRate = 48_000,
    SampleCount = 1,
};
signal.SetData("external-consumer"u8);

byte[] datagram = DisSerializer.Serialize(signal);
SignalPdu decoded = DisSerializer.Deserialize<SignalPdu>(datagram);

if (!decoded.Data.AsSpan().SequenceEqual("external-consumer"u8))
    throw new InvalidOperationException("The packed Signal PDU API did not round-trip its payload.");

foreach (PduType type in Enum.GetValues<PduType>().Where(x => (byte)x is >= 1 and <= 72))
{
    Pdu pdu = PduFactory.Create(type, exerciseId: 7);
    byte[] bytes = DisSerializer.Serialize(pdu);
    if (DisSerializer.Deserialize(bytes).Header.PduType != type)
        throw new InvalidOperationException($"The packed PDU factory failed for {type}.");
}

Console.WriteLine($"OpenDisNet package {typeof(Pdu).Assembly.GetName().Version} passed the external consumer smoke test.");

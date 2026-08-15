using System.Buffers;
using OpenDisNet;
using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using OpenDisNet.Validation;

internal static class ParserFuzzTarget
{
    private static readonly DisParseOptions PermissiveOptions = new()
    {
        RequireVersion7 = false,
        MaximumPduLength = ushort.MaxValue,
    };

    public static void Run(ReadOnlySpan<byte> input)
    {
        DisSerializer.TryReadHeader(input, out _, out _);
        DisSerializer.TryDeserialize(input, out _, out _, PermissiveOptions);

        DisReadStatus status = DisSerializer.TryRead(input, out IDisPdu? pdu, out int consumed, out _, PermissiveOptions);
        if (status != DisReadStatus.Done)
            return;

        if (pdu is null || consumed <= 0 || consumed > input.Length)
            throw new InvalidOperationException("A successful framed read returned an invalid result.");

        _ = DisValidator.Validate(pdu);
        byte[] serialized = DisSerializer.Serialize(pdu);
        if (DisSerializer.TryRead(serialized, out _, out int roundTripConsumed, out _, PermissiveOptions) != DisReadStatus.Done ||
            roundTripConsumed != serialized.Length)
        {
            throw new InvalidOperationException("A parsed PDU did not survive serialization and framed parsing.");
        }

        var segmented = CreateSegmentedSequence(input[..consumed]);
        if (DisSerializer.TryRead(segmented, out _, out int segmentedConsumed, out _, PermissiveOptions) != DisReadStatus.Done ||
            segmentedConsumed != consumed)
        {
            throw new InvalidOperationException("Contiguous and segmented parsing produced different framing results.");
        }
    }

    public static void RunSmokeCorpus()
    {
        IReadOnlyList<byte[]> seeds = CreateSeeds();
        foreach (byte[] seed in seeds)
        {
            Run(seed);
            for (int length = 0; length < seed.Length; length += Math.Max(1, seed.Length / 8))
                Run(seed.AsSpan(0, length));

            for (int index = 0; index < seed.Length; index += Math.Max(1, seed.Length / 16))
            {
                byte original = seed[index];
                seed[index] ^= 0xFF;
                Run(seed);
                seed[index] = original;
            }
        }

        var random = new Random(1278);
        for (int iteration = 0; iteration < 1_000; iteration++)
        {
            byte[] bytes = new byte[random.Next(0, 2048)];
            random.NextBytes(bytes);
            Run(bytes);
        }
    }

    public static void WriteCorpus(string directory)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(directory);
        Directory.CreateDirectory(directory);
        IReadOnlyList<byte[]> seeds = CreateSeeds();
        for (int index = 0; index < seeds.Count; index++)
            File.WriteAllBytes(Path.Combine(directory, $"pdu-{index:D2}.bin"), seeds[index]);
    }

    private static IReadOnlyList<byte[]> CreateSeeds()
    {
        var seeds = new List<byte[]> { Array.Empty<byte>(), new byte[] { 7, 1, 1 } };
        for (byte pduType = 1; pduType <= 72; pduType++)
            seeds.Add(DisSerializer.Serialize(PduFactory.Create((PduType)pduType, exerciseId: 1)));

        var nonV7Header = new DisHeader((DisProtocolVersion)6, 1, PduType.EntityState, ProtocolFamily.EntityInformationInteraction, 0, 16, 0, 0);
        seeds.Add(DisSerializer.Serialize(new UnknownPdu(nonV7Header, new byte[4])));
        return seeds;
    }

    private static ReadOnlySequence<byte> CreateSegmentedSequence(ReadOnlySpan<byte> input)
    {
        int split = input.Length / 2;
        var first = new BufferSegment(input[..split].ToArray());
        BufferSegment last = first.Append(input[split..].ToArray());
        return new ReadOnlySequence<byte>(first, 0, last, last.Memory.Length);
    }

    private sealed class BufferSegment : ReadOnlySequenceSegment<byte>
    {
        public BufferSegment(ReadOnlyMemory<byte> memory) => Memory = memory;

        public BufferSegment Append(ReadOnlyMemory<byte> memory)
        {
            var segment = new BufferSegment(memory) { RunningIndex = RunningIndex + Memory.Length };
            Next = segment;
            return segment;
        }
    }
}

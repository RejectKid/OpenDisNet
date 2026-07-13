namespace OpenDisNet.Pdus;

internal static partial class PduCodec
{
    private static int CheckedCount(long count, int remaining, string field)
    {
        if (count < 0 || count > 1_000_000 || count > remaining)
            throw new FormatException($"Field '{field}' declares an unsafe element count of {count} with {remaining} bytes remaining.");
        return checked((int)count);
    }

    private static int CheckedCount(ulong count, int remaining, string field) =>
        count > long.MaxValue ? throw new FormatException($"Field '{field}' count is too large.") : CheckedCount((long)count, remaining, field);

    private static int Padding(int offset, int boundary)
    {
        int remainder = offset % boundary;
        return remainder == 0 ? 0 : boundary - remainder;
    }
}

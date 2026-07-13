using OpenDisNet.Pdus;

namespace OpenDisNet.Tests;

public sealed class DisPduReaderTests
{
    [Fact]
    public void RejectsTruncatedHeader()
    {
        Assert.False(DisPduReader.TryParse(new byte[11], out _, out DisParseError error));
        Assert.Equal(DisParseErrorCode.TruncatedHeader, error.Code);
    }

    [Fact]
    public void PreservesUnknownPduBody()
    {
        byte[] bytes = [7, 1, 200, 0, 0, 0, 0, 0, 0, 15, 0, 0, 1, 2, 3];
        Assert.True(DisPduReader.TryParse(bytes, out IDisPdu? parsed, out DisParseError error), error.Message);
        var unknown = Assert.IsType<UnknownPdu>(parsed);
        Assert.Equal(new byte[] { 1, 2, 3 }, unknown.Body.ToArray());
    }
}

using OpenDisNet.Pdus;
using OpenDisNet.Protocol;
using OpenDisNet.Records;

namespace OpenDisNet.Tests.Pdus;

public sealed class WarfarePduTests
{
    [Fact]
    public void FirePduRoundTrips()
    {
        var header = new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 1, PduType.Fire, ProtocolFamily.Warfare, 123, 0, 0, 0);
        var descriptor = new MunitionDescriptor(new EntityType(2, 1, 225, 1, 2, 3, 0), 1000, 2000, 1, 0);
        var expected = new FirePdu(header, new(1, 2, 3), new(1, 2, 4), new(1, 2, 5), new(new(1, 2), 99), 7,
            new(10, 20, 30), descriptor, new(1, 2, 3), 5000);

        byte[] bytes = DisPduWriter.Write(expected);
        var actual = Assert.IsType<FirePdu>(DisPduReader.Parse(bytes));

        Assert.Equal(96, bytes.Length);
        Assert.Equal(expected with { Header = expected.Header with { Length = 96 } }, actual);
    }

    [Fact]
    public void DetonationPduRoundTripsVariableParameters()
    {
        var header = new DisHeader(DisProtocolVersion.Ieee1278_1_2012, 1, PduType.Detonation, ProtocolFamily.Warfare, 0, 0, 0, 0);
        var parameter = new VariableParameter(Enumerable.Range(0, 16).Select(x => (byte)x).ToArray());
        var expected = new DetonationPdu(header, new(1, 1, 1), new(1, 1, 2), new(1, 1, 3), new(new(1, 1), 1),
            new(1, 2, 3), new(4, 5, 6), new(new(2, 1, 225, 1, 0, 0, 0), 0, 0, 1, 0), new(7, 8, 9), 1, [parameter]);

        byte[] bytes = DisPduWriter.Write(expected);
        var actual = Assert.IsType<DetonationPdu>(DisPduReader.Parse(bytes));

        Assert.Equal(120, bytes.Length);
        Assert.Equal(parameter.Data.ToArray(), actual.VariableParameters[0].Data.ToArray());
    }
}

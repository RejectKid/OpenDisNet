namespace OpenDisNet.Pdus;

public partial class EntityId
{
    public EntityId() { }

    public EntityId(ushort siteId, ushort applicationId, ushort entityNumber)
    {
        SiteId = siteId;
        ApplicationId = applicationId;
        EntityNumber = entityNumber;
    }
}

public readonly record struct RadioId(EntityId Entity, ushort Number);

public partial class SignalPdu
{
    /// <summary>The transmitting entity and radio number.</summary>
    public RadioId Radio
    {
        get => new(RadioHeader.RadioReferenceId, RadioHeader.RadioNumber);
        set
        {
            RadioHeader.RadioReferenceId = value.Entity ?? throw new ArgumentNullException(nameof(value));
            RadioHeader.RadioNumber = value.Number;
        }
    }

    /// <summary>Number of samples represented by <see cref="Data"/>.</summary>
    public ushort SampleCount { get => Samples; set => Samples = value; }

    /// <summary>Sets signal bytes and their meaningful bit length. The default uses every bit.</summary>
    public void SetData(ReadOnlySpan<byte> data, int? meaningfulBitLength = null)
    {
        int bits = meaningfulBitLength ?? checked(data.Length * 8);
        if (bits < 0 || bits > data.Length * 8 || bits <= (data.Length - 1) * 8)
            throw new ArgumentOutOfRangeException(nameof(meaningfulBitLength), "Bit length must describe all supplied octets, allowing only unused bits in the final octet.");
        DataBitLength = checked((ushort)bits);
        Data = data.ToArray();
    }
}

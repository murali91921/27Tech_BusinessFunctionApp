namespace Models
{
    public interface IBusinessAddressIT : IBusinessAddress
    {
        string SiglaDellaProvincia { get; set; }
        string CodiceSede { get; set; }
    }
}
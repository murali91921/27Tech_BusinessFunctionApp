namespace Models
{
    public interface IBusinessAddress
    {
        string Address { get; set; }
        IEnumerable<string> AdditionalAddressLines { get; set; }
        string Locality { get; set; }
        string Region { get; set; }
        string PostalCode { get; set; }
        string Country { get; set; }
    }
}
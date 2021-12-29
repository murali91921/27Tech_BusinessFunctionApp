namespace Models
{
    public interface IBusinessHeader
    {
        string id { get; set; }
        string CompanyIdentifier { get; set; }
        string Name { get; set; }
        string PrimaryBusinessCode { get; set; }
    }
}
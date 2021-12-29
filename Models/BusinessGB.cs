namespace Models
{
    public class BusinessGB : IBusiness<LegalFormGB, BusinessCodeTypeGB, IBusinessAddress>
    {
        public LegalFormGB LegalForm { get; set; }
        public BusinessCodeTypeGB BusinessCodeType { get; set; }
        public IDictionary<ExecutionContext, IBusinessAddress> Addresses { get; set; }
        public BusinessStatus Status { get; set; }
        public string CountryCode { get; set; }
        public string VATNumber { get; set; }
        public IEnumerable<string> BusinessCodes { get; set; }
        public DateTimeOffset? OperationalFrom { get; set; }
        public DateTimeOffset? OperationalTo { get; set; }
        public string Address { get; set; }
        public IEnumerable<string> AdditionalAddressLines { get; set; }
        public string Locality { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CompanyNumber { get; set; }
    }
}
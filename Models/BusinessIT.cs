namespace Models
{
    public class BusinessIT : IBusiness<LegalFormIT, BusinessCodeTypeIT, IBusinessAddressIT>
    {
        public LegalFormIT LegalForm { get; set; }
        public BusinessCodeTypeIT BusinessCodeType { get; set; }
        public IDictionary<ExecutionContext, IBusinessAddressIT> Addresses { get; set; }
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
        public string CodiceFiscale { get; set; }
        public string REA { get; set; }
        public string SiglaDellaProvinciaSede { get; set; }
        public string ProvinciaSede { get; set; }
        public string CCIAA { get; set; }
        public string DescrizioneCCIAA { get; set; }
        public string IndirizzoPostaCertificata { get; set; }
    }
}
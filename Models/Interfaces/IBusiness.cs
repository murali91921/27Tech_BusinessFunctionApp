using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface IBusiness : IBusinessAddress
    {
        BusinessStatus Status { get; set; }
        string CountryCode { get; set; }
        string VATNumber { get; set; }
        IEnumerable<string> BusinessCodes { get; set; }
        DateTimeOffset? OperationalFrom { get; set; }
        DateTimeOffset? OperationalTo { get; set; }
    }
}
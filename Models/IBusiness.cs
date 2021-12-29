using Models.Interfaces;
using System.Threading;

namespace Models
{
    public interface IBusiness<LegalFormEnum, BusinessCodeTypeEnum, IBusinessAddressType> : IBusiness
    {
        LegalFormEnum LegalForm { get; set; }
        BusinessCodeTypeEnum BusinessCodeType { get; set; }
        IDictionary<ExecutionContext, IBusinessAddressType> Addresses { get; set; }
    }
}
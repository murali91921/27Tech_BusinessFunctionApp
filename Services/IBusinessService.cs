using Factories;
using Models.Interfaces;

namespace Services
{
    public interface IBusinessService
    {
        IBusiness GetBusiness(string countryCode);
    }
}
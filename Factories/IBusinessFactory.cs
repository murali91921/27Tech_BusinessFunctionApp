using Models.Interfaces;

namespace Factories
{
    public interface IBusinessFactory
    {
        IBusiness GetBusiness(string countryCode);
    }
}
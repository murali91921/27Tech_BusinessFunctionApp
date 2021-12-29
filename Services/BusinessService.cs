using Factories;
using Models.Interfaces;

namespace Services
{
    public class BusinessService : IBusinessService
    {
        public IBusiness GetBusiness(string countryCode)
        {
            IBusinessFactory factory = new BusinessFactory();
            return factory.GetBusiness(countryCode);
        }
    }
}
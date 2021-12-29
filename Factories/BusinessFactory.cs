using Models;
using Models.Interfaces;

namespace Factories
{
    public class BusinessFactory : IBusinessFactory
    {
        IBusiness business;
        public IBusiness GetBusiness(string countryCode)
        {
            if (countryCode.Equals("gb", StringComparison.OrdinalIgnoreCase))
            {
                business = new BusinessGB();
            }
            else if (countryCode.Equals("it", StringComparison.OrdinalIgnoreCase))
            {
                business = new BusinessIT();
            }
            return business;
        }
    }
}
using SustainabilityWithReferences.Dals;
using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Enums;
using SustainabilityWithReferences.Utilities;
using SustainabilityWithReferences.Validators;

namespace SustainabilityWithReferences.Managers
{
    public class CustomerManager
    {
        public void Add(Customer customer, DatabaseTypes databaseTypes)
        {
            Utility.Validate(new CustomerValidator(),customer);
            CustomerDal customerDal = new CustomerDal(databaseTypes);
            customerDal.Add(customer);

        }

        public void AddByOtherBusiness()
        {
             
        }
    }
}

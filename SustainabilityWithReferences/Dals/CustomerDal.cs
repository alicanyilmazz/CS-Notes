using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Dals
{
    public class CustomerDal
    {
        DatabaseTypes _databaseTypes;
        public CustomerDal(DatabaseTypes databaseTypes)
        {
            _databaseTypes = databaseTypes;
        }
        public void Add(Customer customer)
        {
            if (_databaseTypes==DatabaseTypes.Oracle)
            {
                Console.WriteLine(customer.CustomerName+" Customer added to Database with Oracle.");
            }
            else
            {
                Console.WriteLine(customer.CustomerName+" Customer added to Database with Mssql.");
            }
        }

        public bool CustomerExist(Customer customer)
        {
            return true;
        }
    }
}

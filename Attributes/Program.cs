using Attributes.DataAccessLayers;
using Attributes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Age = 21, FirstName = "Alican", LastName = "Yilmaz", Id = 22 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }
}

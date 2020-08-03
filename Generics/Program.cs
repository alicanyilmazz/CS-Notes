using Generics.Entities;
using Generics.GenericMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<int> numbers = utilities.BuildList<int>(1,2,3,4,5,6);
            List<string> cities = utilities.BuildList<string>("Ankara", "İstanbul", "Mersin");
            List<Customer> customers = utilities.BuildList<Customer>(new Customer() { Name = "alican", Surname = "yilmaz" }, new Customer() { Name = "kemal", Surname = "tanca" });
            utilities.WritePrimitiveList(numbers);
            utilities.WriteStringList(cities);
            utilities.WriteCustomerList(customers);
        }
    }
}

using InterfaceImplementationsTwo.DalOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationsTwo.DalOperations.CustomerDalOperations
{
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Data Added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Data Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql Data Updated!");
        }
    }
}

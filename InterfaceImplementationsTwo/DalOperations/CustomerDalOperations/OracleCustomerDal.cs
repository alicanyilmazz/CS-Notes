using InterfaceImplementationsTwo.DalOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationsTwo.DalOperations.CustomerDalOperations
{
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Data Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Data Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Data Updated!");
        }
    }
}

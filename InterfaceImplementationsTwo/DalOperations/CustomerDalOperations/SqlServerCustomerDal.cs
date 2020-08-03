using InterfaceImplementationsTwo.DalOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationsTwo.DalOperations.CustomerDalOperations
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlServer Data Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer Data Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer Data Updated!");
        }
    }
}

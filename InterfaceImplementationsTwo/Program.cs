using InterfaceImplementationsTwo.DalOperations.CustomerDalOperations;
using InterfaceImplementationsTwo.DalOperations.Interfaces;
using InterfaceImplementationsTwo.Managers.CustomerManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationsTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleCustomerDal());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add( );
            }

            Console.ReadLine();
        }
    }
}

using Attributes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.DataAccessLayers
{
    class CustomerDal
    {
        [Obsolete("Do not use Add() method , instead you can use AddNewValue() method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",customer.Age,customer.FirstName,customer.LastName,customer.Id);
        }

        public void AddNewValue(Customer customer)
        {
            Console.WriteLine("{3},{2},{1},{0} added!", customer.Age, customer.FirstName, customer.LastName, customer.Id);
        }
    }
}

using Generics.Entities;
using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericMethods
{
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }

        public void WritePrimitiveList<T>(List<T> values) where T:struct
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteStringList<T>(List<T> values) where T:class
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteCustomerList(List<Customer> values)
        {
            foreach (var item in values)
            {
                Console.WriteLine(item.Name+"  "+item.Surname);
            }
        }

    }
}

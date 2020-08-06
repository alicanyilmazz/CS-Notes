using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.ORM
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product Added with Nhibernate.");
        }

        public bool ProductExist(Product product)
        {
            Console.WriteLine("Product Controlled for Nhibernate.");
            return true;
        }
    }
}

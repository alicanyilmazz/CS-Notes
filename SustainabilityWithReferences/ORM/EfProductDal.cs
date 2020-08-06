using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.ORM
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product Added with EntityFramework.");
        }

        public bool ProductExist(Product product)
        {
            Console.WriteLine("Product Controlled for EfProduct.");
            return true;
        }
    }
}

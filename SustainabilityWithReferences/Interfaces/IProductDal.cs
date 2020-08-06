using SustainabilityWithReferences.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Interfaces
{
    public interface IProductDal
    {
        void Add(Product product);
        bool ProductExist(Product product);

    }
}

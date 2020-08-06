using SustainabilityWithReferences.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Abstract
{
    public interface IProductService
    {
        bool CheckProductStock(Product product);
    }
}

using SustainabilityWithReferences.Abstract;
using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Adapters
{
    public class StockControllerServiceAdapter : IProductService
    {
        public bool CheckProductStock(Product product)
        {
            StockControllerService stockControllerService = new StockControllerService();
            return stockControllerService.CheckStock(Name: "Soap", Barcode: "ASF4224", Quantity: 244);
        }
    }
}

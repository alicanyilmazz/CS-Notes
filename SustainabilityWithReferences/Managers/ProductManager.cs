using SustainabilityWithReferences.Abstract;
using SustainabilityWithReferences.CustomValidators;
using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Interfaces;
using SustainabilityWithReferences.Utilities;
using SustainabilityWithReferences.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Managers
{
    public class ProductManager
    {
        IProductDal _productDal;
        IProductService _productService;
        public ProductManager(IProductDal productDal, IProductService productService) //isterse EfProductDal isterse NhproductDal gönderir.
        {
            _productDal = productDal;
            _productService = productService;
        }

        public void Add(Product product)
        {
            Utility.Validate(new ProductValidator(), product);
            CustomValidations.CheckProductStockService(_productService, product);
            CustomValidations.CheckProductExist(_productDal, product);
            _productDal.Add(product);
        }
    }
}

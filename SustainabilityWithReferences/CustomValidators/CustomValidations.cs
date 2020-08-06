using SustainabilityWithReferences.Abstract;
using SustainabilityWithReferences.Entities;
using SustainabilityWithReferences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.CustomValidators
{
    public static class CustomValidations
    {
        public static void CheckProductExist(IProductDal productDal, Product product)
        {
            if (productDal.ProductExist(product))
            {
                Console.WriteLine("Custom Product Validation was controlled.");
            }
        }

        /// <summary>
        /// It checks the accuracy of the contact information using the 'CheckControllerService'.
        /// </summary>
        /// <param name="productService">Gets a parameter of the IProductService type.</param>
        /// <param name="product">Gets a parameter of the Product entity type.</param>
        public static void CheckProductStockService(IProductService productService,Product product)
        {
            if (!productService.CheckProductStock(product))
            {
                throw new Exception("There is not any stock for this product.");
            }
        }
    }
}

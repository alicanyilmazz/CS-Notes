﻿using SustainabilityWithReferences.Adapters;
using SustainabilityWithReferences.Managers;
using SustainabilityWithReferences.ORM;
using System;

namespace SustainabilityWithReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Entities.Customer { CustomerName = "Alican", CustomerCode = "AFWQFW2213", CustomerIdentity = "2589631725" }, Enums.DatabaseTypes.Oracle);

            ProductManager productManager = new ProductManager(new NhProductDal(), new StockControllerServiceAdapter());
            productManager.Add(new Entities.Product() { Name = "Soap", Quantity = 102, Barcode = "AFWQ212352" });
        }
    }
}

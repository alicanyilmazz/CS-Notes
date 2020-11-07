### C# Clean Code Notes
- I will explain you section by section clean code examples below.

###Sustainability With References
                
-----

- First of all, I will give you examples on writing reference-based code that is necessary to write clean code.
- We will first examine the `Customer Manager`  class and then the `Product Manager`   class.


```javascript
 class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Entities.Customer { CustomerName = "Alican", CustomerCode = "AFWQFW2213", CustomerIdentity = "2589631725" }, Enums.DatabaseTypes.Oracle);

            ProductManager productManager = new ProductManager(new NhProductDal(),new StockControllerServiceAdapter());
            productManager.Add(new Entities.Product() { Name = "Soap", Quantity = 102, Barcode = "AFWQ212352" });

        }
    }
```


### C# Clean Code Notes
- I will explain you section by section clean code examples below.

###Sustainability With References
                
-----

- First of all, I will give you examples on writing reference-based code that is necessary to write clean code.
- We will first examine the `Customer Manager`  class and then the `Product Manager`   class.

####program.cs
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


####CustomerManager.cs
```javascript
  public class CustomerManager
    {
        public void Add(Customer customer, DatabaseTypes databaseTypes)
        {
            Utility.Validate(new CustomerValidator(),customer);
            CustomerDal customerDal = new CustomerDal(databaseTypes);
            customerDal.Add(customer);

        }

        public void AddByOtherBusiness()
        {
             
        }
    }
```
- The Add method, which is a member of the `Customer Manager`  Class, takes two parameters from the `Customer`  Class type and the  `DatabaseTypes`  Enum type.

####Utility.cs
```javascript
    public static class Utility
    {
        /// <summary>
        /// Verify to object using the validator.
        /// </summary>
        /// <param name="validator">Validator implemented from IValidator.</param>
        /// <param name="entity">Entity to be verified</param>
        public static void Validate(IValidator validator, object entity)// First Parameter is : CustomerValidator Second Parameter is : Entity(Customer)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
```

- `utility` 

- There is a `Validate`  method belonging to the `utility`  class.
Because the `Validate` method uses `IValidator`  (`Fluent Api-Fluent Validation` ) type, it checks the incoming entity according to the relevant validator class.

####CustomerValidator.cs
```javascript
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().When(x=>x.CustomerIdentity=="123").WithMessage("CustomerName field not be empty!");
            RuleFor(x => x.CustomerCode).NotEmpty().WithMessage("CustomerCode field not be empty!");
            RuleFor(x => x.CustomerIdentity).NotEmpty().WithMessage("Customer Identity field not be empty!");
            RuleFor(x => x.CustomerIdentity).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
```

### C# Clean Code Notes
- I will explain you section by section clean code examples below.


###Sustainability With References
                
-----
- **First of all, we will give a bad code example and then we will make it better step by step.**
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


- As we have seen in `Customer Validation` , if we want to validate a entity, we must create a  `validator`  class of it.

- `AbstractValidator <Customer>`  structure comes from fluent validation and implements the IValidate interface.

- If we go back to the  `CustomerManager`  class, you will see that we are going to the `CustomerDal`  class.

####CustomerDal.cs
```javascript
  public class CustomerDal
    {
        DatabaseTypes _databaseTypes;
        public CustomerDal(DatabaseTypes databaseTypes)
        {
            _databaseTypes = databaseTypes;
        }
        public void Add(Customer customer)
        {
            if (_databaseTypes==DatabaseTypes.Oracle)
            {
                Console.WriteLine(customer.CustomerName+" Customer added to Database with Oracle.");
            }
            else
            {
                Console.WriteLine(customer.CustomerName+" Customer added to Database with Mssql.");
            }
        }

        public bool CustomerExist(Customer customer)
        {
            return true;
        }
    }
```



- The `CustomerDal`  class works with the Database Types given to it.(Mssql or Oracle etc.)

####DatabaseTypes.cs
```javascript
      public enum DatabaseTypes
    {
        Oracle,SqlServer
    }
```

- Let's take a look at the `Customer Manager`  class again.

-You will see the ` customerDal.Add(customer);`  code and it will add the person to the database according to the database type given previously.

- **Next time we'll look at how we can make this code better.**

- **If you can't wait, please check out the code in the SustainabilityWithReferences folder.**

- `Alican Yılmaz` 

using Attributes.MainAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes.Entities
{
    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        [RequiredProperty]
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustainabilityWithReferences.Entities
{
    public class Customer:Person
    {
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerIdentity { get; set; }
    }
}

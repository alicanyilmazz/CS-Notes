using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    class Customer:IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}

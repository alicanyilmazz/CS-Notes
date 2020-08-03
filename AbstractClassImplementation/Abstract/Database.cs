using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassImplementation.Abstract
{
    public abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by Default.");
        }

        public abstract void Delete();
      
    }
}

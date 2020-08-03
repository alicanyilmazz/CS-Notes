using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTwo.Base
{
    public class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default.");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default.");
        }
    }
}

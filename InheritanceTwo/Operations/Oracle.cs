using InheritanceTwo.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTwo.Operations
{
    public class Oracle:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Oracle.");
            base.Add();
        }
    }
}

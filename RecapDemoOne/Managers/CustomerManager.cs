using RecapDemoOne.Interfaces;
using RecapDemoOne.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOne.Managers
{
    class CustomerManager
    {
        public ILogger _Logger { get; set; }
        public void Add()
        {
            _Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }
}

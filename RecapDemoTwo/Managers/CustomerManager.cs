using RecapDemoTwo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoTwo.Managers
{
    class CustomerManager
    {
        public ILogger _Logger;
        public CustomerManager(ILogger logger)
        {
            _Logger = logger;
        }
        public void Add()
        {
            _Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }
}

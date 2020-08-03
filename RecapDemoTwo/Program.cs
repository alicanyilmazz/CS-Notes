using RecapDemoTwo.Loggers;
using RecapDemoTwo.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new FileLogger());
            customerManager.Add();
        }
    }
}

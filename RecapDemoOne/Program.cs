using RecapDemoOne.Loggers;
using RecapDemoOne.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager._Logger = new DatabaseLogger(); //FileLogger() //SmsLogger()
            customerManager.Add();

        }
    }
}

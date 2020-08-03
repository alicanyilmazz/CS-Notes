using RecapDemoTwo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoTwo.Loggers
{
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File.");
        }
    }
}

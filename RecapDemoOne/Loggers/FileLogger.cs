﻿using RecapDemoOne.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemoOne.Loggers
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File.");
        }
    }
}

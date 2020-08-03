using InterfaceImplementationThree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationThree.Managers
{
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Worked.");
        }
    }
}

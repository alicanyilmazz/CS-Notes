using InterfaceImplementationThree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationThree.Managers
{
    public class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eated.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager getted Salary.");
        }

        public void Work()
        {
            Console.WriteLine("Manager Worked.");
        }
    }
}

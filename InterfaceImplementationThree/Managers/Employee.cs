using InterfaceImplementationThree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationThree.Managers
{
    public class Employee : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Employee Eated.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Employee getted Salary.");
        }

        public void Work()
        {
            Console.WriteLine("Employee Worked.");
        }
    }
}

using InterfaceImplementationThree.Interfaces;
using InterfaceImplementationThree.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationThree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface'leri dogru kullanarak böllerek SOLID in Interface Segregation Principles 'ı uyguladık bu uygulamamızda.
            IWorker[] workers = new IWorker[3] { new Employee(), new Manager(), new Robot() };
            IEat[] eats = new IEat[2] { new Employee(), new Manager() };
            ISalary[] salaries = new ISalary[2] { new Employee(), new Manager() };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();

        }
    }
}

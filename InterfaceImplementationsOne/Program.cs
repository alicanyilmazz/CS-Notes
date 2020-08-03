using InterfaceImplementationsOne.Entities;
using InterfaceImplementationsOne.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementationsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer() { Id = 1, FirstName = "Alican", LastName = "Yilmaz", Address = "Kanatli mah." };
            Student student = new Student() {Id=1,FirstName="Kemal",LastName="Tanca",Department="Computer Sciences"};
        
            personManager.Add(customer);
            personManager.Add(student);

            Console.ReadLine();

        }
    }
}

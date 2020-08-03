using InheritanceOne.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peoples = new Person[3]
            {
                new Customer(){FirstName="Alican" },
                new Student(){FirstName="Kemal" },
                new Person(){FirstName="Yahya"}
            };
            foreach (var person in peoples)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine(); 
            //Burada Interface ile Intheritance arasındaki temel farklardan biride Interface tek başına bir anlam ifade etmediği için 
            //  new Customer(), new Student() ile birlikte new IPerson diyemeyiz hemde new lenemediği için, fakat burada istersen bunlara
            //Ek olarak new Person() yapısını da ekleyebiliriz.

        }
    }
}

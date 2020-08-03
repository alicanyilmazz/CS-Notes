using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndBaseConstructor.Classes
{
    class Manager
    {
        public int Id { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("Done!");
        }

        public static void DoSomething2()
        {
            Console.WriteLine("Done!");
        }
    }
}

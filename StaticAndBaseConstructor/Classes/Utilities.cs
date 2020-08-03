using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndBaseConstructor.Classes
{
    static class Utilities
    {
        static public int _validationId { get; set; }

        static Utilities()
        {
            Console.WriteLine("Utilies.");
        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done.");
        }
    }
}

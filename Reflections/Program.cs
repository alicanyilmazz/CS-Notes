using Reflections.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Calculator);

            Calculator calculator = (Calculator)Activator.CreateInstance(type, 1, 2, 3);
            Console.WriteLine("Sum Method() : " + calculator.Sum(2, 7, 1));

            var instance = Activator.CreateInstance(type, 1, 2, 3); // 1,2,3 constructor ı kullanan metodlar için deger atamak için kullanılıyor ctor gidiyor yani bu degerler.
            MethodInfo methodInfo = instance.GetType().GetMethod("SumDefault");
            Console.WriteLine("SumDefault : " + methodInfo.Invoke(instance, null)); //Metodu calistiriyoruz. (SumDefault())
            Console.WriteLine();

            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.Write(" Method Name is : {0} ", method.Name + "()");
                foreach (var parameter in method.GetParameters())
                {
                    Console.Write(" || Parameter Name : " + parameter.Name);
                }
                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.Write(" || Attribute Name : {0}", attribute.GetType().Name);
                }
                Console.WriteLine();
            }
        }
    }
}

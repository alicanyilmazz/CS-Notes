using Reflections.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Calculators
{
    public class Calculator
    {
        private int _num1;
        private int _num2;
        private int _num3;

        public Calculator(int num1, int num2, int num3)
        {
            _num1 = num1;
            _num2 = num2;
            _num3 = num3;
        }

        public int SumDefault()
        {
            return _num1 + _num2 + _num3;
        }
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        [MethodNameAttribute("Divider")] //Örneğin Metodun Web Api gibi bir yerde dışarıya başka bir isimle görünsün diye kullanabiliriz.
        public float Divide(int x, int y)
        {
            return x / y;
        }

        public float Mode(int x, int y)
        {
            return x % y;
        }

        public float Mean(int x, int y, int z)
        {
            return (x + y + z) / 3;
        }
    }
}

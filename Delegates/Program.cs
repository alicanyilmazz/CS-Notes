using Delegates.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SystemDelegate();
    public delegate void SystemDelegate2(string val);
    public delegate void SystemDelegate3(int a, int b, int c);
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            SystemDelegate _systemDelegate;
            _systemDelegate = customerManager.OpenBoard;
            _systemDelegate += customerManager.ControlCable;
            _systemDelegate();
            _systemDelegate -= customerManager.ControlCable;

            SystemDelegate2 systemDelegate2;
            systemDelegate2 = customerManager.HowPreparedCPU;
            systemDelegate2 = customerManager.HowIsPreaperdGPU;
            systemDelegate2("Better"); //Buradaki Delegate kısıtı aynı parametreyi iki operasyon içinde göndermek zorunda kaldık.Bunu ancak objeler ile çalışarak cözebiliriz.


        }
    }
}

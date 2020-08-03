using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Managers
{
    class CustomerManager
    {
        public void OpenBoard()
        {
            Console.WriteLine("Opened the board!");
        }
        public void ControlCable()
        {
            Console.WriteLine("Controlled the cables.");
        }

        public void HowPreparedCPU(string val)
        {
            Console.WriteLine("CPU : "+val);
        }

        public void HowIsPreaperdGPU(string val)
        {
            Console.WriteLine("GPU : " + val);
        }
    }
}

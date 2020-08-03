using InheritanceTwo.Base;
using InheritanceTwo.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Oracle oracle = new Oracle();
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            oracle.Add();
        }
    }
}

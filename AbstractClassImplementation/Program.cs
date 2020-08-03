using AbstractClassImplementation.Abstract;
using AbstractClassImplementation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Database databaseOracle = new Oracle();
            Database databaseSqlServer = new SqlServer();

            databaseOracle.Add();
            databaseOracle.Delete();

            databaseSqlServer.Add();
            databaseSqlServer.Delete();
        }
    }
}

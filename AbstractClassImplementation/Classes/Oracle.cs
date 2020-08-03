﻿using AbstractClassImplementation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassImplementation.Classes
{
    public class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle.");
        }

    }
}

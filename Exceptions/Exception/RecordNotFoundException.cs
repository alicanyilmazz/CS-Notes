﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Exception
{
    class RecordNotFoundException:System.Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Multiplication:IBinarycomputing
    {
        public int Calculate(int x, int y)
        {
            var result = x * y;
            return result;
        }
    }
}

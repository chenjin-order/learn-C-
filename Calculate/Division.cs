using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Division:IBinarycomputing
    {
        public int Calculate(int x, int y)
        {
            var result = 0;
            if (Math.Abs(y) > 0)
            {
                result = x / y;
            }
            else
            {
                throw new DivideByZeroException("除数等于零");
            }
            return result;
        }
        public double Calculate(double x, double y)
        {
            var precise = 1e-5;
            var result = 0.0;
            if (Math.Abs(y) - Double.Epsilon > precise)
            {
                result = x / y;
            }
            else
            {
                throw new DivideByZeroException("除数等于零");
            }
            return result;
        }
    }
}

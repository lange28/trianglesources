using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
   public static class FunTr
    {
        public static double Sq(double a, double b, double c)
        {
            double res = 0;
            if ((a <= 0) || (b <= 0) || (c <= 0)) { throw new ArgumentOutOfRangeException("ds"); }
            if ((a + b >= c) || (a + c >= b) || (c + b >= a)) { throw new ArgumentException("One of the arguments are greater then the sum of others"); }
            res = 0.5 * a * b;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
   public static class RightTr
    {
        public static double Area(double a, double b, double c)
        {
            //ArgumentException("One of the arguments are greater then the sum of others")
            double value = 0;
            if ((a <= 0) || (b <= 0) || (c <= 0)) { throw new ArgumentOutOfRangeException("ds"); }
            if ((a + b <= c) || (a + c <= b) || (c + b <= a)) { throw new ArgumentException("One of the arguments are greater then the sum of others"); }
            value = 0.5 * a * b;
            return value;
        }
        public static void Main()
        {
            string str;
            Console.WriteLine("Input a");
            str = Console.ReadLine();
            double a = Convert.ToDouble(str);

            Console.WriteLine("Input b");
            str = Console.ReadLine();
            double b = Convert.ToDouble(str);

            Console.WriteLine("Input c");
            str = Console.ReadLine();
            double c = Convert.ToDouble(str);
            
            double s = Area(a, b, c);

            Console.WriteLine("Result "+Convert.ToString(s));
            str = Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment164
{
    class Class1
    {
        public static int Multiply(int x, int y)
        {
            
            int result = x * y;

            return result;
        }

        public static decimal Multiply(decimal x, int y)
        {
            double result = (int)(x * y);

            return (decimal)result;
        }

        public static double Multiply(double x, double y)
        {
            double result = x * y;

            return result;
        }
    }
}

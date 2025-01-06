using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Calculator
    {
        public static long Sum(int x, int y)
        {
            return x + y;
        }
        public static long Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
       
    }
}

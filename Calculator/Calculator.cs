using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        public static int add(int x, int y)
        {
            return x+y;
        }

        public static int dif(int x, int y)
        {
            return x - y;
        }

        public static int mul(int x, int y)
        {
            return x * y;
        }

        public static int div(int x, int y)
        {
            return x / y;
        }

        public static int stp(int x, int y)
        {
            return (int)Math.Pow(x, y);
        }
    }
}

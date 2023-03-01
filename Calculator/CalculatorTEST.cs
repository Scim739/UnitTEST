using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorTEST
    {
        public static void addTEST()
        {
            if (Calculator.add(2, 3) == 5)
                Console.WriteLine("All right");
            else
                Console.WriteLine("Fail");
        }

        public static void difTEST()
        {
            if (Calculator.dif(2, 3) == -1)
                Console.WriteLine("All right");
            else
                Console.WriteLine("Fail");
        }

        public static void mulTEST()
        {
            if (Calculator.mul(2, 3) == 6)
                Console.WriteLine("All right");
            else
                Console.WriteLine("Fail");
        }

        public static void divTEST()
        {
            if (Calculator.div(15, 3) == 5)
                Console.WriteLine("All right");
            else
                Console.WriteLine("Fail");
        }

        public static void stpTEST()
        {
            if (Calculator.stp(2, 3) == 8)
                Console.WriteLine("All right");
            else
                Console.WriteLine("Fail");
        }
    }
}

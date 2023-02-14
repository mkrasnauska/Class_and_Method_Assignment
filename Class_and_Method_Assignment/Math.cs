using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Assignment
{
    static class Math
    {
        public static void MyMathAdd(int a = 9, int b = 7)
        {
            int c = (a + b) / 2;
            Console.WriteLine("a+b/2 b=7 \nResult:" + c);
        }
        public static int MyMathDiv(int x, int y)
        {
            return x / y;

        }
        public static double MyMathDiv(double x, double y)
        {
            return x / y;
        }
    }
}


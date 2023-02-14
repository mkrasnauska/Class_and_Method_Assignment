using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Assignment
{
    internal class Program
    {
        public static void Main()
        {

            Math.MyMathAdd();
            Console.WriteLine("Type number for \"a\" value");
            Math.MyMathAdd(Convert.ToInt32(Console.ReadLine()), 7);


            int z = Math.MyMathDiv(100, 52);
            double m = Math.MyMathDiv(1.84, 7.4);
            Console.WriteLine("Integer division : " + z);
            Console.WriteLine("Double division : " + m);
            Console.ReadLine();

        }
    }
}

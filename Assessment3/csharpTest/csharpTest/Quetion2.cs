using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
    internal class Quetion2
    {
        public static int Sum(int x, int y)
        {
            int total;
            total = x + y;
            return total;
        }

        public static int Sub(int x, int y)
        {
            int total;
            total = x - y;
            return total;
        }
        public static int Mul(int x, int y)
        {
            int total;
            total = x * y;
            return total;
        }

            static void Main(string[] args)
        {
            

            

            Console.Write("Enter x Number :");

            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y Number :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of Two Integers is :" + Sum(x,y));
            Console.WriteLine("Mul of Two Integers is :" + Sub(x,y));
            Console.WriteLine("Mul of Two Integers is :" + Mul(x,y));
        }
    }
}

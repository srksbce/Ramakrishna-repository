using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
    internal class Quetion10b
    {
        // Reverse A number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int Num = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Num > 0)
            {
                int remainder = Num % 10;
                Reverse = (Reverse * 10) + remainder;
                Num = Num / 10;
            }
            Console.WriteLine("Reverse Number is {0}", Reverse);
            Console.ReadLine();
        }
    }
}

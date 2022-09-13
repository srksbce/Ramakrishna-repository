using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
    public class Quetion7
    {
          //method overloading

        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Mul(int x, int y, int z)
        {
            return x * y * z;
        }
        public float Mul(float x, float y)
        {
            return x * y;
        }
        static void Main(string [] args)
        {
            Quetion7 Que = new Quetion7();
           
            Console.WriteLine("Sum of Two Integers is :" + Que.Mul(1, 2));
            Console.WriteLine("Sum of Three Integers is :" + Que.Mul(1, 2, 3));
            Console.WriteLine("Sum of Two Floats is  :" + Que.Mul(1.5f, 2.5f));
        }
    }
}

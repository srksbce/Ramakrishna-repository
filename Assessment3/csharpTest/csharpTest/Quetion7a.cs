using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
    public class Quetion7a
    {
          //method overloading

        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public float Sum(float x, float y)
        {
            return x + y;
        }
        static void Main(string [] args)
        {
            Quetion7a Que = new Quetion7a();
           
            Console.WriteLine("Sum of Two Integers is :" + Que.Sum(1, 2));
            Console.WriteLine("Sum of Three Integers is :" + Que.Sum(1, 2, 3));
            Console.WriteLine("Sum of Two Floats is  :" + Que.Sum(1.5f, 2.5f));
        }
    }
}

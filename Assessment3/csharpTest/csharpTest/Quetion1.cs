using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
  public  class Quetion1
    {
        public void Swap(int x, int y)
        {
            int temp=x;
            x=y;
            y=temp;
            Console.WriteLine("After  Swapping the Values are :{0}\t{1}", x, y);
        }

        //Call by Reference
        public void Swap1(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    
   
        static void Main(string[] args)
        {
            int x = 10,y = 20;
            Console.WriteLine("Before Swapping the Values are :{0}\t{1}", x, y);
            Quetion1 Quetion1 = new Quetion1();
            Quetion1.Swap(x, y);
            Quetion1.Swap1(ref x, ref y);
            Console.WriteLine("After  Swapping the Values are :{0}\t{1}", x, y);
        }
    }
}

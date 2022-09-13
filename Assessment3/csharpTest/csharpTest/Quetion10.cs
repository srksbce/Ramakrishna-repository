using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
   public class Quetion10
    {
        static void Main(string[] args)
        {
            string Str, Revstr = ""; 
            int Length; 
            Console.Write("Enter  String : ");
            Str = Console.ReadLine(); 
            Length = Str.Length - 1; 
            while (Length >= 0)  
            {
                Revstr = Revstr + Str[Length];  
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", Revstr); 
            Console.ReadLine();  
        }
    }
}

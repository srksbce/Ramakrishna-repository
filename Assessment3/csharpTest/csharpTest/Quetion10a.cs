using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
   public class Quetion10a
    {           //return a reverse 
        public static string ReverseString(string Input)
        {

            char[] Array = Input.ToArray();

            string revString = String.Empty;

       
            for (int i = Array.Length - 1; i > -1; i--)
            {

                revString += Array[i];
            }

            
            return revString;
        }

      
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Ramakrishna"));
        }
    }
}


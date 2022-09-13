using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
   public class Quetion9
    {
        //Removing Duplicate characters
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");

       string str = Console.ReadLine();

             string result = "";
        result += str[0]; 

      for (int i = 1; i < str.Length; i++)
        {
    if (str[i - 1] != str[i])
        result += str[i];
                   }

             Console.WriteLine(result);




            }

    }
}

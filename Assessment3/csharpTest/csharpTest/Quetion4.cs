using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
    public class Quetion4
    {
        static void Main(string[] args)
        {
            string str = "rAMAKRISHNA";
            if (str.Length == 0)

                Console.Write("Empty String");
            else if (str.Length == 1)

                Console.Write(char.ToUpper(str[0]));





            else

                Console.Write(char.ToUpper(str[0]) + str.Substring(1));

        }
    }
}

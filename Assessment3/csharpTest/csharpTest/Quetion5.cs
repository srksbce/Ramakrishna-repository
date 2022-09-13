using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTest
{
    public class Quetion5
    {
        public static void Main()
        {
            string Str;
            int i, length, lower, upper;
            Str = "RamaKrishna";
            Console.Write("String: " + Str);
            lower = 0;
            upper = 0;
            length = Str.Length;
            for (i = 0; i < length; i++)
            {
                if (Str[i] >= 'a' && Str[i] <= 'z')
                {
                    lower++;
                }
                else if (Str[i] >= 'A' && Str[i] <= 'Z')
                {
                    upper++;
                }
            }
            Console.Write("\nCharacters in lowecase: {0}\n", lower);
            Console.Write("Characters in uppercase: {0}\n\n", upper);
        }
    }
}


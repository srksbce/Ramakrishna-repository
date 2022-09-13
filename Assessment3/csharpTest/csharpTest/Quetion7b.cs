using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace csharpTest
{
    public class Quetion7b //Base class
    {
        public virtual void display()
        {
            Console.WriteLine("Baseclass Method is calling");
        }
    }
    public class derivedclass : Quetion7b
    {
        public override void display()
        {
            Console.WriteLine("derived class method is calling");
        }
    }
    class mainclass { 
    public static void Main(string[] args)
    {
            derivedclass dc = new derivedclass();
            dc.display();
            Console.ReadLine();
    }

}
}

    


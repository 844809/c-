using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCal;

namespace Lib1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.No1 = 40;
            c.No2 = 20;
            Console.WriteLine(c.Add());
            Console.WriteLine(c.Diff());
            Console.WriteLine(c.Mul());
            Console.WriteLine(c.Div());
 
        }
    }
}

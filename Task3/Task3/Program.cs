using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator(20,5);
            Console.WriteLine(c.Add());
            Console.WriteLine(c.Diff());
            Console.WriteLine(c.Mul());
            Console.WriteLine(c.Div());
        }
    }
}

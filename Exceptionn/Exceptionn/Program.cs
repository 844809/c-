using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionn
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 20;
            double result;
            Modu m = new Modu();
            try
            {
                result = m.div(a, b);
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero {0}", e);
            }
        }
    }
}

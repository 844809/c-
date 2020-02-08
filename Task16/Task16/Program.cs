using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        public static double Mydel(double b, double h)
        {
            return 0.5 * b * h;
        }
        static void Main(string[] args)
        {
            Func<double, double, double> value = Mydel;
            Console.WriteLine(value(1, 2));
        }
    }
}

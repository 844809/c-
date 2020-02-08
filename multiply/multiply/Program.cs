using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, d;
            a = 4;b = 4;
            double d = Multiply(a, b);
            Console.WriteLine("multiplication of {0} and {1} is {2}",a,b,d);

        }
        public static double Multiply(int a,int b)
        {
            double res = a * b;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            a = 4; b = 4;
           
            Console.WriteLine("addition of {0} and {1}", a, b);
            Add(a, b);
        }
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
    }
}

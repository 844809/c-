using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[2];


            test[0] = "Hello ";
            test[1] = "World!";

            string result = string.Concat(test);
            Console.WriteLine("{0}{1}", test);
        }
    }
}

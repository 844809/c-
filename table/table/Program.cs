using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = int.Parse(Console.ReadLine());
            for (i = 0; i < 10; i++)
                Console.WriteLine("{0} * {1}={2}",n, i, n * i);
        }
    }
}

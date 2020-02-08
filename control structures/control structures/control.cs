using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  control
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a > 10)
                Console.WriteLine("good morning");
            else if (a < 10)
                Console.WriteLine("good evening");
            else
                Console.WriteLine("goodnight");
        }
    }
}

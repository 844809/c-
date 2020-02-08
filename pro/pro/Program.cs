using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Centi c = new Centi();
            c.inch = 12;
            Console.WriteLine("{0}", c.inch);
            c.showCenti();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Timeperiod t = new Timeperiod();
            t.Hours = 15;
            Console.WriteLine("hours {0}", t.Hours);
            t.showseconds();
        }
    }
}

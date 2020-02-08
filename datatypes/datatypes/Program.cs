using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'g';
            int i = 89;
            short s = 56;
            long l = 4564;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 3624573;
            double d = 8.358674532;
            float f = 3.7330645f;
            decimal dec = 389.5m;
            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
            DateTime dt = DateTime.Now;
            Console.WriteLine("The current date is:{0}",dt);
            Console.WriteLine( dt.ToShortDateString());
            Console.WriteLine(dt.ToLongDateString());

        }
    }
} 


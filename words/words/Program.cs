using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            numtoword nw = new numtoword();
            int n = int.Parse(Console.ReadLine());
            string d = nw.numbertoword(n);
            Console.WriteLine(d);
        }
    }
}

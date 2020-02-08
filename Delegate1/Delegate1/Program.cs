using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
        public delegate string Mydel(int x, int y);
        static void Main(string[] args)
        {
            Mydel delg = new Mydel(Add);
            Console.WriteLine(delg(50, 20));
            delg += new Mydel(Subtract);
            Console.WriteLine(delg(25, 10));
            delg -= new Mydel(Subtract);
            Console.WriteLine(delg(50, 20));
        }
        static string Add(int x,int y)
        {
            int z = x + y;
            return string.Format("{0}+{1}={2}", x, y, z);
        }
        static string Subtract(int x,int y)
        {
            int z = x - y;
            return string.Format("{0}-{1}={2}", x, y, z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        public delegate void Mydel(string s);
        static void Main(string[] args)
        {
            Mydel delgt = a => Console.WriteLine(a);
            delgt("hello");
        }
    }
}

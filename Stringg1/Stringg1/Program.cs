using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringg1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("hello");
            Console.WriteLine(stb);
            stb.Append(2345);
            Console.WriteLine("Append long values {0}", stb);
            int i = stb.Capacity;
            Console.WriteLine("Initial capacity of StringBuilder {0}", i);
            stb.Insert(6, "World");
            Console.WriteLine("inserted at 6 id {0}", stb);
            stb.Remove(7, 3);
            Console.WriteLine("After removing {0}", stb);
            stb.Replace("lo", "arious");
            Console.WriteLine("After replacing {0}", stb);
        }
    }
}

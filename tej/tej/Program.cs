using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tej
{
    class Program
    {
        static String greetings(String a, int b)
        { 
            return String.Format("congratulations {0} on your {1} birthday", a, b);
        }
        static void Main(String[] args)
        {
            String a,c;
            int b;
            Console.WriteLine("enter name");
            a = Console.ReadLine();
            Console.WriteLine("enter age");
            b = int.Parse(Console.ReadLine());
            c = greetings(a,b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}


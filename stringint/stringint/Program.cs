using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringint
{
    class Program
    {
        static void greetings(String a,int b)
        { 
            Console.WriteLine("congratulations {0} on your {1} birthday", a, b);
        }
        public void Main(String[] args)
        {
            String a;
            int b;
            Console.WriteLine("enter name");
            a = Console.ReadLine();
            Console.WriteLine("enter age");
            b = int.Parse(Console.ReadLine());
            greetings(a, b);
            Console.ReadKey();
        }
    }
}

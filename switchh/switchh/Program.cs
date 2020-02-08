using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchh
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=2;
            switch(b)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("hwru");
                    break;
                case 3:
                    Console.WriteLine("gud");
                    break;
                default:    
                   Console.WriteLine("not bad");
                    break;
            }
        }
    }
}

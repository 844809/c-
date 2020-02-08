using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            Array.Reverse(array);
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            int[] z = { 1, 2, 3, 4, 5 };
            Task12 t = new Task12();
            Console.WriteLine(t.total(z));

        }
        
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            car inova = new car();
            inova.Showcar();
            car c1 = new car("3549");
            c1.Showcar();
            car c2 = new car("3549", "benz");
            c2.Showcar();
            car c3 = new car("3549", "benz", "black");
            c3.Showcar();
            car c4 = new car("3549", "benz", "black", 10000000);
           Console.WriteLine( c4.Showcar());
        }
    }
}

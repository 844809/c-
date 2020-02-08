using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "welcome to cognizant";
            string st2 = "all the best";
            string[] words = st1.Split();
            string[] wordss = st2.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            foreach(string s in wordss)
            {
                Console.WriteLine(s);
            }
        }
    }
}

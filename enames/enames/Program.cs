using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employe = new string[] { "teja", "ganesh", "siri", "shri" };
            foreach (string i in employe)
                Console.WriteLine(i);
        }
    }
}

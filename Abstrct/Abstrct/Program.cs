using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrct
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract1 a1 = new Abstract1();
            a1.abs();
            Abstract2 a2 = new Abstract2();
            a2.abs();
        }
    }
}

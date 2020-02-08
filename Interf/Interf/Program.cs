using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interf
{

    interface Bike
    {
        void getit();
    }
    interface car
    {
        void getit1();
    }
    class Program
    {
        static void Main(string[] args)
        {
           Doit i = new Doit();
            i.getit();
            i.getit1();
        }
    }
}

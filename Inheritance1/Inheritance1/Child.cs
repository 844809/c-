using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Child:Parent
    {
        public void showTrain()
        {
            Console.WriteLine("From Train");
        }
        public override void show1()
        {
            Console.WriteLine("everything is awesome");
        }
    }
}

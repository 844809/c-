using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro
{
    class Centi
    {
        double centimeter;
        public double inch
        {
            get { return centimeter / 2.54; }
            set
            {
                centimeter = value * 2.54;
            }
        }
        public void showCenti()
        {
            Console.WriteLine("centimeters {0}", centimeter);
        }
    }
}

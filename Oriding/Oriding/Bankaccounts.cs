using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriding
{
    class Bankaccounts
    {
        public Customer customer;
        public double si;
        int Accnumber;
        double Accbal;
        public int accno { get; set; }
        public double accbal { get; set; }
        public virtual double Si()
        {
            int r = 3;
            int t = 3;
            si = (accbal * t * r) / 100;
            return si;
        }
    }
}

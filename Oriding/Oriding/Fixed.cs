using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriding
{
    class Fixed:Bankaccounts
    {
        Bankaccounts b = new Bankaccounts();
        public override double Si()
        {
            double add = b.si;
            double newadd = add * 0.03;
            return newadd;
        }
    }
}

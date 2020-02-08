using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oride
{
    class Analyst:Employee
    {
        public override string Empsalary(double salary)
        {
            double incentive = 4000;
            double total = incentive + salary;
            return total.ToString();
        }
    }
}

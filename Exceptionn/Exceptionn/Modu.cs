using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionn
{
    class Modu
    {
        public double div(double a,double b)
        {
            if(a==0)
            {
                throw new System.DivideByZeroException();
            }
            return a % b;
        }
    }
}

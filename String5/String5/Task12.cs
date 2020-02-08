using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String5
{
    class Task12
    {
        public int total(int[] g)
        {
            int sum = 0;
            foreach(int q in g)
            {
                if(q%2==0)
                {
                    sum += q;
                }
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Linq
{
    class course
    {
        public int cid { get; set; }
        public string name { get; set; }
        public double fees { get; set; }
        public DateTime doj { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<course>clst=new List<course>()
            {
                new course{cid=1,name="c#",fees=45122,doj=Convert.ToDateTime("11-12-2019")},
new             course{cid=2,name="java",fees=45122,doj=Convert.ToDateTime("11-12-2019")},
new             course{cid=3,name="python",fees=45122,doj=Convert.ToDateTime("11-12-2019")},
new             course{cid=4,name="julia",fees=45122,doj=Convert.ToDateTime("11-12-2019")},
};
            var query = from aq in clst
                        select aq;
            foreach (var q in query)
            {
                Console.WriteLine("cid:{0}\n cname {1}\n fees :{2}\n doj:{3}", q.cid, q.name, q.fees, q.doj);
            }
            var qget = from a in clst
                       orderby a.fees
                       select a;
            foreach (var q in qget)
            {
                Console.WriteLine("cid:{0}\n cname {1}\n fees :{2}\n doj:{3}", q.cid, q.name, q.fees, q.doj);
            }
            var y = from i in clst
                    where i.cid is 1
                    select i;
            foreach (var q in qget)
            {
                Console.WriteLine("cid:{0}\n cname {1}\n fees :{2}\n doj:{3}", q.cid, q.name, q.fees, q.doj);
            }

        }
        
    }
}

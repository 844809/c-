using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Custprod
{
    class Customer1:DbContext
    {

        public List<Product1> product { get; set; }
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
        public double Purchase { get; set; }
    }
}

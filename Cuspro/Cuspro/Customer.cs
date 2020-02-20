using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuspro
{
    class Customer
    {
        public List<Product> product { get; set; }
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
        public double Purchase { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cp
{
    class Product
    {
        public string name { get; set; }
        public int id { get; set; }
        public double price { get; set; }
        public List<Customer> customers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cp
{
    class Customer
    {

        public string name { get; set; }
        public int id { get; set; }
        public int quality { get; set; }
        public List<Product> Products { get; set; }
    }
}

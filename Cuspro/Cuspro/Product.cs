using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cuspro
{
    class Product:DbContext
    {
        public int Productid { get; set; }
        public string Productname {get;set;}
        public double Productcost { get; set; }
    }
}

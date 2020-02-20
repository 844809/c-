using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Custprod
{
    class Product1
    {
        [Key]
        public int Productid { get; set; }
        public string Productname { get; set; }
        public double Productcost { get; set; }
    }
}

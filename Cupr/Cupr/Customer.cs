using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cupr
{
    class Customer
    {
        [Key]
        public int cid { get; set; }
        public string name { get; set; }
        public int quality { get; set; }
        public List<Product> Products { get; set; }
    }
}

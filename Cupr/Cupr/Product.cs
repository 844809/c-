using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cupr
{
    class Product
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public double price { get; set; }
        public Customer cid { get; set; }
       // public List<Customer> customers { get; set; }
        public virtual ICollection<Purchase> purchases { get; set; }
    }
}

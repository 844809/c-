using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupr
{
    class Program
    {
       public static void insertinitialdata()
        {
            Context c = new Context();
            var customers = new List<Customer>
            {
                new Customer{name="teju",quality=40},
                new Customer{name="vish",quality=50},
                new Customer{name="ambi",quality=60},
                new Customer{name="siri",quality=70},
                new Customer{name="anu",quality=80},
                new Customer{name="shri",quality=90}
            };
            customers.ForEach(s => c.customers.Add(s));
            c.SaveChanges();
            var products = new List<Product>
            {
                new Product{pname="choco",price=59},
                new Product{pname="teddy",price=99},
                new Product{pname="cosmotics",price=79},
                new Product{pname="dress",price=89},
                new Product{pname="footwear",price=39}
            };
            products.ForEach(p => c.products.Add(p));
            c.SaveChanges();
            var purchases = new List<Purchase>
            {
                new Purchase{OrderDate=Convert.ToDateTime("09-02-2020"),pid=1,cid=2},
                new Purchase{OrderDate=Convert.ToDateTime("08-02-2020"),pid=2,cid=1},
                new Purchase{OrderDate=Convert.ToDateTime("07-02-2020"),pid=3,cid=2},
                new Purchase{OrderDate=Convert.ToDateTime("06-02-2020"),pid=3,cid=3},
                new Purchase{OrderDate=Convert.ToDateTime("05-02-2020"),pid=4,cid=4}
            };
            purchases.ForEach(pu => c.purchases.Add(pu));
            c.SaveChanges();
        }
        public static void show()
        {
            Context ct = new Context();
            var customers = ct.customers;
            Console.WriteLine("customer details");
            foreach(var p in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.cid, p.name, p.quality);
            }                                                                                   
            var products = ct.products;
            Console.WriteLine("product details");
            foreach (var p in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}",p.pid,p.pname,p.price);
            }
            var purchases = ct.purchases;
            Console.WriteLine("purchase details");
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", "purid", "Orederdate", "ppid", "name", "price", "cid", "cname");
            foreach (var p in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", p.id, p.OrderDate.ToShortDateString(), p.pid,p.product.pname,p.product.price,p.cid,p.customer.name);
            }
        }
        

        static void Main(string[] args)
        {
            insertinitialdata();
            show();
        }
    }
}

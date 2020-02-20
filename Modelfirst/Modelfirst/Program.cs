using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelfirst
{
    class Program
    {
        static ModelfirstentityContainer mdb = new ModelfirstentityContainer();
        static void Main(string[] args)
        {
           // Category1();
            //Product1();
            Category();
            Product();
        }
        public static void Category()
        {
            Console.WriteLine("enter cid");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            var c = new category
            {
                cid = id,
                cname = name
            };
            mdb.categories.Add(c);
            mdb.SaveChanges();
        }
        public static void Product()
        {
            Console.WriteLine("enter pid");
            int idd = int.Parse(Console.ReadLine());
            Console.WriteLine("enter title");
            string title = Console.ReadLine();
            Console.WriteLine("enter price");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter cid");
            int id = int.Parse(Console.ReadLine());
            var p = new Product
            {
                pid = idd,
                title = title,
                price = price,
                category_cid=id
         
            };
            mdb.Products.Add(p);
            mdb.SaveChanges();
        }
        private static void Category1()
        {
            Console.WriteLine("Categories");
            var ct = mdb.categories;
            foreach (var t in ct)
            {
                Console.WriteLine("{0}\t{1}", t.cid, t.cname);
            }
        }
        private static void Product1()
        {
            Console.WriteLine("Products");
            var p = mdb.Products;
            foreach (var t in p)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", t.pid, t.title, t.price, t.category_cid);
            }
        }
       
    }
}

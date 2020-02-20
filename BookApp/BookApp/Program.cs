using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Program
    {
        public static void insertinitialdata()
        {
            Context t = new Context();
            var authors = new List<Author>
            {
                new Author{name="Ravinder",address="punjab"},
                new Author{name="sudeep",address="mumbai"},
                new Author{name="preetyshenoy",address="delhi"},
                new Author{name="chethan",address="london"}
            };
            authors.ForEach(s => t.authors.Add(s));
            t.SaveChanges();
            var books = new List<Book>
            {
                new Book{title="Dreams",price=150},
                new Book{title="mahabarath",price=170},
                new Book{title="Ramayana",price=180},
                new Book{title="Githa",price=200}
            };
            books.ForEach(p => t.books.Add(p));
            t.SaveChanges();
            var details = new List<Detail>
            {
                new Detail{aid=1,bid=2 },
                new Detail{aid=2,bid=3 },
                new Detail{aid=3,bid=2 },
                new Detail{aid=3,bid=3 }
            };
            details.ForEach(d => t.details.Add(d));
            t.SaveChanges();
        }
        public static void show()
        {
            Context ct = new Context();
            var authors = ct.authors;
            Console.WriteLine("Author details");
            foreach (var p in authors)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.aid, p.name, p.address);
            }
            var books = ct.books;
            Console.WriteLine("Book details");
            foreach (var p in books)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.bid, p.title, p.price);
            }
            var details = ct.details;
            Console.WriteLine(" details");
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", "dtid", "bid", "name", "price", "aid", "name", "address");
            foreach (var p in details)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-14}{4,10}{5,8}{6,15}", p.id, p.bid, p.book.title, p.book.price, p.aid, p.author.name, p.author.address);
            }
        }
        static void Main(string[] args)
        {
            //insertinitialdata();
            show();
        }

    }
}


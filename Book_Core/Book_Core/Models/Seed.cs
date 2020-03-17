using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Core.Datalayer;
using Microsoft.Extensions.DependencyInjection;

namespace Book_Core.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book
                    {
                        Btitle = "Dreams",
                        Category = "Fiction",
                        Price = 100.00,
                        AuthorName = "Ravinder",
                        Publisher = "Penguin",
                        Releasedate = Convert.ToDateTime("10-09-2014")
                    },
                     new Book
                     {
                         Btitle = "In 105",
                         Category = "Thriller",
                         Price = 200.00,
                         AuthorName = "Chethan",
                         Publisher = "Penguin",
                         Releasedate = Convert.ToDateTime("10-10-2009")
                     }
                    );
                context.SaveChanges();
            }
        }
    }
}

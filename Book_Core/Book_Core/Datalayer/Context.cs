using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Core.Datalayer
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}

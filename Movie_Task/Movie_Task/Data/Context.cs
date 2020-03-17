using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movie_Task.Models;
using System.Data.Entity;


namespace Movie_Task.Data
{
    public class Context:DbContext
    { 
        
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theater> Theaters { get; set; }
    }
       
    
}
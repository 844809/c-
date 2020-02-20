using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Efcodefirstdemo
{
    class Employecontext :DbContext
    {
       public DbSet<Employe> Employees { get; set; }
    }
}

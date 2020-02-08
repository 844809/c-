using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk3
{
    class Program
    {
        static void Main(string[] args)
        {
            Proper p = new Proper();
            p.Name = "Teja";
            p.Idno = 3549;
            p.Course = "c#";
           // p.Joindate = DateTime.Parse("11-29-1997");
            p.Joindate = Convert.ToDateTime("11-03-1997");
            Console.WriteLine("name is {0}\nID is {1}", p.Name, p.Idno);
            Console.WriteLine("course:{0}\nJoining date:{1}", p.Course, p.Joindate.ToString("dd-MM-yyyy"));
        }
    }
}

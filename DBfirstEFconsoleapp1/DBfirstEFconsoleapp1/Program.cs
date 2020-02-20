using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBfirstEFconsoleapp1
{
    class Program
    {
        static EmployeDBEntities5 mdb = new EmployeDBEntities5();
        static void Main(string[] args)
        {
            //department();
            //Departmnt();
           // department1();
            Departmnt1();
        }

        private static void department1()
        {
            Console.WriteLine("enter depid");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter  depname");
            string name = Console.ReadLine();
            Console.WriteLine("enter description");
            string des = Console.ReadLine();
            var dp = new department
            {
                depID = id,
                deptName = name,
                description=des
            };
            mdb.departments.Add(dp);
            mdb.SaveChanges();

        }

        private static void Departmnt1()
        {
            Console.WriteLine("enter dep id");
            string idd = (Console.ReadLine());
            Console.WriteLine("enter dep name");
            string namee = Console.ReadLine();
            var Dp = new Departmnt
            {
                Did = idd,
                Dname = namee
            };
            mdb.Departmnts.Add(Dp);
            mdb.SaveChanges();
        }

        private static void department()
        {
            Console.WriteLine("department...");
            var dp = mdb.departments;
            foreach (var t in dp)
            {
                Console.WriteLine("{0}\t{1}\t{2}", t.depID,t.deptName,t.description);
            }
        }

        private static void Departmnt()
        {
            Console.WriteLine("Departmnt");
            var Dpp = mdb.Departmnts;
            foreach (var t in Dpp)
            {
                Console.WriteLine("{0}\t{1}", t.Did, t.Dname);
            }
        }
    }
}

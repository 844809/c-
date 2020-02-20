using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcodefirstdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // insertdata();
            //showdata();
            //Console.WriteLine("enter id");
            //int i = int.Parse(Console.ReadLine());
            //search(i);
            // Console.WriteLine("enter new designation");
            //string desg = Console.ReadLine();
            //update(i,desg);
            //delete();
            Console.WriteLine("1->insert\n2->show\n3->search\n4->update\n5->delete");
            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    insertdata();
                    break;
                case 2:
                    showdata();
                    break;
                case 3:
                    search();
                    break;
                case 4:
                    update();
                    break;
                case 5:
                    delete();
                    break;
            }

        }


        private static void insertdata()
        {
            Employecontext ect = new Employecontext();
            Console.WriteLine("enter Employe id");
            int eid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter Employee Designation");
            string Desg = Console.ReadLine();
            Console.WriteLine("enter salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            ect.Employees.Add(new Employe { Eid = eid, Ename = name, Designation = Desg, salary = sal });
            Console.ReadKey();
            ect.SaveChanges();
        }
        private static void showdata()
        {
            Employecontext emp = new Employecontext();

            //var emp1 = from e in empctx.Employees;

            var employees = emp.Employees;
            foreach (var ep in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", ep.Eid, ep.Ename, ep.Designation, ep.salary);
            }
        }
        private static void search()
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Employecontext empctx = new Employecontext();

            //var emp1 = from e in empctx.Employees;

            var employees = from d in empctx.Employees
                            where d.Eid == id
                            select d;
            foreach(var res in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", res.Eid, res.Ename, res.Designation, res.salary);
            }
        }
        private static void update()
        {
            Console.WriteLine("enter id");
            int eid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter designation");
            string desg = Console.ReadLine();
            Employecontext empctx = new Employecontext();

            //var emp1 = from e in empctx.Employees;

            var employees = from d in empctx.Employees
                            where d.Eid == eid
                            select d;
            foreach(var d in employees)
            {
                d.Designation = desg;
            }
            empctx.SaveChanges();
        }
        private static void delete()
        {
            Console.WriteLine("enter id");
            int i = int.Parse(Console.ReadLine());
            Employecontext e = new Employecontext();
            var del = e.Employees.Find(i);
            e.Employees.Remove(del);
            e.SaveChanges();
        }
    }

        
    
    
}

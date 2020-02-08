using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task15
{
    class employee
    {
        public int eid;
        public string ename;
        public string designation;
        public double salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> lst = new List<employee>();
            lst.Add(new employee { eid = 1, ename = "Ambica", designation = "PAT", salary = 22000 });
            lst.Add(new employee { eid = 2, ename = "teju", designation = "PAT", salary = 22000 });
            lst.Add(new employee { eid = 3, ename = "vishnu", designation = "PAT", salary = 22000 });
            lst.Add(new employee { eid = 4, ename = "Anu", designation = "PAT", salary = 22000 });

            foreach (employee e in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.eid, e.ename, e.designation, e.salary);
            }
            lst.RemoveAt(2);
            Console.WriteLine();
            foreach (employee e in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e.eid, e.ename, e.designation, e.salary);
            }
        }
    }
}

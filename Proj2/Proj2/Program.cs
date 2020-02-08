using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2
{
    class Student
    {
        public int ID { get; set; }
        public string SName { get; set; }
        public string course { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);
            Multiply(6, 7);
            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine("sum:{0}", ad(3, 4));
            List<Student> lst = new List<Student>
{
new Student{ID=1,SName="Aravind",course="c#"},
new Student{ID=2,SName="hari",course="py"},
new Student{ID=3,SName="giri",course="java"},
new Student{ID=4,SName="uma",course="go"}
};
            lst.Sort((a,b)=>a.ID.CompareTo(b.ID));
            foreach (var s in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.ID, s.SName, s.course);
            }
            Predicate<Student> fst = x => x.ID == 3;
            var st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.SName, st.course);
        }
    }
    
}

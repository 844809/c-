using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Exam
    {
        //data fields
         string name, id, center;//instance variables
         int marks;
        public void Getdata(string nm, string id, string cent, int mks)
        {
            name = nm;
            this.id = id;
            center = cent;
            marks = mks;
        }
        public void Showdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + center);
            Console.WriteLine(marks);
            Console.WriteLine();
        }
    }
}

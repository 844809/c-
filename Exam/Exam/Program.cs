using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam e = new Exam();
            e.Getdata("teja", "3549", "srm", 100);
            e.Showdata();
        }
    }
}

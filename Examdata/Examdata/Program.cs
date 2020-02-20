using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examdata
{
    class Program
    {
        static datamodexamContainer efc = new datamodexamContainer();
        static void Main(string[] args)
        {
            courseshow();
            examsshow();
            schoolshow();
            invigilatorshow();
            subjectshow();
            var students = efc.Students;
            foreach (var c in students)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", c.stid, c.sname, c.Course.cname, c.School.Slocation, c.School.ScId);
            }

        }

        private static void subjectshow()
        {
            var subject = efc.Subjects;
            foreach (var c in subject)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.suid, c.sname, c.Course.cid);
            }
        }

        private static void invigilatorshow()
        {
            var invigilator = efc.Invigilators;
            foreach (var c in invigilator)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.Iid, c.Iname, c.School.Slocation);
            }
        }

        private static void schoolshow()
        {
            var school = efc.Schools;
            foreach (var c in school)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.ScId, c.Sname, c.Slocation);
            }
        }

        private static void examsshow()
        {
            var exams = efc.Exams;
            foreach (var c in exams)
            {
                Console.WriteLine("{0}\t{1}\t", c.Eid, c.School.Slocation);
            }
        }

        private static void courseshow()
        {
            var cources = efc.Courses;
            foreach (var c in cources)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.cid, c.cname, c.School.ScId);
            }
        }
    }
}

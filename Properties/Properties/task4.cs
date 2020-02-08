using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class task4
    {
        string fname;
        string Lname;
        string name;
        int idno;
        string course;
        DateTime joindate; 
        public task4(string fname,string lname)
        {
            this.fname = fname;
            Lname = lname;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Idno
        {
            get { return idno; }
            set { idno = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }
    }
}

    


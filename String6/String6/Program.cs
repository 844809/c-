using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String6
{
    struct Mobile
    {
        public string mobilename;
        public string model;
        public string color;

    }
    class Tot
    {
        public string name;
        public int id;
        public int marks;
        public void details(string Name,int Id,int Marks)
        {
            name = Name;
            id = Id;
            marks = Marks;
            Console.WriteLine("Name is:{0}\nId is:{1}\nMarks are:{2}", name, id, marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tot t = new Tot();
            t.details("teju", 3549, 98);
            Mobile m1;
            m1.mobilename = "honor";
            m1.model = "chleo";
            m1.color = "black";
            Console.WriteLine("Name is:"+m1.mobilename+ " Model is: " +m1.model+ " color is:" +m1.color);

        }
    }
}

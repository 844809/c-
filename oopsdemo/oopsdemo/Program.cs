using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //object of trainee class
            get1();
            get3();
            get2();
        }

        private static void get3()
        {
            trainee tr1 = new trainee();
            tr1.Getdata("siri", "1918", "Andhra pradesh", 22);
            tr1.Showdata();
        }

        private static void get2()
        {
            trainee tr2 = new trainee();
            tr2.Getdata("ambi", "6319", "Andhra pradesh", 21);
            tr2.age = 12;
            tr2.address = "up";
            tr2.Showdata();
        }

        private static void get1()
        {
            trainee tr = new trainee();
            tr.Getdata("teja", "Emp3549", "Andhra pradesh", 21);
            tr.Showdata();
        }
    }
}

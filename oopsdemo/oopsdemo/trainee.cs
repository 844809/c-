using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsdemo
{
    class trainee
    {
        //data fields
        public string name, id, address;//instance variables
         public int age;
         public void Getdata(string nm,string id,string adr,int ag)
        {
            name = nm;
            this.id = id;
            address = adr;
            age = ag;
        }
         public void Showdata()
        {
            Console.WriteLine(name);
            Console.WriteLine(id + " " + address);
            Console.WriteLine(age);
            Console.WriteLine();
        }

    }
}

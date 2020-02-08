using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            //arraylist();
            Hashtable hst = new Hashtable();
            hst.Add("raju", 12345);
            hst.Add("karan", 5678);
            hst.Add("arjun", 6789);
            foreach(string k in hst.Values)
            {
                Console.WriteLine(k);
            }
            hst.Remove("karan");
            ArrayList al = new ArrayList() { "teja", "ambi", "vishnu", "siri" };
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("akhil");
            al.Add("shri");
            al.Insert(4, "siva");
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Reverse();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "cat", "mat" };
            al.SetRange(4, r);
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2, 2);
            Console.WriteLine();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
        }
    }
}

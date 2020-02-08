using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fileoperation1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\hi.txt";
            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter yout name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your id");
                    string Id = Console.ReadLine();
                    sw.WriteLine("name" + name);
                    sw.WriteLine("Id" + Id);
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("enter some text");
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("deleting file");
            File.Delete(path);
        }
    }
}

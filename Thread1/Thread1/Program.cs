using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getnumbers);
            Thread th = new Thread(tsd);
            th.Start();

            ThreadStart sd = new ThreadStart(GetEven);
            Thread h = new Thread(sd);
            h.Start();
        }
        public static void getnumbers()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}", i);
                Thread.Sleep(100);
            }
        }
        public static void GetEven()
        {
            for(int i=1;i<=10;i++)
            {
                if (i % 2 == 0)
                {

                    Console.WriteLine("{0}", i);
                    Thread.Sleep(300);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numav
{
    class Program
    {
        public static double getavg (int[]a)
        {
            double sum = 0;
            double avg = 0;
            foreach(int i in a)
            {
                sum = sum + i;
                avg = sum / a.Length;
            }
            return avg;   
        }
        static void Main(string[] args)
        {
            int[] marks = new int[] { 90, 87, 54, 23 };
            double avg = getavg(marks);
           Console.WriteLine("marks {0}",avg);
            
        }
    }
}

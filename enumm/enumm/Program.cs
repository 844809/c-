using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of Monday:{0}",(int)WeekDays.Monday);
            Console.WriteLine("value of Friday:{0}",(int)WeekDays.Friday);
        }
        enum WeekDays
        {
            Monday = 10,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        
    }
}

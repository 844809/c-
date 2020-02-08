using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Productt pd = new Productt {Id=1,Pname="milkshake",Price=240 };
            Console.WriteLine("{0}\n{1}\n{2}", pd.Id, pd.Pname, pd.Price);
        }
    }
}

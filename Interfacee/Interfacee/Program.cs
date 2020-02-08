using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacee
{
    public interface laiborne
    {
        void fly();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Helicopter h = new Helicopter();
            h.fly();
            Aeroplane a = new Aeroplane();
            a.fly();
        }
    }
}

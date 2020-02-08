using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class car
    {
        string regno;
        string model;
        string color;
        double price;
        public car() { } //default constructor
        public car(string reg) //overload
        {
            regno = reg;
        }
        public car(string reg,string mod)
        {
            regno = reg;
            model = mod;
        }
        public car(string reg, string mod,string colr)
        {
            regno = reg;
            model = mod;
            color = colr;
        }
        public car(string reg,string mod,string colr,double pr)
        {
            regno = reg;
            model = mod;
            color = colr;
            price = pr;
        }
       // public void Showcar()
       public string Showcar()
        {
            return string.Format("Rega no:{0}\nModel is {1}\nColor:{2}\nPrice{3}", regno, model, color, price);
           /* Console.WriteLine("Reg no is:" + regno);
            Console.WriteLine("Model is:" + model);
            Console.WriteLine("color is:" + color);
            Console.WriteLine("price is:" + price);
            Console.WriteLine();*/

        }

    }
}

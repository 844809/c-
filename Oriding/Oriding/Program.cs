using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer
            {
                Id = 123,
                Name = "teju",
                Address = "chennai",

            };



            Bankaccounts b = new Bankaccounts
            {
                accno = 215646312,
                accbal = 1000,

            };
            Console.WriteLine("customer id ={0}\nname ={1}\naddress={2}\naccount number ={3}\nbalance ={4}", c.Id, c.Name, c.Address, b.accno, b.accbal);
            Console.WriteLine("simple interest " + b.Si());

            Fixed f = new Fixed();
            Console.WriteLine("simple interest plus 3" + f.Si());
        }
    }
}

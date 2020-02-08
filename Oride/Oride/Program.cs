using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oride
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee
            {
                Id = 1,
                Name = "Tejasri",
                Address = "bluelotus",
            };
            Console.WriteLine("Employee id:{0}\name:{1}\nAddress:{2}\n", e.Id, e.Name, e.Address);
            Console.WriteLine("salary is {0}\n", e.Empsalary(24000));
        }
    }
}

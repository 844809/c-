using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oride
{
    class Employee
    {
        int id;
        string address;
        string name;
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public virtual string Empsalary(double salary)
        {
            return salary.ToString();
        }
    }
}

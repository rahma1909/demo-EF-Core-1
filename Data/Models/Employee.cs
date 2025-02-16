using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Data.Models
{
    //poco class
    //plain old c# (clr) obj

    internal class Employee
    {
        public int Id { get; set; } //pk
        public required string  Name { get; set; } //reference type
        public int? Age { get; set; }
        public double Salary { get; set; }//nullable value type =>allow null
    }
}

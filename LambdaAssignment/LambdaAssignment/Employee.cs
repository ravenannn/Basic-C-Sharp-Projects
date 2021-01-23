using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Employee
    {
        // Create first name, last name, and ID properties
        public string last { get; set; }
        public string first { get; set; }
        public int id { get; set; }

        public Employee(string firstName, string lastName, int ID)
        {
            first = firstName;
            last = lastName;
            id = ID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate and initialize an Employee object with first name of "Sample" and last name of "Student"
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "Sample";
            newEmployee.LastName = "Student";

            // Call the superclass method SayName() on the employee object
            newEmployee.SayName();

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee newEmployee = new Employee();
            newEmployee.firstName = "Sample";
            newEmployee.lastName = "Student";

            // Call SayName() method on the object
            newEmployee.SayName();

            Console.ReadLine();
        }
    }
}

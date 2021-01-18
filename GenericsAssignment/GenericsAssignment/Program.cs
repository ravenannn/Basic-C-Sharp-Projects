using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employeeDept = new Employee<string>();
            employeeDept.things = new List<string>() { "HR", "Recruiting", "Management", "Payroll", "Sales", "Customer Service" };
            

            Employee<int> employeeAges = new Employee<int>();
            employeeAges.things = new List<int>() { 22, 16, 18, 34, 36, 21 };

            foreach (string thing in employeeDept.things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employeeAges.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}

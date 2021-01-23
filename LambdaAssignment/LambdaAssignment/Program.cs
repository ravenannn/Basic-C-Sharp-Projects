using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create list of 10 employees. Each should have first name, last name, and Id.
            List<Employee> Employees = new List<Employee>();
            List<string> firstNames = new List<string>()
            {
                "Joe", "John", "Karen", "Peter", "Joe", "Sarah", "Sierra", "Kevin", "Levi", "Mike"
            };

            List<string> lastNames = new List<string>()
            {
                "Smith", "Hunter", "Spear", "Bryan", "Franklin", "Johnson", "Shultz", "Beard", "Henson", "Tolliver"
            };

            List<int> IDs = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

          
            for (int i = 0; i < firstNames.Count; i++)
            {
                Employees.Add(new Employee(firstNames[i], lastNames[i], IDs[i]));
            }


            //Use foreach to create a new list of all employees with the first name Joe
            //List<Employee> Joes = new List<Employee>();
            //foreach (Employee employee in Employees)
            //{
            //    if (employee.first == "Joe")
            //    {
            //        Joes.Add(employee);
            //    }
            //}

            // Display employees named "Joe" from list of Joes
            //foreach (var joe in Joes)
            //{
            //    Console.WriteLine("An employee named Joe is: " + joe.first + " " + joe.last + " ID Number " + joe.id);
            //}

            // Use Lambda expression to create a new list of employees with the first name Joe
            var Joes = Employees.Where(x => x.first == "Joe");
            foreach (var joe in Joes)
            {
                Console.WriteLine("An employee named Joe is: " + joe.first + " " + joe.last + " ID Number " + joe.id);
            }

            //Use Lambda expression to make a list of employees with an ID number greater than 5

            var idGreaterThan5 = Employees.Where(x => x.id > 5);
            foreach (var person in idGreaterThan5)
            {
                Console.WriteLine("An employee with an ID Number greater than 5 is: " + person.first + " " + person.last + " ID: " + person.id);
            }

            Console.ReadLine();
        }
    }
}
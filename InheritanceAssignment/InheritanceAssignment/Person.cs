using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class Person
    {
        // Give Person class two properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create void method that takes no params and writes full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}

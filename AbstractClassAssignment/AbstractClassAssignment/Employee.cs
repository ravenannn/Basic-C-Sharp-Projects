using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{   
    // Have class inherit from Person class
    public class Employee : Person
    {   
        // Implement SayName() Method from Person Class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); 
        }

    }
}

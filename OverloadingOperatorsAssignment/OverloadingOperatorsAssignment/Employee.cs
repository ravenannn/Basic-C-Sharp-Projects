using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsAssignment
{   
    // Have class inherit from Person class
    public class Employee : Person
    {
        // create property call ID of data type int
        public int ID { get; set; }

        // Implement SayName() Method from Person Class
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); 
        }


        // Overload the "==" operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return true;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.ID = 23456;
            Employee employee2 = new Employee();
            employee2.ID = 67890;

            Console.WriteLine(employee1.ID == employee2.ID);

            Console.ReadLine();
           
        }
    }
}

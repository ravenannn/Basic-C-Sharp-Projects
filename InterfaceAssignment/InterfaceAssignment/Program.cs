using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            IQuittable quit = new Employee();

            // Call the Quit() method on it
            quit.Quit();

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        // Create a struct called Number
        struct Number
        {
            // Give it a property Amount with data type decimal
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            // Create an object of data type Number
            Number num;

            // Assign an amount to it
            num.Amount = 342;

            // Print the amoutn to the console
            Console.WriteLine(num.Amount);

            Console.ReadLine();
            
        }
    }
}

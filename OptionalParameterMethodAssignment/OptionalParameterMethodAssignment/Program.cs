using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations solveMath = new MathOperations();

            Console.WriteLine("Please choose a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a second number if you'd like: ");
            string optionalNum2 = Console.ReadLine();
            int convertedNum2 = 0;

            if (optionalNum2.Length > 0)
            {
                convertedNum2 = Convert.ToInt32(optionalNum2);
            }
            
            

            int addedNums = solveMath.mathOperations(num1, convertedNum2);
            Console.WriteLine("Your chosen number(s) added to ten equal: " + addedNums);
            Console.ReadLine();
        }
    }
}

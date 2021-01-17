using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Void method that outputs an integer
            Console.WriteLine("Please choose a number: ");
            int intOne = Convert.ToInt32(Console.ReadLine());

            MathOperations divide = new MathOperations();
            divide.divideByTwo(intOne);

            // Overloaded Method
            MathOperations a = new MathOperations();
            double length = 3.3;
            double breadth = 4.9;
            double rect = a.area(length, breadth);
            Console.WriteLine("Area of a rectangle is: " + rect);

            double side = 3.3;
            double square = a.area(side);
            Console.WriteLine("Area of a square is: " + square);

            // Display info from method with output params
            int initializeInMethod;
            MathOperations outParams = new MathOperations();
            outParams.outArgExample(out initializeInMethod);
            Console.WriteLine(initializeInMethod);

            // Display info from static class
            Console.WriteLine(myCollege.CollegeName);
            Console.WriteLine(myCollege.Location);


            Console.ReadLine();
        }
    }
}

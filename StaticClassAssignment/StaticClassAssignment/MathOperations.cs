using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAssignment
{
    class MathOperations
    {
        // Create a void method
        public void divideByTwo(int intOne)
        {
            int divided = intOne / 2;
            Console.WriteLine(intOne + " divided by 2 is: " + divided);
        }

        // Overload a method
        public double area(double s)
        {
            double area = s * s;
            return area;
        }

        public double area(double l, double b)
        {
            double area = l * b;
            return area;
        }

        // Create method with output parameters
        public void outArgExample(out int number)
        {
            number = 44;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations returnInt = new MathOperations();
            int intOne = 3;
            int intTwo = 5;

            returnInt.mathOperations(intOne, intTwo);
            returnInt.mathOperations(3, 5);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;


namespace ClassesAndMethodsAssignment
{
    public class MathOperations
    {
       

        public void Add12(int chosenNum)
        {
            int added = 12 + chosenNum;
            Console.WriteLine(chosenNum + " plus 12 equals: " + added);
        }

        public void Mult3(int chosenNum)
        {
            int multiplied = 3 * chosenNum;
            Console.WriteLine(chosenNum + " multiplied by 3 equals: " + multiplied);
        }

        public void Sub10(int chosenNum)
        {
            int subtracted = chosenNum - 10;
            Console.WriteLine(chosenNum + " minus 10 equals: " + subtracted);
        }
    }
}

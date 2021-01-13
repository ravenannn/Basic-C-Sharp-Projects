using System;


namespace MathOperatorsAndComparisonAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a number:");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());
            int multBy50 = inputNum1 * 50;
            Console.WriteLine(inputNum1 + " multiplied by 50 is: " + multBy50);

            Console.WriteLine("Choose another number:");
            int inputNum2 = Convert.ToInt32(Console.ReadLine());
            int add25 = inputNum2 + 25;
            Console.WriteLine(inputNum2 + " plus 25 is: " + add25);

            Console.WriteLine("Choose another number:");
            double inputNum3 = Convert.ToDouble(Console.ReadLine());
            double div12Point5 = inputNum3 / 12.5;
            Console.WriteLine(inputNum3 + " divided by 12.5 is: " + div12Point5);

            Console.WriteLine("Choose another number:");
            int inputNum4 = Convert.ToInt32(Console.ReadLine());
            bool isGreaterThan50 = inputNum4 > 50;
            Console.WriteLine(inputNum4 + " is greater than 50: " + isGreaterThan50);

            Console.WriteLine("Choose another number:");
            double inputNum5 = Convert.ToDouble(Console.ReadLine());
            double divBy7 = inputNum5 % 7;
            Console.WriteLine(inputNum5 + " divided by 7 has a remainder of: " + divBy7);

            Console.ReadLine();

        }
    }
}

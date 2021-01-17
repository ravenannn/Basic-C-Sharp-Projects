using System;


namespace ClassesAndMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            MathOperations mathProblem = new MathOperations();

            int add12Result = mathProblem.Add12(chosenNum);
            Console.WriteLine(chosenNum + " plus 12 equals: " + add12Result);
            int mult3Result = mathProblem.Mult3(chosenNum);
            Console.WriteLine(chosenNum + " multiplied by 3 equals: " + mult3Result);
            int sub10Result = mathProblem.Sub10(chosenNum);
            Console.WriteLine(chosenNum + " minus 10 equals: " + sub10Result);

            Console.ReadLine();
        }
        

    }
}

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

            mathProblem.Add12(chosenNum);
            mathProblem.Mult3(chosenNum);
            mathProblem.Sub10(chosenNum);

            Console.ReadLine();
        }
        

    }
}

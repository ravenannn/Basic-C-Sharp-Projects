using System;
using System.Collections.Generic;


namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of integers
            List<int> numbers = new List<int>() { 1, 2, 4, 5, 7, 9, 10, 12, 15, 20, 25, 30, 33, 40, 100, 250, 500 };
            try
            {

                // Ask user for number to divide each number in the list by.
                Console.WriteLine("Please choose a number: ");
                int chosenNum = Convert.ToInt32(Console.ReadLine());

                // Write a loop that takes each integer in list/divides it by the input number, display results
                for (int i = 0; i < numbers.Count; i++)
                {
                    int result = numbers[i] / chosenNum;
                    Console.WriteLine(numbers[i] + " divided by " + chosenNum + " equals: " + result);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program made it through the try/catch block.");
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Current date and time
            var currentDateTime = DateTime.Now;
            // Print current DateTime
            Console.WriteLine("Current date and time is: " + currentDateTime);

            // Ask user for a number
            Console.WriteLine("Please choose a number: ");

            // Convert and store user input as an integer
            int chosenNum = Convert.ToInt32(Console.ReadLine());

            // Print to console the time it will be in X hours, X being the user's input number
            Console.WriteLine("The date and time in " + chosenNum + " hours will be: " + currentDateTime.AddHours(chosenNum));

            Console.ReadLine();


        }
    }
}

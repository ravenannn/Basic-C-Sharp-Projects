using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        
        // Create an enum
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            try
            {

            // Prompt user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");
            string input = Console.ReadLine();
            var formattedInput = char.ToUpper(input[0]) + input.Substring(1);
            var parsed = Enum.Parse(typeof(DaysOfTheWeek), formattedInput);
            
            Console.WriteLine("You chose " + input);

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.WriteLine("The code successfully made it through this Try/Catch Block.");
                Console.ReadLine();
            }

        }
    }
    
}

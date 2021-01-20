using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedErrorCatchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Ask user for their age
                Console.WriteLine("How old will you turn this year?");
                int userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge <= 0)
                {
                    throw new NegativeAgeException();
                }
                // Get current DateTime
                var currentDate = DateTime.Now;

                // Subtract age in years from current date
                var userBorn = currentDate.AddYears(-userAge);

                //Display year user was born
                Console.WriteLine("You were born in the year: " + userBorn.Year);

            }
            catch (NegativeAgeException)
            {
                Console.WriteLine("Please enter an age greater than zero.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.");
            }

            

            Console.ReadLine();
        }
    }
}

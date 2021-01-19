using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number
            Console.WriteLine("Please choose a number: ");
            // Save input
            string chosenNum = Console.ReadLine();
            // Append input to the log
            using (StreamWriter file = new StreamWriter(@"C:\Users\raven\Logs\log2.txt", true))
            {
                file.WriteLine(chosenNum);
            }
            string text = File.ReadAllText(@"C:\Users\raven\Logs\log2.txt");
            Console.WriteLine(text);

            Console.ReadLine();
        }

    }
}

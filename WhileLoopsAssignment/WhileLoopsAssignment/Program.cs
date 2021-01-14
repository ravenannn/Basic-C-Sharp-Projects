using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();
            bool isGuessed = color == "purple";

            //boolean comparison using a do while statement
            do
            {
                switch (color)
                {
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "pink":
                        Console.WriteLine("You guessed pink. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "black":
                        Console.WriteLine("You guessed black. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. That's correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            // boolean comparison using a while statement
            while (isGuessed)
            {
                Console.WriteLine("You must be psychic!");
                isGuessed = false;
            }
            Console.Read();

        }
    }
}


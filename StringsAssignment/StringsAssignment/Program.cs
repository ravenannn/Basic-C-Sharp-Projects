using System;
using System.Text;


namespace StringsAssignment
{
    class Program
    {
        static void Main()
        {
            // Concatenate three strings
            string str1 = "Hi, my name";
            string str2 = "is Raven, and";
            string str3 = "I love the color purple.";
            string concatted = str1 + " " + str2 + " " + str3;
            Console.WriteLine(concatted);

            // Convert string to uppercase
            Console.WriteLine(concatted.ToUpper());

            // Create Stringbuilder and build a paragraph of text one sentence at a time
            StringBuilder sb = new StringBuilder("Hello, world!");
            sb.Append(" What a beautiful day.");
            sb.Append(" Would you like to go for a run?");
            sb.Append(" It may snow again next week.");

            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}

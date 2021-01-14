using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        //Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
        string[] stringArray = { "purple", "yellow", "blue", "green", "red", "orange", "pink", "black", "white" };
        Console.WriteLine("Choose a number:");
        int chosenStrIndex = Convert.ToInt32(Console.ReadLine());

        //Add in a message that displays when the user selects an index that doesn’t exist.
        if (chosenStrIndex > stringArray.Length - 1)
        {
            Console.WriteLine("Please choose a number between 0 and 8");
            chosenStrIndex = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Your favorite color is " + stringArray[chosenStrIndex] + "!");


        //Create a one-dimensional Array of integers.Ask the user to select an index of the Array and then display the integer at that index on the screen.
        int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };
        Console.WriteLine("Choose a number:");
        int chosenIntIndex = Convert.ToInt32(Console.ReadLine());

        //Add in a message that displays when the user selects an index that doesn’t exist.
        if (chosenIntIndex > numArray.Length - 1)
        {
            Console.WriteLine("Please choose a number between 0 and 6");
            chosenIntIndex = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Your lucky number is " + numArray[chosenIntIndex] + "!");
        

        //Create a list of strings. Ask the user to select an index of the list and then display the content at that index on the screen.
        List<string> stringList = new List<string>();
        stringList.Add("tiger");
        stringList.Add("bear");
        stringList.Add("elephant");
        stringList.Add("wolf");
        stringList.Add("snake");
        stringList.Add("owl");
        stringList.Add("monkey");
        stringList.Add("goldfish");

        Console.WriteLine("Choose a number:");
        int chosenListIndex = Convert.ToInt32(Console.ReadLine());

        //Add in a message that displays when the user selects an index that doesn’t exist.
        if (chosenListIndex > stringList.Count - 1)
        {
            Console.WriteLine("Please choose a number between 0 and 7");
            chosenListIndex = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Your spirit animal is a/an " + stringList[chosenListIndex] + "!");



        Console.ReadLine();
        }
    }


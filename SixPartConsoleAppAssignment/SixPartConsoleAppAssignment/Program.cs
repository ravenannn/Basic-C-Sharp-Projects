using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Program
    {
    static void Main(string[] args)
    {
        // ********* Console App Assignment Part 1 ********

        // Create one dimensional array of strings
        string[] colors = { "red", "blue", "green", "yellow", "pink", "purple", "orange", "black", "brown" };

        // Ask user to input some text
        Console.WriteLine("Please enter your favorite type of car:");
        // Store favorite animal in a variable
        string favCar = Console.ReadLine();

        // Create loop that iterates through each string in the array and adds the user's text input to the end of each string.
        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = colors[i] + " " + favCar;
        }
        // Create loop that prints off each string in the array on a separate line
        for (int j = 0; j < colors.Length; j++)
        {
            Console.WriteLine(colors[j]);

        }

        // ****** Console App Assignment Pt. 2 *******

        // Create infinite loop
        //bool isTrue = true;

        //while (isTrue = true)
        //{
        //    Console.WriteLine(isTrue);
        //}

        // Fix infinite loop so it will execute properly
        bool isTrue = true;

        while (isTrue == true)
        {
            Console.WriteLine(isTrue);
            break;
        }


        // ********* Console App Assignment Part 3 ***********

        // Create loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator
        int[] ages = { 7, 2, 8, 4, 5, 12, 16, 18, 1 };

        for (int k = 0; k < ages.Length; k++)
        {
            if (ages[k] < 13)
            {
                Console.WriteLine(ages[k] + ": You are able to order from the Children's Menu.");
            }
        }

        // Create loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator
        for (int m = 0; m < ages.Length; m++)
        {
            if (ages[m] <= 3)
            {
                Console.WriteLine(ages[m] + ": This child will recieve free admission.");
            }
        }


        // ****** Console App Assignment Part 4 ***********

        // Create list of strings where each item in the list is unique
        List<string> animals = new List<string>() { "dog", "cat", "bird", "snake", "hampster", "hedgehog", "chinchilla", "lizard", "goldfish" };

        // Ask user to input text to search for in the list
        Console.WriteLine("Please choose a type of pet:");
        string chosenPet = Console.ReadLine();
        

        // Create a loop that iterates through the list then displays the index of the list that contains matching text on the screen
        // Add code to the loop to check if the user put in text that isn't on the list and if so, tells the user their input isn't on the list
        // Add code to the loop that stops it from executing once a match has been found


        for (int b = 0; b < animals.Count; b++)
        {
            int result = animals.IndexOf(chosenPet);

            if (result != -1)
            {
                int index = animals.FindIndex(str => str.Contains(chosenPet));
                Console.WriteLine(chosenPet + " is found at the index of " + index);
                break;
            }
            else
            {
                Console.WriteLine("Sorry, " + chosenPet + " is not on our list.");
                break;
            }
        }





        //********* Console App Assignment Pt 5 ************

        //Create a list of strings that has at least 2 identical strings in the list
        List<string> dwarfs = new List<string>() { "Grumpy", "Dopey", "Bashful", "Happy", "Grumpy", "Doc", "Sneezy", "Sneezy", "Bashful", "Sleepy" };

        // Ask user to select  text to search for in the list
        Console.WriteLine("Please choose one of Snow White's seven dwarfs: ");
        string chosenDwarf = Console.ReadLine();

        // Create loop that iterates through list and displays the indices of the list that contain matching text on the screen
        List<int> dwarfIndices = new List<int>();
        for (int d = 0; d < dwarfs.Count; d++)
        {
            // Add code to loop to check if user put in text not on list and tells user it is not on list
            int result = dwarfs.IndexOf(chosenDwarf);

            if (result == -1)
            {
                Console.WriteLine("Sorry, " + chosenDwarf + " is not one of Snow White's seven dwarfs.");
                break;
            }
            if (dwarfs[d] == chosenDwarf)
            {
                dwarfIndices.Add(d);
            }
           
            
        }
        foreach (int index in dwarfIndices)
        {
            Console.WriteLine(chosenDwarf + " is found at the following index: " + index);
        }


        



        // ******** Console App Part 6 *************

        //Create list of strings that has at least 2 identical strings
        List<string> names = new List<string>() { "Jane", "Mary", "Adam", "Mary", "Collette", "Sarah", "Sarah", "Jason", "Joe", "Mark" };
        // Create foreach loop that evaluates each item in the list and displays message showing the string and whether or not it has appeared in the list already
        var repeatedNames = names.ToArray();

        var duplicates = repeatedNames
            .GroupBy(i => i)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);

        foreach (var d in duplicates)
        {
            Console.WriteLine("Names that are repeated in list: " + d);

        }

        Console.ReadLine();

    }
}





using System;


namespace ApprovalProgramAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Your application must ask these questions:
            //What is your age ?
            Console.WriteLine("What is your age?");
            byte age = Convert.ToByte(Console.ReadLine());
            //Have you ever had a DUI?
            Console.WriteLine("Have you ever had a DUI - true or false?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            //How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets do you have?");
            byte tickets = Convert.ToByte(Console.ReadLine());
            //2) Use the following qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            bool oldEnough = age > 15;
            //Applicants must not have any DUI’s.
            bool noDui = dui == false;
            //Applicants must not have more than 3 speeding tickets.
            bool lessTickets = tickets <= 3;
            //3) Print the result of the boolean expression created from the above business rules.
            Console.WriteLine("Qualified?");
            bool qualified = oldEnough == true && noDui == true && lessTickets == true;
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}

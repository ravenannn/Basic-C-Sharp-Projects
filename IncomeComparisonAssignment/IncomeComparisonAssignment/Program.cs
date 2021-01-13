using System;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main()
        {
            // Print Anonymous Income Comparison Program to screen
            Console.WriteLine("Anonymous Income Comparison Program");
            // Print Person 1 to Screen and
            Console.WriteLine("Person 1");
            // get hourly rate
            Console.WriteLine("Hourly Rate?");
            decimal person1Rate = Convert.ToDecimal(Console.ReadLine());
            // get hours worked per week
            Console.WriteLine("Hours worked per week?");
            decimal person1Hours = Convert.ToDecimal(Console.ReadLine());
            // Print Person 2 to Screen and
            Console.WriteLine("Person 2");
            // get hourly rate
            Console.WriteLine("Hourly Rate?");
            decimal person2Rate = Convert.ToDecimal(Console.ReadLine());
            // get hours worked per week
            Console.WriteLine("Hours worked per week?");
            decimal person2Hours = Convert.ToDecimal(Console.ReadLine());
            // Print to Screen Annual Salary of Person 1 and
            Console.WriteLine("Annual salary of Person 1:");
            // display exact salary below
            decimal person1WeeklyPay = person1Rate * person1Hours;
            decimal person1Salary = person1WeeklyPay * 52;
            Console.WriteLine(person1Salary);
            // Print to screen Annual Salary of Person 2 and
            Console.WriteLine("Annual salary of Person 2:");
            // display exact salary below
            decimal person2WeeklyPay = person2Rate * person2Hours;
            decimal person2Salary = person2WeeklyPay * 52;
            Console.WriteLine(person2Salary);
            // Print to screen Does Person 1 make more money than Person 2?
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            // Display true or false below
            bool person1Greater = person1Salary > person2Salary;
            Console.WriteLine(person1Greater);
            Console.ReadLine();
        }
    }
}

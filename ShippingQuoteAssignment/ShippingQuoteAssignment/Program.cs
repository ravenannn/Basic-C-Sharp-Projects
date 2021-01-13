using System;


namespace ShippingQuoteAssignment
{
    class Program
    {
        static void Main()
        {
            //1.The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
            //2.The user must then be prompted for the package weight.
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());
            //3.If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                //4.The user must then be prompted for the package width.
                Console.WriteLine("Please enter the package width:");
                float width = Convert.ToSingle(Console.ReadLine());
                //5.Then the package height.
                Console.WriteLine("Please enter the package height:");
                float height = Convert.ToSingle(Console.ReadLine());
                //6.Then the package length.
                Console.WriteLine("Please enter the package length:");
                float length = Convert.ToSingle(Console.ReadLine());

                float addedDimension = width + length + height;
                if (addedDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    float multDimensionTotal = length * width * height;
                    decimal shippingTotal = Convert.ToDecimal(multDimensionTotal * weight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + shippingTotal.ToString("0.00"));
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();


            


            


            //7.If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.


            //8.Next, multiply the three dimensions(height, width, &length) together, and multiply the product by the weight.Finally, divide the outcome by 100.


            //9.The result of that calculation is the quote.


            //10.Display the quote to the user as a dollar amount.
        }
    }
}

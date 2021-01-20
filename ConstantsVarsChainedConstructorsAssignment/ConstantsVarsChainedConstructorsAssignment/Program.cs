using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsVarsChainedConstructorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a constant variable
            const string shopName = "Pups N' Suds";
            Console.WriteLine(shopName);

            // Create a variable using keyword var
            // This Pet also demonstrates the chained constructors
            var pet = new Pet("Lucky");
            Console.ReadLine();

           
        }
    }
}

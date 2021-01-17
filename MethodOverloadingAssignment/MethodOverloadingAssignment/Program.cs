using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations divided = new MathOperations();
            int intValue = 10;
            int intValResult = divided.mathOperations(intValue);
            Console.WriteLine(intValue + " divided by 2 equals: " + intValResult);
            
            MathOperations added = new MathOperations();
            decimal decValue = 5.5m;
            int decValResult = Convert.ToInt32(added.mathOperations(decValue));
            Console.WriteLine(decValue + " plus 10 equals: " + decValResult);

            MathOperations multiplied = new MathOperations();
            string strValue = "3";
            int strValResult = multiplied.mathOperations(strValue);
            Console.WriteLine(strValue + " multiplied by 5 equals: " + strValResult);

            Console.ReadLine();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterMethodAssignment
{
    class MathOperations
    {
        public int mathOperations(int num1, int optionalNum2)
        {
          
            int optionalAdded = num1 + optionalNum2;
            int addTen = 10 + optionalAdded;
            return addTen;
        }
               
    }
}


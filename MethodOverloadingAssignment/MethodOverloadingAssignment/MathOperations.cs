using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssignment
{
    public class MathOperations
    {
        public int mathOperations(int intValue)
        {
            int div2 = intValue / 2;
            return div2;
        }

        public decimal mathOperations(decimal decValue)
        {
            int add10 = Convert.ToInt32(decValue) + 10;
            return add10;
        }

        public int mathOperations(string strValue)
        {
            int mult5 = 5 * Convert.ToInt32(strValue);
            return mult5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("This employee has opted for voluntary termination.");
        }
    }
}

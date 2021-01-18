using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    // Have class inherit from Person class
    public class Employee<T> : Person
    {
        // create property call ID of data type int
        public int ID { get; set; }

        // create a property called "things" with data type generic list matching generic type of class
        public List<T> things { get; set; }


    }
}
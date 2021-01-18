using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsAssignment
{
    // Create an abstract class named Person
    public abstract class Person
    {
        // Give it two properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Create abstract method SayName()
        public abstract void SayName();



    }
}

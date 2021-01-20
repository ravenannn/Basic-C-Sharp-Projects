using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedErrorCatchingAssignment
{
    class NegativeAgeException : Exception
    {
        // Create two constructors that will inherit from base exception
        public NegativeAgeException()
            //inheriting from the base exception
            : base() { }
        public NegativeAgeException(string message)
            : base(message) { }
    }
}

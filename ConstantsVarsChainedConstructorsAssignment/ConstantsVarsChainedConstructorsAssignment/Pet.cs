using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsVarsChainedConstructorsAssignment
{
    class Pet
    {
        // Chained Constructor - automatically sets needsBath to true upon creation of pet 
        public Pet(string name) : this(name, true)
        {

        }
        public Pet(string name, bool needsBath)
        {
            Name = name;
            NeedsBath = needsBath;
        }

       
        public int Age { get; set; }
        public string Name { get; set; }
        public bool NeedsBath { get; set; }
    }
}

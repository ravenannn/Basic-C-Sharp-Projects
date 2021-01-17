using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAssignment
{
    static class myCollege
    {
        //static fields
        public static string CollegeName;
        public static string Location;

        // static construction
        static myCollege()
        {
            CollegeName = "The Tech Academy";
            Location = "Portland, OR";
        }

    }
}

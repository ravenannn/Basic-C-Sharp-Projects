using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAppChallenge

{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var newStudent = new Student()
                {
                    firstName = "Sierra",
                    lastName = "Miller",
                    DateOfBirth = "11/12/2007",
                    Height = 5.2m,
                    Weight = 110
                };

                ctx.Students.Add(newStudent);
                ctx.SaveChanges();
            }
        }
    }
}

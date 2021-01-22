using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstAppChallenge
{
    public class Student
    {
        public int StudentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

    }
}

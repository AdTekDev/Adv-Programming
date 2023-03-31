using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w010201
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public float  Grade { get; set; }

        public Student(string fn, string ln, int y = 21, float diem=0) {
            FirstName = fn; 
            LastName = ln; 
            Age = y;
            Grade = diem;
        }
    }
}

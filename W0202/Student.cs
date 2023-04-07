
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w020201school
{
    public class Student : Person {
        public School school {get; set;} 

        public Student(string ten, string diachi, string tentruong) {
            this.Address = diachi;
            this.Name = ten;
            this.school = new School(tentruong);
        }
    }
}
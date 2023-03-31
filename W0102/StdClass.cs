using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w010201
{
    internal class StdClass
    {
        private List<Student> students;
        private string className;
        public StdClass(string clsname) { 
            students = new List<Student>();
            className = clsname;
        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void showStdList()
        {
            Console.WriteLine("[ALL] " + className);
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.LastName}  {student.FirstName}");
            }
        }

        public void showStdList(string xname)
        {
            Console.WriteLine("Find: " + className + " co ten " + xname);

            var filstudents = from x in students where x.FirstName == xname select x;
            foreach (Student student in filstudents)
            {
                Console.WriteLine($"{student.LastName}  {student.FirstName}");
            }
        }
    }
}

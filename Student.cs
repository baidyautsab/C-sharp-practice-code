using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor1
{
    internal class Student : IComparable<Student>
    {
        // example of IComparable
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Dob { get; set; }
        public double Mark { get; set; }

        public int CompareTo(Student other)
        {
            if(this.Id > other.Id) return 1;
            else if(this.Id < other.Id) return -1;
            return 0;
        }
    }
    class StudentCompairOnMarks : IComparer<Student>
    {
        // example of IComparer
        public int Compare(Student x, Student y)
        {
            if(x.Mark > y.Mark) return 1;
            else if(x.Mark < y.Mark) return -1; 
            else return 0;
        }
    }
    class TestStudent
    {
        static void Main()
        {
            Student student1 = new Student { Id = 4, Name = "Biren", Age = 22, Dob = new DateTime(2002, 3, 10), Mark = 389 };
            Student student2 = new Student { Id = 10, Name = "Rishabh", Age = 23, Dob = new DateTime(2001, 6, 18), Mark = 429 };
            Student student3 = new Student { Id = 2, Name = "Prasun", Age = 23, Dob = new DateTime(2001, 4, 1), Mark = 390 };
            Student student4 = new Student { Id = 41, Name = "Utsab", Age = 24, Dob = new DateTime(2000, 1, 20), Mark = 371 };
            Student student5 = new Student { Id = 1, Name = "Shamik", Age = 24, Dob = new DateTime(2000, 6, 15), Mark = 367 };
            Student student6 = new Student { Id = 12, Name = "Sayan", Age = 23, Dob = new DateTime(2001, 2, 12), Mark = 342 };
            Student student7 = new Student { Id = 7, Name = "Rohit", Age = 24, Dob = new DateTime(2000, 8, 23), Mark = 445 };

            List<Student> students = new List<Student> {  student1, student2, student3, student4, student5, student6, student7 };

            foreach (Student student in students)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.Dob + " " + student.Mark);
            }

            students.Sort();
            Console.WriteLine("--------------------Sorting by id---------------------");

            foreach (Student student in students)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.Dob + " " + student.Mark);
            }

            Console.WriteLine("--------------------Sorting by marks---------------------");
            StudentCompairOnMarks studentCompairOnMarks = new StudentCompairOnMarks();
            students.Sort(studentCompairOnMarks);

            foreach (Student student in students)
            {
                Console.WriteLine(student.Id + " " + student.Name + " " + student.Age + " " + student.Dob + " " + student.Mark);
            }
        }
    }
}

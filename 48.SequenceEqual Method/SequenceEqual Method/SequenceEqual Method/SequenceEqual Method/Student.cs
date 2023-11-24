using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceEqual_Method
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public static List<Student> GetStudents1()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
        public static List<Student> GetStudents2()
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student{ID= 101,Name = "Preety"},
                new Student{ID= 102,Name = "Priyanka"}
            };
            return listStudents;
        }
    }
}

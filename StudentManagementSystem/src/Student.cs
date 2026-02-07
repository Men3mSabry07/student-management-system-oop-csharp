using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Student
    {
        public int StudentId {get; set;}
        public string Name {get; set;}
        private int _age; 
        public int Age
        {
            get {return _age;} 
            set {_age = value;} 
        }
        public List<Course> Courses = new List<Course>();

        public Student(int studentId, string name, int age)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Age = age;
        }

        public bool Enroll(Course course)
        {
            if (Courses.Any(C => C.Title == course.Title)) return false;
            else Courses.Add(course);

            return true;
        }
        public string PrintDetails()
        {
            string CoursesList = string.Join(",",Courses.Select(C => C.Title).ToList());

            return $"StudentId: {StudentId} , Name: {Name} , Age: {Age} , {CoursesList}";
        }
    }
}

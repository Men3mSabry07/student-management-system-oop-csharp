using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class SchoolStudentManager
    {
        public List<Student> Students = new List<Student>();
        public List<Course> Courses = new List<Course>();
        public List<Instructor> Instructors = new List<Instructor>();
        public bool AddStudent(Student student) {
            if (Students.Any(S => S.StudentId == student.StudentId))  
                return false;

            Students.Add(student);
            
            return true;
        }
      
        public bool AddCourse(Course course) {
            if (Courses.Any(C => C.Title == course.Title))
                return false;

            Courses.Add(course);

            return true;
        }
      
        public bool AddInstructor(Instructor instructor) {
            if (Instructors.Any(I => I.InstructorId == instructor.InstructorId))
                return false;

            Instructors.Add(instructor);

            return true;
        }
        public Student FindStudent(int studentId)
        {
            Student S = Students.FirstOrDefault(s => s.StudentId == studentId);

            return S;
        }
        
        public Course FindCourse(int courseId)
        {
            Course C = Courses.FirstOrDefault(c => c.CourseId == courseId);

            return C;
        }
        
        public Instructor FindInstructor(int instructorId)
        {
            Instructor I = Instructors.FirstOrDefault(i => i.InstructorId == instructorId);
            return I;
        }
        
        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student s = FindStudent(studentId);
            Course c = FindCourse(courseId);

            if (s == null || c == null)
                return false;

            return s.Enroll(c);
        }
    }
}

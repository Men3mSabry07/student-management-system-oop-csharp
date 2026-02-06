using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Course
    {
        public int CourseId;
        public string Title;
        public Instructor Instructor;

        public Course(int courseId, string title, Instructor instructor)
        {
            this.CourseId = courseId;
            this.Title = title;
            this.Instructor = instructor;
        }

        public string PrintDetails()
        {
            return $"Course ID: {CourseId}, Title: {Title}, Instructor: [{Instructor.PrintDetails()}]";
        }

    }
}

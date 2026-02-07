using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    class Instructor
    {
        public int InstructorId;
        public string Name;
        public string Specialization;

        public Instructor(int instructorId, string name, string specialization)
        {
            this.InstructorId = instructorId;
            this.Name = name;
            this.Specialization = specialization;
        }
        // Methods
        public string PrintDetails()
        {
            return $"ID: {InstructorId}, Name: {Name}, Specialization: {Specialization}";
        }
    }
}

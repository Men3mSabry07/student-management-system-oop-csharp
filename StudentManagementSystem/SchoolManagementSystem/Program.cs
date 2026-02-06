using System;
using System.Collections.Specialized;
using System.Linq;
using SchoolManagementSystem;

class Program
{
    static void ShowDashboard(SchoolStudentManager manager)
    {
        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Add Instructor");
        Console.WriteLine("3. Add Course");
        Console.WriteLine("4. Enroll Student in Course");
        Console.WriteLine("5. Show All Students");
        Console.WriteLine("6. Show All Courses");
        Console.WriteLine("7. Show All Instructors");
        Console.WriteLine("8. Find Student by ID");
        Console.WriteLine("9. Find Course by ID");
        Console.WriteLine("10. Check if student enrolled in specific course");
        Console.WriteLine("11. Return instructor name by course name");
        Console.WriteLine("12. Exit");
        Console.WriteLine("----------------------------------------");

        while (true)
        {
            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Student ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Student s = new Student(id, name, age);
                if (manager.AddStudent(s))
                    Console.WriteLine("Student added successfully");
                else
                    Console.WriteLine("Student already exists");
            }
            else if (choice == "2")
            {
                Console.Write("Instructor ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Specialization: ");
                string spec = Console.ReadLine();

                Instructor ins = new Instructor(id, name, spec);
                if (manager.AddInstructor(ins))
                    Console.WriteLine("Instructor added successfully.");
                else
                    Console.WriteLine("Instructor already exists.");
            }
            else if (choice == "3")
            {
                Console.Write("Course ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.Write("Instructor ID: ");
                int insId = int.Parse(Console.ReadLine());

                Instructor ins = manager.FindInstructor(insId);
                if (ins != null)
                {
                    Course c = new Course(id, title, ins);
                    if (manager.AddCourse(c))
                        Console.WriteLine("Course added successfully.");
                    else
                        Console.WriteLine("Course already exists.");
                }
                else
                    Console.WriteLine("Instructor not found!");
            }
            else if (choice == "4")
            {
                Console.Write("Student ID: ");
                int stId = int.Parse(Console.ReadLine());
                Console.Write("Course ID: ");
                int cId = int.Parse(Console.ReadLine());

                if (manager.EnrollStudentInCourse(stId, cId))
                    Console.WriteLine("Student enrolled successfully.");
                else
                    Console.WriteLine("already enrolled");
            }
            else if (choice == "5")
            {
                if (!manager.Students.Any())
                {
                    Console.WriteLine("No students found");
                }
                else
                {
                    foreach (var s in manager.Students)
                        Console.WriteLine(s.PrintDetails());
                }
            }
            else if (choice == "6")
            {
                if (!manager.Courses.Any())
                {
                    Console.WriteLine("No courses found");
                }
                else
                {
                    foreach (var c in manager.Courses)
                        Console.WriteLine(c.PrintDetails());
                }
            }
            else if (choice == "7")
            {
                if (!manager.Instructors.Any())
                {
                    Console.WriteLine("No instructors found");
                }
                else
                {
                    foreach (var i in manager.Instructors)
                        Console.WriteLine(i.PrintDetails());
                }
            }
            else if (choice == "8")
            {
                Console.Write("Student ID: ");
                int stId = int.Parse(Console.ReadLine());
                Student s = manager.FindStudent(stId);
                if (s != null)
                    Console.WriteLine(s.PrintDetails());
                else
                    Console.WriteLine("Student not found");
            }
            else if (choice == "9")
            {
                Console.Write("Course ID: ");
                int cId = int.Parse(Console.ReadLine());
                Course c = manager.FindCourse(cId);
                if (c != null)
                    Console.WriteLine(c.PrintDetails());
                else
                    Console.WriteLine("Course not found");
            }
            else if (choice == "12")
            {
                Console.WriteLine("Game Over");
                return;
            }
            else if (choice == "10")
            {
                Console.Write("Student ID: ");
                int sId = int.Parse(Console.ReadLine());
                Console.Write("Course ID: ");
                int cId = int.Parse(Console.ReadLine());

                Student s = manager.FindStudent(sId);
                if (s != null && s.Courses.Any(c => c.CourseId == cId))
                    Console.WriteLine("Student is enrolled in this course");
                else
                    Console.WriteLine("Student not enrolled or not found");
            }
            else if (choice == "11")
            {
                Console.Write("Course Title: ");
                string title = Console.ReadLine();

                Course c = manager.Courses.FirstOrDefault(cr => cr.Title == title);
                if (c != null && c.Instructor != null)
                    Console.WriteLine($"Instructor: {c.Instructor.Name}");
                else
                    Console.WriteLine("Course or instructor not found.");
            }
            else
            {
                Console.WriteLine("Invalid choice try again");
            }
        }
    }

    static void Main(string[] args)
    {
        SchoolStudentManager Manger = new SchoolStudentManager();

        ShowDashboard(Manger);
    }
}
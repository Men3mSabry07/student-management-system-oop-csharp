# Student Management System (C# – OOP)

A **console-based school management system** built in **C#** using **Object-Oriented Programming (OOP)** principles.  

This project demonstrates how to manage **students, instructors, and courses** in memory without a database, while maintaining **clean code, separation of concerns, and OOP best practices**.

---

## 🚀 Features

- Add/View Students, Courses, and Instructors
- Enroll students in courses
- Search students and courses by ID
- Check if a student is enrolled in a specific course
- Retrieve instructor name by course
- Handles empty lists and invalid input gracefully

**Technical Highlights:**

- Pure **OOP design**: Student, Instructor, Course, and SchoolStudentManager classes
- **Separation of concerns**: Manager class handles data, Program.cs handles UI
- **In-memory storage** using `List<T>`
- Extra validations to prevent duplicates


## Project Structure

```text
StudentManagementSystem/
├── StudentManagementSystem.sln
├── src/   ← Folder containing all source code
│   └── ├── Program.cs
│       ├── Student.cs
│       ├── Course.cs
│       ├── Instructor.cs
│       └── SchoolStudentManager.cs  ← Manages students, courses, and instructors
├── README.md


---

## Author

El Alamy – Aspiring .NET Developer

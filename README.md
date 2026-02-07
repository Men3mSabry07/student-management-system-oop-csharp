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
├── src/
│   └── ├── Program.cs
│       ├── Student.cs
│       ├── Course.cs
│       ├── Instructor.cs
│       └── SchoolStudentManager.cs
├── README.md


**Note:** `.sln` is in the root for easy opening in Visual Studio.  
All code files and the project file are under `src/StudentManagementSystem/`.

---

## How to Run

1. Clone the repository
2. Open `StudentManagementSystem.sln` in Visual Studio
3. Build and run (`F5`)
4. Use the console menu to interact with the system

---

## Author

El Alamy – Aspiring .NET Developer

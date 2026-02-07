# Student Management System (C# – OOP)

A **console-based school management system** built in **C#** using **Object-Oriented Programming (OOP)**.

---

## Project Overview

This project simulates a **school environment** in memory (no database).  
It manages:

- **Students**: add, view, search by ID, enroll in courses
- **Courses**: add, view, link to instructors
- **Instructors**: add, view

**Key Points:**

- Uses **OOP principles**: encapsulation, composition, and separation of concerns.
- Includes **extra features**:
  - Check if a student is enrolled in a specific course
  - Return instructor by course name
- Handles empty lists and invalid input gracefully.

---

# Student Management System

## Project Structure

```text
StudentManagementSystem/
├── StudentManagementSystem.sln
├── src/
│   └── StudentManagementSystem/
│       ├── Program.cs
│       ├── Student.cs
│       ├── Course.cs
│       ├── Instructor.cs
│       └── SchoolStudentManager.cs
├── README.md
└── .gitignore



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

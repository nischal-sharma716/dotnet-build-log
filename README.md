# 🚀 DotNet Build Log

A hands-on journey into C# and .NET development.

This repository documents my progress as I build practical projects and strengthen backend fundamentals using .NET and ASP.NET Core.

## Structure

Each folder represents daily progress or a focused mini-project.

## Goals

- Develop a strong understanding of C# and .NET OOP principles.
- Practice Entity Framework Core, LINQ, and ASP.NET Core.
- Build clean, maintainable, and testable code.

## Day 1: Student Management System & OOP Refactoring

**Activity:**  
- Built a basic console-based Student Management System to add and view students.  
- Refactored the code for better **OOP structure**:
  - Added StudentManager class and IStudentManager interface.
  - Applied encapsulation in the Student class with input validation.
  - Separated UI (Program class) from business logic.
- Implemented **full CRUD operations**: Add, View, Update, Delete, and Search students.  
- Fixed menu loop to correctly handle all options and prevent accidental exits.  
- Improved error handling, maintainability, and scalability.

## Day 2 : LINQ Practice

**Concepts Learned:**
- LINQ basics: filtering, searching, sorting, existence checks, counting
- Lambda expressions (`s => s.Property`)
- `Where()`, `FirstOrDefault()`, `OrderByDescending()`, `Any()`, `Count()`
- Functional-style thinking on collections
- Structuring a console app with `Models` and `Services`

## Day 3: MVC + LINQ Interactive Project

**Activity:**  
- Created an **ASP.NET Core MVC project** with `Student` model and `StudentService`.  
- Implemented **LINQ queries** for:
  - Filtering students by age  
  - Top N students by GPA  
  - Searching students by name  
  - Checking existence and counting by GPA  
- Created **interactive Razor Views** with forms for user input.  
- Added **navigation menu** in `_Layout.cshtml` to easily access LINQ pages.  
- Learned **deferred vs immediate execution** in LINQ (`IEnumerable` vs `.ToList()`).  

**Outcome:**  
- Fully interactive MVC project using LINQ, ready for database integration in the next steps.





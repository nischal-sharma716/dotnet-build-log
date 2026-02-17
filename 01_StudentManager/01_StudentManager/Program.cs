using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    private int id;
    private string name;
    private int age;

    public int Id
    {
        get => id;
        set
        {
            if (value <= 0) throw new ArgumentException("Id must be positive.");
            id = value;
        }
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty.");
            name = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0) throw new ArgumentException("Age must be positive");
            age = value;
        }
    }
}

interface IStudentManager
{
    void AddStudent(Student student);
    void ViewStudents();
    Student? FindStudent(int id);
}

class StudentManager : IStudentManager
{
    private readonly List<Student> students = new();

    public void AddStudent(Student student)
    {
        if (students.Any(s => s.Id == student.Id))
        {
            Console.WriteLine("Student with this ID already exists.");
            return;
        }
        students.Add(student);
        Console.WriteLine("Student added successfully.");
    }

    public void ViewStudents()
    {
        if (!students.Any())
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\n---Student List---");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
        }
    }

    public Student? FindStudent(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }
}

class Program
{
    static void Main()
    {
        IStudentManager studentManager = new StudentManager();
        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("\n--- Student Manager---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter Choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddStudentUI(studentManager);
                    break;
                case 2:
                    studentManager.ViewStudents();
                    break;
                case 3:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void AddStudentUI(IStudentManager manager)
    {
        try
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            var student = new Student { Id = id, Name = name, Age = age };
            manager.AddStudent(student);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }
}
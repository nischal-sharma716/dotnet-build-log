using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
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
                    AddStudent(students);
                    break;
                case 2:
                    ViewStudents(students);
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

    static void AddStudent(List<Student> students)
    {
        Console.WriteLine("Enter ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        students.Add(new Student { Id = id, Name = name, Age = age });

        Console.WriteLine("Student added successfully.");
    }

    static void ViewStudents(List<Student> students)
    {
        if (students.Count == 0)
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
}
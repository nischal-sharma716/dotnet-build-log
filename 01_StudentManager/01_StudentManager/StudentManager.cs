using System;
using System.Collections.Generic;
using System.Linq;
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
        ViewStudentsInternal();
    }

    public void ViewStudentsInternal(int? minAge = null, int? maxAge = null)
    {
        var query = students.AsEnumerable();

        if (minAge.HasValue)
            query = query.Where(s => s.Age >= minAge.Value);
        if (maxAge.HasValue)
            query = query.Where(s => s.Age <= maxAge.Value);

        var list = query.ToList();

        if (!list.Any())
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\n---Student List---");
        Console.WriteLine("ID\tName\tAge");
        foreach (var student in list)
        {
            Console.WriteLine($"{student.Id}\t{student.Name}\t{student.Age}");
        }
    }

    public Student? FindStudent(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public bool DeleteStudent(int id)
    {
        var student = FindStudent(id);
        if (student == null) return false;
        students.Remove(student);
        return true;
    }

    public bool UpdateStudent(int id, string newName, int newAge)
    {
        var student = FindStudent(id);
        if (student == null) return false;

        try
        {
            student.Name = newName;
            student.Age = newAge;
            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<Student> SearchStudents(string namepart)
    {
        return students
            .Where(s => s.Name.IndexOf(namepart, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();
    }
}
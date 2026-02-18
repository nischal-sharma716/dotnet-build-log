using _02_StudentManager_LINQ.Models;
using System.Collections.Generic;

namespace _02_StudentManager_LINQ.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        public StudentService()
        {
            SeedData();
        }

        public void SeedData()
        {
            students.Add(new Student { Name = "Ram", Age = 20, GPA = 3.5 });
            students.Add(new Student { Name = "Shyam", Age = 22, GPA = 3.8 });
            students.Add(new Student { Name = "Hari", Age = 19, GPA = 3.2 });
            students.Add(new Student { Name = "Sita", Age = 21, GPA = 3.9 });
        }

        public void ShowAll()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Age} - {student.GPA}");
            }
        }

        public void ShowOlderThan20()
        {
            var result = students.Where(s => s.Age > 20);
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }
        }

        public void FindByName(string name)
        {
            var student = students.FirstOrDefault(s => s.Name == name);

            if (student != null)
                Console.WriteLine($"{student.Name} found.");
            else
                Console.WriteLine("Stident not found.");
        }

        public void SortByGPA()
        {
            var sorted =  students.OrderByDescending(s => s.GPA);

            foreach (var student in sorted)
            {
                Console.WriteLine($"{student.Name} - {student.GPA}");
            }
        }

        public void CheckHighPerformer()
        {
            bool exists = students.Any(s => s.GPA > 3.8);

            Console.WriteLine(exists ? "High performer exists." : "No high performer.");
        }

        public void CountGoodStudents()
        {
            int count = students.Count(s => s.GPA > 3.5);

            Console.WriteLine($"Students above 3.5 GPA: {count}");
        }
    }
}
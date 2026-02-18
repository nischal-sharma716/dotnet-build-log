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
    }
}
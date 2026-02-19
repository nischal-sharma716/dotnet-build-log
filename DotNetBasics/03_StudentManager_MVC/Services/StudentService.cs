using _03_StudentManager_MVC.Models;


namespace _03_StudentManager_MVC.Services
{
    public class StudentService
    {
        private List<Student> _students;

        public StudentService()
        {
            _students = new List<Student>
            {
                new Student {Id = 1, Name = "Ram", Age = 21, GPA = 3.8},
                new Student {Id = 2, Name = "Sita", Age = 22, GPA = 3.6},
                new Student {Id = 3, Name = "Hati", Age = 19, GPA = 3.9}
            };
        }

        public List<Student>GetAll()
        {
            return _students;
        }

        public List<Student> GetStudentsOlderThan(int age)
        {
            return _students.Where(s => s.Age > age).ToList();
        }

        public List<Student> GetTopStudents(int count)
        {
            return _students.OrderByDescending(s => s.GPA).Take(count).ToList();
        }

        public bool AnyHighGPA(double threshold)
        {
            return _students.Any(s => s.GPA > threshold);
        }

        public int CountLowGPA(double threshold)
        {
            return _students.Count(s => s.GPA < threshold);
        }

        public List<Student> SearchByName(string name)
        {
            return _students
                .Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id ==id); 
        }

        public void UpdateStudent(Student student)
        {
            var existing = GetById(student.Id);
            if (existing != null)
            {
                existing.Name = student.Name;
                existing.Age = student.Age;
                existing.GPA = student.GPA;
            }
        }

        public void DeleteStudent(int id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _students.Remove(existing);
            }
        }
    }
}

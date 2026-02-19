using Microsoft.AspNetCore.Mvc;
using _03_StudentManager_MVC.Models;
using _03_StudentManager_MVC.Services;


namespace _03_StudentManager_MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
        public IActionResult OlderThan(int age = 20)
        {
            var students = _studentService.GetStudentsOlderThan(age);
            return View(students);
        }

        public IActionResult TopStudents(int count = 2)
        {
            var students = _studentService.GetTopStudents(count);
            return View(students);
        }

        public IActionResult HasHighGPA(double threshold = 3.7)
        {
            var result = _studentService.AnyHighGPA(threshold);
            ViewBag.Message = result ? $"There is at least one student with GPA above {threshold}" : $"No student has GPA above {threshold}";
            return View();
        }

        public IActionResult CountLowGPA(double threshold = 3.6)
        {
            var count = _studentService.CountLowGPA(threshold);
            ViewBag.Message = $"Number of students with GPA below {threshold}: {count}";
            return View();
        }

        public IActionResult Search(string name = "Ram")
        {
            var students = _studentService.SearchByName(name);
            return View(students);
        }

    }
}

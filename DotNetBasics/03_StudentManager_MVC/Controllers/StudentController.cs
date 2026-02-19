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
    }
}

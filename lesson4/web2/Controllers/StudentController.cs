using Microsoft.AspNetCore.Mvc;
using web2.Data;
using web2.Models;

namespace web2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext context;

        public StudentController (ApplicationDbContext context)
        {
            this.context = context; 
        }

        public IActionResult Index()
        {
            var students = context.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}

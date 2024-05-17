using lab2a.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2a.Controllers
{
    public class CatController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Index(Cat cat)
        {
            ViewBag.Cat = cat;
            return View();
        }
    }
}

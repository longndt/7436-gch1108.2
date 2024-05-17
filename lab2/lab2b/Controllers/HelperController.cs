using lab2b.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2b.Controllers
{
    public class HelperController : Controller
    {
        public IActionResult HTMLHelper()
        {
            return View();
        }

        public IActionResult TagHelper()
        {
            return View();
        }

        public IActionResult Register(User user)
        {
            return View(user);
        }
    }
}

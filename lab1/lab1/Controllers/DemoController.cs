using Microsoft.AspNetCore.Mvc;
using System;

namespace lab1.Controllers
{
    public class DemoController : Controller
    {
        //url: localhost:PORT/Demo/Index
        public IActionResult Index()
        {
            //view: Views/Demo/Index.cshtml
            return View();
        }

        //url: localhost:PORT/Demo/Hanoi
        public IActionResult Hanoi()
        {
            //Pass data (Model binding) to view
            //Method 1: Using ViewBag
            ViewBag.HN = "Hanoi is the capital of Vietnam";

            //Method 2: Using ViewData
            ViewData["CurrentYear"] = DateTime.Now.Year.ToString();

            //view: Views/Demo/Hanoi.cshtml
            return View();
        }
    }
}

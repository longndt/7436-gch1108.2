using Microsoft.AspNetCore.Mvc;

namespace lab2a.Controllers
{
    public class GreenwichController : Controller
    {
        //URL: localhost:PORT/Greenwich/Index
        public IActionResult Index()
        {
            //Path: Views/Greenwich/Index.cshtml

            //data binding => pass data from controller (BE) to view (FE)
            ViewBag.Name = "Greenwich Vietnam";
            string address = "Số 2 Phạm Văn Bạch - Hà Nội";
            ViewData["Address"] = address;
            return View();
        }
    }
}

using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class MobileController : Controller
    {
        //Render ra form add mobile để người dùng nhập liệu
        public IActionResult Add()
        {
            return View();
        }

        //Render ra page index để thấy kết quả nhập từ form
        //parameter (tham số - đầu vào của method): Mobile
        //dữ liệu của Mobile được lấy từ form
        public IActionResult Index(Mobile mobile)
        {
            //pass data sang view sử dụng ViewBag
            ViewBag.Mobile = mobile;
            return View();
        }
    }
}

using demo.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace demo.Controllers
{
    public class ProductController : Controller
    {
        //declare application db context
        //use context to manage database
        private readonly ApplicationDbContext context;

        //declare constructor
        public ProductController (ApplicationDbContext context)
        {
           this.context = context;
        }

        //READ function (1)
        //View all products : Product list
        //SQL: SELECT * FROM Products
        public IActionResult Index()
        {
            //get product data from "Products" table
            //and save to an array (list)
            var products = context.Products.ToList();

            //render view along with data
            return View(products);
        }

        //READ function (2)
        //View product by ID : Product Detail
        //SQL: SELECT * FROM Products WHERE Id = "id"
        //int? id : id is nullable
        public IActionResult Detail(int? id)
        {
 
            return View();
        }
    }
}

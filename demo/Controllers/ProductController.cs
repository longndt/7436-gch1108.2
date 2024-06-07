using demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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

        //READ function (1A)
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

        //READ function (1B) - with async & await
        //View all products : Product list
        //SQL: SELECT * FROM Products
        //public async Task<IActionResult> Index()
        //{
        //    //get product data from "Products" table
        //    //and save to an array (list)
        //    var products = await context.Products.ToListAsync();

        //    //render view along with data
        //    return View(products);
        //}

        //READ function (2)
        //View product by ID : Product Detail
        //SQL: SELECT * FROM Products WHERE Id = "id"
        //int? id : id is nullable
        public IActionResult Detail(int? id)
        {
            //if id is null return error
            if (id == null)
            {
                return NotFound();
            }
            //find product whose id is similar to id in url
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        //DELETE function
        //SQL: DELETE FROM Products WHERE Id = "id"
        public IActionResult Delete(int? id)
        {
            //if id is null return error
            if (id == null)
            {
                return NotFound();
            }
            //else remove product by id
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            context.Products.Remove(product);
            //save change to database
            context.SaveChanges();
            //redirect to product list page
            return RedirectToAction("Index");
        }
    }
}

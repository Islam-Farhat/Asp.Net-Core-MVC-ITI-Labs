using Microsoft.AspNetCore.Mvc;
using lab1.Models;

namespace lab1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductData.getAllProducts();
            return View("Index",products);
        }
        public IActionResult Details(int id)
        {
            var product = ProductData.getProductByID(id);
            return View("Details",product);
        }
    }
}

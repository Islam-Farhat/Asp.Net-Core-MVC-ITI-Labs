using ITI_Project_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI_Project_MVC.Controllers
{
    public class InstructorController : Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Index()
        {
            var result = context.Instructors.ToList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            var result = context.Instructors.FirstOrDefault(x => x.Id == id);
            return View(result);
        }
    }
}

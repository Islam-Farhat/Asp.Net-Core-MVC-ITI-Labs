using Microsoft.AspNetCore.Mvc;
using ITI_Project_MVC.Models;

namespace ITI_Project_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Index()
        {
            var result = context.Departments.ToList();
            return View(result);
        }
        public IActionResult AddDepartment(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
            return View();
        }
        public IActionResult GetDepartmentByID(int deptID)
        {
            var result = context.Departments.FirstOrDefault(x=>x.Id==deptID);
            return Json(result);
        }

        public IActionResult Edit(Department dept)
        {
            context.Departments.Update(dept);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

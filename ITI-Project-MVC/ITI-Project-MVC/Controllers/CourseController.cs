using Microsoft.AspNetCore.Mvc;
using ITI_Project_MVC.Models;
using Microsoft.EntityFrameworkCore;
using ITI_Project_MVC.ViewModel;
using Microsoft.AspNetCore.Hosting;

namespace ITI_Project_MVC.Controllers
{
    public class CourseController : Controller
    {
        ITIContext context = new ITIContext();

        public IActionResult CheckMinDegree(double MinDegree, double Degree)
        {
            if (MinDegree <Degree)
                return Json(true);
            else
                return Json(false);
        }
        public IActionResult Index()
        {
            var result = context.Courses.Include(s => s.Department).ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            ViewBag.deptList = context.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course newCourse)
        {
            if (ModelState.IsValid)
            {
                context.Courses.Add(newCourse);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.deptList = context.Departments.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            ViewBag.deptList = context.Departments.ToList();

            var result = context.Courses.FirstOrDefault(x => x.Id == id);

            return View(result);
        }

        [HttpPost]
        public IActionResult EditCourse([FromRoute] int id, Course newCourse)
        {
            ViewBag.deptList = context.Departments.ToList();
            if (newCourse.Name != null && newCourse.Degree != null)
            {
                context.Courses.Update(newCourse);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newCourse);
        }

        public IActionResult DeleteCourse(int id)
        {

            var result = context.Courses.FirstOrDefault(x => x.Id == id);

            context.Courses.Remove(result);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

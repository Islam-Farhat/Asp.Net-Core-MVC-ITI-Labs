using Microsoft.AspNetCore.Mvc;
using ITI_Project_MVC.Models;
using Microsoft.EntityFrameworkCore;
using ITI_Project_MVC.ViewModel;
using Microsoft.AspNetCore.Hosting;
using ITI_Project_MVC.Repository;

namespace ITI_Project_MVC.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepository CourseRepository;
        IDepartmentRepository DepartmentRepository;
        public CourseController(ICourseRepository crsrepo, IDepartmentRepository departmentRepository)
        {
            CourseRepository = crsrepo;
            DepartmentRepository = departmentRepository;
        }
        public IActionResult CheckMinDegree(double MinDegree, double Degree)
        {
            if (MinDegree <Degree)
                return Json(true);
            else
                return Json(false);
        }
        public IActionResult Index()
        {
            var result = CourseRepository.GetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult AddCourse()
        {
            ViewBag.deptList = DepartmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddCourse(Course newCourse)
        {
            if (ModelState.IsValid)
            {
                CourseRepository.Insert(newCourse);
                return RedirectToAction("Index");
            }
            ViewBag.deptList = DepartmentRepository.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult EditCourse(int id)
        {
            ViewBag.deptList = DepartmentRepository.GetAll();

            var result = CourseRepository.GetByID(id);

            return View(result);
        }

        [HttpPost]
        public IActionResult EditCourse([FromRoute] int id, Course newCourse)
        {
            ViewBag.deptList = DepartmentRepository.GetAll();
            if (newCourse.Name != null && newCourse.Degree != null)
            {
                CourseRepository.Update(id, newCourse);
                return RedirectToAction("Index");
            }
            return View(newCourse);
        }

        public IActionResult DeleteCourse(int id)
        {
            CourseRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

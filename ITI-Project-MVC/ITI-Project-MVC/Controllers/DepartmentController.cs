using Microsoft.AspNetCore.Mvc;
using ITI_Project_MVC.Models;
using ITI_Project_MVC.Repository;

namespace ITI_Project_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentRepository DepartmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            DepartmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var result = DepartmentRepository.GetAll();
            return View(result);
        }
        public IActionResult AddDepartment(Department dept)
        {
            DepartmentRepository.Insert(dept);
            return View();
        }
        public IActionResult GetDepartmentByID(int deptID)
        {
            var result = DepartmentRepository.GetByID(deptID);
            return Json(result);
        }
        public IActionResult Edit(Department dept)
        {
            DepartmentRepository.Update(dept);
            return RedirectToAction("Index");
        }
    }
}

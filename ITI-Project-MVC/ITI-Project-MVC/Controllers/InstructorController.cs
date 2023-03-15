using ITI_Project_MVC.Models;
using ITI_Project_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using Microsoft.AspNetCore.Hosting;

namespace ITI_Project_MVC.Controllers
{
    public class InstructorController : Controller
    {
        ITIContext context = new ITIContext();
        private readonly IWebHostEnvironment _webHostEnvironment;
        public InstructorController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var result = context.Instructors.Include(x=>x.Course).Include(s=>s.Department).ToList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            var result = context.Instructors.FirstOrDefault(x => x.Id == id);
            return View(result);
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            ViewBag.deptList = context.Departments.ToList();
            ViewBag.courseList = context.Courses.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor, IFormFile Imagell)
        {
            ViewBag.deptList = context.Departments.ToList();
            ViewBag.courseList = context.Courses.ToList();

            //Upload File
            string filename = string.Empty;
            if (Imagell != null)
            {
                string uploads = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                filename = Imagell.FileName;
                string fullpath = Path.Combine(uploads, filename);
                Imagell.CopyTo(new FileStream(fullpath, FileMode.Create));
            }

            if (newInstructor.Name!=null && Imagell != null&& newInstructor.Address != null)
            {
                newInstructor.Image = Imagell.FileName;
                context.Instructors.Add(newInstructor);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
       
        //Upload File
        //public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);

        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Length > 0)
        //        {
        //            var filePath = Path.GetTempFileName();
        //            filePath = "./wwwroot/Image/";

        //            using (var stream = System.IO.File.Create(filePath))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }
        //        }
        //    }

        //    // Process uploaded files
        //    // Don't rely on or trust the FileName property without validation.

        //    return Ok(new { count = files.Count, size });
        //}


        [HttpGet]
        public IActionResult EditInstructor(int id)
        {
            var result = context.Instructors.FirstOrDefault(x => x.Id == id);
            InstructorCourseDepartmentVM resultVM = new InstructorCourseDepartmentVM();
            resultVM.Id = result.Id;
            resultVM.Name = result.Name;
            resultVM.Image = result.Image;
            resultVM.Salary = result.Salary;
            resultVM.Address = result.Address;
            resultVM.Course_Id = result.Course_Id;
            resultVM.Dept_Id = result.Dept_Id;
            resultVM.Departments = context.Departments.ToList();
            resultVM.Courses = context.Courses.ToList();

            return View(resultVM);
        }

        [HttpPost]
        public IActionResult EditInstructor([FromRoute] int id, Instructor newInstructor,IFormFile Imagell)
        {
         
            InstructorCourseDepartmentVM resultVM = new InstructorCourseDepartmentVM();
            resultVM.Id = newInstructor.Id;
            resultVM.Name = newInstructor.Name;
            resultVM.Salary = newInstructor.Salary;
            resultVM.Address = newInstructor.Address;
            resultVM.Course_Id = newInstructor.Course_Id;
            resultVM.Dept_Id = newInstructor.Dept_Id;
            
            //upload file
            string filename = string.Empty;
            if (Imagell != null)
            {
                string uploads = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                filename += Guid.NewGuid().ToString() + "_" + Imagell.FileName;
               
                string fullpath = Path.Combine(uploads, filename);
                Imagell.CopyTo(new FileStream(fullpath, FileMode.Create));
            }
            //-------------------------------------------------//
            if (newInstructor.Name != null&& newInstructor.Address != null)
            {
                if (Imagell != null)
                {
                newInstructor.Image = filename;
                }
                context.Instructors.Update(newInstructor);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
           
            resultVM.Departments = context.Departments.ToList();
            resultVM.Courses = context.Courses.ToList();
            return View(resultVM);
        }
    }
}

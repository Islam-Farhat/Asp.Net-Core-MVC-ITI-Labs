using ITI_Project_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_Project_MVC.Repository
{
    public class CourseRepository : ICourseRepository
    {
        ITIContext context;
        public CourseRepository(ITIContext _context)//inject context
        {
            context = _context;
        }
        public List<Course> GetAll()
        {
            return context.Courses.Include(s => s.Department).ToList();
        }
        public Course GetByID(int id)
        {
            Course crs = context.Courses.FirstOrDefault(e => e.Id == id);
            return crs;
        }

        public List<Department> GetAllDepartments()
        {
            return context.Departments.ToList();
        }
        public void Insert(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }
        public void Update(int id, Course course)
        {
            context.Courses.Update(course);
            context.SaveChanges(true);
        }
        public void Delete(int id)
        {
            Course oldCrs = GetByID(id);
            context.Courses.Remove(oldCrs);
            context.SaveChanges();
        }
    }
}

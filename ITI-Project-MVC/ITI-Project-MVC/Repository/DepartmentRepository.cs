using ITI_Project_MVC.Models;

namespace ITI_Project_MVC.Repository
{
    public class DepartmentRepository: IDepartmentRepository
    {
        ITIContext context;
        public DepartmentRepository(ITIContext _context)//inject context
        {
            context = _context;
        }
        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }
        public Department GetByID(int id)
        {
            Department dept = context.Departments.FirstOrDefault(e => e.Id == id);
            return dept;
        }
        public void Insert(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void Update(Department dept)
        {
            context.Departments.Update(dept);
            context.SaveChanges(true);
        }
        public void Delete(int id)
        {
            Department old = GetByID(id);
            context.Departments.Remove(old);
            context.SaveChanges();
        }
    }
}

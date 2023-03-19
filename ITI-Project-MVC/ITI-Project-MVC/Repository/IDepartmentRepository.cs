using ITI_Project_MVC.Models;

namespace ITI_Project_MVC.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department GetByID(int id);
        void Insert(Department department);
        void Update(Department department);
        void Delete(int id);
    }
}
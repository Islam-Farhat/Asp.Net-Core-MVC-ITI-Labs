using ITI_Project_MVC.Models;
namespace ITI_Project_MVC.Repository
{
    public interface ICourseRepository
    {
        List<Course> GetAll();
        Course GetByID(int id);
        void Insert(Course employee);
        void Update(int id, Course employee);
        void Delete(int id);

       
    }
}
using ITI_Project_MVC.Models;

namespace ITI_Project_MVC.ViewModel
{
    public class InstructorCourseDepartmentVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public int? Dept_Id { get; set; }
        public int? Course_Id { get; set; }
        public virtual List<Course> Courses { get; set; }
        public virtual List<Department> Departments { get; set; }
    }
}

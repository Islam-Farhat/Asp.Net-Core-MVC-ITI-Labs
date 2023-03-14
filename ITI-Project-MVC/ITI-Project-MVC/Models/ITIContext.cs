using Microsoft.EntityFrameworkCore;

namespace ITI_Project_MVC.Models
{
    public class ITIContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Result> Course_Results { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Trainee> Trainees { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIMVC;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}

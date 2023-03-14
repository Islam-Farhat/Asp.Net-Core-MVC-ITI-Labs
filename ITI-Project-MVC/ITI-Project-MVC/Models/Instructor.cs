using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project_MVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        [ForeignKey("Course")]
        public int? Course_Id { get; set; }
        public virtual Department Department { get; set; }
        public virtual Course Course { get; set; }

    }
}

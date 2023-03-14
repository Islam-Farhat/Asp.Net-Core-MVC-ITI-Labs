using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Degree { get; set; }
        public double MinDegree { get; set; }

        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public virtual Department Department { get; set; }
    }
}

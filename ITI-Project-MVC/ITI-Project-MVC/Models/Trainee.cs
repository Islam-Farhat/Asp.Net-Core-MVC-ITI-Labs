using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project_MVC.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public double Grade { get; set; }

        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Course_Result> Course_Results { get; set; }
    }
}

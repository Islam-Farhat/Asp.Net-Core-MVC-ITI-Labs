using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project_MVC.Models
{
    public class Course_Result
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        [ForeignKey("Course")]
        public int? Course_Id { get; set; }

        [ForeignKey("Trainee")]
        public int? Trainee_Id { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}

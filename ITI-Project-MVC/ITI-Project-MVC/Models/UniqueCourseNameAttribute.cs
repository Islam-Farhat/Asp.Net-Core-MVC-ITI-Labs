using System.ComponentModel.DataAnnotations;
using ITI_Project_MVC.Models;
namespace ITI_Project_MVC.Models
{
    public class UniqueCourseNameAttribute:ValidationAttribute
    {
       // public string Msg { get; set; }


        ITIContext context = new ITIContext();

        protected override ValidationResult? IsValid
            (object? value, ValidationContext validationContext)
        {
            string name = value.ToString();
            Course crsFromDB = context.Courses.FirstOrDefault(e => e.Name == name );
            if (crsFromDB == null)//success
            {
                return ValidationResult.Success;//0
            }
            return new ValidationResult("Course Name Already Found");
        }
    }
}

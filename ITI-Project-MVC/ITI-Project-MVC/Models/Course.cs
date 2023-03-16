using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_Project_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Name must be more than 2 Char")]
        [MaxLength(25, ErrorMessage = "Name must be less than 25 letter")]
        [UniqueCourseName(ErrorMessage = "Course Name Already Found")]
        public string Name { get; set; }
        [Range(minimum: 50, maximum: 100)]
        public double Degree { get; set; }

        [Remote("CheckMinDegree", "Course", AdditionalFields = "Degree", ErrorMessage = "MinDegree must less than Degree")]//Client side using Ajax 
        public double MinDegree { get; set; }

        [ForeignKey("Department")]
        public int? Dept_Id { get; set; }
        public virtual Department? Department { get; set; }
    }
}

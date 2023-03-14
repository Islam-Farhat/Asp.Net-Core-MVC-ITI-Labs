using ITI_Project_MVC.Models;
using ITI_Project_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ITI_Project_MVC.Controllers
{
    public class TraineeController : Controller
    {
       
        ITIContext context = new ITIContext();
        public IActionResult ShowResult(int traineeId,int courseId)
        {
            var result = context.Course_Results.Select(s => new {s.Trainee_Id,s.Course_Id,s.Degree,CourseName=s.Course.Name,s.Course.MinDegree,TraineeName=s.Trainee.Name}).FirstOrDefault(x => x.Trainee_Id == traineeId && x.Course_Id == courseId);

            TraineeShowResultVM traineeShowResultVM = new TraineeShowResultVM();
            traineeShowResultVM.TraineeName = result.TraineeName;
            traineeShowResultVM.CousreName = result.CourseName;
            traineeShowResultVM.Degree = result.Degree;

            if (result.Degree >= result.MinDegree)
                traineeShowResultVM.Color = "green";
            else
                traineeShowResultVM.Color = "red";

            return View(traineeShowResultVM);
        }
        public IActionResult ShowCousreResult(int courseId)
        {
            var result = context.Course_Results.Where(x => x.Course_Id == courseId).Select(s => new { TraineeName = s.Trainee.Name, CourseName = s.Course.Name, s.Degree, Image = s.Trainee.Image, Color = (s.Degree >= s.Course.MinDegree) ? "green" : "red" }).ToList();
            List<TraineeShowResultVM> crsList = new List<TraineeShowResultVM>();
            foreach (var item in result)
            {
                TraineeShowResultVM obj = new TraineeShowResultVM();
                obj.TraineeName = item.TraineeName;
                obj.CousreName = item.CourseName;
                obj.Degree = item.Degree;
                obj.Color = item.Color;
                obj.Image = item.Image;
                crsList.Add(obj);
            }
            //Set Session
            HttpContext.Session.SetString("PrjName", "Hello From MVC Project");

            return View(crsList);
        }
        public IActionResult GetSession()
        {

            string ss= HttpContext.Session.GetString("PrjName");
            return Content(ss);
        }
        public IActionResult ShowTraineeResult(int traineeId)
        {
            var result = context.Course_Results.Where(x => x.Trainee_Id == traineeId).Select(s => new { TraineeName = s.Trainee.Name, CourseName = s.Course.Name, s.Degree, Image = s.Trainee.Image, Color = (s.Degree >= s.Course.MinDegree) ? "green" : "red" });

            List<TraineeShowResultVM> crsList = new List<TraineeShowResultVM>();
            foreach (var item in result)
            {
                TraineeShowResultVM obj = new TraineeShowResultVM();
                obj.TraineeName = item.TraineeName;
                obj.CousreName = item.CourseName;
                obj.Degree = item.Degree;
                obj.Color = item.Color;
                obj.Image = item.Image;
                crsList.Add(obj);
            }
            

            //Set Cookies

            Response.Cookies.Append("TraineeName", "Islam");
            Response.Cookies.Append("Age", "22");
            return View(crsList);
        }
    }
}

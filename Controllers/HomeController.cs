using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
           new StudentInfoModel { Name = "Jenny Ann Justimbaste", StudentId = "S001", StudentAge = "20" },
            new StudentInfoModel { Name = "Cloe Sabrina Villanueva", StudentId = "S002", StudentAge = "22" },
            new StudentInfoModel { Name = "Vien Paul Villanueva", StudentId = "S003", StudentAge = "31" }
        };

        return View(studentInfoArray);
    }
}

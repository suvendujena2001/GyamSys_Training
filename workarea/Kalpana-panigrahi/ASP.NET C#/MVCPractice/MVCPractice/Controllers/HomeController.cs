using Microsoft.AspNetCore.Mvc;
using MVCPractice.Models;
using System.Diagnostics;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["data1"] = "kalpana";
            ViewData["data2"] = 23;
            string[] arr = { "kalpana", "panigrahi" };
            ViewData["data3"] =arr;
            ViewData["data4"] = new List<string>()
            {
                "Cricket", "football", "hockey"
            };
            ViewBag.data1 = "My name";
            ViewBag.data2 ="Is Kalpana";

            TempData["data"] = "Temp Data";

            var student = new List<StudentModel>
            {
                new StudentModel
                {
                    RollNo = 1, Name="Kalpana",  Gender= "Female",Standard = 12
                },
                new StudentModel
                {
                    RollNo = 2, Name="Archana", Gender="Female", Standard = 12
                },
                new StudentModel
                {
                    RollNo = 3, Name="Mama",  Gender="Female",Standard = 12
                }
            };
            ViewData["Mystudent"]=student;


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

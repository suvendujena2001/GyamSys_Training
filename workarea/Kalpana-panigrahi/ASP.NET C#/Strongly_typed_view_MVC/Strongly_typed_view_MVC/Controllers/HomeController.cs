using Microsoft.AspNetCore.Mvc;
using Strongly_typed_view_MVC.Models;
using System.Diagnostics;

namespace Strongly_typed_view_MVC.Controllers
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
            Employee obj = new Employee()
            {
                EmpId = 101,
                EmpName = "Kalpana",
                Designation = "Manager",
                Salary = 21000

            };
            return View(obj);
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

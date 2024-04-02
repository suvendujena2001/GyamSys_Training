using LogIn_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LogIn_MVC.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Employee()
        {
            return View();
        }

        public IActionResult Login(string username, string Password)
        {

            if (username.ToLower() == "admin" && Password.ToLower() == "password" && (username!=null || Password!=null))
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View("Employee");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            ViewBag.message = string.Empty;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login(String Username, String Password)
        {    ViewBag.message = string.Empty;
        
            if (Username == "admin" && Password == "password")
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                ViewBag.message = "enter valid username and password";
                return View("Index");
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}

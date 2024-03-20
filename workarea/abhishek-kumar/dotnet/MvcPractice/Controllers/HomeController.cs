using Microsoft.AspNetCore.Mvc;
using MvcPractice.Models;
using System.Diagnostics;

namespace MvcPractice.Controllers
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
        public IActionResult Login(String Username, String Password)
        {
            if (Username == "Abhishek" && Password == "password")
            {
                return RedirectToAction("Index", "Employee");
            }
            else
            {

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

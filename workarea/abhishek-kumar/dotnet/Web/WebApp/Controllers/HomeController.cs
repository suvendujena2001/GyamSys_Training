using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;


namespace WebApp.Controllers
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
           

                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    
                    ViewBag.ErrorMessage = "Please enter both username and password.";
                    return View("Index");
                }
                else if (Username == "Abhishek" && Password == "password")
                {
                   
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                   
                    ViewBag.ErrorMessage = "Invalid username or password. Please try again.";
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

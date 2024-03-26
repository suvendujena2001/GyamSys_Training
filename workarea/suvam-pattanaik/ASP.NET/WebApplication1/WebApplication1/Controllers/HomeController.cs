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

            //ViewData["Message"] = "Hello from ViewData";
            //ViewBag.Message = "Hello from viewbag";
            //TempData["Message"] = "Hello from tempdata";

            //ViewBag.message = string.Empty;
            return View();
        }

        public IActionResult Login(User user)
        {
            user.ErrorMessage = string.Empty;
            if (user != null && user.UserName != null && user.Password != null)
            {
                if (user.UserName.ToLower() == "admin" && user.Password.ToLower() == "suvam")
                {
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    user.ErrorMessage="Please enter valid username and password!!";
                    return View("Index",user);
                }

            }
            else
            {
                user.ErrorMessage="Please enter your username and password first!!!";
                return View("Index",user);
            }
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

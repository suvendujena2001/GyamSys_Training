using CoreMVC_Practice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreMVC_Practice.Controllers
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
           // ViewData["Message"] = "Hello from viewdata";
            //ViewBag.Message = "hello from viewbag";
            //TempData["Message"] = "message from tempdata";
            ViewBag.message=string.Empty;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login(User user)
        {
            ViewBag.message = string.Empty;
            if (user != null && user.Username!=null && user.Password!=null)
            {
                if (user.Username == "admin" && user.Password == "password")
                {
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    ViewBag.message = "enter valid username and password";
                    return View("Index");
                }
            }
            else
            {
                ViewBag.message = "enter username and password";
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

using Microsoft.AspNetCore.Mvc;
using MVC_ER.Models;
using System.Diagnostics;

namespace MVC_ER.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmpDbContext _empDbContext;

        public HomeController(ILogger<HomeController> logger, EmpDbContext Context)
        {
            _logger = logger;
          _empDbContext = Context;
        }

        public IActionResult Index()
        {
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

        public IActionResult Login(string username, string Password)
        {

            if (username.ToLower() == "admin" && Password.ToLower() == "password" && (username != null || Password != null))
            {
                return RedirectToAction("Index", "Emp");
            }
            else
            {
                return View("Emp");
            }
        }
    }
}

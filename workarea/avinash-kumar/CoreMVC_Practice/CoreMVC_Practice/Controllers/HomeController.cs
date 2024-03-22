using CoreMVC_Practice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreMVC_Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext DbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(EmployeeDbContext dbContext, ILogger<HomeController> logger)
        {
            this.DbContext=dbContext;
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
            User userFromDb=DbContext.Users.Where(x => x.Username ==user.Username && x.Password==user.Password).FirstOrDefault();
            ViewBag.message = string.Empty;
            if (user != null && user.Username!=null && user.Password!=null)
            {
                if (userFromDb!=null)
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

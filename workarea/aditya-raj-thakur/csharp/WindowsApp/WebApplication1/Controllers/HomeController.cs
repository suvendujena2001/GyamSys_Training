using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmployeeDbContext Context;

        public HomeController(ILogger<HomeController> logger,EmployeeDbContext dbContext)
        {
            _logger = logger;
            this.Context = dbContext;
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
        public IActionResult Login(User user)
        {    ViewBag.message = string.Empty;
            User userdb = Context.Users.Where(x => x.Username == user.Username && x.Password == user.Password).FirstOrDefault();
        
            if (user!=null && user.Username != null && user.Password !=null)
            {
                if(userdb!=null)
                {
                    return RedirectToAction("Index", "Employee");
                }
               return View("Index");
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

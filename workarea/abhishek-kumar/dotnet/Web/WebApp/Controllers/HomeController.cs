using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Web.DataAccess.Data;
using Web.Models;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger , AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }
      


        public IActionResult Index()
            
        {
          

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login(User user)

        {
            

            User? usefromDb =_db.Users.Where(x => x.UserName == user.UserName && x.Password == user.Password).FirstOrDefault();

                if (usefromDb == null )
                {
                    
                    ViewBag.ErrorMessage = "Please enter both username and password.";
                    return View("Index");
                }
                else if (usefromDb != null)
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

using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmpDetails : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login(String Name, String Password)
        {
            if(Name.ToLower() == "admin" &&  Password.ToLower() == "password") 
            {   
                return RedirectToAction("Index", "db");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}

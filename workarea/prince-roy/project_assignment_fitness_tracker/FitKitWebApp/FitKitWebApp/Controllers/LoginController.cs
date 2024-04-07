using Microsoft.AspNetCore.Mvc;

namespace FitKitWebApp.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

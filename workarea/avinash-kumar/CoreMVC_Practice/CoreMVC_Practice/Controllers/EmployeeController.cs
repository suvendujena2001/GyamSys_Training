using Microsoft.AspNetCore.Mvc;

namespace CoreMVC_Practice.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

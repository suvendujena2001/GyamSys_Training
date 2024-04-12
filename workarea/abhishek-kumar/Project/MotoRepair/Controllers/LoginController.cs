using MotoRepair.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MotoRepair.Controllers
{
    public class LoginController : Controller
    {

        private string url = "https://localhost:7261/";

        private readonly HttpClient _httpClient;


        public LoginController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Logindetails user)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View();
                }
                var json = JsonConvert.SerializeObject(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("api/login", data);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadFromJsonAsync<Users>();

                    if (responseBody.UserType == "Admin")
                    {
                        return RedirectToAction("AdminDashboard", "Login");
                    }
                    if (responseBody.UserType == "Customer")
                    {
                        return RedirectToAction("CustomerDashboard", "Login");
                    }

                }
               /* else if (response.IsSuccessStatusCode && response..UserType == "Customer")
                //{
                //    return RedirectToAction("CustomerDashboard", "Login");
                //}*/
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                  
                    return RedirectToAction("Index");
                }
            
         return View();


        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Error", "Home");
            }

           
        }

        public IActionResult Signup() { 
        
        return View();
        }
        [HttpPost]
        public async Task<IActionResult> Signup(Users user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Users", data);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadFromJsonAsync<Users>();

                if (responseBody.UserType == "Admin")
                {
                    return RedirectToAction("AdminDashboard", "Login");
                }
                if (responseBody.UserType == "Customer")
                {
                    return RedirectToAction("CustomerDashboard", "Login");
                }


            }
            return View();
        }
        public IActionResult AdminDashboard() {
            
          
            return View();
        }
        public IActionResult CustomerDashboard()
        {
           
            return View();
        }
    }
    
}
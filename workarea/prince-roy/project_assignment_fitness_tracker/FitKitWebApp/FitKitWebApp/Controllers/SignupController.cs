using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FitKitWebApp.Controllers
{
    public class SignupController : Controller
    {

        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;

        public SignupController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

        private static string TitleCase(string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserCredentials user)
        {
            try
            {
                user.FirstName = TitleCase(user.FirstName);
                user.LastName = TitleCase(user.LastName);
                user.CreatedBy = $"{user.FirstName} {user.LastName}";
                user.ModifiedBy = $"{user.FirstName} {user.LastName}";
                user.CreatedDate = DateTime.Now;
                user.ModifiedDate = DateTime.Now;
                user.Active = true;

                var json = JsonConvert.SerializeObject(user);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/UserCredentials", data);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();

                    return View("Error");
                }
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
    }
}

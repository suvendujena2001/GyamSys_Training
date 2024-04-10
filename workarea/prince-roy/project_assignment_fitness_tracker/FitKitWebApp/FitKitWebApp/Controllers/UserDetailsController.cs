using FitKitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;
using System.Text;

namespace FitKitWebApp.Controllers
{
    public class UserDetailsController : Controller
    {
        private string url = "https://localhost:7051/";

        private readonly HttpClient _httpClient;

        public UserDetailsController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(url);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserDetails userDetails)
        {
            try
            {
                userDetails.CreatedAt = DateTime.Now;
                userDetails.ModifiedDate = DateTime.Now;

                //var currentUser = GetCurrentUser();
                var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
                var userId = "";
                if (userIdClaim != null)
                {
                    userId = userIdClaim.Value;
                }

                int createdBy;
                int modifiedBy;

                bool success1 = int.TryParse(userId, out createdBy);
                bool success2 = int.TryParse(userId, out modifiedBy);

                userDetails.CreatedBy = createdBy;
                userDetails.ModifiedBy = modifiedBy;


                var json = JsonConvert.SerializeObject(userDetails);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync("api/UserDetails", data);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

            return View();
        }

        private UserClaimsModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                var userClaims = identity.Claims;

                return new UserClaimsModel
                {
                    UserId = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value,
                    EmailAddress = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                    GivenName = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value,
                    Surname = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value,
                };
            }

            return null;
        }
    }
}

using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Api.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class LoginController : Controller

    {

        private readonly IConfiguration _configuration;

        private readonly ApiDbContext _context;

        public LoginController(IConfiguration configuration, ApiDbContext context)

        {

            _configuration = configuration;

            _context = context;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginDetails login)
        {

            var user = _context.Users.FirstOrDefault(u => u.UserName.ToLower() == login.UserName.ToLower() && u.Password.ToLower() == login.Password.ToLower());

            if (user != null)

            {

                //var token = GenerateJwtToken(user);

                return Ok(user);

            }

            return Unauthorized();

        }

        //private string GenerateJwtToken(UserCredential user)

        //{

        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //    var claims = new[]

        //    {

        //        new Claim(ClaimTypes.NameIdentifier, user.UserName),

        //        new Claim(ClaimTypes.Email, user.UserEmail),

        //        new Claim(ClaimTypes.GivenName, user.FirstName),

        //        new Claim(ClaimTypes.Surname, user.LastName)

        //    };

        //    var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],

        //        _configuration["Jwt:Audience"], claims, expires: DateTime.Now.AddMinutes(15), signingCredentials: credentials);

        //    return new JwtSecurityTokenHandler().WriteToken(token);

        //}

    }

}

using Microsoft.AspNetCore.Mvc;



namespace BankApplication_With_Controller.Controllers
{
    public class BankController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Bank Application");
        }
        [Route("/account-details")]
        public IActionResult Details()
        {
            var bankAccount = new { accountNumber = 1001, accountHolderName = "Example Name", currentBalance = 5000 };
            return Json(bankAccount);
        }

        [Route("/account-statement")]
        public IActionResult AccountStatement()
        {
            //send a pdf file (at wwwroot folder) as response
            return File("~/sample.pdf", "application/pdf");
        }

        [Route("/get-current-balance/{accountNumber:int?}")]
        public IActionResult CurrentBalance()
        {
            object accountNumberObj;
   if (HttpContext.Request.RouteValues.TryGetValue("accountNumber", out accountNumberObj) && accountNumberObj is string accountNumber)
   {
    // Check if the 'accountNumber' parameter is provided
    if (string.IsNullOrEmpty(accountNumber))
    {
     return NotFound("Account Number should be supplied");
    }

    // Convert the 'accountNumber' to an integer
    if (int.TryParse(accountNumber, out int accountNumberInt))
    {
     // Hard-coded data
     var bankAccount = new { accountNumber = 1001, accountHolderName = "Example Name", currentBalance = 5000 };

     if (accountNumberInt == 1001)
     {
      // If accountNumber is 1001, return the current balance value
      return Content(bankAccount.currentBalance.ToString());
     }
     else
     {
      // If accountNumber is not 1001, return HTTP 400
      return BadRequest("Account Number should be 1001");
     }
    }
    else
    {
     // If the 'accountNumber' provided in the route parameter is not a valid integer, return HTTP 400
     return BadRequest("Invalid Account Number format");
    }
   }
   else
   {
    // If 'accountNumber' is not found in the route parameters, handle the error
    // For example, redirect to an error page or return a specific error message
    // return RedirectToAction("Error");
    return NotFound("Account Number should be supplied");
   }
        }
    }
}

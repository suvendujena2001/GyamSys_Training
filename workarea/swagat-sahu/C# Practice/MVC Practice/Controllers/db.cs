﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class db : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

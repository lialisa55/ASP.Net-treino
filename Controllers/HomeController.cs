﻿using Microsoft.AspNetCore.Mvc;
using MVCSite.Models;
using System.Diagnostics;

namespace MVCSite.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel
            {
                Nome = "Nathalia Monalisa",
                Email = "nathaliamonalisa150@gmail.com"
            };

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
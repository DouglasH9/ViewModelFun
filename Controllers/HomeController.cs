using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Message hello = new Message()
            {
                Content = "Hello hello! Welcome to the home page where we're using a Message model to say hi!"
            };
            return View(hello);
        }
        public IActionResult Numbers()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            
            NumList theNumbers = new NumList()
            {
                NumList.Nums = 1,2,3
            };
            return View(theNumbers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

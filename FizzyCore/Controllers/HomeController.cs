using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FizzyCore.Models;
using System.Text;

namespace FizzyCore.Controllers
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
            return View();
        }

        public IActionResult Solve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Solve(int userIn1, int userIn2)
        {
           var output = "";
            for (int i = 1; i <= 100; i++)
            {
                if(i % userIn1 == 0 && i % userIn2 == 0)
                {
                    output += "FizzBuzz, ";
                }
                else if (i % userIn1 == 0)
                {
                    output += "Fizz, ";
                }
                else if(i % userIn2 == 0)
                {
                    output += "Buzz, ";
                }
                else
                {
                    output += i + ", ";
                }
            }
            ViewData["Output"] = output;
            return View();
        }

        public IActionResult Code()
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

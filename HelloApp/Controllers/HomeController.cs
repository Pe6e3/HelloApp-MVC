using HelloApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloApp.Controllers
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


        public string Name(string myName, int age)
        {
            if (age < 10)
                return "Возраст слишком маленький";

            return $"текст из метода Name().\nИмя: {myName}, возраст: {age}";
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
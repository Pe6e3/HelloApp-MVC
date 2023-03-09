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

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        //public IActionResult Index()
        //{
        //    return Redirect("~/Home/Privacy");
        //}
        public IActionResult Pe6e3()
        {
            return Redirect("https://pe6e3.github.io/");
        }

        public IActionResult TestAction()
        {
            return RedirectToAction("Pe6e3");
        }

        public IActionResult TestAction2()
        {
            Rectangle numbers = new Rectangle();
            numbers.Width = 13;
            numbers.Height = 11;

            //return RedirectToAction("Square2", "Geometry",numbers);
            return RedirectToAction("Square2", "Geometry", new
            {
                Width = 20,
                Height = 10
            });

        }

        public IActionResult TestRedirectToRoute()
        {
            return RedirectToRoute("default", new { controller = "Geometry", action = "Sum", numbers = 20});

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
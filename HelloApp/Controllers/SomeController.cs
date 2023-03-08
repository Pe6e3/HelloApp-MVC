using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers
{
    public class SomeController : Controller
    {
        [NonAction]
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("Banan")] // метод Test() будет вызываться по ссылке https://localhost:7013/Some/Banan 
        public string Test()
        {
            return "Banan!";
        }
    }
}

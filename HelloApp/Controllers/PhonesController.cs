using HelloApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers;

public class PhonesController : Controller
{
    private MobileContext _db;
    public PhonesController(MobileContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<Phone> phones = _db.Phones.ToList();
        return View(phones);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Phone phone)
    {
        if (phone != null)
        {
            _db.Phones.Add(phone);
            _db.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
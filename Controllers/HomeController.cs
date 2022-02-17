using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetcoremvc2.Interface;
using dotnetcoremvc2.Models;

namespace dotnetcoremvc2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // private Ipeople _people;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger; 
    }

    // public IActionResult Index()
    // {
    //     Set("ThanhDepTraiCookie", "This is my first Cookie", 10);
    //     HttpContext.Session.SetString("ThanhSession", "This is my mvc session");
    //     return View(_people.List());
    // }

    // public IActionResult AddPeople()
    // {
    //     return View();
    // }

    // public IActionResult Test()
    // {
    //     return Content(_sender.PrintToScreen());
    // }

    // public IActionResult SampleView()
    // {
    //     return View();
    // }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }
    // public IActionResult Edit(int id )
    // {
    //     var person = _people.Where(x=>x.Id==id).FirstOrDefault();
    //     return View(person);    
    // }

    // [HttpPost]
    // public IActionResult Edit(PersonModel person)
    // {
    //     _people.Edit(person);
    //     return RedirectToAction("Index");
    // }

    // public IActionResult Detail(int id)
    // {
    //     var personDetail = _people.List().Where(x => x.Id == id).FirstOrDefault();
    //     return View(personDetail);
    // }

    // public IActionResult Delete(int id)
    // {
    //     var person = _people.Delete(id);
    //     return RedirectToAction("Index");
    // }

    // public IActionResult AddPeople(PersonModel model)
    // {
    //     _people.AddPeople(model);
    //     return RedirectToAction("Index");
    // }

    // private void Set(string key, string value, int? expireTime)
    // {
    //     CookieOptions options = new CookieOptions();
    //     if(expireTime.HasValue)
    //     {
    //         options.Expires = DateTime.Now.AddMinutes(expireTime.Value);
    //     }
    //     else
    //     {
    //         options.Expires = DateTime.Now.AddSeconds(30);
    //     }
    //     Response.Cookies.Append(key, value, options);
    // }

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

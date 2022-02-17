using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetcoremvc2.Models;
using dotnetcoremvc2.Interface;

namespace dotnetcoremvc2.Controllers;

public class PeopleController : Controller
{
    private readonly ILogger<PeopleController> _logger;

    public IPeople _people;
    public PeopleController(ILogger<PeopleController> logger, IPeople people)
    {
        _logger = logger;
        _people = people;
    }    
    public IActionResult Index()
    {
        return View(_people.List());
    }

    public IActionResult Detail(int id)
    {
        var personDetail = _people.List().Where(x => x.Id == id).FirstOrDefault();
        return View(personDetail);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(PersonModel model)
    {
        _people.Create(model);
        return RedirectToAction("Index");
    }
    public IActionResult Update(int id )
    {
        var person = _people.List().Where(x=>x.Id==id).FirstOrDefault();
        return View(person);
    }
    [HttpPost]
    public IActionResult Update(PersonModel person)
    {
        _people.Update(person);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {  
        var p = _people.Delete(id);
       return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

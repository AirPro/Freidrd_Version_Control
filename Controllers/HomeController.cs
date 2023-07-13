using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Freidrd_Version_Control.Models;

namespace Freidrd_Version_Control.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult Index()
    // {
    //     return View();
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public JsonResult Index()
    {
        return Json(new Person{Id = 1, FirstName = "Bob", LastName="Freid"});
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

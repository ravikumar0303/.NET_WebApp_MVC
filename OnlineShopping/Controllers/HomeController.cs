using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        Console.WriteLine("Home Controller Constructor is invoked.");
    }

    ~HomeController(){
        Console.WriteLine("Home Controller Destructor is called...");
    }

    //set of Action Methods

    public IActionResult Index()
    {
         Console.WriteLine("Home Controller  Index method is invoked.");
        return View();
    }

    public IActionResult Privacy()
    {
           Console.WriteLine("Home Controller  Privacy method is invoked.");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

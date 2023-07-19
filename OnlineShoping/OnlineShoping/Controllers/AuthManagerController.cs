using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShoping.Models;

namespace OnlineShoping.Controllers;

public class AuthManagerController : Controller
{
    private readonly ILogger<AuthManagerController> _logger;

    public AuthManagerController(ILogger<AuthManagerController> logger)
    {
        _logger = logger;
    }

    public IActionResult login()
    {
        return View();
    }

    public IActionResult registration()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult register()
    {
        return RedirectToAction("login");
    }


}

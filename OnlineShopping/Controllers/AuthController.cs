using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers;
public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    //set of Action Methods
    
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    
}

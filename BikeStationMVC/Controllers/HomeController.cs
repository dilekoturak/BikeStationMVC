using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BikeStationMVC.Models;

namespace BikeStationMVC.Controllers;

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

    public IActionResult BikeList()
    {
        return View();
    }

    public IActionResult Station()
    {
        return View();
    }
}


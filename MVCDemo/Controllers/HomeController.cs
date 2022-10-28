using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Interfaces;
using MVCDemo.Models;

namespace MVCDemo.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;
    private readonly IRepository repository;

    public HomeController(/*ILogger<HomeController> logger,*/ IRepository repository)
    {
        //_logger = logger;
        this.repository = repository;
    }

    public IActionResult Index()
    {
        var model = repository.Cars;

        return View(model);
    }

    public IActionResult Create()
    {
        ElectricCar electricCar = new ElectricCar();
        FuelCar fuelCar = new FuelCar();

        Car electricCarAsCar = electricCar as Car;
        Car fuelCarAsCar = fuelCar as Car;
        repository.Add(electricCarAsCar);
        repository.Add(fuelCarAsCar);
        repository.SaveChanges();

        return RedirectToAction(nameof(Index));
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


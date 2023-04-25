using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HW17_ParnianRafie_m91.Models;
using Repositories;
using AppCore.Entities;

namespace HW17_ParnianRafie_m91.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    private readonly Repository _repository;


    public HomeController(Repository repository)
    {
        _repository = repository;
    }

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    public IActionResult Index()
    {
        List<Teacher> st=_repository.h();
        return View();
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


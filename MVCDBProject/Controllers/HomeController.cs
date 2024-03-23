using Microsoft.AspNetCore.Mvc;
using MVCDBProject.Models;
using System.Diagnostics;

namespace MVCDBProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Var1 = "msg from view bag";
            ViewData["Var2"] = "msg from view data";
            TempData["Var3"] = "msg from temp data";
            string[] games = { "cricket", };
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Var1 = "msg from view bag";
            ViewData["Var2"] = "msg from view data";
            TempData["Var3"] = "msg from temp data";
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Var1 = "msg from view bag";
            ViewData["Var2"] = "msg from view data";
            TempData["Var3"] = "msg from temp data";
            return View();
        }     
    }
}

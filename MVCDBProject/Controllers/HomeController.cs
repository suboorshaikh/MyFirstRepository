using Microsoft.AspNetCore.Mvc;
using MVCDBProject.Models;
using System.Diagnostics;

namespace MVCDBProject.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            var date=  DateTime.Now;
            ViewBag.Var1 = date ;
            ViewData["Var2"] = "msg from view data";
            TempData["Var3"] = "msg from temp data";
             return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Var2"] = "msg from view data";
            if (TempData["Var3"] != null) 
            {
                TempData["Var3"].ToString();
            }
            TempData.Keep();
            return View();
        }
        public IActionResult Contact()
        {
            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }
            return View();
        }
           
    }
}

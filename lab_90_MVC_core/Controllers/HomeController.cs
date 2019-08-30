using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab_90_MVC_core.Models;

namespace lab_90_MVC_core.Controllers
{
    public class HomeController : Controller
    {

        public List<String> list = new List<string>();
        // default if nothing else requested
        public IActionResult Index()
        {
            var instance = new ListClass();
            instance.list.Add("One");
            instance.list.Add("Two");

            list.Add("One");
            list.Add("Two");
            ViewBag.pageList = list;
            return View("Contact", instance);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View("../Phil/Phil");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
}

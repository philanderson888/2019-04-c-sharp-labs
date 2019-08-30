using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_67_razor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewData["Message2"] = "And A Second Message";
            return View();
        }

        public ActionResult RazorHelloWorld()
        {
            ViewData["Message2"] = "And A Second Message";
            ViewBag.Message = "Second razor page";
            var PassThisString = "Send some data from controller to view";

            return View("RazorHelloWorld");
        }
    }
}
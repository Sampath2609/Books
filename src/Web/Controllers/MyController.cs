using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowInfo()
        {
            return Content("I am Sampath");
        }
        public IActionResult ShowJSon()
        {
            return Json(new
            {
                name = "Sampath Vagicharla"
            });
        }

        public IActionResult showHTML()
        {
            var s = "<!DOCTYPE HTML><html><head>Sampath Vagicharla!</head><body> I am Sampath Vagicharla.</body></html>";
            return Content(s, "text/html");
        }

        public IActionResult App()
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

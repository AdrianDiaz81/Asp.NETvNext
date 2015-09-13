using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Configuration;

namespace ADC.ASP.vNext.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration config;
        public HomeController(IConfiguration cfg)
        {
            config = cfg;
        }
        
       
        public IActionResult Index()
        {
           var data= config.Get("AppSettings:SiteTitle");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description pagina.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}

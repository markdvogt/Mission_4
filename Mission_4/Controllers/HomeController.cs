using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, ApplicationContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FillOutForm()
        {
            return View("Form");
        }

        [HttpPost]
        public IActionResult FillOutForm(FormResponse fr)
        {
            if (!ModelState.IsValid)
            {
                return View("Form");
            }
 
            blahContext.Add(fr);
            blahContext.SaveChanges();
            return View("Confirmation", fr);
            
        }

        public IActionResult Podcast()
        {
            return View("Podcasts");
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

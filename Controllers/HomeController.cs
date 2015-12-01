using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using meetups.Models;
using Microsoft.Extensions.PlatformAbstractions;

namespace meetups.Controllers
{
    public class HomeController : Controller
    {
        private IApplicationEnvironment _appEnvironment;
        public HomeController(IApplicationEnvironment appEnvironment) 
        {
            _appEnvironment = appEnvironment;
        }
        
        public IActionResult Index()
        {
            string path = _appEnvironment.ApplicationBasePath; 
            var meetups = Meetup.GetAll(path + "/meetups-lisbon.json");
            return View(meetups);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Ricardo Fiel";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

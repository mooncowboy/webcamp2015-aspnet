using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using meetups.Models;

namespace meetups.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var meetups = Meetup.GetAll();
            return View(meetups);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

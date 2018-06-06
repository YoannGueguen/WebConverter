using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebConvertor.Models;

namespace WebConvertor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost][HttpGet]
        public IActionResult ConvertKilometersToMiles(double kilometer)
        {
            ViewData["miles"] = Test.TestConverter.GivenConvertKilometersToMiles(kilometer);

            return View("Index");
        }
        [HttpPost][HttpGet]
        public IActionResult ConvertMilesToKilometers(double miles)
        {
            double kilometer = Test.TestConverter.GivenConvertKilometersToMiles(miles);
            return View(kilometer);
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

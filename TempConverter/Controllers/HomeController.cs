using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TempConverter.Models;

namespace TempConverter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }//Index()
        public IActionResult About()
        {
            return View();
        }//About ()
        public IActionResult Temperature()
        {
            return View(new TemperatureModel()); //view with ViewModel
        }//Temperature
        public IActionResult Weights()
        {
            return View(new WeightsModel());//view with ViewModel
        }//Weights

        [HttpPost]
        public IActionResult WeightsResult(WeightsModel model) //binding Model
        {
            if (ModelState.IsValid)//check if the model is valid
            {
                return View(model); //view with ViewModel
            }//end if
            return View("Weights", model);
        }//WeightsResult ()

        [HttpPost]
        public IActionResult Temperature(TemperatureModel model)//binding Model
        {
            if (ModelState.IsValid)//check if the model is valid
            {
                ViewBag.RoundTrip = "RoundTrip";
                return View(model);//view with ViewModel
            }//ModelState if

            return View(model);//view with ViewModel
        }//Temperature
    }//Controller
}//namespace 
 

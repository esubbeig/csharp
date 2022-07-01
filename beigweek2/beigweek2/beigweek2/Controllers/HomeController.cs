using Microsoft.AspNetCore.Mvc;

//Created by Beig

namespace beigweek2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //declare a variable to hold the current year.
            String todaysDate = DateTime.Now.Date.ToShortDateString();
            //variable to hold a welcome message
            String myName = "Esub Beig";
            String welcomeMessage = $"Welcome to {myName}"; //string interpolation.

            //send this data to the Index view using the viewData and ViewBag objects.
            ViewBag.todaysDate = todaysDate;
            ViewData["welcome"] = welcomeMessage;

            return View();
        }//Index()
    }//end class HomeController
}//end namespace

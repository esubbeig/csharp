using BeigWeek2.Models;
using Microsoft.AspNetCore.Mvc;

//created by Beig
namespace BeigWeek2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            return View(new WelcomeModel());
        }//Index()


        [HttpPost]
        public IActionResult Index(WelcomeModel welcomemodel)//incoming parameter is the binding model.
        {
            return View("Welcome", welcomemodel);//when user has submitted the data, we return the results page i.e., the Welcome View.

        }


    }//HomeController
}//Namespace

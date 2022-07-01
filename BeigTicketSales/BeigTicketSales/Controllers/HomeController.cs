using Microsoft.AspNetCore.Mvc;

namespace BeigTicketSales.Controllers
{
    public class HomeController : Controller
    {

        //Action methods for Home page and About page.
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}

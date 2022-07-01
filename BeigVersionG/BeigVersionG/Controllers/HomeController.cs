//Esub Beig
//700727173

using BeigVersionG.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeigVersionG.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new BeigModel());
        }//Index()

        [HttpPost]
        public IActionResult Index(BeigModel model)
        {
            bool called = false;
            if (ModelState.IsValid)// validating the model.
            {
                called = true;
                ViewBag.called = called;
                return View(model);
            }
            return View(model);
        }//Index(model)
    }//Controller()
}//namespace

using CarSummary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarSummary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new AreaModel());
        }
        public IActionResult Result(AreaModel model)
        {
            String result = "";
            if (ModelState.IsValid)
            {
                if(model.Side1 == model.Side2)
                {
                    int area = model.Side1 * model.Side2;
                    result = $"Shape is Square and the Area is {area}";
                }
                else
                {
                    int area = model.Side1 * model.Side2;
                    result = $"Shape is Rectangle and the Area is {area}";
                }
                ViewBag.result = result;
            }
            return View("Index",model);
        }
    }
}

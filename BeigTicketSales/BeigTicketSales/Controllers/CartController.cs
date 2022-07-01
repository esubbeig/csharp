using BeigTicketSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeigTicketSales.Controllers
{
    //Esub Beig
    public class CartController : Controller
    {
        public IActionResult Buy(int id)
        {
            //gets the ID of event that the user wants to buy ticket for
            //then using the EventsSercice gets an object representing the event.

            EventsService eventsService = new EventsService();
            Event selectedEvent = eventsService.GetEvent(id);

            //start sale by creating Sale object and setting name of the event and ticket
            //price. (Constructor of the sale object - if you recall).
            Sale newSale = new Sale(selectedEvent.Title, selectedEvent.TicketPrice);
            return View(newSale);
        }//Buy()

        public IActionResult Confirmation(Sale model)
        {
            //the binding model contains the form data for buying ticket.
            if (ModelState.IsValid)
            {
                //call the salesObject's method to calculate sale price
                model.ProcessSale();

                //pass the sale object to the Confirmation view as viewmodel to display sale confirmation.
                return View(model);
            }//model valid
            else
            {
                return View("Buy", model);
            }//else: do not valid (erros)
        }//confirmation
    }//cartcontroller
}//namespace

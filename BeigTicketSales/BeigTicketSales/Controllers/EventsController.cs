using BeigTicketSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeigTicketSales.Controllers
{
    /*
     * Esub Beig
     * This control returns the list of events and event details.
     * Uses the Events Service to send data and get the event details for displaying the views.
     */
    public class EventsController : Controller
    {
        public IActionResult EventList(string id = "All")
        {
            //uses EventsService to get the events, either all if no incoming value,
            //or based on the id of the event.

            //instantiate EventsService class.
            EventsService eventsService = new EventsService();

            //list of categories
            List<Category> categories = eventsService.GetCategories(); //gets all categories.

            //list of events
            List<Event> events = new List<Event>(); //instantiating events list

            //get the events based on category id.
            if(id == "All")
            {
                //Gets all events from the events service.
                events = eventsService.GetAllEvents();
            }
            else
            {
                //ID user asks for categoru of events. so based on id, find the category being asked for
                // then use the category to return all events of the type

                //Variable to hold category id
                int selectedCategoryId = 0;
                //loop through the categories to find the category id
                foreach(Category cat in categories)
                {
                    if (cat.Name == id)
                    {
                        selectedCategoryId = cat.ID;
                    }
                }//foreach to find category

                foreach (Event anEvent in eventsService.GetAllEvents())
                {
                    if(anEvent.CategoryID == selectedCategoryId)
                    {
                        events.Add(anEvent);
                    }
                }//foreach  to find events
            }

            //this action method uses a view model: ListViewModel in order to return the collecitton of evetns.
            ListViewModel viewModel = new ListViewModel(events, categories, id);//the constructor for the ListViewModel takes 3 arguments.


            return View(viewModel);
        }//EventList()
        public IActionResult Details(int id)
        {
            EventsService eventsService = new EventsService();
            Event oneEvent = eventsService.GetEvent(id);
            return View(oneEvent);
        }//Details()
    }//EventsController
}//namespace

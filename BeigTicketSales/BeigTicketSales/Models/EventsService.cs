namespace BeigTicketSales.Models
{
    //Esub Beig
    /*
     * This a class that creates a list of events with ech event of type Event (class).
     * Creates a list of categories, with each category of type category(class).
     * Has two methods: GetEvents() which returns events based on incoming parameter category and GetCategories() that return the list of categories or events. The third method GetAllEvents() will return all categories.
     */
    public class EventsService
    {
        private List<Event> allEvents = new List<Event>()
        {
            new Event()
            {
                ID = 100,
                Title = "The Lion King",
                CategoryID = 1,
                TicketPrice = 50,
                Description = "Musical Based on Disney's animated movie.",
                ImageID = "100.png"
            },
            new Event()
            {
                ID = 200,
                Title = "Holiday Spectacular",
                CategoryID = 2,
                TicketPrice = 40,
                Description = "Holiday extravaganza for the entire family.",
                ImageID = "200.png"
            },
            new Event()
            {
                ID = 300,
                Title = "Mary Poppins",
                CategoryID = 1,
                TicketPrice = 50,
                Description = "The popular musical with seven Tony awards.",
                ImageID = "300.png"
            },
            new Event()
            {
                ID = 400,
                Title = "Taylor Swift",
                CategoryID = 2,
                TicketPrice = 90,
                Description = "Popular singer and songwriter.",
                ImageID = "400.png"
            }
        };
        private List<Category> categories = new List<Category>()
        {
            new Category()
            {
                ID=1,
                Name="Theatre Show"
            },
            new Category(){
                ID=2,
                Name="Concert"
            }
        };
        public Event GetEvent(int id)
        {
            //incoming parameter id comes from the <a> link in the Details view, wherre id is either "All" or a specific category name(@cat.Name).

            //Finds an even based on ID
            Event? selectedEvent = null;
            foreach(Event anEvent in allEvents)
            {
                if(anEvent.ID == id)
                {
                    selectedEvent = anEvent;
                }//if
            }
            return selectedEvent;
        }//GetEvent()
        public List<Category> GetCategories()
        {
            //return categories as a list.
            return categories;
        }//GetCategories()
        public List<Event> GetAllEvents()
        {
            return allEvents; //returns all events.
        }
    }//EventServices
}//namespace

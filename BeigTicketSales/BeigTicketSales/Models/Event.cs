namespace BeigTicketSales.Models
{
    //Esub Beig
    /*
     * This calss creates type for Events.
     * Each event has an event name that is Title,and a description for
     * the event the category to which the event belongs to
     * Ticket price for the event and has an image to display.
     */
    public class Event
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public int CategoryID { get; set; }
        public double TicketPrice { get; set; }
        public string? Description { get; set; }
        public string? ImageID { get; set; }
    }
}

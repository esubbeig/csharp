using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BeigTicketSales.Models
{
    //Esub Beig
    /*
     * This is the supporting model for the Buy view which as a form with access this calss's properties.
     * This calss has an overloaded constructor with two signatures: ad default constructor, and one with parameters for event name for sale and Ticket price.
     * The parametrized constructor is called from the Cart controller's "Buy" action method, to send the Sale model as a viewModel for sale of aspecific event 
     * and ticket price that has been selected by the user to receive further information about the evnet user chooses to buy tickets for.(supports the buy form). 
     */
    public class Sale
    {
        /*Ther are several properties in this class constructor that receives eventName and ticketprice, and also a default constructor without any method body or
         * parameters because there is a defined constructor in the calss as well. The default constructor will be needed for the binding model.
        */
        //And two method: calculate Discount() and processSale() methods.
        //one selectlistItem collection for dropdown.

        //properties and variable first:
        public string? EventName { get; set; }
        public string? CustomerName { get; set; }
        [Required(ErrorMessage = "Email is required field.")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email address")]
        public string EmailAddress { get; set; }
        public double TicketPrice  { get; set; }
        public string? SaleDate { get; set; }
        [Required(ErrorMessage ="Please enter number of tickets")]
        public int Count { get; set; }
        public bool SeniorDiscount { get; set; }
        [Required(ErrorMessage ="Please select a Delivery Option")]
        public string? SelectedDelivery { get; set; }//for select dropdown

        //other properties

        public double SubTotal { get; set; }
        public double SaleDiscount { get; set; }
        public double DeliveryCharge { get; set; }
        public double AmountDue { get; set; }

        // variable for select dropdown:
        public List<SelectListItem> DeliveryOptions = new List<SelectListItem>
        {
            new SelectListItem {Text = "Mail", Value="Mail"},
            new SelectListItem {Text = "Print", Value="Print at Home"},
            new SelectListItem {Text = "Digital", Value="Digital Ticket"},
            new SelectListItem {Text = "Call", Value="Will Call"}
        };

        public Sale()
        {
            //Default constructor without method parameters or body this will be required for binding model.
        }//ctor
         public Sale(string? eventName, double ticketPrice)
        {
            EventName = eventName;
            TicketPrice = ticketPrice;
        }//ctor

        public void CalculateDiscount()
        {
            const double SENIOR_DISCOUNT = 0.2D;
            SaleDiscount = SubTotal + SENIOR_DISCOUNT;
        }//CalculateDiscount()

        public void ProcessSale()
        {
            //calculates the sale value sand sets the sale date.
            SaleDate = DateTime.Today.ToShortDateString();
            SubTotal = TicketPrice * Count;
            CalculateDiscount();//seniordiscount if
            if (SelectedDelivery == "Mail")
            {
                DeliveryCharge = 3.95;
            }
            else
            {
                DeliveryCharge = 0;
            }
            AmountDue = SubTotal = SaleDiscount + DeliveryCharge;
        }
    }//class
}//namespace

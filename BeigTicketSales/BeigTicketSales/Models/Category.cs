namespace BeigTicketSales.Models
{
    //Esub Beig
    /*
     * This class creates a type for categories
     * This is the class for categories of shows. (theater shows and concerts)
     * Each category has two properties. Category id, and category name
     */
    public class Category
    {
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}

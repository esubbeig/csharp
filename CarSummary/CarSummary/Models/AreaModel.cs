using System.ComponentModel.DataAnnotations;

namespace CarSummary.Models
{
    public class AreaModel
    {
        [Range(1,100,ErrorMessage= "Side 1 Should be a number between 1 and 100")]
        [Display(Name = "lease Enter Side1 as an Integer")]
        public int Side1 { get; set; }

        [Range(1, 100, ErrorMessage = "Side 2 Should be a number between 1 and 100")]
        [Display(Name = "lease Enter Side2 as an Integer")]
        public int Side2 { get; set; }
    }
}

//Esub Beig
//700727173

using System.ComponentModel.DataAnnotations;

namespace BeigVersionG.Models
{
    public class BeigModel
    {
        // We need two properties for Distance and Conversion type
        // First property is textbox for Distance which accepts only integer
        [Display(Name="Please Enter Distance as a number")]
        [Required(ErrorMessage = "Distance can't be blank")]
        [Range(1, 500, ErrorMessage = "Please enter a number between 1 and 5000")]
        public int Distance { get; set; }

        // Second property is for ConvertionType which will be radio button
        [Required(ErrorMessage = "Please Select Miles or Kilometers to Convert")]
        public string? ConversionType { get; set; }

        // This method convert the km into and km into miles and returs a string result.
        public string Conversion()
        {
            double mile = 1.60934;
            double km = 0.621371;

            string result;

            // Checking whether ConvertionType is km or mile
            if (ConversionType != null && ConversionType == "Km")
            {
                km = mile * Distance;
                result = $"{Distance} miles = {km} kilometers";
            }
            else
            {
                mile = km * Distance;
                result = $"{Distance} kilometers = {mile} miles";
            }

            return result;
        }//Converion()
    }//BeigModel
}//namespace

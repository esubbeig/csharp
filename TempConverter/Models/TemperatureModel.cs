using System.ComponentModel.DataAnnotations;
/*
Created by Dr. Paravastu
filename: TemperatureModel.cs
*/
namespace TempConverter.Models
{
    public class TemperatureModel
    {
        /* 
         * Properties with Data Valadation annotations.
         * Data validation annotations will require using statement for dataAnnotations (above)
         * There are two properties and one method which does the calculation.
         */
        //Property for textbox.
        [Required(ErrorMessage = "Please enter Temperature")]
        [Display(Name = "Please enter Temperature as a decimal or integer")]
        public decimal Temperature { get; set; }

        //property for radiobuttons
        [Required(ErrorMessage = "Please Select Farenheit or Celcius")]
        public String? TemperatureUnit { get; set; }

        public string ConvertTemp()
        {
            decimal conversionResult = 0;
            string result = "";
            switch (TemperatureUnit)
            {
                case "F2C":
                    //Formula: (F-32) × 5 / 9 = C
                    conversionResult = (Temperature - 32) * 5 / 9;
                    result = $" {Temperature} degrees F{conversionResult} degrees C";
                    break;
                case "C2F":
                    //(C x 9/5)+ 32= F
                    conversionResult = (Temperature * 9 / 5) + 32;
                    result = $"{Temperature}&deg; C = {conversionResult}&deg; F";
                    break;

            }//switch
            return result;
        }//ConvertTemp
    }//TemperatureModel
}//namespace


using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

/*
Created by Gopi
FileName: WeightsModel.cs
*/

namespace TempConverter.Models
{
    public class WeightsModel
    {
        //Property for textbox
        [Display(Name = "Please Enter Weight in Pounds")]
        [Range(30, 300, ErrorMessage = "You weight in Lbs. between 30 and 300")]
        public int Weight { get; set; }

        //property for select dropdown
        [Display(Name = "Please select Planet: ")]
        public string? Planet { get; set; }

        //List for select Dropdown
        public List<SelectListItem> Planetlist { get; set; } = new List<SelectListItem>
      {
          new SelectListItem{Value = "Sun",Text="Sun"},
          new SelectListItem{Value = "Mercury",Text = "Mercury"},
          new SelectListItem{Value = "Venus",Text = "Venus"},
          new SelectListItem{Value = "Earth",Text = "Earth"},
          new SelectListItem{Value = "Moon",Text="Moon"},
          new SelectListItem{Value = "Mars",Text="Mars"},
          new SelectListItem{Value = "Jupiter",Text="Jupiter"},
          new SelectListItem{Value = "Saturn",Text = "Saturn"},
          new SelectListItem{Value = "Uranus",Text = "Uranus"},
          new SelectListItem{Value = "Neptune",Text = "Neptune"},
          new SelectListItem{Value = "Pluto",Text="Pluto"}
      };

        //dictionary object for weights:
        private Dictionary<String, double> planetWeights = new Dictionary<string, double>();
        public string GetWeight()
        {
            //adding the dictionary items for planetWeights
            planetWeights.Add("Sun", 27.01);
            planetWeights.Add("Mercury", 0.38);
            planetWeights.Add("Venus", 0.91);
            planetWeights.Add("Earth", 1);
            planetWeights.Add("Moon", 0.166);
            planetWeights.Add("Mars", 0.38);
            planetWeights.Add("Jupiter", 2.34);
            planetWeights.Add("Saturn", 1.06);
            planetWeights.Add("Uranus", 0.92);
            planetWeights.Add("Neptune", 1.19);
            planetWeights.Add("Pluto", 0.06);

            //calculation:the incoming selection in Planet Property serves as the key forr etrieving the value the value from the planetWeights dictionary object.
            return $"Your Weight on of(Weight) lb.on Earth will be equivalent of{planetWeights[Planet] * Weight} lb. on{Planet}.";
        }// GetWeight()
    }//weights model
} //namespace


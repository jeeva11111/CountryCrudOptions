using Microsoft.AspNetCore.Mvc.Rendering;

namespace CountryCrudOptions.Models
{
    public class CountryDropDown
    {
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }


        public List<SelectListItem> Countries { get; set; }
        public List<SelectListItem> States { get; set; }
        public List<SelectListItem> Cities { get; set; }

        public CountryDropDown()
        {

            this.Countries = new List<SelectListItem>();
            this.States = new List<SelectListItem>();
            this.Cities = new List<SelectListItem>();
        }

    }
}

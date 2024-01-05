using System.ComponentModel.DataAnnotations;

namespace CountryCrudOptions.Models
{
    public class Country
    {
        [Key]
        public int countryId { get; set; }
        public string? countryName { get; set; }
    }
}

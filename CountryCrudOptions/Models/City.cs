using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryCrudOptions.Models
{
    public class City
    {
        [Key]
        public int cityId { get; set; }
        public string? cityName { get; set; }
        public int CountryId { get; set; }
        public int stateId { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        [ForeignKey(nameof(CountryId))]
        public Country? Countries { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        [ForeignKey(nameof(stateId))]
        public State? States { get; set; }

    }
}

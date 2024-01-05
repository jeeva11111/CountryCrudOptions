using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace CountryCrudOptions.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string? stateName { get; set; }
        public int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
    }
}

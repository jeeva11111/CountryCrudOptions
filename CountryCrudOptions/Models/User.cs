using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryCrudOptions.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Please Enter the Name")]

        public string? Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please Enter the Email")]

        public string? Email { get; set; }
        [Required(ErrorMessage = "Please select any Gender")]

        [MaxLength(50)]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "Please select any PinCode")]

        public int PinCode { get; set; }
        [Required(ErrorMessage = "Please Enter  PhoneNumber")]

        public int PhoneNumber { get; set; }

        public bool isActive { get; set; }

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }


        [ForeignKey(nameof(CountryId))]
        public Country? Country { get; set; }
        [ForeignKey(nameof(StateId))]
        public State? State { get; set; }
        [ForeignKey(nameof(CityId))]
        public City? City { get; set; }


    }
}

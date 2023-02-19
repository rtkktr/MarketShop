using System.ComponentModel.DataAnnotations;

namespace MarketShop.Web.Models
{
    public class User : BaseModel
    {
        public int CityId { get; set; }

        [Required]
        public string? FName { get; set; }

        [Required]
        public string? LName { get; set; }

        [Required]
        public string? EmailAddress { get; set; }

        [Required]
        public string? TelephoneNumber { get; set; }

        public string? Fax { get; set; }

        [Required]
        public string? CompanyName { get; set; }

        [Required]
        public string? Address { get; set; }

        [Required]
        public string? CityName { get; set; }

        [Required]
        public string? PostalCode { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public City? City { get; set; }
    }
}

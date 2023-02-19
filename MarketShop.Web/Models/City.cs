using System.ComponentModel.DataAnnotations;

namespace MarketShop.Web.Models
{
    public class City : BaseModel
    {
        public int CountryId { get; set; }

        [Required]
        public string? CityName { get; set; }

        [Required]
        public Country? Country { get; set; }
    }
}

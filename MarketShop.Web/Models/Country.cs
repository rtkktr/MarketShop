using System.ComponentModel.DataAnnotations;

namespace MarketShop.Web.Models
{
    public class Country : BaseModel
    {
        [Required]
        public string? CountryName { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace MarketShop.Web.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}

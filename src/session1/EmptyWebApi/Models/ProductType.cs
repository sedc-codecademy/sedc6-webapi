using System.ComponentModel.DataAnnotations;

namespace EmptyWebApi.Models
{
    public class ProductType
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Name should be at least 10 characters long, and maximum 20 characters long")]
        public string Name { get; set; }
    }
}
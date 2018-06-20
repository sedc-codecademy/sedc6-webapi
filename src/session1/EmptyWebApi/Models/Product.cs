using System.ComponentModel.DataAnnotations.Schema;

namespace EmptyWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("ProductType")]
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
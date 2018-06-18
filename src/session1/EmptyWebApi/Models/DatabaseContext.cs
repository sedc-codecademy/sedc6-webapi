using System.Data.Entity;

namespace EmptyWebApi.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
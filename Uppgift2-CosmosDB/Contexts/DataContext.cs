using Microsoft.EntityFrameworkCore;
using Uppgift2_CosmosDB.Models;

namespace Uppgift2_CosmosDB.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToContainer("ProductCatalog").HasPartitionKey(x => x.Id);
        }
    }
}

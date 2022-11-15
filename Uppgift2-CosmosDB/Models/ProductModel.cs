using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Uppgift2_CosmosDB.Models
{
    public class ProductModel
    {
        [Key]
        [JsonProperty("id")]

        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;

        public int ProductNumber { get; set; }

        public string PartitionKey { get; set; } = null!;
    }
}

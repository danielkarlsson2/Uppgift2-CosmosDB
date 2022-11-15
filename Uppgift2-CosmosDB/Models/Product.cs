using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace Uppgift2_CosmosDB.Models
{
    public class Product
    {
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        public string Description { get; set; } = null!;

    }
}

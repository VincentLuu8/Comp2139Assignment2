using System.ComponentModel.DataAnnotations;

namespace SmartInventory.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Category { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
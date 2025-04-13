﻿using System.ComponentModel.DataAnnotations;

namespace SmartInventory.Models
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        
        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        public decimal Total => Quantity * Price;
    }
}
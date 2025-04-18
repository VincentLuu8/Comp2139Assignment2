﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartInventory.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;
        
        public decimal TotalAmount { get; set; }
        
        public ICollection<OrderItems> OrderItems { get; set; } = new List<OrderItems>();
    }
}
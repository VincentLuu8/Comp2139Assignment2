﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SmartInventory.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public string? ContactInfo { get; set; }

        public string? PreferredCategories { get; set; }
    }
}
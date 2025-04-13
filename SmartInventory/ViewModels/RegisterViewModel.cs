using System.ComponentModel.DataAnnotations;

namespace SmartInventory.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }

        public string? ContactInfo { get; set; }

        public string? PreferredCategories { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password are different")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
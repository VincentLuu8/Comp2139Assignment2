using System.ComponentModel.DataAnnotations;

namespace SmartInventory.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Do you Remember Me?")]
        public bool RememberMe { get; set; }
    }
}
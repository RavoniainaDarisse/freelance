using System.ComponentModel.DataAnnotations;

namespace freelance.Models.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress]
        public required string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères.")]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas.")]
        public string? ConfirmPassword { get; set; }
        public string Nom { get; set; } = "default name";
        
        
    }
}
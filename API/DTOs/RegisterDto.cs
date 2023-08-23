using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = PasswordErrorMessage)]
        public string Password { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string Username { get; set; }

        private const string PasswordErrorMessage = "Password must contain at least one digit, one lowercase letter, one uppercase letter and be between 4 and 8 characters.";
    }
}
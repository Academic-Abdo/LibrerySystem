using System.ComponentModel.DataAnnotations;

namespace LibrerySystem.DTOs
{
    public class LoginDTO
    {
        /// <summary>
        /// Customer Email
        /// </summary>
        /// <example>abdulraoof@outlook.com</example>
        [StringLength(100, ErrorMessage = "Email must be less than 100 char long")]
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        /// <summary>
        /// Customer Password
        /// </summary>
        /// <example>***</example>
        [StringLength(250, ErrorMessage = "Password must be less than 250 char long")]
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}

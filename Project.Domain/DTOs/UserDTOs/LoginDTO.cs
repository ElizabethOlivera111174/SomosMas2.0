using System.ComponentModel.DataAnnotations;

namespace Project.Domain.DTOs.UserDTOs
{
    public class LoginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

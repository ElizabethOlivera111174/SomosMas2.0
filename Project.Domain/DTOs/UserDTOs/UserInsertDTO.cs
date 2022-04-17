using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Project.Domain.DTOs.UserDTOs
{
    public class UserInsertDTO
    {
        [Required(ErrorMessage = "Escriba su nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Escriba su apellido")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Escriba su email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Escriba su password")]
        [MinLength(5, ErrorMessage = "su password debe tener mas de 5 caracteres")]
        public string Password { get; set; }
        
        public IFormFile Photo { get; set; }
        
    }
}

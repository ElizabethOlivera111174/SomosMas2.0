using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Project.Domain.DTOs.ActivitiesDTOs
{
    public class ActivitiyInsertDTO
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El content es requerido")]
        public string Content { get; set; }
        [Required(ErrorMessage = "La imagen es requerida")]
        public IFormFile Image { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Project.Domain.DTOs.ActivitiesDTOs
{
    public class ActivitiesDTO
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El content es requerido")]
        public string Content { get; set; }
        public string Image { get; set; }
    }
}


using System.ComponentModel.DataAnnotations;

namespace Project.Domain.DTOs.CategoriesDTOs
{
    public class CategoryDTO
    {
        /// <summary>
        /// Requerido: Nombre de la nueva Category
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Descripcion de la nueva Category
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Imagen de la nueva Category. Solo se aceptan formatos:
        /// .jpg , .jpng , .png
        /// </summary>
        public string Image { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.Entities
{
    public class Category : EntityBase
    {
        [Required(ErrorMessage = "Nombre de la categoria es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName ="VARCHAR(255)")]
        [MaxLength(255)]
        public string Image { get; set; }

    }
}

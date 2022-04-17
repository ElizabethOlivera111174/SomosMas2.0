using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.Entities
{
    public class Role : EntityBase
    {
        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Description { get; set; }
    }
}

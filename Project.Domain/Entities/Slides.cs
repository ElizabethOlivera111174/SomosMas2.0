using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.Entities
{
    public class Slides : EntityBase
    {
        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(4000)")]
        [MaxLength(4000)]
        public string Text { get; set; }

        [Required]
        [Column(TypeName = "INTEGER")]
        public int Order { get; set; }

        //Foreign Key hacia una organizacion
        public int OrganizationId { get; set; }
        [ForeignKey("OrganizationId")]
        public virtual Organizations Organization { get; set; }
    }
}
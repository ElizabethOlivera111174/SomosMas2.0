﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.Entities
{
    public class Member : EntityBase
    {

        [Required(ErrorMessage = "El nombre es requerido")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string FacebookUrl { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string InstagramUrl { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string LinkedinUrl { get; set; }

        [Required(ErrorMessage = "La imagen es requerida")]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Image { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Description { get; set; }
    }
}

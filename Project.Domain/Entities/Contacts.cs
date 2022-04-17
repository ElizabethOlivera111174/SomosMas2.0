﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain.Entities
{
    public class Contacts : EntityBase
    {
        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "INTEGER")]
        [MaxLength(20)]
        public int Phone { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(320)")]
        [MaxLength(320)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "TEXT")]
        [MaxLength(500)]
        public string Message { get; set; }

    }
}


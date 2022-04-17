using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Project.Domain.DTOs.NewsDTOs
{
    public class NewsInsertDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public IFormFile Image { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}

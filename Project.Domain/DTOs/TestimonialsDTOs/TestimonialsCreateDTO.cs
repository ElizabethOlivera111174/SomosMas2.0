using Microsoft.AspNetCore.Http;

namespace Project.Domain.DTOs.TestimonialsDTOs
{
    public class TestimonialsCreateDTO
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public IFormFile Imagen { get; set; }
    }
}

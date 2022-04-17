using Microsoft.AspNetCore.Http;

namespace Project.Domain.DTOs.TestimonialsDTOs
{
    public class TestimonialsUpdateDTO
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public IFormFile Imagen { get; set; }
    }
}

using Microsoft.AspNetCore.Http;

namespace Project.Domain.DTOs.NewsDTOs
{
    public class NewsUpdateDTO
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
        public int CategoryId { get; set; }
    }
}

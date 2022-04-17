using Microsoft.AspNetCore.Http;

namespace Project.Domain.DTOs.SidlesDTOs
{
    public class UpdateSlideDTO
    {
        public IFormFile ImageUrl { get; set; }
        public int Order { get; set; }
        public string Text { get; set; }
        public int OrganizationId { get; set; }
    }
}

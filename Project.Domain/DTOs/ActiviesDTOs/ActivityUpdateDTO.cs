using Microsoft.AspNetCore.Http;

namespace Project.Domain.DTOs.ActivitiesDTOs
{
    public class ActivityUpdateDTO
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
    }
}

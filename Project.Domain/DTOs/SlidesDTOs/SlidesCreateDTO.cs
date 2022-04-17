namespace Project.Domain.DTOs.SidlesDTOs
{
    public class SlidesCreateDTO
    {
        public string ImageUrl { get; set; }
        public int Order { get; set; }
        public string Text { get; set; }
        public int OrganizationId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Name { get; set; }
    }
}

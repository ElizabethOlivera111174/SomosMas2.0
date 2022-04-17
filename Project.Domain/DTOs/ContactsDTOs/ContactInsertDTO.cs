using System.ComponentModel.DataAnnotations;
namespace Project.Domain.DTOs.ContactsDTOs
{
    public class ContactInsertDTO
    {
        [Required]
        public string Name { get; set; }
        public int Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
    }
}

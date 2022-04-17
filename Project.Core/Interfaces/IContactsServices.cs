using Project.Domain.DTOs.ContactsDTOs;
using Project.Domain.Helpers.Commons;
using Project.Domain.Helpers.Pagination;

namespace Project.Core.Interfaces
{
    public interface IContactsServices
    {
        Task<Result> Insert(ContactInsertDTO contactInsertDTO);
        Task<PaginationDTO<ContactDTO>> GetByPage(string route, int page);
        Task<ContactDTO> GetById(int id);
        bool EntityExists(int id);
    }
}

using Project.Domain.DTOs.NewsDTOs;
using Project.Domain.Helpers.Commons;
using Project.Domain.Helpers.Pagination;

namespace Project.Core.Interfaces
{
    public interface INewsServices
    {
        Task<NewsDTO> GetById(int id);

        bool EntityExists(int id);
        Task<Result> Insert(NewsInsertDTO newsInsertDTO);

        Task<Result> Delete(int id);
        Task<Result> Update(NewsUpdateDTO newsUpdateDTO, int id);
        Task<PaginationDTO<NewsDTO>> GetByPage(string route, int page);
    }
}

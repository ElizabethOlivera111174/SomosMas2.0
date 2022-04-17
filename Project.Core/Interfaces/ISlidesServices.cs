using Project.Domain.DTOs.SidlesDTOs;
using Project.Domain.Helpers.Commons;

namespace Project.Core.Interfaces
{
    public interface ISlidesServices
    {
        Task<Result> Insert(SlidesCreateDTO slidesCreateDTO);
        Task<Result> Delete(int id);
        Task<IEnumerable<SlidesDTO>> GetAll();
        Task<List<SlidesPublicDTO>> GetAllPublic();
        Task<SlidesDTO> GetById(int id);
        bool EntityExist(int id);
        Task<Result> Update(int id, UpdateSlideDTO updateSlideDTO);
    }
}

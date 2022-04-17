using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Domain.DTOs.CategoriesDTOs;
using Project.Domain.Entities;
using Project.Domain.Helpers.Commons;
using Project.Domain.Helpers.Pagination;

namespace Project.Core.Interfaces
{
    public interface ICategoriesServices
    {

        Task<CategoryDTO> GetById(int id);
        bool EntityExist(int id);
        Task<IEnumerable<CategoryNameDTO>> GetAll();
        Task<PaginationDTO<CategoryDTO>> GetByPage(string route,int page);
        Task<Category> Post(CategoryDTO categoryDTO);
        Task<Result> Update(int id, UpdateCategoryDTO updateCategoryDTO);
        Task<Result> Delete(int id);
    }
}

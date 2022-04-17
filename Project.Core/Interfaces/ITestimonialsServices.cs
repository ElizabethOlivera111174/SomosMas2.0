using Project.Domain.DTOs.TestimonialsDTOs;
using Project.Domain.Helpers.Commons;
using Project.Domain.Helpers.Pagination;

namespace Project.Core.Interfaces
{
    public interface ITestimonialsServices
    {
        Task<Result> Insert(TestimonialsCreateDTO testimonialsDTO);
        Task<Result> Delete(int id);
        Task<Result> Update(int id, TestimonialsUpdateDTO testimonialsUpdateDTO); 
        Task<PaginationDTO<TestimonialsDTO>> GetByPage(string route, int page);
    }
}

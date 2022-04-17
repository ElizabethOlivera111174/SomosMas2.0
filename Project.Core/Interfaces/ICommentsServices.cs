using Project.Domain.DTOs.CommentsDTOs;
using Project.Domain.DTOs.NewCommentsDTOs;
using Project.Domain.Helpers.Commons;
using Project.Domain.Helpers.Pagination;
using System.Security.Claims;

namespace Project.Core.Interfaces
{
    public interface ICommentsServices
    {
        Task<IEnumerable<CommentsDTO>> GetAll();
        Task<PaginationDTO<CommentsDTO>> GetByPage(string route,int page);
        Task<IEnumerable<CommentsDTO>> GetById(int id);
        bool EntityExists(int id);
        Task<NewCommentsDTO> Insert(NewCommentsDTO newCommentsDTO);
        Task<Result> Delete(int id);
        Task<bool> ValidateCreatorOrAdmin(ClaimsPrincipal user, int id);
        Task<Result> Update(int id, CommentUpdateDTO CommentUpdateDTO);
    }
}

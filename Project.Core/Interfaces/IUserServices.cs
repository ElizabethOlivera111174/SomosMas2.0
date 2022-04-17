using Project.Domain.DTOs.UserDTOs;
using Project.Domain.Entities;
using Project.Domain.Helpers.Commons;
namespace Project.Core.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<UserDTO>> GetAll();
        Task<Result> Register(UserInsertDTO userInsertDTO);
        Task<User> GetByEmail(string email);
        int GetUserId(string token);
        Task<UserInfoDTO> GetById(int userId);
        Task<Result> Delete(string token );
        Task<Result> Update(UserUpdateDTO userUpdateDTO,string token);
    }
}
using Project.Domain.DTOs.MembersDTOs;
using Project.Domain.Entities;
using Project.Domain.Helpers.Commons;
using Project.Domain.Helpers.Pagination;

namespace Project.Core.Interfaces
{
    public interface IMemberServices
    {
        Task<IEnumerable<MembersDTO>> GetAll();
        Task<Member> Insert(MemberInsertDTO membersInsertarDTO);
        Task<PaginationDTO<MembersDTO>> GetByPage(string route,int page);
        Task<Result> Delete(int id);
        Task<Result> Update(MemberUpdateDTO memberUpdateDTO);

    }
}

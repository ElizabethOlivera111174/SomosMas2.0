using Project.Domain.DTOs.OrganizationsDTOs;
using Project.Domain.Helpers.Commons;

namespace Project.Core.Interfaces
{
    public interface IOrganizationsServices
    {
        Task<OrganizationsDTO> Get();
        Task <Result> Update(OrganizationUpdateDTO organizationUpdateDTO);
    }
}

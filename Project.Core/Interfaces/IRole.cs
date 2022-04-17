using Project.Domain.Entities;

namespace Project.Core.Interfaces
{
    public interface IRoleServices
    {
        Task<Role> GetById(int id);
    }
}

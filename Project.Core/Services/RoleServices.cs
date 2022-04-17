using Project.Core.Interfaces;
using Project.Domain.Entities;
using Project.Infrastucture.UnitOfWork;

namespace Project.Core.Services
{
    public class RoleServices : IRoleServices
    {
        private readonly UnitOfWork _unitOfWork;
        public RoleServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Role> GetById(int id)
        {
            return await _unitOfWork.RoleRepository.GetById(id);
        }

    }
}

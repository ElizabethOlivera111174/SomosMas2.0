using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Domain.DTOs.ActivitiesDTOs;
using Project.Domain.Helpers.Commons;

namespace Project.Core.Interfaces
{
    public interface IActivitiesServices
    {
        Task<IEnumerable<ActivitiesDTO>> GetAll();
        Task<ActivitiesDTO> GetById(int id);
        bool EntityExists(int id);
        Task<Result> Insert(ActivitiyInsertDTO activitiyInsertDTO);
        Task<Result> Update(ActivityUpdateDTO activityUpdateDTO,int id);
    }
}

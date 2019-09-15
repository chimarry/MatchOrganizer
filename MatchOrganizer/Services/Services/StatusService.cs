using Database;
using Database.Entities;
using Services.DTO;
using Services.Helpers;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class StatusService : IStatusService
    {
        private readonly IServiceExecutor<StatusDTO, Status> _serviceExecutor;


        public StatusService(IServiceExecutor<StatusDTO, Status> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;

        }

        public Task Add(StatusDTO dto)
        {
            return _serviceExecutor.TryAdding(dto, x => x.Name != dto.Name && x.NotActive == false);
        }

        public async Task Delete(int id)
        {
            Status dbStatus = await _serviceExecutor.GetSingleOrDefault(x => x.StatusId == id && x.NotActive == false);
            await _serviceExecutor.TryDeleting(dbStatus);
        }

        public async Task<IList<StatusDTO>> GetAll()
        {
            return await _serviceExecutor.TryGettingAll(x => x.NotActive == false);
        }


        public Task<IList<StatusDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public Task Update(StatusDTO dto)
        {
            return _serviceExecutor.TryUpdating(dto, x => x.StatusId == dto.StatusId && x.NotActive == false);
        }

        public async Task<StatusDTO> GetById(int id)
        {
            return await _serviceExecutor.TryGettingOne(x => x.StatusId == id && x.NotActive == false);
        }
    }
}

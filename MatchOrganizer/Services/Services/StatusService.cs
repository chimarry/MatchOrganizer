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

        public async Task<ErrorHandling.Status> Add(StatusDTO dto)
        {
            return await _serviceExecutor.Add(dto, x => x.Name != dto.Name && x.NotActive == false);
        }

        public async Task<ErrorHandling.Status> Delete(int id)
        {
            Database.Entities.Status dbStatus = await _serviceExecutor.GetSingleOrDefault(x => x.StatusId == id && x.NotActive == false);
            return await _serviceExecutor.Delete(dbStatus);
        }

        public async Task<List<StatusDTO>> GetAll()
        {
            return await _serviceExecutor.GetAll(x => x.NotActive == false);
        }


        public Task<List<StatusDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public async Task<ErrorHandling.Status> Update(StatusDTO dto)
        {
            return await _serviceExecutor.Update(dto, x => x.StatusId == dto.StatusId && x.NotActive == false);
        }

        public async Task<StatusDTO> GetById(int id)
        {
            return await _serviceExecutor.GetOne(x => x.StatusId == id && x.NotActive == false);
        }
    }
}

using Database.Entities;
using Services.DTO;
using Services.ErrorHandling;
using Services.Helpers;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{

    public class PlayerStatisticService : IPlayerStatisticsService
    {
        private readonly IServiceExecutor<PlayerDTO, Player> _serviceExecutor;

        public Task<ErrorHandling.Status> Add(PlayerStatisticsDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<ErrorHandling.Status> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PlayerStatisticsDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PlayerStatisticsDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PlayerStatisticsDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public Task<ErrorHandling.Status> Update(PlayerStatisticsDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}

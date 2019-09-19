using Database;
using Database.Entities;
using Services.DTO;
using Services.Helpers;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Status = Services.ErrorHandling.Status;

namespace Services.Services
{

    public class MatchService : IMatchService
    {

        private readonly IServiceExecutor<MatchDTO, Match> _serviceExecutor;

        public MatchService(IServiceExecutor<MatchDTO, Match> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;
        }

        public async Task<Status> Add(MatchDTO dto)
        {
            return await _serviceExecutor.Add(dto, x => x.HostTeamId != dto.HostTeamId && x.GuestTeamId != dto.GuestTeamId && x.StartTime != dto.StartTime);
        }

        public async Task<Status> Delete(int id)
        {
            Match dbMatch = await _serviceExecutor.GetSingleOrDefault(x => x.MatchId == id && x.NotActive == false);
            dbMatch.NotActive = true;
            return await _serviceExecutor.Delete(dbMatch);
        }

        public Task<List<MatchDTO>> GetAll()
        {
            return _serviceExecutor.GetAll(x => x.NotActive == false);
        }

        public async Task<MatchDTO> GetById(int id)
        {
            return await _serviceExecutor.GetOne(x => x.MatchId == id && x.NotActive == false);
        }

        public async Task<List<MatchDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public async Task<Status> Update(MatchDTO dto)
        {
            return await _serviceExecutor.Update(dto, x => x.MatchId == dto.MatchId && x.NotActive == false);
        }
    }
}

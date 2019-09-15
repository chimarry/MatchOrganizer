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

    public class MatchService : IMatchService
    {

       
        private readonly IServiceExecutor<MatchDTO, Match> _serviceExecutor;

        public MatchService(IServiceExecutor<MatchDTO, Match> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;
        }

        public Task Add(MatchDTO dto)
        {
            return _serviceExecutor.TryAdding(dto, x => x.HostTeamId != dto.HostTeamId && x.GuestTeamId != dto.GuestTeamId && x.StartTime != dto.StartTime);
        }

        public async Task Delete(int id)
        {
            Match dbMatch = await _serviceExecutor.GetSingleOrDefault(x => x.MatchId == id && x.NotActive == false);
            dbMatch.NotActive = true;
            await _serviceExecutor.TryDeleting(dbMatch);
        }

        public Task<IList<MatchDTO>> GetAll()
        {
            return _serviceExecutor.TryGettingAll(x => x.NotActive == false);
        }

        public Task<MatchDTO> GetById(int id)
        {
            return _serviceExecutor.TryGettingOne(x => x.MatchId == id && x.NotActive == false);
        }

        public Task<IList<MatchDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public Task Update(MatchDTO dto)
        {
            return _serviceExecutor.TryUpdating(dto, x => x.MatchId == dto.MatchId && x.NotActive == false);
        }
    }
}

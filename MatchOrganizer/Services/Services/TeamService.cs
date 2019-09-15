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
    public class TeamService : ITeamService
    {
        private readonly IServiceExecutor<TeamDTO, Team> _serviceExecutor;

        public TeamService(IServiceExecutor<TeamDTO, Team> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;
        }

        public Task Add(TeamDTO dto)
        {
            return _serviceExecutor.TryAdding(dto, x => x.Name != dto.Name && x.NotActive == false);
        }

        public async Task Delete(int id)
        {
            Team dbTeam = await _serviceExecutor.GetSingleOrDefault(x => x.TeamId == id && x.NotActive == false);
            dbTeam.NotActive = true;
            await _serviceExecutor.TryDeleting(dbTeam);
        }

        public Task<IList<TeamDTO>> GetAll()
        {
            return _serviceExecutor.TryGettingAll(x => x.NotActive == false);
        }

        public async Task<TeamDTO> GetById(int id)
        {
            return await _serviceExecutor.TryGettingOne(x => x.TeamId == id && x.NotActive == false);
        }

        public Task<IList<TeamDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public Task Update(TeamDTO dto)
        {
            return _serviceExecutor.TryUpdating(dto, x => x.TeamId == dto.TeamId && x.NotActive == false);
        }
    }
}

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
    public class TeamService : ITeamService
    {
        private readonly IServiceExecutor<TeamDTO, Team> _serviceExecutor;

        public TeamService(IServiceExecutor<TeamDTO, Team> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;
        }

        public async Task<Status> Add(TeamDTO dto)
        {
            return await _serviceExecutor.Add(dto, x => x.Name == dto.Name && x.NotActive == false);
        }

        public async Task<Status> Delete(int id)
        {
            Team dbTeam = await _serviceExecutor.GetSingleOrDefault(x => x.TeamId == id && x.NotActive == false);
            dbTeam.NotActive = true;
            return await _serviceExecutor.Delete(dbTeam);
        }

        public Task<List<TeamDTO>> GetAll()
        {
            return _serviceExecutor.GetAll(x => x.NotActive == false);
        }

        public async Task<TeamDTO> GetById(int id)
        {
            return await _serviceExecutor.GetOne(x => x.TeamId == id && x.NotActive == false);
        }

        public Task<List<TeamDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public async Task<Status> Update(TeamDTO dto)
        {
            return await _serviceExecutor.Update(dto, x => x.TeamId == dto.TeamId && x.NotActive == false);
        }
    }
}

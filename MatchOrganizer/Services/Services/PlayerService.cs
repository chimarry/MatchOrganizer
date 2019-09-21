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
    public class PlayerService : IPlayerService
    {

        private readonly IServiceExecutor<PlayerDTO, Player> _serviceExecutor;


        public PlayerService(IServiceExecutor<PlayerDTO, Player> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;
        }


        public async Task<Status> Add(PlayerDTO dto)
        {
            return await _serviceExecutor.Add(dto, x => x.FullName == dto.FullName && x.NotActive == false);
        }

        public async Task<Status> Delete(int id)
        {
            var dbPlayer = await _serviceExecutor.GetSingleOrDefault((x => x.PlayerId == id && x.NotActive == false));
            dbPlayer.NotActive = true;
            return await _serviceExecutor.Delete(dbPlayer);
        }

        public async Task<List<PlayerDTO>> GetAll()
        {
            return await _serviceExecutor.GetAll(x => x.NotActive == false);
        }

        public async Task<List<PlayerDTO>> GetAllInTeam(int teamId)
        {
            return await _serviceExecutor.GetAll(x => x.TeamId == teamId && x.NotActive == false);
        }
        public async Task<int> GetNoPlayersInTeam(int teamId)
        {
            return (await GetAllInTeam(teamId)).Count;
        }
        public async Task<PlayerDTO> GetById(int id)
        {
            return await _serviceExecutor.GetOne(x => x.PlayerId == id && x.NotActive == false);
        }

        public Task<List<PlayerDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public async Task<Status> Update(PlayerDTO dto)
        {
            return await _serviceExecutor.Update(dto, x => x.PlayerId == dto.PlayerId && x.NotActive == false);
        }
    }
}

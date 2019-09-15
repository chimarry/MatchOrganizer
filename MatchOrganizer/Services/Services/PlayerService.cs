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
    public class PlayerService : IPlayerService
    {
     
        private readonly IServiceExecutor<PlayerDTO, Player> _serviceExecutor;


        public PlayerService( IServiceExecutor<PlayerDTO, Player> serviceExecutor)
        {
            _serviceExecutor = serviceExecutor;
        }

        public Task Add(PlayerDTO dto)
        {
            return _serviceExecutor.TryAdding(dto, x => x.FullName != dto.FullName && x.NotActive == false);
        }

        public async Task Delete(int id)
        {
            var dbPlayer = await _serviceExecutor.GetSingleOrDefault((x => x.PlayerId == id && x.NotActive == false));
            dbPlayer.NotActive = true;
            await _serviceExecutor.TryDeleting(dbPlayer);
        }

        public async Task<IList<PlayerDTO>> GetAll()
        {
            return await _serviceExecutor.TryGettingAll(x => x.NotActive == false);
        }

        public async Task<PlayerDTO> GetById(int id)
        {
            return await _serviceExecutor.TryGettingOne(x => x.PlayerId == id && x.NotActive == false);
        }

        public Task<IList<PlayerDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public Task Update(PlayerDTO dto)
        {
            return _serviceExecutor.TryUpdating(dto, x => x.PlayerId == dto.PlayerId && x.NotActive == false);
        }
    }
}

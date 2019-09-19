using Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPlayerService : IServiceTemplate<PlayerDTO>
    {
        Task<List<PlayerDTO>> GetAllInTeam(int teamId);
        Task<int> GetNoPlayersInTeam(int teamId);
    }
}

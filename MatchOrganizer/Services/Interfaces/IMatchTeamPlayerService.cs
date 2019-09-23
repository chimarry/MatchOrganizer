using Services.DTO;
using Services.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IMatchTeamPlayerService : IServiceTemplate<MatchTeamPlayerDTO>
    {
        Task<Status> AddGoal(int playerId, int matchId, int teamId);
        Task<List<MatchTeamPlayerDTO>> GetAll(int matchId, int teamId);
        Task<List<PlayerDTO>> GetPlayersForTeam(int matchId, int teamId);

    }
}

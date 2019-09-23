using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Services.AutoMapper;
using Services.DTO;
using Services.ErrorHandling;
using Services.Helpers;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class MatchTeamPlayerService : IMatchTeamPlayerService
    {

        private readonly IServiceExecutor<MatchTeamPlayerDTO, MatchTeamPlayer> _serviceExecutor;
        private readonly MatchOrganizerContext _context;

        public MatchTeamPlayerService(IServiceExecutor<MatchTeamPlayerDTO, MatchTeamPlayer> serviceExecutor, MatchOrganizerContext context)
        {
            _serviceExecutor = serviceExecutor;
            _context = context;
        }

        public async Task<Status> Add(MatchTeamPlayerDTO dto)
        {
            return await _serviceExecutor.Add(dto, x => x.PlayerId == dto.PlayerId && x.TeamId == dto.TeamId && x.MatchId == dto.MatchId);
        }


        public async Task<Status> Update(MatchTeamPlayerDTO dto)
        {
            return await _serviceExecutor.Update(dto, x => x.MatchId == dto.MatchId && x.PlayerId == dto.PlayerId && x.TeamId == dto.TeamId);
        }
        public async Task<Status> AddGoal(int playerId, int matchId, int teamId)
        {

            MatchTeamPlayer dbMatchTeamPlayer = await _serviceExecutor.GetSingleOrDefault(x => x.PlayerId == playerId && x.MatchId == matchId && x.TeamId == teamId);
            if (dbMatchTeamPlayer == null)
            {
                return Status.NotFound;
            }
            MatchTeamPlayerDTO matchTeamPlayer = Mapping.Mapper.Map<MatchTeamPlayerDTO>(dbMatchTeamPlayer);
            ++matchTeamPlayer.Score;
            return await _serviceExecutor.Update(matchTeamPlayer, x => x.MatchId == matchId && x.PlayerId == playerId && x.TeamId == teamId);

        }
        public async Task<List<PlayerDTO>> GetPlayersForTeam(int matchId, int teamId)
        {
            //it is better to use procedure

            List<int> playersMatchTeams = await _context.MatchTeamPlayers.Where(x => x.MatchId == matchId && x.TeamId == teamId).Select(x => x.PlayerId).ToListAsync();
            List<Player> players = await _context.Players.Where(x => playersMatchTeams.Contains(x.PlayerId)).ToListAsync();
            return Mapping.Mapper.Map<List<Player>, List<PlayerDTO>>(players);
        }

        public Task<List<MatchTeamPlayerDTO>> GetAll(int matchId, int teamId)
        {
            throw new NotImplementedException();
        }
        #region NotImplemented

        public Task<Status> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MatchTeamPlayerDTO>> GetAll()
        {
            return await _serviceExecutor.GetAll(x => true);
        }

        public Task<MatchTeamPlayerDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MatchTeamPlayerDTO>> GetRange(int startPosition, int numberOfItems)
        {
            throw new NotImplementedException();
        }



        #endregion

    }
}

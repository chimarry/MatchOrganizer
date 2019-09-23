using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;
using Services.Services;
using System.Threading;
using AutoMapper;
using MatchOrganizerAPI.Model;
using MatchOrganizerAPI.Automapper;

namespace MatchOrganizerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMatchService _matchService;
        private readonly ITeamService _teamService;
        private readonly IPlayerService _playerService;
        private readonly IMatchTeamPlayerService _matchTeamPlayerService;

        public MatchController(IMatchService matchService, ITeamService teamService, IPlayerService playerService, IMatchTeamPlayerService matchTeamPlayerService)
        {
            _matchService = matchService;
            _teamService = teamService;
            _playerService = playerService;
            _matchTeamPlayerService = matchTeamPlayerService;
        }


        [HttpGet("matches")]
        public async Task<ActionResult<IEnumerable<MatchModel>>> Matches()
        {
            List<MatchDTO> matchesBasicInfo = await _matchService.GetAll();
            List<MatchModel> matchModels = new List<MatchModel>();
            foreach (MatchDTO match in matchesBasicInfo)
            {
                MatchModel model = Mapping.Mapper.Map<MatchModel>(match);
                model.HostTeam = Mapping.Mapper.Map<TeamModel>(await _teamService.GetById(match.HostTeamId));
                model.GuestTeam = Mapping.Mapper.Map<TeamModel>(await _teamService.GetById(match.GuestTeamId));
                model.HostTeam.Players = Mapping.Mapper.Map<List<PlayerDTO>, List<PlayerModel>>(await _playerService.GetAllInTeam(match.HostTeamId));
                model.GuestTeam.Players = Mapping.Mapper.Map<List<PlayerDTO>, List<PlayerModel>>(await _playerService.GetAllInTeam(match.GuestTeamId));
                model.HostTeamPlayers = Mapping.Mapper.Map<List<PlayerDTO>, List<PlayerModel>>(await _matchTeamPlayerService.GetPlayersForTeam(match.MatchId, match.HostTeamId));
                model.GuestTeamPlayers = Mapping.Mapper.Map<List<PlayerDTO>, List<PlayerModel>>(await _matchTeamPlayerService.GetPlayersForTeam(match.MatchId, match.GuestTeamId));

                matchModels.Add(model);
            }
            return matchModels;
        }

    }
}

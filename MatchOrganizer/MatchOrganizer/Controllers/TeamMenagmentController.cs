using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchOrganizer.Automapper;
using MatchOrganizer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.Interfaces;

namespace MatchOrganizer.Controllers
{
    public class TeamMenagmentController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IPlayerService _playerService;


        public TeamMenagmentController(ITeamService teamService, IPlayerService playerService)
        {
            _teamService = teamService;
            _playerService = playerService;
        }

        public async Task<IActionResult> Index()
        {

            List<TeamDTO> teams = await _teamService.GetAll();
            List<TeamViewModel> teamsToRender = Mapping.Mapper.Map<List<TeamDTO>, List<TeamViewModel>>(teams);
            teamsToRender.ForEach(async team => team.NoPlayers = await _playerService.GetNoPlayersInTeam(team.TeamId));

            return await Task.Run(() => View(teamsToRender));

        }
        public async Task<IActionResult> Details(int? id)
        {
            TeamDTO team = await _teamService.GetById(id.Value);
            List<PlayerDTO> players = await _playerService.GetAllInTeam(id.Value);

            TeamDetailsViewModel detailsToShow = Mapping.Mapper.Map<TeamDetailsViewModel>(team);
            detailsToShow.Players = Mapping.Mapper.Map<List<PlayerDTO>, List<PlayerViewModel>>(players);
            return View(detailsToShow);
        }
   
    }
}
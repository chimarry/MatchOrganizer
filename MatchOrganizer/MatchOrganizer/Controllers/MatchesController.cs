using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MatchOrganizer.Automapper;
using MatchOrganizer.ViewModels;
using MatchOrganizer.ViewModels.Matches;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;

using Services.DTO;
using Services.ErrorHandling;
using Services.Interfaces;

namespace MatchOrganizer.Controllers
{
    public class MatchesController : Controller
    {
        private readonly IMatchService _matchService;
        private readonly IPlayerService _playerService;
        private readonly ITeamService _teamService;
        private readonly IMatchTeamPlayerService _matchTeamPlayerService;

        public MatchesController(IMatchService matchService, IPlayerService playerService, ITeamService teamService, IMatchTeamPlayerService matchTeamPlayerService)
        {
            _matchService = matchService;
            _playerService = playerService;
            _teamService = teamService;
            _matchTeamPlayerService = matchTeamPlayerService;
        }

        public async Task<IActionResult> Index()
        {
            List<MatchDTO> matchDetailsDTOs = await _matchService.GetAll();
            List<IndexMatchViewModel> matchesToRender = Mapping.Mapper.Map<List<MatchDTO>, List<IndexMatchViewModel>>(matchDetailsDTOs);
            foreach (IndexMatchViewModel model in matchesToRender)
            {
                model.GuestTeamName = (await _teamService.GetById(model.GuestTeamId)).Name;
                model.HostTeamName = (await _teamService.GetById(model.HostTeamId)).Name;
            }
            return View(matchesToRender);
        }
        public async Task<IActionResult> Create()
        {
            CreateMatchViewModel model = new CreateMatchViewModel();
            List<TeamDTO> teams = await _teamService.GetAll();

            ViewBag.HostTeams = CreateViewBagTeams(teams);
            ViewBag.GuestTeams = CreateViewBagTeams(teams);
            return View(model);
        }


        [HttpGet]
        public async Task<JsonResult> GetPlayerList(int TeamId)
        {
            var citylist = new SelectList(await _playerService.GetAllInTeam(TeamId), "PlayerId", "FullName");
            return Json(citylist);

        }

        [HttpPost]
        public async Task<IActionResult> Save(CreateMatchViewModel model)
        {
            if (!ModelState.IsValid)
            {
                List<TeamDTO> teams = await _teamService.GetAll();
                ViewBag.HostTeams = CreateViewBagTeams(teams);
                ViewBag.GuestTeams = CreateViewBagTeams(teams);
                return View("Create", model);
            }

            MatchDTO addedMatch = await SaveMatch(model);
            if (addedMatch.MatchId != 0)
            {
                List<MatchTeamPlayerDTO> playersInMatch = new List<MatchTeamPlayerDTO>();
                Status addingHostPlayersStatus = await SavePlayers(model.HostPlayerList, model.HostTeamId, addedMatch.MatchId);
                Status addingGuestPlayersStatus = await SavePlayers(model.GuestPlayerList, model.GuestTeamId, addedMatch.MatchId);

                return RedirectToAction("Index");
            }
            //already exists so adding resulted in null
            return View("Create", model);
        }

        #region NonActionPrivateMethods
        [NonAction]
        private async Task<MatchDTO> SaveMatch(CreateMatchViewModel model)
        {
            MatchDTO matchBasic = Mapping.Mapper.Map<MatchDTO>(model);
            Status addingMatchStatus = await _matchService.Add(matchBasic);
            if (addingMatchStatus == Status.Success)
                matchBasic = await _matchService.GetByUniqueIdentifiers(model.HostTeamId, model.GuestTeamId, model.StartTime);
            return matchBasic;

        }

        [NonAction]
        private async Task<Status> SavePlayers(List<int> players, int idTeam, int idMatch)
        {
            Status addingStatus = Status.Success;
            foreach (int playerId in players)
            {
                MatchTeamPlayerDTO relationship = new MatchTeamPlayerDTO()
                {
                    MatchId = idMatch,
                    TeamId = idTeam,
                    PlayerId = playerId
                };
                addingStatus = await _matchTeamPlayerService.Add(relationship);
            }
            return addingStatus;

        }


        [NonAction]
        private List<SelectListItem> CreateViewBagTeams(List<TeamDTO> teams)
        {
            List<TeamListItemViewModel> dbTeams = Mapping.Mapper.Map<List<TeamDTO>, List<TeamListItemViewModel>>(teams);
            List<SelectListItem> teamsItems = new List<SelectListItem>();
            foreach (TeamListItemViewModel team in dbTeams)
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = team.Name,
                    Value = team.TeamId.ToString()
                };
                teamsItems.Add(item);
            }
            return teamsItems;
        }
        #endregion
    }
}
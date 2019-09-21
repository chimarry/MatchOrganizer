using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatchOrganizer.Automapper;
using MatchOrganizer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DTO;
using Services.ErrorHandling;
using Services.Interfaces;

namespace MatchOrganizer.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public IActionResult Create(int teamId)
        {
            return PartialView("_CreatePlayerPartial", new PlayerViewModel() { TeamId = teamId });
        }
        public async Task<IActionResult> Save(PlayerViewModel model)
        {
            PlayerDTO playerToAdd = Mapping.Mapper.Map<PlayerDTO>(model);
            Status addingStatus = await _playerService.Add(playerToAdd);
            return RedirectToAction("Details", "TeamMenagment", new { id = playerToAdd.TeamId });
        }
        public IActionResult ConfirmDelete(int playerId, int teamId)
        {
            return PartialView("_DeletePlayerPartial", new PlayerViewModel() { TeamId = teamId, PlayerId = playerId });
        }
        public async Task<IActionResult> Delete(PlayerViewModel player)
        {
            Status deletingStatus = await _playerService.Delete(player.PlayerId);
            return RedirectToAction("Details", "TeamMenagment", new { id = player.TeamId });
        }
    }
}
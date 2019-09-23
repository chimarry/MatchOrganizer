using Database;
using Database.Entities;
using Services.AutoMapper;
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

    public class MatchService : IMatchService
    {

        private readonly IServiceExecutor<MatchDTO, Match> _serviceExecutor;
        private readonly ITeamService _teamService;

        public MatchService(IServiceExecutor<MatchDTO, Match> serviceExecutor, ITeamService teamService)
        {
            _serviceExecutor = serviceExecutor;
            _teamService = teamService;
        }

        public async Task<Status> Add(MatchDTO dto)
        {

            return await _serviceExecutor.Add(dto, x =>
             ((x.HostTeamId == dto.HostTeamId || x.GuestTeamId == dto.GuestTeamId
             || x.HostTeamId == dto.GuestTeamId || x.GuestTeamId == dto.HostTeamId) && x.StartTime == dto.StartTime));
        }

        public async Task<Status> Delete(int id)
        {
            Match dbMatch = await _serviceExecutor.GetSingleOrDefault(x => x.MatchId == id && x.NotActive == false);
            dbMatch.NotActive = true;
            return await _serviceExecutor.Delete(dbMatch);
        }

        public Task<List<MatchDTO>> GetAll()
        {
            return _serviceExecutor.GetAll(x => x.NotActive == false);
        }


        public async Task<MatchDTO> GetById(int id)
        {
            return await _serviceExecutor.GetOne(x => x.MatchId == id && x.NotActive == false);
        }

        public async Task<List<MatchDTO>> GetRange(int startPosition, int numberOfItems)
        {
            return await _serviceExecutor.GetRange(startPosition, numberOfItems, x => x.NotActive == false);
        }



        public async Task<Status> Update(MatchDTO dto)
        {
            return await _serviceExecutor.Update(dto, x => x.MatchId == dto.MatchId && x.NotActive == false);
        }
        public async Task<MatchDetailsDTO> GetWithDetails(int matchId)
        {
            MatchDTO matchDTO = await _serviceExecutor.GetOne(x => x.MatchId == matchId);
            MatchDetailsDTO matchDetails = new MatchDetailsDTO()
            {
                Match = matchDTO,
                GuestTeamName = (await _teamService.GetById(matchDTO.GuestTeamId)).Name,
                HostTeamName = (await _teamService.GetById(matchDTO.HostTeamId)).Name,
                Score = matchDTO.HostScore + ":" + matchDTO.GuestScore,
            };
            return matchDetails;

        }
        public async Task<List<MatchDetailsDTO>> GetAllWithDetails()
        {
            List<MatchDTO> matchDTOs = await _serviceExecutor.GetAll(x => x.NotActive == false);
            List<MatchDetailsDTO> matchDetailsDTOs = new List<MatchDetailsDTO>();

            foreach (MatchDTO match in matchDTOs)
            {
                MatchDetailsDTO matchDetails = new MatchDetailsDTO()
                {
                    Match = match,
                    GuestTeamName = (await _teamService.GetById(match.GuestTeamId)).Name,
                    HostTeamName = (await _teamService.GetById(match.HostTeamId)).Name,
                    Score = match.HostScore + ":" + match.GuestScore,
                };
                matchDetailsDTOs.Add(matchDetails);
            }
            return matchDetailsDTOs;
        }
        public async Task<MatchDTO> GetByUniqueIdentifiers(int hostTeamId, int guestTeamId, DateTime startTime)
        {
            Match dbMatch = await _serviceExecutor.GetSingleOrDefault(x =>
            (x.HostTeamId == hostTeamId && x.GuestTeamId == guestTeamId)
            || (x.HostTeamId == guestTeamId && x.GuestTeamId == hostTeamId) && x.StartTime.Equals(startTime));
            return Mapping.Mapper.Map<MatchDTO>(dbMatch);
        }


    }
}
